namespace tMax14mnf
{
    partial class loginXF
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
            this.loginSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.pwdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IDtextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.queriesTableAdapter = new tMax14mnf.DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pwdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDtextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.loginSimpleButton);
            this.layoutControl1.Controls.Add(this.pwdTextEdit);
            this.layoutControl1.Controls.Add(this.IDtextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(292, 104);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // loginSimpleButton
            // 
            this.loginSimpleButton.Location = new System.Drawing.Point(12, 60);
            this.loginSimpleButton.Name = "loginSimpleButton";
            this.loginSimpleButton.Size = new System.Drawing.Size(268, 32);
            this.loginSimpleButton.StyleController = this.layoutControl1;
            this.loginSimpleButton.TabIndex = 6;
            this.loginSimpleButton.Text = "Login";
            this.loginSimpleButton.Click += new System.EventHandler(this.loginSimpleButton_Click);
            // 
            // pwdTextEdit
            // 
            this.pwdTextEdit.EditValue = "";
            this.pwdTextEdit.Location = new System.Drawing.Point(94, 36);
            this.pwdTextEdit.Name = "pwdTextEdit";
            this.pwdTextEdit.Size = new System.Drawing.Size(186, 20);
            this.pwdTextEdit.StyleController = this.layoutControl1;
            this.pwdTextEdit.TabIndex = 5;
            // 
            // IDtextEdit
            // 
            this.IDtextEdit.EditValue = "10827";
            this.IDtextEdit.Location = new System.Drawing.Point(94, 12);
            this.IDtextEdit.Name = "IDtextEdit";
            this.IDtextEdit.Size = new System.Drawing.Size(186, 20);
            this.IDtextEdit.StyleController = this.layoutControl1;
            this.IDtextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(292, 104);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.IDtextEdit;
            this.layoutControlItem1.CustomizationFormText = "Agent ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(272, 24);
            this.layoutControlItem1.Text = "Manufacturer ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pwdTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Password";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(272, 24);
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.loginSimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(40, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(272, 36);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // loginXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 104);
            this.Controls.Add(this.layoutControl1);
            this.Name = "loginXF";
            this.Text = "loginXF";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pwdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDtextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton loginSimpleButton;
        private DevExpress.XtraEditors.TextEdit pwdTextEdit;
        private DevExpress.XtraEditors.TextEdit IDtextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
    }
}