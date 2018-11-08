using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.KaliteKontrol
{
    public partial class kkOlyFlytXF : DevExpress.XtraEditors.XtraForm
    {
        public kkOlyFlytXF()
        {
            InitializeComponent();
        }

        private void fillTable()
        {
            this.kK_OLYFLYTTableAdapter.Fill(this.kkDataSet.KK_OLYFLYT, "");
        }

        private void kkOlyFlyXF_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = kkOlyFlytGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Kalite Yönetim Olay Faaliyet", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }
    }
}