﻿using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.Local_Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> Handler = OnLicenseSelected;
            
            if(Handler != null)
            {
                Handler(LicenseID);
            }
        }
        private int _LicenseID = -1;
        public int LicenseID
        {
            get { return ctrlDriverLicenseInfo1.LicenseID; }
        }
        public clsLicense SelectedLicenseInfo
        {
            get { return ctrlDriverLicenseInfo1.SelectedLicenseInfo; }
        }
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            set 
            {
                _FilterEnabled = value; 
                gbFilter.Enabled = _FilterEnabled;
            }
            get
            {
                return _FilterEnabled;
            }
        }
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadLicenseInfo(LicenseID);  
            _LicenseID = ctrlDriverLicenseInfo1.LicenseID; 

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LicenseID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _LicenseID = int.Parse(txtLicenseID.Text);
            LoadLicenseInfo(_LicenseID);
        }
        public void txtLicenseIDFocus()
        {
            txtLicenseID.Focus();
        }
        private void txtLicenseID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtLicenseID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseID, "This field is required");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtLicenseID, null);
            }
        }
        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }
        }
    }
}
