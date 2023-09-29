﻿namespace TaxSystem.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Owners = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnNewOwner = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAllOwners = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDeletedUsers = new DevExpress.XtraBars.BarButtonItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.MainDocument = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "مالکین";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Owners});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "عمومي";
            // 
            // Owners
            // 
            this.Owners.ItemLinks.Add(this.BtnNewOwner);
            this.Owners.ItemLinks.Add(this.BtnAllOwners);
            this.Owners.ItemLinks.Add(this.BtnDeletedUsers);
            this.Owners.Name = "Owners";
            this.Owners.Text = "مالکین";
            // 
            // BtnNewOwner
            // 
            this.BtnNewOwner.Caption = "نوی مالک";
            this.BtnNewOwner.Id = 1;
            this.BtnNewOwner.ImageOptions.Image = global::TaxSystem.UI.Properties.Resources.AddOwner;
            this.BtnNewOwner.Name = "BtnNewOwner";
            this.BtnNewOwner.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnNewOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnNewOwner_ItemClick);
            // 
            // BtnAllOwners
            // 
            this.BtnAllOwners.Caption = "ټول مالکین";
            this.BtnAllOwners.Id = 2;
            this.BtnAllOwners.ImageOptions.Image = global::TaxSystem.UI.Properties.Resources.Owners;
            this.BtnAllOwners.Name = "BtnAllOwners";
            this.BtnAllOwners.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnAllOwners.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAllOwners_ItemClick);
            // 
            // BtnDeletedUsers
            // 
            this.BtnDeletedUsers.Caption = "حذف سوي مالکین";
            this.BtnDeletedUsers.Id = 3;
            this.BtnDeletedUsers.ImageOptions.Image = global::TaxSystem.UI.Properties.Resources.Trash;
            this.BtnDeletedUsers.Name = "BtnDeletedUsers";
            this.BtnDeletedUsers.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.BtnDeletedUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDeletedUsers_ItemClick);
            // 
            // ribbon
            // 
            this.ribbon.AllowKeyTips = false;
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.AllowTrimPageText = false;
            this.ribbon.AutoSizeItems = true;
            this.ribbon.AutoUpdateMergedRibbons = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Skin;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BtnNewOwner,
            this.BtnAllOwners,
            this.BtnDeletedUsers});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowSearchItem = true;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1350, 290);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // MainDocument
            // 
            this.MainDocument.MdiParent = this;
            this.MainDocument.MenuManager = this.ribbon;
            this.MainDocument.View = this.tabbedView1;
            this.MainDocument.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1350, 761);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = global::TaxSystem.UI.Properties.Resources.Kandahar1;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمومي فورم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Owners;
        private DevExpress.XtraBars.BarButtonItem BtnNewOwner;
        private DevExpress.XtraBars.BarButtonItem BtnAllOwners;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Docking2010.DocumentManager MainDocument;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem BtnDeletedUsers;
    }
}