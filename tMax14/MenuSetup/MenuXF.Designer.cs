namespace tMax14.MenuSetup
{
    partial class MenuXF
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colIDX = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAD = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFRM = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colISMDL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.TFrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colCANDRAG = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.mnuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuSetupDataSet = new tMax14.MenuSetup.MenuSetupDataSet();
            this.mnuTableAdapter = new tMax14.MenuSetup.MenuSetupDataSetTableAdapters.MNUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSetupDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeList1.Appearance.EvenRow.Options.UseFont = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIDX,
            this.colAD,
            this.colFRM,
            this.colISMDL,
            this.colCANDRAG});
            this.treeList1.DataSource = this.mnuBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.AllowRecursiveNodeChecking = true;
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsBehavior.ShowEditorOnMouseUp = true;
            this.treeList1.OptionsNavigation.UseTabKey = true;
            this.treeList1.ParentFieldName = "PRID";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TFrepositoryItemCheckEdit});
            this.treeList1.Size = new System.Drawing.Size(406, 273);
            this.treeList1.TabIndex = 0;
            this.treeList1.NodeCellStyle += new DevExpress.XtraTreeList.GetCustomNodeCellStyleEventHandler(this.treeList1_NodeCellStyle);
            this.treeList1.BeforeDragNode += new DevExpress.XtraTreeList.BeforeDragNodeEventHandler(this.treeList1_BeforeDragNode);
            this.treeList1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeList1_DragDrop);
            this.treeList1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeList1_DragOver);
            // 
            // colIDX
            // 
            this.colIDX.Caption = "Index";
            this.colIDX.FieldName = "IDX";
            this.colIDX.Name = "colIDX";
            this.colIDX.Visible = true;
            this.colIDX.VisibleIndex = 0;
            this.colIDX.Width = 40;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 118;
            // 
            // colFRM
            // 
            this.colFRM.Caption = "FormName";
            this.colFRM.FieldName = "FRM";
            this.colFRM.Name = "colFRM";
            this.colFRM.OptionsColumn.AllowEdit = false;
            this.colFRM.OptionsColumn.AllowFocus = false;
            this.colFRM.Visible = true;
            this.colFRM.VisibleIndex = 2;
            this.colFRM.Width = 136;
            // 
            // colISMDL
            // 
            this.colISMDL.Caption = "isModal";
            this.colISMDL.ColumnEdit = this.TFrepositoryItemCheckEdit;
            this.colISMDL.FieldName = "ISMDL";
            this.colISMDL.Name = "colISMDL";
            this.colISMDL.Visible = true;
            this.colISMDL.VisibleIndex = 3;
            this.colISMDL.Width = 42;
            // 
            // TFrepositoryItemCheckEdit
            // 
            this.TFrepositoryItemCheckEdit.AutoHeight = false;
            this.TFrepositoryItemCheckEdit.Caption = "Check";
            this.TFrepositoryItemCheckEdit.Name = "TFrepositoryItemCheckEdit";
            this.TFrepositoryItemCheckEdit.ValueChecked = "T";
            this.TFrepositoryItemCheckEdit.ValueUnchecked = "F";
            // 
            // colCANDRAG
            // 
            this.colCANDRAG.Caption = "CanDrag";
            this.colCANDRAG.ColumnEdit = this.TFrepositoryItemCheckEdit;
            this.colCANDRAG.FieldName = "CANDRAG";
            this.colCANDRAG.Name = "colCANDRAG";
            this.colCANDRAG.OptionsColumn.AllowEdit = false;
            this.colCANDRAG.OptionsColumn.AllowFocus = false;
            this.colCANDRAG.Visible = true;
            this.colCANDRAG.VisibleIndex = 4;
            this.colCANDRAG.Width = 52;
            // 
            // mnuBindingSource
            // 
            this.mnuBindingSource.DataMember = "MNU";
            this.mnuBindingSource.DataSource = this.menuSetupDataSet;
            // 
            // menuSetupDataSet
            // 
            this.menuSetupDataSet.DataSetName = "MenuSetupDataSet";
            this.menuSetupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnuTableAdapter
            // 
            this.mnuTableAdapter.ClearBeforeFill = true;
            // 
            // MenuXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 273);
            this.Controls.Add(this.treeList1);
            this.Name = "MenuXF";
            this.Text = "MenuXF";
            this.Load += new System.EventHandler(this.MenuXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mnuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuSetupDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private MenuSetupDataSet menuSetupDataSet;
        private System.Windows.Forms.BindingSource mnuBindingSource;
        private MenuSetupDataSetTableAdapters.MNUTableAdapter mnuTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAD;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFRM;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colISMDL;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIDX;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFrepositoryItemCheckEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCANDRAG;
    }
}