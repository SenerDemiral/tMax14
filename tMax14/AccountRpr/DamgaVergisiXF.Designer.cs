namespace tMax14.AccountRpr
{
    partial class DamgaVergisiXF
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
            this.accountRprDataSet = new tMax14.AccountRpr.AccountRprDataSet();
            this.dAMGAV_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAMGAV_SELTableAdapter = new tMax14.AccountRpr.AccountRprDataSetTableAdapters.DAMGAV_SELTableAdapter();
            this.dAMGAV_SELGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPULNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sonPulNoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAMGAV_SELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAMGAV_SELGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sonPulNoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // accountRprDataSet
            // 
            this.accountRprDataSet.DataSetName = "AccountRprDataSet";
            this.accountRprDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dAMGAV_SELBindingSource
            // 
            this.dAMGAV_SELBindingSource.DataMember = "DAMGAV_SEL";
            this.dAMGAV_SELBindingSource.DataSource = this.accountRprDataSet;
            // 
            // dAMGAV_SELTableAdapter
            // 
            this.dAMGAV_SELTableAdapter.ClearBeforeFill = true;
            // 
            // dAMGAV_SELGridControl
            // 
            this.dAMGAV_SELGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.dAMGAV_SELGridControl.DataSource = this.dAMGAV_SELBindingSource;
            this.dAMGAV_SELGridControl.Location = new System.Drawing.Point(12, 38);
            this.dAMGAV_SELGridControl.MainView = this.gridView1;
            this.dAMGAV_SELGridControl.Name = "dAMGAV_SELGridControl";
            this.dAMGAV_SELGridControl.Size = new System.Drawing.Size(744, 351);
            this.dAMGAV_SELGridControl.TabIndex = 2;
            this.dAMGAV_SELGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSIRANO,
            this.colMOT,
            this.colDST,
            this.colTARIH,
            this.colPULNO,
            this.colREFNO,
            this.colFIYAT,
            this.colMID,
            this.colHID});
            this.gridView1.GridControl = this.dAMGAV_SELGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSIRANO
            // 
            this.colSIRANO.AppearanceCell.Options.UseTextOptions = true;
            this.colSIRANO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSIRANO.AppearanceHeader.Options.UseTextOptions = true;
            this.colSIRANO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSIRANO.Caption = "Sıra No";
            this.colSIRANO.DisplayFormat.FormatString = "n0";
            this.colSIRANO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.Visible = true;
            this.colSIRANO.VisibleIndex = 0;
            this.colSIRANO.Width = 86;
            // 
            // colMOT
            // 
            this.colMOT.AppearanceCell.Options.UseTextOptions = true;
            this.colMOT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMOT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 1;
            this.colMOT.Width = 86;
            // 
            // colDST
            // 
            this.colDST.AppearanceCell.Options.UseTextOptions = true;
            this.colDST.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDST.AppearanceHeader.Options.UseTextOptions = true;
            this.colDST.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDST.Caption = "Destinasyon";
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 2;
            this.colDST.Width = 86;
            // 
            // colTARIH
            // 
            this.colTARIH.AppearanceCell.Options.UseTextOptions = true;
            this.colTARIH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTARIH.AppearanceHeader.Options.UseTextOptions = true;
            this.colTARIH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTARIH.Caption = "Tarih";
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 3;
            this.colTARIH.Width = 86;
            // 
            // colPULNO
            // 
            this.colPULNO.AppearanceCell.Options.UseTextOptions = true;
            this.colPULNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPULNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colPULNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPULNO.Caption = "Pul No";
            this.colPULNO.DisplayFormat.FormatString = "n0";
            this.colPULNO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPULNO.FieldName = "PULNO";
            this.colPULNO.Name = "colPULNO";
            this.colPULNO.Visible = true;
            this.colPULNO.VisibleIndex = 4;
            this.colPULNO.Width = 86;
            // 
            // colREFNO
            // 
            this.colREFNO.AppearanceCell.Options.UseTextOptions = true;
            this.colREFNO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFNO.AppearanceHeader.Options.UseTextOptions = true;
            this.colREFNO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colREFNO.Caption = "Ref No";
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 5;
            this.colREFNO.Width = 86;
            // 
            // colFIYAT
            // 
            this.colFIYAT.AppearanceCell.Options.UseTextOptions = true;
            this.colFIYAT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIYAT.AppearanceHeader.Options.UseTextOptions = true;
            this.colFIYAT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFIYAT.Caption = "Fiyat";
            this.colFIYAT.FieldName = "FIYAT";
            this.colFIYAT.Name = "colFIYAT";
            this.colFIYAT.Visible = true;
            this.colFIYAT.VisibleIndex = 6;
            this.colFIYAT.Width = 100;
            // 
            // colMID
            // 
            this.colMID.AppearanceCell.Options.UseTextOptions = true;
            this.colMID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMID.AppearanceHeader.Options.UseTextOptions = true;
            this.colMID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMID.Caption = "mID";
            this.colMID.DisplayFormat.FormatString = "n0";
            this.colMID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            this.colMID.Visible = true;
            this.colMID.VisibleIndex = 7;
            this.colMID.Width = 60;
            // 
            // colHID
            // 
            this.colHID.AppearanceCell.Options.UseTextOptions = true;
            this.colHID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHID.AppearanceHeader.Options.UseTextOptions = true;
            this.colHID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHID.Caption = "hID";
            this.colHID.DisplayFormat.FormatString = "n0";
            this.colHID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHID.FieldName = "HID";
            this.colHID.Name = "colHID";
            this.colHID.Visible = true;
            this.colHID.VisibleIndex = 8;
            this.colHID.Width = 60;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(66, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(69, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sonPulNoSpinEdit);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.dAMGAV_SELGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(572, 446, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(768, 401);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sonPulNoSpinEdit
            // 
            this.sonPulNoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sonPulNoSpinEdit.Location = new System.Drawing.Point(193, 12);
            this.sonPulNoSpinEdit.Name = "sonPulNoSpinEdit";
            this.sonPulNoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sonPulNoSpinEdit.Properties.IsFloatValue = false;
            this.sonPulNoSpinEdit.Properties.Mask.EditMask = "N00";
            this.sonPulNoSpinEdit.Size = new System.Drawing.Size(66, 20);
            this.sonPulNoSpinEdit.StyleController = this.layoutControl1;
            this.sonPulNoSpinEdit.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(263, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(493, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Fill";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(768, 401);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dAMGAV_SELGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(748, 355);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(127, 26);
            this.layoutControlItem2.Text = "Tarih";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(251, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(497, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sonPulNoSpinEdit;
            this.layoutControlItem4.Location = new System.Drawing.Point(127, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 26);
            this.layoutControlItem4.Text = "Son Pul No";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            // 
            // DamgaVergisiXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 401);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DamgaVergisiXF";
            this.Text = "DamgaVergisiXF";
            ((System.ComponentModel.ISupportInitialize)(this.accountRprDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAMGAV_SELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAMGAV_SELGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sonPulNoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountRprDataSet accountRprDataSet;
        private System.Windows.Forms.BindingSource dAMGAV_SELBindingSource;
        private AccountRprDataSetTableAdapters.DAMGAV_SELTableAdapter dAMGAV_SELTableAdapter;
        private DevExpress.XtraGrid.GridControl dAMGAV_SELGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colPULNO;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colHID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit sonPulNoSpinEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}