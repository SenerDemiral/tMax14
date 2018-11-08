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
using DevExpress.XtraPrinting;

namespace tMax14.Teklif
{
    public partial class TeklifSatisXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Teklif.TeklifSatisXF.tsb";
        int newTSBid;

        public TeklifSatisXF()
        {
            InitializeComponent();

            tsbGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemGridLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colCRRIDS.ColumnEdit = Program.MF.FRTcrrRepositoryItemCheckedComboBoxEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colORGS.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colDSTS.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colFNLDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colFRTDRM.ColumnEdit = Program.MF.frtDrmRepositoryItemLookUpEdit;
            colDTM.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselTBrepositoryItemCheckedComboBoxEdit;
            colPTM.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            
            Program.MF.GridControlSettings(tsbGridControl);

            Program.MF.XGLrestore(layoutName, 0, tsbGridView);
        }

        public void Save()
        {
            object PK;
            if (tsbGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                PK = newTSBid;
            else
                PK = tsbGridView.GetFocusedRowCellValue(colTSBID);
            this.Validate();
            this.tsbBindingSource.EndEdit();
            this.tsbTableAdapter.Update(this.teklifDataSet.TSB);
            this.tsbTableAdapter.Fill(this.teklifDataSet.TSB, string.Format("TSBID = {0}", PK), Program.USR);
        }

        private void TeklifSatisXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teklifDataSet.TSB' table. You can move, or remove it, as needed.
            this.tsbTableAdapter.Fill(this.teklifDataSet.TSB, "1=1", Program.USR);
            this.tsbTableAdapter.ClearBeforeFill = false;
        }

        private void tsbGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            newTSBid = (int)tafQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTSBID, newTSBid);
            //view.SetFocusedRowCellValue(colSTU, "A");   //Aktif
            view.SetFocusedRowCellValue(colTYP, "G");   //Genel
            view.SetFocusedRowCellValue(colROT, "E");   //Export
            view.SetFocusedRowCellValue(colDR, "D");   //Direct
            view.SetFocusedRowCellValue(colDF, "D");   //Direct
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = tsbGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = tsbGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colTSBID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "TSB";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            //this.tsbTableAdapter.FillByPK(this.teklifDataSet.TSB, PK);
        }

        private void attachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = tsbGridView;

            if (view.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "TSB";
            frm.RefID = (int)view.GetFocusedRowCellValue(colTSBID);
            frm.RefInfo = view.GetFocusedRowCellDisplayText(colTSBID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bookmarkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = tsbGridView;

            string BKMS = view.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                view.SetFocusedRowCellValue(colBKMS, BKMS);
                view.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                view.SetFocusedRowCellValue(colBKMS, BKMS);
                view.UpdateCurrentRow();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = tsbGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Satış Teklifleri");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void tsbGridView_CustomDrawRowFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Blue;    //Sadece ForeColor calisiyor, BackColor olmuyor
            //e.Info.DisplayText = string.Format("{0} {1:n2}", afbRow.BDVZ, e.Info.Value);

            if (e.Column == colTSBID)
            {
                decimal gCnt = Convert.ToDecimal(e.Info.Value);
                decimal tCnt = Convert.ToDecimal(tsbGridView.DataRowCount);
                //decimal tCnt = Convert.ToDecimal(colTSBID.SummaryItem.SummaryValue);
                if (tCnt != 0)
                {
                    decimal pc = Math.Round(gCnt / tCnt * 100, 0);
                    e.Info.DisplayText = string.Format("%{0}", pc);
                }
            }
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( tsbGridView.DataRowCount.ToString());
        }

        private void tsbGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo info = e.Info as DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            string s = "";
            foreach (DevExpress.XtraGrid.GridGroupSummaryItem g in view.GroupSummary)
            {
                if (g.ShowInGroupColumnFooter == null)
                {
                    if (s != string.Empty)
                        s += " ";
                    s += view.GetGroupSummaryDisplayText(e.RowHandle, g);
                }
            }
            //var aaa = view.GetGroupSummaryValues(e.RowHandle).Values;
            //decimal gCnt = Convert.ToDecimal(view.GetChildRowCount(e.RowHandle));
            int c = 0;
            decimal gCnt = Convert.ToDecimal(getChildRows(view, e.RowHandle, ref c));
            decimal tCnt = Convert.ToDecimal(tsbGridView.DataRowCount);
            //decimal tCnt = Convert.ToDecimal(colTSBID.SummaryItem.SummaryValue);
            if (tCnt != 0)
            {
                decimal pc = Math.Round(gCnt / tCnt * 100, 0);
                s += string.Format(" %{0}", pc);
            }
            
            info.GroupText = string.Format(view.GroupFormat, info.Column.Caption, info.GroupValueText, s);

            
        }

        public int getChildRows(GridView view, int groupRowHandle, ref int cnt)
        {
            if (!view.IsGroupRow(groupRowHandle)) return cnt;
            //Get the number of immediate children 
            int childCount = view.GetChildRowCount(groupRowHandle);
            for (int i = 0; i < childCount; i++)
            {
                //Get the handle of a child row with the required index 
                int childHandle = view.GetChildRowHandle(groupRowHandle, i);
                //If the child is a group row, then add its children to the list 
                if (view.IsGroupRow(childHandle))
                    getChildRows(view, childHandle, ref cnt);
                else
                    cnt++;
            }
            return cnt;
        }
    }
}