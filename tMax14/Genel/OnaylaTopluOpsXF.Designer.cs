namespace tMax14.Genel
{
    partial class OnaylaTopluOpsXF
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.onaylaSetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.genelQueriesTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.GenelQueriesTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "ATD <";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(44, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(144, 20);
            this.dateEdit1.TabIndex = 16;
            // 
            // onaylaSetSimpleButton
            // 
            this.onaylaSetSimpleButton.Location = new System.Drawing.Point(12, 44);
            this.onaylaSetSimpleButton.Name = "onaylaSetSimpleButton";
            this.onaylaSetSimpleButton.Size = new System.Drawing.Size(176, 22);
            this.onaylaSetSimpleButton.TabIndex = 15;
            this.onaylaSetSimpleButton.Text = "ONAYLA";
            this.onaylaSetSimpleButton.Click += new System.EventHandler(this.onaylaSetSimpleButton_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(12, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(174, 39);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Belirtilen tarihden önceki OpsMaster kayıtlarrında CRM ve ITL olan yetkiler MPS y" +
    "apılacaktır.";
            // 
            // OnaylaTopluOpsXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 120);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.onaylaSetSimpleButton);
            this.Name = "OnaylaTopluOpsXF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnaylaTopluOpsXF";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton onaylaSetSimpleButton;
        private GenelDataSetTableAdapters.GenelQueriesTableAdapter genelQueriesTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}