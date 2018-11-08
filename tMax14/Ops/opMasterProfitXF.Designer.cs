namespace tMax14.Ops
{
    partial class opMasterProfitXF
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.opmProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opmProfitTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OPM_PROFITTableAdapter();
            this.tableAdapterManager = new tMax14.Ops.OpsDataSetTableAdapters.TableAdapterManager();
            this.opmProfitGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmProfitGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFTRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKURTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colRTUT
            // 
            this.colRTUT.AppearanceHeader.Options.UseTextOptions = true;
            this.colRTUT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRTUT.Caption = "Tut (RPR)";
            this.colRTUT.DisplayFormat.FormatString = "n2";
            this.colRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRTUT.FieldName = "RTUT";
            this.colRTUT.Name = "colRTUT";
            this.colRTUT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRTUT.OptionsColumn.FixedWidth = true;
            this.colRTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RTUT", "{0:n2}")});
            this.colRTUT.Visible = true;
            this.colRTUT.VisibleIndex = 6;
            // 
            // colDRM
            // 
            this.colDRM.AppearanceCell.Options.UseTextOptions = true;
            this.colDRM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDRM.Caption = "Durum";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.OptionsColumn.FixedWidth = true;
            this.colDRM.ToolTip = "-Faturalaşmamış, Açık, Kapalı";
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 1;
            this.colDRM.Width = 40;
            // 
            // colAFBID
            // 
            this.colAFBID.FieldName = "AFBID";
            this.colAFBID.Name = "colAFBID";
            this.colAFBID.OptionsColumn.FixedWidth = true;
            this.colAFBID.Width = 60;
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opmProfitBindingSource
            // 
            this.opmProfitBindingSource.DataMember = "OPM_PROFIT";
            this.opmProfitBindingSource.DataSource = this.opsDataSet;
            // 
            // opmProfitTableAdapter
            // 
            this.opmProfitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AFDO_SELTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.OPH_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPH_SELTableAdapter = null;
            this.tableAdapterManager.OPHTableAdapter = null;
            this.tableAdapterManager.OPM_BOS_SELTableAdapter = null;
            this.tableAdapterManager.OPM_CNTR_LOADTableAdapter = null;
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
            // opmProfitGridControl
            // 
            this.opmProfitGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.opmProfitGridControl.DataSource = this.opmProfitBindingSource;
            this.opmProfitGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opmProfitGridControl.Location = new System.Drawing.Point(0, 0);
            this.opmProfitGridControl.MainView = this.opmProfitGridView;
            this.opmProfitGridControl.Name = "opmProfitGridControl";
            this.opmProfitGridControl.Size = new System.Drawing.Size(706, 340);
            this.opmProfitGridControl.TabIndex = 2;
            this.opmProfitGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opmProfitGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem,
            this.onaylaToolStripMenuItem,
            this.layoutsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(113, 70);
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.faturaToolStripMenuItem.Text = "Fatura";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onayToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // opmProfitGridView
            // 
            this.opmProfitGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAFBID,
            this.colDRM,
            this.colFTRNO,
            this.colFTRTRH,
            this.colKURTRH,
            this.colFRTID,
            this.colAFDID,
            this.colTUR,
            this.colAHTID,
            this.colOPID,
            this.colOPHM,
            this.colMIK,
            this.colDFYT,
            this.colDDVZ,
            this.colDKUR,
            this.colBDVZ,
            this.colBKUR,
            this.colRKUR,
            this.colRTUT});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colRTUT;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = new decimal(new int[] {
            0,
            0,
            0,
            0});
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colDRM;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "-";
            this.opmProfitGridView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.opmProfitGridView.GridControl = this.opmProfitGridControl;
            this.opmProfitGridView.GroupCount = 1;
            this.opmProfitGridView.GroupFormat = "{1} {2}";
            this.opmProfitGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RTUT", this.colRTUT, "{0:n2}")});
            this.opmProfitGridView.Name = "opmProfitGridView";
            this.opmProfitGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.opmProfitGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.opmProfitGridView.OptionsBehavior.Editable = false;
            this.opmProfitGridView.OptionsView.AllowCellMerge = true;
            this.opmProfitGridView.OptionsView.ShowFooter = true;
            this.opmProfitGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFRTID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.opmProfitGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.opmProfitGridView_CustomColumnDisplayText);
            // 
            // colFTRNO
            // 
            this.colFTRNO.Caption = "FtrNo";
            this.colFTRNO.FieldName = "FTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.OptionsColumn.AllowEdit = false;
            this.colFTRNO.OptionsColumn.AllowFocus = false;
            this.colFTRNO.OptionsColumn.FixedWidth = true;
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 8;
            this.colFTRNO.Width = 54;
            // 
            // colFTRTRH
            // 
            this.colFTRTRH.Caption = "FtrTrh";
            this.colFTRTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colFTRTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFTRTRH.FieldName = "FTRTRH";
            this.colFTRTRH.Name = "colFTRTRH";
            this.colFTRTRH.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFTRTRH.OptionsColumn.FixedWidth = true;
            this.colFTRTRH.Visible = true;
            this.colFTRTRH.VisibleIndex = 7;
            this.colFTRTRH.Width = 54;
            // 
            // colKURTRH
            // 
            this.colKURTRH.Caption = "KurTrh";
            this.colKURTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colKURTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colKURTRH.FieldName = "KURTRH";
            this.colKURTRH.Name = "colKURTRH";
            this.colKURTRH.OptionsColumn.FixedWidth = true;
            this.colKURTRH.Width = 54;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 0;
            this.colFRTID.Width = 174;
            // 
            // colAFDID
            // 
            this.colAFDID.FieldName = "AFDID";
            this.colAFDID.Name = "colAFDID";
            this.colAFDID.OptionsColumn.FixedWidth = true;
            this.colAFDID.Width = 60;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 80;
            // 
            // colAHTID
            // 
            this.colAHTID.Caption = "Charge";
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 0;
            this.colAHTID.Width = 109;
            // 
            // colOPID
            // 
            this.colOPID.Caption = "OpID";
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 10;
            this.colOPID.Width = 60;
            // 
            // colOPHM
            // 
            this.colOPHM.AppearanceCell.Options.UseTextOptions = true;
            this.colOPHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPHM.AppearanceHeader.Options.UseTextOptions = true;
            this.colOPHM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPHM.Caption = "H/M";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.OptionsColumn.FixedWidth = true;
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 9;
            this.colOPHM.Width = 30;
            // 
            // colMIK
            // 
            this.colMIK.AppearanceCell.Options.UseTextOptions = true;
            this.colMIK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.Caption = "Mik";
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMIK.OptionsColumn.FixedWidth = true;
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 3;
            this.colMIK.Width = 50;
            // 
            // colDFYT
            // 
            this.colDFYT.AppearanceHeader.Options.UseTextOptions = true;
            this.colDFYT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDFYT.Caption = "dFyt";
            this.colDFYT.FieldName = "DFYT";
            this.colDFYT.Name = "colDFYT";
            this.colDFYT.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDFYT.OptionsColumn.FixedWidth = true;
            this.colDFYT.Visible = true;
            this.colDFYT.VisibleIndex = 4;
            // 
            // colDDVZ
            // 
            this.colDDVZ.Caption = "dDvz";
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDDVZ.OptionsColumn.FixedWidth = true;
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 5;
            this.colDDVZ.Width = 40;
            // 
            // colDKUR
            // 
            this.colDKUR.Caption = "dKur";
            this.colDKUR.FieldName = "DKUR";
            this.colDKUR.Name = "colDKUR";
            this.colDKUR.OptionsColumn.FixedWidth = true;
            this.colDKUR.Width = 50;
            // 
            // colBDVZ
            // 
            this.colBDVZ.Caption = "bDvz";
            this.colBDVZ.FieldName = "BDVZ";
            this.colBDVZ.Name = "colBDVZ";
            this.colBDVZ.OptionsColumn.FixedWidth = true;
            this.colBDVZ.Width = 40;
            // 
            // colBKUR
            // 
            this.colBKUR.Caption = "bKur";
            this.colBKUR.FieldName = "BKUR";
            this.colBKUR.Name = "colBKUR";
            this.colBKUR.OptionsColumn.FixedWidth = true;
            this.colBKUR.Width = 50;
            // 
            // colRKUR
            // 
            this.colRKUR.Caption = "rKur";
            this.colRKUR.FieldName = "RKUR";
            this.colRKUR.Name = "colRKUR";
            this.colRKUR.OptionsColumn.FixedWidth = true;
            this.colRKUR.Width = 50;
            // 
            // opMasterProfitXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 340);
            this.Controls.Add(this.opmProfitGridControl);
            this.Name = "opMasterProfitXF";
            this.Text = "opMasterProfit";
            this.Load += new System.EventHandler(this.opMasterProfit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opmProfitGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource opmProfitBindingSource;
        private OpsDataSetTableAdapters.OPM_PROFITTableAdapter opmProfitTableAdapter;
        private OpsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl opmProfitGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opmProfitGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colAFBID;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colKURTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAFDID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colDFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colBDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colBKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colRKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRNO;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
    }
}