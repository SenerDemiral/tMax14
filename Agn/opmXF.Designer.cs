namespace Agn
{
    partial class opmXF
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
            this.agnDataSet = new Agn.AgnDataSet();
            this.wAN_AGN_OPM_SELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wAN_AGN_OPM_SELTableAdapter = new Agn.AgnDataSetTableAdapters.WAN_AGN_OPM_SELTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.iQRYToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iQRYToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.opmSelGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.housesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmSelGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOPMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colORG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNSTUTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPSTUTS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_OPM_SELBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmSelGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmSelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agnDataSet
            // 
            this.agnDataSet.DataSetName = "AgnDataSet";
            this.agnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wAN_AGN_OPM_SELBindingSource
            // 
            this.wAN_AGN_OPM_SELBindingSource.DataMember = "WAN_AGN_OPM_SEL";
            this.wAN_AGN_OPM_SELBindingSource.DataSource = this.agnDataSet;
            // 
            // wAN_AGN_OPM_SELTableAdapter
            // 
            this.wAN_AGN_OPM_SELTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iQRYToolStripLabel,
            this.iQRYToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(928, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // iQRYToolStripLabel
            // 
            this.iQRYToolStripLabel.Name = "iQRYToolStripLabel";
            this.iQRYToolStripLabel.Size = new System.Drawing.Size(36, 22);
            this.iQRYToolStripLabel.Text = "IQRY:";
            // 
            // iQRYToolStripTextBox
            // 
            this.iQRYToolStripTextBox.Name = "iQRYToolStripTextBox";
            this.iQRYToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // opmSelGridControl
            // 
            this.opmSelGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.opmSelGridControl.DataSource = this.wAN_AGN_OPM_SELBindingSource;
            this.opmSelGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opmSelGridControl.Location = new System.Drawing.Point(0, 25);
            this.opmSelGridControl.MainView = this.opmSelGridView;
            this.opmSelGridControl.Name = "opmSelGridControl";
            this.opmSelGridControl.Size = new System.Drawing.Size(928, 266);
            this.opmSelGridControl.TabIndex = 2;
            this.opmSelGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.opmSelGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.housesToolStripMenuItem,
            this.attachmentsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(136, 48);
            // 
            // housesToolStripMenuItem
            // 
            this.housesToolStripMenuItem.Name = "housesToolStripMenuItem";
            this.housesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.housesToolStripMenuItem.Text = "Houses";
            this.housesToolStripMenuItem.Click += new System.EventHandler(this.housesToolStripMenuItem_Click);
            // 
            // attachmentsToolStripMenuItem
            // 
            this.attachmentsToolStripMenuItem.Name = "attachmentsToolStripMenuItem";
            this.attachmentsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.attachmentsToolStripMenuItem.Text = "Attachments";
            this.attachmentsToolStripMenuItem.Click += new System.EventHandler(this.attachmentsToolStripMenuItem_Click);
            // 
            // opmSelGridView
            // 
            this.opmSelGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOPMID,
            this.colROT,
            this.colMOT,
            this.colORG,
            this.colDST,
            this.colREFNO,
            this.colVHC,
            this.colNSTU,
            this.colNSTUTS,
            this.colPSTU,
            this.colPSTUTS});
            this.opmSelGridView.GridControl = this.opmSelGridControl;
            this.opmSelGridView.Name = "opmSelGridView";
            this.opmSelGridView.OptionsBehavior.Editable = false;
            // 
            // colOPMID
            // 
            this.colOPMID.FieldName = "OPMID";
            this.colOPMID.Name = "colOPMID";
            this.colOPMID.OptionsColumn.FixedWidth = true;
            this.colOPMID.Visible = true;
            this.colOPMID.VisibleIndex = 0;
            // 
            // colROT
            // 
            this.colROT.FieldName = "ROT";
            this.colROT.Name = "colROT";
            this.colROT.OptionsColumn.FixedWidth = true;
            this.colROT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colROT.Visible = true;
            this.colROT.VisibleIndex = 1;
            this.colROT.Width = 39;
            // 
            // colMOT
            // 
            this.colMOT.FieldName = "MOT";
            this.colMOT.Name = "colMOT";
            this.colMOT.OptionsColumn.FixedWidth = true;
            this.colMOT.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colMOT.Visible = true;
            this.colMOT.VisibleIndex = 2;
            this.colMOT.Width = 38;
            // 
            // colORG
            // 
            this.colORG.FieldName = "ORG";
            this.colORG.Name = "colORG";
            this.colORG.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colORG.Visible = true;
            this.colORG.VisibleIndex = 3;
            this.colORG.Width = 93;
            // 
            // colDST
            // 
            this.colDST.FieldName = "DST";
            this.colDST.Name = "colDST";
            this.colDST.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDST.Visible = true;
            this.colDST.VisibleIndex = 4;
            this.colDST.Width = 93;
            // 
            // colREFNO
            // 
            this.colREFNO.FieldName = "REFNO";
            this.colREFNO.Name = "colREFNO";
            this.colREFNO.Visible = true;
            this.colREFNO.VisibleIndex = 5;
            this.colREFNO.Width = 93;
            // 
            // colVHC
            // 
            this.colVHC.FieldName = "VHC";
            this.colVHC.Name = "colVHC";
            this.colVHC.Visible = true;
            this.colVHC.VisibleIndex = 6;
            this.colVHC.Width = 93;
            // 
            // colNSTU
            // 
            this.colNSTU.FieldName = "NSTU";
            this.colNSTU.Name = "colNSTU";
            this.colNSTU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNSTU.Visible = true;
            this.colNSTU.VisibleIndex = 7;
            this.colNSTU.Width = 93;
            // 
            // colNSTUTS
            // 
            this.colNSTUTS.FieldName = "NSTUTS";
            this.colNSTUTS.Name = "colNSTUTS";
            this.colNSTUTS.Visible = true;
            this.colNSTUTS.VisibleIndex = 8;
            this.colNSTUTS.Width = 93;
            // 
            // colPSTU
            // 
            this.colPSTU.FieldName = "PSTU";
            this.colPSTU.Name = "colPSTU";
            this.colPSTU.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPSTU.Visible = true;
            this.colPSTU.VisibleIndex = 9;
            this.colPSTU.Width = 93;
            // 
            // colPSTUTS
            // 
            this.colPSTUTS.FieldName = "PSTUTS";
            this.colPSTUTS.Name = "colPSTUTS";
            this.colPSTUTS.Visible = true;
            this.colPSTUTS.VisibleIndex = 10;
            this.colPSTUTS.Width = 107;
            // 
            // opmXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 291);
            this.Controls.Add(this.opmSelGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "opmXF";
            this.Text = "Masters";
            ((System.ComponentModel.ISupportInitialize)(this.agnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wAN_AGN_OPM_SELBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opmSelGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opmSelGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgnDataSet agnDataSet;
        private System.Windows.Forms.BindingSource wAN_AGN_OPM_SELBindingSource;
        private AgnDataSetTableAdapters.WAN_AGN_OPM_SELTableAdapter wAN_AGN_OPM_SELTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel iQRYToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iQRYToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl opmSelGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView opmSelGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colOPMID;
        private DevExpress.XtraGrid.Columns.GridColumn colROT;
        private DevExpress.XtraGrid.Columns.GridColumn colMOT;
        private DevExpress.XtraGrid.Columns.GridColumn colORG;
        private DevExpress.XtraGrid.Columns.GridColumn colDST;
        private DevExpress.XtraGrid.Columns.GridColumn colREFNO;
        private DevExpress.XtraGrid.Columns.GridColumn colVHC;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colNSTUTS;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTU;
        private DevExpress.XtraGrid.Columns.GridColumn colPSTUTS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem housesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentsToolStripMenuItem;
    }
}