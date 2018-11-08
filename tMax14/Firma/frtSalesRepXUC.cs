using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.Firma
{
    public partial class frtSalesRepXUC : DevExpress.XtraEditors.XtraUserControl
    {
        string layoutName = "Firma.frtSalesRepXUC";
        
        public frtSalesRepXUC()
        {
            InitializeComponent();

            Program.MF.XGLrestore(layoutName, 0, frtSalesRepGridView);
        }

        private void frtSalesRepXUC_Load(object sender, EventArgs e)
        {
            Qry.qsvFrtSalesRepXUC frm = new Qry.qsvFrtSalesRepXUC();
            frm.DT = firmaDataSet.FRT_SALESREP;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);
            
            //this.frtSalesRepTableAdapter.Fill(this.firmaDataSet.FRT_SALESREP, Program.USR, "", "");
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = frtSalesRepGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = frtSalesRepGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "SalesRep Activity Report", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //previewToolStripMenuItem.Checked = !previewToolStripMenuItem.Checked;
            frtSalesRepGridView.OptionsView.ShowPreview = previewToolStripMenuItem.Checked;
        }
    }
}
