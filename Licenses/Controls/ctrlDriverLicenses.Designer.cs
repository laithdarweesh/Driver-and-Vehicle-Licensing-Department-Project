namespace DVLD_Project.Licenses.Controls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.lblInternationalLicensesRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmsLocalLicensesHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowLocalLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInternationalLicensesHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowInternationalLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDriverLicenses.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.cmsLocalLicensesHistory.SuspendLayout();
            this.cmsInternationalLicensesHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcDriverLicenses);
            this.gbDriverLicenses.Location = new System.Drawing.Point(7, 5);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(1050, 270);
            this.gbDriverLicenses.TabIndex = 0;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.tcDriverLicenses.Location = new System.Drawing.Point(7, 25);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(990, 239);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocalLicenses.Controls.Add(this.lblLocalLicensesRecords);
            this.tpLocalLicenses.Controls.Add(this.label2);
            this.tpLocalLicenses.Controls.Add(this.label1);
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(982, 206);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dgvLocalLicensesHistory.AllowUserToResizeRows = false;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.cmsLocalLicensesHistory;
            this.dgvLocalLicensesHistory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(5, 36);
            this.dgvLocalLicensesHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLocalLicensesHistory.MultiSelect = false;
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(968, 119);
            this.dgvLocalLicensesHistory.TabIndex = 55;
            // 
            // lblLocalLicensesRecords
            // 
            this.lblLocalLicensesRecords.AutoSize = true;
            this.lblLocalLicensesRecords.Location = new System.Drawing.Point(87, 160);
            this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            this.lblLocalLicensesRecords.Size = new System.Drawing.Size(18, 20);
            this.lblLocalLicensesRecords.TabIndex = 2;
            this.lblLocalLicensesRecords.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Record:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Licenses History:";
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternationalLicenses.Controls.Add(this.lblInternationalLicensesRecord);
            this.tpInternationalLicenses.Controls.Add(this.label4);
            this.tpInternationalLicenses.Controls.Add(this.label5);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(982, 206);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International";
            this.tpInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.AllowUserToResizeRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.cmsInternationalLicensesHistory;
            this.dgvInternationalLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(5, 36);
            this.dgvInternationalLicenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInternationalLicenses.MultiSelect = false;
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(968, 119);
            this.dgvInternationalLicenses.TabIndex = 59;
            // 
            // lblInternationalLicensesRecord
            // 
            this.lblInternationalLicensesRecord.AutoSize = true;
            this.lblInternationalLicensesRecord.Location = new System.Drawing.Point(87, 160);
            this.lblInternationalLicensesRecord.Name = "lblInternationalLicensesRecord";
            this.lblInternationalLicensesRecord.Size = new System.Drawing.Size(18, 20);
            this.lblInternationalLicensesRecord.TabIndex = 58;
            this.lblInternationalLicensesRecord.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "#Record:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "International Licenses History:";
            // 
            // cmsLocalLicensesHistory
            // 
            this.cmsLocalLicensesHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowLocalLicenseHistory});
            this.cmsLocalLicensesHistory.Name = "cmsPeople";
            this.cmsLocalLicensesHistory.Size = new System.Drawing.Size(186, 42);
            // 
            // tsmShowLocalLicenseHistory
            // 
            this.tsmShowLocalLicenseHistory.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.tsmShowLocalLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowLocalLicenseHistory.Name = "tsmShowLocalLicenseHistory";
            this.tsmShowLocalLicenseHistory.Size = new System.Drawing.Size(185, 38);
            this.tsmShowLocalLicenseHistory.Text = "&Show License Info";
            this.tsmShowLocalLicenseHistory.Click += new System.EventHandler(this.tsmShowLocalLicenseHistory_Click);
            // 
            // cmsInternationalLicensesHistory
            // 
            this.cmsInternationalLicensesHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowInternationalLicenseHistory});
            this.cmsInternationalLicensesHistory.Name = "cmsPeople";
            this.cmsInternationalLicensesHistory.Size = new System.Drawing.Size(186, 42);
            // 
            // tsmShowInternationalLicenseHistory
            // 
            this.tsmShowInternationalLicenseHistory.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.tsmShowInternationalLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowInternationalLicenseHistory.Name = "tsmShowInternationalLicenseHistory";
            this.tsmShowInternationalLicenseHistory.Size = new System.Drawing.Size(196, 38);
            this.tsmShowInternationalLicenseHistory.Text = "&Show License Info";
            this.tsmShowInternationalLicenseHistory.Click += new System.EventHandler(this.tsmShowInternationalLicenseHistory_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDriverLicenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1106, 278);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.cmsLocalLicensesHistory.ResumeLayout(false);
            this.cmsInternationalLicensesHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicensesHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLocalLicenseHistory;
        private System.Windows.Forms.ContextMenuStrip cmsInternationalLicensesHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmShowInternationalLicenseHistory;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
