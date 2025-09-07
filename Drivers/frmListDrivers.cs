using DVLD_Buisness;
using DVLD_Project.Licenses;
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

namespace DVLD_Project.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtAllDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _dtAllDrivers = clsDriver.GetAllDrivers();
            dgvListDrivers.DataSource = _dtAllDrivers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvListDrivers.Rows.Count.ToString();

            if(dgvListDrivers.Rows.Count > 0)
            {
                dgvListDrivers.Columns[0].HeaderText = "Driver ID";
                dgvListDrivers.Columns[0].Width = 100;

                dgvListDrivers.Columns[1].HeaderText = "Person ID";
                dgvListDrivers.Columns[1].Width = 105;

                dgvListDrivers.Columns[2].HeaderText = "National No";
                dgvListDrivers.Columns[2].Width = 120;

                dgvListDrivers.Columns[3].HeaderText = "Full Name";
                dgvListDrivers.Columns[3].Width = 305;

                dgvListDrivers.Columns[4].HeaderText = "Date";
                dgvListDrivers.Columns[4].Width = 170;

                dgvListDrivers.Columns[5].HeaderText = "Active Licenses";
                dgvListDrivers.Columns[5].Width = 145;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if(txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListDrivers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "DriverID" || FilterColumn == "PersonID")
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = dgvListDrivers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase Driver ID or Person ID is selected.
            if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmShowPersonInfo_Click(object sender, EventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo((int) dgvListDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            frmListDrivers_Load(null, null);
        }
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory((int) dgvListDrivers.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
    }
}
