namespace DVLD_Project.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicesnseApplications
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
            this.components = new System.ComponentModel.Container();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmScheduleTestMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScedhuleVisionTestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScedhuleWrittenTestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScedhuleStreetTestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicensePersonHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).BeginInit();
            this.cmsApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(301, 240);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(216, 26);
            this.txtFilterValue.TabIndex = 59;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(93, 240);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBy.TabIndex = 58;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Find By:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(128, 664);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 55;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "#Records:";
            // 
            // dgvLocalDrivingLicenseApplications
            // 
            this.dgvLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseApplications.AllowUserToResizeRows = false;
            this.dgvLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsApplication;
            this.dgvLocalDrivingLicenseApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalDrivingLicenseApplications.Location = new System.Drawing.Point(9, 285);
            this.dgvLocalDrivingLicenseApplications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLocalDrivingLicenseApplications.MultiSelect = false;
            this.dgvLocalDrivingLicenseApplications.Name = "dgvLocalDrivingLicenseApplications";
            this.dgvLocalDrivingLicenseApplications.ReadOnly = true;
            this.dgvLocalDrivingLicenseApplications.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLocalDrivingLicenseApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDrivingLicenseApplications.Size = new System.Drawing.Size(1350, 371);
            this.dgvLocalDrivingLicenseApplications.TabIndex = 53;
            // 
            // cmsApplication
            // 
            this.cmsApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowApplicationDetails,
            this.toolStripMenuItem1,
            this.tsmDeleteApplication,
            this.tsmEditApplication,
            this.toolStripSeparator1,
            this.tsmCancelApplication,
            this.toolStripSeparator2,
            this.tsmScheduleTestMenue,
            this.toolStripMenuItem2,
            this.tsmIssueDrivingLicense,
            this.toolStripSeparator3,
            this.tsmShowLicense,
            this.toolStripSeparator4,
            this.showLicensePersonHistoryToolStripMenuItem});
            this.cmsApplication.Name = "cmsPeople";
            this.cmsApplication.Size = new System.Drawing.Size(262, 344);
            this.cmsApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplication_Opening);
            // 
            // tsmShowApplicationDetails
            // 
            this.tsmShowApplicationDetails.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowApplicationDetails.Name = "tsmShowApplicationDetails";
            this.tsmShowApplicationDetails.Size = new System.Drawing.Size(261, 38);
            this.tsmShowApplicationDetails.Text = "&Show Application Details";
            this.tsmShowApplicationDetails.Click += new System.EventHandler(this.tsmShowApplicationDetails_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmDeleteApplication
            // 
            this.tsmDeleteApplication.Image = global::DVLD_Project.Properties.Resources.Delete_32_2;
            this.tsmDeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDeleteApplication.Name = "tsmDeleteApplication";
            this.tsmDeleteApplication.Size = new System.Drawing.Size(261, 38);
            this.tsmDeleteApplication.Text = "&Delete Application";
            this.tsmDeleteApplication.Click += new System.EventHandler(this.tsmDeleteApplication_Click);
            // 
            // tsmEditApplication
            // 
            this.tsmEditApplication.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.tsmEditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditApplication.Name = "tsmEditApplication";
            this.tsmEditApplication.Size = new System.Drawing.Size(261, 38);
            this.tsmEditApplication.Text = "&Edit Application";
            this.tsmEditApplication.Click += new System.EventHandler(this.tsmEditApplication_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.tsmCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(261, 38);
            this.tsmCancelApplication.Text = "&Cancel Application";
            this.tsmCancelApplication.Click += new System.EventHandler(this.tsmCancelApplication_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmScheduleTestMenue
            // 
            this.tsmScheduleTestMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScedhuleVisionTestItem,
            this.tsmScedhuleWrittenTestItem,
            this.tsmScedhuleStreetTestItem});
            this.tsmScheduleTestMenue.Image = global::DVLD_Project.Properties.Resources.TestType_32;
            this.tsmScheduleTestMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmScheduleTestMenue.Name = "tsmScheduleTestMenue";
            this.tsmScheduleTestMenue.Size = new System.Drawing.Size(261, 38);
            this.tsmScheduleTestMenue.Text = "Schedule &Test";
            // 
            // tsmScedhuleVisionTestItem
            // 
            this.tsmScedhuleVisionTestItem.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.tsmScedhuleVisionTestItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmScedhuleVisionTestItem.Name = "tsmScedhuleVisionTestItem";
            this.tsmScedhuleVisionTestItem.Size = new System.Drawing.Size(203, 38);
            this.tsmScedhuleVisionTestItem.Text = "Schedule &Vision Test";
            this.tsmScedhuleVisionTestItem.Click += new System.EventHandler(this.tsmScedhuleVisionTestItem_Click);
            // 
            // tsmScedhuleWrittenTestItem
            // 
            this.tsmScedhuleWrittenTestItem.Image = global::DVLD_Project.Properties.Resources.Written_Test_32;
            this.tsmScedhuleWrittenTestItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmScedhuleWrittenTestItem.Name = "tsmScedhuleWrittenTestItem";
            this.tsmScedhuleWrittenTestItem.Size = new System.Drawing.Size(203, 38);
            this.tsmScedhuleWrittenTestItem.Text = "Schedule &Written Test";
            this.tsmScedhuleWrittenTestItem.Click += new System.EventHandler(this.tsmScedhuleWrittenTestItem_Click);
            // 
            // tsmScedhuleStreetTestItem
            // 
            this.tsmScedhuleStreetTestItem.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.tsmScedhuleStreetTestItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmScedhuleStreetTestItem.Name = "tsmScedhuleStreetTestItem";
            this.tsmScedhuleStreetTestItem.Size = new System.Drawing.Size(203, 38);
            this.tsmScedhuleStreetTestItem.Text = "Schedule &Street Test";
            this.tsmScedhuleStreetTestItem.Click += new System.EventHandler(this.tsmScedhuleStreetTestItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmIssueDrivingLicense
            // 
            this.tsmIssueDrivingLicense.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.tsmIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmIssueDrivingLicense.Name = "tsmIssueDrivingLicense";
            this.tsmIssueDrivingLicense.Size = new System.Drawing.Size(261, 38);
            this.tsmIssueDrivingLicense.Text = "&Issue Driving License (First Time)";
            this.tsmIssueDrivingLicense.Click += new System.EventHandler(this.tsmIssueDrivingLicense_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.tsmShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(261, 38);
            this.tsmShowLicense.Text = "Show &License";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // showLicensePersonHistoryToolStripMenuItem
            // 
            this.showLicensePersonHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.showLicensePersonHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicensePersonHistoryToolStripMenuItem.Name = "showLicensePersonHistoryToolStripMenuItem";
            this.showLicensePersonHistoryToolStripMenuItem.Size = new System.Drawing.Size(261, 38);
            this.showLicensePersonHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showLicensePersonHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicensePersonHistoryToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(397, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 37);
            this.label3.TabIndex = 63;
            this.label3.Text = "Local Driving License Applications";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Local_32;
            this.pictureBox1.Location = new System.Drawing.Point(696, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pbLocalDrivingLicense
            // 
            this.pbLocalDrivingLicense.Image = global::DVLD_Project.Properties.Resources.Applications;
            this.pbLocalDrivingLicense.Location = new System.Drawing.Point(511, 2);
            this.pbLocalDrivingLicense.Margin = new System.Windows.Forms.Padding(5);
            this.pbLocalDrivingLicense.Name = "pbLocalDrivingLicense";
            this.pbLocalDrivingLicense.Size = new System.Drawing.Size(251, 182);
            this.pbLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocalDrivingLicense.TabIndex = 61;
            this.pbLocalDrivingLicense.TabStop = false;
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewApplication.Image = global::DVLD_Project.Properties.Resources.Add_New_User_72;
            this.btnAddNewApplication.Location = new System.Drawing.Point(1270, 214);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(88, 69);
            this.btnAddNewApplication.TabIndex = 60;
            this.btnAddNewApplication.UseVisualStyleBackColor = true;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1233, 660);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListLocalDrivingLicesnseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLocalDrivingLicense);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalDrivingLicenseApplications);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListLocalDrivingLicesnseApplications";
            this.Text = "List Local Driving Licesnse Applications";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicesnseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseApplications)).EndInit();
            this.cmsApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLocalDrivingLicense;
        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmShowApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmIssueDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showLicensePersonHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleTestMenue;
        private System.Windows.Forms.ToolStripMenuItem tsmScedhuleVisionTestItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScedhuleWrittenTestItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScedhuleStreetTestItem;
    }
}