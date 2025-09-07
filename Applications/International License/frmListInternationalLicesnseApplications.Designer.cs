namespace DVLD_Project.Applications.International_License
{
    partial class frmListInternationalLicesnseApplications
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
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.cmsInternationalApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pbInternationalLicense = new System.Windows.Forms.PictureBox();
            this.pbInternationalLicenseApplication = new System.Windows.Forms.PictureBox();
            this.btnNewApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsInternationalApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicenseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(311, 173);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(443, 35);
            this.lblTitle.TabIndex = 64;
            this.lblTitle.Text = "International License Applications";
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
            this.cbIsActive.Location = new System.Drawing.Point(298, 218);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(56, 28);
            this.cbIsActive.TabIndex = 62;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(364, 219);
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
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(92, 218);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBy.TabIndex = 59;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Find By:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(107, 661);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 56;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 661);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "#Records:";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToResizeRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalApplications;
            this.dgvInternationalLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(8, 271);
            this.dgvInternationalLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInternationalLicenses.MultiSelect = false;
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1033, 371);
            this.dgvInternationalLicenses.TabIndex = 54;
            // 
            // cmsInternationalApplications
            // 
            this.cmsInternationalApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetails,
            this.tsmShowLicenseDetails,
            this.tsmShowPersonLicenseHistory});
            this.cmsInternationalApplications.Name = "cmsPeople";
            this.cmsInternationalApplications.Size = new System.Drawing.Size(242, 118);
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
            // pbInternationalLicense
            // 
            this.pbInternationalLicense.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.pbInternationalLicense.Location = new System.Drawing.Point(620, 55);
            this.pbInternationalLicense.Name = "pbInternationalLicense";
            this.pbInternationalLicense.Size = new System.Drawing.Size(78, 58);
            this.pbInternationalLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInternationalLicense.TabIndex = 65;
            this.pbInternationalLicense.TabStop = false;
            // 
            // pbInternationalLicenseApplication
            // 
            this.pbInternationalLicenseApplication.Image = global::DVLD_Project.Properties.Resources.Applications;
            this.pbInternationalLicenseApplication.Location = new System.Drawing.Point(408, 4);
            this.pbInternationalLicenseApplication.Margin = new System.Windows.Forms.Padding(5);
            this.pbInternationalLicenseApplication.Name = "pbInternationalLicenseApplication";
            this.pbInternationalLicenseApplication.Size = new System.Drawing.Size(251, 168);
            this.pbInternationalLicenseApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInternationalLicenseApplication.TabIndex = 63;
            this.pbInternationalLicenseApplication.TabStop = false;
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewApplication.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnNewApplication.Location = new System.Drawing.Point(953, 197);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.Size = new System.Drawing.Size(88, 69);
            this.btnNewApplication.TabIndex = 61;
            this.btnNewApplication.UseVisualStyleBackColor = true;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(915, 652);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListInternationalLicesnseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1049, 692);
            this.Controls.Add(this.pbInternationalLicense);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbInternationalLicenseApplication);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnNewApplication);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListInternationalLicesnseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International Licesnse Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicesnseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsInternationalApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicenseApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbInternationalLicenseApplication;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.PictureBox pbInternationalLicense;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}