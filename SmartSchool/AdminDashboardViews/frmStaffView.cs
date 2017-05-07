using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchool
{
    public partial class frmStaffView : Form
    {
        public frmStaffView()
        {
            InitializeComponent();
        }

        void Load_Gridview()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select [staffid],[firstname],[lastname],[gender]  ,[dob] ,[placeofbirth] ,[mothertongue],[nationality],[contact],[address] ,[dateofjoin],[cnic] ,[lastworked],[previousexp] ,[designation],[desgid]  ,[subjectname] ,[subjectid] from staffs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvstaff.DataSource = dt;
            conn.Close();
        }

        private void frmStaffView_Load(object sender, EventArgs e)
        {
            Load_Gridview();
            Load_ComboBox_Salary();
        }
        void Load_ComboBox_Salary()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select * from staffs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSearchStaff.DataSource = dt;
            cbSearchStaff.ValueMember = "staffid";
            cbSearchStaff.Text = "(ID)";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete ? ", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);


                if (gvstaff.Rows.Count > 1 && gvstaff.SelectedRows[0].Index != gvstaff.Rows.Count - 1)
                {
                    string sql = "DELETE FROM Staffs WHERE staffid =" + gvstaff.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    gvstaff.Rows.RemoveAt(gvstaff.SelectedRows[0].Index);
                    MessageBox.Show("Staff deleted!");
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


                if (gvstaff.Rows.Count > 1 && gvstaff.SelectedRows[0].Index != gvstaff.Rows.Count - 1)
                {
                    string sql = "update staffs set firstname = '" + gvstaff.SelectedRows[0].Cells[1].Value.ToString() + "' , lastname = ('" + gvstaff.SelectedRows[0].Cells[2].Value.ToString() + "') , gender = ('" + gvstaff.SelectedRows[0].Cells[3].Value.ToString() + "') , dob = ('" + gvstaff.SelectedRows[0].Cells[4].Value.ToString() + "') , placeofbirth = ('" + gvstaff.SelectedRows[0].Cells[5].Value.ToString() + "') , mothertongue = ('" + gvstaff.SelectedRows[0].Cells[6].Value.ToString() + "') , nationality = ('" + gvstaff.SelectedRows[0].Cells[7].Value.ToString() + "') , contact = (" + gvstaff.SelectedRows[0].Cells[8].Value.ToString() + ") , address = ('" + gvstaff.SelectedRows[0].Cells[9].Value.ToString() + "') , dateofjoin = ('" + gvstaff.SelectedRows[0].Cells[10].Value.ToString() + "') , cnic = (" + gvstaff.SelectedRows[0].Cells[11].Value.ToString() + ") , lastworked = ('" + gvstaff.SelectedRows[0].Cells[12].Value.ToString() + "') , previousexp = ('" + gvstaff.SelectedRows[0].Cells[13].Value.ToString() + "') , designation = ('" + gvstaff.SelectedRows[0].Cells[14].Value.ToString() + "') , desgid = (" + gvstaff.SelectedRows[0].Cells[15].Value.ToString() + ") , subjectname = ('" + gvstaff.SelectedRows[0].Cells[16].Value.ToString() + "') , subjectid = (" + gvstaff.SelectedRows[0].Cells[17].Value.ToString() + ") WHERE staffid =" + gvstaff.SelectedRows[0].Cells[0].Value.ToString() + "";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Staff updated!");

                }
            }
        }

        private void tbSearchStaffFname_TextChanged(object sender, EventArgs e)
        {
            cbSearchStaff.ResetText();
        }

        private void cbSearchStaff_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSearchStaffFname.Clear();
            tbSearchStaffLName.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            if (tbSearchStaffFname.Text != "")
            {
                String query = String.Format("select [staffid],[firstname],[lastname],[gender]  ,[dob] ,[placeofbirth] ,[mothertongue],[nationality],[contact],[address] ,[dateofjoin],[cnic] ,[lastworked],[previousexp] ,[designation],[desgid]  ,[subjectname] ,[subjectid] from staffs where firstname like '%{0}%' and lastname like '%{1}%'", tbSearchStaffFname.Text, tbSearchStaffLName.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvstaff.DataSource = dt;
                get_image3();
                conn.Close();
                cbSearchStaff.ResetText();
            }
            else
            {
                String query = String.Format("Select [staffid],[firstname],[lastname],[gender]  ,[dob] ,[placeofbirth] ,[mothertongue],[nationality],[contact],[address] ,[dateofjoin],[cnic] ,[lastworked],[previousexp] ,[designation],[desgid]  ,[subjectname] ,[subjectid] from staffs where staffid = {0}", cbSearchStaff.SelectedValue);
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvstaff.DataSource = dt;
                get_image2();
                conn.Close();

            }
        }

        public Image get_image3()
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = String.Format("Select picture from staffs where firstname like '%{0}%' and lastname like '%{1}%'", tbSearchStaffFname.Text, tbSearchStaffLName.Text);
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteScalar().ToString() != "")
                {
                    byte[] s = (byte[])cmd.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(s);
                    conn.Close();
                    return pictureBox2.Image = Image.FromStream(ms);
                }
                else
                {
                    conn.Close();
                    return pictureBox2.Image = null;
                }
            }
            catch (Exception ex)
            {
                return pictureBox2.Image = null;
            }

        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Load_Gridview();
            tbSearchStaffFname.Clear();
            tbSearchStaffLName.Clear();
            cbSearchStaff.ResetText();
            pictureBox2.Image = null;
        }


        public Image get_image2()
        {
            string id = cbSearchStaff.SelectedValue.ToString();
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select picture from staffs where staffid = " + id + " ";
            SqlCommand cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteScalar().ToString() != "")
            {
                byte[] s = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream(s);
                conn.Close();
                return pictureBox2.Image = Image.FromStream(ms);
            }
            else
            {
                conn.Close();
                return pictureBox2.Image = null;
            }
        }
        public Image get_image()
        {
            try
            {
                string id = gvstaff.SelectedRows[0].Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select picture from staffs where staffid = " + id + " ";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteScalar().ToString() != "")
                {
                    byte[] s = (byte[])cmd.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(s);
                    conn.Close();
                    return pictureBox2.Image = Image.FromStream(ms);
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Image Not Found!");
                    return pictureBox2.Image = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Select Full Row!");
                return pictureBox2.Image = null;
            }
            
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            if(cbSearchStaff.Text != "" && cbSearchStaff.Text != "(ID)")
            {
                if(get_image2()!= null)
                {
                    get_image2();
                }
                else
                {
                    MessageBox.Show("Image Not Found!");
                }

            }
            else
            {
                get_image();
            }
        }
    }
}
