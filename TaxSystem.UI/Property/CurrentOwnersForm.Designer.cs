namespace TaxSystem.UI.Property
{
    partial class CurrentOwnersForm
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
            this.GridCurrentOwners = new DevExpress.XtraGrid.GridControl();
            this.ViewCurrentOwners = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TxtPhone = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.GridCurrentOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCurrentOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCurrentOwners
            // 
            this.GridCurrentOwners.Location = new System.Drawing.Point(11, 57);
            this.GridCurrentOwners.MainView = this.ViewCurrentOwners;
            this.GridCurrentOwners.Name = "GridCurrentOwners";
            this.GridCurrentOwners.Size = new System.Drawing.Size(817, 518);
            this.GridCurrentOwners.TabIndex = 0;
            this.GridCurrentOwners.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewCurrentOwners});
            // 
            // ViewCurrentOwners
            // 
            this.ViewCurrentOwners.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.ViewCurrentOwners.GridControl = this.GridCurrentOwners;
            this.ViewCurrentOwners.Name = "ViewCurrentOwners";
            this.ViewCurrentOwners.OptionsBehavior.Editable = false;
            this.ViewCurrentOwners.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "شمېره";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "نوم";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "موبایل شمېره";
            this.gridColumn3.FieldName = "Phone";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "اوسنی";
            this.gridColumn4.FieldName = "IsCurrent";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 112;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnSave);
            this.layoutControl1.Controls.Add(this.TxtPhone);
            this.layoutControl1.Controls.Add(this.TxtName);
            this.layoutControl1.Controls.Add(this.GridCurrentOwners);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(839, 586);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(839, 586);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridCurrentOwners;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(821, 522);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(474, 11);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(243, 42);
            this.TxtName.StyleController = this.layoutControl1;
            this.TxtName.TabIndex = 3;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TxtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(463, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(358, 46);
            this.layoutControlItem2.Text = "نوم";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 30);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(87, 11);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(272, 42);
            this.TxtPhone.StyleController = this.layoutControl1;
            this.TxtPhone.TabIndex = 4;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TxtPhone;
            this.layoutControlItem3.Location = new System.Drawing.Point(76, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(387, 46);
            this.layoutControlItem3.Text = "موبایل شمېره";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(99, 30);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(11, 11);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(72, 37);
            this.BtnSave.StyleController = this.layoutControl1;
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(76, 46);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // CurrentOwnersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(839, 586);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.Image = global::TaxSystem.UI.Properties.Resources.Kandahar1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrentOwnersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اوسنۍ مالک";
            ((System.ComponentModel.ISupportInitialize)(this.GridCurrentOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCurrentOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCurrentOwners;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewCurrentOwners;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TxtPhone;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}