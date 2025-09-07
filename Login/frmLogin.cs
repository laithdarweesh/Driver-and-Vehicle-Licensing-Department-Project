using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                chkRememberMe.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = clsUser.HashPassword(txtPassword.Text.Trim());
            clsUser User = clsUser.FindByUserNameAndPassword(txtUserName.Text.Trim(), Password);

            if(User == null)
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid UserName/Password", "Wrong Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!User.IsActive)
            {
                txtUserName.Focus();
                MessageBox.Show("Your Account is Deactive, Contact your Admin", "Deactivated Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(chkRememberMe.Checked)
            {
                clsGlobal.SaveUserNameAndPasswordToRegistry(txtUserName.Text.Trim(), txtPassword.Text.Trim());
                //clsGlobal.RememberUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
            }
            else
            {
                clsGlobal.SaveUserNameAndPasswordToRegistry("", "");
                //clsGlobal.RememberUserNameAndPassword("", "");
            }

            clsGlobal.CurrentUser = User;
            this.Hide();
            frmMain frm = new frmMain(this);
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text.Trim()) ) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "User Name Can Not be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Can Not be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }
    }
}