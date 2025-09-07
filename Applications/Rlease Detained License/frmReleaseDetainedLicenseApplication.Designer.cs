namespace DVLD_Project.Applications.Rlease_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbDetain = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.PbLocalDrivingApplicationId = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.llShowLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.llShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbDetain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(243, -6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(409, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Release Detained License";
            // 
            // gbDetain
            // 
            this.gbDetain.Controls.Add(this.lbl);
            this.gbDetain.Controls.Add(this.PbLocalDrivingApplicationId);
            this.gbDetain.Controls.Add(this.pbApplicationDate);
            this.gbDetain.Controls.Add(this.label4);
            this.gbDetain.Controls.Add(this.lblDetainID);
            this.gbDetain.Controls.Add(this.lblFineFees);
            this.gbDetain.Controls.Add(this.lblDetainDate);
            this.gbDetain.Controls.Add(this.lblCreatedBy);
            this.gbDetain.Controls.Add(this.label5);
            this.gbDetain.Controls.Add(this.lbl1);
            this.gbDetain.Controls.Add(this.pictureBox2);
            this.gbDetain.Controls.Add(this.pictureBox4);
            this.gbDetain.Controls.Add(this.pictureBox1);
            this.gbDetain.Controls.Add(this.pictureBox5);
            this.gbDetain.Controls.Add(this.label3);
            this.gbDetain.Controls.Add(this.label10);
            this.gbDetain.Controls.Add(this.lblApplicationFees);
            this.gbDetain.Controls.Add(this.lblApplicationID);
            this.gbDetain.Controls.Add(this.lblTotalFees);
            this.gbDetain.Controls.Add(this.lblLicenseID);
            this.gbDetain.Controls.Add(this.label24);
            this.gbDetain.Controls.Add(this.pictureBox11);
            this.gbDetain.Controls.Add(this.pictureBox12);
            this.gbDetain.Controls.Add(this.label25);
            this.gbDetain.Location = new System.Drawing.Point(12, 493);
            this.gbDetain.Name = "gbDetain";
            this.gbDetain.Size = new System.Drawing.Size(852, 178);
            this.gbDetain.TabIndex = 1;
            this.gbDetain.TabStop = false;
            this.gbDetain.Text = "Detain Info";
            this.gbDetain.Enter += new System.EventHandler(this.gbDetain_Enter);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(21, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(91, 20);
            this.lbl.TabIndex = 107;
            this.lbl.Text = "Detain ID:";
            // 
            // PbLocalDrivingApplicationId
            // 
            this.PbLocalDrivingApplicationId.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.PbLocalDrivingApplicationId.Location = new System.Drawing.Point(176, 27);
            this.PbLocalDrivingApplicationId.Name = "PbLocalDrivingApplicationId";
            this.PbLocalDrivingApplicationId.Size = new System.Drawing.Size(31, 26);
            this.PbLocalDrivingApplicationId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLocalDrivingApplicationId.TabIndex = 108;
            this.PbLocalDrivingApplicationId.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(176, 60);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(31, 26);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 109;
            this.pbApplicationDate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(223, 30);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(39, 20);
            this.lblDetainID.TabIndex = 111;
            this.lblDetainID.Text = "???";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(684, 129);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(39, 20);
            this.lblFineFees.TabIndex = 130;
            this.lblFineFees.Text = "$$$";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(223, 63);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(99, 20);
            this.lblDetainDate.TabIndex = 112;
            this.lblDetainDate.Text = "??/??/????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(684, 96);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(39, 20);
            this.lblCreatedBy.TabIndex = 129;
            this.lblCreatedBy.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Application Fees:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(503, 129);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 20);
            this.lbl1.TabIndex = 128;
            this.lbl1.Text = "Fine Fees:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(176, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(637, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 127;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(176, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(637, 93);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 126;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Total Fees:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 125;
            this.label10.Text = "Created By:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(223, 96);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(39, 20);
            this.lblApplicationFees.TabIndex = 117;
            this.lblApplicationFees.Text = "$$$";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(684, 63);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(39, 20);
            this.lblApplicationID.TabIndex = 124;
            this.lblApplicationID.Text = "???";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(223, 129);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(39, 20);
            this.lblTotalFees.TabIndex = 118;
            this.lblTotalFees.Text = "$$$";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(684, 30);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(39, 20);
            this.lblLicenseID.TabIndex = 123;
            this.lblLicenseID.Text = "???";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(503, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(127, 20);
            this.label24.TabIndex = 122;
            this.label24.Text = "Application ID:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox11.Location = new System.Drawing.Point(637, 60);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 121;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.pictureBox12.Location = new System.Drawing.Point(637, 27);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 120;
            this.pictureBox12.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(503, 30);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 20);
            this.label25.TabIndex = 119;
            this.label25.Text = "License ID:";
            // 
            // llShowLicensesInfo
            // 
            this.llShowLicensesInfo.AutoSize = true;
            this.llShowLicensesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowLicensesInfo.Location = new System.Drawing.Point(186, 680);
            this.llShowLicensesInfo.Name = "llShowLicensesInfo";
            this.llShowLicensesInfo.Size = new System.Drawing.Size(148, 20);
            this.llShowLicensesInfo.TabIndex = 134;
            this.llShowLicensesInfo.TabStop = true;
            this.llShowLicensesInfo.Text = "Show Licenses Info";
            this.llShowLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(607, 671);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 132;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.White;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRelease.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(738, 671);
            this.btnRelease.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(126, 37);
            this.btnRelease.TabIndex = 131;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // llShowLicensesHistory
            // 
            this.llShowLicensesHistory.AutoSize = true;
            this.llShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowLicensesHistory.Location = new System.Drawing.Point(12, 680);
            this.llShowLicensesHistory.Name = "llShowLicensesHistory";
            this.llShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.llShowLicensesHistory.TabIndex = 133;
            this.llShowLicensesHistory.TabStop = true;
            this.llShowLicensesHistory.Text = "Show Licenses History";
            this.llShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesHistory_LinkClicked);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 25);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(879, 472);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 135;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(879, 749);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.llShowLicensesInfo);
            this.Controls.Add(this.gbDetain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.llShowLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReleaseDetainedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Detained License";
            this.Activated += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicenseApplication_Load);
            this.gbDetain.ResumeLayout(false);
            this.gbDetain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDetain;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox PbLocalDrivingApplicationId;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.LinkLabel llShowLicensesInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.LinkLabel llShowLicensesHistory;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
    }
}