using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxSystem.UI.Property
{
    public partial class CurrentOwnersForm : DevExpress.XtraEditors.XtraForm
    {
        private int _id = 0;
        public CurrentOwnersForm(int id)
        {
            InitializeComponent();
            _id = id;
            GridCurrentOwners.DataSource = Application.Property.GetCurrentOwners(id);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                Domain.Entities.CurrentOwners current = new Domain.Entities.CurrentOwners()
                {
                    Name = TxtName.Text,
                    Phone = TxtPhone.Text,
                    IsCurrent = true, 
                    PropertyOwnerId = _id
                };
                bool Added = Application.Property.AddCurrentOwner(current);
                if (Added)
                {
                    Defaults.SucccessMessageBox();
                    RefreshData();
                    Clear();
                }
                else
                {
                    Defaults.ErrorMessageBox();
                }
            }
        }

        private void Clear()
        {
            TxtName.Text = string.Empty;
            TxtPhone.Text = string.Empty;
        }

        private new bool Validated()
        {
            bool result = true;
            if (TxtName.Text.Length <= 0)
            {
                TxtName.ErrorText = "د مالک نوم حتمي دی";
                result = false;
            }
            else
            {
                TxtName.ErrorText = string.Empty;
            }
            if (TxtPhone.Text.Length <= 0)
            {
                TxtPhone.ErrorText = "د مالک شمېره حتمي ده";
                result = false;
            }
            else
            {
                TxtPhone.ErrorText = string.Empty;
            }
            return result;
        }

        private void RefreshData()
        {
            GridCurrentOwners.DataSource = Application.Property.GetCurrentOwners(_id);
            GridCurrentOwners.RefreshDataSource();
        }
    }
}