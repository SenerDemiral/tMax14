namespace tMax14.Login
{
    partial class PwdChangeForm
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
            this.CancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.OKsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.oldPwdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.utIdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.newPwdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.newPwd2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.loginQueriesTableAdapter = new tMax14.Login.LoginDataSetTableAdapters.LoginQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldPwdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPwdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPwd2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.newPwd2TextEdit);
            this.layoutControl1.Controls.Add(this.newPwdTextEdit);
            this.layoutControl1.Controls.Add(this.CancelSimpleButton);
            this.layoutControl1.Controls.Add(this.OKsimpleButton);
            this.layoutControl1.Controls.Add(this.oldPwdTextEdit);
            this.layoutControl1.Controls.Add(this.utIdTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(523, 143, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(292, 138);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // CancelSimpleButton
            // 
            this.CancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelSimpleButton.Location = new System.Drawing.Point(7, 103);
            this.CancelSimpleButton.Name = "CancelSimpleButton";
            this.CancelSimpleButton.Size = new System.Drawing.Size(132, 28);
            this.CancelSimpleButton.StyleController = this.layoutControl1;
            this.CancelSimpleButton.TabIndex = 7;
            this.CancelSimpleButton.Text = "Cancel";
            // 
            // OKsimpleButton
            // 
            this.OKsimpleButton.Location = new System.Drawing.Point(143, 103);
            this.OKsimpleButton.Name = "OKsimpleButton";
            this.OKsimpleButton.Size = new System.Drawing.Size(142, 28);
            this.OKsimpleButton.StyleController = this.layoutControl1;
            this.OKsimpleButton.TabIndex = 6;
            this.OKsimpleButton.Text = "OK";
            this.OKsimpleButton.Click += new System.EventHandler(this.OKsimpleButton_Click);
            // 
            // oldPwdTextEdit
            // 
            this.oldPwdTextEdit.Location = new System.Drawing.Point(80, 31);
            this.oldPwdTextEdit.Name = "oldPwdTextEdit";
            this.oldPwdTextEdit.Size = new System.Drawing.Size(205, 20);
            this.oldPwdTextEdit.StyleController = this.layoutControl1;
            this.oldPwdTextEdit.TabIndex = 5;
            // 
            // utIdTextEdit
            // 
            this.utIdTextEdit.Location = new System.Drawing.Point(80, 7);
            this.utIdTextEdit.Name = "utIdTextEdit";
            this.utIdTextEdit.Properties.Mask.EditMask = "d";
            this.utIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.utIdTextEdit.Size = new System.Drawing.Size(205, 20);
            this.utIdTextEdit.StyleController = this.layoutControl1;
            this.utIdTextEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(292, 138);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.OKsimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(136, 96);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(82, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(146, 32);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CancelSimpleButton;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(29, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(136, 32);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.utIdTextEdit;
            this.layoutControlItem1.CustomizationFormText = "Id";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem1.Text = "Id";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.oldPwdTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Password";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem2.Text = "Old Password";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 13);
            // 
            // newPwdTextEdit
            // 
            this.newPwdTextEdit.Location = new System.Drawing.Point(80, 55);
            this.newPwdTextEdit.Name = "newPwdTextEdit";
            this.newPwdTextEdit.Size = new System.Drawing.Size(205, 20);
            this.newPwdTextEdit.StyleController = this.layoutControl1;
            this.newPwdTextEdit.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.newPwdTextEdit;
            this.layoutControlItem5.CustomizationFormText = "New Password";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem5.Text = "New Password";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(70, 13);
            // 
            // newPwd2TextEdit
            // 
            this.newPwd2TextEdit.Location = new System.Drawing.Point(80, 79);
            this.newPwd2TextEdit.Name = "newPwd2TextEdit";
            this.newPwd2TextEdit.Size = new System.Drawing.Size(205, 20);
            this.newPwd2TextEdit.StyleController = this.layoutControl1;
            this.newPwd2TextEdit.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.newPwd2TextEdit;
            this.layoutControlItem6.CustomizationFormText = "New Password";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(282, 24);
            this.layoutControlItem6.Text = "New Password";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(70, 13);
            // 
            // PwdChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 138);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PwdChangeForm";
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldPwdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPwdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPwd2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton CancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton OKsimpleButton;
        private DevExpress.XtraEditors.TextEdit oldPwdTextEdit;
        private DevExpress.XtraEditors.TextEdit utIdTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit newPwd2TextEdit;
        private DevExpress.XtraEditors.TextEdit newPwdTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private LoginDataSetTableAdapters.LoginQueriesTableAdapter loginQueriesTableAdapter;
    }
}