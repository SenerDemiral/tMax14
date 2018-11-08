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
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.AccountRpr
{
    public partial class AvdHstXF : DevExpress.XtraEditors.XtraForm
    {
        public string HspNo = "";
        public int FRTid = 0;
        public string info;
        
        public AvdHstXF()
        {
            InitializeComponent();

            avdHstGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.AHPhspNoAdRepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.AVBTrepositoryItemLookUpEdit;

        }

        private void AvdHstXF_Load(object sender, EventArgs e)
        {
            Text = string.Format("{0} Hesap Hareketleri", info);

            this.avdHstTableAdapter.Fill(this.accountRprDataSet.ACC_AVD_HST, FRTid, HspNo);
            this.accKlnOztTekTableAdapter.Fill(this.accountRprDataSet.ACC_KLN_OZT_TEK, FRTid, HspNo);

            avdHstGridView.ExpandAllGroups();
            avdHstGridView.BestFitColumns();
            accKlnOztTekGridView.ExpandAllGroups();
            accKlnOztTekGridView.BestFitColumns();

            //avdHstGridView.ActiveFilterString = "[SKL] = 'A'";
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            string mdlH = Text;
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void fisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!avdHstGridView.IsDataRow(avdHstGridView.FocusedRowHandle))
                return;
            
            int AVBid = (int)avdHstGridView.GetFocusedRowCellValue(colAVBID);
            Account.FisDetayXF frm = new Account.FisDetayXF("V", AVBid);
            frm.ShowDialog();
        }

        private void avdHstGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            // RunningTotal  http://www.devexpress.com/Support/Center/Question/Details/Q366364
            GridView view = (GridView)sender;
            int rh = view.GetRowHandle(e.ListSourceRowIndex);

            if (e.Column == colREFID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colREFTO));

            if (e.Column.FieldName == "CumBkyTL")
            {
                int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
                decimal qta = 0;
                for (int i = firstRowHandle; i <= rh; i++)
                {
                    decimal tut = view.GetRowCellValue(i, colATUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(i, colATUT));
                    if (view.GetRowCellValue(i, colBA).ToString() == "B")
                        qta += tut;
                    else
                        qta -= tut;
                }
                if (qta < 0)
                    e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
                else if (qta > 0)
                    e.DisplayText = qta.ToString("N") + " B";
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "CumBky")
            {
                int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
                decimal qta = 0;
                for (int i = firstRowHandle; i <= rh; i++)
                {
                    decimal tut = view.GetRowCellValue(i, colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(i, colDTUT));
                    if (view.GetRowCellValue(i, colBA).ToString() == "B")
                        qta += tut;
                    else
                        qta -= tut;
                }
                if (qta < 0)
                    e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
                else if (qta > 0)
                    e.DisplayText = qta.ToString("N") + " B";
                else
                    e.DisplayText = "";
            }
        }

        private void accKlnOztTekGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZt.GroupIndex == -1 || e.GroupLevel < colDDVZt.GroupIndex) && (fn == "DBRC" || fn == "DALC" || fn == "DBKY" || fn == "DBRCKLN" || fn == "DALCKLN"))
                    e.Exists = false;
            }
        }

        private void avdHstGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                if (e.IsGroupSummary && (colDDVZ.GroupIndex == -1 || e.GroupLevel < colDDVZ.GroupIndex) && (fn == "DBRC" || fn == "DALC" || fn == "DBKY"))
                    e.Exists = false;
            }
        }

        private void avdHstGridView_EndGrouping(object sender, EventArgs e)
        {
            if (colDDVZ.GroupIndex == -1)
                colCumBky.Visible = false;
            else
                colCumBky.Visible = true;
        }

    }
}