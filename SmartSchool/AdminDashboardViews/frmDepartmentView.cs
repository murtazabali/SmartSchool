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
    public partial class frmDepartmentView : Form
    {
        public frmDepartmentView()
        {
            InitializeComponent();
        }


        private void frmDepartmentView_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Search();
        }

        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from dept";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvdepartment.DataSource = dt;
            conn.Close();
        }

        void Load_ComboBox_Search()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select deptid from dept";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchDept.DataSource = dt;
            cbSearchDept.ValueMember = "deptid";
            cbSearchDept.Text = "(ID)";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvdepartment.Rows.Count > 1 && gvdepartment.SelectedRows[0].Index != gvdepartment.Rows.Count - 1)
                {
                    string sql = "DELETE FROM dept WHERE deptid =" + gvdepartment.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvdepartment.Rows.RemoveAt(gvdepartment.SelectedRows[0].Index);
                    MessageBox.Show("Department deleted!");
                    Load_Gridview();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to update?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvdepartment.Rows.Count > 1 && gvdepartment.SelectedRows[0].Index != gvdepartment.Rows.Count - 1)
                {
                    string sql = "update dept set deptname = '" + gvdepartment.SelectedRows[0].Cells[1].Value.ToString() + "' , location = ('" + gvdepartment.SelectedRows[0].Cells[2].Value.ToString() + "')  WHERE deptid =" + gvdepartment.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Department updated!");

                }

            }


        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            if (tbSearchDept.Text != "")
            {
                String query = String.Format("Select * from dept where deptname like '%{0}%'", tbSearchDept.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvdepartment.DataSource = dt;
                conn.Close();
                cbSearchDept.ResetText();
            }
            else
            {
                String query = String.Format("Select * from dept where deptid = {0}", cbSearchDept.SelectedValue);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvdepartment.DataSource = dt;
                conn.Close();
            }            
            
        }

        private void cbSearchDept_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchDept.Clear();
        }

        private void tbSearchDept_TextChanged(object sender, EventArgs e)
        {
            cbSearchDept.ResetText();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchDept.Clear();
            cbSearchDept.ResetText();
        }
    }
}
