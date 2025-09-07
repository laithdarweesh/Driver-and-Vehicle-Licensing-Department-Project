namespace DVLD_Project.Licenses.Detain_License
{
    partial class frmDetainLicenseApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.llShowLicensesInfo = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.llShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.gbDetain = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.PbLocalDrivingApplicationId = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_Project.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(332, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detain License";
            // 
            // llShowLicensesInfo
            // 
            this.llShowLicensesInfo.AutoSize = true;
            this.llShowLicensesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowLicensesInfo.Location = new System.Drawing.Point(192, 649);
            this.llShowLicensesInfo.Name = "llShowLicensesInfo";
            this.llShowLicensesInfo.Size = new System.Drawing.Size(148, 20);
            this.llShowLicensesInfo.TabIndex = 119;
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
            this.btnClose.Location = new System.Drawing.Point(610, 640);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 117;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.White;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetain.Image = global::DVLD_Project.Properties.Resources.Detain_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(744, 640);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(126, 37);
            this.btnDetain.TabIndex = 116;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // llShowLicensesHistory
            // 
            this.llShowLicensesHistory.AutoSize = true;
            this.llShowLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.llShowLicensesHistory.Location = new System.Drawing.Point(17, 649);
            this.llShowLicensesHistory.Name = "llShowLicensesHistory";
            this.llShowLicensesHistory.Size = new System.Drawing.Size(169, 20);
            this.llShowLicensesHistory.TabIndex = 118;
            this.llShowLicensesHistory.TabStop = true;
            this.llShowLicensesHistory.Text = "Show Licenses History";
            this.llShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesHistory_LinkClicked);
            // 
            // gbDetain
            // 
            this.gbDetain.Controls.Add(this.txtFineFees);
            this.gbDetain.Controls.Add(this.lbl);
            this.gbDetain.Controls.Add(this.PbLocalDrivingApplicationId);
            this.gbDetain.Controls.Add(this.pbApplicationDate);
            this.gbDetain.Controls.Add(this.label4);
            this.gbDetain.Controls.Add(this.lblDetainID);
            this.gbDetain.Controls.Add(this.lblDetainDate);
            this.gbDetain.Controls.Add(this.label5);
            this.gbDetain.Controls.Add(this.pictureBox2);
            this.gbDetain.Controls.Add(this.lblCreatedBy);
            this.gbDetain.Controls.Add(this.lblLicenseID);
            this.gbDetain.Controls.Add(this.label7);
            this.gbDetain.Controls.Add(this.pictureBox4);
            this.gbDetain.Controls.Add(this.pictureBox5);
            this.gbDetain.Controls.Add(this.label10);
            this.gbDetain.Location = new System.Drawing.Point(17, 506);
            this.gbDetain.Name = "gbDetain";
            this.gbDetain.Size = new System.Drawing.Size(853, 126);
            this.gbDetain.TabIndex = 120;
            this.gbDetain.TabStop = false;
            this.gbDetain.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(227, 89);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(100, 26);
            this.txtFineFees.TabIndex = 121;
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(9, 26);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(91, 20);
            this.lbl.TabIndex = 119;
            this.lbl.Text = "Detain ID:";
            // 
            // PbLocalDrivingApplicationId
            // 
            this.PbLocalDrivingApplicationId.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.PbLocalDrivingApplicationId.Location = new System.Drawing.Point(176, 23);
            this.PbLocalDrivingApplicationId.Name = "PbLocalDrivingApplicationId";
            this.PbLocalDrivingApplicationId.Size = new System.Drawing.Size(31, 26);
            this.PbLocalDrivingApplicationId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLocalDrivingApplicationId.TabIndex = 120;
            this.PbLocalDrivingApplicationId.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(176, 56);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(31, 26);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 121;
            this.pbApplicationDate.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 122;
            this.label4.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(223, 26);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(39, 20);
            this.lblDetainID.TabIndex = 123;
            this.lblDetainID.Text = "???";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(223, 59);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(99, 20);
            this.lblDetainDate.TabIndex = 124;
            this.lblDetainDate.Text = "??/??/????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 125;
            this.label5.Text = "Fine Fees:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(176, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(720, 59);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(39, 20);
            this.lblCreatedBy.TabIndex = 118;
            this.lblCreatedBy.Text = "???";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(720, 26);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(39, 20);
            this.lblLicenseID.TabIndex = 117;
            this.lblLicenseID.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 116;
            this.label7.Text = "Created By:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(673, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 115;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.pictureBox5.Location = new System.Drawing.Point(673, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 114;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 113;
            this.label10.Text = "License ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(5, 34);
            this.ctrlDriverLicenseInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(879, 471);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 121;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(890, 692);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.gbDetain);
            this.Controls.Add(this.llShowLicensesInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.llShowLicensesHistory);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDetainLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Activated += new System.EventHandler(this.frmDetainLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicenseApplication_Load);
            this.gbDetain.ResumeLayout(false);
            this.gbDetain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel llShowLicensesInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.LinkLabel llShowLicensesHistory;
        private System.Windows.Forms.GroupBox gbDetain;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox PbLocalDrivingApplicationId;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtFineFees;
        private Local_Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}