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

namespace tMax14.Misc
{
    public partial class frkXF : DevExpress.XtraEditors.XtraForm
    {
        public frkXF()
        {
            InitializeComponent();

            Program.MF.GridControlSettings(frkGridControl);
            frkGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colRPTID.ColumnEdit = Program.MF.RPTrepositoryItemCheckedComboBoxEdit;
        }

        public void Save()
        {
            this.Validate();
            this.frkBindingSource.EndEdit();
            this.frkTableAdapter.Update(this.miscDataSet.FRK);
        }
        
        private void frkXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.frkTableAdapter.Fill(this.miscDataSet.FRK, "", Program.USR);   // All
                frkTableAdapter.ClearBeforeFill = false;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void frkGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            int PK = (int)miscQueriesTableAdapter.GET_PK("FRT");

            view.SetFocusedRowCellValue(colFRKID, PK);
            view.SetFocusedRowCellValue(colTRH, DateTime.Today);
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = frkGridView;
            if (view.DataRowCount == 0)
                return;

            int refId = (int)view.GetFocusedRowCellValue(colFRKID);

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "FRK";
            frm.RefID = refId;
            frm.RefInfo = view.GetFocusedRowCellDisplayText(colAD);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = frkGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colFRKID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "FRK";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();
            this.frkTableAdapter.Fill(this.miscDataSet.FRK, string.Format("FRKid = {0}", PK), Program.USR); //Refresh Clear=false
        }

        private void mailGonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = frkGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colFRKID);
            frkSendXF frm = new frkSendXF();
            frm.frkID = PK;
            frm.info = view.GetFocusedRowCellDisplayText(colAD);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void reportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.rphXF frm = new Genel.rphXF();

            frm.iQry = $"INFO = 'FrkID:{frkGridView.GetFocusedRowCellValue(colFRKID)}'";

            frm.ShowDialog();
            frm.Dispose();
        }
    }
}