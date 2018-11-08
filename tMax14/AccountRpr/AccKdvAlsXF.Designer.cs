namespace tMax14.AccountRpr
{
    partial class AccKdvAlsXF
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
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.accKdvAlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accKdvAlsTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.ACC_KDV_ALSTableAdapter();
            this.accKdvAlsGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colFTRTUTBRT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAKUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFTRTUTTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVTUTTL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADET = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKdvAlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKdvAlsGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
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
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accKdvAlsBindingSource
            // 
            this.accKdvAlsBindingSource.DataMember = "ACC_KDV_ALS";
            this.accKdvAlsBindingSource.DataSource = this.accountRprDataSet;
            // 
            // accKdvAlsTableAdapter
            // 
            this.accKdvAlsTableAdapter.ClearBeforeFill = true;
            // 
            // accKdvAlsGridControl
            // 
            this.accKdvAlsGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.accKdvAlsGridControl.DataSource = this.accKdvAlsBindingSource;
            this.accKdvAlsGridControl.Location = new System.Drawing.Point(12, 38);
            this.accKdvAlsGridControl.MainView = this.gridView1;
            this.accKdvAlsGridControl.Name = "accKdvAlsGridControl";
            this.accKdvAlsGridControl.Size = new System.Drawing.Size(1176, 268);
            this.accKdvAlsGridControl.TabIndex = 4;
            this.accKdvAlsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colFTRTUTBRT,
            this.colAKUR,
            this.colFTRTUTTL,
            this.colKDVTUTTL,
            this.colACIKLAMA,
            this.colADET,
            this.colOPS});
            this.gridView1.GridControl = this.accKdvAlsGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colAFBID
            // 
            this.colAFBID.FieldName = "AFBID";
            this.colAFBID.Name = "colAFBID";
            this.colAFBID.Visible = true;
            this.colAFBID.VisibleIndex = 0;
            this.colAFBID.Width = 63;
            // 
            // colFRTID
            // 
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            this.colFRTID.Width = 63;
            // 
            // colFRTAD
            // 
            this.colFRTAD.Caption = "Firma";
            this.colFRTAD.FieldName = "FRTAD";
            this.colFRTAD.Name = "colFRTAD";
            this.colFRTAD.Visible = true;
            this.colFRTAD.VisibleIndex = 2;
            this.colFRTAD.Width = 63;
            // 
            // colFRTVRGNO
            // 
            this.colFRTVRGNO.Caption = "VrgNo";
            this.colFRTVRGNO.FieldName = "FRTVRGNO";
            this.colFRTVRGNO.Name = "colFRTVRGNO";
            this.colFRTVRGNO.Visible = true;
            this.colFRTVRGNO.VisibleIndex = 3;
            this.colFRTVRGNO.Width = 63;
            // 
            // colTUR
            // 
            this.colTUR.Caption = "Tür";
            this.colTUR.FieldName = "TUR";
            this.colTUR.Name = "colTUR";
            this.colTUR.Visible = true;
            this.colTUR.VisibleIndex = 4;
            this.colTUR.Width = 35;
            // 
            // colTUR2
            // 
            this.colTUR2.Caption = "Tür2";
            this.colTUR2.FieldName = "TUR2";
            this.colTUR2.Name = "colTUR2";
            this.colTUR2.Visible = true;
            this.colTUR2.VisibleIndex = 5;
            this.colTUR2.Width = 35;
            // 
            // colTUR3
            // 
            this.colTUR3.Caption = "Tür3";
            this.colTUR3.FieldName = "TUR3";
            this.colTUR3.Name = "colTUR3";
            this.colTUR3.Visible = true;
            this.colTUR3.VisibleIndex = 6;
            this.colTUR3.Width = 35;
            // 
            // colFTRNO
            // 
            this.colFTRNO.Caption = "FtrNo";
            this.colFTRNO.FieldName = "FTRNO";
            this.colFTRNO.Name = "colFTRNO";
            this.colFTRNO.Visible = true;
            this.colFTRNO.VisibleIndex = 7;
            this.colFTRNO.Width = 70;
            // 
            // colFTRTRH
            // 
            this.colFTRTRH.Caption = "FtrTrh";
            this.colFTRTRH.FieldName = "FTRTRH";
            this.colFTRTRH.Name = "colFTRTRH";
            this.colFTRTRH.Visible = true;
            this.colFTRTRH.VisibleIndex = 8;
            this.colFTRTRH.Width = 70;
            // 
            // colFTRDVZ
            // 
            this.colFTRDVZ.Caption = "Dvz";
            this.colFTRDVZ.FieldName = "FTRDVZ";
            this.colFTRDVZ.Name = "colFTRDVZ";
            this.colFTRDVZ.Visible = true;
            this.colFTRDVZ.VisibleIndex = 9;
            this.colFTRDVZ.Width = 70;
            // 
            // colFTRTUT
            // 
            this.colFTRTUT.Caption = "Tutar";
            this.colFTRTUT.FieldName = "FTRTUT";
            this.colFTRTUT.Name = "colFTRTUT";
            this.colFTRTUT.Visible = true;
            this.colFTRTUT.VisibleIndex = 10;
            this.colFTRTUT.Width = 70;
            // 
            // colFTRTUTBRT
            // 
            this.colFTRTUTBRT.Caption = "BürütTutarTL";
            this.colFTRTUTBRT.FieldName = "FTRTUTBRT";
            this.colFTRTUTBRT.Name = "colFTRTUTBRT";
            this.colFTRTUTBRT.Visible = true;
            this.colFTRTUTBRT.VisibleIndex = 11;
            this.colFTRTUTBRT.Width = 70;
            // 
            // colAKUR
            // 
            this.colAKUR.Caption = "Kur";
            this.colAKUR.FieldName = "AKUR";
            this.colAKUR.Name = "colAKUR";
            this.colAKUR.Visible = true;
            this.colAKUR.VisibleIndex = 12;
            this.colAKUR.Width = 70;
            // 
            // colFTRTUTTL
            // 
            this.colFTRTUTTL.Caption = "TutarTL";
            this.colFTRTUTTL.FieldName = "FTRTUTTL";
            this.colFTRTUTTL.Name = "colFTRTUTTL";
            this.colFTRTUTTL.Visible = true;
            this.colFTRTUTTL.VisibleIndex = 13;
            this.colFTRTUTTL.Width = 70;
            // 
            // colKDVTUTTL
            // 
            this.colKDVTUTTL.Caption = "KdvTutTL";
            this.colKDVTUTTL.FieldName = "KDVTUTTL";
            this.colKDVTUTTL.Name = "colKDVTUTTL";
            this.colKDVTUTTL.Visible = true;
            this.colKDVTUTTL.VisibleIndex = 14;
            this.colKDVTUTTL.Width = 70;
            // 
            // colOPS
            // 
            this.colOPS.Caption = "Ops";
            this.colOPS.FieldName = "OPS";
            this.colOPS.Name = "colOPS";
            this.colOPS.Visible = true;
            this.colOPS.VisibleIndex = 17;
            this.colOPS.Width = 114;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.accKdvAlsGridControl);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1200, 318);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(323, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(865, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "FILL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(214, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(105, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 2;
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
            this.dateEdit1.Size = new System.Drawing.Size(94, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 0;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1200, 318);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dateEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(150, 26);
            this.layoutControlItem1.Text = "FtrTrh >=";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.accKdvAlsGridControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1180, 272);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(150, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(161, 26);
            this.layoutControlItem2.Text = "FtrTrh <";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(869, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 15;
            this.colACIKLAMA.Width = 87;
            // 
            // colADET
            // 
            this.colADET.Caption = "Adet";
            this.colADET.FieldName = "ADET";
            this.colADET.Name = "colADET";
            this.colADET.Visible = true;
            this.colADET.VisibleIndex = 16;
            this.colADET.Width = 40;
            // 
            // AccKdvAlsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 318);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AccKdvAlsXF";
            this.Text = "AccKdvAlsXF";
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKdvAlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accKdvAlsGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
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

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource accKdvAlsBindingSource;
        private AccountRprDataSetTableAdapters.ACC_KDV_ALSTableAdapter accKdvAlsTableAdapter;
        private DevExpress.XtraGrid.GridControl accKdvAlsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
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
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTUTBRT;
        private DevExpress.XtraGrid.Columns.GridColumn colAKUR;
        private DevExpress.XtraGrid.Columns.GridColumn colFTRTUTTL;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVTUTTL;
        private DevExpress.XtraGrid.Columns.GridColumn colOPS;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colADET;
    }
}