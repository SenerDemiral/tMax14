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

            fRCAGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemGridLookUpEdit;
            colLOCID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(fRCAGridControl);
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
    }
}