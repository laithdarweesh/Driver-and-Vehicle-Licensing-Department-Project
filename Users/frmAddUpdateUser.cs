using DVLD_Buisness;
using DVLD_Project.People.Controls;
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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode = enMode.AddNew;

        private int _UserId = -1;
        private clsUser _User;
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _User = new clsUser();
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserId = UserID;
            _Mode = enMode.Update;
            _User = clsUser.FindByUserID(_UserId);
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            if (_User == null)
            {
                MessageBox.Show("User with ID [" + _UserId + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                btnSave.Enabled = false;
                tpLoginInfo.Enabled = false;
                chkIsActive.Checked = true;
                return;
            }

            lblTitle.Text = "Update User";
            this.Text = "Update User";
            ctrlPersonCardWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardWithFilter1.FilterEnabled = false;
            tpLoginInfo.Enabled = true;

            lblUserId.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            //txtPassword.Text = _User.Password;
            //txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }

            if(ctrlPersonCardWithFilter1.PersonId != -1)
            {
                if (clsUser.IsUserExistForPersonID(ctrlPersonCardWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one", "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter1.FilterFocus();
                    return;
                }

                else
                {
                    _User.PersonID = ctrlPersonCardWithFilter1.PersonId;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }
            }

            else
            {
                MessageBox.Show("Please Select a Person", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ctrlPersonCardWithFilter1.FilterFocus();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                                           "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            _User.UserName = txtUserName.Text.Trim();
            _User.Password = clsUser.HashPassword(txtPassword.Text.Trim());
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {
                if(_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update User";
                    this.Text = "Update User";
                    lblUserId.Text = _User.UserID.ToString();
                    MessageBox.Show("User Added Successufully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Updated Successufully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if(_Mode == enMode.AddNew)
                    MessageBox.Show("Error: Can't Added this Person as User", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error: Can't Updated this User", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateEmptyTextBox(txtUserName, e, "UserName can't be blank"))
            {
                btnSave.Enabled = false;
                return;
            }
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (ValidateUserName())

            {
                errorProvider1.SetError(txtUserName, "UserName is for another Person");
                btnSave.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(txtUserName, null);

                if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "" && txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                    btnSave.Enabled = true;
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateEmptyTextBox(txtPassword, e, "Password can't be blank"))
            {
                btnSave.Enabled = false;
                return;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != "" && txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim() && txtUserName.Text.Trim() != "" && !ValidateUserName())
            {
                btnSave.Enabled = true;
            }

            else
            {
                btnSave.Enabled = false;
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtPassword.Text.Trim() != "" && !ValidateEmptyTextBox(txtConfirmPassword, e, "Confirm Password can't be blank"))
            {
                btnSave.Enabled = false;
                return;
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() != "" && txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password must match Password");
                btnSave.Enabled = false;
            }

            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);

                if(txtPassword.Text.Trim() != "" && txtUserName.Text.Trim() != "" && !(ValidateUserName()))
                {
                    btnSave.Enabled = true;
                }
            }
        }
        private bool ValidateEmptyTextBox(object sender, CancelEventArgs e, string ErrorMessage)
        {
            if (string.IsNullOrEmpty(((TextBox)sender).Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError((TextBox)sender, ErrorMessage);
                return false;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError((TextBox)sender, null);
                return true;
            }
        }
        private bool ValidateUserName()
        {
            if (_Mode == enMode.AddNew)
                return (clsUser.IsUserExist(txtUserName.Text.Trim()));
            else
                return (clsUser.IsUserExist(txtUserName.Text.Trim()) && txtUserName.Text.Trim() != _User.UserName);
        }
        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.FilterFocus();
        }
    }
}
