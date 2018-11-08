namespace tMax14.Account
{
    partial class KurGirisXF
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dvkGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new tMax14.Account.AccountDataSet();
            this.dvkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDVZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUR4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYYTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONYTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dVKTableAdapter = new tMax14.Account.AccountDataSetTableAdapters.DVKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvkGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dVKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dvkGridControl);
            this.layoutControl1.Controls.Add(this.trhDateEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(484, 101, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(683, 309);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dvkGridControl
            // 
            this.dvkGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.dvkGridControl.DataSource = this.dVKBindingSource;
            this.dvkGridControl.Location = new System.Drawing.Point(12, 36);
            this.dvkGridControl.MainView = this.dvkGridView;
            this.dvkGridControl.Name = "dvkGridControl";
            this.dvkGridControl.Size = new System.Drawing.Size(659, 261);
            this.dvkGridControl.TabIndex = 5;
            this.dvkGridControl.Tag = "DVK";
            this.dvkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dvkGridView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onaylaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // dVKBindingSource
            // 
            this.dVKBindingSource.DataMember = "DVK";
            this.dVKBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvkGridView
            // 
            this.dvkGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDVZ,
            this.colTRH,
            this.colKUR1,
            this.colKUR2,
            this.colKUR3,
            this.colKUR4,
            this.colONYUSR,
            this.colONYYTK,
            this.colONYTRH});
            this.dvkGridView.GridControl = this.dvkGridControl;
            this.dvkGridView.Name = "dvkGridView";
            this.dvkGridView.OptionsView.ColumnAutoWidth = false;
            this.dvkGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dvkGridView_InitNewRow);
            // 
            // colDVZ
            // 
            this.colDVZ.Caption = "Dvz";
            this.colDVZ.FieldName = "DVZ";
            this.colDVZ.Name = "colDVZ";
            this.colDVZ.Visible = true;
            this.colDVZ.VisibleIndex = 0;
            // 
            // colTRH
            // 
            this.colTRH.Caption = "Tarih";
            this.colTRH.FieldName = "TRH";
            this.colTRH.Name = "colTRH";
            this.colTRH.OptionsColumn.AllowEdit = false;
            this.colTRH.OptionsColumn.AllowFocus = false;
            this.colTRH.Visible = true;
            this.colTRH.VisibleIndex = 1;
            // 
            // colKUR1
            // 
            this.colKUR1.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR1.Caption = "MB Alş";
            this.colKUR1.FieldName = "KUR1";
            this.colKUR1.Name = "colKUR1";
            this.colKUR1.Visible = true;
            this.colKUR1.VisibleIndex = 2;
            // 
            // colKUR2
            // 
            this.colKUR2.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR2.Caption = "MB Stş";
            this.colKUR2.FieldName = "KUR2";
            this.colKUR2.Name = "colKUR2";
            this.colKUR2.Visible = true;
            this.colKUR2.VisibleIndex = 3;
            // 
            // colKUR3
            // 
            this.colKUR3.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR3.Caption = "GB Alş";
            this.colKUR3.FieldName = "KUR3";
            this.colKUR3.Name = "colKUR3";
            this.colKUR3.Visible = true;
            this.colKUR3.VisibleIndex = 4;
            // 
            // colKUR4
            // 
            this.colKUR4.AppearanceHeader.Options.UseTextOptions = true;
            this.colKUR4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKUR4.Caption = "GB Stş";
            this.colKUR4.FieldName = "KUR4";
            this.colKUR4.Name = "colKUR4";
            this.colKUR4.Visible = true;
            this.colKUR4.VisibleIndex = 5;
            // 
            // colONYUSR
            // 
            this.colONYUSR.Caption = "OnyUsr";
            this.colONYUSR.FieldName = "ONYUSR";
            this.colONYUSR.Name = "colONYUSR";
            this.colONYUSR.OptionsColumn.AllowEdit = false;
            this.colONYUSR.OptionsColumn.AllowFocus = false;
            this.colONYUSR.Visible = true;
            this.colONYUSR.VisibleIndex = 6;
            this.colONYUSR.Width = 50;
            // 
            // colONYYTK
            // 
            this.colONYYTK.Caption = "OnyYtk";
            this.colONYYTK.FieldName = "ONYYTK";
            this.colONYYTK.Name = "colONYYTK";
            this.colONYYTK.OptionsColumn.AllowEdit = false;
            this.colONYYTK.OptionsColumn.AllowFocus = false;
            this.colONYYTK.Visible = true;
            this.colONYYTK.VisibleIndex = 7;
            this.colONYYTK.Width = 50;
            // 
            // colONYTRH
            // 
            this.colONYTRH.Caption = "OnyTrh";
            this.colONYTRH.DisplayFormat.FormatString = "dd.MM.yy HH:mm";
            this.colONYTRH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colONYTRH.FieldName = "ONYTRH";
            this.colONYTRH.Name = "colONYTRH";
            this.colONYTRH.OptionsColumn.AllowEdit = false;
            this.colONYTRH.OptionsColumn.AllowFocus = false;
            this.colONYTRH.Visible = true;
            this.colONYTRH.VisibleIndex = 8;
            this.colONYTRH.Width = 89;
            // 
            // trhDateEdit
            // 
            this.trhDateEdit.EditValue = null;
            this.trhDateEdit.Location = new System.Drawing.Point(39, 12);
            this.trhDateEdit.Name = "trhDateEdit";
            this.trhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trhDateEdit.Size = new System.Drawing.Size(219, 20);
            this.trhDateEdit.StyleController = this.layoutControl1;
            this.trhDateEdit.TabIndex = 4;
            this.trhDateEdit.EditValueChanged += new System.EventHandler(this.trhDateEdit_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(683, 309);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.trhDateEdit;
            this.layoutControlItem1.CustomizationFormText = "Tarih";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 24);
            this.layoutControlItem1.Text = "Tarih";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(24, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dvkGridControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(663, 265);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(250, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(413, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dVKTableAdapter
            // 
            this.dVKTableAdapter.ClearBeforeFill = true;
            // 
            // KurGirisXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 309);
            this.Controls.Add(this.layoutControl1);
            this.Name = "KurGirisXF";
            this.Text = "Kur Girişleri";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvkGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dVKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit trhDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource dVKBindingSource;
        private AccountDataSetTableAdapters.DVKTableAdapter dVKTableAdapter;
        private DevExpress.XtraGrid.GridControl dvkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dvkGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDVZ;
        private DevExpress.XtraGrid.Columns.GridColumn colTRH;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR1;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR2;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR3;
        private DevExpress.XtraGrid.Columns.GridColumn colKUR4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colONYUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colONYYTK;
        private DevExpress.XtraGrid.Columns.GridColumn colONYTRH;
    }
}