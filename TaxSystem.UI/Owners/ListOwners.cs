using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
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

namespace TaxSystem.UI.Owners
{
    public partial class ListOwners : DevExpress.XtraEditors.XtraForm
    {
        public ListOwners()
        {
            InitializeComponent();
            GridAllOwners.DataSource = Application.Owners.GetAll();
        }

        private void BtnUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ViewAllOwners.SelectedRowsCount > 0)
            {
                string text = (string)ViewAllOwners.GetFocusedRowCellValue("FirstName");
                var form = System.Windows.Forms.Application.OpenForms.OfType<AddEditOwner>().Where(x => x.Text == text);
                if (form.Count() != 1)
                {
                    Domain.Entities.Owners own = (Domain.Entities.Owners)ViewAllOwners.GetFocusedRow();
                    AddEditOwner owner = new AddEditOwner(own);
                    owner.Text = text;
                    owner.MdiParent = System.Windows.Forms.Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    owner.Show();
                }
                else
                {
                    form.First().Focus();
                }
            }
        }

        private void BtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            GridAllOwners.DataSource = Application.Owners.GetAll();
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Defaults.YesNoMessageBox("غواړئ مالک حذف کړئ؟") == DialogResult.Yes)
            {
                if (ViewAllOwners.SelectedRowsCount > 0)
                {
                    int Row = (int)ViewAllOwners.GetFocusedRowCellValue("Id");
                    bool Deleted = Application.Owners.ChangeDeleteStatus(Row, true);
                    if (Deleted)
                    {
                        GridAllOwners.RefreshDataSource();
                        Defaults.SucccessMessageBox();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
            }
        }

        private void BtnSearch_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Name  = XtraInputBox.Show("پلټنه", "پلټنه", "");
            GridAllOwners.DataSource = Application.Owners.GetBySearch(Name);
            GridAllOwners.RefreshDataSource();
            GridAllOwners.Refresh();
        }
        public Domain.Entities.Owners thisOwner;
        private void GridAllOwners_DoubleClick(object sender, EventArgs e)
        {
            if (ViewAllOwners.SelectedRowsCount > 0)
            {
                thisOwner = (Domain.Entities.Owners)ViewAllOwners.GetFocusedRow();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}