using DVLD_Buisness;
using DVLD_Project.People.Controls;
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

namespace DVLD_Project.People
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllPeople = clsPerson.GetAllPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                       "FirstName", "SecondName", "ThirdName", "LastName", "GendorCaption",
                                       "DateOfBirth", "CountryName", "Phone", "Email");


        private void _RefreshPeopleList()
        {
            _dtAllPeople = clsPerson.GetAllPeople();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                       "FirstName", "SecondName", "ThirdName", "LastName", "GendorCaption",
                                       "DateOfBirth", "CountryName", "Phone", "Email");

            dgvListPeople.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvListPeople.DataSource = _dtPeople;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString(); 

            if(dgvListPeople.Rows.Count > 0)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[0].Width = 105;

                dgvListPeople.Columns[1].HeaderText = "National No";
                dgvListPeople.Columns[1].Width = 120;

                dgvListPeople.Columns[2].HeaderText = "First Name";
                dgvListPeople.Columns[2].Width = 120;

                dgvListPeople.Columns[3].HeaderText = "Second Name";
                dgvListPeople.Columns[3].Width = 140;

                dgvListPeople.Columns[4].HeaderText = "Third Name";
                dgvListPeople.Columns[4].Width = 120;

                dgvListPeople.Columns[5].HeaderText = "Last Name";
                dgvListPeople.Columns[5].Width = 120;

                dgvListPeople.Columns[6].HeaderText = "Gendor";
                dgvListPeople.Columns[6].Width = 120;

                dgvListPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvListPeople.Columns[7].Width = 140;

                dgvListPeople.Columns[8].HeaderText = "Nationality";
                dgvListPeople.Columns[8].Width = 120;

                dgvListPeople.Columns[9].HeaderText = "Phone";
                dgvListPeople.Columns[9].Width = 120;

                dgvListPeople.Columns[10].HeaderText = "Email";
                dgvListPeople.Columns[10].Width = 170;
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");
            txtFilterValue.Text = "";
            txtFilterValue.Focus();

            if (txtFilterValue.Visible)
                btnAddPerson.Location = new Point(520, 229);

            else
                btnAddPerson.Location = new Point(295, 229);
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            //Map Selected Filter to real Column name
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }

            if(FilterColumn == "PersonID")
            {
                //in this case we deal with integer not string.
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            }

            lblRecordsCount.Text = dgvListPeople.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to Delete Person with ID [" + dgvListPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsPerson.DeletePerson((int) dgvListPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person with ID [" + dgvListPeople.CurrentRow.Cells[0].Value + "] " + "Deleted Successufully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListPeople_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new frmShowPersonInfo((int)dgvListPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id is selected.
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
