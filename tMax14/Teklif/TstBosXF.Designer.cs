namespace tMax14.Teklif
{
    partial class TstBosXF
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
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.tstBosSelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tstBosSelTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TST_BOS_SELTableAdapter();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.kaydetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.rowTSTID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowNOTS = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rowINFO = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRFSTYP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstBosSelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tstBosSelBindingSource
            // 
            this.tstBosSelBindingSource.DataMember = "TST_BOS_SEL";
            this.tstBosSelBindingSource.DataSource = this.teklifDataSet;
            // 
            // tstBosSelTableAdapter
            // 
            this.tstBosSelTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.kaydetSimpleButton);
            this.layoutControl1.Controls.Add(this.vGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(229, 216);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // kaydetSimpleButton
            // 
            this.kaydetSimpleButton.Location = new System.Drawing.Point(12, 182);
            this.kaydetSimpleButton.Name = "kaydetSimpleButton";
            this.kaydetSimpleButton.Size = new System.Drawing.Size(205, 22);
            this.kaydetSimpleButton.StyleController = this.layoutControl1;
            this.kaydetSimpleButton.TabIndex = 4;
            this.kaydetSimpleButton.Text = "Kaydet";
            this.kaydetSimpleButton.Click += new System.EventHandler(this.kaydetSimpleButton_Click);
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.tstBosSelBindingSource;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(12, 12);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 133;
            this.vGridControl1.RowHeaderWidth = 67;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowTSTID,
            this.rowNOTS,
            this.rowINFO,
            this.rowRFSTYP});
            this.vGridControl1.Size = new System.Drawing.Size(205, 166);
            this.vGridControl1.TabIndex = 1;
            // 
            // rowTSTID
            // 
            this.rowTSTID.Name = "rowTSTID";
            this.rowTSTID.Properties.Caption = "TstID";
            this.rowTSTID.Properties.FieldName = "TSTID";
            this.rowTSTID.Properties.ReadOnly = true;
            // 
            // rowNOTS
            // 
            this.rowNOTS.Name = "rowNOTS";
            this.rowNOTS.Properties.Caption = "Not";
            this.rowNOTS.Properties.FieldName = "NOTS";
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(229, 216);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.vGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(209, 170);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.kaydetSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 170);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(209, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // rowINFO
            // 
            this.rowINFO.Name = "rowINFO";
            this.rowINFO.Properties.Caption = "Info";
            this.rowINFO.Properties.FieldName = "INFO";
            // 
            // rowRFSTYP
            // 
            this.rowRFSTYP.Name = "rowRFSTYP";
            this.rowRFSTYP.Properties.Caption = "Refused";
            this.rowRFSTYP.Properties.FieldName = "RFSTYP";
            // 
            // TstBosXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 216);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TstBosXF";
            this.Text = "TstBosXF";
            this.Load += new System.EventHandler(this.TstBosXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tstBosSelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource tstBosSelBindingSource;
        private TeklifDataSetTableAdapters.TST_BOS_SELTableAdapter tstBosSelTableAdapter;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTSTID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowNOTS;
        private DevExpress.XtraEditors.SimpleButton kaydetSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowINFO;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRFSTYP;
    }
}