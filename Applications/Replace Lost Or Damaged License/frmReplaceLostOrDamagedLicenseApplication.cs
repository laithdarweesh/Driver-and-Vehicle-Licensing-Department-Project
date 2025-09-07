using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.Licenses;
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
using static DVLD_Buisness.clsLicense;


namespace DVLD_Project.Applications.Replace_Lost_Or_Damaged_License
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use according 
            // to user selection.

            if (rbDamagedLicense.Checked)
                return (int) clsApplication.enApplicationType.ReplacementDamagedDrivingLicense;
            else
                return (int)clsApplication.enApplicationType.ReplacementLostDrivingLicense;
        }
        private enIssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (rbDamagedLicense.Checked)
                return enIssueReason.DamagedReplacement;
            else
                return enIssueReason.LostReplacement;
        }
        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
            rbDamagedLicense.Checked = true;

            lblApplicationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            btnIssueReplacement.Enabled = false;
            llShowLicensesHistory.Enabled = false;
            llShowNewLicensesInfo.Enabled = false;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            llShowLicensesHistory.Enabled = (SelectedLicenseID != -1);
            llShowNewLicensesInfo.Enabled = false;

            lblReplacementApplicationID.Text = "???";
            lblReplacedLicenseID.Text = "???";
            lblOldLicenseID.Text = "???";

            if (SelectedLicenseID == -1)
                return;

            if(!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Active, choose an active License",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            btnIssueReplacement.Enabled = true;
        }
        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the License?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            clsLicense NewLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.
                                   ReplaceLicense(_GetIssueReason(), clsGlobal.CurrentUser.UserID);

            if(NewLicense == null)
            {
                MessageBox.Show("Faild to Issue a Replacement for the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Licensed Replaced Successfully with ID [" + NewLicense.LicenseID.ToString()
                           + "]", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _NewLicenseID = NewLicense.LicenseID;

            lblReplacementApplicationID.Text = NewLicense.ApplicationID.ToString();
            lblReplacedLicenseID.Text = _NewLicenseID.ToString();
            lblOldLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.LicenseID.ToString();

            llShowNewLicensesInfo.Enabled = true;
            btnIssueReplacement.Enabled = false;
           
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            gbReplacementFor.Enabled = false;
        }
        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Damaged License";
            lblTitle.Text = this.Text;
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();

            lblTitle.Location = new Point((440 - (lblTitle.Width / 2)), 1);
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Lost License";
            lblTitle.Text = this.Text;
            lblApplicationFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).Fees.ToString();

            lblTitle.Location = new Point((440 - (lblTitle.Width / 2)), 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowNewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm =
            new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
