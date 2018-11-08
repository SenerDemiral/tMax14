namespace tMax14.Account
{
    partial class AfdFytUpdXF
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
            this.oFytTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.oDvzTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nDvzLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.nFytEdit = new DevExpress.XtraEditors.CalcEdit();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.dVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new tMax14.MainDataSet();
            this.dVTTableAdapter = new tMax14.MainDataSetTableAdapters.DVTTableAdapter();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oFytTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDvzTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDvzLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFytEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // oFytTextEdit
            // 
            this.oFytTextEdit.Location = new System.Drawing.Point(49, 12);
            this.oFytTextEdit.Name = "oFytTextEdit";
            this.oFytTextEdit.Properties.ReadOnly = true;
            this.oFytTextEdit.Size = new System.Drawing.Size(100, 20);
            this.oFytTextEdit.TabIndex = 0;
            // 
            // oDvzTextEdit
            // 
            this.oDvzTextEdit.Location = new System.Drawing.Point(155, 12);
            this.oDvzTextEdit.Name = "oDvzTextEdit";
            this.oDvzTextEdit.Properties.ReadOnly = true;
            this.oDvzTextEdit.Size = new System.Drawing.Size(55, 20);
            this.oDvzTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Eski";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Yeni";
            // 
            // nDvzLookUpEdit
            // 
            this.nDvzLookUpEdit.Location = new System.Drawing.Point(155, 47);
            this.nDvzLookUpEdit.Name = "nDvzLookUpEdit";
            this.nDvzLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nDvzLookUpEdit.Properties.DataSource = this.dVTBindingSource;
            this.nDvzLookUpEdit.Properties.DisplayMember = "DVZ";
            this.nDvzLookUpEdit.Properties.ValueMember = "DVZ";
            this.nDvzLookUpEdit.Size = new System.Drawing.Size(55, 20);
            this.nDvzLookUpEdit.TabIndex = 4;
            // 
            // nFytEdit
            // 
            this.nFytEdit.Location = new System.Drawing.Point(49, 47);
            this.nFytEdit.Name = "nFytEdit";
            this.nFytEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nFytEdit.Properties.Precision = 4;
            this.nFytEdit.Size = new System.Drawing.Size(100, 20);
            this.nFytEdit.TabIndex = 5;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(49, 73);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(161, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "UPDATE";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dVTBindingSource
            // 
            this.dVTBindingSource.DataMember = "DVT";
            this.dVTBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dVTTableAdapter
            // 
            this.dVTTableAdapter.ClearBeforeFill = true;
            // 
            // AfdFytUpdXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 109);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.nFytEdit);
            this.Controls.Add(this.nDvzLookUpEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.oDvzTextEdit);
            this.Controls.Add(this.oFytTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AfdFytUpdXF";
            this.Text = "AfdFytUpdXF";
            this.Load += new System.EventHandler(this.AfdFytUpdXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oFytTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oDvzTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDvzLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFytEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit oFytTextEdit;
        private DevExpress.XtraEditors.TextEdit oDvzTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit nDvzLookUpEdit;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource dVTBindingSource;
        private MainDataSetTableAdapters.DVTTableAdapter dVTTableAdapter;
        private DevExpress.XtraEditors.CalcEdit nFytEdit;
        private DevExpress.XtraEditors.SimpleButton updateButton;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
    }
}