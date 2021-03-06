﻿namespace tMax14.Account
{
    partial class MizanXF
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
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.accMizanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accMizanTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.ACC_MIZANTableAdapter();
            this.accMizanGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accMizanGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHSPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHSPAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBRCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKLNTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colH5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVRBRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVRALC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVRBRCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVRALCKLN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.DvrCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.SklAslCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.fillSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMizanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMizanGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accMizanGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvrCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SklAslCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accMizanBindingSource
            // 
            this.accMizanBindingSource.DataMember = "ACC_MIZAN";
            this.accMizanBindingSource.DataSource = this.accountDataSet;
            // 
            // accMizanTableAdapter
            // 
            this.accMizanTableAdapter.ClearBeforeFill = true;
            // 
            // accMizanGridControl
            // 
            this.accMizanGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.accMizanGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.accMizanGridControl.DataSource = this.accMizanBindingSource;
            this.accMizanGridControl.Location = new System.Drawing.Point(12, 38);
            this.accMizanGridControl.MainView = this.accMizanGridView;
            this.accMizanGridControl.Name = "accMizanGridControl";
            this.accMizanGridControl.Size = new System.Drawing.Size(946, 288);
            this.accMizanGridControl.TabIndex = 2;
            this.accMizanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accMizanGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // accMizanGridView
            // 
            this.accMizanGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHSPNO,
            this.colHSPAD,
            this.colBRC,
            this.colALC,
            this.colBRCKLN,
            this.colALCKLN,
            this.colKLNTUR,
            this.colLVL,
            this.colH1,
            this.colH2,
            this.colH3,
            this.colH4,
            this.colH5,
            this.colDVRBRC,
            this.colDVRALC,
            this.colDVRBRCKLN,
            this.colDVRALCKLN});
            this.accMizanGridView.GridControl = this.accMizanGridControl;
            this.accMizanGridView.Name = "accMizanGridView";
            this.accMizanGridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // colHSPNO
            // 
            this.colHSPNO.Caption = "HspNo";
            this.colHSPNO.FieldName = "HSPNO";
            this.colHSPNO.Name = "colHSPNO";
            this.colHSPNO.Visible = true;
            this.colHSPNO.VisibleIndex = 0;
            this.colHSPNO.Width = 97;
            // 
            // colHSPAD
            // 
            this.colHSPAD.Caption = "HspAd";
            this.colHSPAD.FieldName = "HSPAD";
            this.colHSPAD.Name = "colHSPAD";
            this.colHSPAD.Visible = true;
            this.colHSPAD.VisibleIndex = 1;
            this.colHSPAD.Width = 222;
            // 
            // colBRC
            // 
            this.colBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBRC.Caption = "Brç";
            this.colBRC.DisplayFormat.FormatString = "n";
            this.colBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRC.FieldName = "BRC";
            this.colBRC.Name = "colBRC";
            this.colBRC.Visible = true;
            this.colBRC.VisibleIndex = 3;
            this.colBRC.Width = 90;
            // 
            // colALC
            // 
            this.colALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colALC.Caption = "Alc";
            this.colALC.DisplayFormat.FormatString = "n";
            this.colALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colALC.FieldName = "ALC";
            this.colALC.Name = "colALC";
            this.colALC.Visible = true;
            this.colALC.VisibleIndex = 4;
            this.colALC.Width = 90;
            // 
            // colBRCKLN
            // 
            this.colBRCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colBRCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBRCKLN.Caption = "BrçBky";
            this.colBRCKLN.DisplayFormat.FormatString = "n";
            this.colBRCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBRCKLN.FieldName = "BRCKLN";
            this.colBRCKLN.Name = "colBRCKLN";
            this.colBRCKLN.Visible = true;
            this.colBRCKLN.VisibleIndex = 5;
            this.colBRCKLN.Width = 90;
            // 
            // colALCKLN
            // 
            this.colALCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colALCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colALCKLN.Caption = "AlcBky";
            this.colALCKLN.DisplayFormat.FormatString = "n";
            this.colALCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colALCKLN.FieldName = "ALCKLN";
            this.colALCKLN.Name = "colALCKLN";
            this.colALCKLN.Visible = true;
            this.colALCKLN.VisibleIndex = 6;
            this.colALCKLN.Width = 95;
            // 
            // colKLNTUR
            // 
            this.colKLNTUR.AppearanceCell.Options.UseTextOptions = true;
            this.colKLNTUR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKLNTUR.Caption = "BkyTür";
            this.colKLNTUR.FieldName = "KLNTUR";
            this.colKLNTUR.Name = "colKLNTUR";
            this.colKLNTUR.OptionsColumn.FixedWidth = true;
            this.colKLNTUR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colKLNTUR.Visible = true;
            this.colKLNTUR.VisibleIndex = 2;
            this.colKLNTUR.Width = 40;
            // 
            // colLVL
            // 
            this.colLVL.AppearanceCell.Options.UseTextOptions = true;
            this.colLVL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLVL.AppearanceHeader.Options.UseTextOptions = true;
            this.colLVL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLVL.Caption = "Lvl";
            this.colLVL.FieldName = "LVL";
            this.colLVL.Name = "colLVL";
            this.colLVL.OptionsColumn.FixedWidth = true;
            this.colLVL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLVL.Width = 30;
            // 
            // colH1
            // 
            this.colH1.AppearanceCell.Options.UseTextOptions = true;
            this.colH1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH1.AppearanceHeader.Options.UseTextOptions = true;
            this.colH1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH1.FieldName = "H1";
            this.colH1.Name = "colH1";
            this.colH1.OptionsColumn.FixedWidth = true;
            this.colH1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colH1.Width = 34;
            // 
            // colH2
            // 
            this.colH2.AppearanceCell.Options.UseTextOptions = true;
            this.colH2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH2.AppearanceHeader.Options.UseTextOptions = true;
            this.colH2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH2.FieldName = "H2";
            this.colH2.Name = "colH2";
            this.colH2.OptionsColumn.FixedWidth = true;
            this.colH2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colH2.Width = 34;
            // 
            // colH3
            // 
            this.colH3.AppearanceCell.Options.UseTextOptions = true;
            this.colH3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH3.AppearanceHeader.Options.UseTextOptions = true;
            this.colH3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH3.FieldName = "H3";
            this.colH3.Name = "colH3";
            this.colH3.OptionsColumn.FixedWidth = true;
            this.colH3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colH3.Width = 34;
            // 
            // colH4
            // 
            this.colH4.AppearanceCell.Options.UseTextOptions = true;
            this.colH4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH4.AppearanceHeader.Options.UseTextOptions = true;
            this.colH4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH4.FieldName = "H4";
            this.colH4.Name = "colH4";
            this.colH4.OptionsColumn.FixedWidth = true;
            this.colH4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colH4.Width = 34;
            // 
            // colH5
            // 
            this.colH5.AppearanceCell.Options.UseTextOptions = true;
            this.colH5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH5.AppearanceHeader.Options.UseTextOptions = true;
            this.colH5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colH5.FieldName = "H5";
            this.colH5.Name = "colH5";
            this.colH5.OptionsColumn.FixedWidth = true;
            this.colH5.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colH5.Width = 34;
            // 
            // colDVRBRC
            // 
            this.colDVRBRC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVRBRC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVRBRC.Caption = "DvrBrç";
            this.colDVRBRC.DisplayFormat.FormatString = "n";
            this.colDVRBRC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVRBRC.FieldName = "DVRBRC";
            this.colDVRBRC.Name = "colDVRBRC";
            // 
            // colDVRALC
            // 
            this.colDVRALC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVRALC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVRALC.Caption = "DvrAlc";
            this.colDVRALC.DisplayFormat.FormatString = "n";
            this.colDVRALC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVRALC.FieldName = "DVRALC";
            this.colDVRALC.Name = "colDVRALC";
            // 
            // colDVRBRCKLN
            // 
            this.colDVRBRCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVRBRCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVRBRCKLN.Caption = "DvrBrçBky";
            this.colDVRBRCKLN.DisplayFormat.FormatString = "n";
            this.colDVRBRCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVRBRCKLN.FieldName = "DVRBRCKLN";
            this.colDVRBRCKLN.Name = "colDVRBRCKLN";
            // 
            // colDVRALCKLN
            // 
            this.colDVRALCKLN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDVRALCKLN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDVRALCKLN.Caption = "DvrAlcBky";
            this.colDVRALCKLN.DisplayFormat.FormatString = "n";
            this.colDVRALCKLN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDVRALCKLN.FieldName = "DVRALCKLN";
            this.colDVRALCKLN.Name = "colDVRALCKLN";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.DvrCheckEdit);
            this.layoutControl1.Controls.Add(this.SklAslCheckEdit);
            this.layoutControl1.Controls.Add(this.fillSimpleButton);
            this.layoutControl1.Controls.Add(this.dateEdit2);
            this.layoutControl1.Controls.Add(this.dateEdit1);
            this.layoutControl1.Controls.Add(this.accMizanGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(775, 140, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(970, 338);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // DvrCheckEdit
            // 
            this.DvrCheckEdit.Location = new System.Drawing.Point(422, 12);
            this.DvrCheckEdit.Name = "DvrCheckEdit";
            this.DvrCheckEdit.Properties.Caption = "Devir";
            this.DvrCheckEdit.Properties.DisplayValueChecked = "T";
            this.DvrCheckEdit.Properties.DisplayValueUnchecked = "F";
            this.DvrCheckEdit.Size = new System.Drawing.Size(67, 19);
            this.DvrCheckEdit.StyleController = this.layoutControl1;
            this.DvrCheckEdit.TabIndex = 8;
            // 
            // SklAslCheckEdit
            // 
            this.SklAslCheckEdit.EditValue = "T";
            this.SklAslCheckEdit.Location = new System.Drawing.Point(284, 12);
            this.SklAslCheckEdit.Name = "SklAslCheckEdit";
            this.SklAslCheckEdit.Properties.Caption = "Sadece Asıl olanlar";
            this.SklAslCheckEdit.Properties.DisplayValueChecked = "T";
            this.SklAslCheckEdit.Properties.DisplayValueUnchecked = "F";
            this.SklAslCheckEdit.Properties.ValueChecked = "T";
            this.SklAslCheckEdit.Properties.ValueUnchecked = "F";
            this.SklAslCheckEdit.Size = new System.Drawing.Size(134, 19);
            this.SklAslCheckEdit.StyleController = this.layoutControl1;
            this.SklAslCheckEdit.TabIndex = 7;
            // 
            // fillSimpleButton
            // 
            this.fillSimpleButton.Location = new System.Drawing.Point(493, 12);
            this.fillSimpleButton.Name = "fillSimpleButton";
            this.fillSimpleButton.Size = new System.Drawing.Size(465, 22);
            this.fillSimpleButton.StyleController = this.layoutControl1;
            this.fillSimpleButton.TabIndex = 6;
            this.fillSimpleButton.Text = "FILL";
            this.fillSimpleButton.Click += new System.EventHandler(this.fillSimpleButton_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2014, 12, 10, 10, 1, 56, 0);
            this.dateEdit2.Location = new System.Drawing.Point(194, 12);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(86, 20);
            this.dateEdit2.StyleController = this.layoutControl1;
            this.dateEdit2.TabIndex = 5;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2014, 12, 1, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(58, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(86, 20);
            this.dateEdit1.StyleController = this.layoutControl1;
            this.dateEdit1.TabIndex = 4;
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(970, 338);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.accMizanGridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(950, 292);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEdit1;
            this.layoutControlItem2.CustomizationFormText = "Tarih >=";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(136, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(136, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(136, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Tarih >=";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEdit2;
            this.layoutControlItem3.CustomizationFormText = "Tarih <";
            this.layoutControlItem3.Location = new System.Drawing.Point(136, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(136, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(136, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(136, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Tarih <";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.fillSimpleButton;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(481, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(469, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.SklAslCheckEdit;
            this.layoutControlItem5.Location = new System.Drawing.Point(272, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(138, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(138, 23);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(138, 26);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.DvrCheckEdit;
            this.layoutControlItem6.Location = new System.Drawing.Point(410, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(71, 23);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(71, 23);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(71, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // MizanXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 338);
            this.Controls.Add(this.layoutControl1);
            this.Name = "MizanXF";
            this.Text = "MizanXF";
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMizanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accMizanGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accMizanGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvrCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SklAslCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource accMizanBindingSource;
        private AccountDataSetTableAdapters.ACC_MIZANTableAdapter accMizanTableAdapter;
        private DevExpress.XtraGrid.GridControl accMizanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accMizanGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHSPAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colALC;
        private DevExpress.XtraGrid.Columns.GridColumn colBRCKLN;
        private DevExpress.XtraGrid.Columns.GridColumn colALCKLN;
        private DevExpress.XtraGrid.Columns.GridColumn colKLNTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colLVL;
        private DevExpress.XtraGrid.Columns.GridColumn colH1;
        private DevExpress.XtraGrid.Columns.GridColumn colH2;
        private DevExpress.XtraGrid.Columns.GridColumn colH3;
        private DevExpress.XtraGrid.Columns.GridColumn colH4;
        private DevExpress.XtraGrid.Columns.GridColumn colH5;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton fillSimpleButton;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraEditors.CheckEdit SklAslCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colDVRBRC;
        private DevExpress.XtraGrid.Columns.GridColumn colDVRALC;
        private DevExpress.XtraGrid.Columns.GridColumn colDVRBRCKLN;
        private DevExpress.XtraGrid.Columns.GridColumn colDVRALCKLN;
        private DevExpress.XtraEditors.CheckEdit DvrCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}