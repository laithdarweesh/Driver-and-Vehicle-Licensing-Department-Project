using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserId = -1;
        private clsUser _User;
        public frmChangePassword(int UserId)
        {
            InitializeComponent();
            _UserId = UserId;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _User = clsUser.FindByUserID(_UserId);

            if (_User == null)
            {
                MessageBox.Show("User with ID [" + _UserId + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlUserCard1.LoadUserInfo(_UserId);
        }
        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "New Password Can't be blank");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim()) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                                           "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = clsUser.HashPassword(txtNewPassword.Text.Trim());

            if(_User.Save())
            {
                MessageBox.Show("Password Changed Successyufuly", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("An Error Occured, Password did not change", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password Can't be blank");
                return;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if (clsUser.HashPassword(txtCurrentPassword.Text.Trim()) != _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password is Wrong");
                return;
            }
        }
    }
}