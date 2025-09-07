using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.International_Licenses.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private int _InternationalLicenseID = -1;
        private clsInternationalLicense _InternationalLicense;
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public int InternationalLicenseID
        {
            get { return _InternationalLicenseID; }
        }
        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);

            if (_InternationalLicense == null) 
            {
                MessageBox.Show("International License with ID [" + _InternationalLicenseID.ToString() + "] not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetDefaultValues();
                _InternationalLicenseID = -1;
                return;
            }

            _LoadPersonImage();

            lblFullName.Text = _InternationalLicense.FullAplicantName;
            lblInternationalLicenseID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = (_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Text = clsFormat.DateToShort(_InternationalLicense.IssueDate);

            lblApplicationID.Text = _InternationalLicense.ApplicationID.ToString();
            lblIsActive.Text = (_InternationalLicense.IsActive) ? "Yes" : "No";
            lblDateOfBirth.Text = clsFormat.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverID.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(_InternationalLicense.ExpirationDate);
        }
        private void _LoadPersonImage()
        {
            if(_InternationalLicense.DriverInfo.PersonInfo.Gendor == 0)
            {
                pbPersonImage.Image = Resources.Male_512;
                pbGendor.Image = Resources.Man_32;
            }
            else
            {
                pbPersonImage.Image = Resources.Female_512;
                pbGendor.Image = Resources.Woman_32;
            }

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _ResetDefaultValues()
        {
            lblFullName.Text = "???";
            lblInternationalLicenseID.Text = "???";
            lblLicenseID.Text = "???";
            lblNationalNo.Text = "???";

            lblGendor.Text = "???";
            pbGendor.Image = Resources.Man_32;

            lblIssueDate.Text = "???";
            lblApplicationID.Text = "???";
            lblIsActive.Text = "???";
            lblDateOfBirth.Text = "??/??/????";
            lblDriverID.Text = "???";
            lblExpirationDate.Text = "??/??/????";

            pbPersonImage.Image = Resources.Male_512;
        }
    }
}