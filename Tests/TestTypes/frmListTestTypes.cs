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

namespace DVLD_Project.Tests.TestTypes
{
    public partial class frmListTestTypes : Form
    {
        private static DataTable dtTestTypes;
        public frmListTestTypes()
        {
            InitializeComponent();
        }

        private void frmListTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();

            if(dgvListTestTypes.Rows.Count > 0 ) 
            {
                dgvListTestTypes.Columns[0].HeaderText = "ID";
                dgvListTestTypes.Columns[0].Width = 70;

                dgvListTestTypes.Columns[1].HeaderText = "Title";
                dgvListTestTypes.Columns[1].Width = 170;

                dgvListTestTypes.Columns[2].HeaderText = "Description";
                dgvListTestTypes.Columns[2].Width = 500;

                dgvListTestTypes.Columns[3].HeaderText = "Fees";
                dgvListTestTypes.Columns[3].Width = 127;
            }
        }

        private void _RefreshTestTypesList()
        {
            dtTestTypes = clsTestType.GetAllTestTypes();
            dgvListTestTypes.DataSource = dtTestTypes;
            lblRecord.Text = dgvListTestTypes.Rows.Count.ToString(); 
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((clsTestType.enTestType)dgvListTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListTestTypes_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
