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

namespace tMax14.Teklif
{
    public partial class TeklifFtrAlsXF : DevExpress.XtraEditors.XtraForm
    {
        public int mID = 0;
        public string Editable = "F";

        public TeklifFtrAlsXF()
        {
            InitializeComponent();

            ftrAlsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            //colTUR.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;    InternalRep
            colBRM.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colOK.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            //Program.MF.GridControlSettings(ftrAlsGridControl);
        }

        private void TeklifFtrAlsXF_Load(object sender, EventArgs e)
        {
            if (Editable == "F")
            {
                ftrAlsGridView.OptionsBehavior.Editable = false;
                contextMenuStrip1.Enabled = false;
            }

            try
            {
                this.ftrAlsTableAdapter.Fill(this.teklifDataSet.TKLF_FTR_ALS_SEL, mID, Program.USR);
                ftrAlsGridView.BestFitColumns();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void createChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Chargelar oluşturulacaktır.  Eminmisiniz?", "Teklif -> AlışCharge", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            this.Validate();
            this.ftrAlsBindingSource.EndEdit();
            this.ftrAlsTableAdapter.Update(this.teklifDataSet.TKLF_FTR_ALS_SEL);
        }

        private void ınsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teklifDataSet.TKLF_FTR_ALS_SEL.ImportRow(ftrAlsGridView.GetFocusedDataRow());
            //ftrAlsGridView.AddNewRow();
        }

        private void ftrAlsGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = (GridView)sender;

            if (view.FocusedColumn.FieldName == "OK")
                if (view.GetFocusedRowCellValue(colFRTID) == DBNull.Value ||
                    string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colAHTID)))
                    e.Cancel = true;


                

            if (view.GetDataRow(view.FocusedRowHandle).RowState != DataRowState.Added)
            {
                if (view.FocusedColumn.FieldName == "TXT")
                    return;
            }
        }

        private void ftrAlsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = (GridView)sender;

            if (view.GetRowCellValue(e.RowHandle, "FRTID") == DBNull.Value ||
                view.GetRowCellValue(e.RowHandle, "AHTID") == DBNull.Value ||
                view.GetRowCellValue(e.RowHandle, "BRM") == DBNull.Value ||
                view.GetRowCellValue(e.RowHandle, "MIK") == DBNull.Value ||
                view.GetRowCellValue(e.RowHandle, "DVZ") == DBNull.Value ||
                view.GetRowCellValue(e.RowHandle, "FYT") == DBNull.Value)
            {
                view.SetRowCellValue(e.RowHandle, "OK", "F");
            }
        }
    }
}