namespace tMax14.Genel
{
    partial class KpiSetXF
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
            this.kpiSetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.kpiLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.xGTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.uSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xGTTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.XGTTableAdapter();
            this.genelQueriesTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.GenelQueriesTableAdapter();
            this.uSTTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.USTTableAdapter();
            this.usrCheckedComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.kpiLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrCheckedComboBoxEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // kpiSetSimpleButton
            // 
            this.kpiSetSimpleButton.Location = new System.Drawing.Point(12, 96);
            this.kpiSetSimpleButton.Name = "kpiSetSimpleButton";
            this.kpiSetSimpleButton.Size = new System.Drawing.Size(207, 22);
            this.kpiSetSimpleButton.TabIndex = 8;
            this.kpiSetSimpleButton.Text = "KPI Set";
            this.kpiSetSimpleButton.Click += new System.EventHandler(this.kpiSetSimpleButton_Click);
            // 
            // kpiLookUpEdit
            // 
            this.kpiLookUpEdit.Location = new System.Drawing.Point(44, 12);
            this.kpiLookUpEdit.Name = "kpiLookUpEdit";
            this.kpiLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kpiLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VAL", "VAL", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 21, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.kpiLookUpEdit.Properties.DataSource = this.xGTBindingSource;
            this.kpiLookUpEdit.Properties.DisplayMember = "VAL";
            this.kpiLookUpEdit.Properties.NullText = "";
            this.kpiLookUpEdit.Properties.ValueMember = "ID";
            this.kpiLookUpEdit.Size = new System.Drawing.Size(175, 20);
            this.kpiLookUpEdit.TabIndex = 9;
            // 
            // xGTBindingSource
            // 
            this.xGTBindingSource.DataMember = "XGT";
            this.xGTBindingSource.DataSource = this.genelDataSet;
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(16, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "KPI";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // uSTBindingSource
            // 
            this.uSTBindingSource.DataMember = "UST";
            this.uSTBindingSource.DataSource = this.genelDataSet;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(44, 64);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(175, 20);
            this.dateEdit1.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(16, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Usr";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Trh";
            // 
            // xGTTableAdapter
            // 
            this.xGTTableAdapter.ClearBeforeFill = true;
            // 
            // uSTTableAdapter
            // 
            this.uSTTableAdapter.ClearBeforeFill = true;
            // 
            // usrCheckedComboBoxEdit
            // 
            this.usrCheckedComboBoxEdit.Location = new System.Drawing.Point(43, 38);
            this.usrCheckedComboBoxEdit.Name = "usrCheckedComboBoxEdit";
            this.usrCheckedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.usrCheckedComboBoxEdit.Properties.DataSource = this.uSTBindingSource;
            this.usrCheckedComboBoxEdit.Properties.DisplayMember = "AD";
            this.usrCheckedComboBoxEdit.Properties.ValueMember = "USR";
            this.usrCheckedComboBoxEdit.Size = new System.Drawing.Size(176, 20);
            this.usrCheckedComboBoxEdit.TabIndex = 15;
            // 
            // KpiSetXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 129);
            this.Controls.Add(this.usrCheckedComboBoxEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.kpiLookUpEdit);
            this.Controls.Add(this.kpiSetSimpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KpiSetXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KpiSetXF";
            this.Load += new System.EventHandler(this.KpiSetXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kpiLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrCheckedComboBoxEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton kpiSetSimpleButton;
        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource xGTBindingSource;
        private GenelDataSetTableAdapters.XGTTableAdapter xGTTableAdapter;
        private GenelDataSetTableAdapters.GenelQueriesTableAdapter genelQueriesTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit kpiLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource uSTBindingSource;
        private GenelDataSetTableAdapters.USTTableAdapter uSTTableAdapter;
        private DevExpress.XtraEditors.CheckedComboBoxEdit usrCheckedComboBoxEdit;
    }
}