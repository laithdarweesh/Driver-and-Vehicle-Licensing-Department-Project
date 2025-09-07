namespace DVLD_Project.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbDriverInternationalLicenseInfo = new System.Windows.Forms.PictureBox();
            this.ctrlDriverInternationalLicenseInfo1 = new DVLD_Project.Licenses.International_Licenses.Controls.ctrlDriverInternationalLicenseInfo();
            this.pbInternationalLicense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverInternationalLicenseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(743, 442);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 70;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(196, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(499, 37);
            this.lblTitle.TabIndex = 69;
            this.lblTitle.Text = "Driver International License Info";
            // 
            // pbDriverInternationalLicenseInfo
            // 
            this.pbDriverInternationalLicenseInfo.Image = global::DVLD_Project.Properties.Resources.LicenseView_400;
            this.pbDriverInternationalLicenseInfo.Location = new System.Drawing.Point(366, 10);
            this.pbDriverInternationalLicenseInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pbDriverInternationalLicenseInfo.Name = "pbDriverInternationalLicenseInfo";
            this.pbDriverInternationalLicenseInfo.Size = new System.Drawing.Size(160, 128);
            this.pbDriverInternationalLicenseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverInternationalLicenseInfo.TabIndex = 68;
            this.pbDriverInternationalLicenseInfo.TabStop = false;
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            this.ctrlDriverInternationalLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverInternationalLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(2, 193);
            this.ctrlDriverInternationalLicenseInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            this.ctrlDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(872, 243);
            this.ctrlDriverInternationalLicenseInfo1.TabIndex = 71;
            // 
            // pbInternationalLicense
            // 
            this.pbInternationalLicense.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.pbInternationalLicense.Location = new System.Drawing.Point(366, 10);
            this.pbInternationalLicense.Name = "pbInternationalLicense";
            this.pbInternationalLicense.Size = new System.Drawing.Size(42, 34);
            this.pbInternationalLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInternationalLicense.TabIndex = 72;
            this.pbInternationalLicense.TabStop = false;
            // 
            // frmShowInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(876, 486);
            this.Controls.Add(this.pbInternationalLicense);
            this.Controls.Add(this.ctrlDriverInternationalLicenseInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbDriverInternationalLicenseInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show International License Info";
            this.Load += new System.EventHandler(this.frmShowInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverInternationalLicenseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternationalLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbDriverInternationalLicenseInfo;
        private Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private System.Windows.Forms.PictureBox pbInternationalLicense;
    }
}