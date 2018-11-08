
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraReports.UI;
using tMax14ReportClassLibrary;

namespace tMax14.AccountRpr
{
    public partial class ExtreXF : DevExpress.XtraEditors.XtraForm
    {
        public int frtID = 0;
        public string firma;

        public ExtreXF()
        {
            InitializeComponent();

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
            //DateTime dt1 = new DateTime(dateEdit1.DateTime.Year, dateEdit1.DateTime.Month, 1);
            //DateTime dt = dt1.AddMonths(1);
            //DateTime dt2 = new DateTime(dt.Year, dt.Month, 1);
            //Text = string.Format("{0} {1:MMMM yyyy} Ekstresi", firma, dateEdit1.DateTime);
            Text = string.Format("{0} [{1:dd.MM.yy} - {1:dd.MM.yy}] Ekstresi", firma, dateEdit1.DateTime, dateEdit2.DateTime);

            
            /*
            DnmRepositoryItemImageComboBox.Items[0].Description = string.Format("< {0:dd.MM.yy}", dateEdit1.DateTime);
            DnmOztRepositoryItemImageComboBox.Items[0].Description = string.Format("< {0:dd.MM.yy}", dateEdit1.DateTime);

            DnmRepositoryItemImageComboBox.Items[1].Description = string.Format("{0:dd.MM.yy}-{1:dd.MM.yy}", dateEdit1.DateTime, dateEdit2.DateTime.AddDays(-1));
            DnmOztRepositoryItemImageComboBox.Items[1].Description = string.Format("{0:dd.MM.yy}-{1:dd.MM.yy}", dateEdit1.DateTime, dateEdit2.DateTime.AddDays(-1));

            DnmRepositoryItemImageComboBox.Items[2].Description = string.Format("{0:dd.MM.yy} >", dateEdit2.DateTime.AddDays(-1));
            DnmOztRepositoryItemImageComboBox.Items[2].Description = string.Format("{0:dd.MM.yy} >", dateEdit2.DateTime.AddDays(-1));
            */
            try
            {
                //this.accExtreTableAdapter.Fill(this.accountRprDataSet.ACC_EXTRE, frtID, dateEdit1.DateTime, dateEdit2.DateTime);
                //this.accExtreOzetTableAdapter.Fill(this.accountRprDataSet.ACC_EXTRE_OZET, frtID, dateEdit1.DateTime, dateEdit2.DateTime);
                this.accExtreDtyTableAdapter.Fill(this.accountRprDataSet.ACC_EXTRE_DTY, frtID, dateEdit1.DateTime, dateEdit2.DateTime);
                this.accExtreOztTableAdapter.Fill(this.accountRprDataSet.ACC_EXTRE_OZT, frtID, dateEdit1.DateTime, dateEdit2.DateTime);

                accExtreGridView.BestFitColumns();
                
                //accExtreOztAdvBandedGridView.BestFitColumns();
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void accExtreGridView_EndGrouping(object sender, EventArgs e)
        {
           // if (!accExtreGridView.GroupedColumns.Contains(colDVZ))
           //     accExtreGridView.GroupSummary[0].SummaryType = DevExpress.Data.SummaryItemType.None;
        }

        private void accExtreGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDVZ.GroupIndex == -1 || e.GroupLevel < colDVZ.GroupIndex) && (fn == "DBRC" || fn == "DALC" || fn == "DKLN"))
                {
                    e.Exists = false;
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositeLink cLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcl1 = new PrintableComponentLink();
            pcl1.Component = accExtreGridControl;
            PrintableComponentLink pcl2 = new PrintableComponentLink();
            pcl2.Component = accExtreOztGridControl;
            
            cLink.Links.Add(pcl1);
            cLink.Links.Add(pcl2);

            cLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            cLink.Landscape = true;
            cLink.Margins.Left = 50;
            cLink.Margins.Right = 50;
            cLink.Margins.Top = 50;
            cLink.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = cLink.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("{0} Firma Extresi [{1:dd.MM.yyyy} - {2:dd.MM.yyyy}]", firma, dateEdit1.DateTime, dateEdit2.DateTime.AddDays(-1));
            //string mdlH = string.Format("{0} {1:MMMM yyyy} Ekstresi", firma, dateEdit1.DateTime);
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            cLink.ShowPreviewDialog();

            /*
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink();
            link.Component = accExtreGridControl;
            PrintableComponentLink link2 = new PrintableComponentLink();
            link2.Component = accExtreOzetGridControl;
            ps.Links.Add(link);
            ps.Links.Add(link2);
            
            
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Firma Extre");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();*/
        }

        private void accExtreGridView_ColumnFilterChanged(object sender, EventArgs e)
        {
            //colVDEDNMo.FilterInfo = colVDEDNM.FilterInfo;   // Ozet'e tasi
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExtreXR rpr = new ExtreXR(frtID, dateEdit1.DateTime, dateEdit2.DateTime);
            
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
            }

        }

        rptInfo rpti = new rptInfo();
        
        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtreXR rpr = new ExtreXR(frtID, dateEdit1.DateTime, dateEdit2.DateTime);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Firma Extre", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("EXTRE", "FRT", frtID, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail Firma Extre", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }


    }
}