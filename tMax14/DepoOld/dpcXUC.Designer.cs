namespace tMax14.DepoOld
{
    partial class dpcXUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.depoOldDataSet = new tMax14.DepoOld.DepoOldDataSet();
            this.depoDPCselBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoDPCselTableAdapter = new tMax14.DepoOld.DepoOldDataSetTableAdapters.DepoDPCselTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.lM_TSToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lM_TSToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.depoDPCselGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDPCRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHBRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBRF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHBINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMBINFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.MBmemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.HBmemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOGULK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSULK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCIKTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.depoOldDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDPCselBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoDPCselGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBmemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HBmemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // depoOldDataSet
            // 
            this.depoOldDataSet.DataSetName = "DepoOldDataSet";
            this.depoOldDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depoDPCselBindingSource
            // 
            this.depoDPCselBindingSource.DataMember = "DepoDPCsel";
            this.depoDPCselBindingSource.DataSource = this.depoOldDataSet;
            // 
            // depoDPCselTableAdapter
            // 
            this.depoDPCselTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lM_TSToolStripLabel,
            this.lM_TSToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(856, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // lM_TSToolStripLabel
            // 
            this.lM_TSToolStripLabel.Name = "lM_TSToolStripLabel";
            this.lM_TSToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.lM_TSToolStripLabel.Text = "LM_TS:";
            // 
            // lM_TSToolStripTextBox
            // 
            this.lM_TSToolStripTextBox.Name = "lM_TSToolStripTextBox";
            this.lM_TSToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.lM_TSToolStripTextBox.Text = "01.01.2013";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // depoDPCselGridControl
            // 
            this.depoDPCselGridControl.DataSource = this.depoDPCselBindingSource;
            this.depoDPCselGridControl.Location = new System.Drawing.Point(12, 28);
            this.depoDPCselGridControl.MainView = this.gridView1;
            this.depoDPCselGridControl.Name = "depoDPCselGridControl";
            this.depoDPCselGridControl.Size = new System.Drawing.Size(467, 288);
            this.depoDPCselGridControl.TabIndex = 2;
            this.depoDPCselGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDPCRF,
            this.colCIKTRH,
            this.colHBRF,
            this.colMBRF,
            this.colHBINFO,
            this.colMBINFO,
            this.colROT,
            this.colMOT,
            this.colOGULK,
            this.colDSULK});
            this.gridView1.GridControl = this.depoDPCselGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colDPCRF
            // 
            this.colDPCRF.FieldName = "DPCRF";
            this.colDPCRF.MaxWidth = 70;
            this.colDPCRF.Name = "colDPCRF";
            this.colDPCRF.OptionsColumn.FixedWidth = true;
            this.colDPCRF.Visible = true;
            this.colDPCRF.VisibleIndex = 0;
            this.colDPCRF.Width = 60;
            // 
            // colHBRF
            // 
            this.colHBRF.FieldName = "HBRF";
            this.colHBRF.MaxWidth = 70;
            this.colHBRF.Name = "colHBRF";
            this.colHBRF.OptionsColumn.FixedWidth = true;
            this.colHBRF.Visible = true;
            this.colHBRF.VisibleIndex = 2;
            this.colHBRF.Width = 60;
            // 
            // colMBRF
            // 
            this.colMBRF.FieldName = "MBRF";
            this.colMBRF.MaxWidth = 70;
            this.colMBRF.Name = "colMBRF";
            this.colMBRF.OptionsColumn.FixedWidth = true;
            this.colMBRF.Visible = true;
            this.colMBRF.VisibleIndex = 3;
            this.colMBRF.Width = 60;
            // 
            // colHBINFO
            // 
            this.colHBINFO.FieldName = "HBINFO";
            this.colHBINFO.Name = "colHBINFO";
            // 
            // colMBINFO
            // 
            this.colMBINFO.FieldName = "MBINFO";
            this.colMBINFO.Name = "colMBINFO";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.MBmemoEdit);
            this.layoutControl1.Controls.Add(this.HBmemoEdit);
            this.layoutControl1.Controls.Add(this.depoDPCselGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 25);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1009, 132, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(856, 328);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // MBmemoEdit
            // 
            this.MBmemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depoDPCselBindingSource, "MBINFO", true));
            this.MBmemoEdit.Location = new System.Drawing.Point(677, 28);
            this.MBmemoEdit.Name = "MBmemoEdit";
            this.MBmemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MBmemoEdit.Properties.Appearance.Options.UseFont = true;
            this.MBmemoEdit.Size = new System.Drawing.Size(167, 288);
            this.MBmemoEdit.StyleController = this.layoutControl1;
            this.MBmemoEdit.TabIndex = 5;
            // 
            // HBmemoEdit
            // 
            this.HBmemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depoDPCselBindingSource, "HBINFO", true));
            this.HBmemoEdit.Location = new System.Drawing.Point(488, 28);
            this.HBmemoEdit.Name = "HBmemoEdit";
            this.HBmemoEdit.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HBmemoEdit.Properties.Appearance.Options.UseFont = true;
            this.HBmemoEdit.Size = new System.Drawing.Size(180, 288);
            this.HBmemoEdit.StyleController = this.layoutControl1;
            this.HBmemoEdit.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.splitterItem1,
            this.splitterItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(856, 328);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.depoDPCselGridControl;
            this.layoutControlItem1.CustomizationFormText = "Depo Çıkışları";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(471, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(258, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(471, 308);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Depo Çıkışları";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.HBmemoEdit;
            this.layoutControlItem2.CustomizationFormText = "House";
            this.layoutControlItem2.Location = new System.Drawing.Point(476, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(184, 308);
            this.layoutControlItem2.Text = "House";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.MBmemoEdit;
            this.layoutControlItem3.CustomizationFormText = "Master";
            this.layoutControlItem3.Location = new System.Drawing.Point(665, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(171, 308);
            this.layoutControlItem3.Text = "Master";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(63, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(471, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 308);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(660, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(5, 308);
            // 
            // colROT
            // 
            this.colROT.AppearanceCell.Options.UseTextOptions = true;
            this.colROT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROT.AppearanceHeader.Options.UseTextOptions = true;
            this.colROT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colROT.FieldName = "ROT";
            this.colROT.MaxWidth = 40;
            this.colROT.Name = "colROT";
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 4;
            this.colROT.Width = 40;
            // 
            // colMOT
            // 
            this.colMOT.AppearanceCell.Options.UseTextOptions = true;
            this.colMOT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.FieldName = "MOT";
            this.colMOT.MaxWidth = 40;
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 5;
            this.colMOT.Width = 40;
            // 
            // colOGULK
            // 
            this.colOGULK.AppearanceCell.Options.UseTextOptions = true;
            this.colOGULK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOGULK.AppearanceHeader.Options.UseTextOptions = true;
            this.colOGULK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOGULK.Caption = "Org";
            this.colOGULK.FieldName = "OGULK";
            this.colOGULK.MaxWidth = 40;
            this.colOGULK.Name = "colOGULK";
            this.colOGULK.Visible = true;
            this.colOGULK.VisibleIndex = 6;
            this.colOGULK.Width = 40;
            // 
            // colDSULK
            // 
            this.colDSULK.AppearanceCell.Options.UseTextOptions = true;
            this.colDSULK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSULK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDSULK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDSULK.Caption = "Dst";
            this.colDSULK.FieldName = "DSULK";
            this.colDSULK.MaxWidth = 40;
            this.colDSULK.Name = "colDSULK";
            this.colDSULK.Visible = true;
            this.colDSULK.VisibleIndex = 7;
            this.colDSULK.Width = 40;
            // 
            // colCIKTRH
            // 
            this.colCIKTRH.Caption = "ÇıkTrh";
            this.colCIKTRH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colCIKTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCIKTRH.FieldName = "CIKTRH";
            this.colCIKTRH.MaxWidth = 82;
            this.colCIKTRH.Name = "colCIKTRH";
            this.colCIKTRH.Visible = true;
            this.colCIKTRH.VisibleIndex = 1;
            // 
            // dpcXUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "dpcXUC";
            this.Size = new System.Drawing.Size(856, 353);
            ((System.ComponentModel.ISupportInitialize)(this.depoOldDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoDPCselBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoDPCselGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MBmemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HBmemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DepoOldDataSet depoOldDataSet;
        private System.Windows.Forms.BindingSource depoDPCselBindingSource;
        private DepoOldDataSetTableAdapters.DepoDPCselTableAdapter depoDPCselTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel lM_TSToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lM_TSToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl depoDPCselGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDPCRF;
        private DevExpress.XtraGrid.Columns.GridColumn colHBRF;
        private DevExpress.XtraGrid.Columns.GridColumn colMBRF;
        private DevExpress.XtraGrid.Columns.GridColumn colHBINFO;
        private DevExpress.XtraGrid.Columns.GridColumn colMBINFO;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit MBmemoEdit;
        private DevExpress.XtraEditors.MemoEdit HBmemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colCIKTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colOGULK;
        private DevExpress.XtraGrid.Columns.GridColumn colDSULK;
    }
}
