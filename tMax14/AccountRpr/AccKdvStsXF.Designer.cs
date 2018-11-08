namespace tMax14.AccountRpr
{
    partial class AccKdvStsXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.accKdvStsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCC_KDV_STSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAFBID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTVRGNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUR3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTUTTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFKARNENOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVHCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.aCC_KDV_STSTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_KDV_STSTableAdapter();
            this.colMATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMCIKKAPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMVRSGMRK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accKdvStsGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCC_KDV_STSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.accKdvStsGridControl);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1096, 362);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // accKdvStsGridControl
            // 
            this.accKdvStsGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.accKdvStsGridControl.DataSource = this.aCC_KDV_STSBindingSource;
            this.accKdvStsGridControl.Location = new System.Drawing.Point(12, 38);
            this.accKdvStsGridControl.MainView = this.gridView1;
            this.accKdvStsGridControl.Name = "accKdvStsGridControl";
            this.accKdvStsGridControl.Size = new System.Drawing.Size(1072, 312);
            this.accKdvStsGridControl.TabIndex = 6;
            this.accKdvStsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(145, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // aCC_KDV_STSBindingSource
            // 
            this.aCC_KDV_STSBindingSource.DataMember = "ACC_KDV_STS";
            this.aCC_KDV_STSBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAFBID,
            this.colFRTID,
            this.colFRTAD,
            this.colFRTVRGNO,
            this.colTUR,
            this.colTUR2,
            this.colTUR3,
            this.colFTRNO,
            this.colFTRTRH,
            this.colFTRDVZ,
            this.colFTRTUT,
            this.colAKUR,
            this.colFTRTUTTL,
            this.colATDS,
            this.colREFKARNENOS,
            this.colVHCS,
            this.colORGS,
            this.colDSTS,
            this.colOPS,
            this.colMATA,
            this.colMCIKKAPI,
            this.colMVRSGMRK});
            this.gridView1.GridControl = this.accKdvStsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colAFBID
            // 
            this.colAFBID.FieldName = "AFBID";
            this.colAFBID.Name = "colAFBID";
            this.colAFBID.Visible = true;
            this.colAFBID.VisibleIndex = 0;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            // 
            // colFRTAD
            // 
            this.colFRTAD.Caption = "Firma";
            this.colFRTAD.FieldName = "FRTAD";
            this.colFRTAD.Name = "colFRTAD";
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 2;
            // 
            // colFRTVRGNO
            // 
            this.colFRTVRGNO.Caption = "VergiNo";
            this.colFRTVRGNO.FieldName = "FRTVRGNO";
            this.colFRTVRGNO.Name = "colFRTVRGNO";
            this.colFRTVRGNO.Visible = true;
            this.colFRTVRGNO.VisibleIndex = 3;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 4;
            // 
            // colTUR2
            // 
            this.colTUR2.Caption = "Tür2";
            this.colTUR2.FieldName = "TUR2";
            this.colTUR2.Name = "colTUR2";
            this.colTUR2.Visible = true;
            this.colTUR2.VisibleIndex = 5;
            // 
            // colTUR3
            // 
            this.colTUR3.Caption = "Tür3";
            this.colTUR3.FieldName = "TUR3";
            this.colTUR3.Name = "colTUR3";
            this.colTUR3.Visible = true;
            this.colTUR3.VisibleIndex = 6;
            // 
            // colFTRNO
            // 
            this.colFTRNO.Caption = "FtrNo";
            this.colFTRNO.FieldName = "FTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 7;
            // 
            // colFTRTRH
            // 
            this.colFTRTRH.Caption = "FtrTrh";
            this.colFTRTRH.FieldName = "FTRTRH";
            this.colFTRTRH.Name = "colFTRTRH";
            this.colFTRTRH.Visible = true;
            this.colFTRTRH.VisibleIndex = 8;
            // 
            // colFTRDVZ
            // 
            this.colFTRDVZ.Caption = "Dvz";
            this.colFTRDVZ.FieldName = "FTRDVZ";
            this.colFTRDVZ.Name = "colFTRDVZ";
            this.colFTRDVZ.Visible = true;
            this.colFTRDVZ.VisibleIndex = 9;
            // 
            // colFTRTUT
            // 
            this.colFTRTUT.Caption = "Tutar";
            this.colFTRTUT.FieldName = "FTRTUT";
            this.colFTRTUT.Name = "colFTRTUT";
            this.colFTRTUT.Visible = true;
            this.colFTRTUT.VisibleIndex = 10;
            // 
            // colAKUR
            // 
            this.colAKUR.Caption = "Kur";
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            this.colAKUR.Visible = true;
            this.colAKUR.VisibleIndex = 11;
            // 
            // colFTRTUTTL
            // 
            this.colFTRTUTTL.Caption = "TutarTL";
            this.colFTRTUTTL.FieldName = "FTRTUTTL";
            this.colFTRTUTTL.Name = "colFTRTUTTL";
            this.colFTRTUTTL.Visible = true;
            this.colFTRTUTTL.VisibleIndex = 12;
            // 
            // colATDS
            // 
            this.colATDS.Caption = "ATDs";
            this.colATDS.FieldName = "ATDS";
            this.colATDS.Name = "colATDS";
            this.colATDS.Visible = true;
            this.colATDS.VisibleIndex = 13;
            // 
            // colREFKARNENOS
            // 
            this.colREFKARNENOS.Caption = "RefKarneNo";
            this.colREFKARNENOS.FieldName = "REFKARNENOS";
            this.colREFKARNENOS.Name = "colREFKARNENOS";
            this.colREFKARNENOS.Visible = true;
            this.colREFKARNENOS.VisibleIndex = 14;
            // 
            // colVHCS
            // 
            this.colVHCS.Caption = "Vhc";
            this.colVHCS.FieldName = "VHCS";
            this.colVHCS.Name = "colVHCS";
            this.colVHCS.Visible = true;
            this.colVHCS.VisibleIndex = 15;
            // 
            // colORGS
            // 
            this.colORGS.Caption = "Org";
            this.colORGS.FieldName = "ORGS";
            this.colORGS.Name = "colORGS";
            this.colORGS.Visible = true;
            this.colORGS.VisibleIndex = 16;
            // 
            // colDSTS
            // 
            this.colDSTS.Caption = "Dst";
            this.colDSTS.FieldName = "DSTS";
            this.colDSTS.Name = "colDSTS";
            this.colDSTS.Visible = true;
            this.colDSTS.VisibleIndex = 17;
            // 
            // colOPS
            // 
            this.colOPS.Caption = "Ops";
            this.colOPS.FieldName = "OPS";
            this.colOPS.Name = "colOPS";
            this.colOPS.Visible = true;
            this.colOPS.VisibleIndex = 18;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(312, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(772, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "FILL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(212, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(96, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(64, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(92, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1096, 362);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(148, 26);
            this.layoutControlItem1.Text = "FtrTrh >=";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.accKdvStsGridControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1076, 316);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(148, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(152, 26);
            this.layoutControlItem2.Text = "FtrTrh <";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(776, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // aCC_KDV_STSTableAdapter
            // 
            this.aCC_KDV_STSTableAdapter.ClearBeforeFill = true;
            // 
            // colMATA
            // 
            this.colMATA.Caption = "ATA";
            this.colMATA.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colMATA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colMATA.FieldName = "MATA";
            this.colMATA.Name = "colMATA";
            this.colMATA.Visible = true;
            this.colMATA.VisibleIndex = 19;
            // 
            // colMCIKKAPI
            // 
            this.colMCIKKAPI.Caption = "ÇıkışKapı";
            this.colMCIKKAPI.FieldName = "MCIKKAPI";
            this.colMCIKKAPI.Name = "colMCIKKAPI";
            this.colMCIKKAPI.Visible = true;
            this.colMCIKKAPI.VisibleIndex = 20;
            // 
            // colMVRSGMRK
            // 
            this.colMVRSGMRK.Caption = "VarışGümrük";
            this.colMVRSGMRK.FieldName = "MVRSGMRK";
            this.colMVRSGMRK.Name = "colMVRSGMRK";
            this.colMVRSGMRK.Visible = true;
            this.colMVRSGMRK.VisibleIndex = 21;
            // 
            // AccKdvStsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 362);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AccKdvStsXF";
            this.Text = "AccKdvStsXF";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accKdvStsGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aCC_KDV_STSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource aCC_KDV_STSBindingSource;
        private AccountRprDataSetTableAdapters.ACC_KDV_STSTableAdapter aCC_KDV_STSTableAdapter;
        private DevExpress.XtraGrid.GridControl accKdvStsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colAFBID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTAD;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTVRGNO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR2;
        private DevExpress.XtraGrid.Columns.GridColumn colTUR3;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTUTTL;
        private DevExpress.XtraGrid.Columns.GridColumn colATDS;
        private DevExpress.XtraGrid.Columns.GridColumn colREFKARNENOS;
        private DevExpress.XtraGrid.Columns.GridColumn colVHCS;
        private DevExpress.XtraGrid.Columns.GridColumn colORGS;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colOPS;
        private DevExpress.XtraGrid.Columns.GridColumn colMATA;
        private DevExpress.XtraGrid.Columns.GridColumn colMCIKKAPI;
        private DevExpress.XtraGrid.Columns.GridColumn colMVRSGMRK;
    }
}