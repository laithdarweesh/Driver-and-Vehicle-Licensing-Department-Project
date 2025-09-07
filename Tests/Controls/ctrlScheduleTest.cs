using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Tests
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1}

        private enMode _Mode = enMode.AddNew;
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private int _TestAppointmentID = -1;

        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private clsTestAppointment _TestAppointment;
        public clsTestType.enTestType TestTypeID
        {
            get
            {
                return _TestTypeID;
            }
            set
            {
                _TestTypeID = value;

                switch(_TestTypeID)
                {
                    case clsTestType.enTestType.VisionTest:
                        pbTestTypeImage.Image = Resources.Vision_512;
                        gbTestType.Text = "Vision Test";
                        //lblScheduleTest.Text = "Schedule Vision Test";
                        break;

                    case clsTestType.enTestType.WrittenTest:
                        pbTestTypeImage.Image = Resources.Written_Test_512;
                        gbTestType.Text = "Written Test";
                        //lblScheduleTest.Text = "Schedule Written Test";
                        break;

                    case clsTestType.enTestType.StreetTest:
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        gbTestType.Text = "Street Test";
                        //lblScheduleTest.Text = "Schedule Street Test";
                        break;
                }
            }
        }
        public void LoadInfo(int LocalDrivingLicenseApplicationID, int AppointmentID = -1)
        {
            //if no appointment id this means AddNew mode otherwise it's update mode.
            if (AppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = AppointmentID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            if(_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID [" + _LocalDrivingLicenseApplicationID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            //decide if the createion mode is retake test or not based if the person attended this test before
            if (_LocalDrivingLicenseApplication.DoesAttendedTestType(_TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;

            lblLocalDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication.PersonFullName;

            //this will show the trials for this test before 
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();
            
            //not implemented in instructor code
            lblUserMessage.Visible = false;

            if(_CreationMode == enCreationMode.FirstTimeSchedule)
            {
                gbRetakeTestInfo.Enabled = false;
                lblTitle.Text = "Schedule Test";
                lblRetakeTestAppFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblTitle.Location = new Point((519 / 2) - (lblTitle.Width / 2), 227);
                lblRetakeTestAppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees.ToString();
                lblRetakeTestAppID.Text = "0";
            }

            if(_Mode == enMode.AddNew)
            {
                dtpTestDate.MinDate = DateTime.Now;
                lblFees.Text = clsTestType.Find(_TestTypeID).Fees.ToString();

                _TestAppointment = new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblFees.Text) + Convert.ToSingle(lblRetakeTestAppFees.Text)).ToString();

            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePrviousTestConstraint())
                return;
        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.FindTestAppointmentByID(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID [" + _TestAppointmentID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return false;
            }

            //we compare the current date with the appointment date to set the min date.
            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpTestDate.MinDate = DateTime.Now;
            else
                dtpTestDate.MinDate = _TestAppointment.AppointmentDate;

            dtpTestDate.Value = _TestAppointment.AppointmentDate;
            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if (_TestAppointment.RetakeTestApplicationID != -1)
            {
                gbRetakeTestInfo.Enabled = true;
                lblTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            }

            return true;
        }
        private bool _HandleActiveTestAppointmentConstraint()
        {
            if(_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.IsThereAnActiveScheduleTest(_LocalDrivingLicenseApplicationID , _TestTypeID))
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person Already have an active appointment for this test";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            //if appointment is locked that means the person already sat for this test
            //we cannot update locked appointment

            if (_TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = "Person already sat for the test, appointment loacked.";
                dtpTestDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }    
            else
            {
                lblUserMessage.Visible = false;
                return true;
            }
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lblUserMessage.Visible = false;
                    return true;

                case clsTestType.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.

                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest))
                    {
                        lblUserMessage.Visible = true;
                        lblUserMessage.Text = "Cannot Sechule, Vision Test Should be Passed First.";
                        dtpTestDate.Enabled = false;
                        btnSave.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        return true;
                    }

                case clsTestType.enTestType.StreetTest:
                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.

                    if (!_LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest))
                    {
                        lblUserMessage.Visible = true;
                        lblUserMessage.Text = "Cannot Sechule, Written Test Should be Passed First.";
                        dtpTestDate.Enabled = false;
                        btnSave.Enabled = false;    
                        return false;
                    }
                    else
                    {
                        lblUserMessage.Visible = false;
                        return true;
                    }
            }

            return true;
        }
        private bool _HandleRetakeApplication()
        {
            //this will decide to create a seperate application for retake test or not.
            // and will create it if needed , then it will linkit to the appoinment.
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                //incase the mode is add new and creation mode is retake test we should create a seperate application for it.
                //then we linke it with the appointment.

                //First Create Applicaiton 
                clsApplication Application = new clsApplication();

                Application.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                Application.ApplicationDate = DateTime.Now;
                Application.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                Application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationType.Find((int)clsApplication.enApplicationType.RetakeTest).Fees;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (!Application.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = Application.ApplicationID;
            }

            return true;
        }
        public ctrlScheduleTest()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtpTestDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblFees.Text);
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_TestAppointment.Save())
            {
                if(_Mode == enMode.AddNew)
                {
                    MessageBox.Show("Test Appointment added Successufully with ID[" + _TestAppointment.TestAppointmentID.ToString() + "]", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                }
                else
                {
                    MessageBox.Show("Test Appointment with ID [" + _TestAppointment.TestAppointmentID.ToString() + "] Updated Successufully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (_Mode == enMode.AddNew)
                {
                    MessageBox.Show("Cann't added Appointment for this Test", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cann't Updated Appointment for this Test", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}