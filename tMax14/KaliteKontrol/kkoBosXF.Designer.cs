namespace tMax14.KaliteKontrol
{
    partial class kkoBosXF
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
            this.kKO_BOS_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kKO_BOS_SELTableAdapter = new tMax14.KaliteKontrol.kkDataSetTableAdapters.KKO_BOS_SELTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowKKOID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowDRM = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowBLDSKL = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowONC = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTUR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTOUSR = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowINFO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTAGS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rowILGUSRS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKO_BOS_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
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
            // kKO_BOS_SELBindingSource
            // 
            this.kKO_BOS_SELBindingSource.DataMember = "KKO_BOS_SEL";
            this.kKO_BOS_SELBindingSource.DataSource = this.kkDataSet;
            // 
            // kKO_BOS_SELTableAdapter
            // 
            this.kKO_BOS_SELTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 188);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(360, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 2;
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
            this.layoutControl1.Size = new System.Drawing.Size(384, 222);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.kKO_BOS_SELBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 153;
            this.vGridControl1.RowHeaderWidth = 47;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowKKOID,
            this.rowDRM,
            this.rowBLDSKL,
            this.rowONC,
            this.rowTUR,
            this.rowTOUSR,
            this.rowINFO,
            this.rowTAGS,
            this.rowILGUSRS});
            this.vGridControl1.Size = new System.Drawing.Size(360, 172);
            this.vGridControl1.TabIndex = 3;
            // 
            // rowKKOID
            // 
            this.rowKKOID.Name = "rowKKOID";
            this.rowKKOID.Properties.Caption = "KKOID";
            this.rowKKOID.Properties.FieldName = "KKOID";
            this.rowKKOID.Properties.ReadOnly = true;
            // 
            // rowDRM
            // 
            this.rowDRM.Name = "rowDRM";
            this.rowDRM.Properties.Caption = "Drm";
            this.rowDRM.Properties.FieldName = "DRM";
            // 
            // rowBLDSKL
            // 
            this.rowBLDSKL.Name = "rowBLDSKL";
            this.rowBLDSKL.Properties.Caption = "BldŞkl";
            this.rowBLDSKL.Properties.FieldName = "BLDSKL";
            // 
            // rowONC
            // 
            this.rowONC.Name = "rowONC";
            this.rowONC.Properties.Caption = "Öncelik";
            this.rowONC.Properties.FieldName = "ONC";
            // 
            // rowTUR
            // 
            this.rowTUR.Name = "rowTUR";
            this.rowTUR.Properties.Caption = "Tür";
            this.rowTUR.Properties.FieldName = "TUR";
            // 
            // rowTOUSR
            // 
            this.rowTOUSR.Name = "rowTOUSR";
            this.rowTOUSR.Properties.Caption = "ToUsr";
            this.rowTOUSR.Properties.FieldName = "TOUSR";
            // 
            // rowINFO
            // 
            this.rowINFO.Name = "rowINFO";
            this.rowINFO.Properties.Caption = "Info";
            this.rowINFO.Properties.FieldName = "INFO";
            // 
            // rowTAGS
            // 
            this.rowTAGS.Name = "rowTAGS";
            this.rowTAGS.Properties.Caption = "TAGs";
            this.rowTAGS.Properties.FieldName = "TAGS";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(384, 222);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(364, 176);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(364, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // rowILGUSRS
            // 
            this.rowILGUSRS.Name = "rowILGUSRS";
            this.rowILGUSRS.Properties.Caption = "IlgUsr";
            this.rowILGUSRS.Properties.FieldName = "ILGUSRS";
            // 
            // kkoBosXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 222);
            this.Controls.Add(this.layoutControl1);
            this.Name = "kkoBosXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kkoBosXF";
            this.Load += new System.EventHandler(this.kkoBosXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kKO_BOS_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private kkDataSet kkDataSet;
        private System.Windows.Forms.BindingSource kKO_BOS_SELBindingSource;
        private kkDataSetTableAdapters.KKO_BOS_SELTableAdapter kKO_BOS_SELTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKKOID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDRM;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowBLDSKL;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowONC;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTUR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTOUSR;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowINFO;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTAGS;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowILGUSRS;
    }
}