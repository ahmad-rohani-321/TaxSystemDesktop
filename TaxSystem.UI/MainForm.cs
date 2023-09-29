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
    }
}