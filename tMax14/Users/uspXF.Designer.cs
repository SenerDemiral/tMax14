namespace tMax14.Users
{
    partial class uspXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspXF));
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.uspBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.USP_SELTableAdapter();
            this.uspBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.uSP_SELBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uspTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colUSTID1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRMAD1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTYP = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TYPrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colENT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TFNrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMDF = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TFrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colID1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPRID1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRTIDS = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBindingNavigator)).BeginInit();
            this.uspBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFNrepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspBindingSource
            // 
            this.uspBindingSource.DataMember = "USP_SEL";
            this.uspBindingSource.DataSource = this.usersDataSet;
            // 
            // uspTableAdapter
            // 
            this.uspTableAdapter.ClearBeforeFill = true;
            // 
            // uspBindingNavigator
            // 
            this.uspBindingNavigator.AddNewItem = null;
            this.uspBindingNavigator.BindingSource = this.uspBindingSource;
            this.uspBindingNavigator.CountItem = null;
            this.uspBindingNavigator.DeleteItem = null;
            this.uspBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSP_SELBindingNavigatorSaveItem});
            this.uspBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspBindingNavigator.MoveFirstItem = null;
            this.uspBindingNavigator.MoveLastItem = null;
            this.uspBindingNavigator.MoveNextItem = null;
            this.uspBindingNavigator.MovePreviousItem = null;
            this.uspBindingNavigator.Name = "uspBindingNavigator";
            this.uspBindingNavigator.PositionItem = null;
            this.uspBindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.uspBindingNavigator.TabIndex = 0;
            this.uspBindingNavigator.Text = "bindingNavigator1";
            // 
            // uSP_SELBindingNavigatorSaveItem
            // 
            this.uSP_SELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSP_SELBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSP_SELBindingNavigatorSaveItem.Image")));
            this.uSP_SELBindingNavigatorSaveItem.Name = "uSP_SELBindingNavigatorSaveItem";
            this.uSP_SELBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uSP_SELBindingNavigatorSaveItem.Text = "Save Data";
            this.uSP_SELBindingNavigatorSaveItem.Click += new System.EventHandler(this.uSP_SELBindingNavigatorSaveItem_Click);
            // 
            // uspTreeList
            // 
            this.uspTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colUSTID1,
            this.colFRM,
            this.colFRMAD1,
            this.colTYP,
            this.colENT,
            this.colMDF,
            this.colID1,
            this.colPRID1,
            this.colFRTIDS});
            this.uspTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.uspTreeList.DataSource = this.uspBindingSource;
            this.uspTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uspTreeList.Location = new System.Drawing.Point(0, 25);
            this.uspTreeList.Name = "uspTreeList";
            this.uspTreeList.OptionsBehavior.ImmediateEditor = false;
            this.uspTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.uspTreeList.ParentFieldName = "PRID";
            this.uspTreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TYPrepositoryItemImageComboBox,
            this.TFrepositoryItemCheckEdit,
            this.TFNrepositoryItemCheckEdit});
            this.uspTreeList.Size = new System.Drawing.Size(596, 302);
            this.uspTreeList.TabIndex = 1;
            this.uspTreeList.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.uspSelTreeList_ShowingEditor);
            // 
            // colUSTID1
            // 
            this.colUSTID1.FieldName = "USTID";
            this.colUSTID1.Name = "colUSTID1";
            this.colUSTID1.OptionsColumn.AllowEdit = false;
            this.colUSTID1.OptionsColumn.AllowFocus = false;
            this.colUSTID1.Width = 212;
            // 
            // colFRM
            // 
            this.colFRM.FieldName = "FRM";
            this.colFRM.Name = "colFRM";
            this.colFRM.OptionsColumn.AllowEdit = false;
            this.colFRM.OptionsColumn.AllowFocus = false;
            this.colFRM.Width = 233;
            // 
            // colFRMAD1
            // 
            this.colFRMAD1.Caption = "Ad";
            this.colFRMAD1.FieldName = "FRMAD";
            this.colFRMAD1.Name = "colFRMAD1";
            this.colFRMAD1.OptionsColumn.AllowEdit = false;
            this.colFRMAD1.OptionsColumn.AllowFocus = false;
            this.colFRMAD1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colFRMAD1.Visible = true;
            this.colFRMAD1.VisibleIndex = 0;
            this.colFRMAD1.Width = 200;
            // 
            // colTYP
            // 
            this.colTYP.Caption = "Type";
            this.colTYP.ColumnEdit = this.TYPrepositoryItemImageComboBox;
            this.colTYP.FieldName = "TYP";
            this.colTYP.MinWidth = 40;
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.AllowEdit = false;
            this.colTYP.OptionsColumn.AllowFocus = false;
            this.colTYP.OptionsColumn.FixedWidth = true;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 3;
            this.colTYP.Width = 80;
            // 
            // TYPrepositoryItemImageComboBox
            // 
            this.TYPrepositoryItemImageComboBox.AutoHeight = false;
            this.TYPrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TYPrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("User", "U", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Menu", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Context", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Form", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dialog", "D", -1)});
            this.TYPrepositoryItemImageComboBox.Name = "TYPrepositoryItemImageComboBox";
            // 
            // colENT
            // 
            this.colENT.Caption = "View";
            this.colENT.ColumnEdit = this.TFNrepositoryItemCheckEdit;
            this.colENT.FieldName = "ENT";
            this.colENT.MinWidth = 40;
            this.colENT.Name = "colENT";
            this.colENT.OptionsColumn.FixedWidth = true;
            this.colENT.Visible = true;
            this.colENT.VisibleIndex = 1;
            this.colENT.Width = 80;
            // 
            // TFNrepositoryItemCheckEdit
            // 
            this.TFNrepositoryItemCheckEdit.AllowGrayed = true;
            this.TFNrepositoryItemCheckEdit.AutoHeight = false;
            this.TFNrepositoryItemCheckEdit.Name = "TFNrepositoryItemCheckEdit";
            this.TFNrepositoryItemCheckEdit.ValueChecked = "T";
            this.TFNrepositoryItemCheckEdit.ValueUnchecked = "F";
            // 
            // colMDF
            // 
            this.colMDF.Caption = "Modify";
            this.colMDF.ColumnEdit = this.TFNrepositoryItemCheckEdit;
            this.colMDF.FieldName = "MDF";
            this.colMDF.MinWidth = 40;
            this.colMDF.Name = "colMDF";
            this.colMDF.OptionsColumn.FixedWidth = true;
            this.colMDF.Visible = true;
            this.colMDF.VisibleIndex = 2;
            this.colMDF.Width = 80;
            // 
            // TFrepositoryItemCheckEdit
            // 
            this.TFrepositoryItemCheckEdit.AutoHeight = false;
            this.TFrepositoryItemCheckEdit.Caption = "Check";
            this.TFrepositoryItemCheckEdit.Name = "TFrepositoryItemCheckEdit";
            this.TFrepositoryItemCheckEdit.ValueChecked = "T";
            this.TFrepositoryItemCheckEdit.ValueUnchecked = "F";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.AllowFocus = false;
            this.colID1.Width = 234;
            // 
            // colPRID1
            // 
            this.colPRID1.FieldName = "PRID";
            this.colPRID1.Name = "colPRID1";
            this.colPRID1.OptionsColumn.AllowEdit = false;
            this.colPRID1.OptionsColumn.AllowFocus = false;
            this.colPRID1.Width = 232;
            // 
            // colFRTIDS
            // 
            this.colFRTIDS.Caption = "Private Firmalar";
            this.colFRTIDS.FieldName = "FRTIDS";
            this.colFRTIDS.Name = "colFRTIDS";
            // 
            // uspXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 327);
            this.Controls.Add(this.uspTreeList);
            this.Controls.Add(this.uspBindingNavigator);
            this.Name = "uspXF";
            this.Text = "Kullanıcı Giriş İzinleri [uspXF]";
            this.Load += new System.EventHandler(this.uspXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBindingNavigator)).EndInit();
            this.uspBindingNavigator.ResumeLayout(false);
            this.uspBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFNrepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource uspBindingSource;
        private UsersDataSetTableAdapters.USP_SELTableAdapter uspTableAdapter;
        private System.Windows.Forms.BindingNavigator uspBindingNavigator;
        private System.Windows.Forms.ToolStripButton uSP_SELBindingNavigatorSaveItem;
        private DevExpress.XtraTreeList.TreeList uspTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUSTID1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRMAD1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTYP;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TYPrepositoryItemImageComboBox;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colENT;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFrepositoryItemCheckEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMDF;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPRID1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRTIDS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFNrepositoryItemCheckEdit;
    }
}