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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            cb_Department();
            UserID();
        }

        private void cbDeptName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            SqlCommand cmd = new SqlCommand("SP_Read_Depid", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@deptName", cbDeptName.SelectedValue.ToString());
            tbDeptId.Text = cmd.ExecuteScalar().ToString();
            conn.Close();
        }

        void UserID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(userid) from Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            int userid = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            tbUserId.Text = userid.ToString();
            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Insert_User", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username",tbUsername.Text );
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@deptid", int.Parse(tbDeptId.Text));
                if (tbPassword.Text.Equals(tbConfirmPassword.Text))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Passwords Do Not Match!");
                    tbPassword.Text = null;
                    tbConfirmPassword.Text = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void cb_Department()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = "Select * from dept";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbDeptName.DataSource = dt;
            cbDeptName.ValueMember = "deptname";
            cbDeptName.Text = "(Select Department)";
        }
        void Clear()
        {
            UserID();
            cbDeptName.Text = "(Select Department)";
            tbDeptId.Text = null;
            tbUsername.Text = null;
            tbPassword.Text = null;
            tbConfirmPassword.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
