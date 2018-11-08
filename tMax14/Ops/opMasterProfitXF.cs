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

namespace tMax14.Ops
{
    public partial class opMasterProfitXF : DevExpress.XtraEditors.XtraForm
    {
        public int OPMid = 0;

        public opMasterProfitXF()
        {
            InitializeComponent();

            opmProfitGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
        }

        private void opMasterProfit_Load(object sender, EventArgs e)
        {
            Program.MF.XGLrestore("Ops.opMasterProfitXF", 0, opmProfitGridView);

            this.opmProfitTableAdapter.Fill(this.opsDataSet.OPM_PROFIT, OPMid, Program.rprDvz);
        }

        private void opmProfitGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.Value != DBNull.Value && e.Column == colRTUT && (decimal)e.Value < 0)
                e.DisplayText = string.Format("{0:N2}", Math.Abs((decimal)e.Value));
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmProfitGridView.IsDataRow(opmProfitGridView.FocusedRowHandle))
                if (opmProfitGridView.GetFocusedRowCellValue(colAFBID) != DBNull.Value)
                { 
                    int AFBid = (int)opmProfitGridView.GetFocusedRowCellValue(colAFBID);
                    Account.FaturaDetayXF frm = new Account.FaturaDetayXF(AFBid, false);
                    frm.ShowDialog();
                }
        }

        private void onayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.onayXF frm = new Genel.onayXF();
            string islYtkCur, accYtkCur;
            Program.MF.IslAccCurYtk("M", OPMid, out islYtkCur, out accYtkCur);
            frm.curYTK = accYtkCur;
            frm.Tbl = "OPMA";
            frm.TblPK = OPMid;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Ops.opMasterProfitXF";
            frm.origin = opmProfitGridView;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}