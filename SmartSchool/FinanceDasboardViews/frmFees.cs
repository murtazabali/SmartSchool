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
    public partial class frmFees : Form
    {
        public frmFees()
        {
            InitializeComponent();        
        }

        private void frmFees_Load(object sender, EventArgs e)
        {
            FeeID();
            cb_Month();
            panelStudentDetails.Hide();
        }

        void FeeID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(fid) from fees";
            SqlCommand cmd = new SqlCommand(query, conn);
            int fid = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            txtfeeid.Text = fid.ToString();
            conn.Close();
        }

        void cb_Month()
        {
            string[] month = { "(Select Month)","January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            cbmonth.DataSource = month;
        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {
            if(txtstudentid.Text == "")
            {
                panelStudentDetails.Hide();
                lblStatus.Text = "";
            }
            else
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = String.Format("Select firstname,lastname,gender,bform,class,section from student where stdid = {0}", int.Parse(txtstudentid.Text));
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    lblStatus.Text = "";
                    while (reader.Read())
                    {
                        lblFirstname.Text = reader["firstname"].ToString();
                        lblLastName.Text = reader["lastname"].ToString();
                        lblGender.Text = reader["gender"].ToString();
                        lblBform.Text = reader["bform"].ToString();
                        lblClass.Text = reader["class"].ToString();
                        lblSection.Text = reader["section"].ToString();
                    }
                    conn.Close();
                    panelStudentDetails.Show();
                }
                else
                {
                    panelStudentDetails.Hide();
                    lblStatus.Text = "Student not found!";
                }
                
            }
        }

        private void nmFeeAmount_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nmtotal.Value = nmFeeAmount.Value - nmscholarship.Value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void nmscholarship_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nmtotal.Value = nmFeeAmount.Value - (nmFeeAmount.Value * (nmscholarship.Value / 100));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void nmpaidfees_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nmbalance.Value = nmtotal.Value - nmpaidfees.Value;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = String.Format("Select firstname from student where stdid = {0}", int.Parse(txtstudentid.Text));
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if(cbmonth.Text != "(Select Month)")
            {
                if (reader.HasRows)
                {
                    Insert_Fees();
                    MessageBox.Show("Bill Added!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Student not Found!");
                }
            }
            else
            {
                MessageBox.Show("Please Select Month!");
            }
           

       }

        void Insert_Fees()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();               
                SqlCommand cmd = new SqlCommand("SP_Insert_Fee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stdid",int.Parse(txtstudentid.Text));
                cmd.Parameters.AddWithValue("@month",cbmonth.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@duedate",dtdue.Value);
                cmd.Parameters.AddWithValue("@paydate",dtpaid.Value);
                cmd.Parameters.AddWithValue("@scholarship",nmscholarship.Value);
                cmd.Parameters.AddWithValue("@paidfees",nmpaidfees.Value);
                cmd.Parameters.AddWithValue("@balance",nmbalance.Value);
                cmd.Parameters.AddWithValue("@totalfees",nmtotal.Value);
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
            FeeID();
            cbmonth.ResetText(); ;
            txtstudentid.Text = null;
            dtdue.ResetText();
            dtpaid.ResetText();
            nmFeeAmount.ResetText();
            nmscholarship.ResetText();
            nmtotal.ResetText();
            nmpaidfees.ResetText();
            nmbalance.ResetText();
        }
    }
}
