namespace tMax14.Depo
{
    partial class depoQryKlnUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(depoQryKlnUC));
            this.depoDataSet = new tMax14.Depo.DepoDataSet();
            this.depoQryKlnTrhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoQryKlnTrhTableAdapter = new tMax14.Depo.DepoDataSetTableAdapters.DEPOQRY_KLN_TRHTableAdapter();
            this.tableAdapterManager = new tMax14.Depo.DepoDataSetTableAdapters.TableAdapterManager();
            this.depoQryKlnGridControl = new DevExpress.XtraGrid.GridControl();
            this.depoQryKlnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDPGID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIRFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNSGRDGR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGTPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.prmDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.trh2dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.trh1dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.depoQryKlnPrintableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnTrhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnGridView)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnPrintableComponentLink.ImageCollection)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // depoDataSet
            // 
            this.depoDataSet.DataSetName = "DepoDataSet";
            this.depoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoQryKlnTrhBindingSource
            // 
            this.depoQryKlnTrhBindingSource.DataMember = "DEPOQRY_KLN_TRH";
            this.depoQryKlnTrhBindingSource.DataSource = this.depoDataSet;
            // 
            // depoQryKlnTrhTableAdapter
            // 
            this.depoQryKlnTrhTableAdapter.ClearBeforeFill = true;
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
            // depoQryKlnGridControl
            // 
            this.depoQryKlnGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.depoQryKlnGridControl.DataSource = this.depoQryKlnTrhBindingSource;
            this.depoQryKlnGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depoQryKlnGridControl.Location = new System.Drawing.Point(19, 0);
            this.depoQryKlnGridControl.MainView = this.depoQryKlnGridView;
            this.depoQryKlnGridControl.Name = "depoQryKlnGridControl";
            this.depoQryKlnGridControl.Size = new System.Drawing.Size(800, 358);
            this.depoQryKlnGridControl.TabIndex = 2;
            this.depoQryKlnGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.depoQryKlnGridView});
            // 
            // depoQryKlnGridView
            // 
            this.depoQryKlnGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depoQryKlnGridView.Appearance.GroupRow.Options.UseFont = true;
            this.depoQryKlnGridView.Appearance.GroupRow.Options.UseTextOptions = true;
            this.depoQryKlnGridView.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.depoQryKlnGridView.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.White;
            this.depoQryKlnGridView.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depoQryKlnGridView.AppearancePrint.GroupFooter.Options.UseBackColor = true;
            this.depoQryKlnGridView.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.depoQryKlnGridView.AppearancePrint.GroupRow.BackColor = System.Drawing.Color.White;
            this.depoQryKlnGridView.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depoQryKlnGridView.AppearancePrint.GroupRow.Options.UseBackColor = true;
            this.depoQryKlnGridView.AppearancePrint.GroupRow.Options.UseFont = true;
            this.depoQryKlnGridView.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.depoQryKlnGridView.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.depoQryKlnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTRH,
            this.colDPGID,
            this.colGIRFRTID,
            this.colKLNMIK,
            this.colKLNSGRDGR,
            this.colGTPID,
            this.colTANIM});
            this.depoQryKlnGridView.GridControl = this.depoQryKlnGridControl;
            this.depoQryKlnGridView.GroupCount = 1;
            this.depoQryKlnGridView.GroupFormat = "{1} {2} Depo Mevcudu";
            this.depoQryKlnGridView.GroupRowHeight = 30;
            this.depoQryKlnGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNMIK", this.colKLNMIK, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KLNSGRDGR", this.colKLNSGRDGR, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TANIM", this.colTANIM, "{0:n0}")});
            this.depoQryKlnGridView.Name = "depoQryKlnGridView";
            this.depoQryKlnGridView.OptionsBehavior.ReadOnly = true;
            this.depoQryKlnGridView.OptionsPrint.PrintHorzLines = false;
            this.depoQryKlnGridView.OptionsPrint.PrintVertLines = false;
            this.depoQryKlnGridView.OptionsPrint.UsePrintStyles = false;
            this.depoQryKlnGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTRH, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.FixedWidth = true;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 0;
            // 
            // colDPGID
            // 
            this.colDPGID.Caption = "GirId";
            this.colDPGID.FieldName = "DPGID";
            this.colDPGID.Name = "colDPGID";
            // 
            // colGIRFRTID
            // 
            this.colGIRFRTID.Caption = "GirFirma";
            this.colGIRFRTID.FieldName = "GIRFRTID";
            this.colGIRFRTID.Name = "colGIRFRTID";
            this.colGIRFRTID.Visible = true;
            this.colGIRFRTID.VisibleIndex = 1;
            this.colGIRFRTID.Width = 150;
            // 
            // colKLNMIK
            // 
            this.colKLNMIK.Caption = "KlnMik";
            this.colKLNMIK.DisplayFormat.FormatString = "n0";
            this.colKLNMIK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLNMIK.FieldName = "KLNMIK";
            this.colKLNMIK.Name = "colKLNMIK";
            this.colKLNMIK.OptionsColumn.FixedWidth = true;
            this.colKLNMIK.Visible = true;
            this.colKLNMIK.VisibleIndex = 2;
            this.colKLNMIK.Width = 60;
            // 
            // colKLNSGRDGR
            // 
            this.colKLNSGRDGR.Caption = "KlnSgrDgr";
            this.colKLNSGRDGR.DisplayFormat.FormatString = "n2";
            this.colKLNSGRDGR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKLNSGRDGR.FieldName = "KLNSGRDGR";
            this.colKLNSGRDGR.Name = "colKLNSGRDGR";
            this.colKLNSGRDGR.OptionsColumn.FixedWidth = true;
            this.colKLNSGRDGR.Visible = true;
            this.colKLNSGRDGR.VisibleIndex = 3;
            // 
            // colGTPID
            // 
            this.colGTPID.Caption = "GTP";
            this.colGTPID.FieldName = "GTPID";
            this.colGTPID.Name = "colGTPID";
            this.colGTPID.Visible = true;
            this.colGTPID.VisibleIndex = 4;
            this.colGTPID.Width = 157;
            // 
            // colTANIM
            // 
            this.colTANIM.Caption = "Mal Tanımı";
            this.colTANIM.FieldName = "TANIM";
            this.colTANIM.Name = "colTANIM";
            this.colTANIM.Visible = true;
            this.colTANIM.VisibleIndex = 0;
            this.colTANIM.Width = 158;
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
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 358);
            // 
            // prmDockPanel
            // 
            this.prmDockPanel.Controls.Add(this.dockPanel1_Container);
            this.prmDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.prmDockPanel.ID = new System.Guid("5f21887e-798b-49ae-988e-b2fd3c3cee53");
            this.prmDockPanel.Location = new System.Drawing.Point(0, 0);
            this.prmDockPanel.Name = "prmDockPanel";
            this.prmDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.prmDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.prmDockPanel.SavedIndex = 0;
            this.prmDockPanel.Size = new System.Drawing.Size(200, 358);
            this.prmDockPanel.Text = "Parametreler";
            this.prmDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 331);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.trh2dateEdit);
            this.layoutControl1.Controls.Add(this.trh1dateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(192, 331);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(12, 60);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(168, 22);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 6;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
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
            this.trh2dateEdit.TabIndex = 5;
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
            this.trh1dateEdit.TabIndex = 4;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(192, 331);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.trh1dateEdit;
            this.layoutControlItem1.CustomizationFormText = "Trh >=";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(172, 24);
            this.layoutControlItem1.Text = "Trh >=";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trh2dateEdit;
            this.layoutControlItem2.CustomizationFormText = "Trh <";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(172, 24);
            this.layoutControlItem2.Text = "Trh <";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.OKsimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(172, 263);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // printingSystem
            // 
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Application = "tMax14";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Author = "Şener DEMİRAL";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Subject = "Depo Mevcudu";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Title = "Transorient Depo Mevcudu";
            this.printingSystem.Links.AddRange(new object[] {
            this.depoQryKlnPrintableComponentLink});
            // 
            // depoQryKlnPrintableComponentLink
            // 
            this.depoQryKlnPrintableComponentLink.Component = this.depoQryKlnGridControl;
            // 
            // 
            // 
            this.depoQryKlnPrintableComponentLink.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.depoQryKlnPrintableComponentLink.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            this.depoQryKlnPrintableComponentLink.Owner = null;
            this.depoQryKlnPrintableComponentLink.PageHeaderFooter = new DevExpress.XtraPrinting.PageHeaderFooter(new DevExpress.XtraPrinting.PageHeaderArea(new string[] {
                "Transorient Depo Mevcudu",
                "",
                "[Date Printed][Time Printed]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))), DevExpress.XtraPrinting.BrickAlignment.Near), new DevExpress.XtraPrinting.PageFooterArea(new string[] {
                "",
                "",
                "[Page # of Pages #]"}, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))), DevExpress.XtraPrinting.BrickAlignment.Near));
            this.depoQryKlnPrintableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.depoQryKlnPrintableComponentLink.PrintingSystem = this.printingSystem;
            this.depoQryKlnPrintableComponentLink.PrintingSystemBase = this.printingSystem;
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
            // depoQryKlnUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.depoQryKlnGridControl);
            this.Controls.Add(this.hideContainerLeft);
            this.Name = "depoQryKlnUC";
            this.Size = new System.Drawing.Size(819, 358);
            ((System.ComponentModel.ISupportInitialize)(this.depoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnTrhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnGridView)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.depoQryKlnPrintableComponentLink.ImageCollection)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DepoDataSet depoDataSet;
        private System.Windows.Forms.BindingSource depoQryKlnTrhBindingSource;
        private DepoDataSetTableAdapters.DEPOQRY_KLN_TRHTableAdapter depoQryKlnTrhTableAdapter;
        private DepoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl depoQryKlnGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView depoQryKlnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colDPGID;
        private DevExpress.XtraGrid.Columns.GridColumn colGIRFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNSGRDGR;
        private DevExpress.XtraGrid.Columns.GridColumn colGTPID;
        private DevExpress.XtraGrid.Columns.GridColumn colTANIM;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel prmDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraEditors.DateEdit trh2dateEdit;
        private DevExpress.XtraEditors.DateEdit trh1dateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink depoQryKlnPrintableComponentLink;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}
