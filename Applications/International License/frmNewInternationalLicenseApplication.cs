using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.Licenses;
using DVLD_Project.Licenses.International_Licenses;
using DVLD_Project.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.International_License
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        private int _InternationalLicenseID = -1;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            btnIssue.Enabled = false;
            llShowLicensesHistory.Enabled = false;
            llShowLicensesInfo.Enabled = false;

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = -1; 
            LicenseID = obj;

            llShowLicensesHistory.Enabled = (LicenseID != -1);
            llShowLicensesInfo.Enabled = false;
            btnIssue.Enabled = false;

            lblInternationalLicenseApplicationID.Text = "???";
            lblInternationalLicenseID.Text = "???";
            lblLocalLicenseID.Text = "???";
            lblExpirationDate.Text = "??/??/????";

            if (LicenseID == -1)
                return;

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblIssueDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblFees.Text = clsApplicationType.Find((int) clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            //check the license class, person could not issue international license without having
            //normal license of class 3.

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("Selected License should be [" 
                    + clsLicenseClass.FindByLicenseClassID(3).ClassName.ToString() 
                    + "], select another one", "Not Allowed" , MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            //check if person already have an active international license

            _InternationalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (_InternationalLicenseID != -1)
            {
                MessageBox.Show("Person already has an active International License with ID [" +
                    _InternationalLicenseID.ToString() + "]",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            lblLocalLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now.AddYears(1));

            btnIssue.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue International License?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();

            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            
            if(!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to issue International License", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("International License issued successufully with ID [" + InternationalLicense.InternationalLicenseID.ToString() + "]", "License Issued",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            lblInternationalLicenseApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lblInternationalLicenseID.Text = _InternationalLicenseID.ToString();

            btnIssue.Enabled = false;
            llShowLicensesInfo.Enabled = true;
            //ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void llShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewInternationalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}