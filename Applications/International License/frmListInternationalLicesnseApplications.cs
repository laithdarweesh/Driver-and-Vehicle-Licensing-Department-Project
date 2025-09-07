using DVLD_Buisness;
using DVLD_Project.Licenses;
using DVLD_Project.Licenses.International_Licenses;
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

namespace DVLD_Project.Applications.International_License
{
    public partial class frmListInternationalLicesnseApplications : Form
    {
        private DataTable _dtInternationalLicense;
        public frmListInternationalLicesnseApplications()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            _dtInternationalLicense = clsInternationalLicense.GetAllInternationalLicenses();
            dgvInternationalLicenses.DataSource = _dtInternationalLicense;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if(dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 140;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 140;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 110;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 130;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 170;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 170;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 130;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None" && cbFilterBy.Text != "Is Active");
            cbIsActive.Visible = (cbFilterBy.Text == "Is Active");

            /*if(cbFilterBy.Text != "Is Active")
            {
                _dtInternationalLicense.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
            }*/

            _dtInternationalLicense.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue.Location = new Point(298, 219);
                cbIsActive.Location = new Point(524 , 218);
                return;
            }

            if(cbIsActive.Visible)
            {
                cbIsActive.SelectedIndex = 0;
                cbIsActive.Focus();
                txtFilterValue.Location = new Point(364, 219);
                cbIsActive.Location = new Point(298, 218);
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "IsActive", FilterValue = cbIsActive.Text;

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
                _dtInternationalLicense.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, FilterValue);

            lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColoumn = "";

            switch(cbFilterBy.Text)
            {
                case "International License ID":
                    FilterColoumn = "InternationalLicenseID";
                    break;

                case "Application ID":
                    FilterColoumn = "ApplicationID";
                    break;

                case "Driver ID":
                    FilterColoumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColoumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColoumn = "IsActive";
                    break;

                default:
                    FilterColoumn = "None";
                    break;
            }

            if(FilterColoumn == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtInternationalLicense.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }

            _dtInternationalLicense.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColoumn, txtFilterValue.Text.Trim());
            lblRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
            frmListInternationalLicesnseApplications_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow numbers only becasue all fiters are numbers.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.Find((int) dgvInternationalLicenses.CurrentRow.Cells[0].Value);

            if(InternationalLicense == null)
            {
                MessageBox.Show("Error: Selected License not related to any Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowPersonInfo frm = new frmShowPersonInfo(InternationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
            frmListInternationalLicesnseApplications_Load(null, null);
        }

        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListInternationalLicesnseApplications_Load(null, null);
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.Find((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);

            if (InternationalLicense == null)
            {
                MessageBox.Show("Error: Selected License not related to any Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(InternationalLicense.DriverInfo.PersonID);
            frm.ShowDialog();
            frmListInternationalLicesnseApplications_Load(null, null);
        }
    }
}