using DVLD_Buisness;
using DVLD_Project.Properties;
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

namespace DVLD_Project.Tests
{
    public partial class frmListTestAppointments : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        private static DataTable _dtLicenseTestAppointments;
        public frmListTestAppointments(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestTypeID = TestTypeID;
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImageAndTitle();
            ctrlDrivingLicenseApplicationInfo1.LoadLocalDrivingLicenseInfoByID(_LocalDrivingLicenseApplicationID);

            _dtLicenseTestAppointments = clsTestAppointment.GetApplicationTestAppointmentPerTestType(_LocalDrivingLicenseApplicationID, _TestTypeID);
            dgvListTestAppointments.DataSource = _dtLicenseTestAppointments;
            lblRecordsCount.Text = dgvListTestAppointments.Rows.Count.ToString();

            if(dgvListTestAppointments.Rows.Count > 0)
            {
                dgvListTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvListTestAppointments.Columns[0].Width = 190;

                dgvListTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvListTestAppointments.Columns[1].Width = 170;

                dgvListTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvListTestAppointments.Columns[2].Width = 130;

                dgvListTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvListTestAppointments.Columns[3].Width = 130;
            }
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    pbImageTestType.Image = Resources.Vision_Test_32;
                    lblTitleTestType.Text = "Vision Test Appointment";
                    this.Text = lblTitleTestType.Text;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    pbImageTestType.Image = Resources.Written_Test_32;
                    lblTitleTestType.Text = "Written Test Appointment";
                    this.Text = lblTitleTestType.Text;
                    break;

                case clsTestType.enTestType.StreetTest:
                    pbImageTestType.Image = Resources.Street_Test_32;
                    lblTitleTestType.Text = "Street Test Appointment";
                    this.Text = lblTitleTestType.Text;
                    break;
            }
        }
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(_LocalDrivingLicenseApplicationID);

            //check if Person have an active test appointment
            if(LocalDrivingLicenseApplication.IsThereAnActiveScheduleTest(_TestTypeID))
            {
                MessageBox.Show("Person already have an active appointment for this test, you cann't add new appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //now check if person passed this test before, through check if have data in Test Table 
            clsTest LastTest = LocalDrivingLicenseApplication.GetLastTestPerTestType(_TestTypeID);

            if(LastTest == null)
            {
                frmScheduleTest frm1 = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID);
                frm1.ShowDialog();
                frmListTestAppointments_Load(null, null);
                return;
            }

            //if person already passed the test s/he cannot retak it.
            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest(LastTest.TestAppointmenetInfo.LocalDrivingLicenseApplicationID, _TestTypeID);
            frm2.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }
        private void tsmEditTest_Click(object sender, EventArgs e)
        {
            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID, (int)dgvListTestAppointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }
        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int) dgvListTestAppointments.CurrentRow.Cells[0].Value, _TestTypeID);
            frm.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}