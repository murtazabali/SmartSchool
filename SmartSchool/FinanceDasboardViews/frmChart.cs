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
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
            cSalary.Series["Salary"].Color = Color.BlueViolet;
            cBonus.Series["Bonus"].Color = Color.Green;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select totalsalary, month from salary where staffid = " + tbId.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                foreach (var series in cSalary.Series)
                {
                    series.Points.Clear();
                }
                while (dr.Read())
                {

                    cSalary.Series["Salary"].Points.AddXY(dr["month"].ToString(), dr["totalsalary"].ToString());
                    cSalary.Series["Salary"].XValueMember = "month";
                    cSalary.Series["Salary"].YValueMembers = "Salary";
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLoadBonus_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
                conn.Open();
                String query = "Select bonus, month from salary where staffid = " + tbBonus.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                foreach (var series in cBonus.Series)
                {
                    series.Points.Clear();
                }
                while (dr.Read())
                {

                    cBonus.Series["Bonus"].Points.AddXY(dr["month"].ToString(), dr["bonus"].ToString());
                    cBonus.Series["Bonus"].XValueMember = "month";
                    cBonus.Series["Bonus"].YValueMembers = "bonus";
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
