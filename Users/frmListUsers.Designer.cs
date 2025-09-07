namespace DVLD_Project.Users
{
    partial class frmListUsers
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
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.SendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.pbManageUsers = new System.Windows.Forms.PictureBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.AllowUserToResizeRows = false;
            this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvListUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListUsers.Location = new System.Drawing.Point(48, 276);
            this.dgvListUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListUsers.MultiSelect = false;
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUsers.Size = new System.Drawing.Size(895, 371);
            this.dgvListUsers.TabIndex = 0;
            // 
            // cmsUsers
            // 
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.AddNewUserToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.ChangePasswordtoolStripMenuItem,
            this.toolStripMenuItem2,
            this.SendEmailToolStripMenuItem,
            this.PhoneCallToolStripMenuItem});
            this.cmsUsers.Name = "cmsPeople";
            this.cmsUsers.Size = new System.Drawing.Size(197, 304);
            // 
            // ShowDetailsToolStripMenuItem
            // 
            this.ShowDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.ShowDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDetailsToolStripMenuItem.Name = "ShowDetailsToolStripMenuItem";
            this.ShowDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.ShowDetailsToolStripMenuItem.Text = "&Show Details";
            this.ShowDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(193, 6);
            // 
            // AddNewUserToolStripMenuItem
            // 
            this.AddNewUserToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Add_New_User_32;
            this.AddNewUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            this.AddNewUserToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.AddNewUserToolStripMenuItem.Text = "Add &New User";
            this.AddNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.EditToolStripMenuItem.Text = "&Edit";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.DeleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.DeleteToolStripMenuItem.Text = "&Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // ChangePasswordtoolStripMenuItem
            // 
            this.ChangePasswordtoolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Password_32;
            this.ChangePasswordtoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ChangePasswordtoolStripMenuItem.Name = "ChangePasswordtoolStripMenuItem";
            this.ChangePasswordtoolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.ChangePasswordtoolStripMenuItem.Text = "Change &Password";
            this.ChangePasswordtoolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordtoolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // SendEmailToolStripMenuItem
            // 
            this.SendEmailToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.send_email_32;
            this.SendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            this.SendEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.SendEmailToolStripMenuItem.Text = "Send &Email";
            this.SendEmailToolStripMenuItem.Click += new System.EventHandler(this.SendEmailToolStripMenuItem_Click);
            // 
            // PhoneCallToolStripMenuItem
            // 
            this.PhoneCallToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.call_32;
            this.PhoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PhoneCallToolStripMenuItem.Name = "PhoneCallToolStripMenuItem";
            this.PhoneCallToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.PhoneCallToolStripMenuItem.Text = "Phone &Call";
            this.PhoneCallToolStripMenuItem.Click += new System.EventHandler(this.PhoneCallToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(819, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(167, 661);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 45;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(68, 661);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "#Records:";
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageUsers.Location = new System.Drawing.Point(363, 164);
            this.lblManageUsers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(193, 35);
            this.lblManageUsers.TabIndex = 53;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // pbManageUsers
            // 
            this.pbManageUsers.Image = global::DVLD_Project.Properties.Resources.Users_2_400;
            this.pbManageUsers.Location = new System.Drawing.Point(330, 9);
            this.pbManageUsers.Margin = new System.Windows.Forms.Padding(5);
            this.pbManageUsers.Name = "pbManageUsers";
            this.pbManageUsers.Size = new System.Drawing.Size(251, 147);
            this.pbManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageUsers.TabIndex = 52;
            this.pbManageUsers.TabStop = false;
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(338, 223);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(56, 28);
            this.cbIsActive.TabIndex = 51;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUser.Image = global::DVLD_Project.Properties.Resources.Add_New_User_72;
            this.btnAddUser.Location = new System.Drawing.Point(853, 196);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(88, 69);
            this.btnAddUser.TabIndex = 50;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(404, 223);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(216, 26);
            this.txtFilterValue.TabIndex = 49;
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
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "IsActive"});
            this.cbFilterBy.Location = new System.Drawing.Point(132, 223);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBy.TabIndex = 48;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Find By:";
            // 
            // frmListUsers
            // 
            this.AcceptButton = this.btnAddUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(974, 749);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.pbManageUsers);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.PictureBox pbManageUsers;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem ShowDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordtoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem SendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhoneCallToolStripMenuItem;
    }
}