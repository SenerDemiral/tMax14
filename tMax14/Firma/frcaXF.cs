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

namespace tMax14.Firma
{
    public partial class frcaXF : DevExpress.XtraEditors.XtraForm
    {
        public int FrtID = 0;

        public frcaXF()
        {
            InitializeComponent();

            frcaGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemGridLookUpEdit;
            colLOCID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(frcaGridControl);
        }

        public void Save()
        {
            this.Validate();
            this.frcaBindingSource.EndEdit();
            this.frcaTableAdapter.Update(this.firmaDataSet.FRCA);

        }

        private void frcaXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.FRCA' table. You can move, or remove it, as needed.
            if (FrtID == 0)
                this.frcaTableAdapter.Fill(this.firmaDataSet.FRCA, "FRCAID > 0", Program.USR);
            else
                this.frcaTableAdapter.Fill(this.firmaDataSet.FRCA, string.Format("FRTID = {0}", FrtID), Program.USR);

            if (FrtID != 0)
                colFRTID.OptionsColumn.ReadOnly = true;
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)firmaQueriesTableAdapter.GET_PK("FRT");
            view.SetFocusedRowCellValue(colFRCAID, PK);
            if (FrtID != 0)
                view.SetFocusedRowCellValue(colFRTID, FrtID);
            view.SetFocusedRowCellValue(colPRIORITY, "1");
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            if (gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !gridView1.IsDataRow(gridView1.FocusedRowHandle))
                return;

            int PK = (int)gridView1.GetFocusedRowCellValue(colFRCAID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = gridView1.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "FRCA";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            //this.tstTableAdapter.ClearBeforeFill = false;
            //this.tstTableAdapter.Fill(this.teklifDataSet.TST, string.Format("TSTid = {0}", PK), Program.USR);
        }
    }
}