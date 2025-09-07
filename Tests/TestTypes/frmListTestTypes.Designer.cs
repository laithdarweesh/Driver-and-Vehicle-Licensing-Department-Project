namespace DVLD_Project.Tests.TestTypes
{
    partial class frmListTestTypes
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
            this.lblManageTestType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.pbManageTestType = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvListTestTypes = new System.Windows.Forms.DataGridView();
            this.cmsTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTestType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).BeginInit();
            this.cmsTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManageTestType
            // 
            this.lblManageTestType.AutoSize = true;
            this.lblManageTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblManageTestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageTestType.Location = new System.Drawing.Point(316, 209);
            this.lblManageTestType.Name = "lblManageTestType";
            this.lblManageTestType.Size = new System.Drawing.Size(298, 37);
            this.lblManageTestType.TabIndex = 0;
            this.lblManageTestType.Text = "Manage Test Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Record:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(96, 412);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(18, 20);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "?";
            // 
            // pbManageTestType
            // 
            this.pbManageTestType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbManageTestType.Image = global::DVLD_Project.Properties.Resources.TestType_512;
            this.pbManageTestType.Location = new System.Drawing.Point(355, 5);
            this.pbManageTestType.Name = "pbManageTestType";
            this.pbManageTestType.Size = new System.Drawing.Size(220, 189);
            this.pbManageTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManageTestType.TabIndex = 3;
            this.pbManageTestType.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(795, 412);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvListTestTypes
            // 
            this.dgvListTestTypes.AllowUserToAddRows = false;
            this.dgvListTestTypes.AllowUserToDeleteRows = false;
            this.dgvListTestTypes.AllowUserToResizeColumns = false;
            this.dgvListTestTypes.AllowUserToResizeRows = false;
            this.dgvListTestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTestTypes.ContextMenuStrip = this.cmsTestTypes;
            this.dgvListTestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListTestTypes.Location = new System.Drawing.Point(13, 261);
            this.dgvListTestTypes.Name = "dgvListTestTypes";
            this.dgvListTestTypes.ReadOnly = true;
            this.dgvListTestTypes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvListTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTestTypes.Size = new System.Drawing.Size(908, 136);
            this.dgvListTestTypes.TabIndex = 37;
            // 
            // cmsTestTypes
            // 
            this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.EditToolStripMenuItem,
            this.toolStripMenuItem2});
            this.cmsTestTypes.Name = "cmsPeople";
            this.cmsTestTypes.Size = new System.Drawing.Size(161, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.EditToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.EditToolStripMenuItem.Text = "&Edit Test Type";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // frmListTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.dgvListTestTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbManageTestType);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblManageTestType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Test Types";
            this.Load += new System.EventHandler(this.frmListTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbManageTestType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTestTypes)).EndInit();
            this.cmsTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageTestType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.PictureBox pbManageTestType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}