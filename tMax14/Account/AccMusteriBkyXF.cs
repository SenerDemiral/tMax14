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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class AccMusteriBkyXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Account.AccMusteriBkyXF";
        
        public AccMusteriBkyXF()
        {
            InitializeComponent();

            accMusteriBkyGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colEFUTAGS.ColumnEdit = Program.MF.TAGselEFUrepositoryItemCheckedComboBoxEdit;

            Program.MF.XGLrestore(layoutName, 0, gridView1);
        }

        private void AccMusteriBkyXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.ACC_MUSTERI_BKY' table. You can move, or remove it, as needed.

        }

        private void gridView1_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var aaa = e.Item;
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                //if (e.IsGroupSummary && e.GroupLevel != colBDVZ.GroupIndex && fn == "BTUTBRT")
                if (colDDVZ.GroupIndex == -1 && fn != "AVDID")
                    e.Exists = false;
                else if (e.GroupLevel < colDDVZ.GroupIndex && (fn == "DBKY" || fn == "DBRCBKY" || fn == "DALCBKY"))
                    e.Exists = false;
            }
        }

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
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
            info.GroupText = string.Format(view.GroupFormat, info.Column.Caption, info.EditValue, s);
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            if (colHSPAD.GroupIndex > -1)
                colHSPAD.VisibleIndex = -1;
            else
                colHSPAD.VisibleIndex = 0;

            if (colYID.GroupIndex > -1)
                colYID.VisibleIndex = -1;
            else
                colYID.VisibleIndex = 0;
        }

        private void gridView1_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            GridView View = sender as GridView;
            string tags = View.GetRowCellDisplayText(e.RowHandle, colEFUTAGS);
            string info = View.GetRowCellDisplayText(e.RowHandle, colEFUINFO);

            //if (View.GetRowCellDisplayText(e.RowHandle, colTAGS) != "")
            e.PreviewText = tags;
            if (e.PreviewText != "" && info != "")
                e.PreviewText += "\r\n";
            e.PreviewText += info;

        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPreviewToolStripMenuItem.Checked = !showPreviewToolStripMenuItem.Checked;
            gridView1.OptionsView.ShowPreview = showPreviewToolStripMenuItem.Checked;
        }

        private void takipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            var view = gridView1;
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Genel.efuMdfyXF frm = new Genel.efuMdfyXF(view.GetFocusedRowCellValue(colREFTO), view.GetFocusedRowCellValue(colREFID), view.GetFocusedRowCellValue(colEFUTAGS), view.GetFocusedRowCellValue(colEFUTKPTRH));

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                view.SetFocusedRowCellValue(colEFUTAGS, frm.TAGs);
                view.SetFocusedRowCellValue(colEFUINFO, frm.Info);
                view.SetFocusedRowCellValue(colEFUTKPTRH, frm.TkpTrh);
            }
            frm.Dispose();
             * */
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var ps = new PrintingSystem();
            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.DataAware;

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = accMusteriBkyGridControl;
            
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
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

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XlsxExportOptions xeo = new XlsxExportOptions();
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                accMusteriBkyGridControl.ExportToXlsx(saveFileDialog.FileName);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = gridView1;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = gridView1;
            if (!view.IsDataRow(view.FocusedRowHandle) || view.GetFocusedRowCellDisplayText(colREFTO) != "F")
                return;

            //Account.FaturaXF frm = new Account.FaturaXF();
            //frm.AFBid = (int)view.GetFocusedRowCellValue(colREFID);

            int AFBid = (int)view.GetFocusedRowCellValue(colREFID);
            FaturaDetayXF frm = new FaturaDetayXF(AFBid, false);
            frm.ShowDialog();
            frm.Dispose();

        }

        private void expandLevel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = gridView1;
            view.ExpandGroupLevel(1, false);
        }

        private void fillSimpleButton_Click(object sender, EventArgs e)
        {
            if (YIDimageComboBoxEdit.SelectedIndex == 2)
            {
                colYID.GroupIndex = 0;
                colHSPAD.GroupIndex = 1;
                colDDVZ.GroupIndex = 2;
            }
            else
            {
                colYID.GroupIndex = -1;
                colHSPAD.GroupIndex = 0;
                colDDVZ.GroupIndex = 1;
            }
            
            int nor = 0;
            Program.MF.startSW();

            nor = this.accMusteriBkyTableAdapter.Fill(this.accountDataSet.ACC_MUSTERI_BKY, YIDimageComboBoxEdit.EditValue.ToString());

            Program.MF.stopSW("Müşteri Bakiye", nor);


        }

    }
}