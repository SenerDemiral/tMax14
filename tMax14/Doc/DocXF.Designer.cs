namespace tMax14.Doc
{
    partial class DocXF
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.docDataSet = new tMax14.Doc.DocDataSet();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docTableAdapter = new tMax14.Doc.DocDataSetTableAdapters.DOCTableAdapter();
            this.docGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteADMNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDOCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLBLEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBKMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALTTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINSUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBRS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPRVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.docQueriesTableAdapter = new tMax14.Doc.DocDataSetTableAdapters.DocQueriesTableAdapter();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.qsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.docDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.qsDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // docDataSet
            // 
            this.docDataSet.DataSetName = "DocDataSet";
            this.docDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docBindingSource
            // 
            this.docBindingSource.DataMember = "DOC";
            this.docBindingSource.DataSource = this.docDataSet;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // docGridControl
            // 
            this.docGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.docGridControl.DataSource = this.docBindingSource;
            this.docGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docGridControl.Location = new System.Drawing.Point(19, 0);
            this.docGridControl.MainView = this.docGridView;
            this.docGridControl.Name = "docGridControl";
            this.docGridControl.Size = new System.Drawing.Size(788, 258);
            this.docGridControl.TabIndex = 2;
            this.docGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.docGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToDesktopToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.deleteADMNToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(171, 136);
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.yeniToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bookmarkToolStripMenuItem.Text = "Bookmark";
            this.bookmarkToolStripMenuItem.Click += new System.EventHandler(this.bookmarkToolStripMenuItem_Click);
            // 
            // deleteADMNToolStripMenuItem
            // 
            this.deleteADMNToolStripMenuItem.Name = "deleteADMNToolStripMenuItem";
            this.deleteADMNToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.deleteADMNToolStripMenuItem.Text = "Delete (ADMN)";
            this.deleteADMNToolStripMenuItem.Click += new System.EventHandler(this.deleteADMNToolStripMenuItem_Click);
            // 
            // saveToDesktopToolStripMenuItem
            // 
            this.saveToDesktopToolStripMenuItem.Name = "saveToDesktopToolStripMenuItem";
            this.saveToDesktopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.saveToDesktopToolStripMenuItem.Text = "Save to Desktop";
            this.saveToDesktopToolStripMenuItem.Click += new System.EventHandler(this.saveToDesktopToolStripMenuItem_Click);
            // 
            // docGridView
            // 
            this.docGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOCID,
            this.colREFTBL,
            this.colREFID,
            this.colAD,
            this.colTYP,
            this.colEXD,
            this.colBLBLEN,
            this.colTAGS,
            this.colBKMS,
            this.colDET,
            this.colALTTBL,
            this.colALTID,
            this.colINSUSR,
            this.colMBRS,
            this.colPRVT});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Coral;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            this.docGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.docGridView.GridControl = this.docGridControl;
            this.docGridView.Name = "docGridView";
            this.docGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.docGridView.OptionsView.ShowFooter = true;
            this.docGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.docGridView_ShowingEditor);
            this.docGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.docGridView_InitNewRow);
            this.docGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.docGridView_FocusedRowChanged);
            this.docGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.docGridView_ValidateRow);
            // 
            // colDOCID
            // 
            this.colDOCID.Caption = "DocID";
            this.colDOCID.DisplayFormat.FormatString = "n0";
            this.colDOCID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDOCID.FieldName = "DOCID";
            this.colDOCID.Name = "colDOCID";
            this.colDOCID.OptionsColumn.AllowEdit = false;
            this.colDOCID.OptionsColumn.AllowFocus = false;
            this.colDOCID.OptionsColumn.FixedWidth = true;
            this.colDOCID.Visible = true;
            this.colDOCID.VisibleIndex = 0;
            this.colDOCID.Width = 60;
            // 
            // colREFTBL
            // 
            this.colREFTBL.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFTBL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTBL.Caption = "RefTbl";
            this.colREFTBL.FieldName = "REFTBL";
            this.colREFTBL.Name = "colREFTBL";
            this.colREFTBL.OptionsColumn.AllowEdit = false;
            this.colREFTBL.OptionsColumn.AllowFocus = false;
            this.colREFTBL.OptionsColumn.FixedWidth = true;
            this.colREFTBL.Visible = true;
            this.colREFTBL.VisibleIndex = 7;
            this.colREFTBL.Width = 40;
            // 
            // colREFID
            // 
            this.colREFID.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFID.Caption = "RefID";
            this.colREFID.DisplayFormat.FormatString = "#";
            this.colREFID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.AllowEdit = false;
            this.colREFID.OptionsColumn.AllowFocus = false;
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 8;
            this.colREFID.Width = 50;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 79;
            // 
            // colTYP
            // 
            this.colTYP.AppearanceCell.Options.UseTextOptions = true;
            this.colTYP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTYP.AppearanceHeader.Options.UseTextOptions = true;
            this.colTYP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTYP.Caption = "Type";
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.AllowEdit = false;
            this.colTYP.OptionsColumn.AllowFocus = false;
            this.colTYP.OptionsColumn.FixedWidth = true;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 4;
            this.colTYP.Width = 53;
            // 
            // colEXD
            // 
            this.colEXD.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.AllowEdit = false;
            this.colEXD.OptionsColumn.AllowFocus = false;
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 3;
            this.colEXD.Width = 65;
            // 
            // colBLBLEN
            // 
            this.colBLBLEN.AppearanceHeader.Options.UseTextOptions = true;
            this.colBLBLEN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBLBLEN.Caption = "Size";
            this.colBLBLEN.DisplayFormat.FormatString = "n0";
            this.colBLBLEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLBLEN.FieldName = "BLBLEN";
            this.colBLBLEN.Name = "colBLBLEN";
            this.colBLBLEN.OptionsColumn.AllowEdit = false;
            this.colBLBLEN.OptionsColumn.AllowFocus = false;
            this.colBLBLEN.OptionsColumn.FixedWidth = true;
            this.colBLBLEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BLBLEN", "{0:n0}")});
            this.colBLBLEN.Visible = true;
            this.colBLBLEN.VisibleIndex = 5;
            this.colBLBLEN.Width = 60;
            // 
            // colTAGS
            // 
            this.colTAGS.Caption = "TAGs";
            this.colTAGS.FieldName = "TAGS";
            this.colTAGS.Name = "colTAGS";
            this.colTAGS.OptionsColumn.FixedWidth = true;
            this.colTAGS.Visible = true;
            this.colTAGS.VisibleIndex = 6;
            this.colTAGS.Width = 96;
            // 
            // colBKMS
            // 
            this.colBKMS.Caption = "BKMs";
            this.colBKMS.FieldName = "BKMS";
            this.colBKMS.Name = "colBKMS";
            this.colBKMS.OptionsColumn.AllowEdit = false;
            this.colBKMS.OptionsColumn.AllowFocus = false;
            this.colBKMS.OptionsColumn.FixedWidth = true;
            this.colBKMS.Width = 120;
            // 
            // colDET
            // 
            this.colDET.Caption = "DışEvrakTürü";
            this.colDET.FieldName = "DET";
            this.colDET.Name = "colDET";
            this.colDET.ToolTip = "Dış Evrak Türü";
            this.colDET.Visible = true;
            this.colDET.VisibleIndex = 2;
            this.colDET.Width = 35;
            // 
            // colALTTBL
            // 
            this.colALTTBL.AppearanceHeader.Options.UseTextOptions = true;
            this.colALTTBL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colALTTBL.Caption = "AltTbl";
            this.colALTTBL.FieldName = "ALTTBL";
            this.colALTTBL.Name = "colALTTBL";
            this.colALTTBL.OptionsColumn.AllowEdit = false;
            this.colALTTBL.OptionsColumn.AllowFocus = false;
            this.colALTTBL.OptionsColumn.FixedWidth = true;
            this.colALTTBL.Visible = true;
            this.colALTTBL.VisibleIndex = 9;
            this.colALTTBL.Width = 40;
            // 
            // colALTID
            // 
            this.colALTID.AppearanceHeader.Options.UseTextOptions = true;
            this.colALTID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colALTID.Caption = "AltID";
            this.colALTID.FieldName = "ALTID";
            this.colALTID.Name = "colALTID";
            this.colALTID.OptionsColumn.AllowEdit = false;
            this.colALTID.OptionsColumn.AllowFocus = false;
            this.colALTID.OptionsColumn.FixedWidth = true;
            this.colALTID.Visible = true;
            this.colALTID.VisibleIndex = 10;
            this.colALTID.Width = 50;
            // 
            // colINSUSR
            // 
            this.colINSUSR.Caption = "InsUsr";
            this.colINSUSR.FieldName = "INSUSR";
            this.colINSUSR.Name = "colINSUSR";
            this.colINSUSR.OptionsColumn.AllowEdit = false;
            this.colINSUSR.OptionsColumn.AllowFocus = false;
            this.colINSUSR.Visible = true;
            this.colINSUSR.VisibleIndex = 11;
            this.colINSUSR.Width = 45;
            // 
            // colMBRS
            // 
            this.colMBRS.Caption = "Members";
            this.colMBRS.FieldName = "MBRS";
            this.colMBRS.Name = "colMBRS";
            this.colMBRS.Visible = true;
            this.colMBRS.VisibleIndex = 12;
            this.colMBRS.Width = 45;
            // 
            // colPRVT
            // 
            this.colPRVT.Caption = "Prvt";
            this.colPRVT.FieldName = "PRVT";
            this.colPRVT.Name = "colPRVT";
            this.colPRVT.Visible = true;
            this.colPRVT.VisibleIndex = 13;
            this.colPRVT.Width = 52;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.AutoHideSpeed = 5;
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.qsDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 258);
            // 
            // qsDockPanel
            // 
            this.qsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.qsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.ID = new System.Guid("9366d2b6-274c-414a-bcb6-3a317169020e");
            this.qsDockPanel.Location = new System.Drawing.Point(0, 0);
            this.qsDockPanel.Name = "qsDockPanel";
            this.qsDockPanel.OriginalSize = new System.Drawing.Size(236, 200);
            this.qsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.qsDockPanel.SavedIndex = 0;
            this.qsDockPanel.Size = new System.Drawing.Size(236, 258);
            this.qsDockPanel.Text = "Quick Search";
            this.qsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(228, 231);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // DocXF
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 258);
            this.Controls.Add(this.docGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "DocXF";
            this.Text = "DocXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocXF_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DocXF_FormClosed);
            this.Load += new System.EventHandler(this.DocXF_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DocXF_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DocXF_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.docDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.qsDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DocDataSet docDataSet;
        private System.Windows.Forms.BindingSource docBindingSource;
        private DocDataSetTableAdapters.DOCTableAdapter docTableAdapter;
        private DevExpress.XtraGrid.GridControl docGridControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Grid.GridView docGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colBLBLEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTAGS;
        private DevExpress.XtraGrid.Columns.GridColumn colBKMS;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DocDataSetTableAdapters.DocQueriesTableAdapter docQueriesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel qsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.Columns.GridColumn colDET;
        private DevExpress.XtraGrid.Columns.GridColumn colALTTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colALTID;
        private DevExpress.XtraGrid.Columns.GridColumn colINSUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colMBRS;
        private DevExpress.XtraGrid.Columns.GridColumn colPRVT;
        private System.Windows.Forms.ToolStripMenuItem deleteADMNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToDesktopToolStripMenuItem;
    }
}