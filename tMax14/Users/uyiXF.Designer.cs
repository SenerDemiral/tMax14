namespace tMax14.Users
{
    partial class uyiXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyiXF));
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.uyiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyiTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.UYITableAdapter();
            this.uyiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.uYIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uyıTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colUSTID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colYTK = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colYTKAD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPRID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRMAD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colTYP = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TYPrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colENT = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TFrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colMDF = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyiBindingNavigator)).BeginInit();
            this.uyiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyıTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyiBindingSource
            // 
            this.uyiBindingSource.DataMember = "UYI";
            this.uyiBindingSource.DataSource = this.usersDataSet;
            // 
            // uyiTableAdapter
            // 
            this.uyiTableAdapter.ClearBeforeFill = true;
            // 
            // uyiBindingNavigator
            // 
            this.uyiBindingNavigator.AddNewItem = null;
            this.uyiBindingNavigator.BindingSource = this.uyiBindingSource;
            this.uyiBindingNavigator.CountItem = null;
            this.uyiBindingNavigator.DeleteItem = null;
            this.uyiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uYIBindingNavigatorSaveItem});
            this.uyiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uyiBindingNavigator.MoveFirstItem = null;
            this.uyiBindingNavigator.MoveLastItem = null;
            this.uyiBindingNavigator.MoveNextItem = null;
            this.uyiBindingNavigator.MovePreviousItem = null;
            this.uyiBindingNavigator.Name = "uyiBindingNavigator";
            this.uyiBindingNavigator.PositionItem = null;
            this.uyiBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.uyiBindingNavigator.TabIndex = 0;
            this.uyiBindingNavigator.Text = "bindingNavigator1";
            // 
            // uYIBindingNavigatorSaveItem
            // 
            this.uYIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uYIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uYIBindingNavigatorSaveItem.Image")));
            this.uYIBindingNavigatorSaveItem.Name = "uYIBindingNavigatorSaveItem";
            this.uYIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uYIBindingNavigatorSaveItem.Text = "Save Data";
            this.uYIBindingNavigatorSaveItem.Click += new System.EventHandler(this.uYIBindingNavigatorSaveItem_Click);
            // 
            // uyıTreeList
            // 
            this.uyıTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colUSTID,
            this.colID,
            this.colYTK,
            this.colYTKAD,
            this.colPRID,
            this.colFRM,
            this.colFRMAD,
            this.colTYP,
            this.colENT,
            this.colMDF});
            this.uyıTreeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.uyıTreeList.DataSource = this.uyiBindingSource;
            this.uyıTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uyıTreeList.Location = new System.Drawing.Point(0, 25);
            this.uyıTreeList.Name = "uyıTreeList";
            this.uyıTreeList.OptionsBehavior.ImmediateEditor = false;
            this.uyıTreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.uyıTreeList.ParentFieldName = "PRID";
            this.uyıTreeList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TYPrepositoryItemImageComboBox,
            this.TFrepositoryItemCheckEdit});
            this.uyıTreeList.Size = new System.Drawing.Size(645, 295);
            this.uyıTreeList.TabIndex = 2;
            this.uyıTreeList.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.uspSelTreeList_ShowingEditor);
            // 
            // colUSTID
            // 
            this.colUSTID.FieldName = "USTID";
            this.colUSTID.Name = "colUSTID";
            this.colUSTID.OptionsColumn.ReadOnly = true;
            this.colUSTID.Width = 37;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Width = 37;
            // 
            // colYTK
            // 
            this.colYTK.FieldName = "YTK";
            this.colYTK.Name = "colYTK";
            this.colYTK.OptionsColumn.ReadOnly = true;
            this.colYTK.Width = 37;
            // 
            // colYTKAD
            // 
            this.colYTKAD.FieldName = "YTKAD";
            this.colYTKAD.Name = "colYTKAD";
            this.colYTKAD.OptionsColumn.ReadOnly = true;
            this.colYTKAD.Width = 37;
            // 
            // colPRID
            // 
            this.colPRID.FieldName = "PRID";
            this.colPRID.Name = "colPRID";
            this.colPRID.OptionsColumn.ReadOnly = true;
            this.colPRID.Width = 37;
            // 
            // colFRM
            // 
            this.colFRM.FieldName = "FRM";
            this.colFRM.Name = "colFRM";
            this.colFRM.OptionsColumn.ReadOnly = true;
            this.colFRM.Width = 37;
            // 
            // colFRMAD
            // 
            this.colFRMAD.Caption = "Ad";
            this.colFRMAD.FieldName = "FRMAD";
            this.colFRMAD.Name = "colFRMAD";
            this.colFRMAD.OptionsColumn.ReadOnly = true;
            this.colFRMAD.Visible = true;
            this.colFRMAD.VisibleIndex = 0;
            this.colFRMAD.Width = 37;
            // 
            // colTYP
            // 
            this.colTYP.Caption = "Type";
            this.colTYP.ColumnEdit = this.TYPrepositoryItemImageComboBox;
            this.colTYP.FieldName = "TYP";
            this.colTYP.Name = "colTYP";
            this.colTYP.OptionsColumn.ReadOnly = true;
            this.colTYP.Visible = true;
            this.colTYP.VisibleIndex = 3;
            this.colTYP.Width = 38;
            // 
            // TYPrepositoryItemImageComboBox
            // 
            this.TYPrepositoryItemImageComboBox.AutoHeight = false;
            this.TYPrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TYPrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Yetki", "Y", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Menu", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Context", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Form", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Dialog", "D", -1)});
            this.TYPrepositoryItemImageComboBox.Name = "TYPrepositoryItemImageComboBox";
            // 
            // colENT
            // 
            this.colENT.ColumnEdit = this.TFrepositoryItemCheckEdit;
            this.colENT.FieldName = "ENT";
            this.colENT.Name = "colENT";
            this.colENT.OptionsColumn.FixedWidth = true;
            this.colENT.Visible = true;
            this.colENT.VisibleIndex = 1;
            this.colENT.Width = 38;
            // 
            // TFrepositoryItemCheckEdit
            // 
            this.TFrepositoryItemCheckEdit.AutoHeight = false;
            this.TFrepositoryItemCheckEdit.Caption = "Check";
            this.TFrepositoryItemCheckEdit.Name = "TFrepositoryItemCheckEdit";
            this.TFrepositoryItemCheckEdit.ValueChecked = "T";
            this.TFrepositoryItemCheckEdit.ValueUnchecked = "F";
            // 
            // colMDF
            // 
            this.colMDF.ColumnEdit = this.TFrepositoryItemCheckEdit;
            this.colMDF.FieldName = "MDF";
            this.colMDF.Name = "colMDF";
            this.colMDF.OptionsColumn.FixedWidth = true;
            this.colMDF.Visible = true;
            this.colMDF.VisibleIndex = 2;
            this.colMDF.Width = 38;
            // 
            // uyiXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 320);
            this.Controls.Add(this.uyıTreeList);
            this.Controls.Add(this.uyiBindingNavigator);
            this.Name = "uyiXF";
            this.Text = "Yetki Giriş İzinleri [uyiXF]";
            this.Load += new System.EventHandler(this.uyiXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyiBindingNavigator)).EndInit();
            this.uyiBindingNavigator.ResumeLayout(false);
            this.uyiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyıTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPrepositoryItemImageComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource uyiBindingSource;
        private UsersDataSetTableAdapters.UYITableAdapter uyiTableAdapter;
        private System.Windows.Forms.BindingNavigator uyiBindingNavigator;
        private System.Windows.Forms.ToolStripButton uYIBindingNavigatorSaveItem;
        private DevExpress.XtraTreeList.TreeList uyıTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUSTID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colYTK;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colYTKAD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPRID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRMAD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTYP;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colENT;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMDF;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox TYPrepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFrepositoryItemCheckEdit;
    }
}