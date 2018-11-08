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

namespace tMax14.Ops
{
    public partial class obsXF : DevExpress.XtraEditors.XtraForm
    {
        public obsXF()
        {
            InitializeComponent();

            obsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colACCAGNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSPNSRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCROID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSITEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDSTLABID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAIRPORTID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(obsGridControl);

        }

        public void Save()
        {
            this.Validate();
            this.obsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);
        }

        private void obsXF_Load(object sender, EventArgs e)
        {
            this.obsTableAdapter.Fill(this.opsDataSet.OBS, string.Format("OBSID > 0"), Program.USR);

        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS"); 
            view.SetFocusedRowCellValue(colOBSID, PK);
            view.SetFocusedRowCellValue(colSTU, "N");
        }

        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(obsGridView.GetFocusedRowCellDisplayText(colPRTNO)) ||
                string.IsNullOrEmpty(obsGridView.GetFocusedRowCellDisplayText(colSITENO)) ||
                obsGridView.GetFocusedRowCellValue(colDSTLABID) == DBNull.Value)
            {
                MessageBox.Show("PrtNo, SiteNo ve DstLab girilmeli");
                return;
            }
            
            Save();
            obsdXF frm = new obsdXF();
            frm.Editable = obsGridView.GetFocusedRowCellValue(colEDITABLE).ToString();
            frm.obsID = (int)obsGridView.GetFocusedRowCellValue(colOBSID);
            frm.PrtNo = obsGridView.GetFocusedRowCellDisplayText(colPRTNO);
            frm.SiteNo = obsGridView.GetFocusedRowCellDisplayText(colSITENO);
            frm.DstLabID = (int)obsGridView.GetFocusedRowCellValue(colDSTLABID);
            frm.ShowDialog();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (obsGridView.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "OBS";
            frm.RefID = (int)obsGridView.GetFocusedRowCellValue(colOBSID);
            frm.RefInfo = obsGridView.GetFocusedRowCellDisplayText(colOBSID);
            frm.ShowDialog();
            frm.Dispose();

        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)obsGridView.GetFocusedRowCellValue(colOBSID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "OBS";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();

        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            if (obsGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !obsGridView.IsDataRow(obsGridView.FocusedRowHandle))
                return;

            int PK = (int)obsGridView.GetFocusedRowCellValue(colOBSID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = obsGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "OBS";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.obsTableAdapter.ClearBeforeFill = false;
            this.obsTableAdapter.Fill(opsDataSet.OBS, string.Format("OBSID = {0}", PK), Program.USR);

        }
    }
}