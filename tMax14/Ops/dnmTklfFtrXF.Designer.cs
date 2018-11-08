namespace tMax14.Ops
{
    partial class dnmTklfFtrXF
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.opsDataSet = new tMax14.Ops.OpsDataSet();
            this.tKLF_INS_FTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tFaturaGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mergeCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTSTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tKLF_INS_FTR_DENEMETableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.TKLF_INS_FTR_DENEMETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_INS_FTRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFaturaGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colOPHM
            // 
            this.colOPHM.AppearanceCell.Options.UseTextOptions = true;
            this.colOPHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPHM.Caption = "H/M";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 2;
            this.colOPHM.Width = 32;
            // 
            // opsDataSet
            // 
            this.opsDataSet.DataSetName = "OpsDataSet";
            this.opsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKLF_INS_FTRBindingSource
            // 
            this.tKLF_INS_FTRBindingSource.DataMember = "TKLF_INS_FTR_DENEME";
            this.tKLF_INS_FTRBindingSource.DataSource = this.opsDataSet;
            // 
            // tFaturaGridControl
            // 
            this.tFaturaGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tFaturaGridControl.DataSource = this.tKLF_INS_FTRBindingSource;
            this.tFaturaGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tFaturaGridControl.Location = new System.Drawing.Point(0, 0);
            this.tFaturaGridControl.MainView = this.gridView1;
            this.tFaturaGridControl.Name = "tFaturaGridControl";
            this.tFaturaGridControl.Size = new System.Drawing.Size(1094, 329);
            this.tFaturaGridControl.TabIndex = 2;
            this.tFaturaGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeCellToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // mergeCellToolStripMenuItem
            // 
            this.mergeCellToolStripMenuItem.Checked = true;
            this.mergeCellToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mergeCellToolStripMenuItem.Name = "mergeCellToolStripMenuItem";
            this.mergeCellToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.mergeCellToolStripMenuItem.Text = "Merge Cell";
            this.mergeCellToolStripMenuItem.Click += new System.EventHandler(this.mergeCellToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTSTID,
            this.colTSFID,
            this.colOPHM,
            this.colOPID,
            this.colAHTID,
            this.colBRM,
            this.colMIK,
            this.colFYT,
            this.colDVZ,
            this.colKDY,
            this.colFRTID,
            this.colAHTID1});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colOPHM;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "M";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.tFaturaGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            // 
            // colTSTID
            // 
            this.colTSTID.FieldName = "TSTID";
            this.colTSTID.Name = "colTSTID";
            this.colTSTID.OptionsColumn.FixedWidth = true;
            this.colTSTID.Visible = true;
            this.colTSTID.VisibleIndex = 0;
            this.colTSTID.Width = 60;
            // 
            // colTSFID
            // 
            this.colTSFID.FieldName = "TSFID";
            this.colTSFID.Name = "colTSFID";
            this.colTSFID.OptionsColumn.FixedWidth = true;
            this.colTSFID.Visible = true;
            this.colTSFID.VisibleIndex = 1;
            this.colTSFID.Width = 60;
            // 
            // colOPID
            // 
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 3;
            this.colOPID.Width = 60;
            // 
            // colAHTID
            // 
            this.colAHTID.Caption = "Charge";
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 6;
            this.colAHTID.Width = 249;
            // 
            // colBRM
            // 
            this.colBRM.AppearanceCell.Options.UseTextOptions = true;
            this.colBRM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBRM.AppearanceHeader.Options.UseTextOptions = true;
            this.colBRM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.OptionsColumn.FixedWidth = true;
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 7;
            this.colBRM.Width = 57;
            // 
            // colMIK
            // 
            this.colMIK.AppearanceCell.Options.UseTextOptions = true;
            this.colMIK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.AppearanceHeader.Options.UseTextOptions = true;
            this.colMIK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.OptionsColumn.FixedWidth = true;
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 8;
            this.colMIK.Width = 50;
            // 
            // colFYT
            // 
            this.colFYT.AppearanceHeader.Options.UseTextOptions = true;
            this.colFYT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFYT.DisplayFormat.FormatString = "n";
            this.colFYT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFYT.FieldName = "FYT";
            this.colFYT.Name = "colFYT";
            this.colFYT.OptionsColumn.FixedWidth = true;
            this.colFYT.Visible = true;
            this.colFYT.VisibleIndex = 9;
            this.colFYT.Width = 65;
            // 
            // colDVZ
            // 
            this.colDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZ.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVZ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.OptionsColumn.FixedWidth = true;
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 10;
            this.colDVZ.Width = 40;
            // 
            // colKDY
            // 
            this.colKDY.AppearanceCell.Options.UseTextOptions = true;
            this.colKDY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKDY.AppearanceHeader.Options.UseTextOptions = true;
            this.colKDY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKDY.Caption = "K%";
            this.colKDY.FieldName = "KDY";
            this.colKDY.Name = "colKDY";
            this.colKDY.OptionsColumn.FixedWidth = true;
            this.colKDY.Visible = true;
            this.colKDY.VisibleIndex = 11;
            this.colKDY.Width = 30;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 4;
            this.colFRTID.Width = 303;
            // 
            // colAHTID1
            // 
            this.colAHTID1.FieldName = "AHTID";
            this.colAHTID1.Name = "colAHTID1";
            this.colAHTID1.OptionsColumn.FixedWidth = true;
            this.colAHTID1.Visible = true;
            this.colAHTID1.VisibleIndex = 5;
            this.colAHTID1.Width = 60;
            // 
            // tKLF_INS_FTR_DENEMETableAdapter
            // 
            this.tKLF_INS_FTR_DENEMETableAdapter.ClearBeforeFill = true;
            // 
            // dnmTklfFtrXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 329);
            this.Controls.Add(this.tFaturaGridControl);
            this.Name = "dnmTklfFtrXF";
            this.Text = "DENEME Teklif->Fatura [dnmTklfFtrXF]";
            this.Load += new System.EventHandler(this.dnmTklfFtrXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKLF_INS_FTRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFaturaGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpsDataSet opsDataSet;
        private System.Windows.Forms.BindingSource tKLF_INS_FTRBindingSource;
        private DevExpress.XtraGrid.GridControl tFaturaGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTSTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTSFID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mergeCellToolStripMenuItem;
        private OpsDataSetTableAdapters.TKLF_INS_FTR_DENEMETableAdapter tKLF_INS_FTR_DENEMETableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colKDY;
    }
}