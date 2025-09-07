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
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Rlease_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        private int _LicenseID = -1;
        public frmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
            ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }
        private void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

            if(_LicenseID != -1)
            {
                btnRelease.Enabled = true;
                llShowLicensesHistory.Enabled = true;
                return;
            }

            btnRelease.Enabled = false;
            llShowLicensesHistory.Enabled = false;
            llShowLicensesInfo.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            lblDetainID.Text = "???";
            lblDetainDate.Text = "??/??/????";
            lblApplicationFees.Text = "$$$";
            lblTotalFees.Text = "$$$";

            lblLicenseID.Text = "???";
            lblApplicationID.Text = "???";
            lblCreatedBy.Text = "???";
            lblFineFees.Text = "$$$";

            llShowLicensesHistory.Enabled = (_LicenseID != -1);
            llShowLicensesInfo.Enabled = false;

            if (_LicenseID == -1)
                return;

            if(!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("License with ID [" + _LicenseID.ToString() + "] is not Detained, choose another one", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainID.ToString();
            lblDetainDate.Text = clsFormat.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.DetainDate);
            lblApplicationFees.Text = clsApplicationType.Find((int) clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense).Fees.ToString();

            lblLicenseID.Text = _LicenseID.ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedLicenseInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;
        }
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release this Detained License?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int ApplicationID = -1;

            if(!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID, ref ApplicationID))
            {
                MessageBox.Show("Faild to Release the Detain License", "Faild", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            MessageBox.Show("License with ID [" + _LicenseID.ToString()
                            + "] Released Successufully", "Successed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            lblApplicationID.Text = ApplicationID.ToString();
            btnRelease.Enabled = false;
            llShowLicensesInfo.Enabled = true;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }
        private void frmReleaseDetainedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = 
                    new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void llShowLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbDetain_Enter(object sender, EventArgs e)
        {

        }
    }
}
