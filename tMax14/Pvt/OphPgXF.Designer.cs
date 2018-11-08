namespace tMax14.Pvt
{
    partial class OphPgXF
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
            this.oPH_PGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPH_PGTableAdapter = new tMax14.Pvt.PvtDataSetTableAdapters.OPH_PGTableAdapter();
            this.ophPgGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNTNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMETA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCABW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMRTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOD = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPH_PGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophPgGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pvtDataSet
            // 
            this.pvtDataSet.DataSetName = "PvtDataSet";
            this.pvtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPH_PGBindingSource
            // 
            this.oPH_PGBindingSource.DataMember = "OPH_PG";
            this.oPH_PGBindingSource.DataSource = this.pvtDataSet;
            // 
            // oPH_PGTableAdapter
            // 
            this.oPH_PGTableAdapter.ClearBeforeFill = true;
            // 
            // ophPgGridControl
            // 
            this.ophPgGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.ophPgGridControl.DataSource = this.oPH_PGBindingSource;
            this.ophPgGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ophPgGridControl.Location = new System.Drawing.Point(0, 0);
            this.ophPgGridControl.MainView = this.gridView1;
            this.ophPgGridControl.Name = "ophPgGridControl";
            this.ophPgGridControl.Size = new System.Drawing.Size(1321, 325);
            this.ophPgGridControl.TabIndex = 2;
            this.ophPgGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHID,
            this.colMID,
            this.colAOH,
            this.colORG,
            this.colCNTNO,
            this.colORDINF,
            this.colNSTU,
            this.colROS,
            this.colMORG,
            this.colMATD,
            this.colMDST,
            this.colMETA,
            this.colMATA,
            this.colCABW,
            this.colDRBD,
            this.colRTR,
            this.colROH,
            this.colMRTD,
            this.colPOD});
            this.gridView1.GridControl = this.ophPgGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colHID
            // 
            this.colHID.AppearanceCell.Options.UseTextOptions = true;
            this.colHID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.Width = 50;
            // 
            // colMID
            // 
            this.colMID.AppearanceCell.Options.UseTextOptions = true;
            this.colMID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMID.AppearanceHeader.Options.UseTextOptions = true;
            this.colMID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.Width = 50;
            // 
            // colAOH
            // 
            this.colAOH.AppearanceCell.Options.UseTextOptions = true;
            this.colAOH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAOH.AppearanceHeader.Options.UseTextOptions = true;
            this.colAOH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAOH.Caption = "Loading Date";
            this.colAOH.FieldName = "AOH";
            this.colAOH.Name = "colAOH";
            this.colAOH.Visible = true;
            this.colAOH.VisibleIndex = 0;
            this.colAOH.Width = 73;
            // 
            // colORG
            // 
            this.colORG.AppearanceCell.Options.UseTextOptions = true;
            this.colORG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colORG.AppearanceHeader.Options.UseTextOptions = true;
            this.colORG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colORG.Caption = "Loading Place";
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 1;
            this.colORG.Width = 73;
            // 
            // colCNTNO
            // 
            this.colCNTNO.AppearanceCell.Options.UseTextOptions = true;
            this.colCNTNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNTNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colCNTNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCNTNO.Caption = "Container Number";
            this.colCNTNO.FieldName = "CNTNO";
            this.colCNTNO.Name = "colCNTNO";
            this.colCNTNO.Visible = true;
            this.colCNTNO.VisibleIndex = 2;
            this.colCNTNO.Width = 73;
            // 
            // colORDINF
            // 
            this.colORDINF.AppearanceCell.Options.UseTextOptions = true;
            this.colORDINF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colORDINF.AppearanceHeader.Options.UseTextOptions = true;
            this.colORDINF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colORDINF.Caption = "Client Reference";
            this.colORDINF.FieldName = "ORDINF";
            this.colORDINF.Name = "colORDINF";
            this.colORDINF.Visible = true;
            this.colORDINF.VisibleIndex = 3;
            this.colORDINF.Width = 73;
            // 
            // colNSTU
            // 
            this.colNSTU.AppearanceCell.Options.UseTextOptions = true;
            this.colNSTU.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNSTU.AppearanceHeader.Options.UseTextOptions = true;
            this.colNSTU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNSTU.Caption = "Status";
            this.colNSTU.FieldName = "NSTU";
            this.colNSTU.Name = "colNSTU";
            this.colNSTU.Visible = true;
            this.colNSTU.VisibleIndex = 4;
            this.colNSTU.Width = 73;
            // 
            // colROS
            // 
            this.colROS.AppearanceCell.Options.UseTextOptions = true;
            this.colROS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROS.AppearanceHeader.Options.UseTextOptions = true;
            this.colROS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROS.Caption = "Requested Delivery Date at Site";
            this.colROS.FieldName = "ROS";
            this.colROS.Name = "colROS";
            this.colROS.Visible = true;
            this.colROS.VisibleIndex = 5;
            this.colROS.Width = 88;
            // 
            // colMORG
            // 
            this.colMORG.AppearanceCell.Options.UseTextOptions = true;
            this.colMORG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMORG.AppearanceHeader.Options.UseTextOptions = true;
            this.colMORG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMORG.Caption = "Rail Departure";
            this.colMORG.FieldName = "MORG";
            this.colMORG.Name = "colMORG";
            this.colMORG.Visible = true;
            this.colMORG.VisibleIndex = 6;
            this.colMORG.Width = 73;
            // 
            // colMATD
            // 
            this.colMATD.AppearanceCell.Options.UseTextOptions = true;
            this.colMATD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMATD.AppearanceHeader.Options.UseTextOptions = true;
            this.colMATD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMATD.Caption = "Rail Departure Date";
            this.colMATD.FieldName = "MATD";
            this.colMATD.Name = "colMATD";
            this.colMATD.Visible = true;
            this.colMATD.VisibleIndex = 7;
            this.colMATD.Width = 73;
            // 
            // colMDST
            // 
            this.colMDST.AppearanceCell.Options.UseTextOptions = true;
            this.colMDST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMDST.AppearanceHeader.Options.UseTextOptions = true;
            this.colMDST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMDST.Caption = "Rail Arrival";
            this.colMDST.FieldName = "MDST";
            this.colMDST.Name = "colMDST";
            this.colMDST.Visible = true;
            this.colMDST.VisibleIndex = 8;
            this.colMDST.Width = 73;
            // 
            // colMETA
            // 
            this.colMETA.AppearanceCell.Options.UseTextOptions = true;
            this.colMETA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMETA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMETA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMETA.Caption = "Expected Rail Arrival Date TR";
            this.colMETA.FieldName = "META";
            this.colMETA.Name = "colMETA";
            this.colMETA.Visible = true;
            this.colMETA.VisibleIndex = 9;
            this.colMETA.Width = 73;
            // 
            // colMATA
            // 
            this.colMATA.AppearanceCell.Options.UseTextOptions = true;
            this.colMATA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMATA.AppearanceHeader.Options.UseTextOptions = true;
            this.colMATA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMATA.Caption = "Actual Rail Arrival Date TR";
            this.colMATA.FieldName = "MATA";
            this.colMATA.Name = "colMATA";
            this.colMATA.Visible = true;
            this.colMATA.VisibleIndex = 10;
            this.colMATA.Width = 73;
            // 
            // colCABW
            // 
            this.colCABW.AppearanceCell.Options.UseTextOptions = true;
            this.colCABW.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCABW.AppearanceHeader.Options.UseTextOptions = true;
            this.colCABW.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCABW.Caption = "Customs at Bonded Warehouse Y/N";
            this.colCABW.FieldName = "CABW";
            this.colCABW.Name = "colCABW";
            this.colCABW.Visible = true;
            this.colCABW.VisibleIndex = 11;
            this.colCABW.Width = 76;
            // 
            // colDRBD
            // 
            this.colDRBD.AppearanceCell.Options.UseTextOptions = true;
            this.colDRBD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDRBD.AppearanceHeader.Options.UseTextOptions = true;
            this.colDRBD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDRBD.Caption = "Custom docs Relased to Client";
            this.colDRBD.FieldName = "DRBD";
            this.colDRBD.Name = "colDRBD";
            this.colDRBD.Visible = true;
            this.colDRBD.VisibleIndex = 12;
            this.colDRBD.Width = 82;
            // 
            // colRTR
            // 
            this.colRTR.AppearanceCell.Options.UseTextOptions = true;
            this.colRTR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRTR.AppearanceHeader.Options.UseTextOptions = true;
            this.colRTR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRTR.Caption = "Customs Completed";
            this.colRTR.FieldName = "RTR";
            this.colRTR.Name = "colRTR";
            this.colRTR.Visible = true;
            this.colRTR.VisibleIndex = 13;
            this.colRTR.Width = 73;
            // 
            // colROH
            // 
            this.colROH.AppearanceCell.Options.UseTextOptions = true;
            this.colROH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROH.AppearanceHeader.Options.UseTextOptions = true;
            this.colROH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROH.Caption = "Delivery-slot Booked at Site";
            this.colROH.FieldName = "ROH";
            this.colROH.Name = "colROH";
            this.colROH.Visible = true;
            this.colROH.VisibleIndex = 14;
            this.colROH.Width = 81;
            // 
            // colMRTD
            // 
            this.colMRTD.AppearanceCell.Options.UseTextOptions = true;
            this.colMRTD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMRTD.AppearanceHeader.Options.UseTextOptions = true;
            this.colMRTD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMRTD.Caption = "Arrival at Site for Unloading";
            this.colMRTD.FieldName = "MRTD";
            this.colMRTD.Name = "colMRTD";
            this.colMRTD.Visible = true;
            this.colMRTD.VisibleIndex = 15;
            this.colMRTD.Width = 73;
            // 
            // colPOD
            // 
            this.colPOD.AppearanceCell.Options.UseTextOptions = true;
            this.colPOD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPOD.AppearanceHeader.Options.UseTextOptions = true;
            this.colPOD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPOD.Caption = "Unloading Completed";
            this.colPOD.FieldName = "POD";
            this.colPOD.Name = "colPOD";
            this.colPOD.Visible = true;
            this.colPOD.VisibleIndex = 16;
            this.colPOD.Width = 96;
            // 
            // OphPgXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 325);
            this.Controls.Add(this.ophPgGridControl);
            this.Name = "OphPgXF";
            this.Text = "OphPgXF";
            this.Load += new System.EventHandler(this.OphPgXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pvtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPH_PGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophPgGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PvtDataSet pvtDataSet;
        private System.Windows.Forms.BindingSource oPH_PGBindingSource;
        private PvtDataSetTableAdapters.OPH_PGTableAdapter oPH_PGTableAdapter;
        private DevExpress.XtraGrid.GridControl ophPgGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colAOH;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colCNTNO;
        private DevExpress.XtraGrid.Columns.GridColumn colORDINF;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colROS;
        private DevExpress.XtraGrid.Columns.GridColumn colMORG;
        private DevExpress.XtraGrid.Columns.GridColumn colMATD;
        private DevExpress.XtraGrid.Columns.GridColumn colMDST;
        private DevExpress.XtraGrid.Columns.GridColumn colMETA;
        private DevExpress.XtraGrid.Columns.GridColumn colMATA;
        private DevExpress.XtraGrid.Columns.GridColumn colCABW;
        private DevExpress.XtraGrid.Columns.GridColumn colDRBD;
        private DevExpress.XtraGrid.Columns.GridColumn colRTR;
        private DevExpress.XtraGrid.Columns.GridColumn colROH;
        private DevExpress.XtraGrid.Columns.GridColumn colMRTD;
        private DevExpress.XtraGrid.Columns.GridColumn colPOD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}