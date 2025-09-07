namespace DVLD_Project.Tests
{
    partial class frmListTestAppointments
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
            this.lblTitleTestType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListTestAppointments = new System.Windows.Forms.DataGridView();
            this.cmsTestAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.pbImageTestType = new System.Windows.Forms.PictureBox();
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD_Project.Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestAppointments)).BeginInit();
            this.cmsTestAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleTestType
            // 
            this.lblTitleTestType.AutoSize = true;
            this.lblTitleTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitleTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitleTestType.Location = new System.Drawing.Point(288, 134);
            this.lblTitleTestType.Name = "lblTitleTestType";
            this.lblTitleTestType.Size = new System.Drawing.Size(389, 37);
            this.lblTitleTestType.TabIndex = 44;
            this.lblTitleTestType.Text = "Vision Test Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Appointments:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(230, 718);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordsCount.TabIndex = 58;
            this.lblRecordsCount.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(131, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "#Records:";
            // 
            // dgvListTestAppointments
            // 
            this.dgvListTestAppointments.AllowUserToAddRows = false;
            this.dgvListTestAppointments.AllowUserToDeleteRows = false;
            this.dgvListTestAppointments.AllowUserToResizeRows = false;
            this.dgvListTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTestAppointments.ContextMenuStrip = this.cmsTestAppointments;
            this.dgvListTestAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListTestAppointments.Location = new System.Drawing.Point(136, 582);
            this.dgvListTestAppointments.MultiSelect = false;
            this.dgvListTestAppointments.Name = "dgvListTestAppointments";
            this.dgvListTestAppointments.ReadOnly = true;
            this.dgvListTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTestAppointments.Size = new System.Drawing.Size(680, 122);
            this.dgvListTestAppointments.TabIndex = 60;
            this.dgvListTestAppointments.TabStop = false;
            // 
            // cmsTestAppointments
            // 
            this.cmsTestAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditTest,
            this.tsmTakeTest});
            this.cmsTestAppointments.Name = "cmsPeople";
            this.cmsTestAppointments.Size = new System.Drawing.Size(137, 80);
            // 
            // tsmEditTest
            // 
            this.tsmEditTest.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.tsmEditTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditTest.Name = "tsmEditTest";
            this.tsmEditTest.Size = new System.Drawing.Size(136, 38);
            this.tsmEditTest.Text = "&Edit";
            this.tsmEditTest.Click += new System.EventHandler(this.tsmEditTest_Click);
            // 
            // tsmTakeTest
            // 
            this.tsmTakeTest.Image = global::DVLD_Project.Properties.Resources.Test_32;
            this.tsmTakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmTakeTest.Name = "tsmTakeTest";
            this.tsmTakeTest.Size = new System.Drawing.Size(136, 38);
            this.tsmTakeTest.Text = "&Take Test";
            this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(690, 707);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.Image = global::DVLD_Project.Properties.Resources.AddAppointment_32;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(883, 592);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(44, 37);
            this.btnAddNewAppointment.TabIndex = 46;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // pbImageTestType
            // 
            this.pbImageTestType.Image = global::DVLD_Project.Properties.Resources.Vision_512;
            this.pbImageTestType.Location = new System.Drawing.Point(408, 1);
            this.pbImageTestType.Name = "pbImageTestType";
            this.pbImageTestType.Size = new System.Drawing.Size(150, 128);
            this.pbImageTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageTestType.TabIndex = 43;
            this.pbImageTestType.TabStop = false;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(5, 175);
            this.ctrlDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(938, 403);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 45;
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(949, 749);
            this.Controls.Add(this.dgvListTestAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.lblTitleTestType);
            this.Controls.Add(this.pbImageTestType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vision Test Appointment";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestAppointments)).EndInit();
            this.cmsTestAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleTestType;
        private System.Windows.Forms.PictureBox pbImageTestType;
        private Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListTestAppointments;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppointments;
        private System.Windows.Forms.ToolStripMenuItem tsmEditTest;
        private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
    }
}