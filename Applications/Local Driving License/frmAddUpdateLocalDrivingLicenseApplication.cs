using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode;

        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }

        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesInComboBox();
            tpApplicationInfo.Enabled = false;
            btnSave.Enabled = false;

            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void _LoadData()
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("L.D.Application with ID [" + _LocalDrivingLicenseApplicationID.ToString() + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblTitle.Text = "Update Local Driving License Application";
            this.Text = lblTitle.Text;
            lblTitle.Location = new Point((445 - (lblTitle.Width / 2)), 7);

            ctrlPersonCardWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);

            ctrlPersonCardWithFilter1.FilterEnabled = false;
            tpApplicationInfo.Enabled = true;
            btnSave.Enabled = true;

            lblLocalLicenseApplicationId.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = clsFormat.DateToShort(_LocalDrivingLicenseApplication.ApplicationDate);
            lblApplicationFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            cbLicenseClass.SelectedIndex = cbLicenseClass.FindString(clsLicenseClass.FindByLicenseClassID(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            lblCreatedByUser.Text = clsUser.FindByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).UserName;
        }
        private void _FillLicenseClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach(DataRow Row in dtLicenseClasses.Rows)
            {
                cbLicenseClass.Items.Add(Row["ClassName"]);
            }
        }
        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received
            _SelectedPersonID = PersonID;
            ctrlPersonCardWithFilter1.LoadPersonInfo(PersonID);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.PersonId != -1)
            {
                tcApplicationInfo.SelectedTab = tcApplicationInfo.TabPages["tpApplicationInfo"];
                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            int LicenseClassID = clsLicenseClass.FindByLicenseClassName(cbLicenseClass.Text).LicenseClassID;
            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplication.enApplicationType.NewLocalDrivingLicense, LicenseClassID);

            if(ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }

            // check if user already have issued license of the same driving  class.
            if(clsLicense.IsLicenseExistByPersonID(ctrlPersonCardWithFilter1.PersonId, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = ctrlPersonCardWithFilter1.PersonId;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToSingle(lblApplicationFees.Text);
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            if(_LocalDrivingLicenseApplication.Save())
            {
                btnSave.Enabled = false;

                if(_Mode == enMode.AddNew)
                {
                    lblLocalLicenseApplicationId.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();

                    //change form mode to update.
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Local Driving License Application";
                    this.Text = lblTitle.Text;
                    lblTitle.Location = new Point((445 - (lblTitle.Width / 2)), 7);
                    MessageBox.Show("Application Added to System successufully with ID [" + _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString() + "]", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Application Updated to " + cbLicenseClass.Text.ToString() + " Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(_Mode == enMode.AddNew)
                    MessageBox.Show("Error: Can't Add New Local Driving Application to System", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error: Can't Update Application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ctrlPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
            
            if(_SelectedPersonID == -1)
            {
                lblLocalLicenseApplicationId.Text = "???";
                lblApplicationDate.Text = "???";
                cbLicenseClass.SelectedIndex = 2;
                lblApplicationFees.Text = "???";
                lblCreatedByUser.Text = "???";

                lblTitle.Text = "Local Driving License Application";
                this.Text = lblTitle.Text;
                lblTitle.Location = new Point((445 - (lblTitle.Width / 2)), 7);

                ctrlPersonCardWithFilter1.FilterFocus();
                tpApplicationInfo.Enabled = false;
                btnSave.Enabled = false;

                return;
            }

            if (_LocalDrivingLicenseApplicationID != -1)
                return;

            _Mode = enMode.AddNew;
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();

            lblTitle.Text = "New Local Driving License Application";
            this.Text = lblTitle.Text;
            lblTitle.Location = new Point((445 - (lblTitle.Width / 2)), 7);

            lblLocalLicenseApplicationId.Text = "???";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            cbLicenseClass.SelectedIndex = 2;
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocalDrivingLicense).Fees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            ctrlPersonCardWithFilter1.FilterFocus();
            tpApplicationInfo.Enabled = false;
            btnSave.Enabled = false;
        }
        private void ctrlPersonCardWithFilter1_OnAddNewPerson(int obj)
        {
            _SelectedPersonID = obj;
            
            _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            _Mode = enMode.AddNew;

            lblTitle.Text = "New Local Driving License Application";
            this.Text = lblTitle.Text;
            lblTitle.Location = new Point((445 - (lblTitle.Width / 2)), 7);

            lblLocalLicenseApplicationId.Text = "???";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            cbLicenseClass.SelectedIndex = 2;
            lblApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocalDrivingLicense).Fees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.UserName;

            ctrlPersonCardWithFilter1.FilterFocus();
            tpApplicationInfo.Enabled = false;
            btnSave.Enabled = false;

        }
        private void frmAddUpdateLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!btnSave.Enabled)
                btnSave.Enabled = true;
        }
    }
}