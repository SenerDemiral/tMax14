namespace tMax14.Depo
{
    partial class depoQryHrkUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depoQryHrkUC));
            this.depoDataSet = new tMax14.Depo.DepoDataSet();
            this.depoQryHrkTrhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoQryHrkTrhTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DEPOQRY_HRK_TRHTableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.depoQryHrkGridControl = new DevExpress.XtraGrid.GridControl();
            this.depoQryHrkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDPGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGTPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRSGRDGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNSGRDGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.prmDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.trh2dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.trh1dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.depoQryHrkPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkTrhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.prmDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trh2dateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh2dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh1dateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh1dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkPrintableComponentLink.ImageCollection)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoQryHrkTrhBindingSource
            // 
            this.depoQryHrkTrhBindingSource.DataMember = "DEPOQRY_HRK_TRH";
            this.depoQryHrkTrhBindingSource.DataSource = this.depoDataSet;
            // 
            // depoQryHrkTrhTableAdapter
            // 
            this.depoQryHrkTrhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DPCATableAdapter = null;
            this.tableAdapterManager.DPGATableAdapter = null;
            this.tableAdapterManager.GTPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // depoQryHrkGridControl
            // 
            this.depoQryHrkGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.depoQryHrkGridControl.DataSource = this.depoQryHrkTrhBindingSource;
            this.depoQryHrkGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depoQryHrkGridControl.Location = new System.Drawing.Point(19, 0);
            this.depoQryHrkGridControl.MainView = this.depoQryHrkGridView;
            this.depoQryHrkGridControl.Name = "depoQryHrkGridControl";
            this.depoQryHrkGridControl.Size = new System.Drawing.Size(786, 482);
            this.depoQryHrkGridControl.TabIndex = 2;
            this.depoQryHrkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.depoQryHrkGridView});
            // 
            // depoQryHrkGridView
            // 
            this.depoQryHrkGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depoQryHrkGridView.Appearance.GroupRow.Options.UseFont = true;
            this.depoQryHrkGridView.Appearance.GroupRow.Options.UseTextOptions = true;
            this.depoQryHrkGridView.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.depoQryHrkGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRH,
            this.colDPGID,
            this.colTANIM,
            this.colGIRFRTID,
            this.colGTPID,
            this.colGIRMIK,
            this.colCIKMIK,
            this.colKLNMIK,
            this.colGIRSGRDGR,
            this.colKLNSGRDGR});
            this.depoQryHrkGridView.GridControl = this.depoQryHrkGridControl;
            this.depoQryHrkGridView.GroupCount = 1;
            this.depoQryHrkGridView.GroupFormat = "{1} {2} Depo Hareketleri";
            this.depoQryHrkGridView.GroupRowHeight = 30;
            this.depoQryHrkGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIRMIK", this.colGIRMIK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIKMIK", this.colCIKMIK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TANIM", this.colTANIM, "{0:n0}")});
            this.depoQryHrkGridView.Name = "depoQryHrkGridView";
            this.depoQryHrkGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.depoQryHrkGridView.OptionsBehavior.ReadOnly = true;
            this.depoQryHrkGridView.OptionsPrint.PrintHorzLines = false;
            this.depoQryHrkGridView.OptionsPrint.PrintVertLines = false;
            this.depoQryHrkGridView.OptionsPrint.UsePrintStyles = false;
            this.depoQryHrkGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRH, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.GroupFormat.FormatString = "dd MMM yyyy";
            this.colTRH.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 0;
            this.colTRH.Width = 64;
            // 
            // colDPGID
            // 
            this.colDPGID.FieldName = "DPGID";
            this.colDPGID.Name = "colDPGID";
            this.colDPGID.OptionsColumn.FixedWidth = true;
            this.colDPGID.Width = 60;
            // 
            // colTANIM
            // 
            this.colTANIM.Caption = "Mal Tanımı";
            this.colTANIM.FieldName = "TANIM";
            this.colTANIM.Name = "colTANIM";
            this.colTANIM.Visible = true;
            this.colTANIM.VisibleIndex = 0;
            this.colTANIM.Width = 140;
            // 
            // colGIRFRTID
            // 
            this.colGIRFRTID.Caption = "GirFirma";
            this.colGIRFRTID.FieldName = "GIRFRTID";
            this.colGIRFRTID.Name = "colGIRFRTID";
            this.colGIRFRTID.Visible = true;
            this.colGIRFRTID.VisibleIndex = 1;
            this.colGIRFRTID.Width = 140;
            // 
            // colGTPID
            // 
            this.colGTPID.Caption = "GTP";
            this.colGTPID.FieldName = "GTPID";
            this.colGTPID.Name = "colGTPID";
            this.colGTPID.Visible = true;
            this.colGTPID.VisibleIndex = 2;
            this.colGTPID.Width = 140;
            // 
            // colGIRMIK
            // 
            this.colGIRMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colGIRMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGIRMIK.Caption = "GirMik";
            this.colGIRMIK.DisplayFormat.FormatString = "n0";
            this.colGIRMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIRMIK.FieldName = "GIRMIK";
            this.colGIRMIK.Name = "colGIRMIK";
            this.colGIRMIK.Visible = true;
            this.colGIRMIK.VisibleIndex = 3;
            this.colGIRMIK.Width = 60;
            // 
            // colCIKMIK
            // 
            this.colCIKMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colCIKMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCIKMIK.Caption = "ÇıkMik";
            this.colCIKMIK.DisplayFormat.FormatString = "n0";
            this.colCIKMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCIKMIK.FieldName = "CIKMIK";
            this.colCIKMIK.Name = "colCIKMIK";
            this.colCIKMIK.Visible = true;
            this.colCIKMIK.VisibleIndex = 4;
            this.colCIKMIK.Width = 60;
            // 
            // colKLNMIK
            // 
            this.colKLNMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colKLNMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKLNMIK.Caption = "KlnMik";
            this.colKLNMIK.DisplayFormat.FormatString = "n0";
            this.colKLNMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLNMIK.FieldName = "KLNMIK";
            this.colKLNMIK.Name = "colKLNMIK";
            this.colKLNMIK.ToolTip = "Bu Tarihte Kalan miktarı";
            this.colKLNMIK.Visible = true;
            this.colKLNMIK.VisibleIndex = 5;
            this.colKLNMIK.Width = 60;
            // 
            // colGIRSGRDGR
            // 
            this.colGIRSGRDGR.Caption = "GirSgrDğr";
            this.colGIRSGRDGR.DisplayFormat.FormatString = "n2";
            this.colGIRSGRDGR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIRSGRDGR.FieldName = "GIRSGRDGR";
            this.colGIRSGRDGR.Name = "colGIRSGRDGR";
            this.colGIRSGRDGR.Width = 78;
            // 
            // colKLNSGRDGR
            // 
            this.colKLNSGRDGR.Caption = "KlnSgrDğr";
            this.colKLNSGRDGR.DisplayFormat.FormatString = "n2";
            this.colKLNSGRDGR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLNSGRDGR.FieldName = "KLNSGRDGR";
            this.colKLNSGRDGR.Name = "colKLNSGRDGR";
            this.colKLNSGRDGR.Width = 98;
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
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
            this.hideContainerLeft.Controls.Add(this.prmDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 482);
            // 
            // prmDockPanel
            // 
            this.prmDockPanel.Controls.Add(this.dockPanel1_Container);
            this.prmDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.prmDockPanel.ID = new System.Guid("cfa69179-1d9c-4f22-b335-ce34f815110f");
            this.prmDockPanel.Location = new System.Drawing.Point(0, 0);
            this.prmDockPanel.Name = "prmDockPanel";
            this.prmDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.prmDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.prmDockPanel.SavedIndex = 0;
            this.prmDockPanel.Size = new System.Drawing.Size(200, 482);
            this.prmDockPanel.Text = "Parametreler";
            this.prmDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 455);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.trh2dateEdit);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.trh1dateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(192, 455);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // trh2dateEdit
            // 
            this.trh2dateEdit.EditValue = null;
            this.trh2dateEdit.Location = new System.Drawing.Point(50, 36);
            this.trh2dateEdit.Name = "trh2dateEdit";
            this.trh2dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trh2dateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.trh2dateEdit.Size = new System.Drawing.Size(130, 20);
            this.trh2dateEdit.StyleController = this.layoutControl1;
            this.trh2dateEdit.TabIndex = 6;
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(12, 60);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(168, 22);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 4;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // trh1dateEdit
            // 
            this.trh1dateEdit.EditValue = null;
            this.trh1dateEdit.Location = new System.Drawing.Point(50, 12);
            this.trh1dateEdit.Name = "trh1dateEdit";
            this.trh1dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trh1dateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.trh1dateEdit.Size = new System.Drawing.Size(130, 20);
            this.trh1dateEdit.StyleController = this.layoutControl1;
            this.trh1dateEdit.TabIndex = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(192, 455);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.OKsimpleButton;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(172, 387);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trh1dateEdit;
            this.layoutControlItem2.CustomizationFormText = "Trh >=";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(172, 24);
            this.layoutControlItem2.Text = "Trh >=";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.trh2dateEdit;
            this.layoutControlItem3.CustomizationFormText = "Trh <";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(172, 24);
            this.layoutControlItem3.Text = "Trh <";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(35, 13);
            // 
            // printingSystem
            // 
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Application = "tMax14";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Author = "Şener DEMİRAL";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Subject = "Depo Hareketleri";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Title = "Transorient Depo Hareketleri";
            this.printingSystem.Links.AddRange(new object[] {
            this.depoQryHrkPrintableComponentLink});
            // 
            // depoQryHrkPrintableComponentLink
            // 
            this.depoQryHrkPrintableComponentLink.Component = this.depoQryHrkGridControl;
            // 
            // 
            // 
            this.depoQryHrkPrintableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.depoQryHrkPrintableComponentLink.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.depoQryHrkPrintableComponentLink.Owner = null;
            this.depoQryHrkPrintableComponentLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "Transorient Depo Hareketleri",
                "",
                "[Date Printed][Time Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "",
                "[Page # of Pages #]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.depoQryHrkPrintableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.depoQryHrkPrintableComponentLink.PrintingSystem = this.printingSystem;
            this.depoQryHrkPrintableComponentLink.PrintingSystemBase = this.printingSystem;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(135, 26);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // depoQryHrkUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.depoQryHrkGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "depoQryHrkUC";
            this.Size = new System.Drawing.Size(805, 482);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkTrhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.prmDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trh2dateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh2dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh1dateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trh1dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryHrkPrintableComponentLink.ImageCollection)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource depoQryHrkTrhBindingSource;
        private DepoDataSetTableAdapters.DEPOQRY_HRK_TRHTableAdapter depoQryHrkTrhTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl depoQryHrkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView depoQryHrkGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colDPGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRSGRDGR;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNSGRDGR;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraEditors.DateEdit trh2dateEdit;
        private DevExpress.XtraEditors.DateEdit trh1dateEdit;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraBars.Docking.DockPanel prmDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colGTPID;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink depoQryHrkPrintableComponentLink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}
