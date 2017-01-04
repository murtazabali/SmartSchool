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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void logoutExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmDepartment nd = new frmDepartment();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmNewUser nd = new frmNewUser();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStaff nd = new frmStaff();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void newSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSubject nd = new frmSubject();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void newAddmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmNewAddmission nd = new frmNewAddmission();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStudentView nd = new frmStudentView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStaffView nd = new frmStaffView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewDepartmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmDepartmentView nd = new frmDepartmentView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void viewSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSubjectView nd = new frmSubjectView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnNewAddmission_Click(object sender, EventArgs e)
        {

            panelAdminDpt.Controls.Clear();
            frmNewAddmission nd = new frmNewAddmission();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();

        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStudentView nd = new frmStudentView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void frmAdminDashboard_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        void HideAll()
        {
            panelStudent.Hide();
            panelDepartment.Hide();
            panelStaff.Hide();
            panelSubject.Hide();
            panelUser.Hide();
            panelSchedule.Hide();
            panelLogout.Hide();
        }

        private void btnStudent_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelStudent.Show();
        }

        private void btnStaff_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelStaff.Show();
        }

        private void btnDepartment_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelDepartment.Show();
        }

        private void btnSubject_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelSubject.Show();
        }

        private void btnUser_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelUser.Show();
        }

        private void btnSchedule_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelSchedule.Show();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            HideAll();
            panelLogout.Show();
        }

        private void btnNewStaff_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStaff nd = new frmStaff();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmStaffView nd = new frmStaffView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnNewDepartment_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmDepartment nd = new frmDepartment();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnViewDepartment_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmDepartmentView nd = new frmDepartmentView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnNewSubject_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSubject nd = new frmSubject();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSubjectView nd = new frmSubjectView();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmNewUser nd = new frmNewUser();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnShowSchedule_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSchedule nd = new frmSchedule();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
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

        private void panelAdminDpt_MouseClick(object sender, MouseEventArgs e)
        {
            HideAll();
        }

        private void btnNewAddmission_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelStudent_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelStaff_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelDepartment_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelSubject_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelUser_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelSchedule_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void panelLogout_MouseLeave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnShowSchedule_Leave(object sender, EventArgs e)
        {
            HideAll();
        }

        private void showScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmSchedule nd = new frmSchedule();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmShowUsers nd = new frmShowUsers();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            panelAdminDpt.Controls.Clear();
            frmShowUsers nd = new frmShowUsers();
            nd.MdiParent = this;
            panelAdminDpt.Controls.Add(nd);
            nd.Show();
            HideAll();
        }
    }
}
