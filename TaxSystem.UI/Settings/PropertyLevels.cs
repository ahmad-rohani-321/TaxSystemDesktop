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

namespace TaxSystem.UI.Settings
{
    public partial class PropertyLevels : XtraForm
    {
        public PropertyLevels()
        {
            InitializeComponent();
            GridLevels.DataSource = Application.Settings.GetLevels();
        }
        private Domain.Entities.PropertyLevel level;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            TxtName.ErrorText = string.Empty;
            if (TxtName.Text.Length != 0)
            {
                if (level != null)
                {
                    level.LevelName = TxtName.Text;
                    bool updated = Application.Settings.UpdateLevels(level);
                    if (updated)
                    {
                        GridLevels.DataSource = Application.Settings.GetLevels();
                        GridLevels.RefreshDataSource();
                        Clear();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
                else
                {
                    bool added = Application.Settings.AddLevel(TxtName.Text);
                    if (added)
                    {
                        GridLevels.DataSource = Application.Settings.GetLevels();
                        GridLevels.RefreshDataSource();
                        Clear();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
            }
            else
            {
                TxtName.ErrorText = "د درجې نوم حتمي دی";
            }
        }

        private void ViewPaymentPeriods_DoubleClick(object sender, EventArgs e)
        {
            if (ViewLevels.SelectedRowsCount > 0)
            {
                level = (Domain.Entities.PropertyLevel)ViewLevels.GetFocusedRow();
                TxtName.Text = level.LevelName;
            }
        }
        private void Clear()
        {
            TxtName.Text = string.Empty;
            level = null;
        }
    }
}