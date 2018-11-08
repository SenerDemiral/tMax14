namespace tMax14.Pvt
{
    partial class KpiSetRprXF
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
            this.pvtDataSet = new tMax14.Pvt.PvtDataSet();
            this.kPI_SET_RPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kPI_SET_RPRTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.KPI_SET_RPRTableAdapter();
            this.kPI_SET_RPRGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colREFTBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKPIAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKPIUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKPITRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPI_SET_RPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPI_SET_RPRGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kPI_SET_RPRBindingSource
            // 
            this.kPI_SET_RPRBindingSource.DataMember = "KPI_SET_RPR";
            this.kPI_SET_RPRBindingSource.DataSource = this.pvtDataSet;
            // 
            // kPI_SET_RPRTableAdapter
            // 
            this.kPI_SET_RPRTableAdapter.ClearBeforeFill = true;
            // 
            // kPI_SET_RPRGridControl
            // 
            this.kPI_SET_RPRGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.kPI_SET_RPRGridControl.DataSource = this.kPI_SET_RPRBindingSource;
            this.kPI_SET_RPRGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kPI_SET_RPRGridControl.Location = new System.Drawing.Point(0, 0);
            this.kPI_SET_RPRGridControl.MainView = this.gridView1;
            this.kPI_SET_RPRGridControl.Name = "kPI_SET_RPRGridControl";
            this.kPI_SET_RPRGridControl.Size = new System.Drawing.Size(580, 317);
            this.kPI_SET_RPRGridControl.TabIndex = 2;
            this.kPI_SET_RPRGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colREFTBL,
            this.colREFID,
            this.colKPI,
            this.colKPIAD,
            this.colKPIUSR,
            this.colKPITRH});
            this.gridView1.GridControl = this.kPI_SET_RPRGridControl;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            // 
            // colREFTBL
            // 
            this.colREFTBL.AppearanceCell.Options.UseTextOptions = true;
            this.colREFTBL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFTBL.Caption = "Ref";
            this.colREFTBL.FieldName = "REFTBL";
            this.colREFTBL.Name = "colREFTBL";
            this.colREFTBL.OptionsColumn.FixedWidth = true;
            this.colREFTBL.Visible = true;
            this.colREFTBL.VisibleIndex = 0;
            this.colREFTBL.Width = 40;
            // 
            // colREFID
            // 
            this.colREFID.Caption = "RefID";
            this.colREFID.DisplayFormat.FormatString = "n0";
            this.colREFID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colREFID.FieldName = "REFID";
            this.colREFID.Name = "colREFID";
            this.colREFID.OptionsColumn.FixedWidth = true;
            this.colREFID.Visible = true;
            this.colREFID.VisibleIndex = 1;
            this.colREFID.Width = 60;
            // 
            // colKPI
            // 
            this.colKPI.FieldName = "KPI";
            this.colKPI.Name = "colKPI";
            this.colKPI.OptionsColumn.FixedWidth = true;
            this.colKPI.Visible = true;
            this.colKPI.VisibleIndex = 2;
            this.colKPI.Width = 100;
            // 
            // colKPIAD
            // 
            this.colKPIAD.Caption = "KpiAd";
            this.colKPIAD.FieldName = "KPIAD";
            this.colKPIAD.Name = "colKPIAD";
            this.colKPIAD.Visible = true;
            this.colKPIAD.VisibleIndex = 3;
            this.colKPIAD.Width = 151;
            // 
            // colKPIUSR
            // 
            this.colKPIUSR.Caption = "KpiUsr";
            this.colKPIUSR.FieldName = "KPIUSR";
            this.colKPIUSR.Name = "colKPIUSR";
            this.colKPIUSR.Visible = true;
            this.colKPIUSR.VisibleIndex = 4;
            this.colKPIUSR.Width = 111;
            // 
            // colKPITRH
            // 
            this.colKPITRH.Caption = "KpiTrh";
            this.colKPITRH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colKPITRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colKPITRH.FieldName = "KPITRH";
            this.colKPITRH.Name = "colKPITRH";
            this.colKPITRH.OptionsColumn.FixedWidth = true;
            this.colKPITRH.Visible = true;
            this.colKPITRH.VisibleIndex = 5;
            this.colKPITRH.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // KpiSetRprXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.kPI_SET_RPRGridControl);
            this.Name = "KpiSetRprXF";
            this.Text = "KpiSetRprXF";
            this.Load += new System.EventHandler(this.KpiSetRprXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPI_SET_RPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kPI_SET_RPRGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource kPI_SET_RPRBindingSource;
        private PvtDataSetTableAdapters.KPI_SET_RPRTableAdapter kPI_SET_RPRTableAdapter;
        private DevExpress.XtraGrid.GridControl kPI_SET_RPRGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colREFTBL;
        private DevExpress.XtraGrid.Columns.GridColumn colREFID;
        private DevExpress.XtraGrid.Columns.GridColumn colKPI;
        private DevExpress.XtraGrid.Columns.GridColumn colKPIUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colKPITRH;
        private DevExpress.XtraGrid.Columns.GridColumn colKPIAD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}