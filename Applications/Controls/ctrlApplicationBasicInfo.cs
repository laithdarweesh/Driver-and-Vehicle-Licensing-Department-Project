using DVLD_Buisness;
using DVLD_Project.Global_Classes;
using DVLD_Project.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Controls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private int _ApplicationID = -1;
        private clsApplication _Application;

        public int ApplicationID 
        {
            get { return _ApplicationID; }
        }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }
        public void LoadApplicationInfo(int ApplicationID)
        {
            _Application = clsApplication.FindBaseApplication(ApplicationID);

            if(_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("Application with ID: [" + ApplicationID + "] not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillApplicationInfo();
        }
        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;

            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblStatus.Text = _Application.StatusText;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeInfo.Title;
            lblApplicant.Text = _Application.FullAplicantName;
            lblDate.Text = clsFormat.DateToShort(_Application.ApplicationDate);
            lblLastStatusDate.Text = clsFormat.DateToShort(_Application.LastStatusDate);
            lblCreatedByUser.Text = _Application.CreatedByUserInfo.UserName;
        }
        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblApplicationID.Text = "???";
            lblStatus.Text = "???";
            lblFees.Text = "$$$";
            lblType.Text = "???";
            lblApplicant.Text = "???";
            lblDate.Text = "??/??/????";
            lblLastStatusDate.Text = "??/??/????";
            lblCreatedByUser.Text = "???";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();

            //Refresh
            LoadApplicationInfo(_ApplicationID);
        }
    }
}
