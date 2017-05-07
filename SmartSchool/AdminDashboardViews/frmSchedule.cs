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
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }

        void load()
        {

            using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
            {
                string sql = string.Format("select * from Schedule ");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSchedule.DataSource = dt;
                    conn.Close();


                }
            }
        }

        void cb_Time()
        {
            string[] time = { "(Select Time Slot)", "07:00 to 08:00", "08:00 to 09:00", "09:00 to 10:00", "10:30 to 11:30", "11:30 to 12:30", "12:30 to 01:30" };
            cbTime.DataSource = time;
            //   cbTimeWise.DataSource = time;
        }

        void cb_class()
        {
            string[] cls = { "(Select Class)", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            cbClass.DataSource = cls;
            // cbFindClassWise.DataSource = cls; 
        }

        void cb_room()
        {
            string[] scholarship = { "(Select Room No)", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            cbRoom.DataSource = scholarship;
        }

        void Cb_Subject()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = "Select * from subject";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbSubject.DataSource = dt;
            cbSubject.ValueMember = "subjectname";
            cbSubject.Text = "(Select Subject)";
        }

        void Cb_teacher()
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            String query = String.Format("Select * from staffs where designation = 'Faculty' and subjectname like '%{0}%'", cbSubject.SelectedValue.ToString());
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbTeacher.DataSource = dt;
            cbTeacher.ValueMember = "firstname";
            cbTeacher.Text = "(Select Teacher)";
        }

        void count_room()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
                {
                    string sql = string.Format("select count(RoomNo) from Schedule where Day = '" + lblDay.Text + "' and Date = '" + dateTimePicker1.Value + "' and Time = '" + cbTime.Text + "' and  RoomNo = " + cbRoom.Text + "");
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        int count = int.Parse(cmd.ExecuteScalar().ToString());
                        if (count > 0)
                        {

                            MessageBox.Show("room already reserved please select another room");

                        }
                        else
                        {
                            using (SqlConnection connn = new SqlConnection(DB.GetInstance().connStr))
                            {
                                string sql2 = string.Format("select count(class) from Schedule where Day = '" + lblDay.Text + "' and Date = '" + dateTimePicker1.Value + "' and Time = '" + cbTime.Text + "' and  class = " + cbClass.Text + "");
                                using (SqlCommand cmddd = new SqlCommand(sql2, connn))
                                {
                                    connn.Open();
                                    int count2 = int.Parse(cmddd.ExecuteScalar().ToString());
                                    if (count2 > 0)
                                    {

                                        MessageBox.Show("This Class Already Have Class On " + cbTime.Text + " Please Select Another Time Slot");

                                    }
                                    else
                                    {

                                        SqlConnection con = new SqlConnection(DB.GetInstance().connStr);
                                        string query = "insert into Schedule (Day , Date , Time , class , roomno , subject , teacher) values ('" + lblDay.Text + "' , '" + dateTimePicker1.Value + "' , '" + cbTime.SelectedValue + "' ," + cbClass.SelectedValue + " ,  " + cbRoom.SelectedValue + " ,  '" + cbSubject.SelectedValue + "' , '" + cbTeacher.SelectedValue + "')";
                                        con.Open();
                                        SqlCommand cmdd = new SqlCommand(query, con);
                                        cmdd.ExecuteNonQuery();
                                        con.Close();
                                        MessageBox.Show("Class Has Been Reserved On " + lblDay.Text + " , " + dateTimePicker1.Value + " At " + cbTime.Text + " In Room No " + cbRoom.Text + "");

                                        load();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }




        private void frmSchedule_Load(object sender, EventArgs e)
        {
            lblDay.Text = dateTimePicker1.Value.DayOfWeek.ToString();
            cb_class();
            cb_room();
            Cb_Subject();
            Cb_teacher();
            cb_Time();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbClass.Text == "(Select Class)" || lblDay.Text == "(Select Day)" || cbTime.Text == "(Select Time Slot)")
            {
                MessageBox.Show("Please Check that all fields are properly selected!");
            }
            else
            {
                count_room();
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
            {
                string sql = string.Format("select * from Schedule where Day = '" + lblDay.Text + "' ");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSchedule.DataSource = dt;
                    conn.Close();


                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
            {
                string sql = string.Format("select * from Schedule where class = '" + cbClass.Text + "' ");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSchedule.DataSource = dt;
                    conn.Close();


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
            {
                string sql = string.Format("select * from Schedule where date = '" + dateTimePicker1.Value + "' ");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSchedule.DataSource = dt;
                    conn.Close();


                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DB.GetInstance().connStr))
            {
                string sql = string.Format("select * from Schedule where time = '" + cbTime.Text + "' ");
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvSchedule.DataSource = dt;
                    conn.Close();


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmScheduleReport sr = new frmScheduleReport();
            sr.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDay.Text = dateTimePicker1.Value.DayOfWeek.ToString();
        }

        private void cbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cb_teacher();
        }
    }
}
