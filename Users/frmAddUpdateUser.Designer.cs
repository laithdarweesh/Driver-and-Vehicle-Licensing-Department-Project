namespace DVLD_Project.Users
{
    partial class frmAddUpdateUser
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
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFilter1 = new DVLD_Project.People.Controls.ctrlPersonCardWithFilter();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.PbUserId = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUserInfo.SuspendLayout();
            this.tpPersonalInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(253, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(339, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Edit Application Type";
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tpPersonalInfo);
            this.tcUserInfo.Controls.Add(this.tpLoginInfo);
            this.tcUserInfo.ItemSize = new System.Drawing.Size(106, 25);
            this.tcUserInfo.Location = new System.Drawing.Point(10, 77);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(861, 534);
            this.tcUserInfo.TabIndex = 1;
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.BackColor = System.Drawing.Color.White;
            this.tpPersonalInfo.Controls.Add(this.btnNext);
            this.tpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 29);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(853, 501);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Image = global::DVLD_Project.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(723, 458);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 37);
            this.btnNext.TabIndex = 37;
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
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(890, 445);
            this.ctrlPersonCardWithFilter1.TabIndex = 1;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.BackColor = System.Drawing.Color.White;
            this.tpLoginInfo.Controls.Add(this.chkIsActive);
            this.tpLoginInfo.Controls.Add(this.lblUserId);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.txtPassword);
            this.tpLoginInfo.Controls.Add(this.label1);
            this.tpLoginInfo.Controls.Add(this.pbPassword);
            this.tpLoginInfo.Controls.Add(this.pbConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.pbUserName);
            this.tpLoginInfo.Controls.Add(this.PbUserId);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.lbl);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 29);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(853, 501);
            this.tpLoginInfo.TabIndex = 0;
            this.tpLoginInfo.Text = "Login Info";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkIsActive.Location = new System.Drawing.Point(230, 224);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 23;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.Location = new System.Drawing.Point(232, 73);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(39, 20);
            this.lblUserId.TabIndex = 22;
            this.lblUserId.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(230, 181);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(167, 20);
            this.txtConfirmPassword.TabIndex = 18;
            this.txtConfirmPassword.Tag = "";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(230, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Tag = "";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "User Name:";
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::DVLD_Project.Properties.Resources.Password_32;
            this.pbPassword.Location = new System.Drawing.Point(193, 142);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(31, 26);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 15;
            this.pbPassword.TabStop = false;
            // 
            // pbConfirmPassword
            // 
            this.pbConfirmPassword.Image = global::DVLD_Project.Properties.Resources.Password_32;
            this.pbConfirmPassword.Location = new System.Drawing.Point(193, 178);
            this.pbConfirmPassword.Name = "pbConfirmPassword";
            this.pbConfirmPassword.Size = new System.Drawing.Size(31, 26);
            this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConfirmPassword.TabIndex = 14;
            this.pbConfirmPassword.TabStop = false;
            // 
            // pbUserName
            // 
            this.pbUserName.Image = global::DVLD_Project.Properties.Resources.Person_32;
            this.pbUserName.Location = new System.Drawing.Point(192, 106);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(31, 26);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserName.TabIndex = 13;
            this.pbUserName.TabStop = false;
            // 
            // PbUserId
            // 
            this.PbUserId.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.PbUserId.Location = new System.Drawing.Point(192, 70);
            this.PbUserId.Name = "PbUserId";
            this.PbUserId.Size = new System.Drawing.Size(31, 26);
            this.PbUserId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserId.TabIndex = 12;
            this.PbUserId.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(230, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 20);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Tag = "";
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(112, 73);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 20);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "UserID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 618);
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
            this.btnSave.Location = new System.Drawing.Point(606, 618);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(914, 665);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Update User";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tpPersonalInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbConfirmPassword;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.PictureBox PbUserId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}