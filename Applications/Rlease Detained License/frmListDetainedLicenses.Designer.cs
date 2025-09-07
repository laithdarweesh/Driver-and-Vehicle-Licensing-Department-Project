namespace DVLD_Project.Applications.Rlease_Detained_License
{
    partial class frmListDetainedLicenses
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
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsListDetainedLIcenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReleaseDetainedLicense = new System.Windows.Forms.Button();
            this.pbDetainedLicenses = new System.Windows.Forms.PictureBox();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmsListDetainedLIcenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainedLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(480, 159);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(426, 37);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "Manage Detained Licenses";
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(294, 205);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(56, 28);
            this.cbIsReleased.TabIndex = 62;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(360, 206);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(216, 26);
            this.txtFilterValue.TabIndex = 60;
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
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(88, 205);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBy.TabIndex = 59;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Find By:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(103, 644);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 56;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "#Records:";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToResizeRows = false;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmsListDetainedLIcenses;
            this.dgvDetainedLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(4, 259);
            this.dgvDetainedLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetainedLicenses.MultiSelect = false;
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1360, 371);
            this.dgvDetainedLicenses.TabIndex = 54;
            // 
            // cmsListDetainedLIcenses
            // 
            this.cmsListDetainedLIcenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetails,
            this.tsmShowLicenseDetails,
            this.tsmShowPersonLicenseHistory,
            this.toolStripSeparator1,
            this.tsmReleaseDetainedLicense});
            this.cmsListDetainedLIcenses.Name = "cmsPeople";
            this.cmsListDetainedLIcenses.Size = new System.Drawing.Size(242, 184);
            this.cmsListDetainedLIcenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsListDetainedLIcenses_Opening);
            // 
            // tsmShowPersonDetails
            // 
            this.tsmShowPersonDetails.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowPersonDetails.Name = "tsmShowPersonDetails";
            this.tsmShowPersonDetails.Size = new System.Drawing.Size(241, 38);
            this.tsmShowPersonDetails.Text = "&Show Person Details";
            this.tsmShowPersonDetails.Click += new System.EventHandler(this.tsmShowPersonDetails_Click);
            // 
            // tsmShowLicenseDetails
            // 
            this.tsmShowLicenseDetails.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.tsmShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowLicenseDetails.Name = "tsmShowLicenseDetails";
            this.tsmShowLicenseDetails.Size = new System.Drawing.Size(241, 38);
            this.tsmShowLicenseDetails.Text = "&Show License Details";
            this.tsmShowLicenseDetails.Click += new System.EventHandler(this.tsmShowLicenseDetails_Click);
            // 
            // tsmShowPersonLicenseHistory
            // 
            this.tsmShowPersonLicenseHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_321;
            this.tsmShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowPersonLicenseHistory.Name = "tsmShowPersonLicenseHistory";
            this.tsmShowPersonLicenseHistory.Size = new System.Drawing.Size(241, 38);
            this.tsmShowPersonLicenseHistory.Text = "Show Person License &History";
            this.tsmShowPersonLicenseHistory.Click += new System.EventHandler(this.tsmShowPersonLicenseHistory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmReleaseDetainedLicense
            // 
            this.tsmReleaseDetainedLicense.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_32;
            this.tsmReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReleaseDetainedLicense.Name = "tsmReleaseDetainedLicense";
            this.tsmReleaseDetainedLicense.Size = new System.Drawing.Size(241, 38);
            this.tsmReleaseDetainedLicense.Text = "Release Detained License";
            this.tsmReleaseDetainedLicense.Click += new System.EventHandler(this.tsmReleaseDetainedLicense_Click);
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDetainedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReleaseDetainedLicense.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_64;
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(1183, 184);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(88, 69);
            this.btnReleaseDetainedLicense.TabIndex = 65;
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = true;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // pbDetainedLicenses
            // 
            this.pbDetainedLicenses.Image = global::DVLD_Project.Properties.Resources.Detain_512;
            this.pbDetainedLicenses.Location = new System.Drawing.Point(567, 0);
            this.pbDetainedLicenses.Margin = new System.Windows.Forms.Padding(5);
            this.pbDetainedLicenses.Name = "pbDetainedLicenses";
            this.pbDetainedLicenses.Size = new System.Drawing.Size(251, 159);
            this.pbDetainedLicenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDetainedLicenses.TabIndex = 63;
            this.pbDetainedLicenses.TabStop = false;
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetainLicense.Image = global::DVLD_Project.Properties.Resources.Detain_64;
            this.btnDetainLicense.Location = new System.Drawing.Point(1276, 184);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(88, 69);
            this.btnDetainLicense.TabIndex = 61;
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1238, 635);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.btnReleaseDetainedLicense);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbDetainedLicenses);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained Licenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmsListDetainedLIcenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainedLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbDetainedLicenses;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Button btnReleaseDetainedLicense;
        private System.Windows.Forms.ContextMenuStrip cmsListDetainedLIcenses;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedLicense;
    }
}