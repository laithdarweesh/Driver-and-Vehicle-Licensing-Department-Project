using DVLD_Buisness;
using DVLD_Project.Global_Classes;
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

namespace DVLD_Project.Licenses.Detain_License
{
    public partial class frmDetainLicenseApplication : Form
    {
        private int _DetainedLicenseID = -1;
        private int _LicenseID = -1;
        public frmDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmDetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            btnDetain.Enabled = false;
            llShowLicensesHistory.Enabled = false;
            llShowLicensesInfo.Enabled = false;
            txtFineFees.Enabled = false;
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            lblDetainID.Text = "???";
            lblLicenseID.Text = "???";
            txtFineFees.Text = "";

            llShowLicensesHistory.Enabled = (_LicenseID != -1);
            llShowLicensesInfo.Enabled = false;

            if (_LicenseID == -1)
                return;

            if(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("License with ID [" + _LicenseID.ToString()
                              + "] is Detained! Choose another One", "Not Allowed", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            txtFineFees.Enabled = true;
            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Detain this License?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            _DetainedLicenseID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainLicense(Convert.ToSingle(txtFineFees.Text), clsGlobal.CurrentUser.UserID);

            if(_DetainedLicenseID == -1)
            {
                MessageBox.Show("Error: Faild to Detain License", "Faild", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("License with ID [" + _LicenseID.ToString()
                            + "] Detained Successufully", "Successed", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            lblDetainID.Text = _DetainedLicenseID.ToString();
            lblLicenseID.Text = ctrlDriverLicenseInfoWithFilter1.LicenseID.ToString();

            btnDetain.Enabled = false;
            txtFineFees.Enabled = false;
            llShowLicensesInfo.Enabled = true;

            //ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cann't not be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }

            if(!clsValidation.IsNumber(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory
                                (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
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

        private void frmDetainLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
    }
}
