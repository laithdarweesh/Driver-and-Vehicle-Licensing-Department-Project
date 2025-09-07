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

namespace DVLD_Project.Applications.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        clsApplicationType _ApplicationType;
        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _LoadData()
        {
            _ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if(_ApplicationType == null)
            {
                MessageBox.Show("Application ID [" + _ApplicationTypeID + "] Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblApplicationTypeId.Text = _ApplicationType.ID.ToString();
            txtTitle.Text = _ApplicationType.Title;
            txtFees.Text = _ApplicationType.Fees.ToString();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error",
                                           "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ApplicationType.Title = txtTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToSingle(txtFees.Text.Trim());

            if((MessageBox.Show("Are you sure to Update Application with ID [" + _ApplicationType.ID + "]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                if (_ApplicationType.Save())
                {
                    MessageBox.Show("Application with ID [" + _ApplicationType.ID + "] Updated Successufully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occured, Data not saved", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title Can't be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTitle, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees Can't be blank");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }

            if(!clsValidation.IsNumber(txtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number!");
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }
    }
}
