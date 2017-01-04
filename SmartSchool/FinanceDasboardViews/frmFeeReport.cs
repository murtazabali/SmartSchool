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
    public partial class frmFeeReport : Form
    {
        public frmFeeReport()
        {
            InitializeComponent();
        }


        void load_feeBalancereport()
        {
            gvFeeReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from fees where balance > 0 ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeeReport.DataSource = dt;
            conn.Close();
        }


        void load_studinfo()
        {
            try
            {
                string id = gvFeeReport.SelectedRows[0].Cells[1].Value.ToString();

                gvStudentInfo.Show();
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select stdid , firstname , lastname , contact , address , class , section from student where stdid = " + id + " ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvStudentInfo.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {

            }
        }


        void cb_Month()
        {
            string[] month = { "(Select Month)", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            comboMonth.DataSource = month;
        }

        void cb_Scholarship()
        {
            string[] scholarship = { "(Select Percentage)", "0 and 0", "1 and 25", "26 and 50", "51 and 75", "76 and 100" };
            comboScholarShip.DataSource = scholarship;
        }




        private void cbBalanceFees_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBalanceFees.Checked)
            {
                load_feeBalancereport();

            }
            else
            {
                gvFeeReport.DataSource = null;
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                load_studinfo();
            }
            else
            {
                gvStudentInfo.Hide();

            }
        }


        private void frmFeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMSDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.sMSDataSet.student);
            gvStudentInfo.Hide();
            cb_Scholarship();
            cb_Month();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gvFeeReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from fees where month like '" + comboMonth.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeeReport.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            gvFeeReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from fees where stdid = " + comboID.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeeReport.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gvFeeReport.Show();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from fees where scholarship between " + comboScholarShip.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvFeeReport.DataSource = dt;
            conn.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                gvFeeReport.Show();
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select * from fees where  paydate > duedate";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvFeeReport.DataSource = dt;
                conn.Close();
            }
            else
            {
                gvFeeReport.DataSource = null;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmFeeRemainingReport fr = new frmFeeRemainingReport();
            fr.ShowDialog();
        }
    }
}
