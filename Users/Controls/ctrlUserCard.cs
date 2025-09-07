using DVLD_Buisness;
using System;
using System.Windows.Forms;

namespace DVLD_Project.Users.Controls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserId = -1;
        private clsUser _User;

        public int UserId
        {
            get { return _UserId; }
        }

        public clsUser SelectedUser
        {
            get { return _User; }
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserId)
        {
            _User = clsUser.FindByUserID(UserId);

            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show("User with ID [" + UserId + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);

            lblUserId.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;

            if (_User.IsActive)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }

        private void ResetUserInfo()
        {
            ctrlPersonCard1.ResetPersonInfo();

            lblUserId.Text = "?";
            lblUserName.Text = "?";
            lblIsActive.Text = "?";
        }
    }
}
