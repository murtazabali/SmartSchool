using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchool
{
    public partial class frmFinanceDashBoard : Form
    {
        public frmFinanceDashBoard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void logoutExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmFees nd = new frmFees();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmViewFees nd = new frmViewFees();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalary nd = new frmSalary();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalaryView nd = new frmSalaryView();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void feeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeeReport report = new frmFeeReport();
            this.IsMdiContainer = true;
            report.MdiParent = this;
            report.Show();
        }

        private void frmFinanceDashBoard_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        void HideAll()
        {
            panelFees.Hide();
            panelSalary.Hide();
            panelLogout.Hide();
            panelReport.Hide();
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelFees.Show();
        }

        private void btnStaff_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelSalary.Show();
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelReport.Show();
        }

        private void btnLogout2_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelLogout.Show();
        }

        private void panelFees_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelSalary_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelReport_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelLogout_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }


        private void panelFees_MouseLeave_1(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnAddfees_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmFees nd = new frmFees();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnViewFees_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmViewFees nd = new frmViewFees();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalary nd = new frmSalary();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnViewSalary_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalaryView nd = new frmSalaryView();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnFeesReport_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmFeeReport nd = new frmFeeReport();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnSalaryReport_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalaryReport nd = new frmSalaryReport();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnLogoutAndExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void feeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmFeeReport nd = new frmFeeReport();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFinanceDept.Controls.Clear();
            frmSalaryReport nd = new frmSalaryReport();
            nd.MdiParent = this;
            panelFinanceDept.Controls.Add(nd);
            nd.Show();
            HideAll();
        }
    }
}
