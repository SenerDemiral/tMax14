namespace tMax14agn
{
    partial class ophXF
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
            this.dataSet = new tMax14agn.DataSet();
            this.oPHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPHTableAdapter = new tMax14agn.DataSetTableAdapters.OPHTableAdapter();
            this.ophGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ophGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOPHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSHP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMNF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNFY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNF2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAGN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVM3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWBD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPODINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHNDINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORDINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGODINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCINF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANTRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALGTIPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOW = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEOH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDLV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ophGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPHBindingSource
            // 
            this.oPHBindingSource.DataMember = "OPH";
            this.oPHBindingSource.DataSource = this.dataSet;
            // 
            // oPHTableAdapter
            // 
            this.oPHTableAdapter.ClearBeforeFill = true;
            // 
            // ophGridControl
            // 
            this.ophGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.ophGridControl.DataSource = this.oPHBindingSource;
            this.ophGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ophGridControl.Location = new System.Drawing.Point(0, 0);
            this.ophGridControl.MainView = this.ophGridView;
            this.ophGridControl.Name = "ophGridControl";
            this.ophGridControl.Size = new System.Drawing.Size(958, 258);
            this.ophGridControl.TabIndex = 2;
            this.ophGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ophGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packagesToolStripMenuItem,
            this.updatesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(120, 48);
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.packagesToolStripMenuItem.Text = "Packages";
            this.packagesToolStripMenuItem.Click += new System.EventHandler(this.packagesToolStripMenuItem_Click);
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.updatesToolStripMenuItem.Text = "Updates";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // ophGridView
            // 
            this.ophGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPHID,
            this.colOPMID,
            this.colREFNO,
            this.colEXD,
            this.colROT,
            this.colMOT,
            this.colNSTU,
            this.colPSTU,
            this.colORG,
            this.colDST,
            this.colSHP,
            this.colMNF,
            this.colCNE,
            this.colNFY,
            this.colNF2,
            this.colAGN,
            this.colDCN,
            this.colNOP,
            this.colPCS,
            this.colVM3,
            this.colGRW,
            this.colCHW,
            this.colDTM,
            this.colDTP,
            this.colPTM,
            this.colPOR,
            this.colTOL,
            this.colPAG,
            this.colWBD,
            this.colRRT,
            this.colEOH,
            this.colAOH,
            this.colRTR,
            this.colATR,
            this.colBRD,
            this.colROS,
            this.colRTD,
            this.colPOD,
            this.colPODINF,
            this.colHNDINF,
            this.colORDINF,
            this.colGODINF,
            this.colDOCINF,
            this.colANTRP,
            this.colMALGTIPNO,
            this.colDOW,
            this.colREOH,
            this.colPEOH,
            this.colCCT,
            this.colEXPR,
            this.colDLV,
            this.colRCP});
            this.ophGridView.GridControl = this.ophGridControl;
            this.ophGridView.Name = "ophGridView";
            this.ophGridView.OptionsBehavior.Editable = false;
            this.ophGridView.OptionsView.ColumnAutoWidth = false;
            this.ophGridView.OptionsView.ShowFooter = true;
            // 
            // colOPHID
            // 
            this.colOPHID.FieldName = "OPHID";
            this.colOPHID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colOPHID.Name = "colOPHID";
            this.colOPHID.Visible = true;
            this.colOPHID.VisibleIndex = 0;
            // 
            // colOPMID
            // 
            this.colOPMID.FieldName = "OPMID";
            this.colOPMID.Name = "colOPMID";
            this.colOPMID.Visible = true;
            this.colOPMID.VisibleIndex = 1;
            // 
            // colREFNO
            // 
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 2;
            // 
            // colEXD
            // 
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 3;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 4;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 5;
            // 
            // colNSTU
            // 
            this.colNSTU.FieldName = "NSTU";
            this.colNSTU.Name = "colNSTU";
            this.colNSTU.Visible = true;
            this.colNSTU.VisibleIndex = 6;
            // 
            // colPSTU
            // 
            this.colPSTU.FieldName = "PSTU";
            this.colPSTU.Name = "colPSTU";
            this.colPSTU.Visible = true;
            this.colPSTU.VisibleIndex = 7;
            // 
            // colORG
            // 
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 8;
            // 
            // colDST
            // 
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 9;
            // 
            // colSHP
            // 
            this.colSHP.FieldName = "SHP";
            this.colSHP.Name = "colSHP";
            this.colSHP.Visible = true;
            this.colSHP.VisibleIndex = 10;
            // 
            // colMNF
            // 
            this.colMNF.FieldName = "MNF";
            this.colMNF.Name = "colMNF";
            this.colMNF.Visible = true;
            this.colMNF.VisibleIndex = 11;
            // 
            // colCNE
            // 
            this.colCNE.FieldName = "CNE";
            this.colCNE.Name = "colCNE";
            this.colCNE.Visible = true;
            this.colCNE.VisibleIndex = 12;
            // 
            // colNFY
            // 
            this.colNFY.FieldName = "NFY";
            this.colNFY.Name = "colNFY";
            this.colNFY.Visible = true;
            this.colNFY.VisibleIndex = 13;
            // 
            // colNF2
            // 
            this.colNF2.FieldName = "NF2";
            this.colNF2.Name = "colNF2";
            this.colNF2.Visible = true;
            this.colNF2.VisibleIndex = 14;
            // 
            // colAGN
            // 
            this.colAGN.FieldName = "AGN";
            this.colAGN.Name = "colAGN";
            this.colAGN.Visible = true;
            this.colAGN.VisibleIndex = 15;
            // 
            // colDCN
            // 
            this.colDCN.FieldName = "DCN";
            this.colDCN.Name = "colDCN";
            this.colDCN.Visible = true;
            this.colDCN.VisibleIndex = 16;
            // 
            // colNOP
            // 
            this.colNOP.FieldName = "NOP";
            this.colNOP.Name = "colNOP";
            this.colNOP.Visible = true;
            this.colNOP.VisibleIndex = 17;
            // 
            // colPCS
            // 
            this.colPCS.FieldName = "PCS";
            this.colPCS.Name = "colPCS";
            this.colPCS.Visible = true;
            this.colPCS.VisibleIndex = 18;
            // 
            // colVM3
            // 
            this.colVM3.FieldName = "VM3";
            this.colVM3.Name = "colVM3";
            this.colVM3.Visible = true;
            this.colVM3.VisibleIndex = 19;
            // 
            // colGRW
            // 
            this.colGRW.FieldName = "GRW";
            this.colGRW.Name = "colGRW";
            this.colGRW.ToolTip = "Gross Weight";
            this.colGRW.Visible = true;
            this.colGRW.VisibleIndex = 20;
            // 
            // colCHW
            // 
            this.colCHW.FieldName = "CHW";
            this.colCHW.Name = "colCHW";
            this.colCHW.ToolTip = "Chargable Weight";
            this.colCHW.Visible = true;
            this.colCHW.VisibleIndex = 21;
            // 
            // colDTM
            // 
            this.colDTM.FieldName = "DTM";
            this.colDTM.Name = "colDTM";
            this.colDTM.ToolTip = "Delivery Terms";
            this.colDTM.Visible = true;
            this.colDTM.VisibleIndex = 22;
            // 
            // colDTP
            // 
            this.colDTP.FieldName = "DTP";
            this.colDTP.Name = "colDTP";
            this.colDTP.ToolTip = "Delivery Terms Payment";
            this.colDTP.Visible = true;
            this.colDTP.VisibleIndex = 23;
            // 
            // colPTM
            // 
            this.colPTM.FieldName = "PTM";
            this.colPTM.Name = "colPTM";
            this.colPTM.ToolTip = "Payment Terms";
            this.colPTM.Visible = true;
            this.colPTM.VisibleIndex = 24;
            // 
            // colPOR
            // 
            this.colPOR.FieldName = "POR";
            this.colPOR.Name = "colPOR";
            this.colPOR.Visible = true;
            this.colPOR.VisibleIndex = 25;
            // 
            // colTOL
            // 
            this.colTOL.FieldName = "TOL";
            this.colTOL.Name = "colTOL";
            this.colTOL.ToolTip = "Type of Loading";
            this.colTOL.Visible = true;
            this.colTOL.VisibleIndex = 26;
            // 
            // colPAG
            // 
            this.colPAG.FieldName = "PAG";
            this.colPAG.Name = "colPAG";
            this.colPAG.Visible = true;
            this.colPAG.VisibleIndex = 27;
            // 
            // colWBD
            // 
            this.colWBD.FieldName = "WBD";
            this.colWBD.Name = "colWBD";
            this.colWBD.Visible = true;
            this.colWBD.VisibleIndex = 28;
            // 
            // colRRT
            // 
            this.colRRT.FieldName = "RRT";
            this.colRRT.Name = "colRRT";
            this.colRRT.Visible = true;
            this.colRRT.VisibleIndex = 29;
            // 
            // colEOH
            // 
            this.colEOH.FieldName = "EOH";
            this.colEOH.Name = "colEOH";
            this.colEOH.Visible = true;
            this.colEOH.VisibleIndex = 30;
            // 
            // colAOH
            // 
            this.colAOH.FieldName = "AOH";
            this.colAOH.Name = "colAOH";
            this.colAOH.Visible = true;
            this.colAOH.VisibleIndex = 31;
            // 
            // colRTR
            // 
            this.colRTR.FieldName = "RTR";
            this.colRTR.Name = "colRTR";
            this.colRTR.Visible = true;
            this.colRTR.VisibleIndex = 32;
            // 
            // colATR
            // 
            this.colATR.FieldName = "ATR";
            this.colATR.Name = "colATR";
            this.colATR.Visible = true;
            this.colATR.VisibleIndex = 33;
            // 
            // colBRD
            // 
            this.colBRD.FieldName = "BRD";
            this.colBRD.Name = "colBRD";
            this.colBRD.Visible = true;
            this.colBRD.VisibleIndex = 34;
            // 
            // colROS
            // 
            this.colROS.FieldName = "ROS";
            this.colROS.Name = "colROS";
            this.colROS.Visible = true;
            this.colROS.VisibleIndex = 35;
            // 
            // colRTD
            // 
            this.colRTD.FieldName = "RTD";
            this.colRTD.Name = "colRTD";
            this.colRTD.Visible = true;
            this.colRTD.VisibleIndex = 36;
            // 
            // colPOD
            // 
            this.colPOD.FieldName = "POD";
            this.colPOD.Name = "colPOD";
            this.colPOD.Visible = true;
            this.colPOD.VisibleIndex = 37;
            // 
            // colPODINF
            // 
            this.colPODINF.FieldName = "PODINF";
            this.colPODINF.Name = "colPODINF";
            this.colPODINF.Visible = true;
            this.colPODINF.VisibleIndex = 38;
            // 
            // colHNDINF
            // 
            this.colHNDINF.FieldName = "HNDINF";
            this.colHNDINF.Name = "colHNDINF";
            this.colHNDINF.Visible = true;
            this.colHNDINF.VisibleIndex = 39;
            // 
            // colORDINF
            // 
            this.colORDINF.FieldName = "ORDINF";
            this.colORDINF.Name = "colORDINF";
            this.colORDINF.Visible = true;
            this.colORDINF.VisibleIndex = 40;
            // 
            // colGODINF
            // 
            this.colGODINF.FieldName = "GODINF";
            this.colGODINF.Name = "colGODINF";
            this.colGODINF.Visible = true;
            this.colGODINF.VisibleIndex = 41;
            // 
            // colDOCINF
            // 
            this.colDOCINF.FieldName = "DOCINF";
            this.colDOCINF.Name = "colDOCINF";
            this.colDOCINF.Visible = true;
            this.colDOCINF.VisibleIndex = 42;
            // 
            // colANTRP
            // 
            this.colANTRP.FieldName = "ANTRP";
            this.colANTRP.Name = "colANTRP";
            this.colANTRP.Visible = true;
            this.colANTRP.VisibleIndex = 43;
            // 
            // colMALGTIPNO
            // 
            this.colMALGTIPNO.FieldName = "MALGTIPNO";
            this.colMALGTIPNO.Name = "colMALGTIPNO";
            this.colMALGTIPNO.Visible = true;
            this.colMALGTIPNO.VisibleIndex = 44;
            this.colMALGTIPNO.Width = 78;
            // 
            // colDOW
            // 
            this.colDOW.FieldName = "DOW";
            this.colDOW.Name = "colDOW";
            this.colDOW.Visible = true;
            this.colDOW.VisibleIndex = 45;
            // 
            // colREOH
            // 
            this.colREOH.FieldName = "REOH";
            this.colREOH.Name = "colREOH";
            this.colREOH.Visible = true;
            this.colREOH.VisibleIndex = 46;
            // 
            // colPEOH
            // 
            this.colPEOH.FieldName = "PEOH";
            this.colPEOH.Name = "colPEOH";
            this.colPEOH.Visible = true;
            this.colPEOH.VisibleIndex = 47;
            // 
            // colCCT
            // 
            this.colCCT.FieldName = "CCT";
            this.colCCT.Name = "colCCT";
            this.colCCT.Visible = true;
            this.colCCT.VisibleIndex = 48;
            // 
            // colEXPR
            // 
            this.colEXPR.FieldName = "EXPR";
            this.colEXPR.Name = "colEXPR";
            this.colEXPR.ToolTip = "Express";
            this.colEXPR.Visible = true;
            this.colEXPR.VisibleIndex = 49;
            // 
            // colDLV
            // 
            this.colDLV.FieldName = "DLV";
            this.colDLV.Name = "colDLV";
            this.colDLV.ToolTip = "Delivery to";
            this.colDLV.Visible = true;
            this.colDLV.VisibleIndex = 50;
            // 
            // colRCP
            // 
            this.colRCP.FieldName = "RCP";
            this.colRCP.Name = "colRCP";
            this.colRCP.ToolTip = "Receipt from";
            this.colRCP.Visible = true;
            this.colRCP.VisibleIndex = 51;
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            this.dockManager.ClosedPanel += new DevExpress.XtraBars.Docking.DockPanelEventHandler(this.dockManager_ClosedPanel);
            // 
            // ophXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 258);
            this.Controls.Add(this.ophGridControl);
            this.Name = "ophXF";
            this.Text = "Houses";
            this.Load += new System.EventHandler(this.ophXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ophGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ophGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource oPHBindingSource;
        private DataSetTableAdapters.OPHTableAdapter oPHTableAdapter;
        private DevExpress.XtraGrid.GridControl ophGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ophGridView;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colOPHID;
        private DevExpress.XtraGrid.Columns.GridColumn colOPMID;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colSHP;
        private DevExpress.XtraGrid.Columns.GridColumn colMNF;
        private DevExpress.XtraGrid.Columns.GridColumn colCNE;
        private DevExpress.XtraGrid.Columns.GridColumn colNFY;
        private DevExpress.XtraGrid.Columns.GridColumn colNF2;
        private DevExpress.XtraGrid.Columns.GridColumn colAGN;
        private DevExpress.XtraGrid.Columns.GridColumn colDCN;
        private DevExpress.XtraGrid.Columns.GridColumn colNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPCS;
        private DevExpress.XtraGrid.Columns.GridColumn colVM3;
        private DevExpress.XtraGrid.Columns.GridColumn colGRW;
        private DevExpress.XtraGrid.Columns.GridColumn colCHW;
        private DevExpress.XtraGrid.Columns.GridColumn colDTM;
        private DevExpress.XtraGrid.Columns.GridColumn colDTP;
        private DevExpress.XtraGrid.Columns.GridColumn colPTM;
        private DevExpress.XtraGrid.Columns.GridColumn colPOR;
        private DevExpress.XtraGrid.Columns.GridColumn colTOL;
        private DevExpress.XtraGrid.Columns.GridColumn colPAG;
        private DevExpress.XtraGrid.Columns.GridColumn colWBD;
        private DevExpress.XtraGrid.Columns.GridColumn colRRT;
        private DevExpress.XtraGrid.Columns.GridColumn colEOH;
        private DevExpress.XtraGrid.Columns.GridColumn colAOH;
        private DevExpress.XtraGrid.Columns.GridColumn colRTR;
        private DevExpress.XtraGrid.Columns.GridColumn colATR;
        private DevExpress.XtraGrid.Columns.GridColumn colBRD;
        private DevExpress.XtraGrid.Columns.GridColumn colROS;
        private DevExpress.XtraGrid.Columns.GridColumn colRTD;
        private DevExpress.XtraGrid.Columns.GridColumn colPOD;
        private DevExpress.XtraGrid.Columns.GridColumn colPODINF;
        private DevExpress.XtraGrid.Columns.GridColumn colHNDINF;
        private DevExpress.XtraGrid.Columns.GridColumn colORDINF;
        private DevExpress.XtraGrid.Columns.GridColumn colGODINF;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCINF;
        private DevExpress.XtraGrid.Columns.GridColumn colANTRP;
        private DevExpress.XtraGrid.Columns.GridColumn colMALGTIPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOW;
        private DevExpress.XtraGrid.Columns.GridColumn colREOH;
        private DevExpress.XtraGrid.Columns.GridColumn colPEOH;
        private DevExpress.XtraGrid.Columns.GridColumn colCCT;
        private DevExpress.XtraGrid.Columns.GridColumn colEXPR;
        private DevExpress.XtraGrid.Columns.GridColumn colDLV;
        private DevExpress.XtraGrid.Columns.GridColumn colRCP;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
    }
}