namespace tMax14.Users
{
    partial class ustXF
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
            this.usersDataSet = new tMax14.Users.UsersDataSet();
            this.ustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ustTableAdapter = new tMax14.Users.UsersDataSetTableAdapters.USTTableAdapter();
            this.uSTGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jurnalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUSTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDRM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMKK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTEL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "UsersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ustBindingSource
            // 
            this.ustBindingSource.DataMember = "UST";
            this.ustBindingSource.DataSource = this.usersDataSet;
            this.ustBindingSource.Filter = "DRM = \'-\' OR DRM = \'P\'";
            // 
            // ustTableAdapter
            // 
            this.ustTableAdapter.ClearBeforeFill = true;
            // 
            // uSTGridControl
            // 
            this.uSTGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.uSTGridControl.DataSource = this.ustBindingSource;
            this.uSTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uSTGridControl.Location = new System.Drawing.Point(0, 0);
            this.uSTGridControl.MainView = this.gridView1;
            this.uSTGridControl.Name = "uSTGridControl";
            this.uSTGridControl.ShowOnlyPredefinedDetails = true;
            this.uSTGridControl.Size = new System.Drawing.Size(757, 301);
            this.uSTGridControl.TabIndex = 1;
            this.uSTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jurnalToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(106, 26);
            // 
            // jurnalToolStripMenuItem
            // 
            this.jurnalToolStripMenuItem.Name = "jurnalToolStripMenuItem";
            this.jurnalToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.jurnalToolStripMenuItem.Text = "Jurnal";
            this.jurnalToolStripMenuItem.Click += new System.EventHandler(this.jurnalToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUSTID,
            this.colUSR,
            this.colDRM,
            this.colAD,
            this.colUNVT,
            this.colMKK,
            this.colSMTEL,
            this.colSOTEL});
            this.gridView1.GridControl = this.uSTGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colUSTID
            // 
            this.colUSTID.FieldName = "USTID";
            this.colUSTID.Name = "colUSTID";
            this.colUSTID.OptionsColumn.FixedWidth = true;
            this.colUSTID.Visible = true;
            this.colUSTID.VisibleIndex = 0;
            this.colUSTID.Width = 80;
            // 
            // colUSR
            // 
            this.colUSR.FieldName = "USR";
            this.colUSR.Name = "colUSR";
            this.colUSR.OptionsColumn.FixedWidth = true;
            this.colUSR.Visible = true;
            this.colUSR.VisibleIndex = 1;
            this.colUSR.Width = 80;
            // 
            // colDRM
            // 
            this.colDRM.Caption = "Drm";
            this.colDRM.FieldName = "DRM";
            this.colDRM.Name = "colDRM";
            this.colDRM.Visible = true;
            this.colDRM.VisibleIndex = 2;
            this.colDRM.Width = 38;
            // 
            // colAD
            // 
            this.colAD.Caption = "Ad";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 3;
            this.colAD.Width = 167;
            // 
            // colUNVT
            // 
            this.colUNVT.Caption = "Ünvan";
            this.colUNVT.FieldName = "UNVT";
            this.colUNVT.Name = "colUNVT";
            this.colUNVT.Visible = true;
            this.colUNVT.VisibleIndex = 4;
            this.colUNVT.Width = 105;
            // 
            // colMKK
            // 
            this.colMKK.Caption = "CepKısaKod";
            this.colMKK.FieldName = "MKK";
            this.colMKK.Name = "colMKK";
            this.colMKK.Visible = true;
            this.colMKK.VisibleIndex = 5;
            this.colMKK.Width = 86;
            // 
            // colSMTEL
            // 
            this.colSMTEL.Caption = "SirketMobilTel";
            this.colSMTEL.FieldName = "SMTEL";
            this.colSMTEL.Name = "colSMTEL";
            this.colSMTEL.Visible = true;
            this.colSMTEL.VisibleIndex = 6;
            this.colSMTEL.Width = 86;
            // 
            // colSOTEL
            // 
            this.colSOTEL.Caption = "ŞirketOfisTel";
            this.colSOTEL.FieldName = "SOTEL";
            this.colSOTEL.Name = "colSOTEL";
            this.colSOTEL.Visible = true;
            this.colSOTEL.VisibleIndex = 7;
            this.colSOTEL.Width = 97;
            // 
            // ustXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 301);
            this.Controls.Add(this.uSTGridControl);
            this.Name = "ustXF";
            this.Text = "ustXF";
            this.Load += new System.EventHandler(this.ustXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSTGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UsersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource ustBindingSource;
        private UsersDataSetTableAdapters.USTTableAdapter ustTableAdapter;
        private DevExpress.XtraGrid.GridControl uSTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUSTID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSR;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colUNVT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem jurnalToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colMKK;
        private DevExpress.XtraGrid.Columns.GridColumn colSMTEL;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTEL;
        private DevExpress.XtraGrid.Columns.GridColumn colDRM;
    }
}