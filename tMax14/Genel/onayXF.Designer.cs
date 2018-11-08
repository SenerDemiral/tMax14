namespace tMax14.Genel
{
    partial class onayXF
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
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.onaylaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.curYTKtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.userLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.uSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new tMax14.MainDataSet();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.uSTTableAdapter = new tMax14.MainDataSetTableAdapters.USTTableAdapter();
            this.mainQueriesTableAdapter = new tMax14.MainDataSetTableAdapters.MainQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curYTKtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.imageComboBoxEdit1);
            this.layoutControl1.Controls.Add(this.onaylaSimpleButton);
            this.layoutControl1.Controls.Add(this.curYTKtextEdit);
            this.layoutControl1.Controls.Add(this.userLookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(240, 114);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(30, 88);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(206, 20);
            this.imageComboBoxEdit1.StyleController = this.layoutControl1;
            this.imageComboBoxEdit1.TabIndex = 9;
            // 
            // onaylaSimpleButton
            // 
            this.onaylaSimpleButton.Location = new System.Drawing.Point(9, 57);
            this.onaylaSimpleButton.Name = "onaylaSimpleButton";
            this.onaylaSimpleButton.Size = new System.Drawing.Size(222, 22);
            this.onaylaSimpleButton.StyleController = this.layoutControl1;
            this.onaylaSimpleButton.TabIndex = 7;
            this.onaylaSimpleButton.Text = "Onayla";
            this.onaylaSimpleButton.Click += new System.EventHandler(this.onaylaSimpleButton_Click);
            // 
            // curYTKtextEdit
            // 
            this.curYTKtextEdit.Enabled = false;
            this.curYTKtextEdit.Location = new System.Drawing.Point(68, 4);
            this.curYTKtextEdit.Name = "curYTKtextEdit";
            this.curYTKtextEdit.Size = new System.Drawing.Size(168, 20);
            this.curYTKtextEdit.StyleController = this.layoutControl1;
            this.curYTKtextEdit.TabIndex = 6;
            // 
            // userLookUpEdit
            // 
            this.userLookUpEdit.Enabled = false;
            this.userLookUpEdit.Location = new System.Drawing.Point(34, 33);
            this.userLookUpEdit.Name = "userLookUpEdit";
            this.userLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USR", "USR", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "AD", 24, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("USTID", "USTID", 10, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.userLookUpEdit.Properties.DataSource = this.uSTBindingSource;
            this.userLookUpEdit.Properties.DisplayMember = "AD";
            this.userLookUpEdit.Properties.ValueMember = "USR";
            this.userLookUpEdit.Size = new System.Drawing.Size(197, 20);
            this.userLookUpEdit.StyleController = this.layoutControl1;
            this.userLookUpEdit.TabIndex = 5;
            this.userLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.userLookUpEdit_Closed);
            // 
            // uSTBindingSource
            // 
            this.uSTBindingSource.DataMember = "UST";
            this.uSTBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AutoSize;
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(240, 114);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.curYTKtextEdit;
            this.layoutControlItem3.CustomizationFormText = "Mevcut Yetki";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(236, 24);
            this.layoutControlItem3.Text = "Mevcut Yetki";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(236, 60);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.userLookUpEdit;
            this.layoutControlItem2.CustomizationFormText = "User";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(226, 24);
            this.layoutControlItem2.Text = "User";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(22, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.onaylaSimpleButton;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(226, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.imageComboBoxEdit1;
            this.layoutControlItem6.CustomizationFormText = "Yetki";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(236, 26);
            this.layoutControlItem6.Text = "Yetki";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(23, 13);
            // 
            // uSTTableAdapter
            // 
            this.uSTTableAdapter.ClearBeforeFill = true;
            // 
            // onayXF
            // 
            this.AcceptButton = this.onaylaSimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 114);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "onayXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "onayXF";
            this.Load += new System.EventHandler(this.onayXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curYTKtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit userLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource uSTBindingSource;
        private MainDataSetTableAdapters.USTTableAdapter uSTTableAdapter;
        private DevExpress.XtraEditors.TextEdit curYTKtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton onaylaSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private MainDataSetTableAdapters.MainQueriesTableAdapter mainQueriesTableAdapter;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}