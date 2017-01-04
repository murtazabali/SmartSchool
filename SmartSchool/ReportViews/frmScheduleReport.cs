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

namespace SmartSchool
{
    public partial class frmScheduleReport : Form
    {
        public frmScheduleReport()
        {
            InitializeComponent();
        }

        private void frmScheduleReport_Load(object sender, EventArgs e)
        {
            ScheduleReport sr = new ScheduleReport();
            crystalReportViewer1.ReportSource = sr;
        }
    }
}
