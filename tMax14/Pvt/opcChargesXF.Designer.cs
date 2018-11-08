namespace tMax14.Pvt
{
    partial class opcChargesXF
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
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.oPC_CHARGESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPC_CHARGESTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.OPC_CHARGESTableAdapter();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.oPC_CHARGESGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAFBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPCID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKURTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGLRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPC_CHARGESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPC_CHARGESGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colBA
            // 
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 10;
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPC_CHARGESBindingSource
            // 
            this.oPC_CHARGESBindingSource.DataMember = "OPC_CHARGES";
            this.oPC_CHARGESBindingSource.DataSource = this.pvtDataSet;
            // 
            // oPC_CHARGESTableAdapter
            // 
            this.oPC_CHARGESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oPC_CHARGESGridControl
            // 
            this.oPC_CHARGESGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.oPC_CHARGESGridControl.DataSource = this.oPC_CHARGESBindingSource;
            this.oPC_CHARGESGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oPC_CHARGESGridControl.Location = new System.Drawing.Point(0, 0);
            this.oPC_CHARGESGridControl.MainView = this.gridView1;
            this.oPC_CHARGESGridControl.Name = "oPC_CHARGESGridControl";
            this.oPC_CHARGESGridControl.Size = new System.Drawing.Size(1134, 482);
            this.oPC_CHARGESGridControl.TabIndex = 2;
            this.oPC_CHARGESGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSNB,
            this.colNOC,
            this.colOPHM,
            this.colOPID,
            this.colAFDID,
            this.colAFBID,
            this.colFRTID,
            this.colAHTID,
            this.colOPCID,
            this.colTUR,
            this.colBA,
            this.colMIK,
            this.colBRM,
            this.colDFYT,
            this.colDDVZ,
            this.colDKUR,
            this.colKURTRH,
            this.colRKUR,
            this.colGLRTUT,
            this.colGDRTUT});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colBA;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "A";
            styleFormatCondition2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colOPHM;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "M";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridView1.GridControl = this.oPC_CHARGESGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colSNB
            // 
            this.colSNB.FieldName = "SNB";
            this.colSNB.Name = "colSNB";
            this.colSNB.Visible = true;
            this.colSNB.VisibleIndex = 0;
            // 
            // colNOC
            // 
            this.colNOC.FieldName = "NOC";
            this.colNOC.Name = "colNOC";
            this.colNOC.ToolTip = "Number of Container";
            this.colNOC.Visible = true;
            this.colNOC.VisibleIndex = 1;
            // 
            // colOPHM
            // 
            this.colOPHM.Caption = "OpHM";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 2;
            // 
            // colOPID
            // 
            this.colOPID.Caption = "OpID";
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 3;
            // 
            // colAFDID
            // 
            this.colAFDID.FieldName = "AFDID";
            this.colAFDID.Name = "colAFDID";
            this.colAFDID.Visible = true;
            this.colAFDID.VisibleIndex = 4;
            // 
            // colAFBID
            // 
            this.colAFBID.FieldName = "AFBID";
            this.colAFBID.Name = "colAFBID";
            this.colAFBID.Visible = true;
            this.colAFBID.VisibleIndex = 5;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 6;
            // 
            // colAHTID
            // 
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 7;
            // 
            // colOPCID
            // 
            this.colOPCID.FieldName = "OPCID";
            this.colOPCID.Name = "colOPCID";
            this.colOPCID.Visible = true;
            this.colOPCID.VisibleIndex = 8;
            // 
            // colTUR
            // 
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 9;
            // 
            // colMIK
            // 
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 11;
            // 
            // colBRM
            // 
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 12;
            // 
            // colDFYT
            // 
            this.colDFYT.FieldName = "DFYT";
            this.colDFYT.Name = "colDFYT";
            this.colDFYT.Visible = true;
            this.colDFYT.VisibleIndex = 13;
            // 
            // colDDVZ
            // 
            this.colDDVZ.FieldName = "DDVZ";
            this.colDDVZ.Name = "colDDVZ";
            this.colDDVZ.Visible = true;
            this.colDDVZ.VisibleIndex = 14;
            // 
            // colDKUR
            // 
            this.colDKUR.FieldName = "DKUR";
            this.colDKUR.Name = "colDKUR";
            this.colDKUR.Visible = true;
            this.colDKUR.VisibleIndex = 15;
            // 
            // colKURTRH
            // 
            this.colKURTRH.DisplayFormat.FormatString = "dd.MM.yy";
            this.colKURTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colKURTRH.FieldName = "KURTRH";
            this.colKURTRH.Name = "colKURTRH";
            this.colKURTRH.Visible = true;
            this.colKURTRH.VisibleIndex = 16;
            // 
            // colRKUR
            // 
            this.colRKUR.FieldName = "RKUR";
            this.colRKUR.Name = "colRKUR";
            this.colRKUR.Visible = true;
            this.colRKUR.VisibleIndex = 17;
            // 
            // colGLRTUT
            // 
            this.colGLRTUT.DisplayFormat.FormatString = "n";
            this.colGLRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGLRTUT.FieldName = "GLRTUT";
            this.colGLRTUT.Name = "colGLRTUT";
            this.colGLRTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GLRTUT", "{0:n}")});
            this.colGLRTUT.Visible = true;
            this.colGLRTUT.VisibleIndex = 18;
            // 
            // colGDRTUT
            // 
            this.colGDRTUT.DisplayFormat.FormatString = "n";
            this.colGDRTUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGDRTUT.FieldName = "GDRTUT";
            this.colGDRTUT.Name = "colGDRTUT";
            this.colGDRTUT.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GDRTUT", "{0:n}")});
            this.colGDRTUT.Visible = true;
            this.colGDRTUT.VisibleIndex = 19;
            // 
            // opcChargesXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 482);
            this.Controls.Add(this.oPC_CHARGESGridControl);
            this.Name = "opcChargesXF";
            this.Text = "opcChargesXF";
            this.Load += new System.EventHandler(this.opcChargesXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPC_CHARGESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPC_CHARGESGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource oPC_CHARGESBindingSource;
        private PvtDataSetTableAdapters.OPC_CHARGESTableAdapter oPC_CHARGESTableAdapter;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl oPC_CHARGESGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSNB;
        private DevExpress.XtraGrid.Columns.GridColumn colNOC;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colAFDID;
        private DevExpress.XtraGrid.Columns.GridColumn colAFBID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPCID;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DevExpress.XtraGrid.Columns.GridColumn colDFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colDKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colKURTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colRKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colGLRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colGDRTUT;
    }
}