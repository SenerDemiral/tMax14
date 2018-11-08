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

namespace tMax14.AccountRpr
{
    public partial class AccMarkenFtrXF : DevExpress.XtraEditors.XtraForm
    {
        public string afbIDs;
        string layoutName = "AccountRpr.AccMarkenFtrXF";

        public AccMarkenFtrXF()
        {
            InitializeComponent();
        }

        private void AccMarkenFtrXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.aCC_MARKEN_FTRTableAdapter.Fill(this.accountRprDataSet.ACC_MARKEN_FTR, afbIDs);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            Program.MF.XGLrestore(layoutName, 0, accMarkenFtrGridView);

        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = accMarkenFtrGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = accMarkenFtrGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            /*
            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Faturaları");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;
            */
            link.CreateDocument();
            link.ShowPreview();

        }

    }
}