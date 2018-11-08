using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class FisDetayHistoryXF : DevExpress.XtraEditors.XtraUserControl
    {
        public string iQry;
        //public string HspNo;
        public int FRTid = 0;
        //public int refID;
        //public string refTO;
        public string info;

        public FisDetayHistoryXF()
        {
            InitializeComponent();

            avdHstGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.AHPhspNoAdRepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.AVBTrepositoryItemLookUpEdit;
        }

        private void FisDetayHistoryXF_Load(object sender, EventArgs e)
        {
            /*
            var p1 = this.Parent;   // p1 = {_Container [DevExpress.XtraBars.Docking.ControlContainer], BorderStyle: System.Windows.Forms.BorderStyle.None}
            var p2 = p1.Parent;   // p2 = { [DevExpress.XtraBars.Docking.DockPanel]}
            var o1 = p2 as DevExpress.XtraBars.Docking.DockPanel;
            dynamic o2 = o1.DockManager.Form;
            o2.Text = "SENER";
            //var f1 = o1.Form;
            var p3 = p2.Parent;   // p3 = {DevExpress.XtraBars.Docking.FloatForm, Text: }
            var o3 = p3 as DevExpress.XtraBars.Docking.FloatForm;
            
            var p4 = p3.Parent;   //
            */

            Text = string.Format("{0} Hesap Hareketleri", info);
            
            this.avdHstTableAdapter.Fill(this.accountDataSet.AVD_HST, iQry, FRTid);
            
            //avdHstGridView.BestFitColumns(true);

            //if (!string.IsNullOrWhiteSpace(HspNo))
            //    colHSPNO.Visible = false;

            dovizKalanlari();

            avdHstGridView.ActiveFilterString = "[SKL] = 'A'";
        }

        private void avdHstGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // RunningTotal  http://www.devexpress.com/Support/Center/Question/Details/Q366364
            GridView view = (GridView)sender;
            int rh = view.GetRowHandle(e.ListSourceRowIndex);

            if (e.Column == colREFID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colREFTO));

            if (e.Column.FieldName == "aRunTotal")
            {
                int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
                decimal qta = 0;
                for (int i = firstRowHandle; i <= rh; i++)
                {
                    if (view.GetRowCellValue(i, colBA).ToString() == "B")
                        qta += Convert.ToDecimal(view.GetRowCellValue(i, colATUT));
                    else
                        qta -= Convert.ToDecimal(view.GetRowCellValue(i, colATUT));
                }
                if (qta < 0)
                    e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
                else if (qta > 0)
                    e.DisplayText = qta.ToString("N") + " B";
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "dRunTotal")
            {
                int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
                decimal qta = 0;
                for (int i = firstRowHandle; i <= rh; i++)
                {
                    if (view.GetRowCellValue(i, colBA).ToString() == "B")
                        qta += Convert.ToDecimal(view.GetRowCellValue(i, colDTUT));
                    else
                        qta -= Convert.ToDecimal(view.GetRowCellValue(i, colDTUT));
                }
                if (qta < 0)
                    e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
                else if (qta > 0)
                    e.DisplayText = qta.ToString("N") + " B";
                else
                    e.DisplayText = "";
            }
        }

        private void dovizKalanlari()
        {
            Dictionary<string, decimal> dvzKln = new Dictionary<string, decimal>();
            decimal tut;

            foreach (AccountDataSet.AVD_HSTRow avdHstRow in this.accountDataSet.AVD_HST.Rows)
            {
                tut = avdHstRow.DTUT;
                if (avdHstRow.BA == "A")
                    tut *= -1m;
                if (dvzKln.ContainsKey(avdHstRow.DDVZ))
                    dvzKln[avdHstRow.DDVZ] += tut;
                else
                    dvzKln.Add(avdHstRow.DDVZ, tut);
            }
            dvzKlnGridControl.DataSource = dvzKln;

        }

        private void dvzKlnGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colDvzKlnTut)
            {
                decimal tut = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colDvzKlnTut));
                if (tut > 0)
                    e.DisplayText = string.Format("{0:N2} B", tut);
                if (tut < 0)
                    e.DisplayText = string.Format("{0:N2} A", tut * -1m);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //avdHstGridControl.ShowPrintPreview();

            PrintingSystem ps = new PrintingSystem();
            // Create a link that will print a control. 
            PrintableComponentLink link = new PrintableComponentLink(ps);
            // Specify the control to be printed. 
            link.Component = avdHstGridControl;
            // Set the paper format. 
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;
            // Subscribe to the CreateReportHeaderArea event used to generate the report header. 
            //link.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            //link.CreateMarginalFooterArea += link_CreateMarginalFooterArea;
            // Generate the report. 
            link.CreateDocument();
            // Show the report. 
            link.ShowPreview();

        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPreviewToolStripMenuItem.Checked = !showPreviewToolStripMenuItem.Checked;
            avdHstGridView.OptionsView.ShowPreview = showPreviewToolStripMenuItem.Checked;
            colACIKLAMA.Visible = !showPreviewToolStripMenuItem.Checked;
        }

        private void fisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FisXF frm = new FisXF();
            //frm.iQry = string.Format("AVBID = {0}", avdHstGridView.GetFocusedRowCellValue(colAVBID));
            //frm.Show();

            int AVBid = (int)avdHstGridView.GetFocusedRowCellValue(colAVBID);
            FisDetayXF frm = new FisDetayXF("V", AVBid);
            frm.ShowDialog();

        }

        private void avdHstGridView_CustomSummaryExists(object sender, CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZ.GroupIndex == -1 || e.GroupLevel < colDDVZ.GroupIndex) && (fn == "DBRC" || fn == "DALC" || fn == "DBKY"))
                {
                    e.Exists = false;
                    colCompDrunTotal.Visible = false;
                }
                else
                {
                    colCompDrunTotal.VisibleIndex = colDALC.VisibleIndex+1;
                }
            }
        }

        private void avdHstGridView_EndGrouping(object sender, EventArgs e)
        {
            if (colDDVZ.GroupIndex == -1)
                colCompDrunTotal.Visible = false;

            /*
                        GridView view = (GridView)sender;

                        view.GroupSummary.Clear();

                        view.GroupSummary.AddRange(new GridSummaryItem[] {
                                new GridGroupSummaryItem(SummaryItemType.Sum, "ABRC", colABRC, "{0:n2}"),
                                new GridGroupSummaryItem(SummaryItemType.Sum, "AALC", colAALC, "{0:n2}")});

                        if (colDDVZ.GroupIndex == 0)
                        {
                            colDBRC.Visible = true;
                            colDALC.Visible = true;

                            view.GroupSummary.AddRange(new GridSummaryItem[] {
                                new GridGroupSummaryItem(SummaryItemType.Sum, "DBRC", colDBRC, "{0:n2}"),
                                new GridGroupSummaryItem(SummaryItemType.Sum, "DALC", colDALC, "{0:n2}")});
                        }*/
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = avdHstGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("{0} Hesap Hareketleri", info);
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