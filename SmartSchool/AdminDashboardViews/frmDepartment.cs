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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }



        void deptID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(deptid) from dept";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            txtdeptid.Text = (id.ToString());
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                string sql = "insert into dept(deptid , deptname , location) values ( @deptid , @deptname , @location) ";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@deptid", txtdeptid.Text);
                cmd.Parameters.AddWithValue("@deptname", tbDeptName.Text);
                cmd.Parameters.AddWithValue("@location", txtdeptlocation.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                deptID();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            deptID();
        }
    }
}
