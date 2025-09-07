namespace DVLD_Project.Licenses.Local_Licenses
{
    partial class frmShowLicenseInfo
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
            this.lblDriverLicenseInfo = new System.Windows.Forms.Label();
            this.pbDriverLicenseInfo = new System.Windows.Forms.PictureBox();
            this.ctrlDriverLicenseInfo1 = new DVLD_Project.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfo();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverLicenseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverLicenseInfo
            // 
            this.lblDriverLicenseInfo.AutoSize = true;
            this.lblDriverLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblDriverLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDriverLicenseInfo.Location = new System.Drawing.Point(300, 140);
            this.lblDriverLicenseInfo.Name = "lblDriverLicenseInfo";
            this.lblDriverLicenseInfo.Size = new System.Drawing.Size(300, 37);
            this.lblDriverLicenseInfo.TabIndex = 66;
            this.lblDriverLicenseInfo.Text = "Driver License Info";
            // 
            // pbDriverLicenseInfo
            // 
            this.pbDriverLicenseInfo.Image = global::DVLD_Project.Properties.Resources.LicenseView_400;
            this.pbDriverLicenseInfo.Location = new System.Drawing.Point(370, 5);
            this.pbDriverLicenseInfo.Margin = new System.Windows.Forms.Padding(5);
            this.pbDriverLicenseInfo.Name = "pbDriverLicenseInfo";
            this.pbDriverLicenseInfo.Size = new System.Drawing.Size(160, 128);
            this.pbDriverLicenseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverLicenseInfo.TabIndex = 65;
            this.pbDriverLicenseInfo.TabStop = false;
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(10, 182);
            this.ctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(867, 339);
            this.ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(742, 531);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowLicenseInfo
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.lblDriverLicenseInfo);
            this.Controls.Add(this.pbDriverLicenseInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShowLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.frmShowLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverLicenseInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverLicenseInfo;
        private System.Windows.Forms.PictureBox pbDriverLicenseInfo;
        private Controls.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}