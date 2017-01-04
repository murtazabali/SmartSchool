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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        void subID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(subjectid) from subject";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            txtsubjectid.Text = (id.ToString());
            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Insert_Subject", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subjectid", int.Parse(txtsubjectid.Text));
                cmd.Parameters.AddWithValue("@code", txtsubjectcode.Text);
                cmd.Parameters.AddWithValue("@subjectname", txtsubjectname.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject Inserted!");
                Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {

            txtsubjectid.Text = null;
            txtsubjectcode.Text = null;
            txtsubjectname.Text = null;
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            subID();
        }
    }
}
