using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchool
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
           
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {

            try {
                SalID();
                cb_Month();
                panelStaffDetails.Hide();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void SalID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select (max(salid)) from salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            int fid = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            txtsalaryid.Text = fid.ToString();
            conn.Close();
        }
        void cb_Month()
        {
            string[] month = { "(Select Month)", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            cbmonth.DataSource = month;
        }

        private void txtstaffid_TextChanged(object sender, EventArgs e)
        {
           if(txtstaffid.Text == "")
            {
                panelStaffDetails.Hide();
                lblStatus.Text = "";
            }
            else
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = String.Format("Select firstname,lastname,gender,contact,cnic,designation,subjectname from staffs where staffid = {0}", int.Parse(txtstaffid.Text));
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lblStatus.Text = "";
                    while (reader.Read())
                    {
                        if (reader["designation"].ToString() == "Faculty")
                        {
                            lblFirstname.Text = reader["firstname"].ToString();
                            lblLastname.Text = reader["lastname"].ToString();
                            lblGender.Text = reader["gender"].ToString();
                            lblContact.Text = reader["contact"].ToString();
                            lblCNIC.Text = reader["cnic"].ToString();
                            lblDesignation.Text = reader["designation"].ToString();
                            lblSubject.Text = reader["subjectname"].ToString();
                            lblSubjectheader.Show();
                        }
                        else
                        {
                            lblFirstname.Text = reader["firstname"].ToString();
                            lblLastname.Text = reader["lastname"].ToString();
                            lblGender.Text = reader["gender"].ToString();
                            lblContact.Text = reader["contact"].ToString();
                            lblCNIC.Text = reader["cnic"].ToString();
                            lblDesignation.Text = reader["designation"].ToString();
                            lblSubject.Text = null;
                            lblSubjectheader.Hide();
                        }
                       
                    }
                    conn.Close();
                    panelStaffDetails.Show();
                }
                else
                {
                    panelStaffDetails.Hide();
                    lblStatus.Text = "Staff not found!";
                }

            }
        }

        private void nmbasic_ValueChanged(object sender, EventArgs e)
        {
            txttotal.Text = (nmbasic.Value + nmbonus.Value).ToString();
        }

        private void nmbonus_ValueChanged(object sender, EventArgs e)
        {
            txttotal.Text = (nmbasic.Value + nmbonus.Value).ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = String.Format("Select firstname from staffs where staffid = {0}", int.Parse(txtstaffid.Text));
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (cbmonth.Text != "(Select Month)")
            {
                if (reader.HasRows)
                {
                    Insert_Salary();
                    MessageBox.Show("Salary Added!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Satff not Found!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Month!");
            }
        }

        void Insert_Salary()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Insert_Salary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staffid", int.Parse(txtstaffid.Text));
                cmd.Parameters.AddWithValue("@month", cbmonth.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@basicsalary", nmbasic.Value);
                cmd.Parameters.AddWithValue("@bonus", nmbonus.Value);
                cmd.Parameters.AddWithValue("@totalsalary", int.Parse(txttotal.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Clear()
        {
            SalID();
            cbmonth.ResetText();
            txtstaffid.Text = null;
            nmbasic.ResetText();
            nmbonus.ResetText();
            txttotal.Text = null;
        }
    }
}
