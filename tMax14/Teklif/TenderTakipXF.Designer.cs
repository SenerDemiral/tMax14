namespace tMax14.Teklif
{
    partial class TenderTakipXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenderTakipXF));
            this.teklifDataSet = new tMax14.Teklif.TeklifDataSet();
            this.tttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tttTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TTTTableAdapter();
            this.tttBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tTTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tttGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTTTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFRTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHNDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSRCTYP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROUTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colRSPUSRS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREGION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR1A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR1E = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR2A = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colR2E = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDSTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTKPTRH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.teklifQueriesTableAdapter = new tMax14.Teklif.TeklifDataSetTableAdapters.TeklifQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tttBindingNavigator)).BeginInit();
            this.tttBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tttGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // teklifDataSet
            // 
            this.teklifDataSet.DataSetName = "TeklifDataSet";
            this.teklifDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tttBindingSource
            // 
            this.tttBindingSource.DataMember = "TTT";
            this.tttBindingSource.DataSource = this.teklifDataSet;
            // 
            // tttTableAdapter
            // 
            this.tttTableAdapter.ClearBeforeFill = true;
            // 
            // tttBindingNavigator
            // 
            this.tttBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tttBindingNavigator.BindingSource = this.tttBindingSource;
            this.tttBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tttBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tttBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tTTBindingNavigatorSaveItem});
            this.tttBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tttBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tttBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tttBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tttBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tttBindingNavigator.Name = "tttBindingNavigator";
            this.tttBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tttBindingNavigator.Size = new System.Drawing.Size(1011, 25);
            this.tttBindingNavigator.TabIndex = 0;
            this.tttBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tTTBindingNavigatorSaveItem
            // 
            this.tTTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tTTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tTTBindingNavigatorSaveItem.Image")));
            this.tTTBindingNavigatorSaveItem.Name = "tTTBindingNavigatorSaveItem";
            this.tTTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tTTBindingNavigatorSaveItem.Text = "Save Data";
            this.tTTBindingNavigatorSaveItem.Click += new System.EventHandler(this.tTTBindingNavigatorSaveItem_Click);
            // 
            // tttGridControl
            // 
            this.tttGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tttGridControl.DataSource = this.tttBindingSource;
            this.tttGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tttGridControl.Location = new System.Drawing.Point(0, 25);
            this.tttGridControl.MainView = this.gridView1;
            this.tttGridControl.Name = "tttGridControl";
            this.tttGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1});
            this.tttGridControl.Size = new System.Drawing.Size(1011, 301);
            this.tttGridControl.TabIndex = 1;
            this.tttGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jurnalToolStripMenuItem,
            this.attachmentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 48);
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // attachmentToolStripMenuItem
            // 
            this.attachmentToolStripMenuItem.Name = "attachmentToolStripMenuItem";
            this.attachmentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.attachmentToolStripMenuItem.Text = "Attachment";
            this.attachmentToolStripMenuItem.Click += new System.EventHandler(this.attachmentToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTTTID,
            this.colFRTID,
            this.colHNDID,
            this.colSRCTYP,
            this.colROTS,
            this.colMOTS,
            this.colROUTE,
            this.colRSPUSRS,
            this.colREGION,
            this.colR1A,
            this.colR1E,
            this.colR2A,
            this.colR2E,
            this.colCOMMENTS,
            this.colSTU,
            this.colORGS,
            this.colDSTS,
            this.colTKPTRH});
            this.gridView1.GridControl = this.tttGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            // 
            // colTTTID
            // 
            this.colTTTID.FieldName = "TTTID";
            this.colTTTID.Name = "colTTTID";
            this.colTTTID.OptionsColumn.ReadOnly = true;
            this.colTTTID.Visible = true;
            this.colTTTID.VisibleIndex = 0;
            // 
            // colFRTID
            // 
            this.colFRTID.Caption = "Company";
            this.colFRTID.FieldName = "FRTID";
            this.colFRTID.Name = "colFRTID";
            this.colFRTID.Visible = true;
            this.colFRTID.VisibleIndex = 1;
            // 
            // colHNDID
            // 
            this.colHNDID.Caption = "HandledBy";
            this.colHNDID.FieldName = "HNDID";
            this.colHNDID.Name = "colHNDID";
            this.colHNDID.Visible = true;
            this.colHNDID.VisibleIndex = 2;
            // 
            // colSRCTYP
            // 
            this.colSRCTYP.Caption = "SrcType";
            this.colSRCTYP.FieldName = "SRCTYP";
            this.colSRCTYP.Name = "colSRCTYP";
            this.colSRCTYP.Visible = true;
            this.colSRCTYP.VisibleIndex = 3;
            // 
            // colROTS
            // 
            this.colROTS.Caption = "ROTs";
            this.colROTS.FieldName = "ROTS";
            this.colROTS.Name = "colROTS";
            this.colROTS.Visible = true;
            this.colROTS.VisibleIndex = 4;
            // 
            // colMOTS
            // 
            this.colMOTS.Caption = "MOTs";
            this.colMOTS.FieldName = "MOTS";
            this.colMOTS.Name = "colMOTS";
            this.colMOTS.Visible = true;
            this.colMOTS.VisibleIndex = 5;
            // 
            // colROUTE
            // 
            this.colROUTE.Caption = "Route";
            this.colROUTE.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colROUTE.FieldName = "ROUTE";
            this.colROUTE.Name = "colROUTE";
            this.colROUTE.Visible = true;
            this.colROUTE.VisibleIndex = 6;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colRSPUSRS
            // 
            this.colRSPUSRS.Caption = "Responsible";
            this.colRSPUSRS.FieldName = "RSPUSRS";
            this.colRSPUSRS.Name = "colRSPUSRS";
            this.colRSPUSRS.Visible = true;
            this.colRSPUSRS.VisibleIndex = 7;
            // 
            // colREGION
            // 
            this.colREGION.Caption = "Region";
            this.colREGION.FieldName = "REGION";
            this.colREGION.Name = "colREGION";
            this.colREGION.Visible = true;
            this.colREGION.VisibleIndex = 10;
            // 
            // colR1A
            // 
            this.colR1A.Caption = "1.RndApp";
            this.colR1A.FieldName = "R1A";
            this.colR1A.Name = "colR1A";
            this.colR1A.Visible = true;
            this.colR1A.VisibleIndex = 11;
            // 
            // colR1E
            // 
            this.colR1E.Caption = "1.RndEnd";
            this.colR1E.FieldName = "R1E";
            this.colR1E.Name = "colR1E";
            this.colR1E.Visible = true;
            this.colR1E.VisibleIndex = 12;
            // 
            // colR2A
            // 
            this.colR2A.Caption = "2.RndApp";
            this.colR2A.FieldName = "R2A";
            this.colR2A.Name = "colR2A";
            this.colR2A.Visible = true;
            this.colR2A.VisibleIndex = 13;
            // 
            // colR2E
            // 
            this.colR2E.Caption = "2.RndEnd";
            this.colR2E.FieldName = "R2E";
            this.colR2E.Name = "colR2E";
            this.colR2E.Visible = true;
            this.colR2E.VisibleIndex = 14;
            // 
            // colCOMMENTS
            // 
            this.colCOMMENTS.Caption = "Comments";
            this.colCOMMENTS.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colCOMMENTS.FieldName = "COMMENTS";
            this.colCOMMENTS.Name = "colCOMMENTS";
            this.colCOMMENTS.Visible = true;
            this.colCOMMENTS.VisibleIndex = 16;
            // 
            // colSTU
            // 
            this.colSTU.Caption = "Stu";
            this.colSTU.FieldName = "STU";
            this.colSTU.Name = "colSTU";
            this.colSTU.Visible = true;
            this.colSTU.VisibleIndex = 17;
            // 
            // colORGS
            // 
            this.colORGS.Caption = "ORGs";
            this.colORGS.FieldName = "ORGS";
            this.colORGS.Name = "colORGS";
            this.colORGS.Visible = true;
            this.colORGS.VisibleIndex = 8;
            // 
            // colDSTS
            // 
            this.colDSTS.Caption = "DSTs";
            this.colDSTS.FieldName = "DSTS";
            this.colDSTS.Name = "colDSTS";
            this.colDSTS.Visible = true;
            this.colDSTS.VisibleIndex = 9;
            // 
            // colTKPTRH
            // 
            this.colTKPTRH.Caption = "TkpTrh";
            this.colTKPTRH.FieldName = "TKPTRH";
            this.colTKPTRH.Name = "colTKPTRH";
            this.colTKPTRH.Visible = true;
            this.colTKPTRH.VisibleIndex = 15;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // TenderTakipXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 326);
            this.Controls.Add(this.tttGridControl);
            this.Controls.Add(this.tttBindingNavigator);
            this.Name = "TenderTakipXF";
            this.Text = "TenderTakipXF";
            this.Load += new System.EventHandler(this.TenderTakipXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teklifDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tttBindingNavigator)).EndInit();
            this.tttBindingNavigator.ResumeLayout(false);
            this.tttBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tttGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeklifDataSet teklifDataSet;
        private System.Windows.Forms.BindingSource tttBindingSource;
        private TeklifDataSetTableAdapters.TTTTableAdapter tttTableAdapter;
        private System.Windows.Forms.BindingNavigator tttBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tTTBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl tttGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colFRTID;
        private DevExpress.XtraGrid.Columns.GridColumn colHNDID;
        private DevExpress.XtraGrid.Columns.GridColumn colSRCTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colROTS;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTS;
        private DevExpress.XtraGrid.Columns.GridColumn colROUTE;
        private DevExpress.XtraGrid.Columns.GridColumn colRSPUSRS;
        private DevExpress.XtraGrid.Columns.GridColumn colREGION;
        private DevExpress.XtraGrid.Columns.GridColumn colR1A;
        private DevExpress.XtraGrid.Columns.GridColumn colR1E;
        private DevExpress.XtraGrid.Columns.GridColumn colR2A;
        private DevExpress.XtraGrid.Columns.GridColumn colR2E;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMMENTS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTU;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private TeklifDataSetTableAdapters.TeklifQueriesTableAdapter teklifQueriesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private System.Windows.Forms.ToolStripMenuItem attachmentToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colORGS;
        private DevExpress.XtraGrid.Columns.GridColumn colDSTS;
        private DevExpress.XtraGrid.Columns.GridColumn colTKPTRH;
    }
}