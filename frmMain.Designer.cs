namespace DVLD_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMainMenue = new System.Windows.Forms.MenuStrip();
            this.ApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewDrivingLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalDrivingLicence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReplacementForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.PeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenue
            // 
            this.msMainMenue.BackColor = System.Drawing.Color.White;
            this.msMainMenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.msMainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplicationsToolStripMenuItem,
            this.PeopleToolStripMenuItem,
            this.DriversToolStripMenuItem,
            this.UsersToolStripMenuItem,
            this.AccountSettingsToolStripMenuItem});
            this.msMainMenue.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenue.Location = new System.Drawing.Point(0, 0);
            this.msMainMenue.Name = "msMainMenue";
            this.msMainMenue.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMainMenue.Size = new System.Drawing.Size(1364, 72);
            this.msMainMenue.TabIndex = 1;
            this.msMainMenue.Text = "menuStrip1";
            this.msMainMenue.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMainMenue_ItemClicked);
            // 
            // ApplicationsToolStripMenuItem
            // 
            this.ApplicationsToolStripMenuItem.DoubleClickEnabled = true;
            this.ApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDrivingLicensesServices,
            this.toolStripMenuItem1,
            this.tsmManageApplications,
            this.toolStripMenuItem2,
            this.tsmDetainLicenses,
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes});
            this.ApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Applications_64;
            this.ApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
            this.ApplicationsToolStripMenuItem.Size = new System.Drawing.Size(182, 68);
            this.ApplicationsToolStripMenuItem.Text = "&Applications";
            // 
            // tsmDrivingLicensesServices
            // 
            this.tsmDrivingLicensesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewDrivingLicence,
            this.tsmRenewDrivingLicense,
            this.toolStripMenuItem3,
            this.tsmReplacementForLostOrDamagedLicense,
            this.toolStripMenuItem4,
            this.tsmReleaseDetainedDrivingLicense,
            this.tsmRetakeTest});
            this.tsmDrivingLicensesServices.Image = global::DVLD_Project.Properties.Resources.Driver_License_48;
            this.tsmDrivingLicensesServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDrivingLicensesServices.Name = "tsmDrivingLicensesServices";
            this.tsmDrivingLicensesServices.Size = new System.Drawing.Size(331, 70);
            this.tsmDrivingLicensesServices.Text = "&Driving Licenses Services";
            // 
            // tsmNewDrivingLicence
            // 
            this.tsmNewDrivingLicence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicence,
            this.tsmInternationalDrivingLicence});
            this.tsmNewDrivingLicence.Image = global::DVLD_Project.Properties.Resources.New_Driving_License_32;
            this.tsmNewDrivingLicence.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmNewDrivingLicence.Name = "tsmNewDrivingLicence";
            this.tsmNewDrivingLicence.Size = new System.Drawing.Size(415, 38);
            this.tsmNewDrivingLicence.Text = "&New Driving Licence";
            // 
            // tsmLocalDrivingLicence
            // 
            this.tsmLocalDrivingLicence.Image = global::DVLD_Project.Properties.Resources.Local_32;
            this.tsmLocalDrivingLicence.Name = "tsmLocalDrivingLicence";
            this.tsmLocalDrivingLicence.Size = new System.Drawing.Size(241, 26);
            this.tsmLocalDrivingLicence.Text = "&Local Licence";
            this.tsmLocalDrivingLicence.Click += new System.EventHandler(this.tsmLocalDrivingLicence_Click);
            // 
            // tsmInternationalDrivingLicence
            // 
            this.tsmInternationalDrivingLicence.BackColor = System.Drawing.Color.White;
            this.tsmInternationalDrivingLicence.Image = global::DVLD_Project.Properties.Resources.International_321;
            this.tsmInternationalDrivingLicence.Name = "tsmInternationalDrivingLicence";
            this.tsmInternationalDrivingLicence.Size = new System.Drawing.Size(241, 26);
            this.tsmInternationalDrivingLicence.Text = "&International Licence";
            this.tsmInternationalDrivingLicence.Click += new System.EventHandler(this.tsmInternationalDrivingLicence_Click);
            // 
            // tsmRenewDrivingLicense
            // 
            this.tsmRenewDrivingLicense.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.tsmRenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmRenewDrivingLicense.Name = "tsmRenewDrivingLicense";
            this.tsmRenewDrivingLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmRenewDrivingLicense.Text = "&Renew Driving License";
            this.tsmRenewDrivingLicense.Click += new System.EventHandler(this.tsmRenewDrivingLicense_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmReplacementForLostOrDamagedLicense
            // 
            this.tsmReplacementForLostOrDamagedLicense.Image = global::DVLD_Project.Properties.Resources.Damaged_Driving_License_32;
            this.tsmReplacementForLostOrDamagedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReplacementForLostOrDamagedLicense.Name = "tsmReplacementForLostOrDamagedLicense";
            this.tsmReplacementForLostOrDamagedLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmReplacementForLostOrDamagedLicense.Text = "Replacement for Lost or &Damaged License";
            this.tsmReplacementForLostOrDamagedLicense.Click += new System.EventHandler(this.tsmReplacementForLostOrDamagedLicense_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmReleaseDetainedDrivingLicense
            // 
            this.tsmReleaseDetainedDrivingLicense.Image = global::DVLD_Project.Properties.Resources.Detained_Driving_License_321;
            this.tsmReleaseDetainedDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReleaseDetainedDrivingLicense.Name = "tsmReleaseDetainedDrivingLicense";
            this.tsmReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            this.tsmReleaseDetainedDrivingLicense.Click += new System.EventHandler(this.tsmReleaseDetainedDrivingLicense_Click);
            // 
            // tsmRetakeTest
            // 
            this.tsmRetakeTest.Image = global::DVLD_Project.Properties.Resources.Retake_Test_32;
            this.tsmRetakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmRetakeTest.Name = "tsmRetakeTest";
            this.tsmRetakeTest.Size = new System.Drawing.Size(415, 38);
            this.tsmRetakeTest.Text = "Retake Test";
            this.tsmRetakeTest.Click += new System.EventHandler(this.tsmRetakeTest_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(328, 6);
            // 
            // tsmManageApplications
            // 
            this.tsmManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicenseApplications,
            this.tsmInternationalLicenseApplications});
            this.tsmManageApplications.Image = global::DVLD_Project.Properties.Resources.Manage_Applications_64;
            this.tsmManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageApplications.Name = "tsmManageApplications";
            this.tsmManageApplications.Size = new System.Drawing.Size(331, 70);
            this.tsmManageApplications.Text = "Manage Applications";
            // 
            // tsmLocalDrivingLicenseApplications
            // 
            this.tsmLocalDrivingLicenseApplications.Image = global::DVLD_Project.Properties.Resources.LocalDriving_License;
            this.tsmLocalDrivingLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmLocalDrivingLicenseApplications.Name = "tsmLocalDrivingLicenseApplications";
            this.tsmLocalDrivingLicenseApplications.Size = new System.Drawing.Size(357, 38);
            this.tsmLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.tsmLocalDrivingLicenseApplications.Click += new System.EventHandler(this.tsmLocalDrivingLicenseApplications_Click);
            // 
            // tsmInternationalLicenseApplications
            // 
            this.tsmInternationalLicenseApplications.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.tsmInternationalLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmInternationalLicenseApplications.Name = "tsmInternationalLicenseApplications";
            this.tsmInternationalLicenseApplications.Size = new System.Drawing.Size(357, 38);
            this.tsmInternationalLicenseApplications.Text = "International License Applications";
            this.tsmInternationalLicenseApplications.Click += new System.EventHandler(this.tsmInternationalLicenseApplications_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(328, 6);
            // 
            // tsmDetainLicenses
            // 
            this.tsmDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageDetainedLicenses,
            this.tsmDetainLicense,
            this.tsmReleaseDetainedLicense});
            this.tsmDetainLicenses.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.tsmDetainLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDetainLicenses.Name = "tsmDetainLicenses";
            this.tsmDetainLicenses.Size = new System.Drawing.Size(331, 70);
            this.tsmDetainLicenses.Text = "Detain Licenses";
            // 
            // tsmManageDetainedLicenses
            // 
            this.tsmManageDetainedLicenses.Image = global::DVLD_Project.Properties.Resources.Detain_32;
            this.tsmManageDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageDetainedLicenses.Name = "tsmManageDetainedLicenses";
            this.tsmManageDetainedLicenses.Size = new System.Drawing.Size(300, 38);
            this.tsmManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.tsmManageDetainedLicenses.Click += new System.EventHandler(this.tsmManageDetainedLicenses_Click);
            // 
            // tsmDetainLicense
            // 
            this.tsmDetainLicense.Image = global::DVLD_Project.Properties.Resources.Detain_321;
            this.tsmDetainLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDetainLicense.Name = "tsmDetainLicense";
            this.tsmDetainLicense.Size = new System.Drawing.Size(300, 38);
            this.tsmDetainLicense.Text = "Detain License";
            this.tsmDetainLicense.Click += new System.EventHandler(this.tsmDetainLicense_Click);
            // 
            // tsmReleaseDetainedLicense
            // 
            this.tsmReleaseDetainedLicense.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_321;
            this.tsmReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReleaseDetainedLicense.Name = "tsmReleaseDetainedLicense";
            this.tsmReleaseDetainedLicense.Size = new System.Drawing.Size(300, 38);
            this.tsmReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmReleaseDetainedLicense.Click += new System.EventHandler(this.tsmReleaseDetainedLicense_Click);
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Image = global::DVLD_Project.Properties.Resources.Application_Types_64;
            this.tsmManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(331, 70);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Image = global::DVLD_Project.Properties.Resources.Test_Type_64;
            this.tsmManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(331, 70);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // PeopleToolStripMenuItem
            // 
            this.PeopleToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.People_64;
            this.PeopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PeopleToolStripMenuItem.Name = "PeopleToolStripMenuItem";
            this.PeopleToolStripMenuItem.Size = new System.Drawing.Size(139, 68);
            this.PeopleToolStripMenuItem.Text = "People";
            this.PeopleToolStripMenuItem.Click += new System.EventHandler(this.PeopleToolStripMenuItem_Click);
            // 
            // DriversToolStripMenuItem
            // 
            this.DriversToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Drivers_64;
            this.DriversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DriversToolStripMenuItem.Name = "DriversToolStripMenuItem";
            this.DriversToolStripMenuItem.Size = new System.Drawing.Size(140, 68);
            this.DriversToolStripMenuItem.Text = "Drivers";
            this.DriversToolStripMenuItem.Click += new System.EventHandler(this.DriversToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Users_2_64;
            this.UsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(127, 68);
            this.UsersToolStripMenuItem.Text = "Users";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // AccountSettingsToolStripMenuItem
            // 
            this.AccountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrentUserInfo,
            this.tsmChangePassw,
            this.toolStripMenuItem5,
            this.tsmSignOut});
            this.AccountSettingsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.account_settings_64;
            this.AccountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountSettingsToolStripMenuItem.Name = "AccountSettingsToolStripMenuItem";
            this.AccountSettingsToolStripMenuItem.Size = new System.Drawing.Size(215, 68);
            this.AccountSettingsToolStripMenuItem.Text = "Account Settings";
            this.AccountSettingsToolStripMenuItem.Click += new System.EventHandler(this.AccountSettingsToolStripMenuItem_Click);
            // 
            // tsmCurrentUserInfo
            // 
            this.tsmCurrentUserInfo.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCurrentUserInfo.Name = "tsmCurrentUserInfo";
            this.tsmCurrentUserInfo.Size = new System.Drawing.Size(230, 38);
            this.tsmCurrentUserInfo.Text = "&Current User Info";
            this.tsmCurrentUserInfo.Click += new System.EventHandler(this.tsmCurrentUserInfo_Click);
            // 
            // tsmChangePassw
            // 
            this.tsmChangePassw.Image = global::DVLD_Project.Properties.Resources.Password_32;
            this.tsmChangePassw.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassw.Name = "tsmChangePassw";
            this.tsmChangePassw.Size = new System.Drawing.Size(230, 38);
            this.tsmChangePassw.Text = "Change Password";
            this.tsmChangePassw.Click += new System.EventHandler(this.tsmChangePassw_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(227, 6);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = global::DVLD_Project.Properties.Resources.sign_out_32__2;
            this.tsmSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(230, 38);
            this.tsmSignOut.Text = "Sign &Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Logo_Final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMainMenue);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMainMenue.ResumeLayout(false);
            this.msMainMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenue;
        private System.Windows.Forms.ToolStripMenuItem ApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DriversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivingLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem tsmNewDrivingLicence;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicence;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalDrivingLicence;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmRenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReplacementForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmRetakeTest;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassw;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedLicense;
    }
}

