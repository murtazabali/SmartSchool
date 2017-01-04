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
    public partial class frmShowUsers : Form
    {
        public frmShowUsers()
        {
            InitializeComponent();
        }

        private void frmShowUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMSUsers.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sMSUsers.Users);
            Load_ComboBox_Search();
        }
        void Load_ComboBox_Search()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select userid from Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchUsers.DataSource = dt;
            cbSearchUsers.ValueMember = "userid";
            cbSearchUsers.Text = "(ID)";
            conn.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete?  ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (dgvUsers.Rows.Count > 1 && dgvUsers.SelectedRows[0].Index != dgvUsers.Rows.Count - 1)
                {
                    string sql = "DELETE FROM Users WHERE userid =" + dgvUsers.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvUsers.Rows.RemoveAt(dgvUsers.SelectedRows[0].Index);
                    MessageBox.Show("User Deleted!");
                    frmShowUsers_Load(sender, e);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to update? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (dgvUsers.Rows.Count > 1 && dgvUsers.SelectedRows[0].Index != dgvUsers.Rows.Count - 1)
                {
                    string sql = "update Users set password = '" + dgvUsers.SelectedRows[0].Cells[2].Value.ToString() + "' WHERE userid =" + dgvUsers.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User Updated!");
                    frmShowUsers_Load(sender, e);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            if (tbSearchUsers.Text != "")
            {
                String query = String.Format("Select * from Users where username like '%{0}%'", tbSearchUsers.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
                conn.Close();
                cbSearchUsers.ResetText();
            }
            else
            {
                String query = String.Format("Select * from Users where userid = {0}", cbSearchUsers.SelectedValue);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
                conn.Close();
            }
        }

        private void cbSearchUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchUsers.Clear();
        }

        private void tbSearchUsers_TextChanged(object sender, EventArgs e)
        {
            cbSearchUsers.ResetText();
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchUsers.Clear();
            cbSearchUsers.ResetText();
        }

        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = String.Format("Select * from Users");
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUsers.DataSource = dt;
            conn.Close();
        }
    }
}
