using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using tMax14ReportClassLibrary;
using DevExpress.XtraPrinting;

namespace tMax14.AccountRpr
{
    public partial class BaBsMtbktXF : DevExpress.XtraEditors.XtraForm
    {
        public BaBsMtbktXF()
        {
            InitializeComponent();

            //donemDateEdit.DateTime = DateTime.Today;

            DateTime today = DateTime.Today;
            dateEdit1.EditValue = new DateTime(today.Year, today.Month, 1);
            today = today.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime today = dateEdit1.DateTime.AddMonths(1);
            dateEdit2.EditValue = new DateTime(today.Year, today.Month, 1);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            this.aCC_BABSTableAdapter.Fill(this.accountRprDataSet.ACC_BABS, dateEdit1.DateTime, dateEdit2.DateTime);
            gridView1.BestFitColumns();

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int frtID = (int)gridView1.GetFocusedRowCellValue(colFRTID);

            BaBsMtkbtFrmXR rpr = new BaBsMtkbtFrmXR(frtID, dateEdit1.DateTime, dateEdit2.DateTime);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
            }
        }

        rptInfo rpti = new rptInfo();
        
        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int frtID = (int)gridView1.GetFocusedRowCellValue(colFRTID);
            BaBsMtkbtFrmXR rpr = new BaBsMtkbtFrmXR(frtID, dateEdit1.DateTime, dateEdit2.DateTime);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail BaBs Mutabakat Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("BABSMF", "FRT", frtID, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail BaBs Mutabakat Formu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = BaBsGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = Text;
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

    }
}