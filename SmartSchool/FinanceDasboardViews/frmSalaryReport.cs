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
using SmartSchool.ReportViews;
namespace SmartSchool
{
    public partial class frmSalaryReport : Form
    {
        public frmSalaryReport()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            gvsalReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from salary where staffid = " + comboID.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvsalReport.DataSource = dt;
            conn.Close();
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            cb_bonus();
            cb_Month();
            gvStaffInfo.Hide();
            // TODO: This line of code loads data into the 'sMSDataSet.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.sMSDataSet.salary);

        }

        void cb_Month()
        {
            string[] month = { "(Select Month)", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            comboMonth.DataSource = month;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvsalReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from salary where month = '" + comboMonth.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvsalReport.DataSource = dt;
            conn.Close();

        }
        void cb_bonus()
        {
            string[] bonus = { "(Select range)", "0 and 0", "1 and 4999", "5000 and 9999", "10000 and 14999", "15000 and 20000" };
            comboBonus.DataSource = bonus;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            gvsalReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from salary where bonus between " + comboBonus.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvsalReport.DataSource = dt;
            conn.Close();
        }
        void load_staffinfo()
        {

            try
            {
                string id = gvsalReport.SelectedRows[0].Cells[1].Value.ToString();

                gvStaffInfo.Show();
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select staffid , firstname , lastname , contact , address , designation from staffs where staffid = " + id + " ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvStaffInfo.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gvStaffInfo.Show();
                load_staffinfo();

            }
            else
            {
                gvStaffInfo.DataSource = null;
                gvStaffInfo.Hide();

            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmAllSalaryReport rp = new frmAllSalaryReport();
            rp.ShowDialog();
        }
    }
}
