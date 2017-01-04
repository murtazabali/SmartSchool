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
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.GetInstance().connStr);
            conn.Open();
            String query = "Select totalsalary, staffid from salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cSalary.Series["Salary"].Points.AddXY(dr["staffid"].ToString(), dr["totalsalary"].ToString());
                cSalary.Series["Salary"].XValueMember = "Staff";
                cSalary.Series["Salary"].YValueMembers = "Salary";
            }
            conn.Close();
        }
    }
}
