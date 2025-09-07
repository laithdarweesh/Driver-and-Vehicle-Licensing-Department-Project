namespace DVLD_Project.Tests.TestTypes
{
    partial class frmEditTestType
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pbDescription = new System.Windows.Forms.PictureBox();
            this.pbTestId = new System.Windows.Forms.PictureBox();
            this.pbFees = new System.Windows.Forms.PictureBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.PbTitle = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTestTypeId = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Test Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(36, 169);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(105, 20);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(322, 346);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(189, 346);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(184, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(263, 129);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // pbDescription
            // 
            this.pbDescription.Image = global::DVLD_Project.Properties.Resources.ApplicationTitle;
            this.pbDescription.Location = new System.Drawing.Point(147, 170);
            this.pbDescription.Name = "pbDescription";
            this.pbDescription.Size = new System.Drawing.Size(31, 26);
            this.pbDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDescription.TabIndex = 171;
            this.pbDescription.TabStop = false;
            // 
            // pbTestId
            // 
            this.pbTestId.Image = global::DVLD_Project.Properties.Resources.Number_321;
            this.pbTestId.Location = new System.Drawing.Point(147, 104);
            this.pbTestId.Name = "pbTestId";
            this.pbTestId.Size = new System.Drawing.Size(31, 26);
            this.pbTestId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestId.TabIndex = 180;
            this.pbTestId.TabStop = false;
            // 
            // pbFees
            // 
            this.pbFees.Image = global::DVLD_Project.Properties.Resources.money_32;
            this.pbFees.Location = new System.Drawing.Point(147, 306);
            this.pbFees.Name = "pbFees";
            this.pbFees.Size = new System.Drawing.Size(31, 26);
            this.pbFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFees.TabIndex = 179;
            this.pbFees.TabStop = false;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(184, 306);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(263, 26);
            this.txtFees.TabIndex = 2;
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // PbTitle
            // 
            this.PbTitle.Image = global::DVLD_Project.Properties.Resources.ApplicationTitle;
            this.PbTitle.Location = new System.Drawing.Point(147, 137);
            this.PbTitle.Name = "PbTitle";
            this.PbTitle.Size = new System.Drawing.Size(31, 26);
            this.PbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbTitle.TabIndex = 177;
            this.PbTitle.TabStop = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 137);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 26);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // lblTestTypeId
            // 
            this.lblTestTypeId.AutoSize = true;
            this.lblTestTypeId.Location = new System.Drawing.Point(184, 107);
            this.lblTestTypeId.Name = "lblTestTypeId";
            this.lblTestTypeId.Size = new System.Drawing.Size(18, 20);
            this.lblTestTypeId.TabIndex = 175;
            this.lblTestTypeId.Text = "?";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFees.Location = new System.Drawing.Point(36, 308);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(54, 20);
            this.lblFees.TabIndex = 174;
            this.lblFees.Text = "Fees:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(36, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 20);
            this.lblTitle.TabIndex = 173;
            this.lblTitle.Text = "Title:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblId.Location = new System.Drawing.Point(36, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(33, 20);
            this.lblId.TabIndex = 172;
            this.lblId.Text = "ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditTestType
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(477, 398);
            this.Controls.Add(this.pbTestId);
            this.Controls.Add(this.pbFees);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.PbTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTestTypeId);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pbDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Test Type";
            this.Load += new System.EventHandler(this.frmEditTestType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pbDescription;
        private System.Windows.Forms.PictureBox pbTestId;
        private System.Windows.Forms.PictureBox pbFees;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.PictureBox PbTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTestTypeId;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}