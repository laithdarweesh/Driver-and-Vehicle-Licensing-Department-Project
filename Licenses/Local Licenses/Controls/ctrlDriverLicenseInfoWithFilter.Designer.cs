namespace DVLD_Project.Licenses.Local_Licenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLicenseID = new System.Windows.Forms.TextBox();
            this.ctrlDriverLicenseInfo1 = new DVLD_Project.Licenses.Local_Licenses.Controls.ctrlDriverLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.txtLicenseID);
            this.gbFilter.Location = new System.Drawing.Point(10, 8);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(393, 72);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.btnFind.Location = new System.Drawing.Point(336, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 38);
            this.btnFind.TabIndex = 39;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "License ID:";
            // 
            // txtLicenseID
            // 
            this.txtLicenseID.Location = new System.Drawing.Point(113, 29);
            this.txtLicenseID.Name = "txtLicenseID";
            this.txtLicenseID.Size = new System.Drawing.Size(216, 20);
            this.txtLicenseID.TabIndex = 38;
            this.txtLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            this.txtLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseID_Validating);
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(4, 88);
            this.ctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(867, 339);
            this.ctrlDriverLicenseInfo1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(879, 439);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
