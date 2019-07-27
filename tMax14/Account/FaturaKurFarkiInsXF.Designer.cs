namespace tMax14.Account
{
    partial class FaturaKurFarkiInsXF
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
            this.ftrNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.topKurFarkiTLtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ftrTrhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.usrTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.refAfbIDtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.accountQueriesTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.AccountQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ftrNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topKurFarkiTLtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAfbIDtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ftrNoTextEdit);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.topKurFarkiTLtextEdit);
            this.layoutControl1.Controls.Add(this.ftrTrhDateEdit);
            this.layoutControl1.Controls.Add(this.usrTextEdit);
            this.layoutControl1.Controls.Add(this.refAfbIDtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(326, 173);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ftrNoTextEdit
            // 
            this.ftrNoTextEdit.Location = new System.Drawing.Point(90, 60);
            this.ftrNoTextEdit.Name = "ftrNoTextEdit";
            this.ftrNoTextEdit.Size = new System.Drawing.Size(224, 20);
            this.ftrNoTextEdit.StyleController = this.layoutControl1;
            this.ftrNoTextEdit.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 132);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(302, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "KurFarkıFaturası Yarat";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // topKurFarkiTLtextEdit
            // 
            this.topKurFarkiTLtextEdit.Location = new System.Drawing.Point(90, 84);
            this.topKurFarkiTLtextEdit.Name = "topKurFarkiTLtextEdit";
            this.topKurFarkiTLtextEdit.Properties.Mask.EditMask = "f";
            this.topKurFarkiTLtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.topKurFarkiTLtextEdit.Size = new System.Drawing.Size(224, 20);
            this.topKurFarkiTLtextEdit.StyleController = this.layoutControl1;
            this.topKurFarkiTLtextEdit.TabIndex = 8;
            // 
            // ftrTrhDateEdit
            // 
            this.ftrTrhDateEdit.EditValue = null;
            this.ftrTrhDateEdit.Location = new System.Drawing.Point(90, 36);
            this.ftrTrhDateEdit.Name = "ftrTrhDateEdit";
            this.ftrTrhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ftrTrhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ftrTrhDateEdit.Size = new System.Drawing.Size(224, 20);
            this.ftrTrhDateEdit.StyleController = this.layoutControl1;
            this.ftrTrhDateEdit.TabIndex = 7;
            // 
            // usrTextEdit
            // 
            this.usrTextEdit.Location = new System.Drawing.Point(90, 108);
            this.usrTextEdit.Name = "usrTextEdit";
            this.usrTextEdit.Properties.ReadOnly = true;
            this.usrTextEdit.Size = new System.Drawing.Size(224, 20);
            this.usrTextEdit.StyleController = this.layoutControl1;
            this.usrTextEdit.TabIndex = 6;
            // 
            // refAfbIDtextEdit
            // 
            this.refAfbIDtextEdit.Location = new System.Drawing.Point(90, 12);
            this.refAfbIDtextEdit.Name = "refAfbIDtextEdit";
            this.refAfbIDtextEdit.Properties.ReadOnly = true;
            this.refAfbIDtextEdit.Size = new System.Drawing.Size(224, 20);
            this.refAfbIDtextEdit.StyleController = this.layoutControl1;
            this.refAfbIDtextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(326, 173);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.refAfbIDtextEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem2.Text = "Referans AfbID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.usrTextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem1.Text = "Usr";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.topKurFarkiTLtextEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem4.Text = "KurFarkı TL";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ftrTrhDateEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem3.Text = "FaturaTarih";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(306, 33);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ftrNoTextEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem6.Text = "FaturaNo";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(75, 13);
            // 
            // FaturaKurFarkiInsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 173);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FaturaKurFarkiInsXF";
            this.Text = "FaturaKurFarkiInsXF";
            this.Load += new System.EventHandler(this.FaturaKurFarkiInsXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ftrNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topKurFarkiTLtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ftrTrhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refAfbIDtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit topKurFarkiTLtextEdit;
        private DevExpress.XtraEditors.DateEdit ftrTrhDateEdit;
        private DevExpress.XtraEditors.TextEdit usrTextEdit;
        private DevExpress.XtraEditors.TextEdit refAfbIDtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private AccountDataSetTableAdapters.AccountQueriesTableAdapter accountQueriesTableAdapter;
        private DevExpress.XtraEditors.TextEdit ftrNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}