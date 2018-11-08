namespace tMax14.Traxon
{
    partial class Trx2XF
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
            this.traxonQueriesTableAdapter = new tMax14.Traxon.TraxonDataSetTableAdapters.TraxonQueriesTableAdapter();
            this.traxonDataSet = new tMax14.Traxon.TraxonDataSet();
            this.tRX3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRX3TableAdapter = new tMax14.Traxon.TraxonDataSetTableAdapters.TRX3TableAdapter();
            this.trx3GridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGELEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIDEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.progressBarControl = new DevExpress.XtraEditors.ProgressBarControl();
            this.gidenMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.gelenMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem4 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.trX3_FHL4TableAdapter1 = new tMax14.Traxon.TraxonDataSetTableAdapters.TRX3_FHL4TableAdapter();
            this.trX3_FWB16TableAdapter1 = new tMax14.Traxon.TraxonDataSetTableAdapters.TRX3_FWB16TableAdapter();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.traxonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRX3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trx3GridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gidenMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // traxonDataSet
            // 
            this.traxonDataSet.DataSetName = "TraxonDataSet";
            this.traxonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRX3BindingSource
            // 
            this.tRX3BindingSource.DataMember = "TRX3";
            this.tRX3BindingSource.DataSource = this.traxonDataSet;
            // 
            // tRX3TableAdapter
            // 
            this.tRX3TableAdapter.ClearBeforeFill = true;
            // 
            // trx3GridControl
            // 
            this.trx3GridControl.ContextMenuStrip = this.contextMenuStrip;
            this.trx3GridControl.DataSource = this.tRX3BindingSource;
            this.trx3GridControl.Location = new System.Drawing.Point(12, 28);
            this.trx3GridControl.MainView = this.gridView1;
            this.trx3GridControl.Name = "trx3GridControl";
            this.trx3GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.trx3GridControl.Size = new System.Drawing.Size(953, 317);
            this.trx3GridControl.TabIndex = 3;
            this.trx3GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getToolStripMenuItem,
            this.putToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(93, 48);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.getToolStripMenuItem.Text = "Get";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // putToolStripMenuItem
            // 
            this.putToolStripMenuItem.Name = "putToolStripMenuItem";
            this.putToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.putToolStripMenuItem.Text = "Put";
            this.putToolStripMenuItem.Click += new System.EventHandler(this.putToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMID,
            this.colREFNO,
            this.colEXD,
            this.colMSGID,
            this.colGELEN,
            this.colGIDEN,
            this.colERR,
            this.colUSR,
            this.colINSTS});
            this.gridView1.GridControl = this.trx3GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEXD, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colMID
            // 
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.OptionsColumn.FixedWidth = true;
            this.colMID.Visible = true;
            this.colMID.VisibleIndex = 0;
            this.colMID.Width = 60;
            // 
            // colREFNO
            // 
            this.colREFNO.Caption = "RefNo";
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.OptionsColumn.FixedWidth = true;
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 1;
            this.colREFNO.Width = 110;
            // 
            // colEXD
            // 
            this.colEXD.DisplayFormat.FormatString = "dd.MM.yy HH:mm:ss";
            this.colEXD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 2;
            this.colEXD.Width = 100;
            // 
            // colMSGID
            // 
            this.colMSGID.AppearanceCell.Options.UseTextOptions = true;
            this.colMSGID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMSGID.Caption = "MsgID";
            this.colMSGID.FieldName = "MSGID";
            this.colMSGID.Name = "colMSGID";
            this.colMSGID.OptionsColumn.FixedWidth = true;
            this.colMSGID.Visible = true;
            this.colMSGID.VisibleIndex = 3;
            this.colMSGID.Width = 57;
            // 
            // colGELEN
            // 
            this.colGELEN.Caption = "Gelen";
            this.colGELEN.FieldName = "GELEN";
            this.colGELEN.Name = "colGELEN";
            this.colGELEN.Visible = true;
            this.colGELEN.VisibleIndex = 4;
            this.colGELEN.Width = 202;
            // 
            // colGIDEN
            // 
            this.colGIDEN.Caption = "Giden";
            this.colGIDEN.FieldName = "GIDEN";
            this.colGIDEN.Name = "colGIDEN";
            this.colGIDEN.Visible = true;
            this.colGIDEN.VisibleIndex = 5;
            this.colGIDEN.Width = 243;
            // 
            // colERR
            // 
            this.colERR.AppearanceHeader.Options.UseTextOptions = true;
            this.colERR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colERR.Caption = "Err";
            this.colERR.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colERR.FieldName = "ERR";
            this.colERR.Name = "colERR";
            this.colERR.OptionsColumn.FixedWidth = true;
            this.colERR.Visible = true;
            this.colERR.VisibleIndex = 6;
            this.colERR.Width = 40;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = "T";
            this.repositoryItemCheckEdit1.ValueUnchecked = "F";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.progressBarControl);
            this.layoutControl1.Controls.Add(this.gidenMemoEdit);
            this.layoutControl1.Controls.Add(this.gelenMemoEdit);
            this.layoutControl1.Controls.Add(this.trx3GridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(943, 349, 250, 532);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(977, 592);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Location = new System.Drawing.Point(12, 562);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Properties.ShowTitle = true;
            this.progressBarControl.Properties.Step = 1;
            this.progressBarControl.Size = new System.Drawing.Size(953, 18);
            this.progressBarControl.StyleController = this.layoutControl1;
            this.progressBarControl.TabIndex = 8;
            // 
            // gidenMemoEdit
            // 
            this.gidenMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRX3BindingSource, "GIDEN", true));
            this.gidenMemoEdit.Location = new System.Drawing.Point(501, 370);
            this.gidenMemoEdit.Name = "gidenMemoEdit";
            this.gidenMemoEdit.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.gidenMemoEdit.Properties.ReadOnly = true;
            this.gidenMemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.gidenMemoEdit.Properties.UseReadOnlyAppearance = false;
            this.gidenMemoEdit.Properties.WordWrap = false;
            this.gidenMemoEdit.Size = new System.Drawing.Size(464, 188);
            this.gidenMemoEdit.StyleController = this.layoutControl1;
            this.gidenMemoEdit.TabIndex = 7;
            // 
            // gelenMemoEdit
            // 
            this.gelenMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRX3BindingSource, "GELEN", true));
            this.gelenMemoEdit.Location = new System.Drawing.Point(12, 370);
            this.gelenMemoEdit.Name = "gelenMemoEdit";
            this.gelenMemoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.gelenMemoEdit.Properties.WordWrap = false;
            this.gelenMemoEdit.Size = new System.Drawing.Size(480, 188);
            this.gelenMemoEdit.StyleController = this.layoutControl1;
            this.gelenMemoEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem3,
            this.layoutControlItem5,
            this.splitterItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(977, 592);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.trx3GridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(957, 337);
            this.layoutControlItem1.Text = "Traxon Communication";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gelenMemoEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 342);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(484, 208);
            this.layoutControlItem2.Text = "Gelen";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.Location = new System.Drawing.Point(0, 337);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(957, 5);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gidenMemoEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(489, 342);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(468, 208);
            this.layoutControlItem5.Text = "Giden";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(109, 13);
            // 
            // splitterItem4
            // 
            this.splitterItem4.AllowHotTrack = true;
            this.splitterItem4.Location = new System.Drawing.Point(484, 342);
            this.splitterItem4.Name = "splitterItem4";
            this.splitterItem4.Size = new System.Drawing.Size(5, 208);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.progressBarControl;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 550);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(957, 22);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // trX3_FHL4TableAdapter1
            // 
            this.trX3_FHL4TableAdapter1.ClearBeforeFill = true;
            // 
            // trX3_FWB16TableAdapter1
            // 
            this.trX3_FWB16TableAdapter1.ClearBeforeFill = true;
            // 
            // colUSR
            // 
            this.colUSR.Caption = "Usr";
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.Visible = true;
            this.colUSR.VisibleIndex = 7;
            this.colUSR.Width = 48;
            // 
            // colINSTS
            // 
            this.colINSTS.Caption = "InsTS";
            this.colINSTS.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colINSTS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colINSTS.FieldName = "INSTS";
            this.colINSTS.Name = "colINSTS";
            this.colINSTS.Visible = true;
            this.colINSTS.VisibleIndex = 8;
            this.colINSTS.Width = 91;
            // 
            // Trx2XF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 592);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Trx2XF";
            this.Text = "Trx2XF";
            this.Load += new System.EventHandler(this.Trx2XF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traxonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRX3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trx3GridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gidenMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelenMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TraxonDataSetTableAdapters.TraxonQueriesTableAdapter traxonQueriesTableAdapter;
        private TraxonDataSet traxonDataSet;
        private System.Windows.Forms.BindingSource tRX3BindingSource;
        private TraxonDataSetTableAdapters.TRX3TableAdapter tRX3TableAdapter;
        private DevExpress.XtraGrid.GridControl trx3GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colMSGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGELEN;
        private DevExpress.XtraGrid.Columns.GridColumn colGIDEN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit gelenMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraEditors.MemoEdit gidenMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SplitterItem splitterItem4;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colERR;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private TraxonDataSetTableAdapters.TRX3_FHL4TableAdapter trX3_FHL4TableAdapter1;
        private TraxonDataSetTableAdapters.TRX3_FWB16TableAdapter trX3_FWB16TableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem putToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colINSTS;
    }
}