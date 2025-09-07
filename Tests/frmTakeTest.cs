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

namespace DVLD_Project.Tests
{
    public partial class frmTakeTest : Form
    {
        private clsTestType.enTestType _TestTypeID;
        private int _AppointmentID = -1;
        private int _TestID = -1;

        private clsTest _Test;
        public frmTakeTest(int AppointmentID, clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            _AppointmentID = AppointmentID;
            _TestTypeID = TestTypeID;
        }
        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestTypeID = _TestTypeID;
            ctrlScheduledTest1.LoadInfo(_AppointmentID);

            if(ctrlScheduledTest1.TestAppointmentID == -1)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;

            _TestID = ctrlScheduledTest1.TestID;

            if (_TestID != -1)
            {
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                lblUserMessage.Visible = true;
                
                _Test = clsTest.Find(_TestID);

                if (_Test == null)
                {
                    MessageBox.Show("Error: No Taken Test with ID [" + _TestID.ToString() + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;

                txtNotes.Text = _Test.Notes;

                return;
            }

            _Test = new clsTest();
            lblUserMessage.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_TestID != -1)
            {
                if (MessageBox.Show("Are you sure you want to save?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to save? After that you cann't change Pass/Fail result after you save?..", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
                {
                    if(_TestID != -1)
                    {
                        MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if(_Test.TestResult)
                    {
                        MessageBox.Show("Congratulations, you Passed this Test", "Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbPass.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Sorry, you fail to pass this Test", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbFail.Checked = true;
                    }
                    
                    lblUserMessage.Visible = true;
                    rbPass.Enabled = false;
                    rbFail.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error: Data is not Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}