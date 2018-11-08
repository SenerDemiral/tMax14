namespace tMax14.Docs
{
    partial class docForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docForm));
            this.docTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTYP = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEXD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBLBLEN = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDOCID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPRID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colBKM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFLG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.addRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadModifiedCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docsDataSet = new tMax14.Docs.DocsDataSet();
            this.docTableAdapter = new tMax14.Docs.DocsDataSetTableAdapters.DOCTableAdapter();
            this.docsQueriesTableAdapter = new tMax14.Docs.DocsDataSetTableAdapters.DocsQueriesTableAdapter();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.statusBar = new DevExpress.XtraBars.Bar();
            this.searchTAGbarEditItem = new DevExpress.XtraBars.BarEditItem();
            this.searchTAGrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bookmarkedBarCheckItem = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sharedImageCollection = new DevExpress.Utils.SharedImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.docTreeList)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTAGrepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).BeginInit();
            this.SuspendLayout();
            // 
            // docTreeList
            // 
            this.docTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNAME,
            this.colTYP,
            this.colEXD,
            this.colTAG,
            this.colBLBLEN,
            this.colDOCID,
            this.colPRID,
            this.colBKM,
            this.colFLG});
            this.docTreeList.ContextMenuStrip = this.contextMenuStrip;
            this.docTreeList.DataSource = this.docBindingSource;
            this.docTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docTreeList.KeyFieldName = "DOCID";
            this.docTreeList.Location = new System.Drawing.Point(0, 0);
            this.docTreeList.Name = "docTreeList";
            this.docTreeList.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.docTreeList.OptionsView.ShowCheckBoxes = true;
            this.docTreeList.ParentFieldName = "PRID";
            this.docTreeList.RootValue = null;
            this.docTreeList.Size = new System.Drawing.Size(701, 261);
            this.docTreeList.TabIndex = 0;
            this.docTreeList.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.docTreeList_NodeCellStyle);
            this.docTreeList.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.docTreeList_BeforeCheckNode);
            this.docTreeList.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.docTreeList_AfterCheckNode);
            this.docTreeList.StateChanged += new System.EventHandler(this.docTreeList_StateChanged);
            this.docTreeList.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.docTreeList_ShowingEditor);
            this.docTreeList.DragDrop += new System.Windows.Forms.DragEventHandler(this.docTreeList_DragDrop);
            this.docTreeList.DragEnter += new System.Windows.Forms.DragEventHandler(this.docTreeList_DragEnter);
            this.docTreeList.DragOver += new System.Windows.Forms.DragEventHandler(this.docTreeList_DragOver);
            this.docTreeList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.docTreeList_MouseDown);
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Name";
            this.colNAME.FieldName = "NAME";
            this.colNAME.MinWidth = 32;
            this.colNAME.Name = "colNAME";
            this.colNAME.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            this.colNAME.Width = 353;
            // 
            // colTYP
            // 
            this.colTYP.Caption = "Typ";
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.AllowEdit = false;
            this.colTYP.OptionsColumn.AllowFocus = false;
            this.colTYP.OptionsColumn.FixedWidth = true;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 2;
            this.colTYP.Width = 55;
            // 
            // colEXD
            // 
            this.colEXD.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXD.Caption = "Date";
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.OptionsColumn.AllowEdit = false;
            this.colEXD.OptionsColumn.AllowFocus = false;
            this.colEXD.OptionsColumn.FixedWidth = true;
            this.colEXD.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 3;
            this.colEXD.Width = 110;
            // 
            // colTAG
            // 
            this.colTAG.Caption = "TAGs";
            this.colTAG.FieldName = "TAG";
            this.colTAG.Name = "colTAG";
            this.colTAG.Visible = true;
            this.colTAG.VisibleIndex = 1;
            this.colTAG.Width = 85;
            // 
            // colBLBLEN
            // 
            this.colBLBLEN.AllNodesSummary = true;
            this.colBLBLEN.Caption = "Size (Byte)";
            this.colBLBLEN.FieldName = "BLBLEN";
            this.colBLBLEN.Format.FormatString = "n0";
            this.colBLBLEN.Format.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBLBLEN.Name = "colBLBLEN";
            this.colBLBLEN.OptionsColumn.AllowEdit = false;
            this.colBLBLEN.OptionsColumn.AllowFocus = false;
            this.colBLBLEN.OptionsColumn.FixedWidth = true;
            this.colBLBLEN.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.colBLBLEN.SummaryFooterStrFormat = "{0:n0}";
            this.colBLBLEN.Visible = true;
            this.colBLBLEN.VisibleIndex = 4;
            this.colBLBLEN.Width = 80;
            // 
            // colDOCID
            // 
            this.colDOCID.FieldName = "DOCID";
            this.colDOCID.Name = "colDOCID";
            // 
            // colPRID
            // 
            this.colPRID.FieldName = "PRID";
            this.colPRID.Name = "colPRID";
            // 
            // colBKM
            // 
            this.colBKM.FieldName = "BKM";
            this.colBKM.Name = "colBKM";
            this.colBKM.OptionsColumn.AllowEdit = false;
            this.colBKM.OptionsColumn.AllowFocus = false;
            // 
            // colFLG
            // 
            this.colFLG.FieldName = "FLG";
            this.colFLG.Name = "colFLG";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator4,
            this.addRootToolStripMenuItem,
            this.addChildToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.uploadToolStripMenuItem,
            this.uploadModifiedCopyToolStripMenuItem,
            this.toolStripSeparator2,
            this.findToolStripMenuItem,
            this.toolStripSeparator3,
            this.expandAllToolStripMenuItem,
            this.expandChildToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(179, 248);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(175, 6);
            // 
            // addRootToolStripMenuItem
            // 
            this.addRootToolStripMenuItem.Name = "addRootToolStripMenuItem";
            this.addRootToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.addRootToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addRootToolStripMenuItem.Text = "Add Root";
            this.addRootToolStripMenuItem.Click += new System.EventHandler(this.addRootToolStripMenuItem_Click);
            // 
            // addChildToolStripMenuItem
            // 
            this.addChildToolStripMenuItem.Name = "addChildToolStripMenuItem";
            this.addChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Insert)));
            this.addChildToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addChildToolStripMenuItem.Text = "Add Child";
            this.addChildToolStripMenuItem.Click += new System.EventHandler(this.addChildToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // uploadModifiedCopyToolStripMenuItem
            // 
            this.uploadModifiedCopyToolStripMenuItem.Name = "uploadModifiedCopyToolStripMenuItem";
            this.uploadModifiedCopyToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.uploadModifiedCopyToolStripMenuItem.Text = "Upload Modified Copy";
            this.uploadModifiedCopyToolStripMenuItem.Click += new System.EventHandler(this.uploadModifiedCopyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // expandChildToolStripMenuItem
            // 
            this.expandChildToolStripMenuItem.Name = "expandChildToolStripMenuItem";
            this.expandChildToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.expandChildToolStripMenuItem.Text = "Expand Child";
            this.expandChildToolStripMenuItem.Click += new System.EventHandler(this.expandChildToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // docBindingSource
            // 
            this.docBindingSource.DataMember = "DOC";
            this.docBindingSource.DataSource = this.docsDataSet;
            // 
            // docsDataSet
            // 
            this.docsDataSet.DataSetName = "DocsDataSet";
            this.docsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.statusBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.sharedImageCollection;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.searchTAGbarEditItem,
            this.bookmarkedBarCheckItem});
            this.barManager.MaxItemId = 8;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.searchTAGrepositoryItemTextEdit});
            this.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize;
            this.barManager.StatusBar = this.statusBar;
            // 
            // statusBar
            // 
            this.statusBar.BarName = "Status bar";
            this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.statusBar.DockCol = 0;
            this.statusBar.DockRow = 0;
            this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.statusBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.searchTAGbarEditItem, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.bookmarkedBarCheckItem)});
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.UseWholeRow = true;
            this.statusBar.Text = "Status bar";
            // 
            // searchTAGbarEditItem
            // 
            this.searchTAGbarEditItem.AutoFillWidth = true;
            this.searchTAGbarEditItem.Caption = "search TAG";
            this.searchTAGbarEditItem.Edit = this.searchTAGrepositoryItemTextEdit;
            this.searchTAGbarEditItem.Hint = "Aramak istediğiniz Kelimeleri girin";
            this.searchTAGbarEditItem.Id = 0;
            this.searchTAGbarEditItem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTAGbarEditItem.ItemAppearance.Normal.Options.UseFont = true;
            this.searchTAGbarEditItem.Name = "searchTAGbarEditItem";
            this.searchTAGbarEditItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.searchTAGbarEditItem.Width = 163;
            // 
            // searchTAGrepositoryItemTextEdit
            // 
            this.searchTAGrepositoryItemTextEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTAGrepositoryItemTextEdit.Appearance.Options.UseFont = true;
            this.searchTAGrepositoryItemTextEdit.AutoHeight = false;
            this.searchTAGrepositoryItemTextEdit.Mask.EditMask = "(<(\\-?[0-9A-Z]+)+>)+";
            this.searchTAGrepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.searchTAGrepositoryItemTextEdit.Name = "searchTAGrepositoryItemTextEdit";
            this.searchTAGrepositoryItemTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTAGrepositoryItemTextEdit_KeyDown);
            // 
            // bookmarkedBarCheckItem
            // 
            this.bookmarkedBarCheckItem.Caption = " All ";
            this.bookmarkedBarCheckItem.Id = 6;
            this.bookmarkedBarCheckItem.Name = "bookmarkedBarCheckItem";
            this.bookmarkedBarCheckItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            this.bookmarkedBarCheckItem.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bookmarkedBarCheckItem_CheckedChanged);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(701, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 261);
            this.barDockControlBottom.Size = new System.Drawing.Size(701, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 261);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(701, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 261);
            // 
            // sharedImageCollection
            // 
            // 
            // 
            // 
            this.sharedImageCollection.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollection.ImageSource.ImageStream")));
            this.sharedImageCollection.ImageSource.Images.SetKeyName(0, "button-blue.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(1, "button-green.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(2, "button-purple.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(3, "button-red.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(4, "button-seagreen.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(5, "button-yellow.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(6, "circle_blue.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(7, "circle_green.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(8, "circle_grey.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(9, "circle_orange.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(10, "circle_purple.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(11, "circle_red.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(12, "circle_tan.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(13, "circle_yellow.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(14, "bullet-green.png");
            this.sharedImageCollection.ParentControl = this;
            // 
            // docForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.docTreeList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "docForm";
            this.Size = new System.Drawing.Size(701, 286);
            this.Load += new System.EventHandler(this.docForm_Load);
            this.Leave += new System.EventHandler(this.docForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.docTreeList)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTAGrepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList docTreeList;
        private System.Windows.Forms.BindingSource docBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTYP;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEXD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTAG;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBLBLEN;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDOCID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPRID;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addRootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadModifiedCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar statusBar;
        private DevExpress.XtraBars.BarEditItem searchTAGbarEditItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit searchTAGrepositoryItemTextEdit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private tMax14.Docs.DocsDataSet docsDataSet;
        private tMax14.Docs.DocsDataSetTableAdapters.DOCTableAdapter docTableAdapter;
        private tMax14.Docs.DocsDataSetTableAdapters.DocsQueriesTableAdapter docsQueriesTableAdapter;
        private DevExpress.XtraBars.BarCheckItem bookmarkedBarCheckItem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colBKM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFLG;
        private DevExpress.Utils.SharedImageCollection sharedImageCollection;
    }
}