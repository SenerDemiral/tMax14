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

namespace tMax14.AccountRpr
{
    public partial class AccKlnDtyAllXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Account.AccKlnDtyAllXF";
        Genel.efuMdfyXF efuMdfyFrm;

        public AccKlnDtyAllXF()
        {
            InitializeComponent();

            FrtGrpLookUpEdit.Properties.DataSource = Program.MF.frtGrpRepositoryItemCheckedComboBoxEdit.DataSource;
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            int nor = 0;
            Program.MF.startSW();

            string FrtGrp = FrtGrpLookUpEdit.EditValue == null ? "" : FrtGrpLookUpEdit.EditValue.ToString();
            if (YIDimageComboBoxEdit.EditValue != null)
                nor += this.accKlnDtyAllTableAdapter.Fill(this.accountRprDataSet.ACC_KLN_DTY_ALL, YIDimageComboBoxEdit.EditValue.ToString(), FrtGrp);
            nor += this.accKlnOztAllTopTableAdapter.Fill(this.accountRprDataSet.ACC_KLN_OZT_ALL_TOP);

            Program.MF.stopSW("Müşteri Kalanları", nor);

            accKlnOztAllTopGridView.BestFitColumns();
            //Genel.efuMdfyXF efuMdfyFrm = new Genel.efuMdfyXF(view.GetFocusedRowCellValue(colREFTO), view.GetFocusedRowCellValue(colREFID), view.GetFocusedRowCellValue(colEFUTAGS), view.GetFocusedRowCellValue(colEFUTKPTRH));
        }

        private void accKlnDtyAllGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var aaa = e.Item;
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                //if (e.IsGroupSummary && e.GroupLevel != colBDVZ.GroupIndex && fn == "BTUTBRT")
                if (colDDVZ.GroupIndex == -1 && fn != "AVDID")
                    e.Exists = false;
                else if (e.GroupLevel < colDDVZ.GroupIndex && (fn == "DKLN" || fn == "DBRCKLN" || fn == "DALCKLN"))
                    e.Exists = false;
            }
        }

        private void AccKlnDtyAllXF_Load(object sender, EventArgs e)
        {
        }

        private void takipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = accKlnDtyAllGridView;
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (efuMdfyFrm == null)
                efuMdfyFrm = new Genel.efuMdfyXF();

            efuMdfyFrm.RefTO = view.GetFocusedRowCellValue(colREFTO);
            efuMdfyFrm.RefID = view.GetFocusedRowCellValue(colREFID);
            efuMdfyFrm.TAGs = view.GetFocusedRowCellValue(colEFUTAGS);
            efuMdfyFrm.TkpTrh = view.GetFocusedRowCellValue(colEFUTKPTRH);

            if (efuMdfyFrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                view.SetFocusedRowCellValue(colEFUTAGS, efuMdfyFrm.TAGs);
                view.SetFocusedRowCellValue(colEFUINFO, efuMdfyFrm.Info);
                view.SetFocusedRowCellValue(colEFUTKPTRH, efuMdfyFrm.TkpTrh);
            }
            //frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            CompositeLink cLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcl1 = new PrintableComponentLink();
            pcl1.Component = accKlnDtyAllGridControl;
            PrintableComponentLink pcl2 = new PrintableComponentLink();
            pcl2.Component = accKlnOztAllTopGridControl;

            Link npl = new Link();  // newPage Link
            npl.CreateDetailArea += npl_CreateDetailArea;
            
            cLink.Links.Add(pcl1);
            cLink.Links.Add(npl);
            cLink.Links.Add(pcl2);

            cLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            cLink.Landscape = true;
            cLink.Margins.Left = 50;
            cLink.Margins.Right = 50;
            cLink.Margins.Top = 50;
            cLink.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = cLink.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Kalan Takibi");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            cLink.ShowPreviewDialog();
            */
            
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = accKlnDtyAllGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Kalan Takibi");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        void npl_CreateDetailArea(object sender, CreateAreaEventArgs e)
        {
            e.Graph.PrintingSystem.InsertPageBreak(0);
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XlsxExportOptions xeo = new XlsxExportOptions();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                accKlnDtyAllGridControl.ExportToXlsx(saveFileDialog.FileName);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = accKlnDtyAllGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void expLvl1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnDtyAllGridView.ExpandGroupLevel(0, false);
        }

        private void expLvl2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnDtyAllGridView.ExpandGroupLevel(1, false);
        }

        private void expLvl3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accKlnDtyAllGridView.ExpandGroupLevel(2, false);
        }

        private void accKlnOztAllTopGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
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

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = accKlnOztAllTopGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Kalan Takibi TOPLAM");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void exportToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = pivotGridControl1;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Müşteri Kalan Takibi TOPLAM");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void layoutsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Account.AccKlnDtyAllPvtXF";
            frm.origin = pivotGridControl1;
            frm.ShowDialog();
            frm.Dispose();

        }
    }
}