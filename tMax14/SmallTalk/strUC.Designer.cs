namespace tMax14.SmallTalk
{
    partial class strUC
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
            this.smallTalkDataSet = new tMax14.SmallTalk.SmallTalkDataSet();
            this.strBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.strTableAdapter = new tMax14.SmallTalk.SmallTalkDataSetTableAdapters.STRTableAdapter();
            this.strGridControl = new DevExpress.XtraGrid.GridControl();
            this.strGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTRID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSRS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.smallTalkQueriesTableAdapter = new tMax14.SmallTalk.SmallTalkDataSetTableAdapters.SmallTalkQueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smallTalkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // smallTalkDataSet
            // 
            this.smallTalkDataSet.DataSetName = "SmallTalkDataSet";
            this.smallTalkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // strBindingSource
            // 
            this.strBindingSource.DataMember = "STR";
            this.strBindingSource.DataSource = this.smallTalkDataSet;
            // 
            // strTableAdapter
            // 
            this.strTableAdapter.ClearBeforeFill = true;
            // 
            // strGridControl
            // 
            this.strGridControl.DataSource = this.strBindingSource;
            this.strGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strGridControl.Location = new System.Drawing.Point(0, 0);
            this.strGridControl.MainView = this.strGridView;
            this.strGridControl.Name = "strGridControl";
            this.strGridControl.Size = new System.Drawing.Size(470, 317);
            this.strGridControl.TabIndex = 1;
            this.strGridControl.Tag = "SmallTalk.strUC";
            this.strGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.strGridView});
            this.strGridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.strGridControl_KeyDown);
            // 
            // strGridView
            // 
            this.strGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTRID,
            this.colNAME,
            this.colUSRS});
            this.strGridView.GridControl = this.strGridControl;
            this.strGridView.Name = "strGridView";
            this.strGridView.OptionsView.ShowGroupPanel = false;
            this.strGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.strGridView_InitNewRow);
            this.strGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.strGridView_RowUpdated);
            // 
            // colSTRID
            // 
            this.colSTRID.FieldName = "STRID";
            this.colSTRID.Name = "colSTRID";
            this.colSTRID.OptionsColumn.FixedWidth = true;
            this.colSTRID.Visible = true;
            this.colSTRID.VisibleIndex = 0;
            this.colSTRID.Width = 60;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Room";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            this.colNAME.Width = 123;
            // 
            // colUSRS
            // 
            this.colUSRS.Caption = "UserList";
            this.colUSRS.FieldName = "USRS";
            this.colUSRS.Name = "colUSRS";
            this.colUSRS.Visible = true;
            this.colUSRS.VisibleIndex = 2;
            this.colUSRS.Width = 254;
            // 
            // strUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.strGridControl);
            this.Name = "strUC";
            this.Size = new System.Drawing.Size(470, 317);
            this.Load += new System.EventHandler(this.STRUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smallTalkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SmallTalkDataSet smallTalkDataSet;
        private System.Windows.Forms.BindingSource strBindingSource;
        private SmallTalkDataSetTableAdapters.STRTableAdapter strTableAdapter;
        private DevExpress.XtraGrid.GridControl strGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView strGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSTRID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colUSRS;
        private SmallTalkDataSetTableAdapters.SmallTalkQueriesTableAdapter smallTalkQueriesTableAdapter;
    }
}
