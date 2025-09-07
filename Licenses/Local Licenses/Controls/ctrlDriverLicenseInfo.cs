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

namespace DVLD_Project.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID = -1;
        private clsLicense _License;
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }
        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return _License; }
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            _License = clsLicense.FindLicenseByID(LicenseID);
            
            if(_License == null)
            {
                _LicenseID = -1;
                _ResetDefaultValues();
                MessageBox.Show("Error: License with ID [" + LicenseID.ToString() +  "] not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseID = LicenseID;
            _LoadPersonImage();

            lblClass.Text = _License.LicenseClassInfo.ClassName;
            lblFullName.Text = _License.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNo;

            lblGendor.Text = _License.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";

            lblIssueDate.Text = clsFormat.DateToShort(_License.IssueDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = clsFormat.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverID.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = clsFormat.DateToShort(_License.ExpirationDate);
            lblIsDetained.Text = _License.IsDetained ? "Yes" : "No";
        }
        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gendor == 0)
            {
                pbPersonImage.Image = Resources.Male_512;
                pbGendor.Image = Resources.Man_32;
            }
            else
            {
                pbPersonImage.Image = Resources.Female_512;
                pbGendor.Image = Resources.Woman_32;
            }

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbPersonImage.Load(ImagePath);
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _ResetDefaultValues()
        {
            lblClass.Text = "???";
            lblFullName.Text = "???";
            lblLicenseID.Text = "???";
            lblNationalNo.Text = "???";
            
            lblGendor.Text = "???";
            pbGendor.Image = Resources.Man_32;

            lblIssueDate.Text = "???";
            lblIssueReason.Text = "???";
            lblNotes.Text = "???";
            lblIsActive.Text = "???";
            lblDateOfBirth.Text = "???";
            lblDriverID.Text = "???";
            lblExpirationDate.Text = "???";
            lblIsDetained.Text = "???";

            pbPersonImage.Image = Resources.Male_512;
        }
    }
}