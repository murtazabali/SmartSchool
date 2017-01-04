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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Cb_Designation();
            Cb_Subject();
            lblSubject.Hide();
            cbSubject.Hide();
            StaffID();
        }

        void Cb_Designation()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = "Select * from designation";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbDesignation.DataSource = dt;
            cbDesignation.ValueMember = "Desgname";
            cbDesignation.Text = "(Select Designation)";
        }

        void StaffID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(staffid) from staffs";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            tbStaffId.Text = (id.ToString());
            conn.Close();
        }


        void Cb_Subject()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = "Select * from subject";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSubject.DataSource = dt;
            cbSubject.ValueMember = "subjectname";
            cbSubject.Text = "(Select Subject)";
        }

        int desgid()
        {
            string designation = cbDesignation.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = String.Format("Select desgid from designation where Desgname = '{0}'", designation);          
            SqlCommand cmd = new SqlCommand(query, conn);
            int desgid = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return desgid;
        }

        int subjectid()
        {
                string subjectname = cbSubject.SelectedValue.ToString();
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = String.Format("Select subjectid from subject where subjectname = '{0}'", subjectname);
                SqlCommand cmd = new SqlCommand(query, conn);
                int subjectid = int.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                return subjectid;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Insert_Staff", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@staffid", int.Parse(tbStaffId.Text));
                cmd.Parameters.AddWithValue("@firstname", tbFirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", tbLastname.Text);
                cmd.Parameters.AddWithValue("@gender", tbGender.Text);
                cmd.Parameters.AddWithValue("@dob", dtStaffDob.Value);
                cmd.Parameters.AddWithValue("@placeofbirth", tbPlaceOfBirth.Text);
                cmd.Parameters.AddWithValue("@mothertongue", tbMotherTongue.Text);
                cmd.Parameters.AddWithValue("@nationality", tbNationality.Text);
                cmd.Parameters.AddWithValue("@contact", decimal.Parse(tbContact.Text));
                cmd.Parameters.AddWithValue("@address", tbAddress.Text);
                cmd.Parameters.AddWithValue("@dateofjoin", dtDateofJoin.Value);
                cmd.Parameters.AddWithValue("@cnic", decimal.Parse(tbCNIC.Text));
                cmd.Parameters.AddWithValue("@lastworked", tbLastWorkedPlace.Text);
                cmd.Parameters.AddWithValue("@previousexp", tbPreviousExp.Text);
                cmd.Parameters.AddWithValue("@designation", cbDesignation.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@desgid", desgid());
                if (cbDesignation.SelectedValue.ToString() == "Faculty")
                {
                    cmd.Parameters.AddWithValue("@subjectname", cbSubject.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@subjectid", subjectid());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@subjectname", "");
                    cmd.Parameters.AddWithValue("@subjectid", "");
                }             
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Staff Inserted!");
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void Clear()
        {
            tbStaffId.Text = null;
            tbFirstname.Text = null;
            tbLastname.Text = null;
            tbGender.Text = null;
            dtStaffDob.Text = null;
            tbMotherTongue.Text = null;
            tbNationality.Text = null;
            tbContact.Text = null;
            tbAddress.Text = null;
            dtDateofJoin.Text = null;
            tbPlaceOfBirth.Text = null;
            tbCNIC.Text = null;
            tbLastWorkedPlace.Text = null;
            tbPreviousExp.Text = null;
            Cb_Designation();
            Cb_Subject();
            cbSubject.Hide();
            lblSubject.Hide();
            StaffID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbDesignation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbDesignation.SelectedValue.ToString() == "Faculty")
            {
                lblSubject.Show();
                cbSubject.Show();
            }
            else
            {
                lblSubject.Hide();
                cbSubject.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
