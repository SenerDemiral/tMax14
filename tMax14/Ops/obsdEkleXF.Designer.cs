namespace tMax14.Ops
{
    partial class obsdEkleXF
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
            this.GrsTrhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.BasStkNoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.AdetSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.opsQueriesTableAdapter = new tMax14.Ops.OpsDataSetTableAdapters.OpsQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrsTrhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrsTrhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasStkNoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrsTrhDateEdit
            // 
            this.GrsTrhDateEdit.EditValue = null;
            this.GrsTrhDateEdit.Location = new System.Drawing.Point(116, 24);
            this.GrsTrhDateEdit.Name = "GrsTrhDateEdit";
            this.GrsTrhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrsTrhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GrsTrhDateEdit.Size = new System.Drawing.Size(100, 20);
            this.GrsTrhDateEdit.TabIndex = 0;
            // 
            // BasStkNoSpinEdit
            // 
            this.BasStkNoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BasStkNoSpinEdit.Location = new System.Drawing.Point(116, 55);
            this.BasStkNoSpinEdit.Name = "BasStkNoSpinEdit";
            this.BasStkNoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.BasStkNoSpinEdit.Properties.IsFloatValue = false;
            this.BasStkNoSpinEdit.Properties.Mask.EditMask = "N00";
            this.BasStkNoSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.BasStkNoSpinEdit.TabIndex = 1;
            // 
            // AdetSpinEdit
            // 
            this.AdetSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AdetSpinEdit.Location = new System.Drawing.Point(116, 86);
            this.AdetSpinEdit.Name = "AdetSpinEdit";
            this.AdetSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AdetSpinEdit.Properties.IsFloatValue = false;
            this.AdetSpinEdit.Properties.Mask.EditMask = "N00";
            this.AdetSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.AdetSpinEdit.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Giriş Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Başlangıç Stok No";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Adet";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(116, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // obsdEkleXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 160);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.AdetSpinEdit);
            this.Controls.Add(this.BasStkNoSpinEdit);
            this.Controls.Add(this.GrsTrhDateEdit);
            this.Name = "obsdEkleXF";
            this.Text = "obsdEkleXF";
            ((System.ComponentModel.ISupportInitialize)(this.GrsTrhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrsTrhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasStkNoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdetSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit GrsTrhDateEdit;
        private DevExpress.XtraEditors.SpinEdit BasStkNoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit AdetSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private OpsDataSetTableAdapters.OpsQueriesTableAdapter opsQueriesTableAdapter;
    }
}