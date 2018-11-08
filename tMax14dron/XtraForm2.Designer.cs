namespace tMax14dron
{
    partial class XtraForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dvzKurBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.queriesTableAdapter = new tMax14dron.DataSetTableAdapters.QueriesTableAdapter();
            this.hstDataSet = new tMax14dron.HstDataSet();
            this.hSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hstGridControl = new DevExpress.XtraGrid.GridControl();
            this.hstGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEXD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colErr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMsj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.kurUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstGridView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dvzKurBackgroundWorker
            // 
            this.dvzKurBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dvzKurBackgroundWorker_DoWork);
            this.dvzKurBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dvzKurBackgroundWorker_RunWorkerCompleted);
            // 
            // hstDataSet
            // 
            this.hstDataSet.DataSetName = "HstDataSet";
            this.hstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hSTBindingSource
            // 
            this.hSTBindingSource.DataMember = "HST";
            this.hSTBindingSource.DataSource = this.hstDataSet;
            // 
            // hstGridControl
            // 
            this.hstGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.hstGridControl.DataSource = this.hSTBindingSource;
            this.hstGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hstGridControl.Location = new System.Drawing.Point(0, 0);
            this.hstGridControl.MainView = this.hstGridView;
            this.hstGridControl.Name = "hstGridControl";
            this.hstGridControl.Size = new System.Drawing.Size(461, 385);
            this.hstGridControl.TabIndex = 1;
            this.hstGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.hstGridView});
            // 
            // hstGridView
            // 
            this.hstGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEXD,
            this.colKonu,
            this.colErr,
            this.colMsj});
            this.hstGridView.GridControl = this.hstGridControl;
            this.hstGridView.Name = "hstGridView";
            this.hstGridView.DoubleClick += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // colEXD
            // 
            this.colEXD.DisplayFormat.FormatString = "dd.MM.yy HH:mm:ss";
            this.colEXD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEXD.FieldName = "EXD";
            this.colEXD.Name = "colEXD";
            this.colEXD.Visible = true;
            this.colEXD.VisibleIndex = 0;
            this.colEXD.Width = 110;
            // 
            // colKonu
            // 
            this.colKonu.FieldName = "Konu";
            this.colKonu.Name = "colKonu";
            this.colKonu.Visible = true;
            this.colKonu.VisibleIndex = 1;
            this.colKonu.Width = 57;
            // 
            // colErr
            // 
            this.colErr.FieldName = "Err";
            this.colErr.Name = "colErr";
            this.colErr.Visible = true;
            this.colErr.VisibleIndex = 2;
            this.colErr.Width = 136;
            // 
            // colMsj
            // 
            this.colMsj.FieldName = "Msj";
            this.colMsj.Name = "colMsj";
            this.colMsj.Visible = true;
            this.colMsj.VisibleIndex = 3;
            this.colMsj.Width = 140;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "tMaxDron";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.kurUpdateToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 98);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // kurUpdateToolStripMenuItem
            // 
            this.kurUpdateToolStripMenuItem.Name = "kurUpdateToolStripMenuItem";
            this.kurUpdateToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kurUpdateToolStripMenuItem.Text = "KurUpdate";
            this.kurUpdateToolStripMenuItem.Click += new System.EventHandler(this.kurUpdateToolStripMenuItem_Click);
            // 
            // XtraForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 385);
            this.ControlBox = false;
            this.Controls.Add(this.hstGridControl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraForm2";
            this.ShowInTaskbar = false;
            this.Text = "tMax14dron";
            this.Load += new System.EventHandler(this.XtraForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hstGridView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker dvzKurBackgroundWorker;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private HstDataSet hstDataSet;
        private System.Windows.Forms.BindingSource hSTBindingSource;
        private DevExpress.XtraGrid.GridControl hstGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView hstGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colEXD;
        private DevExpress.XtraGrid.Columns.GridColumn colKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colErr;
        private DevExpress.XtraGrid.Columns.GridColumn colMsj;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem kurUpdateToolStripMenuItem;
    }
}