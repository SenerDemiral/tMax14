namespace tMax14.Pvt
{
    partial class rprCMgridFX
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
            this.rPR_CM_GRIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPR_CM_GRIDTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.RPR_CM_GRIDTableAdapter();
            this.tableAdapterManager = new tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOTHINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_PRTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_SITENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_SNDINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_DIW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOTF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_NOTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_CM_GRIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPR_CM_GRIDBindingSource
            // 
            this.rPR_CM_GRIDBindingSource.DataMember = "RPR_CM_GRID";
            this.rPR_CM_GRIDBindingSource.DataSource = this.pvtDataSet;
            // 
            // rPR_CM_GRIDTableAdapter
            // 
            this.rPR_CM_GRIDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.RPR_TRACING_DTYTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tMax14.Pvt.PvtDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // GridControl
            // 
            this.GridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.GridControl.DataSource = this.rPR_CM_GRIDBindingSource;
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Location = new System.Drawing.Point(0, 0);
            this.GridControl.MainView = this.gridView1;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(1266, 294);
            this.GridControl.TabIndex = 2;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMID,
            this.colHID,
            this.colREFNO,
            this.colCNE,
            this.colBRD,
            this.colAOH,
            this.colGRW,
            this.colOTHINF,
            this.colB_PRTNO,
            this.colB_SITENO,
            this.colB_SNDINFO,
            this.colB_NOF,
            this.colB_NOA,
            this.colB_NOR,
            this.colB_DIW,
            this.colB_NOTF,
            this.colB_NOTA,
            this.colB_NOTR,
            this.colTOPS});
            this.gridView1.GridControl = this.GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMID
            // 
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.Width = 62;
            // 
            // colHID
            // 
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.Width = 62;
            // 
            // colREFNO
            // 
            this.colREFNO.Caption = "HAWB";
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 0;
            this.colREFNO.Width = 62;
            // 
            // colCNE
            // 
            this.colCNE.Caption = "Consignee";
            this.colCNE.FieldName = "CNE";
            this.colCNE.Name = "colCNE";
            this.colCNE.Visible = true;
            this.colCNE.VisibleIndex = 1;
            this.colCNE.Width = 62;
            // 
            // colBRD
            // 
            this.colBRD.Caption = "Booked";
            this.colBRD.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colBRD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colBRD.FieldName = "BRD";
            this.colBRD.Name = "colBRD";
            this.colBRD.OptionsColumn.FixedWidth = true;
            this.colBRD.Visible = true;
            this.colBRD.VisibleIndex = 11;
            this.colBRD.Width = 87;
            // 
            // colAOH
            // 
            this.colAOH.Caption = "PU";
            this.colAOH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colAOH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colAOH.FieldName = "AOH";
            this.colAOH.Name = "colAOH";
            this.colAOH.OptionsColumn.FixedWidth = true;
            this.colAOH.Visible = true;
            this.colAOH.VisibleIndex = 12;
            this.colAOH.Width = 87;
            // 
            // colGRW
            // 
            this.colGRW.Caption = "GrW";
            this.colGRW.FieldName = "GRW";
            this.colGRW.Name = "colGRW";
            this.colGRW.OptionsColumn.FixedWidth = true;
            this.colGRW.Visible = true;
            this.colGRW.VisibleIndex = 13;
            this.colGRW.Width = 40;
            // 
            // colOTHINF
            // 
            this.colOTHINF.Caption = "Comment";
            this.colOTHINF.FieldName = "OTHINF";
            this.colOTHINF.Name = "colOTHINF";
            this.colOTHINF.Visible = true;
            this.colOTHINF.VisibleIndex = 16;
            this.colOTHINF.Width = 171;
            // 
            // colB_PRTNO
            // 
            this.colB_PRTNO.Caption = "Protocol#";
            this.colB_PRTNO.FieldName = "B_PRTNO";
            this.colB_PRTNO.Name = "colB_PRTNO";
            this.colB_PRTNO.Visible = true;
            this.colB_PRTNO.VisibleIndex = 2;
            this.colB_PRTNO.Width = 62;
            // 
            // colB_SITENO
            // 
            this.colB_SITENO.Caption = "Site";
            this.colB_SITENO.FieldName = "B_SITENO";
            this.colB_SITENO.Name = "colB_SITENO";
            this.colB_SITENO.Visible = true;
            this.colB_SITENO.VisibleIndex = 3;
            this.colB_SITENO.Width = 62;
            // 
            // colB_SNDINFO
            // 
            this.colB_SNDINFO.Caption = "Booked by";
            this.colB_SNDINFO.FieldName = "B_SNDINFO";
            this.colB_SNDINFO.Name = "colB_SNDINFO";
            this.colB_SNDINFO.Visible = true;
            this.colB_SNDINFO.VisibleIndex = 10;
            this.colB_SNDINFO.Width = 87;
            // 
            // colB_NOF
            // 
            this.colB_NOF.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOF.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOF.Caption = "#BF";
            this.colB_NOF.FieldName = "B_NOF";
            this.colB_NOF.Name = "colB_NOF";
            this.colB_NOF.OptionsColumn.FixedWidth = true;
            this.colB_NOF.Visible = true;
            this.colB_NOF.VisibleIndex = 8;
            this.colB_NOF.Width = 40;
            // 
            // colB_NOA
            // 
            this.colB_NOA.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOA.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOA.Caption = "#BA";
            this.colB_NOA.FieldName = "B_NOA";
            this.colB_NOA.Name = "colB_NOA";
            this.colB_NOA.OptionsColumn.FixedWidth = true;
            this.colB_NOA.Visible = true;
            this.colB_NOA.VisibleIndex = 7;
            this.colB_NOA.Width = 40;
            // 
            // colB_NOR
            // 
            this.colB_NOR.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOR.Caption = "#BR";
            this.colB_NOR.FieldName = "B_NOR";
            this.colB_NOR.Name = "colB_NOR";
            this.colB_NOR.OptionsColumn.FixedWidth = true;
            this.colB_NOR.Visible = true;
            this.colB_NOR.VisibleIndex = 9;
            this.colB_NOR.Width = 40;
            // 
            // colB_DIW
            // 
            this.colB_DIW.Caption = "DI Kg";
            this.colB_DIW.FieldName = "B_DIW";
            this.colB_DIW.Name = "colB_DIW";
            this.colB_DIW.OptionsColumn.FixedWidth = true;
            this.colB_DIW.Visible = true;
            this.colB_DIW.VisibleIndex = 14;
            this.colB_DIW.Width = 40;
            // 
            // colB_NOTF
            // 
            this.colB_NOTF.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOTF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTF.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOTF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTF.Caption = "#VF";
            this.colB_NOTF.FieldName = "B_NOTF";
            this.colB_NOTF.Name = "colB_NOTF";
            this.colB_NOTF.OptionsColumn.FixedWidth = true;
            this.colB_NOTF.Visible = true;
            this.colB_NOTF.VisibleIndex = 5;
            this.colB_NOTF.Width = 40;
            // 
            // colB_NOTA
            // 
            this.colB_NOTA.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOTA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTA.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTA.Caption = "#VA";
            this.colB_NOTA.FieldName = "B_NOTA";
            this.colB_NOTA.Name = "colB_NOTA";
            this.colB_NOTA.OptionsColumn.FixedWidth = true;
            this.colB_NOTA.Visible = true;
            this.colB_NOTA.VisibleIndex = 4;
            this.colB_NOTA.Width = 40;
            // 
            // colB_NOTR
            // 
            this.colB_NOTR.AppearanceCell.Options.UseTextOptions = true;
            this.colB_NOTR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTR.AppearanceHeader.Options.UseTextOptions = true;
            this.colB_NOTR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colB_NOTR.Caption = "#VR";
            this.colB_NOTR.FieldName = "B_NOTR";
            this.colB_NOTR.Name = "colB_NOTR";
            this.colB_NOTR.OptionsColumn.FixedWidth = true;
            this.colB_NOTR.Visible = true;
            this.colB_NOTR.VisibleIndex = 6;
            this.colB_NOTR.Width = 40;
            // 
            // colTOPS
            // 
            this.colTOPS.Caption = "Boxes provided";
            this.colTOPS.FieldName = "TOPS";
            this.colTOPS.Name = "colTOPS";
            this.colTOPS.Visible = true;
            this.colTOPS.VisibleIndex = 15;
            this.colTOPS.Width = 124;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // rprCMgridFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 294);
            this.Controls.Add(this.GridControl);
            this.Name = "rprCMgridFX";
            this.Text = "rprCMgridFX";
            this.Load += new System.EventHandler(this.rprCMgridFX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPR_CM_GRIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource rPR_CM_GRIDBindingSource;
        private PvtDataSetTableAdapters.RPR_CM_GRIDTableAdapter rPR_CM_GRIDTableAdapter;
        private PvtDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colBRD;
        private DevExpress.XtraGrid.Columns.GridColumn colAOH;
        private DevExpress.XtraGrid.Columns.GridColumn colGRW;
        private DevExpress.XtraGrid.Columns.GridColumn colOTHINF;
        private DevExpress.XtraGrid.Columns.GridColumn colB_PRTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_SITENO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_SNDINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOF;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOA;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOR;
        private DevExpress.XtraGrid.Columns.GridColumn colB_DIW;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOTF;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOTA;
        private DevExpress.XtraGrid.Columns.GridColumn colB_NOTR;
        private DevExpress.XtraGrid.Columns.GridColumn colTOPS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}