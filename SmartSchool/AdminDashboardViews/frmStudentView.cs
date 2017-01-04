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
    public partial class frmStudentView : Form
    {
        public frmStudentView()
        {
            InitializeComponent();
        }

        private void frmStudentView_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Stdid();
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
            String query = "Select * from student";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvstudent.DataSource = dt;
            conn.Close();
        }   

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to delete  ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvstudent.Rows.Count > 1 && gvstudent.SelectedRows[0].Index != gvstudent.Rows.Count - 1)
                {
                    string sql = "DELETE FROM student WHERE stdid =" + gvstudent.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvstudent.Rows.RemoveAt(gvstudent.SelectedRows[0].Index);
                    MessageBox.Show("data has been deleted");

                }

                


            }
            Load_Gridview();
            MessageBox.Show("data has been udeleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you really want to update ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvstudent.Rows.Count > 1 && gvstudent.SelectedRows[0].Index != gvstudent.Rows.Count - 1)
                {
                    string sql = "update student set firstname = '" + gvstudent.SelectedRows[0].Cells[1].Value.ToString() + "' , lastname = ('" + gvstudent.SelectedRows[0].Cells[2].Value.ToString() + "') , gender = ('" + gvstudent.SelectedRows[0].Cells[3].Value.ToString() + "') , dob = ('" + gvstudent.SelectedRows[0].Cells[4].Value.ToString() + "') , placeofbirth = ('" + gvstudent.SelectedRows[0].Cells[5].Value.ToString() + "') , mothertongue = ('" + gvstudent.SelectedRows[0].Cells[6].Value.ToString() + "') , nationality = ('" + gvstudent.SelectedRows[0].Cells[7].Value.ToString() + "') , contact = (" + gvstudent.SelectedRows[0].Cells[8].Value.ToString() + ") , address = ('" + gvstudent.SelectedRows[0].Cells[9].Value.ToString() + "') , dateofjoining = ('" + gvstudent.SelectedRows[0].Cells[10].Value.ToString() + "') , lastschoolattend = ('" + gvstudent.SelectedRows[0].Cells[11].Value.ToString() + "') , bform = (" + gvstudent.SelectedRows[0].Cells[12].Value.ToString() + ") , class = (" + gvstudent.SelectedRows[0].Cells[13].Value.ToString() + ") , section = ('" + gvstudent.SelectedRows[0].Cells[14].Value.ToString() + "') WHERE stdid =" + gvstudent.SelectedRows[0].Cells[0].Value.ToString() + "";
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
                String query = String.Format("select * from student where firstname like '%{0}%' and lastname like '%{1}%'", tbSearchStudentFname.Text, tbSearchStudentLName.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvstudent.DataSource = dt;
                conn.Close();
                cbSearchStudent.ResetText();
            }
            else
            {
                String query = String.Format("Select * from student where stdid = {0}", cbSearchStudent.SelectedValue);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvstudent.DataSource = dt;
                conn.Close();
            }
        }

        private void cbSearchStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchStudentFname.Clear();
            tbSearchStudentLName.Clear();
        }

        private void tbSearchStudentFname_TextChanged(object sender, EventArgs e)
        {
            cbSearchStudent.ResetText();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchStudentFname.Clear();
            tbSearchStudentLName.Clear();
            cbSearchStudent.ResetText();
        }
    }
}
