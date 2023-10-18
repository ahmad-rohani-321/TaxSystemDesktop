using DevExpress.XtraEditors;
using System.Linq;

namespace TaxSystem.UI.Property
{
    public partial class PropertiesList : XtraForm
    {
        public PropertiesList()
        {
            InitializeComponent();
            GridAllProperties.DataSource = Application.Property.GetProperties();
        }

        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void BtnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ViewAllProperties.SelectedRowsCount > 0)
            {
                if (Defaults.YesNoMessageBox("غواړئ ملکیت حذف کړئ؟")
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    int id = (int)ViewAllProperties.GetFocusedRowCellValue("Id");
                    bool deleted = Application.Property.DeleteProperty(id, true);
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
        private void RefreshData()
        {
            GridAllProperties.DataSource = Application.Property.GetProperties();
            GridAllProperties.RefreshDataSource();
            GridAllProperties.Refresh();
        }

        private void BtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        private void BtnPhoneNumbers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ViewAllProperties.SelectedRowsCount > 0)
            {
                int id = (int)ViewAllProperties.GetFocusedRowCellValue("Id");
                CurrentOwnersForm form = new CurrentOwnersForm(id);
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}