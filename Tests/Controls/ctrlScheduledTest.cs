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

namespace DVLD_Project.Tests.Controls
{
    public partial class ctrlScheduledTest : UserControl
    {
        private clsTestType.enTestType _TestTypeID;
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _TestAppointmentID = -1;
        private int _TestID = -1;

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

                switch (_TestTypeID)
                {
                    case clsTestType.enTestType.VisionTest:
                        gbTestType.Text = "Vision Test";
                        pbTestTypeImage.Image = Resources.Vision_Test_32;
                        break;

                    case clsTestType.enTestType.WrittenTest:
                        gbTestType.Text = "Written Test";
                        pbTestTypeImage.Image = Resources.Written_Test_32;
                        break;

                    case clsTestType.enTestType.StreetTest:
                        gbTestType.Text = "Street Test";
                        pbTestTypeImage.Image = Resources.driving_test_512;
                        break;
                }
            }
        }
        public int TestAppointmentID
        {
            get 
            {
                return _TestAppointmentID;
            }
        }
        public int TestID
        {
            get
            {
                return _TestID;
            }
        }
        public clsTestAppointment TestAppointment
        {
            get
            {
                return _TestAppointment;
            }
        }
        public void LoadInfo(int AppointmentID)
        {
            _TestAppointmentID = AppointmentID;
            _TestAppointment = clsTestAppointment.FindTestAppointmentByID(_TestAppointmentID);

            if(_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID [" + _TestAppointmentID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _TestID = _TestAppointment.TestID;

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            if(_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving Application with ID [" + _LocalDrivingLicenseApplicationID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDrivingLicenseAppID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lblFullName.Text = _LocalDrivingLicenseApplication.PersonFullName;
            lblTrial.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();
            lblDate.Text = clsFormat.DateToShort(_TestAppointment.AppointmentDate);
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTestID.Text = (_TestAppointment.TestID == -1) ? "Not Taken Yet" : _TestAppointment.TestID.ToString();
        }
        public ctrlScheduledTest()
        {
            InitializeComponent();
        }
    }
}