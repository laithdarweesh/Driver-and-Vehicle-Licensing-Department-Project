using DVLD_Buisness;
using DVLD_Project.Licenses;
using DVLD_Project.Licenses.Local_Licenses;
using DVLD_Project.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicesnseApplications : Form
    {
        private DataTable _dtAllLocalDrivingLicenseApplications;
        public frmListLocalDrivingLicesnseApplications()
        {
            InitializeComponent();
        }
        private void frmListLocalDrivingLicesnseApplications_Load(object sender, EventArgs e)
        {
            _RefreshListLocalDrivingLicenseApplications();

            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 300;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National No";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 120;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 350;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 170;

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Tests";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 150;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 120;
            }
        }
        private void _RefreshListLocalDrivingLicenseApplications()
        {
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplication();
            dgvLocalDrivingLicenseApplications.DataSource = _dtAllLocalDrivingLicenseApplications;
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if(txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                
                return;
            }

            if(FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                //in this case we deal with integer not string.
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'" , FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }
        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase L.D.L.AppID is selected.
            if (cbFilterBy.Text == "L.D.L.AppID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsmShowApplicationDetails_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int) dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = 
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID);

            if(LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("L.D.L Application with ID [" + LocalDrivingLicenseApplicationID.ToString() + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmListLocalDrivingLicesnseApplications_Load(null, null);
                return;
            }

            if(LocalDrivingLicenseApplication.Delete())
                MessageBox.Show("L.D.L Application with Id [" + LocalDrivingLicenseApplicationID.ToString() + "] Deleted Successufull", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmEditApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Cancel this Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID);


            if (LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("L.D.L Application with ID [" + LocalDrivingLicenseApplicationID.ToString() + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmListLocalDrivingLicesnseApplications_Load(null, null);
                return;
            }

            if (LocalDrivingLicenseApplication.Cancel())
                MessageBox.Show("L.D.L Application with Id [" + LocalDrivingLicenseApplicationID.ToString() + "] Cancelled Successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Cann't Cancel L.D.L Application with Id [" + LocalDrivingLicenseApplicationID.ToString() + "]", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = 
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            if (LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("L.D.L Application with ID [" + dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value.ToString() + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmListLocalDrivingLicesnseApplications_Load(null, null);
                return;
            }

            int LicenseID = LocalDrivingLicenseApplication.GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();
                frmListLocalDrivingLicesnseApplications_Load(null, null);
            }
            else
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void showLicensePersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value).ApplicantPersonID;   

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
        private void _ScheduleTest(clsTestType.enTestType TestType)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value, TestType);
            frm.ShowDialog();
            frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
        private void tsmScedhuleVisionTestItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }
        private void tsmScedhuleWrittenTestItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);
        }
        private void tsmScedhuleStreetTestItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
        }
        private void cmsApplication_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseAppID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();
            int PassedTestCount = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;

            bool PassedVisionTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.VisionTest);
            bool PassedWrittenTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.WrittenTest);
            bool PassedStreetTest = LocalDrivingLicenseApplication.DoesPassTestType(clsTestType.enTestType.StreetTest);
            
            tsmDeleteApplication.Enabled = !LicenseExists && LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;
            tsmEditApplication.Enabled = !LicenseExists && LocalDrivingLicenseApplication.TotalTrialsPerTest(clsTestType.enTestType.VisionTest) == 0 && LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;
            tsmCancelApplication.Enabled = !LicenseExists && LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;

            tsmScheduleTestMenue.Enabled = !LicenseExists && (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsmIssueDrivingLicense.Enabled = (PassedTestCount == 3 && !LicenseExists && LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsmShowLicense.Enabled = (LicenseExists && LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.Completed);

            //Enable Disable sub menue of Schedule test menue:

            if(tsmScheduleTestMenue.Enabled)
            {
                //To Allow Schdule vision test, Person must not passed the same test before.
                tsmScedhuleVisionTestItem.Enabled = !PassedVisionTest;

                //To Allow Schdule written test, Person must pass the vision test and must not passed the same test before.
                tsmScedhuleWrittenTestItem.Enabled = (PassedVisionTest && !PassedWrittenTest);

                //To Allow Schdule steet test, Person must pass the vision * written tests, and must not passed the same test before.
                tsmScedhuleStreetTestItem.Enabled = (PassedVisionTest && PassedWrittenTest && !PassedStreetTest);
            }
        }
    }
}