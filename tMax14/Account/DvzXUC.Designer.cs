namespace tMax14.Account
{
    partial class DvzXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.dVZ_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVZ_SELTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.DVZ_SELTableAdapter();
            this.dvzGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvzGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.trh2DateEdit = new DevExpress.XtraEditors.DateEdit();
            this.trhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVZ_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvzGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trh2DateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh2DateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVZ_SELBindingSource
            // 
            this.dVZ_SELBindingSource.DataMember = "DVZ_SEL";
            this.dVZ_SELBindingSource.DataSource = this.accountDataSet;
            // 
            // dVZ_SELTableAdapter
            // 
            this.dVZ_SELTableAdapter.ClearBeforeFill = true;
            // 
            // dvzGridControl
            // 
            this.dvzGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.dvzGridControl.DataSource = this.dVZ_SELBindingSource;
            this.dvzGridControl.Location = new System.Drawing.Point(4, 28);
            this.dvzGridControl.MainView = this.dvzGridView;
            this.dvzGridControl.Name = "dvzGridControl";
            this.dvzGridControl.Size = new System.Drawing.Size(416, 268);
            this.dvzGridControl.TabIndex = 2;
            this.dvzGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvzGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // dvzGridView
            // 
            this.dvzGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDVZ,
            this.colKUR1,
            this.colKUR2,
            this.colKUR3,
            this.colKUR4,
            this.colTRH});
            this.dvzGridView.GridControl = this.dvzGridControl;
            this.dvzGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "KUR1", null, "  MBA:{0:n4}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "KUR2", null, "  MBS:{0:n4}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "KUR3", null, "  YKA:{0:n4}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "KUR4", null, "  YKS:{0:n4}")});
            this.dvzGridView.Name = "dvzGridView";
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.AllowEdit = false;
            this.colDVZ.OptionsColumn.AllowFocus = false;
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 0;
            this.colDVZ.Width = 35;
            // 
            // colKUR1
            // 
            this.colKUR1.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR1.Caption = "MB Alş";
            this.colKUR1.FieldName = "KUR1";
            this.colKUR1.Name = "colKUR1";
            this.colKUR1.OptionsColumn.ReadOnly = true;
            this.colKUR1.Visible = true;
            this.colKUR1.VisibleIndex = 2;
            this.colKUR1.Width = 80;
            // 
            // colKUR2
            // 
            this.colKUR2.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR2.Caption = "MB Stş";
            this.colKUR2.FieldName = "KUR2";
            this.colKUR2.Name = "colKUR2";
            this.colKUR2.Visible = true;
            this.colKUR2.VisibleIndex = 3;
            this.colKUR2.Width = 69;
            // 
            // colKUR3
            // 
            this.colKUR3.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR3.Caption = "GB Alş";
            this.colKUR3.FieldName = "KUR3";
            this.colKUR3.Name = "colKUR3";
            this.colKUR3.Visible = true;
            this.colKUR3.VisibleIndex = 4;
            this.colKUR3.Width = 69;
            // 
            // colKUR4
            // 
            this.colKUR4.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR4.Caption = "GB Stş";
            this.colKUR4.FieldName = "KUR4";
            this.colKUR4.Name = "colKUR4";
            this.colKUR4.Visible = true;
            this.colKUR4.VisibleIndex = 5;
            // 
            // colTRH
            // 
            this.colTRH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTRH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.AllowEdit = false;
            this.colTRH.OptionsColumn.AllowFocus = false;
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 1;
            this.colTRH.Width = 70;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.trh2DateEdit);
            this.layoutControl1.Controls.Add(this.trhDateEdit);
            this.layoutControl1.Controls.Add(this.dvzGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(424, 300);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // trh2DateEdit
            // 
            this.trh2DateEdit.EditValue = null;
            this.trh2DateEdit.Location = new System.Drawing.Point(252, 4);
            this.trh2DateEdit.Name = "trh2DateEdit";
            this.trh2DateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trh2DateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trh2DateEdit.Size = new System.Drawing.Size(168, 20);
            this.trh2DateEdit.StyleController = this.layoutControl1;
            this.trh2DateEdit.TabIndex = 5;
            this.trh2DateEdit.EditValueChanged += new System.EventHandler(this.trhDateEdit_EditValueChanged);
            // 
            // trhDateEdit
            // 
            this.trhDateEdit.EditValue = null;
            this.trhDateEdit.Location = new System.Drawing.Point(42, 4);
            this.trhDateEdit.Name = "trhDateEdit";
            this.trhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trhDateEdit.Size = new System.Drawing.Size(168, 20);
            this.trhDateEdit.StyleController = this.layoutControl1;
            this.trhDateEdit.TabIndex = 4;
            this.trhDateEdit.EditValueChanged += new System.EventHandler(this.trhDateEdit_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(424, 300);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dvzGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(420, 272);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trhDateEdit;
            this.layoutControlItem2.CustomizationFormText = "Tarih";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem2.Text = "Tarih";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.trh2DateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(210, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(210, 24);
            this.layoutControlItem3.Text = "Trh <=";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(35, 13);
            // 
            // DvzXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl1);
            this.Name = "DvzXUC";
            this.Size = new System.Drawing.Size(424, 300);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVZ_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvzGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvzGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trh2DateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh2DateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource dVZ_SELBindingSource;
        private AccountDataSetTableAdapters.DVZ_SELTableAdapter dVZ_SELTableAdapter;
        private DevExpress.XtraGrid.GridControl dvzGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dvzGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR1;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit trhDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR2;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR3;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR4;
        private DevExpress.XtraEditors.DateEdit trh2DateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}
