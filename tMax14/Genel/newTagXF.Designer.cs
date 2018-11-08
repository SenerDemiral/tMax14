namespace tMax14.Genel
{
    partial class newTagXF
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
            this.TBLtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.TAGtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ADtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Tanım = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBLtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tanım)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ADtextEdit);
            this.layoutControl1.Controls.Add(this.TBLtextEdit);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.TAGtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(265, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TBLtextEdit
            // 
            this.TBLtextEdit.Enabled = false;
            this.TBLtextEdit.Location = new System.Drawing.Point(43, 12);
            this.TBLtextEdit.Name = "TBLtextEdit";
            this.TBLtextEdit.Size = new System.Drawing.Size(210, 20);
            this.TBLtextEdit.StyleController = this.layoutControl1;
            this.TBLtextEdit.TabIndex = 1;
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(12, 84);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(241, 22);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 5;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // TAGtextEdit
            // 
            this.TAGtextEdit.Location = new System.Drawing.Point(43, 36);
            this.TAGtextEdit.Name = "TAGtextEdit";
            this.TAGtextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TAGtextEdit.Properties.Appearance.Options.UseFont = true;
            this.TAGtextEdit.Properties.Mask.EditMask = "([0-9A-Z_:\\+\\-\\*\\/=.]{1,18})";
            this.TAGtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.TAGtextEdit.Size = new System.Drawing.Size(210, 20);
            this.TAGtextEdit.StyleController = this.layoutControl1;
            this.TAGtextEdit.TabIndex = 4;
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
            this.Tanım});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(265, 118);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TAGtextEdit;
            this.layoutControlItem1.CustomizationFormText = "TAG";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(245, 24);
            this.layoutControlItem1.Text = "TAG";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(28, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.OKsimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(245, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TBLtextEdit;
            this.layoutControlItem3.CustomizationFormText = "Tbl";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(245, 24);
            this.layoutControlItem3.Text = "Tbl";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(28, 13);
            // 
            // ADtextEdit
            // 
            this.ADtextEdit.Location = new System.Drawing.Point(43, 60);
            this.ADtextEdit.Name = "ADtextEdit";
            this.ADtextEdit.Properties.MaxLength = 40;
            this.ADtextEdit.Size = new System.Drawing.Size(210, 20);
            this.ADtextEdit.StyleController = this.layoutControl1;
            this.ADtextEdit.TabIndex = 5;
            // 
            // Tanım
            // 
            this.Tanım.Control = this.ADtextEdit;
            this.Tanım.CustomizationFormText = "Tanım";
            this.Tanım.Location = new System.Drawing.Point(0, 48);
            this.Tanım.Name = "Tanım";
            this.Tanım.Size = new System.Drawing.Size(245, 24);
            this.Tanım.Text = "Tanım";
            this.Tanım.TextSize = new System.Drawing.Size(28, 13);
            // 
            // newTagXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(265, 118);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Default;
            this.Name = "newTagXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newTagXF";
            this.Load += new System.EventHandler(this.newTagXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBLtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAGtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tanım)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TAGtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit TBLtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit ADtextEdit;
        private DevExpress.XtraLayout.LayoutControlItem Tanım;
    }
}