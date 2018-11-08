namespace tMax14.KaliteKontrol
{
    partial class kkfBosXF
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
            this.kkDataSet = new tMax14.KaliteKontrol.kkDataSet();
            this.kKF_BOS_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kKF_BOS_SELTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKF_BOS_SELTableAdapter();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowKKFID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTUR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowYTKUSR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNOTLAR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKF_BOS_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // kkDataSet
            // 
            this.kkDataSet.DataSetName = "kkDataSet";
            this.kkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kKF_BOS_SELBindingSource
            // 
            this.kKF_BOS_SELBindingSource.DataMember = "KKF_BOS_SEL";
            this.kKF_BOS_SELBindingSource.DataSource = this.kkDataSet;
            // 
            // kKF_BOS_SELTableAdapter
            // 
            this.kKF_BOS_SELTableAdapter.ClearBeforeFill = true;
            // 
            // vGridControl1
            // 
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.vGridControl1.DataSource = this.kKF_BOS_SELBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 154;
            this.vGridControl1.RowHeaderWidth = 46;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowKKFID,
            this.rowTUR,
            this.rowYTKUSR,
            this.rowNOTLAR});
            this.vGridControl1.Size = new System.Drawing.Size(309, 78);
            this.vGridControl1.TabIndex = 2;
            // 
            // rowKKFID
            // 
            this.rowKKFID.Name = "rowKKFID";
            this.rowKKFID.Properties.Caption = "KKFID";
            this.rowKKFID.Properties.FieldName = "KKFID";
            this.rowKKFID.Properties.ReadOnly = true;
            // 
            // rowTUR
            // 
            this.rowTUR.Name = "rowTUR";
            this.rowTUR.Properties.Caption = "Tür";
            this.rowTUR.Properties.FieldName = "TUR";
            // 
            // rowYTKUSR
            // 
            this.rowYTKUSR.Name = "rowYTKUSR";
            this.rowYTKUSR.Properties.Caption = "Yetkili";
            this.rowYTKUSR.Properties.FieldName = "YTKUSR";
            // 
            // rowNOTLAR
            // 
            this.rowNOTLAR.Name = "rowNOTLAR";
            this.rowNOTLAR.Properties.Caption = "Notlar";
            this.rowNOTLAR.Properties.FieldName = "NOTLAR";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 94);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(309, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(333, 128);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(333, 128);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(313, 82);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 82);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(313, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // kkfBosXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 128);
            this.Controls.Add(this.layoutControl1);
            this.Name = "kkfBosXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kkfBos";
            this.Load += new System.EventHandler(this.kkfBosXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKF_BOS_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kKF_BOS_SELBindingSource;
        private kkDataSetTableAdapters.KKF_BOS_SELTableAdapter kKF_BOS_SELTableAdapter;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKKFID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTUR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowYTKUSR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNOTLAR;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}