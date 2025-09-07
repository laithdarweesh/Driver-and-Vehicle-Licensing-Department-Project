namespace DVLD_Project.Tests
{
    partial class frmTakeTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrlScheduledTest1 = new DVLD_Project.Tests.Controls.ctrlScheduledTest();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Result:";
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = global::DVLD_Project.Properties.Resources.Notes_32;
            this.pbLicenseClass.Location = new System.Drawing.Point(145, 566);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(31, 26);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLicenseClass.TabIndex = 111;
            this.pbLicenseClass.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(145, 535);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 110;
            this.pictureBox3.TabStop = false;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Checked = true;
            this.rbPass.Location = new System.Drawing.Point(191, 537);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(62, 24);
            this.rbPass.TabIndex = 113;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.Location = new System.Drawing.Point(260, 537);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(52, 24);
            this.rbFail.TabIndex = 114;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(323, 537);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(255, 20);
            this.lblUserMessage.TabIndex = 115;
            this.lblUserMessage.Text = "You cannot change the results";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(191, 567);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(389, 82);
            this.txtNotes.TabIndex = 116;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(319, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(454, 657);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.BackColor = System.Drawing.Color.White;
            this.ctrlScheduledTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(10, 10);
            this.ctrlScheduledTest1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(575, 512);
            this.ctrlScheduledTest1.TabIndex = 0;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(594, 711);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbLicenseClass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrlScheduledTest ctrlScheduledTest1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}