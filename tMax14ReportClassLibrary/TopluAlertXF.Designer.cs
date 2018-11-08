namespace tMax14ReportClassLibrary
{
    partial class TopluAlertXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopluAlertXF));
            this.checkSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.attCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.eMailSendSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.hdrLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.docTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.DOCTableAdapter();
            this.reportDataSet = new tMax14ReportClassLibrary.ReportDataSet();
            this.docSelDetTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.DOC_SEL_DETTableAdapter();
            this.rprTopluAlertTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.RPR_TOPLUALERTTableAdapter();
            this.reportQueriesTableAdapter = new tMax14ReportClassLibrary.ReportDataSetTableAdapters.ReportQueriesTableAdapter();
            this.stuLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // checkSimpleButton
            // 
            this.checkSimpleButton.Location = new System.Drawing.Point(12, 32);
            this.checkSimpleButton.Name = "checkSimpleButton";
            this.checkSimpleButton.Size = new System.Drawing.Size(555, 22);
            this.checkSimpleButton.StyleController = this.layoutControl1;
            this.checkSimpleButton.TabIndex = 6;
            this.checkSimpleButton.Text = "Hazırla / Kontrol";
            this.checkSimpleButton.Click += new System.EventHandler(this.checkSimpleButton_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.stuLabelControl);
            this.layoutControl1.Controls.Add(this.hdrLabelControl);
            this.layoutControl1.Controls.Add(this.attCheckedListBoxControl);
            this.layoutControl1.Controls.Add(this.eMailSendSimpleButton);
            this.layoutControl1.Controls.Add(this.checkSimpleButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(579, 373);
            this.layoutControl1.TabIndex = 9;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // attCheckedListBoxControl
            // 
            this.attCheckedListBoxControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attCheckedListBoxControl.Appearance.Options.UseFont = true;
            this.attCheckedListBoxControl.CheckOnClick = true;
            this.attCheckedListBoxControl.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.attCheckedListBoxControl.ItemAutoHeight = true;
            this.attCheckedListBoxControl.Location = new System.Drawing.Point(12, 58);
            this.attCheckedListBoxControl.Name = "attCheckedListBoxControl";
            this.attCheckedListBoxControl.Size = new System.Drawing.Size(555, 257);
            this.attCheckedListBoxControl.StyleController = this.layoutControl1;
            this.attCheckedListBoxControl.TabIndex = 9;
            // 
            // eMailSendSimpleButton
            // 
            this.eMailSendSimpleButton.Location = new System.Drawing.Point(12, 319);
            this.eMailSendSimpleButton.Name = "eMailSendSimpleButton";
            this.eMailSendSimpleButton.Size = new System.Drawing.Size(555, 22);
            this.eMailSendSimpleButton.StyleController = this.layoutControl1;
            this.eMailSendSimpleButton.TabIndex = 7;
            this.eMailSendSimpleButton.Text = "eMail Gönder";
            this.eMailSendSimpleButton.Click += new System.EventHandler(this.eMailSendSimpleButton_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(579, 373);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkSimpleButton;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(559, 26);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.eMailSendSimpleButton;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 307);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(559, 26);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.attCheckedListBoxControl;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(559, 261);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(24, 24);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "dialog-accept.png");
            this.imageCollection1.Images.SetKeyName(1, "dialog-error-4.png");
            this.imageCollection1.Images.SetKeyName(2, "dialog-important-2.png");
            // 
            // hdrLabelControl
            // 
            this.hdrLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hdrLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.hdrLabelControl.Location = new System.Drawing.Point(12, 12);
            this.hdrLabelControl.Name = "hdrLabelControl";
            this.hdrLabelControl.Size = new System.Drawing.Size(555, 16);
            this.hdrLabelControl.StyleController = this.layoutControl1;
            this.hdrLabelControl.TabIndex = 10;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.hdrLabelControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(559, 20);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // docTableAdapter
            // 
            this.docTableAdapter.ClearBeforeFill = true;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // docSelDetTableAdapter
            // 
            this.docSelDetTableAdapter.ClearBeforeFill = true;
            // 
            // rprTopluAlertTableAdapter
            // 
            this.rprTopluAlertTableAdapter.ClearBeforeFill = true;
            // 
            // stuLabelControl
            // 
            this.stuLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stuLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.stuLabelControl.Location = new System.Drawing.Point(12, 345);
            this.stuLabelControl.Name = "stuLabelControl";
            this.stuLabelControl.Size = new System.Drawing.Size(555, 16);
            this.stuLabelControl.StyleController = this.layoutControl1;
            this.stuLabelControl.TabIndex = 11;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.stuLabelControl;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 333);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(559, 20);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // TopluAlertXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 373);
            this.Controls.Add(this.layoutControl1);
            this.Name = "TopluAlertXF";
            this.Text = "TopluAlertXF";
            this.Load += new System.EventHandler(this.TopluAlertXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportDataSetTableAdapters.DOCTableAdapter docTableAdapter;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.DOC_SEL_DETTableAdapter docSelDetTableAdapter;
        private DevExpress.XtraEditors.SimpleButton checkSimpleButton;
        private DevExpress.XtraEditors.SimpleButton eMailSendSimpleButton;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private ReportDataSetTableAdapters.RPR_TOPLUALERTTableAdapter rprTopluAlertTableAdapter;
        private ReportDataSetTableAdapters.ReportQueriesTableAdapter reportQueriesTableAdapter;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.CheckedListBoxControl attCheckedListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl hdrLabelControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl stuLabelControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}