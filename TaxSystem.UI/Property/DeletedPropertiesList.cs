using DevExpress.XtraBars;
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
    public partial class DeletedPropertiesList : DevExpress.XtraEditors.XtraForm
    {
        public DeletedPropertiesList()
        {
            InitializeComponent();
            GridAllProperties.DataSource = Application.Property.GetDeletedProperties();
        }

        private void BtnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ViewAllProperties.SelectedRowsCount > 0)
            {
                string name = (string)ViewAllProperties.GetFocusedRowCellValue("Location");
                var Form = System.Windows.Forms.Application.OpenForms.OfType<AddProperty>().Where(x => x.Text == name);
                if (Form.Count() != 0)
                {
                    Form.FirstOrDefault().Focus();
                }
                else
                {
                    Domain.Entities.PropertyInfo entity = (Domain.Entities.PropertyInfo)ViewAllProperties.GetFocusedRow();
                    AddProperty property = new AddProperty(entity);
                    property.MdiParent = System.Windows.Forms.Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    property.Show();
                }
            }
        }

        private void BtnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ViewAllProperties.SelectedRowsCount > 0)
            {
                if (Defaults.YesNoMessageBox("غواړئ ملکیت ریسټور کړئ؟")
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (int)ViewAllProperties.GetFocusedRowCellValue("Id");
                    bool deleted = Application.Property.DeleteProperty(id, false);
                    if (deleted)
                    {
                        Defaults.SucccessMessageBox();
                        RefreshData();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
            }
        }

        private void BtnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            GridAllProperties.DataSource = Application.Property.GetDeletedProperties();
            GridAllProperties.RefreshDataSource();
            GridAllProperties.Refresh();
        }
    }
}