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
    public partial class frmSubjectView : Form
    {
        public frmSubjectView()
        {
            InitializeComponent();
        }



        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from subject";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvsubject.DataSource = dt;
            conn.Close();
        }

        private void frmSubjectView_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Code();
        }
        void Load_ComboBox_Code()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select code from subject";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchCode.DataSource = dt;
            cbSearchCode.ValueMember = "code";
            cbSearchCode.Text = "(Code)";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete  ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvsubject.Rows.Count > 1 && gvsubject.SelectedRows[0].Index != gvsubject.Rows.Count - 1)
                {
                    string sql = "DELETE FROM subject WHERE subjectid =" + gvsubject.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvsubject.Rows.RemoveAt(gvsubject.SelectedRows[0].Index);
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


                if (gvsubject.Rows.Count > 1 && gvsubject.SelectedRows[0].Index != gvsubject.Rows.Count - 1)
                {
                    string sql = "update subject set code = '" + gvsubject.SelectedRows[0].Cells[1].Value.ToString() + "' , subjectname = ('" + gvsubject.SelectedRows[0].Cells[2].Value.ToString() + "')  WHERE subjectid =" + gvsubject.SelectedRows[0].Cells[0].Value.ToString() + "";
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
            if (tbSearchSubject.Text != "")
            {
                String query = String.Format("Select * from subject where subjectname like '%{0}%'", tbSearchSubject.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvsubject.DataSource = dt;
                conn.Close();
                cbSearchCode.ResetText();
            }
            else
            {
                String query = String.Format("Select * from subject where code like '{0}'", cbSearchCode.SelectedValue);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvsubject.DataSource = dt;
                conn.Close();
            }
        }

        private void cbSearchCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchSubject.Clear();
        }

        private void tbSearchSubject_TextChanged(object sender, EventArgs e)
        {
            cbSearchCode.ResetText();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            cbSearchCode.ResetText();
            tbSearchSubject.Clear();
        }
    }
}
