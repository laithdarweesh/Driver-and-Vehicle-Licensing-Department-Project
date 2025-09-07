namespace DVLD_Project.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            this.tcApplicationInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project.People.Controls.ctrlPersonCardWithFilter();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCreatedByUser = new System.Windows.Forms.PictureBox();
            this.lblLocalLicenseApplicationId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.pbApplicationFees = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.PbLocalDrivingApplicationId = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tcApplicationInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedByUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(185, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Local Driving License Application";
            // 
            // tcApplicationInfo
            // 
            this.tcApplicationInfo.Controls.Add(this.tpPersonalInfo);
            this.tcApplicationInfo.Controls.Add(this.tpApplicationInfo);
            this.tcApplicationInfo.Location = new System.Drawing.Point(3, 55);
            this.tcApplicationInfo.Name = "tcApplicationInfo";
            this.tcApplicationInfo.SelectedIndex = 0;
            this.tcApplicationInfo.Size = new System.Drawing.Size(867, 513);
            this.tcApplicationInfo.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tcApplicationInfo.TabIndex = 37;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(859, 480);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(728, 438);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 37);
            this.btnNext.TabIndex = 38;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(6, 5);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(850, 438);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnPersonSelected);
            this.ctrlPersonCardWithFilter1.OnAddNewPerson += new System.Action<int>(this.ctrlPersonCardWithFilter1_OnAddNewPerson);
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.cbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.pbCreatedByUser);
            this.tpApplicationInfo.Controls.Add(this.lblLocalLicenseApplicationId);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.pbLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.pbApplicationFees);
            this.tpApplicationInfo.Controls.Add(this.pbApplicationDate);
            this.tpApplicationInfo.Controls.Add(this.PbLocalDrivingApplicationId);
            this.tpApplicationInfo.Controls.Add(this.lbl);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 29);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(859, 480);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(267, 136);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(320, 28);
            this.cbLicenseClass.TabIndex = 37;
            this.cbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClass_SelectedIndexChanged);
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(267, 172);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(39, 20);
            this.lblApplicationFees.TabIndex = 36;
            this.lblApplicationFees.Text = "???";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(267, 208);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(39, 20);
            this.lblCreatedByUser.TabIndex = 35;
            this.lblCreatedByUser.Text = "???";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(267, 101);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(99, 20);
            this.lblApplicationDate.TabIndex = 34;
            this.lblApplicationDate.Text = "??/??/????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Created By:";
            // 
            // pbCreatedByUser
            // 
            this.pbCreatedByUser.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pbCreatedByUser.Location = new System.Drawing.Point(221, 209);
            this.pbCreatedByUser.Name = "pbCreatedByUser";
            this.pbCreatedByUser.Size = new System.Drawing.Size(31, 26);
            this.pbCreatedByUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreatedByUser.TabIndex = 32;
            this.pbCreatedByUser.TabStop = false;
            // 
            // lblLocalLicenseApplicationId
            // 
            this.lblLocalLicenseApplicationId.AutoSize = true;
            this.lblLocalLicenseApplicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseApplicationId.Location = new System.Drawing.Point(267, 68);
            this.lblLocalLicenseApplicationId.Name = "lblLocalLicenseApplicationId";
            this.lblLocalLicenseApplicationId.Size = new System.Drawing.Size(39, 20);
            this.lblLocalLicenseApplicationId.TabIndex = 31;
            this.lblLocalLicenseApplicationId.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "License Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Application Fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Application Date:";
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_32;
            this.pbLicenseClass.Location = new System.Drawing.Point(221, 137);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(31, 26);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 27;
            this.pbLicenseClass.TabStop = false;
            // 
            // pbApplicationFees
            // 
            this.pbApplicationFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbApplicationFees.Location = new System.Drawing.Point(221, 173);
            this.pbApplicationFees.Name = "pbApplicationFees";
            this.pbApplicationFees.Size = new System.Drawing.Size(31, 26);
            this.pbApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationFees.TabIndex = 26;
            this.pbApplicationFees.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(220, 101);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(31, 26);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbApplicationDate.TabIndex = 25;
            this.pbApplicationDate.TabStop = false;
            // 
            // PbLocalDrivingApplicationId
            // 
            this.PbLocalDrivingApplicationId.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.PbLocalDrivingApplicationId.Location = new System.Drawing.Point(220, 65);
            this.PbLocalDrivingApplicationId.Name = "PbLocalDrivingApplicationId";
            this.PbLocalDrivingApplicationId.Size = new System.Drawing.Size(31, 26);
            this.PbLocalDrivingApplicationId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLocalDrivingApplicationId.TabIndex = 24;
            this.PbLocalDrivingApplicationId.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(53, 68);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(160, 20);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(744, 572);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(613, 572);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 692);
            this.Controls.Add(this.tcApplicationInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Driving License Application";
            this.Activated += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Load);
            this.tcApplicationInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedByUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLocalDrivingApplicationId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblLocalLicenseApplicationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.PictureBox pbApplicationFees;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.PictureBox PbLocalDrivingApplicationId;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.ComboBox cbLicenseClass;
    }
}