using DevExpress.Data.Helpers;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TaxSystem.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region MainForms 
        int countAddEditForm = 0;
        private void BtnNewOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            Owners.AddEditOwner owner = new Owners.AddEditOwner();
            owner.Text = "شخص " + (countAddEditForm += 1);
            owner.MdiParent = this;
            owner.Show();
        }

        private void BtnAllOwners_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Owners.ListOwners>();
            if (!(form.Count() == 1))
            {
                Owners.ListOwners list = new Owners.ListOwners();
                list.MdiParent = this;
                list.Show();
            }
            else
            {
                form.First().Focus();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Defaults.YesNoMessageBox("غواړئ فورم بند کړئ؟") == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnDeletedUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Owners.ListDeletedOwners>();
            if (!(form.Count() == 1))
            {
                Owners.ListDeletedOwners list = new Owners.ListDeletedOwners();
                list.MdiParent = this;
                list.Show();
            }
            else
            {
                form.First().Focus();
            }
        }

        private void BtnPropertiesList_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Property.PropertiesList>();
            if (!(form.Count() == 1))
            {
                Property.PropertiesList list = new Property.PropertiesList();
                list.MdiParent = this;
                list.Show();
            }
            else
            {
                form.First().Focus();
            }
        }
        private int countAddProperty = 0;
        private void BtnAddProperty_ItemClick(object sender, ItemClickEventArgs e)
        {
            Property.AddProperty property = new Property.AddProperty();
            property.Text = "ملکیت " + (countAddProperty += 1);
            property.MdiParent = this;
            property.Show();
        }

        private void BtnListDeletedProperties_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Property.DeletedPropertiesList>();
            if (!(form.Count() == 1))
            {
                Property.DeletedPropertiesList list = new Property.DeletedPropertiesList();
                list.MdiParent = this;
                list.Show();
            }
            else
            {
                form.First().Focus();
            }
        }
        #endregion

        #region Settings
        private void BtnPaymentPeriods_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Settings.PaymentPeriods>().FirstOrDefault();
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Settings.PaymentPeriods paymentPeriods = new Settings.PaymentPeriods();
                paymentPeriods.MdiParent = this;
                paymentPeriods.Show();
            }
        }
        private void BtnLevels_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = System.Windows.Forms.Application.OpenForms.OfType<Settings.PropertyLevels>().FirstOrDefault();
            if (form != null)
            {
                form.Focus();
            }
            else
            {
                Settings.PropertyLevels level = new Settings.PropertyLevels();
                level.MdiParent = this;
                level.Show();
            }
        }
        #endregion
    }
}