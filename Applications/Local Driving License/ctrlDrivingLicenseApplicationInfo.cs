using DVLD_Buisness;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Project.Applications.Local_Driving_License
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public int LocalDrivingLicenseApplicationID 
        { 
            get { return _LocalDrivingLicenseApplicationID; } 
        }
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadLocalDrivingLicenseInfoByID(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID);

            if(_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("L.D Application with ID: [" + LocalDrivingLicenseApplicationID.ToString() + "] not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }
        public void LoadLocalDrivingLicenseInfoByApplicationID(int ApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByApplicationID(ApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ID: [" + ApplicationID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            //incase there is license enable the show link.
            llShowLicenseInfo.Enabled = (_LocalDrivingLicenseApplication.GetActiveLicenseID() != -1);

            lblDrivingLicenseApp.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedForLicense.Text = clsLicenseClass.FindByLicenseClassID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblPassedTests.Text = _LocalDrivingLicenseApplication.GetPassedTestCount().ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);
        }
        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplicationID = -1;

            lblDrivingLicenseApp.Text = "???";
            lblAppliedForLicense.Text = "???";
            lblPassedTests.Text = "0";
            llShowLicenseInfo.Enabled = false;

            ctrlApplicationBasicInfo1.ResetApplicationInfo();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalDrivingLicenseApplication.GetActiveLicenseID());
            frm.ShowDialog();
        }
    }
}