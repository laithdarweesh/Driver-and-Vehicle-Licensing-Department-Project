namespace DVLD_Project.Applications.Replace_Lost_Or_Damaged_License
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            this.llShowNewLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.llShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.gbApplicationInfoForLicenseReplacement = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.PbLocalDrivingApplicationId = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReplacementApplicationID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblReplacedLicenseID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbReplacementFor = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbApplicationInfoForLicenseReplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.gbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // llShowNewLicensesInfo
            // 
            this.llShowNewLicensesInfo.AutoSize = true;
            this.llShowNewLicensesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowNewLicensesInfo.Location = new System.Drawing.Point(186, 653);
            this.llShowNewLicensesInfo.Name = "llShowNewLicensesInfo";
            this.llShowNewLicensesInfo.Size = new System.Drawing.Size(183, 20);
            this.llShowNewLicensesInfo.TabIndex = 130;
            this.llShowNewLicensesInfo.TabStop = true;
            this.llShowNewLicensesInfo.Text = "Show New Licenses Info";
            this.llShowNewLicensesInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicensesInfo_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(540, 644);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 128;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.BackColor = System.Drawing.Color.White;
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIssueReplacement.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.Location = new System.Drawing.Point(671, 644);
            this.btnIssueReplacement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(193, 37);
            this.btnIssueReplacement.TabIndex = 127;
            this.btnIssueReplacement.Text = "Issue Replacement";
            this.btnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // llShowLicensesHistory
            // 
            this.llShowLicensesHistory.AutoSize = true;
            this.llShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowLicensesHistory.Location = new System.Drawing.Point(12, 653);
            this.llShowLicensesHistory.Name = "llShowLicensesHistory";
            this.llShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.llShowLicensesHistory.TabIndex = 129;
            this.llShowLicensesHistory.TabStop = true;
            this.llShowLicensesHistory.Text = "Show Licenses History";
            this.llShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesHistory_LinkClicked);
            // 
            // gbApplicationInfoForLicenseReplacement
            // 
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lbl);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.PbLocalDrivingApplicationId);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pbApplicationDate);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label4);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblReplacementApplicationID);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblApplicationDate);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblCreatedBy);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label7);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox4);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox1);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label3);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblApplicationFees);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblOldLicenseID);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.lblReplacedLicenseID);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label24);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox11);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.pictureBox12);
            this.gbApplicationInfoForLicenseReplacement.Controls.Add(this.label25);
            this.gbApplicationInfoForLicenseReplacement.Location = new System.Drawing.Point(12, 512);
            this.gbApplicationInfoForLicenseReplacement.Name = "gbApplicationInfoForLicenseReplacement";
            this.gbApplicationInfoForLicenseReplacement.Size = new System.Drawing.Size(852, 124);
            this.gbApplicationInfoForLicenseReplacement.TabIndex = 126;
            this.gbApplicationInfoForLicenseReplacement.TabStop = false;
            this.gbApplicationInfoForLicenseReplacement.Text = "Application Info For License Replacement";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(6, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(160, 20);
            this.lbl.TabIndex = 77;
            this.lbl.Text = "L.R.Application ID:";
            // 
            // PbLocalDrivingApplicationId
            // 
            this.PbLocalDrivingApplicationId.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.PbLocalDrivingApplicationId.Location = new System.Drawing.Point(173, 25);
            this.PbLocalDrivingApplicationId.Name = "PbLocalDrivingApplicationId";
            this.PbLocalDrivingApplicationId.Size = new System.Drawing.Size(31, 26);
            this.PbLocalDrivingApplicationId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLocalDrivingApplicationId.TabIndex = 78;
            this.PbLocalDrivingApplicationId.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(173, 58);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(31, 26);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 79;
            this.pbApplicationDate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Application Date:";
            // 
            // lblReplacementApplicationID
            // 
            this.lblReplacementApplicationID.AutoSize = true;
            this.lblReplacementApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacementApplicationID.Location = new System.Drawing.Point(220, 28);
            this.lblReplacementApplicationID.Name = "lblReplacementApplicationID";
            this.lblReplacementApplicationID.Size = new System.Drawing.Size(39, 20);
            this.lblReplacementApplicationID.TabIndex = 81;
            this.lblReplacementApplicationID.Text = "???";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(220, 61);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(99, 20);
            this.lblApplicationDate.TabIndex = 82;
            this.lblApplicationDate.Text = "??/??/????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(666, 91);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(39, 20);
            this.lblCreatedBy.TabIndex = 105;
            this.lblCreatedBy.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(432, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Created By:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(619, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 103;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox1.Location = new System.Drawing.Point(173, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Application Fees:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(220, 94);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(39, 20);
            this.lblApplicationFees.TabIndex = 87;
            this.lblApplicationFees.Text = "$$$";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(666, 58);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(39, 20);
            this.lblOldLicenseID.TabIndex = 100;
            this.lblOldLicenseID.Text = "???";
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.AutoSize = true;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(666, 25);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(39, 20);
            this.lblReplacedLicenseID.TabIndex = 99;
            this.lblReplacedLicenseID.Text = "???";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(432, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 20);
            this.label24.TabIndex = 98;
            this.label24.Text = "Old Licene ID:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.pictureBox11.Location = new System.Drawing.Point(619, 55);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(31, 26);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 97;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.pictureBox12.Location = new System.Drawing.Point(619, 22);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(31, 26);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 96;
            this.pictureBox12.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(432, 25);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(181, 20);
            this.label25.TabIndex = 95;
            this.label25.Text = "Replaced License ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(278, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 37);
            this.lblTitle.TabIndex = 125;
            this.lblTitle.Text = "License Replacement";
            // 
            // gbReplacementFor
            // 
            this.gbReplacementFor.Controls.Add(this.rbLostLicense);
            this.gbReplacementFor.Controls.Add(this.rbDamagedLicense);
            this.gbReplacementFor.Location = new System.Drawing.Point(642, 55);
            this.gbReplacementFor.Name = "gbReplacementFor";
            this.gbReplacementFor.Size = new System.Drawing.Size(220, 100);
            this.gbReplacementFor.TabIndex = 133;
            this.gbReplacementFor.TabStop = false;
            this.gbReplacementFor.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(5, 55);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(117, 24);
            this.rbLostLicense.TabIndex = 127;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(5, 26);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(156, 24);
            this.rbDamagedLicense.TabIndex = 126;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(0, 38);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(879, 473);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 132;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(884, 692);
            this.Controls.Add(this.gbReplacementFor);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.llShowNewLicensesInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.llShowLicensesHistory);
            this.Controls.Add(this.gbApplicationInfoForLicenseReplacement);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Replacement";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.gbApplicationInfoForLicenseReplacement.ResumeLayout(false);
            this.gbApplicationInfoForLicenseReplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.gbReplacementFor.ResumeLayout(false);
            this.gbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel llShowNewLicensesInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.LinkLabel llShowLicensesHistory;
        private System.Windows.Forms.GroupBox gbApplicationInfoForLicenseReplacement;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox PbLocalDrivingApplicationId;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReplacementApplicationID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblReplacedLicenseID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblTitle;
        private Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbReplacementFor;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
    }
}