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

namespace DVLD_Project.Tests.TestTypes
{
    public partial class frmEditTestType : Form
    {
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private clsTestType _TestType;
        public frmEditTestType(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            _TestType = clsTestType.Find(_TestTypeID);

            if(_TestType != null ) 
            {
                lblTestTypeId.Text = ((int)_TestType.ID).ToString();
                txtTitle.Text = _TestType.Title;
                txtDescription.Text = _TestType.Description;
                txtFees.Text = _TestType.Fees.ToString();

                txtTitle.Focus();
            }
            else
            {
                MessageBox.Show("Test Type ID [" + _TestTypeID.ToString() + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                                           "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType.Title = txtTitle.Text.Trim();
            _TestType.Description = txtDescription.Text.Trim();
            _TestType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if(MessageBox.Show("Are you sure to Edit Test Type ID [" + (int)_TestType.ID + "]", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(_TestType.Save())
                {
                    MessageBox.Show("Test Type ID [" + (int)_TestType.ID + "] Edited Successufully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occured: Cann't Edit Test Type ID [" + (int)_TestType.ID + "]", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title Cann't be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Description Cann't be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees Cann't be blank");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }

            if(!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number");
            }
        }
    }
}
