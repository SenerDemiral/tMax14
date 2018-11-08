using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Account
{
    public partial class CbbXF : DevExpress.XtraEditors.XtraForm
    {
        int PK = 0;

        public CbbXF()
        {
            InitializeComponent();

            cBBGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHATALI.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(this.cBBGridControl);

        }

        private void cBBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cBBBindingSource.EndEdit();
            this.cBBTableAdapter.Update(this.accountDataSet.CBB);

        }

        private void CbbXF_Load(object sender, EventArgs e)
        {
            this.cBBTableAdapter.ClearBeforeFill = true;
            this.cBBTableAdapter.Fill(this.accountDataSet.CBB, "CBBID > 0");
            this.cBBTableAdapter.ClearBeforeFill = false;
        }

        public void Save()
        {
            this.Validate();
            this.cBBBindingSource.EndEdit();
            
            int cbbID = 0;
            
            try
            {
                this.cBBTableAdapter.Update(this.accountDataSet.CBB);

                var aaa = gridView1.FocusedRowHandle;
                if (gridView1.IsNewItemRow(gridView1.FocusedRowHandle))
                    cbbID = PK;
                else
                    cbbID = (int)gridView1.GetFocusedRowCellValue(colCBBID);
                this.cBBTableAdapter.Fill(this.accountDataSet.CBB, string.Format("CBBid = {0}", cbbID)); //Refresh
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            
            GridView view = sender as GridView;
            PK = (int)accountQueriesTableAdapter.GET_PK("ACC");

            view.SetRowCellValue(e.RowHandle, colCBBID, PK);
            view.SetRowCellValue(e.RowHandle, colBANK, "GB");
            view.SetRowCellValue(e.RowHandle, colDRM, "A");
            view.SetRowCellValue(e.RowHandle, colHATALI, "T");
            view.SetRowCellValue(e.RowHandle, colTRH, DateTime.Today.AddDays(-1));  // Birgun oncesi
            view.SetRowCellValue(e.RowHandle, colINSUSR, Program.USR);

        }

        private void detayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            if (gridView1.GetFocusedRowCellValue(colTRH) != DBNull.Value)
            {
                int cbbID = (int)gridView1.GetFocusedRowCellValue(colCBBID);
                CbdXF frm = new CbdXF();
                frm.cbbID = cbbID;
                frm.drm = gridView1.GetFocusedRowCellValue(colDRM).ToString();
                frm.trh = (DateTime)gridView1.GetFocusedRowCellValue(colTRH);
                frm.ShowDialog();

                // Refresh
                this.cBBTableAdapter.Fill(this.accountDataSet.CBB, string.Format("CBBid = {0}", cbbID)); //Refresh
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            string drm = view.GetFocusedRowCellValue(colDRM).ToString();
            if (drm == "K")
            {
                e.Cancel = true;
            }
        }

        private void muhasebeFisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(colAVBID) != DBNull.Value)
            {
                int avbID = (int)gridView1.GetFocusedRowCellValue(colAVBID);
                FisXF frm = new FisXF();
                frm.iAVBid = avbID;
                frm.ShowDialog();
            }

        }


    }
}