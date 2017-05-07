using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SmartSchool.AdminDashboardViews
{
    public partial class ConnectionStringForm : Form
    {
        public ConnectionStringForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["connectionString"].ConnectionString = tbCon.Text;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(tbCon.Text);
                conn.Open();
                if (conn.State == ConnectionState.Open) // if connection.Open was successful
                {
                    MessageBox.Show("You have been successfully connected to the database!");
                }
                else
                {
                    MessageBox.Show("Connection failed.");
                }
            }
            catch (SqlException) { }
        }
    }
}
