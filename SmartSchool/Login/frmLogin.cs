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
using SmartSchool.DataSets;
using SmartSchool.Reports;

namespace SmartSchool
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = String.Format("Select password,deptid from Users where username = '{0}'", txtusername.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr["password"].Equals(txtpassword.Text))
                        {
                            conn.Close();
                            query = String.Format("Select deptname from dept where deptid = (Select deptid from Users where username = '{0}')", txtusername.Text);
                            conn.Open();
                            cmd = new SqlCommand(query, conn);
                            dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                if (dr["deptname"].ToString() == cbDepartment.SelectedValue.ToString())
                                {
                                    if (cbDepartment.SelectedValue.ToString() == "Administrator")
                                    {
                                        frmAdminDashboard admin = new frmAdminDashboard();
                                        admin.Show();
                                        this.Hide();
                                    }
                                    if (cbDepartment.SelectedValue.ToString() == "Finance")
                                    {
                                        frmFinanceDashBoard finance = new frmFinanceDashBoard();
                                        finance.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter Correct Department!");
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Load_Cb_Department();
        }
        void Load_Cb_Department()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = "Select * from dept";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbDepartment.DataSource = dt;
            cbDepartment.ValueMember = "deptname";
            cbDepartment.Text = "(Select Department)";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
