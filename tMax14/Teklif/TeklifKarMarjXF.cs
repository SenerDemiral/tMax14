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
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Teklif
{
    public partial class TeklifKarMarjXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "Teklif.TeklifKarMarjXF";
        TeklifDataSet.TKMRow sRow;
        
        public TeklifKarMarjXF()
        {
            InitializeComponent();

            tkmGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colKMG.ColumnEdit = Program.MF.KMGrepositoryItemLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemCheckedComboBoxEdit;

            Program.MF.XGLrestore(layoutName, 0, tkmGridView);
        }

        private void tKMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tkmBindingSource.EndEdit();
            this.tkmTableAdapter.Update(this.teklifDataSet.TKM);

        }

        private void TeklifKarMarjXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teklifDataSet.TKM' table. You can move, or remove it, as needed.
            this.tkmTableAdapter.Fill(this.teklifDataSet.TKM);

        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = tkmGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tkmGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Teklif Kar Marj", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void tkmGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTKMID, PK);
            view.SetFocusedRowCellValue(colROT, "E");
            view.SetFocusedRowCellValue(colMOT, "A");
            view.SetFocusedRowCellValue(colKMG, "A");
            view.SetFocusedRowCellValue(colDVZ, "USD");

            if (sRow != null)
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn col in tkmGridView.Columns)
                    view.SetFocusedRowCellValue(col, sRow[col.FieldName]);

                view.SetFocusedRowCellValue(colTKMID, PK);
                view.SetFocusedRowCellValue(colKMG, "_");
                sRow = null;
            }

        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tkmGridView.IsDataRow(tkmGridView.FocusedRowHandle))
                return;

            this.tkmBindingSource.EndEdit();

            sRow = (TeklifDataSet.TKMRow)tkmGridView.GetFocusedDataRow();
            tkmGridView.AddNewRow();

            
            /*
            TeklifDataSet.TKMRow sRow = (TeklifDataSet.TKMRow)tkmGridView.GetFocusedDataRow();
            TeklifDataSet.TKMRow dRow = teklifDataSet.TKM.NewTKMRow();

            dRow.ItemArray = sRow.ItemArray;
            dRow["KMG"] = "_";  // Degistirmesi gerek!

            teklifDataSet.TKM.AddTKMRow(dRow);
            */

            tkmGridView.FocusedColumn = colKMG;
        }

        private void tkmGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (tkmGridView.GetRowCellValue(e.RowHandle, colKMG).ToString() == "_")
            {
                e.Valid = false;
                e.ErrorText = "Marj Grubu girin";
            }
        }


        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tkmGridView.IsDataRow(tkmGridView.FocusedRowHandle))
                return;

            this.tkmBindingSource.EndEdit();
            sRow = (TeklifDataSet.TKMRow)tkmGridView.GetFocusedDataRow();

            tkmGridView.AddNewRow();

            tkmGridView.SetFocusedRowCellValue("KGM", "C");

        }
    }
}