using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.People
{
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1}
        enum enGendor { Male = 0, Female = 1}

        enMode _Mode = enMode.AddNew;
        private int _PersonId = -1;
        clsPerson _Person;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdatePerson(int PersonId)
        {
            InitializeComponent();
            _PersonId = PersonId;
            _Mode = enMode.Update;
        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();

            if (_Mode == enMode.AddNew ) 
            {
                _Person = new clsPerson();
                _ResetDefaultValues();
                return;
            }

            else
            {
                _Person = clsPerson.Find(_PersonId);
            }
            
            if (_Person == null)
            {
                MessageBox.Show("Person with ID: " + _PersonId + " Not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            lblModeTitle.Text = "Update Person";
            lblPersonId.Text = _PersonId.ToString();

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            CbCountries.SelectedIndex = CbCountries.FindString(_Person.CountryInfo.CountryName);
            txtAddress.Text = _Person.Address;

            if(_Person.ImagePath != "")
                PbPersonImage.ImageLocation = _Person.ImagePath;

            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void _ResetDefaultValues()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            CbCountries.SelectedIndex = CbCountries.FindString("Jordan");
            txtAddress.Text = "";
            PbPersonImage.Image = Resources.Male_512;
            llRemoveImage.Visible = false;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow Row in dtCountries.Rows)
            {
                CbCountries.Items.Add(Row["CountryName"]);
            }
        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.

            
            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != PbPersonImage.ImageLocation)
            {
                if(_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.
#pragma warning disable CS0168 // Variable is declared but never used
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch(IOException IO)
                    {
                        // We could not delete the file.
                        //log it later  
                    }
#pragma warning restore CS0168 // Variable is declared but never used
                }

                if (PbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it

                    string SourceImageFile = PbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        PbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int NationalityCountryId = clsCountry.Find(CbCountries.Text).CountryID;

            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _HandlePersonImage();

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;

            if (rbMale.Checked)
                _Person.Gendor = (byte)enGendor.Male;
            else
                _Person.Gendor = (byte)enGendor.Female;

            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.NationalityCountryID = NationalityCountryId;
            _Person.Address = txtAddress.Text.Trim();

            if (PbPersonImage.ImageLocation != null)
                _Person.ImagePath = PbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            llRemoveImage.Visible = (PbPersonImage.ImageLocation != null);

            if (_Mode == enMode.AddNew)
            {
                if(_Person.Save())
                {
                    MessageBox.Show("New Person Added to System Successufuly with ID : " + _Person.PersonID.ToString(), "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.Update;
                    lblPersonId.Text = _Person.PersonID.ToString();
                    lblModeTitle.Text = "Update Person";
                    DataBack?.Invoke(this, _Person.PersonID);
                }
                else
                {
                    MessageBox.Show("Error: an Error occurred preventing a New Person from being added to the System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                if(_Person.Save())
                {
                    MessageBox.Show("Person Info Updated Successufuly", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBack?.Invoke(this, _Person.PersonID);
                }
                else
                {
                    MessageBox.Show("Error: Person Info is not Updated Successufuly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                PbPersonImage.Load(SelectedFilePath);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                PbPersonImage.Image = Resources.Male_512;
            else
                PbPersonImage.Image = Resources.Female_512;

            llRemoveImage.Visible = false;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if(PbPersonImage.ImageLocation == null)
                PbPersonImage.Image = Resources.Male_512;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (PbPersonImage.ImageLocation == null)
                PbPersonImage.Image = Resources.Female_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer
            TextBox Temp = ((TextBox)sender);

            if(string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
                return;

            if(!clsValidation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }
        }
    }
}
