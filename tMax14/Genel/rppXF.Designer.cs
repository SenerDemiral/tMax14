namespace tMax14.Genel
{
    partial class rppXF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rppXF));
            this.genelDataSet = new tMax14.Genel.GenelDataSet();
            this.rPPBindingSource = new System.Windows.Forms.BindingSource();
            this.rPPTableAdapter = new tMax14.Genel.GenelDataSetTableAdapters.RPPTableAdapter();
            this.rPPBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.rPPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.rppGridControl = new DevExpress.XtraGrid.GridControl();
            this.rppLayoutView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIMG1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colIMG1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIMG2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIMG2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIMG3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIMG3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.colIMGFTRUST = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIMGFTRUST = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIMGFTRALT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIMGFTRALT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPPBindingNavigator)).BeginInit();
            this.rPPBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rppGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rppLayoutView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMGFTRUST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMGFTRALT)).BeginInit();
            this.SuspendLayout();
            // 
            // genelDataSet
            // 
            this.genelDataSet.DataSetName = "GenelDataSet";
            this.genelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPPBindingSource
            // 
            this.rPPBindingSource.DataMember = "RPP";
            this.rPPBindingSource.DataSource = this.genelDataSet;
            // 
            // rPPTableAdapter
            // 
            this.rPPTableAdapter.ClearBeforeFill = true;
            // 
            // rPPBindingNavigator
            // 
            this.rPPBindingNavigator.AddNewItem = null;
            this.rPPBindingNavigator.BindingSource = this.rPPBindingSource;
            this.rPPBindingNavigator.CountItem = null;
            this.rPPBindingNavigator.DeleteItem = null;
            this.rPPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rPPBindingNavigatorSaveItem});
            this.rPPBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rPPBindingNavigator.MoveFirstItem = null;
            this.rPPBindingNavigator.MoveLastItem = null;
            this.rPPBindingNavigator.MoveNextItem = null;
            this.rPPBindingNavigator.MovePreviousItem = null;
            this.rPPBindingNavigator.Name = "rPPBindingNavigator";
            this.rPPBindingNavigator.PositionItem = null;
            this.rPPBindingNavigator.Size = new System.Drawing.Size(364, 25);
            this.rPPBindingNavigator.TabIndex = 0;
            this.rPPBindingNavigator.Text = "bindingNavigator1";
            // 
            // rPPBindingNavigatorSaveItem
            // 
            this.rPPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rPPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rPPBindingNavigatorSaveItem.Image")));
            this.rPPBindingNavigatorSaveItem.Name = "rPPBindingNavigatorSaveItem";
            this.rPPBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.rPPBindingNavigatorSaveItem.Text = "Save Data";
            this.rPPBindingNavigatorSaveItem.Click += new System.EventHandler(this.rPPBindingNavigatorSaveItem_Click);
            // 
            // rppGridControl
            // 
            this.rppGridControl.DataSource = this.rPPBindingSource;
            this.rppGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rppGridControl.Location = new System.Drawing.Point(0, 25);
            this.rppGridControl.MainView = this.rppLayoutView;
            this.rppGridControl.Name = "rppGridControl";
            this.rppGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.rppGridControl.Size = new System.Drawing.Size(364, 262);
            this.rppGridControl.TabIndex = 1;
            this.rppGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.rppLayoutView});
            // 
            // rppLayoutView
            // 
            this.rppLayoutView.CardMinSize = new System.Drawing.Size(78, 98);
            this.rppLayoutView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colIMG1,
            this.colIMG2,
            this.colIMG3,
            this.colIMGFTRUST,
            this.colIMGFTRALT});
            this.rppLayoutView.GridControl = this.rppGridControl;
            this.rppLayoutView.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID});
            this.rppLayoutView.Name = "rppLayoutView";
            this.rppLayoutView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.rppLayoutView.OptionsSingleRecordMode.StretchCardToViewHeight = true;
            this.rppLayoutView.OptionsSingleRecordMode.StretchCardToViewWidth = true;
            this.rppLayoutView.OptionsView.ShowCardCaption = false;
            this.rppLayoutView.OptionsView.ShowHeaderPanel = false;
            this.rppLayoutView.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 166;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(202, 78);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(29, 13);
            this.layoutViewField_colID.TextToControlDistance = 5;
            // 
            // colIMG1
            // 
            this.colIMG1.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIMG1.FieldName = "IMG1";
            this.colIMG1.LayoutViewField = this.layoutViewField_colIMG1;
            this.colIMG1.Name = "colIMG1";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // layoutViewField_colIMG1
            // 
            this.layoutViewField_colIMG1.EditorPreferredWidth = 20;
            this.layoutViewField_colIMG1.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colIMG1.Name = "layoutViewField_colIMG1";
            this.layoutViewField_colIMG1.Size = new System.Drawing.Size(90, 26);
            this.layoutViewField_colIMG1.TextSize = new System.Drawing.Size(61, 13);
            this.layoutViewField_colIMG1.TextToControlDistance = 5;
            // 
            // colIMG2
            // 
            this.colIMG2.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIMG2.FieldName = "IMG2";
            this.colIMG2.LayoutViewField = this.layoutViewField_colIMG2;
            this.colIMG2.Name = "colIMG2";
            // 
            // layoutViewField_colIMG2
            // 
            this.layoutViewField_colIMG2.EditorPreferredWidth = 20;
            this.layoutViewField_colIMG2.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_colIMG2.Name = "layoutViewField_colIMG2";
            this.layoutViewField_colIMG2.Size = new System.Drawing.Size(90, 26);
            this.layoutViewField_colIMG2.TextSize = new System.Drawing.Size(61, 13);
            this.layoutViewField_colIMG2.TextToControlDistance = 5;
            // 
            // colIMG3
            // 
            this.colIMG3.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colIMG3.FieldName = "IMG3";
            this.colIMG3.LayoutViewField = this.layoutViewField_colIMG3;
            this.colIMG3.Name = "colIMG3";
            // 
            // layoutViewField_colIMG3
            // 
            this.layoutViewField_colIMG3.EditorPreferredWidth = 20;
            this.layoutViewField_colIMG3.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_colIMG3.Name = "layoutViewField_colIMG3";
            this.layoutViewField_colIMG3.Size = new System.Drawing.Size(90, 26);
            this.layoutViewField_colIMG3.TextSize = new System.Drawing.Size(61, 13);
            this.layoutViewField_colIMG3.TextToControlDistance = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colIMG1,
            this.layoutViewField_colIMG2,
            this.layoutViewField_colIMG3,
            this.layoutViewField_colIMGFTRUST,
            this.layoutViewField_colIMGFTRALT});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // colIMGFTRUST
            // 
            this.colIMGFTRUST.FieldName = "IMGFTRUST";
            this.colIMGFTRUST.LayoutViewField = this.layoutViewField_colIMGFTRUST;
            this.colIMGFTRUST.Name = "colIMGFTRUST";
            // 
            // layoutViewField_colIMGFTRUST
            // 
            this.layoutViewField_colIMGFTRUST.EditorPreferredWidth = 12;
            this.layoutViewField_colIMGFTRUST.Location = new System.Drawing.Point(0, 78);
            this.layoutViewField_colIMGFTRUST.Name = "layoutViewField_colIMGFTRUST";
            this.layoutViewField_colIMGFTRUST.Size = new System.Drawing.Size(90, 20);
            this.layoutViewField_colIMGFTRUST.TextSize = new System.Drawing.Size(61, 13);
            this.layoutViewField_colIMGFTRUST.TextToControlDistance = 5;
            // 
            // colIMGFTRALT
            // 
            this.colIMGFTRALT.FieldName = "IMGFTRALT";
            this.colIMGFTRALT.LayoutViewField = this.layoutViewField_colIMGFTRALT;
            this.colIMGFTRALT.Name = "colIMGFTRALT";
            // 
            // layoutViewField_colIMGFTRALT
            // 
            this.layoutViewField_colIMGFTRALT.EditorPreferredWidth = 12;
            this.layoutViewField_colIMGFTRALT.Location = new System.Drawing.Point(0, 98);
            this.layoutViewField_colIMGFTRALT.Name = "layoutViewField_colIMGFTRALT";
            this.layoutViewField_colIMGFTRALT.Size = new System.Drawing.Size(90, 20);
            this.layoutViewField_colIMGFTRALT.TextSize = new System.Drawing.Size(61, 13);
            this.layoutViewField_colIMGFTRALT.TextToControlDistance = 5;
            // 
            // rppXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 287);
            this.Controls.Add(this.rppGridControl);
            this.Controls.Add(this.rPPBindingNavigator);
            this.Name = "rppXF";
            this.Text = "rppXF";
            this.Load += new System.EventHandler(this.rppXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPPBindingNavigator)).EndInit();
            this.rPPBindingNavigator.ResumeLayout(false);
            this.rPPBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rppGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rppLayoutView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMG3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMGFTRUST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMGFTRALT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GenelDataSet genelDataSet;
        private System.Windows.Forms.BindingSource rPPBindingSource;
        private GenelDataSetTableAdapters.RPPTableAdapter rPPTableAdapter;
        private System.Windows.Forms.BindingNavigator rPPBindingNavigator;
        private System.Windows.Forms.ToolStripButton rPPBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl rppGridControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView rppLayoutView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMG1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMG2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMG3;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMG1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMG2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMG3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMGFTRUST;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMGFTRUST;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMGFTRALT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMGFTRALT;
    }
}