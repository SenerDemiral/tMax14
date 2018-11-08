namespace tMax14.Genel
{
    partial class efuMdfyXF
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
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.MsjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TAGScheckedComboBoxEdit = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.xTGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new tMax14.MainDataSet();
            this.RefIDtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RefTOtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mainQueriesTableAdapter = new tMax14.MainDataSetTableAdapters.MainQueriesTableAdapter();
            this.xTGTableAdapter = new tMax14.MainDataSetTableAdapters.XTGTableAdapter();
            this.TkpTrhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MsjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGScheckedComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefIDtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefTOtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkpTrhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkpTrhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TkpTrhDateEdit);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.MsjTextEdit);
            this.layoutControl1.Controls.Add(this.TAGScheckedComboBoxEdit);
            this.layoutControl1.Controls.Add(this.RefIDtextEdit);
            this.layoutControl1.Controls.Add(this.RefTOtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(379, 165, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(320, 156);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(12, 108);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(296, 22);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 9;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // MsjTextEdit
            // 
            this.MsjTextEdit.Location = new System.Drawing.Point(69, 60);
            this.MsjTextEdit.Name = "MsjTextEdit";
            this.MsjTextEdit.Properties.MaxLength = 100;
            this.MsjTextEdit.Size = new System.Drawing.Size(239, 20);
            this.MsjTextEdit.StyleController = this.layoutControl1;
            this.MsjTextEdit.TabIndex = 8;
            // 
            // TAGScheckedComboBoxEdit
            // 
            this.TAGScheckedComboBoxEdit.EditValue = "";
            this.TAGScheckedComboBoxEdit.Location = new System.Drawing.Point(69, 36);
            this.TAGScheckedComboBoxEdit.Name = "TAGScheckedComboBoxEdit";
            this.TAGScheckedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.TAGScheckedComboBoxEdit.Properties.DataSource = this.xTGBindingSource;
            this.TAGScheckedComboBoxEdit.Properties.DisplayMember = "AD";
            this.TAGScheckedComboBoxEdit.Properties.ValueMember = "TAG";
            this.TAGScheckedComboBoxEdit.Size = new System.Drawing.Size(239, 20);
            this.TAGScheckedComboBoxEdit.StyleController = this.layoutControl1;
            this.TAGScheckedComboBoxEdit.TabIndex = 6;
            this.TAGScheckedComboBoxEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TAGScheckedComboBoxEdit_ButtonClick);
            // 
            // xTGBindingSource
            // 
            this.xTGBindingSource.DataMember = "XTG";
            this.xTGBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RefIDtextEdit
            // 
            this.RefIDtextEdit.Location = new System.Drawing.Point(180, 12);
            this.RefIDtextEdit.Name = "RefIDtextEdit";
            this.RefIDtextEdit.Properties.ReadOnly = true;
            this.RefIDtextEdit.Size = new System.Drawing.Size(128, 20);
            this.RefIDtextEdit.StyleController = this.layoutControl1;
            this.RefIDtextEdit.TabIndex = 5;
            this.RefIDtextEdit.TabStop = false;
            // 
            // RefTOtextEdit
            // 
            this.RefTOtextEdit.Location = new System.Drawing.Point(69, 12);
            this.RefTOtextEdit.Name = "RefTOtextEdit";
            this.RefTOtextEdit.Properties.ReadOnly = true;
            this.RefTOtextEdit.Size = new System.Drawing.Size(50, 20);
            this.RefTOtextEdit.StyleController = this.layoutControl1;
            this.RefTOtextEdit.TabIndex = 4;
            this.RefTOtextEdit.TabStop = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(320, 156);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.RefTOtextEdit;
            this.layoutControlItem1.CustomizationFormText = "RefTO";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(111, 24);
            this.layoutControlItem1.Text = "RefTO";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TAGScheckedComboBoxEdit;
            this.layoutControlItem3.CustomizationFormText = "TAGs";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem3.Text = "TAGs";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.MsjTextEdit;
            this.layoutControlItem5.CustomizationFormText = "Mesaj";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem5.Text = "Mesaj";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(54, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.OKsimpleButton;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(300, 40);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.RefIDtextEdit;
            this.layoutControlItem2.CustomizationFormText = "RefID";
            this.layoutControlItem2.Location = new System.Drawing.Point(111, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItem2.Text = "RefID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(54, 13);
            // 
            // xTGTableAdapter
            // 
            this.xTGTableAdapter.ClearBeforeFill = true;
            // 
            // TkpTrhDateEdit
            // 
            this.TkpTrhDateEdit.EditValue = null;
            this.TkpTrhDateEdit.Location = new System.Drawing.Point(69, 84);
            this.TkpTrhDateEdit.Name = "TkpTrhDateEdit";
            this.TkpTrhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TkpTrhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TkpTrhDateEdit.Size = new System.Drawing.Size(239, 20);
            this.TkpTrhDateEdit.StyleController = this.layoutControl1;
            this.TkpTrhDateEdit.TabIndex = 10;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.TkpTrhDateEdit;
            this.layoutControlItem4.CustomizationFormText = "Takip Tarihi";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem4.Text = "Takip Tarihi";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(54, 13);
            // 
            // efuMdfyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 156);
            this.Controls.Add(this.layoutControl1);
            this.Name = "efuMdfyXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takip [efuMdfyXF]";
            this.Load += new System.EventHandler(this.efuMdfyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MsjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGScheckedComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xTGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefIDtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefTOtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkpTrhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TkpTrhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraEditors.TextEdit MsjTextEdit;
        private DevExpress.XtraEditors.CheckedComboBoxEdit TAGScheckedComboBoxEdit;
        private DevExpress.XtraEditors.TextEdit RefIDtextEdit;
        private DevExpress.XtraEditors.TextEdit RefTOtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private MainDataSetTableAdapters.MainQueriesTableAdapter mainQueriesTableAdapter;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource xTGBindingSource;
        private MainDataSetTableAdapters.XTGTableAdapter xTGTableAdapter;
        private DevExpress.XtraEditors.DateEdit TkpTrhDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}