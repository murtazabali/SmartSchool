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
    public partial class frmNewAddmission : Form
    {
        public frmNewAddmission()
        {
            InitializeComponent();
        }

        private void frmNewAddmission_Load(object sender, EventArgs e)
        {
            StudentID();
        }

        void StudentID()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select max(stdid) from student";
            SqlCommand cmd = new SqlCommand(query, conn);
            int id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            txtstudentid.Text = (id.ToString());
            conn.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_Insert_NewAddmission", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@firstname", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@lastname", txtlastname.Text);
                cmd.Parameters.AddWithValue("@gender", txtgender.Text);
                cmd.Parameters.AddWithValue("@dob", dtdob.Value);
                cmd.Parameters.AddWithValue("@placeofbirth", txtplace.Text);
                cmd.Parameters.AddWithValue("@mothertongue", txttounge.Text);
                cmd.Parameters.AddWithValue("@nationality", txtnationality.Text);
                cmd.Parameters.AddWithValue("@contact", decimal.Parse(txtcontact.Text));
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@dateofjoining", dtjoining.Value);
                cmd.Parameters.AddWithValue("@lastschoolattend", txtlastschool.Text);
                cmd.Parameters.AddWithValue("@bform", decimal.Parse(txtbform.Text));
                cmd.Parameters.AddWithValue("@class", int.Parse(txtclass.Text));
                cmd.Parameters.AddWithValue("@section", txtsection.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Admission Successful!");
                Clear();
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        void Clear()
        {
            StudentID();
            txtfirstname.Text = null;
            txtlastname.Text = null;
            txtgender.Text = null;
            txtplace.Text = null;
            dtdob.ResetText();
            dtjoining.ResetText();
            txttounge.Text = null;
            txtnationality.Text = null;
            txtcontact.Text = null;
            txtaddress.Text = null;
            txtlastschool.Text = null;
            txtbform.Text = null;
            txtclass.Text = null;
            txtsection.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
