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
using DevExpress.XtraGrid;

namespace tMax14.AccountRpr
{
    public partial class AccKlnOztAllXF : DevExpress.XtraEditors.XtraForm
    {
        public AccKlnOztAllXF()
        {
            InitializeComponent();
        }

        private void AccKlnOztAllXF_Load(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();

            nor = this.accKlnOztAllTableAdapter.Fill(this.accountRprDataSet.ACC_KLN_OZT_ALL);

            Program.MF.stopSW("Müşteri Brç/Alc/Kln Özet", nor);

            accKlnOztAllGridView.BestFitColumns();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = accKlnOztAllGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Brç/Alc/Kln Özet");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void expLvl1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnOztAllGridView.ExpandGroupLevel(0, false);
        }

        private void expLvl2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnOztAllGridView.ExpandGroupLevel(1, false);
        }

        private void expLvl3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnOztAllGridView.ExpandGroupLevel(2, false);
        }

        private void accKlnOztAllGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZ.GroupIndex == -1 || e.GroupLevel < colDDVZ.GroupIndex) && (fn == "DBRC" || fn == "DALC" || fn == "DBKY" || fn == "DBRCKLN" || fn == "DALCKLN"))
                {
                    e.Exists = false;
                }
            }
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = accKlnOztAllGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = view.GetFocusedRowCellDisplayText(colHSPNO);
            frm.FRTid = 0;
            frm.info = string.Format("{0} • {1}", view.GetFocusedRowCellDisplayText(colHSPNO), view.GetFocusedRowCellDisplayText(colHSPAD));
            frm.Show();

        }
    }
}