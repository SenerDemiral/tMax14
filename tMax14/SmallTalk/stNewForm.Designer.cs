namespace tMax14.SmallTalk
{
    partial class stNewForm
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
            this.tagTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.catLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.msjMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.sbjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.roomLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.roomLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.sbjLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.msjLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.catLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.tagLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.smallTalkQueriesTableAdapter = new tMax14.SmallTalk.SmallTalkDataSetTableAdapters.SmallTalkQueriesTableAdapter();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbjLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cancelSimpleButton);
            this.layoutControl1.Controls.Add(this.tagTextEdit);
            this.layoutControl1.Controls.Add(this.catLookUpEdit);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.msjMemoEdit);
            this.layoutControl1.Controls.Add(this.sbjTextEdit);
            this.layoutControl1.Controls.Add(this.roomLookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(727, 88, 469, 549);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(412, 273);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tagTextEdit
            // 
            this.tagTextEdit.Location = new System.Drawing.Point(84, 84);
            this.tagTextEdit.Name = "tagTextEdit";
            this.tagTextEdit.Properties.Mask.EditMask = "(<(\\-?[0-9A-Z]+)+>)+";
            this.tagTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tagTextEdit.Size = new System.Drawing.Size(316, 20);
            this.tagTextEdit.StyleController = this.layoutControl1;
            this.tagTextEdit.TabIndex = 6;
            // 
            // catLookUpEdit
            // 
            this.catLookUpEdit.Location = new System.Drawing.Point(84, 36);
            this.catLookUpEdit.Name = "catLookUpEdit";
            this.catLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.catLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VAL", "KonuŞeki"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", 10, "Id")});
            this.catLookUpEdit.Size = new System.Drawing.Size(316, 20);
            this.catLookUpEdit.StyleController = this.layoutControl1;
            this.catLookUpEdit.TabIndex = 5;
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(129, 239);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(271, 22);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 7;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // msjMemoEdit
            // 
            this.msjMemoEdit.Location = new System.Drawing.Point(12, 124);
            this.msjMemoEdit.Name = "msjMemoEdit";
            this.msjMemoEdit.Size = new System.Drawing.Size(388, 111);
            this.msjMemoEdit.StyleController = this.layoutControl1;
            this.msjMemoEdit.TabIndex = 6;
            // 
            // sbjTextEdit
            // 
            this.sbjTextEdit.Location = new System.Drawing.Point(84, 60);
            this.sbjTextEdit.Name = "sbjTextEdit";
            this.sbjTextEdit.Size = new System.Drawing.Size(316, 20);
            this.sbjTextEdit.StyleController = this.layoutControl1;
            this.sbjTextEdit.TabIndex = 5;
            // 
            // roomLookUpEdit
            // 
            this.roomLookUpEdit.Location = new System.Drawing.Point(84, 12);
            this.roomLookUpEdit.Name = "roomLookUpEdit";
            this.roomLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roomLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "TalkRoom"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STRID", 10, "Id")});
            this.roomLookUpEdit.Size = new System.Drawing.Size(316, 20);
            this.roomLookUpEdit.StyleController = this.layoutControl1;
            this.roomLookUpEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.roomLayoutControlItem,
            this.sbjLayoutControlItem,
            this.msjLayoutControlItem,
            this.layoutControlItem1,
            this.catLayoutControlItem,
            this.tagLayoutControlItem,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(412, 273);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // roomLayoutControlItem
            // 
            this.roomLayoutControlItem.Control = this.roomLookUpEdit;
            this.roomLayoutControlItem.CustomizationFormText = "Cell";
            this.roomLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.roomLayoutControlItem.Name = "roomLayoutControlItem";
            this.roomLayoutControlItem.Size = new System.Drawing.Size(392, 24);
            this.roomLayoutControlItem.Text = "Room";
            this.roomLayoutControlItem.TextSize = new System.Drawing.Size(69, 13);
            this.roomLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // sbjLayoutControlItem
            // 
            this.sbjLayoutControlItem.Control = this.sbjTextEdit;
            this.sbjLayoutControlItem.CustomizationFormText = "Konu";
            this.sbjLayoutControlItem.Location = new System.Drawing.Point(0, 48);
            this.sbjLayoutControlItem.Name = "sbjLayoutControlItem";
            this.sbjLayoutControlItem.Size = new System.Drawing.Size(392, 24);
            this.sbjLayoutControlItem.Text = "Subject";
            this.sbjLayoutControlItem.TextSize = new System.Drawing.Size(69, 13);
            this.sbjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // msjLayoutControlItem
            // 
            this.msjLayoutControlItem.Control = this.msjMemoEdit;
            this.msjLayoutControlItem.CustomizationFormText = "Mesaj";
            this.msjLayoutControlItem.Location = new System.Drawing.Point(0, 96);
            this.msjLayoutControlItem.Name = "msjLayoutControlItem";
            this.msjLayoutControlItem.Size = new System.Drawing.Size(392, 131);
            this.msjLayoutControlItem.Text = "Message Body";
            this.msjLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            this.msjLayoutControlItem.TextSize = new System.Drawing.Size(69, 13);
            this.msjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.OKsimpleButton;
            this.layoutControlItem1.CustomizationFormText = "OK";
            this.layoutControlItem1.Location = new System.Drawing.Point(117, 227);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(275, 26);
            this.layoutControlItem1.Text = "OK";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // catLayoutControlItem
            // 
            this.catLayoutControlItem.Control = this.catLookUpEdit;
            this.catLayoutControlItem.CustomizationFormText = "Category";
            this.catLayoutControlItem.Location = new System.Drawing.Point(0, 24);
            this.catLayoutControlItem.Name = "catLayoutControlItem";
            this.catLayoutControlItem.Size = new System.Drawing.Size(392, 24);
            this.catLayoutControlItem.Text = "Category";
            this.catLayoutControlItem.TextSize = new System.Drawing.Size(69, 13);
            // 
            // tagLayoutControlItem
            // 
            this.tagLayoutControlItem.Control = this.tagTextEdit;
            this.tagLayoutControlItem.CustomizationFormText = "Tag";
            this.tagLayoutControlItem.Location = new System.Drawing.Point(0, 72);
            this.tagLayoutControlItem.Name = "tagLayoutControlItem";
            this.tagLayoutControlItem.Size = new System.Drawing.Size(392, 24);
            this.tagLayoutControlItem.Text = "TAG";
            this.tagLayoutControlItem.TextSize = new System.Drawing.Size(69, 13);
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSimpleButton.Location = new System.Drawing.Point(12, 239);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(113, 22);
            this.cancelSimpleButton.StyleController = this.layoutControl1;
            this.cancelSimpleButton.TabIndex = 8;
            this.cancelSimpleButton.Text = "Cancel";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cancelSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 227);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // stNewForm
            // 
            this.AcceptButton = this.OKsimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelSimpleButton;
            this.ClientSize = new System.Drawing.Size(412, 273);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stNewForm";
            this.Load += new System.EventHandler(this.stNewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tagTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbjLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit tagTextEdit;
        private DevExpress.XtraEditors.LookUpEdit catLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraEditors.MemoEdit msjMemoEdit;
        private DevExpress.XtraEditors.TextEdit sbjTextEdit;
        private DevExpress.XtraEditors.LookUpEdit roomLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem roomLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem sbjLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem msjLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem catLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem tagLayoutControlItem;
        private SmallTalkDataSetTableAdapters.SmallTalkQueriesTableAdapter smallTalkQueriesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}