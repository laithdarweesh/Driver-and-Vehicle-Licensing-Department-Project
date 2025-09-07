namespace DVLD_Project.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            this.ctrlDrivingLicenseApplicationInfo1 = new DVLD_Project.Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbNotes = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            this.ctrlDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDrivingLicenseApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(10, 10);
            this.ctrlDrivingLicenseApplicationInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            this.ctrlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(933, 403);
            this.ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(116, 421);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(817, 144);
            this.txtNotes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            // 
            // PbNotes
            // 
            this.PbNotes.BackColor = System.Drawing.Color.White;
            this.PbNotes.Image = global::DVLD_Project.Properties.Resources.Notes_321;
            this.PbNotes.Location = new System.Drawing.Point(79, 421);
            this.PbNotes.Name = "PbNotes";
            this.PbNotes.Size = new System.Drawing.Size(31, 26);
            this.PbNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbNotes.TabIndex = 37;
            this.PbNotes.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(674, 574);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.BackColor = System.Drawing.Color.White;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnIssueLicense.Image = global::DVLD_Project.Properties.Resources.License_Type_32;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(807, 574);
            this.btnIssueLicense.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(126, 37);
            this.btnIssueLicense.TabIndex = 35;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.PbNotes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.ctrlDrivingLicenseApplicationInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIssueDriverLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Driver License First Time";
            this.Load += new System.EventHandler(this.frmIssueDriverLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.PictureBox PbNotes;
    }
}