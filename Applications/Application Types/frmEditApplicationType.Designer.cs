namespace DVLD_Project.Applications.Application_Types
{
    partial class frmEditApplicationType
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblApplicationTypeId = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.PbTitle = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbAppId = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Application Type";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(36, 104);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(36, 149);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFees.Location = new System.Drawing.Point(36, 192);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(54, 20);
            this.lblFees.TabIndex = 3;
            this.lblFees.Text = "Fees:";
            // 
            // lblApplicationTypeId
            // 
            this.lblApplicationTypeId.AutoSize = true;
            this.lblApplicationTypeId.Location = new System.Drawing.Point(127, 107);
            this.lblApplicationTypeId.Name = "lblApplicationTypeId";
            this.lblApplicationTypeId.Size = new System.Drawing.Size(18, 20);
            this.lblApplicationTypeId.TabIndex = 4;
            this.lblApplicationTypeId.Text = "?";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 147);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 26);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(127, 190);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(263, 26);
            this.txtFees.TabIndex = 12;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // pbFees
            // 
            this.pbFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbFees.Location = new System.Drawing.Point(90, 190);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(31, 26);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 13;
            this.pbFees.TabStop = false;
            // 
            // PbTitle
            // 
            this.PbTitle.Image = global::DVLD_Project.Properties.Resources.ApplicationTitle;
            this.PbTitle.Location = new System.Drawing.Point(90, 147);
            this.PbTitle.Name = "PbTitle";
            this.PbTitle.Size = new System.Drawing.Size(31, 26);
            this.PbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTitle.TabIndex = 11;
            this.PbTitle.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(264, 237);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(131, 237);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbAppId
            // 
            this.pbAppId.Image = global::DVLD_Project.Properties.Resources.Number_321;
            this.pbAppId.Location = new System.Drawing.Point(90, 104);
            this.pbAppId.Name = "pbAppId";
            this.pbAppId.Size = new System.Drawing.Size(31, 26);
            this.pbAppId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppId.TabIndex = 169;
            this.pbAppId.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.pbAppId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbFees);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.PbTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblApplicationTypeId);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Application Type";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblApplicationTypeId;
        private System.Windows.Forms.PictureBox PbTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbAppId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}