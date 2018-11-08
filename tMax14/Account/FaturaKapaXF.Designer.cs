namespace tMax14.Account
{
    partial class FaturaKapaXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dknNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.kapaSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ftrTrhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ftrNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dknNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.dknNoTextEdit);
            this.layoutControl1.Controls.Add(this.kapaSimpleButton);
            this.layoutControl1.Controls.Add(this.ftrTrhDateEdit);
            this.layoutControl1.Controls.Add(this.ftrNoTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(219, 132);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dknNoTextEdit
            // 
            this.dknNoTextEdit.Location = new System.Drawing.Point(74, 60);
            this.dknNoTextEdit.Name = "dknNoTextEdit";
            this.dknNoTextEdit.Properties.MaxLength = 20;
            this.dknNoTextEdit.Size = new System.Drawing.Size(133, 20);
            this.dknNoTextEdit.StyleController = this.layoutControl1;
            this.dknNoTextEdit.TabIndex = 1;
            // 
            // kapaSimpleButton
            // 
            this.kapaSimpleButton.Location = new System.Drawing.Point(12, 84);
            this.kapaSimpleButton.Name = "kapaSimpleButton";
            this.kapaSimpleButton.Size = new System.Drawing.Size(195, 36);
            this.kapaSimpleButton.StyleController = this.layoutControl1;
            this.kapaSimpleButton.TabIndex = 6;
            this.kapaSimpleButton.Text = "Kapa";
            this.kapaSimpleButton.Click += new System.EventHandler(this.kapaSimpleButton_Click);
            // 
            // ftrTrhDateEdit
            // 
            this.ftrTrhDateEdit.EditValue = null;
            this.ftrTrhDateEdit.Location = new System.Drawing.Point(74, 36);
            this.ftrTrhDateEdit.Name = "ftrTrhDateEdit";
            this.ftrTrhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ftrTrhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ftrTrhDateEdit.Size = new System.Drawing.Size(133, 20);
            this.ftrTrhDateEdit.StyleController = this.layoutControl1;
            this.ftrTrhDateEdit.TabIndex = 5;
            // 
            // ftrNoTextEdit
            // 
            this.ftrNoTextEdit.Location = new System.Drawing.Point(74, 12);
            this.ftrNoTextEdit.Name = "ftrNoTextEdit";
            this.ftrNoTextEdit.Properties.MaxLength = 20;
            this.ftrNoTextEdit.Size = new System.Drawing.Size(133, 20);
            this.ftrNoTextEdit.StyleController = this.layoutControl1;
            this.ftrNoTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(219, 132);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ftrNoTextEdit;
            this.layoutControlItem1.CustomizationFormText = "Fatura No";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem1.Text = "Fatura No";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ftrTrhDateEdit;
            this.layoutControlItem2.CustomizationFormText = "Fatura Tarih";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem2.Text = "Fatura Tarih";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.kapaSimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(39, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dknNoTextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem4.Text = "Dekont No";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(59, 13);
            // 
            // FaturaKapaXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 132);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FaturaKapaXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaKapaXF";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dknNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton kapaSimpleButton;
        private DevExpress.XtraEditors.DateEdit ftrTrhDateEdit;
        private DevExpress.XtraEditors.TextEdit ftrNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private DevExpress.XtraEditors.TextEdit dknNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}