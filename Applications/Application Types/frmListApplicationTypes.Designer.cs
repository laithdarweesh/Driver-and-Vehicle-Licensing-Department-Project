namespace DVLD_Project.Applications.Application_Types
{
    partial class frmListApplicationTypes
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
            this.lblManageAppTypes = new System.Windows.Forms.Label();
            this.pbManageAppTypes = new System.Windows.Forms.PictureBox();
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cmsApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageAppTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmsApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageAppTypes
            // 
            this.lblManageAppTypes.AutoSize = true;
            this.lblManageAppTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblManageAppTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageAppTypes.Location = new System.Drawing.Point(149, 210);
            this.lblManageAppTypes.Name = "lblManageAppTypes";
            this.lblManageAppTypes.Size = new System.Drawing.Size(418, 37);
            this.lblManageAppTypes.TabIndex = 0;
            this.lblManageAppTypes.Text = "Manage Application Types";
            // 
            // pbManageAppTypes
            // 
            this.pbManageAppTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbManageAppTypes.Image = global::DVLD_Project.Properties.Resources.Application_Types_512;
            this.pbManageAppTypes.Location = new System.Drawing.Point(248, 9);
            this.pbManageAppTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbManageAppTypes.Name = "pbManageAppTypes";
            this.pbManageAppTypes.Size = new System.Drawing.Size(220, 189);
            this.pbManageAppTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageAppTypes.TabIndex = 1;
            this.pbManageAppTypes.TabStop = false;
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToResizeRows = false;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.cmsApplicationTypes;
            this.dgvApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(17, 280);
            this.dgvApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvApplicationTypes.MultiSelect = false;
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            this.dgvApplicationTypes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(666, 355);
            this.dgvApplicationTypes.TabIndex = 2;
            this.dgvApplicationTypes.TabStop = false;
            // 
            // cmsApplicationTypes
            // 
            this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.EditToolStripMenuItem,
            this.toolStripMenuItem2});
            this.cmsApplicationTypes.Name = "cmsPeople";
            this.cmsApplicationTypes.Size = new System.Drawing.Size(202, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.EditToolStripMenuItem.Text = "&Edit Application Type";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "#Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(114, 650);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(18, 20);
            this.lblRecord.TabIndex = 4;
            this.lblRecord.Text = "?";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(557, 650);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListApplicationTypes
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(700, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.pbManageAppTypes);
            this.Controls.Add(this.lblManageAppTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageAppTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmsApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageAppTypes;
        private System.Windows.Forms.PictureBox pbManageAppTypes;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}