namespace tMax14.Genel
{
    partial class TblTagMdfyXF
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
            this.mainQueriesTableAdapter = new tMax14.MainDataSetTableAdapters.MainQueriesTableAdapter();
            this.mainDataSet = new tMax14.MainDataSet();
            this.xTGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xTGTableAdapter = new tMax14.MainDataSetTableAdapters.XTGTableAdapter();
            this.TAGScheckedComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGScheckedComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xTGBindingSource
            // 
            this.xTGBindingSource.DataMember = "XTG";
            this.xTGBindingSource.DataSource = this.mainDataSet;
            // 
            // xTGTableAdapter
            // 
            this.xTGTableAdapter.ClearBeforeFill = true;
            // 
            // TAGScheckedComboBoxEdit
            // 
            this.TAGScheckedComboBoxEdit.EditValue = "";
            this.TAGScheckedComboBoxEdit.Location = new System.Drawing.Point(41, 12);
            this.TAGScheckedComboBoxEdit.Name = "TAGScheckedComboBoxEdit";
            this.TAGScheckedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.TAGScheckedComboBoxEdit.Properties.DataSource = this.xTGBindingSource;
            this.TAGScheckedComboBoxEdit.Properties.DisplayMember = "AD";
            this.TAGScheckedComboBoxEdit.Properties.ValueMember = "TAG";
            this.TAGScheckedComboBoxEdit.Size = new System.Drawing.Size(302, 20);
            this.TAGScheckedComboBoxEdit.StyleController = this.layoutControl1;
            this.TAGScheckedComboBoxEdit.TabIndex = 7;
            this.TAGScheckedComboBoxEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TAGScheckedComboBoxEdit_ButtonClick);
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(12, 36);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(331, 31);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 10;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TAGScheckedComboBoxEdit);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(355, 79);
            this.layoutControl1.TabIndex = 11;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(355, 79);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TAGScheckedComboBoxEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(335, 24);
            this.layoutControlItem1.Text = "TAGs";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(25, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.OKsimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(29, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(335, 35);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // TblTagMdfyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 79);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TblTagMdfyXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TblTagMdfyXF";
            this.Load += new System.EventHandler(this.TblTagMdfyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGScheckedComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDataSetTableAdapters.MainQueriesTableAdapter mainQueriesTableAdapter;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource xTGBindingSource;
        private MainDataSetTableAdapters.XTGTableAdapter xTGTableAdapter;
        private DevExpress.XtraEditors.CheckedComboBoxEdit TAGScheckedComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}