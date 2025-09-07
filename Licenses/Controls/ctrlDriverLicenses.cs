using DVLD_Buisness;
using DVLD_Project.Licenses.International_Licenses;
using DVLD_Project.Licenses.Local_Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID = -1;
        private clsDriver _Driver;
        
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }
        private void _LoadLoacalLicenseInfo()
        {
            _dtDriverLocalLicensesHistory = clsDriver.GetLicenses(_DriverID);
            dgvLocalLicensesHistory.DataSource = _dtDriverLocalLicensesHistory;
            lblLocalLicensesRecords.Text = dgvLocalLicensesHistory.Rows.Count.ToString();

            if(dgvLocalLicensesHistory.Rows.Count > 0)
            {
                dgvLocalLicensesHistory.Columns[0].HeaderText = "License ID";
                dgvLocalLicensesHistory.Columns[0].Width = 110;

                dgvLocalLicensesHistory.Columns[1].HeaderText = "Application ID";
                dgvLocalLicensesHistory.Columns[1].Width = 135;

                dgvLocalLicensesHistory.Columns[2].HeaderText = "Class Name";
                dgvLocalLicensesHistory.Columns[2].Width = 250;

                dgvLocalLicensesHistory.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicensesHistory.Columns[3].Width = 160;

                dgvLocalLicensesHistory.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicensesHistory.Columns[4].Width = 160;

                dgvLocalLicensesHistory.Columns[5].HeaderText = "Is Active";
                dgvLocalLicensesHistory.Columns[5].Width = 110;
            }
        }
        private void _LoadInternationalLicenseInfo()
        {
            _dtDriverInternationalLicensesHistory = clsDriver.GetInternationalLicenses(_DriverID);
            dgvInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationalLicensesRecord.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "International License ID";
                dgvInternationalLicenses.Columns[0].Width = 210;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 140;

                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 130;

                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 165;

                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 165;

                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 115;
            }
        }
        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = clsDriver.FindByDriverID(_DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("There is no Driver with ID [" + _DriverID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadLoacalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }
        public void LoadInfoByPersonID(int PersonID)
        {
            _Driver = clsDriver.FindByPersonID(PersonID);

            if(_Driver == null)
            {
                MessageBox.Show("There is no Driver linked with Person ID [" + PersonID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;
            _LoadLoacalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }
        private void tsmShowLocalLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = 
                new frmShowLicenseInfo((int) dgvLocalLicensesHistory.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tsmShowInternationalLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}