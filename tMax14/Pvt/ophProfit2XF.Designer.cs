namespace tMax14.Pvt
{
    partial class ophProfit2XF
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
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.oPHPROFITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPH_PROFITTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.OPH_PROFITTableAdapter();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.oPH_PROFITGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORGCNTRY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTCNTRY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3P = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRWP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHWP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKZ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPHPROFITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPH_PROFITGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colHID
            // 
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colHID.Visible = true;
            this.colHID.VisibleIndex = 1;
            this.colHID.Width = 46;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPHPROFITBindingSource
            // 
            this.oPHPROFITBindingSource.DataMember = "OPH_PROFIT";
            this.oPHPROFITBindingSource.DataSource = this.pvtDataSet;
            // 
            // oPH_PROFITTableAdapter
            // 
            this.oPH_PROFITTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oPH_PROFITGridControl
            // 
            this.oPH_PROFITGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.oPH_PROFITGridControl.DataSource = this.oPHPROFITBindingSource;
            this.oPH_PROFITGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oPH_PROFITGridControl.Location = new System.Drawing.Point(0, 0);
            this.oPH_PROFITGridControl.MainView = this.gridView1;
            this.oPH_PROFITGridControl.Name = "oPH_PROFITGridControl";
            this.oPH_PROFITGridControl.Size = new System.Drawing.Size(1368, 304);
            this.oPH_PROFITGridControl.TabIndex = 0;
            this.oPH_PROFITGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMID,
            this.colHID,
            this.colTOB,
            this.colROT,
            this.colMOT,
            this.colORGCNTRY,
            this.colDSTCNTRY,
            this.colSHP,
            this.colCNE,
            this.colACC,
            this.colNOP,
            this.colVM3,
            this.colGRW,
            this.colCHW,
            this.colNOPP,
            this.colVM3P,
            this.colGRWP,
            this.colCHWP,
            this.colGLR,
            this.colGLRP,
            this.colGLRT,
            this.colGDR,
            this.colGDRP,
            this.colGDRT,
            this.colKAR,
            this.colKZ});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colHID;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "IsNull([HID])";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.oPH_PROFITGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "HID", this.colHID, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GLRT", this.colGLRT, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GDRT", this.colGDRT, "{0:n}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR", this.colKAR, "{0:n}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colMID
            // 
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.Visible = true;
            this.colMID.VisibleIndex = 0;
            this.colMID.Width = 46;
            // 
            // colTOB
            // 
            this.colTOB.FieldName = "TOB";
            this.colTOB.Name = "colTOB";
            this.colTOB.Visible = true;
            this.colTOB.VisibleIndex = 2;
            this.colTOB.Width = 32;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 3;
            this.colROT.Width = 32;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 4;
            this.colMOT.Width = 32;
            // 
            // colORGCNTRY
            // 
            this.colORGCNTRY.Caption = "OrgCnt";
            this.colORGCNTRY.FieldName = "ORGCNTRY";
            this.colORGCNTRY.Name = "colORGCNTRY";
            this.colORGCNTRY.Visible = true;
            this.colORGCNTRY.VisibleIndex = 5;
            this.colORGCNTRY.Width = 80;
            // 
            // colDSTCNTRY
            // 
            this.colDSTCNTRY.Caption = "DstCntry";
            this.colDSTCNTRY.FieldName = "DSTCNTRY";
            this.colDSTCNTRY.Name = "colDSTCNTRY";
            this.colDSTCNTRY.Visible = true;
            this.colDSTCNTRY.VisibleIndex = 6;
            this.colDSTCNTRY.Width = 80;
            // 
            // colSHP
            // 
            this.colSHP.Caption = "Shp";
            this.colSHP.FieldName = "SHP";
            this.colSHP.Name = "colSHP";
            this.colSHP.Visible = true;
            this.colSHP.VisibleIndex = 7;
            this.colSHP.Width = 80;
            // 
            // colCNE
            // 
            this.colCNE.Caption = "Cne";
            this.colCNE.FieldName = "CNE";
            this.colCNE.Name = "colCNE";
            this.colCNE.Visible = true;
            this.colCNE.VisibleIndex = 8;
            this.colCNE.Width = 80;
            // 
            // colACC
            // 
            this.colACC.Caption = "Acc";
            this.colACC.FieldName = "ACC";
            this.colACC.Name = "colACC";
            this.colACC.Visible = true;
            this.colACC.VisibleIndex = 9;
            this.colACC.Width = 80;
            // 
            // colNOP
            // 
            this.colNOP.FieldName = "NOP";
            this.colNOP.Name = "colNOP";
            this.colNOP.Visible = true;
            this.colNOP.VisibleIndex = 10;
            this.colNOP.Width = 46;
            // 
            // colVM3
            // 
            this.colVM3.FieldName = "VM3";
            this.colVM3.Name = "colVM3";
            this.colVM3.Visible = true;
            this.colVM3.VisibleIndex = 11;
            this.colVM3.Width = 46;
            // 
            // colGRW
            // 
            this.colGRW.FieldName = "GRW";
            this.colGRW.Name = "colGRW";
            this.colGRW.Visible = true;
            this.colGRW.VisibleIndex = 12;
            this.colGRW.Width = 46;
            // 
            // colCHW
            // 
            this.colCHW.FieldName = "CHW";
            this.colCHW.Name = "colCHW";
            this.colCHW.Visible = true;
            this.colCHW.VisibleIndex = 13;
            this.colCHW.Width = 46;
            // 
            // colNOPP
            // 
            this.colNOPP.Caption = "NOPp";
            this.colNOPP.FieldName = "NOPP";
            this.colNOPP.Name = "colNOPP";
            this.colNOPP.Visible = true;
            this.colNOPP.VisibleIndex = 14;
            this.colNOPP.Width = 46;
            // 
            // colVM3P
            // 
            this.colVM3P.Caption = "VM3p";
            this.colVM3P.FieldName = "VM3P";
            this.colVM3P.Name = "colVM3P";
            this.colVM3P.Visible = true;
            this.colVM3P.VisibleIndex = 15;
            this.colVM3P.Width = 46;
            // 
            // colGRWP
            // 
            this.colGRWP.Caption = "GrWp";
            this.colGRWP.FieldName = "GRWP";
            this.colGRWP.Name = "colGRWP";
            this.colGRWP.Visible = true;
            this.colGRWP.VisibleIndex = 16;
            this.colGRWP.Width = 46;
            // 
            // colCHWP
            // 
            this.colCHWP.Caption = "ChWp";
            this.colCHWP.FieldName = "CHWP";
            this.colCHWP.Name = "colCHWP";
            this.colCHWP.Visible = true;
            this.colCHWP.VisibleIndex = 17;
            this.colCHWP.Width = 46;
            // 
            // colGLR
            // 
            this.colGLR.AppearanceHeader.Options.UseTextOptions = true;
            this.colGLR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGLR.Caption = "Glr";
            this.colGLR.FieldName = "GLR";
            this.colGLR.Name = "colGLR";
            this.colGLR.Visible = true;
            this.colGLR.VisibleIndex = 18;
            this.colGLR.Width = 46;
            // 
            // colGLRP
            // 
            this.colGLRP.AppearanceHeader.Options.UseTextOptions = true;
            this.colGLRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGLRP.Caption = "GlrP";
            this.colGLRP.FieldName = "GLRP";
            this.colGLRP.Name = "colGLRP";
            this.colGLRP.Visible = true;
            this.colGLRP.VisibleIndex = 19;
            this.colGLRP.Width = 46;
            // 
            // colGLRT
            // 
            this.colGLRT.AppearanceHeader.Options.UseTextOptions = true;
            this.colGLRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGLRT.Caption = "GlrT";
            this.colGLRT.FieldName = "GLRT";
            this.colGLRT.Name = "colGLRT";
            this.colGLRT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GLRT", "{0:n}")});
            this.colGLRT.Visible = true;
            this.colGLRT.VisibleIndex = 20;
            this.colGLRT.Width = 80;
            // 
            // colGDR
            // 
            this.colGDR.AppearanceHeader.Options.UseTextOptions = true;
            this.colGDR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGDR.Caption = "Gdr";
            this.colGDR.FieldName = "GDR";
            this.colGDR.Name = "colGDR";
            this.colGDR.Visible = true;
            this.colGDR.VisibleIndex = 21;
            this.colGDR.Width = 46;
            // 
            // colGDRP
            // 
            this.colGDRP.AppearanceHeader.Options.UseTextOptions = true;
            this.colGDRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGDRP.Caption = "GdrP";
            this.colGDRP.FieldName = "GDRP";
            this.colGDRP.Name = "colGDRP";
            this.colGDRP.Visible = true;
            this.colGDRP.VisibleIndex = 22;
            this.colGDRP.Width = 46;
            // 
            // colGDRT
            // 
            this.colGDRT.AppearanceHeader.Options.UseTextOptions = true;
            this.colGDRT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colGDRT.Caption = "GdrT";
            this.colGDRT.FieldName = "GDRT";
            this.colGDRT.Name = "colGDRT";
            this.colGDRT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GDRT", "{0:n}")});
            this.colGDRT.Visible = true;
            this.colGDRT.VisibleIndex = 23;
            this.colGDRT.Width = 80;
            // 
            // colKAR
            // 
            this.colKAR.AppearanceHeader.Options.UseTextOptions = true;
            this.colKAR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colKAR.Caption = "Kar";
            this.colKAR.FieldName = "KAR";
            this.colKAR.Name = "colKAR";
            this.colKAR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR", "{0:n}")});
            this.colKAR.Visible = true;
            this.colKAR.VisibleIndex = 24;
            this.colKAR.Width = 73;
            // 
            // colKZ
            // 
            this.colKZ.Caption = "K/Z";
            this.colKZ.FieldName = "KZ";
            this.colKZ.Name = "colKZ";
            this.colKZ.Visible = true;
            this.colKZ.VisibleIndex = 25;
            this.colKZ.Width = 35;
            // 
            // ophProfit2XF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 304);
            this.Controls.Add(this.oPH_PROFITGridControl);
            this.Name = "ophProfit2XF";
            this.Text = "ophProfit2 Trace";
            this.Load += new System.EventHandler(this.ophProfit2XF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPHPROFITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPH_PROFITGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource oPHPROFITBindingSource;
        private PvtDataSetTableAdapters.OPH_PROFITTableAdapter oPH_PROFITTableAdapter;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl oPH_PROFITGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colTOB;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colORGCNTRY;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTCNTRY;
        private DevExpress.XtraGrid.Columns.GridColumn colSHP;
        private DevExpress.XtraGrid.Columns.GridColumn colCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colACC;
        private DevExpress.XtraGrid.Columns.GridColumn colNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colVM3;
        private DevExpress.XtraGrid.Columns.GridColumn colGRW;
        private DevExpress.XtraGrid.Columns.GridColumn colCHW;
        private DevExpress.XtraGrid.Columns.GridColumn colNOPP;
        private DevExpress.XtraGrid.Columns.GridColumn colVM3P;
        private DevExpress.XtraGrid.Columns.GridColumn colGRWP;
        private DevExpress.XtraGrid.Columns.GridColumn colCHWP;
        private DevExpress.XtraGrid.Columns.GridColumn colGLR;
        private DevExpress.XtraGrid.Columns.GridColumn colGLRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGLRT;
        private DevExpress.XtraGrid.Columns.GridColumn colGDR;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRT;
        private DevExpress.XtraGrid.Columns.GridColumn colKAR;
        private DevExpress.XtraGrid.Columns.GridColumn colKZ;
    }
}