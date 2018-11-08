namespace tMax14.Ops
{
    partial class opContainerLoadingXF
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
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.opmclBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opmclTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OPM_CNTR_LOADTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.opmclGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmclGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMOPPINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOPPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOPPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOPPINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDLVADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHMNF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHPCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOPCID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmclBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmclGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmclGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opmclBindingSource
            // 
            this.opmclBindingSource.DataMember = "OPM_CNTR_LOAD";
            this.opmclBindingSource.DataSource = this.opsDataSet;
            // 
            // opmclTableAdapter
            // 
            this.opmclTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OPCTableAdapter = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = this.opmclTableAdapter;
            this.tableAdapterManager.OPM_SELTableAdapter = null;
            this.tableAdapterManager.OPM2TableAdapter = null;
            this.tableAdapterManager.OPMATableAdapter = null;
            this.tableAdapterManager.OPMCTableAdapter = null;
            this.tableAdapterManager.OPMITableAdapter = null;
            this.tableAdapterManager.OPMTableAdapter = null;
            this.tableAdapterManager.OPOSTableAdapter = null;
            this.tableAdapterManager.OPOTableAdapter = null;
            this.tableAdapterManager.OPP_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPPTableAdapter = null;
            this.tableAdapterManager.OPRH_SEL_DISTableAdapter = null;
            this.tableAdapterManager.PRSTableAdapter = null;
            this.tableAdapterManager.PRTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // opmclGridControl
            // 
            this.opmclGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.opmclGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.opmclGridControl.DataSource = this.opmclBindingSource;
            this.opmclGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opmclGridControl.Location = new System.Drawing.Point(0, 0);
            this.opmclGridControl.MainView = this.opmclGridView;
            this.opmclGridControl.Name = "opmclGridControl";
            this.opmclGridControl.Size = new System.Drawing.Size(980, 291);
            this.opmclGridControl.TabIndex = 2;
            this.opmclGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opmclGridView});
            this.opmclGridControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.opmclGridControl_DragDrop);
            this.opmclGridControl.DragOver += new System.Windows.Forms.DragEventHandler(this.opmclGridControl_DragOver);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(109, 26);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // opmclGridView
            // 
            this.opmclGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMOPPINF,
            this.colMOPPID,
            this.colHOPPID,
            this.colHOPPINF,
            this.colOPHID,
            this.colHTOP,
            this.colHNOP,
            this.colHGRW,
            this.colHVM3,
            this.colIDX,
            this.colHOPCID,
            this.colHDLVADR,
            this.colHCNE,
            this.colHMNF,
            this.colHSHP,
            this.colHPCS,
            this.colHDST});
            this.opmclGridView.GridControl = this.opmclGridControl;
            this.opmclGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HNOP", this.colHNOP, "{0:n0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HGRW", this.colHGRW, "{0:n1}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HVM3", this.colHVM3, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HPCS", this.colHPCS, "{0:n0}")});
            this.opmclGridView.Name = "opmclGridView";
            this.opmclGridView.OptionsBehavior.Editable = false;
            this.opmclGridView.OptionsView.ShowFooter = true;
            this.opmclGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.opmclGridView_CustomDrawGroupRow);
            this.opmclGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.opmclGridView_MouseDown);
            this.opmclGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.opmclGridView_MouseMove);
            // 
            // colMOPPINF
            // 
            this.colMOPPINF.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOPPINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOPPINF.Caption = "mPckInfo";
            this.colMOPPINF.FieldName = "MOPPINF";
            this.colMOPPINF.Name = "colMOPPINF";
            this.colMOPPINF.OptionsColumn.AllowEdit = false;
            this.colMOPPINF.OptionsColumn.AllowFocus = false;
            this.colMOPPINF.Visible = true;
            this.colMOPPINF.VisibleIndex = 0;
            this.colMOPPINF.Width = 50;
            // 
            // colMOPPID
            // 
            this.colMOPPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOPPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOPPID.Caption = "mPckId";
            this.colMOPPID.DisplayFormat.FormatString = "n0";
            this.colMOPPID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMOPPID.FieldName = "MOPPID";
            this.colMOPPID.Name = "colMOPPID";
            this.colMOPPID.OptionsColumn.AllowEdit = false;
            this.colMOPPID.OptionsColumn.AllowFocus = false;
            this.colMOPPID.OptionsColumn.FixedWidth = true;
            this.colMOPPID.Visible = true;
            this.colMOPPID.VisibleIndex = 1;
            this.colMOPPID.Width = 60;
            // 
            // colHOPPID
            // 
            this.colHOPPID.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOPPID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOPPID.Caption = "hPckId";
            this.colHOPPID.DisplayFormat.FormatString = "n0";
            this.colHOPPID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHOPPID.FieldName = "HOPPID";
            this.colHOPPID.Name = "colHOPPID";
            this.colHOPPID.OptionsColumn.AllowEdit = false;
            this.colHOPPID.OptionsColumn.AllowFocus = false;
            this.colHOPPID.OptionsColumn.FixedWidth = true;
            this.colHOPPID.Visible = true;
            this.colHOPPID.VisibleIndex = 2;
            this.colHOPPID.Width = 60;
            // 
            // colHOPPINF
            // 
            this.colHOPPINF.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOPPINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOPPINF.Caption = "House Package Info";
            this.colHOPPINF.FieldName = "HOPPINF";
            this.colHOPPINF.Name = "colHOPPINF";
            this.colHOPPINF.OptionsColumn.AllowEdit = false;
            this.colHOPPINF.OptionsColumn.AllowFocus = false;
            this.colHOPPINF.Visible = true;
            this.colHOPPINF.VisibleIndex = 5;
            this.colHOPPINF.Width = 147;
            // 
            // colOPHID
            // 
            this.colOPHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colOPHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPHID.Caption = "hID";
            this.colOPHID.DisplayFormat.FormatString = "n0";
            this.colOPHID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOPHID.FieldName = "OPHID";
            this.colOPHID.Name = "colOPHID";
            this.colOPHID.OptionsColumn.AllowEdit = false;
            this.colOPHID.OptionsColumn.AllowFocus = false;
            this.colOPHID.OptionsColumn.FixedWidth = true;
            this.colOPHID.Width = 60;
            // 
            // colHTOP
            // 
            this.colHTOP.AppearanceCell.Options.UseTextOptions = true;
            this.colHTOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHTOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colHTOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHTOP.Caption = "hTOP";
            this.colHTOP.FieldName = "HTOP";
            this.colHTOP.Name = "colHTOP";
            this.colHTOP.OptionsColumn.AllowEdit = false;
            this.colHTOP.OptionsColumn.AllowFocus = false;
            this.colHTOP.OptionsColumn.FixedWidth = true;
            this.colHTOP.Width = 60;
            // 
            // colHNOP
            // 
            this.colHNOP.AppearanceHeader.Options.UseTextOptions = true;
            this.colHNOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHNOP.Caption = "NOP";
            this.colHNOP.DisplayFormat.FormatString = "n0";
            this.colHNOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHNOP.FieldName = "HNOP";
            this.colHNOP.Name = "colHNOP";
            this.colHNOP.OptionsColumn.AllowEdit = false;
            this.colHNOP.OptionsColumn.AllowFocus = false;
            this.colHNOP.OptionsColumn.FixedWidth = true;
            this.colHNOP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HNOP", "{0:n0}")});
            this.colHNOP.Visible = true;
            this.colHNOP.VisibleIndex = 11;
            this.colHNOP.Width = 60;
            // 
            // colHGRW
            // 
            this.colHGRW.AppearanceHeader.Options.UseTextOptions = true;
            this.colHGRW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHGRW.Caption = "GrW";
            this.colHGRW.FieldName = "HGRW";
            this.colHGRW.Name = "colHGRW";
            this.colHGRW.OptionsColumn.AllowEdit = false;
            this.colHGRW.OptionsColumn.AllowFocus = false;
            this.colHGRW.OptionsColumn.FixedWidth = true;
            this.colHGRW.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HGRW", "{0:n2}")});
            this.colHGRW.Visible = true;
            this.colHGRW.VisibleIndex = 12;
            this.colHGRW.Width = 66;
            // 
            // colHVM3
            // 
            this.colHVM3.AppearanceHeader.Options.UseTextOptions = true;
            this.colHVM3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHVM3.Caption = "VM3";
            this.colHVM3.DisplayFormat.FormatString = "n2";
            this.colHVM3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHVM3.FieldName = "HVM3";
            this.colHVM3.Name = "colHVM3";
            this.colHVM3.OptionsColumn.AllowEdit = false;
            this.colHVM3.OptionsColumn.AllowFocus = false;
            this.colHVM3.OptionsColumn.FixedWidth = true;
            this.colHVM3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HVM3", "{0:n2}")});
            this.colHVM3.Visible = true;
            this.colHVM3.VisibleIndex = 13;
            this.colHVM3.Width = 60;
            // 
            // colIDX
            // 
            this.colIDX.AppearanceCell.Options.UseTextOptions = true;
            this.colIDX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDX.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDX.Caption = "Sıra";
            this.colIDX.FieldName = "IDX";
            this.colIDX.Name = "colIDX";
            this.colIDX.OptionsColumn.FixedWidth = true;
            this.colIDX.Visible = true;
            this.colIDX.VisibleIndex = 3;
            this.colIDX.Width = 46;
            // 
            // colHDLVADR
            // 
            this.colHDLVADR.Caption = "DlvAdr";
            this.colHDLVADR.FieldName = "HDLVADR";
            this.colHDLVADR.Name = "colHDLVADR";
            this.colHDLVADR.OptionsColumn.AllowEdit = false;
            this.colHDLVADR.OptionsColumn.AllowFocus = false;
            this.colHDLVADR.Visible = true;
            this.colHDLVADR.VisibleIndex = 10;
            this.colHDLVADR.Width = 94;
            // 
            // colHCNE
            // 
            this.colHCNE.Caption = "Cne";
            this.colHCNE.FieldName = "HCNE";
            this.colHCNE.Name = "colHCNE";
            this.colHCNE.OptionsColumn.AllowEdit = false;
            this.colHCNE.OptionsColumn.AllowFocus = false;
            this.colHCNE.OptionsColumn.FixedWidth = true;
            this.colHCNE.Visible = true;
            this.colHCNE.VisibleIndex = 8;
            this.colHCNE.Width = 80;
            // 
            // colHMNF
            // 
            this.colHMNF.Caption = "Mnf";
            this.colHMNF.FieldName = "HMNF";
            this.colHMNF.Name = "colHMNF";
            this.colHMNF.OptionsColumn.AllowEdit = false;
            this.colHMNF.OptionsColumn.AllowFocus = false;
            this.colHMNF.OptionsColumn.FixedWidth = true;
            this.colHMNF.Visible = true;
            this.colHMNF.VisibleIndex = 7;
            this.colHMNF.Width = 80;
            // 
            // colHSHP
            // 
            this.colHSHP.Caption = "Shp";
            this.colHSHP.FieldName = "HSHP";
            this.colHSHP.Name = "colHSHP";
            this.colHSHP.OptionsColumn.AllowEdit = false;
            this.colHSHP.OptionsColumn.AllowFocus = false;
            this.colHSHP.OptionsColumn.FixedWidth = true;
            this.colHSHP.Visible = true;
            this.colHSHP.VisibleIndex = 6;
            this.colHSHP.Width = 80;
            // 
            // colHPCS
            // 
            this.colHPCS.AppearanceHeader.Options.UseTextOptions = true;
            this.colHPCS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHPCS.Caption = "Pcs";
            this.colHPCS.DisplayFormat.FormatString = "n0";
            this.colHPCS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHPCS.FieldName = "HPCS";
            this.colHPCS.Name = "colHPCS";
            this.colHPCS.OptionsColumn.FixedWidth = true;
            this.colHPCS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "HPCS", "{0:n0}")});
            this.colHPCS.Visible = true;
            this.colHPCS.VisibleIndex = 14;
            this.colHPCS.Width = 60;
            // 
            // colHDST
            // 
            this.colHDST.Caption = "Dst";
            this.colHDST.FieldName = "HDST";
            this.colHDST.Name = "colHDST";
            this.colHDST.Visible = true;
            this.colHDST.VisibleIndex = 9;
            // 
            // colHOPCID
            // 
            this.colHOPCID.Caption = "CntID";
            this.colHOPCID.FieldName = "HOPCID";
            this.colHOPCID.Name = "colHOPCID";
            this.colHOPCID.Visible = true;
            this.colHOPCID.VisibleIndex = 4;
            // 
            // opContainerLoadingXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 291);
            this.Controls.Add(this.opmclGridControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "opContainerLoadingXF";
            this.Text = "Master Loading Plan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.opContainerLoadingXF_FormClosing);
            this.Load += new System.EventHandler(this.opContainerLoadingXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmclBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmclGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opmclGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource opmclBindingSource;
        private OpsDataSetTableAdapters.OPM_CNTR_LOADTableAdapter opmclTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl opmclGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opmclGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMOPPINF;
        private DevExpress.XtraGrid.Columns.GridColumn colMOPPID;
        private DevExpress.XtraGrid.Columns.GridColumn colHOPPID;
        private DevExpress.XtraGrid.Columns.GridColumn colHOPPINF;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHID;
        private DevExpress.XtraGrid.Columns.GridColumn colHTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colHNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colHGRW;
        private DevExpress.XtraGrid.Columns.GridColumn colHVM3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX;
        private DevExpress.XtraGrid.Columns.GridColumn colHDLVADR;
        private DevExpress.XtraGrid.Columns.GridColumn colHCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colHMNF;
        private DevExpress.XtraGrid.Columns.GridColumn colHSHP;
        private DevExpress.XtraGrid.Columns.GridColumn colHPCS;
        private DevExpress.XtraGrid.Columns.GridColumn colHDST;
        private DevExpress.XtraGrid.Columns.GridColumn colHOPCID;
    }
}