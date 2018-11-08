namespace tMax14.Teklif
{
    partial class TeklifFtrAlsXF
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
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.colFYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.ftrAlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ftrAlsTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TKLF_FTR_ALS_SELTableAdapter();
            this.ftrAlsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftrAlsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPHM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TURrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAHTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMSJ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colFYT
            // 
            this.colFYT.Caption = "Fyt";
            this.colFYT.FieldName = "FYT";
            this.colFYT.Name = "colFYT";
            this.colFYT.Visible = true;
            this.colFYT.VisibleIndex = 8;
            this.colFYT.Width = 100;
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ftrAlsBindingSource
            // 
            this.ftrAlsBindingSource.DataMember = "TKLF_FTR_ALS_SEL";
            this.ftrAlsBindingSource.DataSource = this.teklifDataSet;
            // 
            // ftrAlsTableAdapter
            // 
            this.ftrAlsTableAdapter.ClearBeforeFill = true;
            // 
            // ftrAlsGridControl
            // 
            this.ftrAlsGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.ftrAlsGridControl.DataSource = this.ftrAlsBindingSource;
            this.ftrAlsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ftrAlsGridControl.Location = new System.Drawing.Point(0, 0);
            this.ftrAlsGridControl.MainView = this.ftrAlsGridView;
            this.ftrAlsGridControl.Name = "ftrAlsGridControl";
            this.ftrAlsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TURrepositoryItemImageComboBox});
            this.ftrAlsGridControl.Size = new System.Drawing.Size(1051, 315);
            this.ftrAlsGridControl.TabIndex = 2;
            this.ftrAlsGridControl.Tag = "FTRALS";
            this.ftrAlsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ftrAlsGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createChargesToolStripMenuItem,
            this.ınsertToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // createChargesToolStripMenuItem
            // 
            this.createChargesToolStripMenuItem.Name = "createChargesToolStripMenuItem";
            this.createChargesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createChargesToolStripMenuItem.Text = "Create Charges";
            this.createChargesToolStripMenuItem.Click += new System.EventHandler(this.createChargesToolStripMenuItem_Click);
            // 
            // ınsertToolStripMenuItem
            // 
            this.ınsertToolStripMenuItem.Name = "ınsertToolStripMenuItem";
            this.ınsertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.ınsertToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ınsertToolStripMenuItem.Text = "Insert";
            this.ınsertToolStripMenuItem.Click += new System.EventHandler(this.ınsertToolStripMenuItem_Click);
            // 
            // ftrAlsGridView
            // 
            this.ftrAlsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPID,
            this.colOPHM,
            this.colOK,
            this.colTUR,
            this.colFRTID,
            this.colAHTID,
            this.colMIK,
            this.colBRM,
            this.colFYT,
            this.colDVZ,
            this.colKDY,
            this.colMSJ,
            this.colTOP,
            this.colREFTO,
            this.colREFID,
            this.colUSR,
            this.colINFO});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[OK] = \'F\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.ftrAlsGridView.FormatRules.Add(gridFormatRule1);
            this.ftrAlsGridView.GridControl = this.ftrAlsGridControl;
            this.ftrAlsGridView.Name = "ftrAlsGridView";
            this.ftrAlsGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.ftrAlsGridView_ShowingEditor);
            this.ftrAlsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.ftrAlsGridView_ValidateRow);
            // 
            // colOPID
            // 
            this.colOPID.FieldName = "OPID";
            this.colOPID.Name = "colOPID";
            this.colOPID.OptionsColumn.AllowEdit = false;
            this.colOPID.OptionsColumn.AllowFocus = false;
            this.colOPID.OptionsColumn.FixedWidth = true;
            this.colOPID.Visible = true;
            this.colOPID.VisibleIndex = 0;
            this.colOPID.Width = 60;
            // 
            // colOPHM
            // 
            this.colOPHM.AppearanceCell.Options.UseTextOptions = true;
            this.colOPHM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOPHM.Caption = "H/M";
            this.colOPHM.FieldName = "OPHM";
            this.colOPHM.Name = "colOPHM";
            this.colOPHM.OptionsColumn.AllowEdit = false;
            this.colOPHM.OptionsColumn.AllowFocus = false;
            this.colOPHM.OptionsColumn.FixedWidth = true;
            this.colOPHM.Visible = true;
            this.colOPHM.VisibleIndex = 1;
            this.colOPHM.Width = 34;
            // 
            // colOK
            // 
            this.colOK.AppearanceCell.Options.UseTextOptions = true;
            this.colOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOK.FieldName = "OK";
            this.colOK.Name = "colOK";
            this.colOK.OptionsColumn.FixedWidth = true;
            this.colOK.Visible = true;
            this.colOK.VisibleIndex = 3;
            this.colOK.Width = 32;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.ColumnEdit = this.TURrepositoryItemImageComboBox;
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.OptionsColumn.FixedWidth = true;
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 2;
            this.colTUR.Width = 61;
            // 
            // TURrepositoryItemImageComboBox
            // 
            this.TURrepositoryItemImageComboBox.AutoHeight = false;
            this.TURrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TURrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Faturalı", "AA", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Belgesiz", "AV", -1)});
            this.TURrepositoryItemImageComboBox.Name = "TURrepositoryItemImageComboBox";
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Firma";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 4;
            this.colFRTID.Width = 125;
            // 
            // colAHTID
            // 
            this.colAHTID.Caption = "Charge";
            this.colAHTID.FieldName = "AHTID";
            this.colAHTID.Name = "colAHTID";
            this.colAHTID.Visible = true;
            this.colAHTID.VisibleIndex = 5;
            this.colAHTID.Width = 131;
            // 
            // colMIK
            // 
            this.colMIK.Caption = "Mik";
            this.colMIK.FieldName = "MIK";
            this.colMIK.Name = "colMIK";
            this.colMIK.OptionsColumn.FixedWidth = true;
            this.colMIK.Visible = true;
            this.colMIK.VisibleIndex = 6;
            this.colMIK.Width = 40;
            // 
            // colBRM
            // 
            this.colBRM.Caption = "Brm";
            this.colBRM.FieldName = "BRM";
            this.colBRM.Name = "colBRM";
            this.colBRM.OptionsColumn.FixedWidth = true;
            this.colBRM.Visible = true;
            this.colBRM.VisibleIndex = 7;
            this.colBRM.Width = 60;
            // 
            // colDVZ
            // 
            this.colDVZ.AppearanceCell.Options.UseTextOptions = true;
            this.colDVZ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 9;
            this.colDVZ.Width = 51;
            // 
            // colKDY
            // 
            this.colKDY.AppearanceCell.Options.UseTextOptions = true;
            this.colKDY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKDY.Caption = "KdY";
            this.colKDY.FieldName = "KDY";
            this.colKDY.Name = "colKDY";
            this.colKDY.OptionsColumn.FixedWidth = true;
            this.colKDY.Visible = true;
            this.colKDY.VisibleIndex = 10;
            this.colKDY.Width = 34;
            // 
            // colMSJ
            // 
            this.colMSJ.Caption = "Msj";
            this.colMSJ.FieldName = "MSJ";
            this.colMSJ.Name = "colMSJ";
            this.colMSJ.OptionsColumn.AllowEdit = false;
            this.colMSJ.OptionsColumn.AllowFocus = false;
            this.colMSJ.Visible = true;
            this.colMSJ.VisibleIndex = 12;
            this.colMSJ.Width = 161;
            // 
            // colTOP
            // 
            this.colTOP.FieldName = "TOP";
            this.colTOP.Name = "colTOP";
            this.colTOP.OptionsColumn.AllowEdit = false;
            this.colTOP.OptionsColumn.AllowFocus = false;
            this.colTOP.OptionsColumn.FixedWidth = true;
            this.colTOP.Visible = true;
            this.colTOP.VisibleIndex = 11;
            this.colTOP.Width = 60;
            // 
            // colREFTO
            // 
            this.colREFTO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFTO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTO.Caption = "Ref";
            this.colREFTO.FieldName = "REFTO";
            this.colREFTO.Name = "colREFTO";
            this.colREFTO.OptionsColumn.AllowEdit = false;
            this.colREFTO.OptionsColumn.AllowFocus = false;
            this.colREFTO.OptionsColumn.FixedWidth = true;
            this.colREFTO.Visible = true;
            this.colREFTO.VisibleIndex = 13;
            this.colREFTO.Width = 34;
            // 
            // colREFID
            // 
            this.colREFID.Caption = "RefID";
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.AllowEdit = false;
            this.colREFID.OptionsColumn.AllowFocus = false;
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 14;
            this.colREFID.Width = 50;
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.AllowEdit = false;
            this.colUSR.OptionsColumn.AllowFocus = false;
            this.colUSR.Width = 95;
            // 
            // colINFO
            // 
            this.colINFO.Caption = "Açıklama";
            this.colINFO.FieldName = "INFO";
            this.colINFO.Name = "colINFO";
            this.colINFO.Visible = true;
            this.colINFO.VisibleIndex = 15;
            // 
            // TeklifFtrAlsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 315);
            this.Controls.Add(this.ftrAlsGridControl);
            this.Name = "TeklifFtrAlsXF";
            this.Text = "AlışChargeYarat [TeklifFtrAlsXF]";
            this.Load += new System.EventHandler(this.TeklifFtrAlsXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftrAlsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TURrepositoryItemImageComboBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource ftrAlsBindingSource;
        private TeklifDataSetTableAdapters.TKLF_FTR_ALS_SELTableAdapter ftrAlsTableAdapter;
        private DevExpress.XtraGrid.GridControl ftrAlsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ftrAlsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOPID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHM;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colAHTID;
        private DevExpress.XtraGrid.Columns.GridColumn colMIK;
        private DevExpress.XtraGrid.Columns.GridColumn colBRM;
        private DevExpress.XtraGrid.Columns.GridColumn colFYT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colKDY;
        private DevExpress.XtraGrid.Columns.GridColumn colMSJ;
        private DevExpress.XtraGrid.Columns.GridColumn colTOP;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createChargesToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colOK;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private System.Windows.Forms.ToolStripMenuItem ınsertToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TURrepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colINFO;
    }
}