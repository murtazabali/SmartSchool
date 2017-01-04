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
    public partial class frmSalaryView : Form
    {
        public frmSalaryView()
        {
            InitializeComponent();
        }

        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvsalaryview.DataSource = dt;
            conn.Close();
        }

        private void frmSalaryView_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Salary();
        }
        void Load_ComboBox_Salary()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchSalary.DataSource = dt;
            cbSearchSalary.ValueMember = "salid";
            cbSearchSalary.Text = "(ID)";
            conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete ? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvsalaryview.Rows.Count > 1 && gvsalaryview.SelectedRows[0].Index != gvsalaryview.Rows.Count - 1)
                {
                    string sql = "DELETE FROM salary WHERE salid =" + gvsalaryview.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvsalaryview.Rows.RemoveAt(gvsalaryview.SelectedRows[0].Index);
                    MessageBox.Show("Salary deleted!");
                    Load_Gridview();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvsalaryview.Rows.Count > 1 && gvsalaryview.SelectedRows[0].Index != gvsalaryview.Rows.Count - 1)
                {
                    string sql = "update salary set staffid = '" + gvsalaryview.SelectedRows[0].Cells[1].Value.ToString() + "' , month = ('" + gvsalaryview.SelectedRows[0].Cells[2].Value.ToString() + "') , basicsalary = (" + gvsalaryview.SelectedRows[0].Cells[3].Value.ToString() + ") , bonus = (" + gvsalaryview.SelectedRows[0].Cells[5].Value.ToString() + ") , totalsalary = (" + gvsalaryview.SelectedRows[0].Cells[5].Value.ToString() + ")  WHERE salid =" + gvsalaryview.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Salary updated!");

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            if (tbSearchSalaryFname.Text != "")
            {
                String query = String.Format("Select * from salary where staffid = (select staffid from staffs where firstname like '%{0}%' and lastname like '%{1}%')", tbSearchSalaryFname.Text, tbSearchSalaryLName.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvsalaryview.DataSource = dt;
                conn.Close();
                cbSearchSalary.ResetText();
            }
            else
            {
                String query = String.Format("Select * from salary where salid = {0}", cbSearchSalary.SelectedValue);              
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvsalaryview.DataSource = dt;
                conn.Close();
            }
        }

        private void cbSearchSalary_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchSalaryFname.Clear();
            tbSearchSalaryLName.Clear();
        }

        private void tbSearchSalaryFname_TextChanged(object sender, EventArgs e)
        {
            cbSearchSalary.ResetText();
        }

        private void cbStaffId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbSearchSalary.ResetText();
            tbSearchSalaryFname.Clear();
            tbSearchSalaryLName.Clear();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchSalaryFname.Clear();
            tbSearchSalaryLName.Clear();
            cbSearchSalary.ResetText();
        }
    }
}
