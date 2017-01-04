using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartSchool.Reports;

namespace SmartSchool.ReportViews
{
    public partial class frmAllSalaryReport : Form
    {
        public frmAllSalaryReport()
        {
            InitializeComponent();
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            SalaryReport sr = new SalaryReport();
            crystalReportViewer1.ReportSource = sr;
        }
    }
}
