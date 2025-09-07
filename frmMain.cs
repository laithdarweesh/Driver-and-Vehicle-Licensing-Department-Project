using DVLD_Project.Applications.Application_Types;
using DVLD_Project.Applications.International_License;
using DVLD_Project.Applications.Local_Driving_License;
using DVLD_Project.Applications.Renew_Local_License;
using DVLD_Project.Applications.Replace_Lost_Or_Damaged_License;
using DVLD_Project.Applications.Rlease_Detained_License;
using DVLD_Project.Drivers;
using DVLD_Project.Global_Classes;
using DVLD_Project.Licenses.Detain_License;
using DVLD_Project.Licenses.Local_Licenses;
using DVLD_Project.Login;
using DVLD_Project.People;
using DVLD_Project.People.Controls;
using DVLD_Project.Tests;
using DVLD_Project.Tests.TestTypes;
using DVLD_Project.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.Refresh();
        }
        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }
        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.Show();
        }
        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListUsers();
            frm.ShowDialog();
        }
        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }
        private void tsmChangePassw_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void tsmCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        private void tsmManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes frm = new frmListApplicationTypes();
            frm.ShowDialog();
        }
        private void tsmManageTestTypes_Click(object sender, EventArgs e)
        {
            frmListTestTypes frm = new frmListTestTypes();
            frm.ShowDialog();
        }
        private void tsmLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }
        private void tsmLocalDrivingLicence_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmRetakeTest_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicesnseApplications frm = new frmListLocalDrivingLicesnseApplications();
            frm.ShowDialog();
        }
        private void tsmRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm = new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmReplacementForLostOrDamagedLicense_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }
        private void tsmInternationalDrivingLicence_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }
        private void tsmInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            frm.ShowDialog();
        }
        private void tsmReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
        }

        private void msMainMenue_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AccountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}