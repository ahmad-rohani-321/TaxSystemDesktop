using DevExpress.XtraEditors;
using System;

namespace TaxSystem.UI.Owners
{
    public partial class AddEditOwner : XtraForm
    {
        Domain.Entities.Owners owner;
        public AddEditOwner()
        {
            InitializeComponent();
        }
        public AddEditOwner(Domain.Entities.Owners own)
        {
            InitializeComponent();
            owner = own;
            TxtFirstName.Text = own.FirstName;
            TxtLastName.Text = own.LastName;
            TxtFatherName.Text = own.FatherName;
            TxtGrandFatherName.Text = own.GrandFatherName;
            TxtNationalID.Text = own.NationalID;
            TxtSavePage.Text = own.PageNo;
            TxtJuldNo.Text = own.JuldNo;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                if (owner != null)
                {
                    owner.FirstName = TxtFirstName.Text;
                    owner.LastName = TxtLastName.Text;
                    owner.FatherName = TxtFatherName.Text;
                    owner.GrandFatherName = TxtGrandFatherName.Text;
                    owner.NationalID = TxtNationalID.Text;
                    owner.JuldNo = TxtJuldNo.Text;
                    owner.PageNo = TxtSavePage.Text;
                    bool Updated = Application.Owners.EditOwner(owner);
                    if (Updated)
                    {
                        Defaults.SucccessMessageBox();
                        Close();    
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
                else
                {
                    Domain.Entities.Owners own = new Domain.Entities.Owners()
                    {
                        FirstName = TxtFirstName.Text,
                        LastName = TxtLastName.Text,
                        FatherName = TxtFatherName.Text,
                        GrandFatherName = TxtGrandFatherName.Text,
                        NationalID = TxtNationalID.Text,
                        JuldNo = TxtJuldNo.Text,
                        PageNo = TxtSavePage.Text
                    };
                    bool Added = Application.Owners.AddOwner(own);
                    if (Added)
                    {
                        Defaults.SucccessMessageBox();
                        ClearForm();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
            }
        }

        private new bool Validated()
        {
            bool result = true;

            if (TxtFirstName.Text.Equals(string.Empty))
            {
                TxtFirstName.ErrorText = "نوم حتمي دی";
                result = false;
            }
            else
            {
                TxtFirstName.ErrorText = string.Empty;
            }

            if (TxtFatherName.Text.Equals(string.Empty))
            {
                TxtFatherName.ErrorText = "د پلار نوم حتمی دی";
                result = false;
            }
            else
            {
                TxtFatherName.ErrorText = string.Empty;
            }

            if (TxtGrandFatherName.Text.Equals(string.Empty))
            {
                TxtGrandFatherName.ErrorText = "د نیکه نوم حتمي دی";
                result = false;
            }
            else
            {
                TxtGrandFatherName.ErrorText = string.Empty;
            }

            if (TxtNationalID.Text.Equals(string.Empty))
            {
                TxtNationalID.ErrorText = "تذکرې شمېره حتمي ده";
                result = false;
            }
            else
            {
                TxtNationalID.ErrorText = string.Empty;
            }
            return result;
        }
        private void ClearForm()
        {
            TxtFatherName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtFatherName.Text = string.Empty;
            TxtGrandFatherName.Text = string.Empty;
            TxtNationalID.Text = string.Empty;
            TxtJuldNo.Text = string.Empty;
            TxtSavePage.Text = string.Empty;
            owner = null;
        }
    }
}