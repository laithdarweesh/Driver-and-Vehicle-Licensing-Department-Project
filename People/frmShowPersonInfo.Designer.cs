namespace DVLD_Project.People
{
    partial class frmShowPersonInfo
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
            this.lblPesonInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonCard = new DVLD_Project.People.Controls.ctrlPersonCard();
            this.SuspendLayout();
            // 
            // lblPesonInfo
            // 
            this.lblPesonInfo.AutoSize = true;
            this.lblPesonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblPesonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPesonInfo.Location = new System.Drawing.Point(301, 18);
            this.lblPesonInfo.Name = "lblPesonInfo";
            this.lblPesonInfo.Size = new System.Drawing.Size(238, 37);
            this.lblPesonInfo.TabIndex = 1;
            this.lblPesonInfo.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(706, 400);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCard
            // 
            this.ctrlPersonCard.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard.Location = new System.Drawing.Point(12, 51);
            this.ctrlPersonCard.Name = "ctrlPersonCard";
            this.ctrlPersonCard.Size = new System.Drawing.Size(839, 356);
            this.ctrlPersonCard.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(867, 451);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPesonInfo);
            this.Controls.Add(this.ctrlPersonCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Information Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard;
        private System.Windows.Forms.Label lblPesonInfo;
        private System.Windows.Forms.Button btnClose;
    }
}