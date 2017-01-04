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
    public partial class frmViewFees : Form
    {
        public frmViewFees()
        {
            InitializeComponent();

        }


        private void frmViewFees_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Stdid();
            cb_Month();
        }


        void cb_Month()
        {
            string[] month = { "(Select Month)", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            cbMonth.DataSource = month;
        }

        void Load_ComboBox_Stdid()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from student";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchStudent.DataSource = dt;
            cbSearchStudent.ValueMember = "stdid";
            cbSearchStudent.Text = "(ID)";
            conn.Close();
        }

        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from fees";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvfee.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete  ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvfee.Rows.Count > 1 && gvfee.SelectedRows[0].Index != gvfee.Rows.Count - 1)
                {
                    string sql = "DELETE FROM fees WHERE fid =" + gvfee.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvfee.Rows.RemoveAt(gvfee.SelectedRows[0].Index);
                    MessageBox.Show("data has been Deleted");
                    Load_Gridview();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to update ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvfee.Rows.Count > 1 && gvfee.SelectedRows[0].Index != gvfee.Rows.Count - 1)
                {
                    string sql = "update fees set stdid = '" + gvfee.SelectedRows[0].Cells[1].Value.ToString() + "' , month = ('" + gvfee.SelectedRows[0].Cells[2].Value.ToString() + "') , duedate = ('" + gvfee.SelectedRows[0].Cells[3].Value.ToString() + "') , paydate = ('" + gvfee.SelectedRows[0].Cells[4].Value.ToString() + "') , scholarship = (" + gvfee.SelectedRows[0].Cells[5].Value.ToString() + ") , paidfees = (" + gvfee.SelectedRows[0].Cells[6].Value.ToString() + ") , balance = (" + gvfee.SelectedRows[0].Cells[7].Value.ToString() + ") , totalfees = (" + gvfee.SelectedRows[0].Cells[8].Value.ToString() + ") WHERE fid =" + gvfee.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("data has been updated");

                }

            }



        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            if (tbSearchStudentFname.Text != "")
            {
                if(cbMonth.SelectedValue.ToString() == "(Select Month)")
                {
                    String query = String.Format("select * from fees where stdid = ( select stdid from student where firstname like '%{0}%' and lastname like '%{1}%') ", tbSearchStudentFname.Text, tbSearchStudentLName.Text);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvfee.DataSource = dt;
                    conn.Close();
                    cbSearchStudent.ResetText();
                }
                else
                {
                    String query = String.Format("select * from fees where stdid = ( select stdid from student where firstname like '%{0}%' and lastname like '%{1}%') and month like '%{2}%' ", tbSearchStudentFname.Text, tbSearchStudentLName.Text,cbMonth.SelectedValue.ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvfee.DataSource = dt;
                    conn.Close();
                    cbSearchStudent.ResetText();
                }
                
            }
            else 
            {
                if(cbMonth.SelectedValue.ToString() == "(Select Month)")
                {
                    String query = String.Format("Select * from fees where stdid = {0}", cbSearchStudent.SelectedValue);
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvfee.DataSource = dt;
                    conn.Close();
                }
                else
                {
                    String query = String.Format("Select * from fees where stdid = {0} and month like '%{1}%'", cbSearchStudent.SelectedValue, cbMonth.SelectedValue.ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvfee.DataSource = dt;
                    conn.Close();
                }
                
            }
        }

        private void tbSearchStudentFname_TextChanged(object sender, EventArgs e)
        {
            cbSearchStudent.ResetText();
        }

        private void cbSearchStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchStudentFname.Clear();
            tbSearchStudentLName.Clear();
            cbMonth.ResetText();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchStudentFname.Clear();
            tbSearchStudentLName.Clear();
            cbMonth.ResetText();
            cbSearchStudent.ResetText();
        }
    }
}
