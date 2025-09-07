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
    public partial class frmListUsers : Form
    {
        private static DataTable _dtAllUsers = clsUser.GetAllUsers();
        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID","PersonID", "UserName", "FullName", "IsActive");
        public frmListUsers()
        {
            InitializeComponent();
        }
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _RefreshListUsers();

            if (dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 110;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 120;

                dgvListUsers.Columns[2].HeaderText = "User Name";
                dgvListUsers.Columns[2].Width = 120;

                dgvListUsers.Columns[3].HeaderText = "Full Name";
                dgvListUsers.Columns[3].Width = 350;

                dgvListUsers.Columns[4].HeaderText = "Is Active";
                dgvListUsers.Columns[4].Width = 120;
            }
        }
        private void _RefreshListUsers()
        {
            _dtAllUsers = clsUser.GetAllUsers();
           _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID", "UserName", "FullName", "IsActive");

            dgvListUsers.DataSource = _dtUsers;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None") && (cbFilterBy.Text != "IsActive");
            cbIsActive.Visible = (cbFilterBy.Text == "IsActive");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
                txtFilterValue.Location = new Point(338, 223);
                cbIsActive.Location = new Point(564, 223);
            }

            if (cbIsActive.Visible)
            {
                cbIsActive.SelectedIndex = 0;
                cbIsActive.Location = new Point(338, 223);
            }

            /*if (cbFilterBy.Text == "None" || cbFilterBy.Text == "IsActive")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
            }*/
            _dtUsers.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "IsActive":
                    FilterColumn = "IsActive";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "UserID" || FilterColumn == "PersonID")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
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

            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = dgvListUsers.Rows.Count.ToString();
        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete User with ID [" + dgvListUsers.CurrentRow.Cells[0].Value + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvListUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User with ID [" + (int)dgvListUsers.CurrentRow.Cells[0].Value + "] " + "Deleted Successufully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUsers_Load(null, null);
                    //_RefreshListUsers();
                }
                else
                {
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangePasswordtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This features not Implemented yet");
        }

        private void PhoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This features not Implemented yet");
        }
    }
}