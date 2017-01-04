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
    public partial class frmFeeRemainingReport : Form
    {
        public frmFeeRemainingReport()
        {
            InitializeComponent();
        }

        private void ReportFee_Load(object sender, EventArgs e)
        {
            FeeRemainingReport fr = new FeeRemainingReport();
            crystalReportViewer1.ReportSource = fr;
        }
    }
}
