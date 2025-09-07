using DVLD_Buisness;
using DVLD_Project.Applications.Local_Driving_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.People.Controls
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        public event Action<int> OnAddNewPerson;
        protected virtual void PersonSelected(int PersonId)
        {
            Action<int> Handler = OnPersonSelected;

            if(Handler != null)
            {
                Handler(PersonId);
            }
        }
        protected virtual void PersonAdded(int PersonID)
        {
            Action<int> Handler = OnAddNewPerson;

            if(Handler != null)
            {
                Handler(PersonID);
            }
        }

        private int _PersonId = -1;

        public int PersonId
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get
            {
                return ctrlPersonCard1.SelectedPersonInfo;
            }
        }

        private bool _ShowAddPerson = true;
        
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewPerson.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get 
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonId)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonId.ToString();
            FindNow();
        }

        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ctrlPersonCard1.LoadPersonInfo(int.Parse(txtFilterValue.Text));
                    break;

                case "National No":
                    ctrlPersonCard1.LoadPersonInfo(txtFilterValue.Text);
                    break;

                default:
                    break;
            }

            if(OnPersonSelected != null && FilterEnabled)
            {
                OnPersonSelected(ctrlPersonCard1.PersonID);
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilterFocus();
                return;
            }

            FindNow();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();

            if (OnAddNewPerson != null && FilterEnabled)
                PersonAdded(PersonId);
        }

        private void DataBackEvent(object sender, int PersonId)
        {
            

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = PersonId.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonId);
        }

        private void ctrlPersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel= false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
