using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.Application_Types
{
    public partial class frmListApplicationTypes : Form
    {
        private static DataTable dtApplicationTypes;
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();

            if(dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "ID";
                dgvApplicationTypes.Columns[0].Width = 70;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 450;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 104;
            }
        }

        private void _RefreshApplicationTypesList()
        {
            dtApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = dtApplicationTypes;
            lblRecord.Text = dgvApplicationTypes.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int) dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshApplicationTypesList();
        }
    }
}
