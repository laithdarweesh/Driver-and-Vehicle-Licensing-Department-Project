namespace DVLD_Project.Drivers
{
    partial class frmListDrivers
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
            this.lblManageDrivers = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListDrivers = new System.Windows.Forms.DataGridView();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbManageDrivers = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageDrivers
            // 
            this.lblManageDrivers.AutoSize = true;
            this.lblManageDrivers.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageDrivers.ForeColor = System.Drawing.Color.DarkRed;
            this.lblManageDrivers.Location = new System.Drawing.Point(404, 176);
            this.lblManageDrivers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblManageDrivers.Name = "lblManageDrivers";
            this.lblManageDrivers.Size = new System.Drawing.Size(212, 35);
            this.lblManageDrivers.TabIndex = 62;
            this.lblManageDrivers.Text = "Manage Drivers";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(89, 234);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(196, 28);
            this.cbFilterBy.TabIndex = 59;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Find By:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(104, 641);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 56;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(5, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "#Records:";
            // 
            // dgvListDrivers
            // 
            this.dgvListDrivers.AllowUserToAddRows = false;
            this.dgvListDrivers.AllowUserToDeleteRows = false;
            this.dgvListDrivers.AllowUserToResizeRows = false;
            this.dgvListDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDrivers.ContextMenuStrip = this.cmsDrivers;
            this.dgvListDrivers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListDrivers.Location = new System.Drawing.Point(5, 271);
            this.dgvListDrivers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListDrivers.MultiSelect = false;
            this.dgvListDrivers.Name = "dgvListDrivers";
            this.dgvListDrivers.ReadOnly = true;
            this.dgvListDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDrivers.Size = new System.Drawing.Size(988, 359);
            this.dgvListDrivers.TabIndex = 54;
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonInfo,
            this.toolStripMenuItem1,
            this.tsmShowPersonLicenseHistory});
            this.cmsDrivers.Name = "cmsPeople";
            this.cmsDrivers.Size = new System.Drawing.Size(242, 86);
            // 
            // tsmShowPersonInfo
            // 
            this.tsmShowPersonInfo.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmShowPersonInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowPersonInfo.Name = "tsmShowPersonInfo";
            this.tsmShowPersonInfo.Size = new System.Drawing.Size(241, 38);
            this.tsmShowPersonInfo.Text = "&Show Person Info";
            this.tsmShowPersonInfo.Click += new System.EventHandler(this.tsmShowPersonInfo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 6);
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
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(291, 235);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(216, 26);
            this.txtFilterValue.TabIndex = 63;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(867, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbManageDrivers
            // 
            this.pbManageDrivers.Image = global::DVLD_Project.Properties.Resources.Driver_Main;
            this.pbManageDrivers.Location = new System.Drawing.Point(385, 21);
            this.pbManageDrivers.Margin = new System.Windows.Forms.Padding(5);
            this.pbManageDrivers.Name = "pbManageDrivers";
            this.pbManageDrivers.Size = new System.Drawing.Size(250, 147);
            this.pbManageDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageDrivers.TabIndex = 61;
            this.pbManageDrivers.TabStop = false;
            // 
            // frmListDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1004, 692);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lblManageDrivers);
            this.Controls.Add(this.pbManageDrivers);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListDrivers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Drivers";
            this.Load += new System.EventHandler(this.frmListDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDrivers)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageDrivers;
        private System.Windows.Forms.PictureBox pbManageDrivers;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListDrivers;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicenseHistory;
    }
}