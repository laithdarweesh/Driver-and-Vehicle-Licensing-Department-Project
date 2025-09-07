using DVLD_Buisness;
using DVLD_Project.Licenses;
using DVLD_Project.Licenses.Detain_License;
using DVLD_Project.Licenses.Local_Licenses;
using DVLD_Project.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Rlease_Detained_License
{
    public partial class frmListDetainedLicenses : Form
    {
        private DataTable _dtAllDetainedLicenses;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _dtAllDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtAllDetainedLicenses;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();

            if(dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 160;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 110; 

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Released Date";
                dgvDetainedLicenses.Columns[5].Width = 160;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No";
                dgvDetainedLicenses.Columns[6].Width = 100;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 330;

                dgvDetainedLicenses.Columns[8].HeaderText = "Release App.ID";
                dgvDetainedLicenses.Columns[8].Width = 150;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIsReleased.Visible = (cbFilterBy.Text == "Is Released");
            txtFilterValue.Visible = (cbFilterBy.Text != "None" && cbFilterBy.Text != "Is Released");

            if(cbFilterBy.Text != "Is Released")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
            }

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue.Location = new Point(294 ,206);
                cbIsReleased.Location = new Point(581, 205);
                return;
            }

            if(cbIsReleased.Visible)
            {
                cbIsReleased.SelectedIndex = 0;
                cbIsReleased.Focus();
                cbIsReleased.Location = new Point(294, 205);
                txtFilterValue.Location = new Point(360, 206);
            }
        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";

            //Map Selected Filter to real Column name in Database
            switch (cbFilterBy.Text)
            {
                case "Detain ID":
                    FilterColoumn = "DetainID";
                    break;

                case "Is Released":
                    FilterColoumn = "IsReleased";
                    break;

                case "National No":
                    FilterColoumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColoumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColoumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColoumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColoumn == "None")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (FilterColoumn == "DetainID" || FilterColoumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, txtFilterValue.Text.Trim());
            else
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'" ,FilterColoumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }
        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "IsReleased", FilterValue = cbIsReleased.Text;

            switch(FilterValue)
            {
                case "All":
                    break;

                case "Yes":
                    FilterValue = "1";
                    break;

                case "No":
                    FilterValue = "0";
                    break;
            }

            if(FilterValue == "All")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }

            //in this case we deal with numbers not string.
            _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, FilterValue);
            lblRecordsCount.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase DetainID or ReleaseAppID is selected.
            if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(dgvDetainedLicenses.CurrentRow.Cells[6].Value.ToString()); // Find By National No
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);

            /*
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.Find(LicenseID).DriverInfo.PersonID;

            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();*/
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLicense License = clsLicense.FindLicenseByID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);

            if(License == null)
            {
                MessageBox.Show("No License linked to this Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(License.DriverInfo.PersonID);
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);

            /*
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            int PersonID = clsLicense.Find(LicenseID).DriverInfo.PersonID;
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();*/
        }

        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDetainedLicenses_Load(null, null);
        }

        private void cmsListDetainedLIcenses_Opening(object sender, CancelEventArgs e)
        {
            tsmReleaseDetainedLicense.Enabled = !(bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value;
        }
    }
}