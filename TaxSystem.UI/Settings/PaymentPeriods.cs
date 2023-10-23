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
    public partial class PaymentPeriods : XtraForm
    {
        public PaymentPeriods()
        {
            InitializeComponent();
            GridPaymentPeriods.DataSource = Application.Settings.GetPaymentPeriods();
        }
        private Domain.Entities.PaymentPeriods period;
        private void BtnSave_Click(object sender, EventArgs e)
        {
            TxtName.ErrorText = string.Empty;
            if (TxtName.Text.Length != 0)
            {
                if (period != null)
                {
                    period.TypeName = TxtName.Text;
                    bool updated = Application.Settings.UpdatePaymentPeriod(period);
                    if (updated)
                    {
                        GridPaymentPeriods.DataSource = Application.Settings.GetPaymentPeriods();
                        GridPaymentPeriods.RefreshDataSource();
                        Clear();
                    }
                    else
                    {
                        Defaults.ErrorMessageBox();
                    }
                }
                else
                {
                    bool added = Application.Settings.AddPaymentPeriod(TxtName.Text);
                    if (added)
                    {
                        GridPaymentPeriods.DataSource = Application.Settings.GetPaymentPeriods();
                        GridPaymentPeriods.RefreshDataSource();
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
                TxtName.ErrorText = "د دورې نوم حتمي دی";
            }
        }

        private void ViewPaymentPeriods_DoubleClick(object sender, EventArgs e)
        {
            if (ViewPaymentPeriods.SelectedRowsCount > 0)
            {
                period = (Domain.Entities.PaymentPeriods)ViewPaymentPeriods.GetFocusedRow();
                TxtName.Text = period.TypeName;
            }
        }
        private void Clear()
        {
            TxtName.Text = string.Empty;
            period = null;
        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtName.ErrorText = string.Empty;
                if (TxtName.Text.Length != 0)
                {
                    if (period != null)
                    {
                        period.TypeName = TxtName.Text;
                        bool updated = Application.Settings.UpdatePaymentPeriod(period);
                        if (updated)
                        {
                            GridPaymentPeriods.DataSource = Application.Settings.GetPaymentPeriods();
                            GridPaymentPeriods.RefreshDataSource();
                            Clear();
                        }
                        else
                        {
                            Defaults.ErrorMessageBox();
                        }
                    }
                    else
                    {
                        bool added = Application.Settings.AddPaymentPeriod(TxtName.Text);
                        if (added)
                        {
                            GridPaymentPeriods.DataSource = Application.Settings.GetPaymentPeriods();
                            GridPaymentPeriods.RefreshDataSource();
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
                    TxtName.ErrorText = "د دورې نوم حتمي دی";
                }
            }
        }
    }
}