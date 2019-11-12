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

namespace tMax14.Teklif
{
    public partial class TenderTakipXF : DevExpress.XtraEditors.XtraForm
    {
        public TenderTakipXF()
        {
            InitializeComponent();

            tttGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colHNDID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colORGS.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colDSTS.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;

            colSTU.ColumnEdit = Program.MF.TklfStuRepositoryItemImageComboBox;
            colROTS.ColumnEdit = Program.MF.ROTrepositoryItemCheckedComboBoxEdit;
            colMOTS.ColumnEdit = Program.MF.MOTrepositoryItemCheckedComboBoxEdit;
            colSRCTYP.ColumnEdit = Program.MF.frtSrcTypRepositoryItemLookUpEdit;
            colRSPUSRS.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

            //colCOMMENTS.ColumnEdit = Program.MF.Te
        }

        private void tTTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tttBindingSource.EndEdit();
            this.tttTableAdapter.Update(this.teklifDataSet.TTT);

        }

        private void TenderTakipXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teklifDataSet.TTT' table. You can move, or remove it, as needed.
            this.tttTableAdapter.Fill(this.teklifDataSet.TTT);

        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                return;
            if (!gridView1.IsDataRow(gridView1.FocusedRowHandle))
                return;

            int refId = (int)gridView1.GetFocusedRowCellValue(colTTTID);

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "TTT";
            frm.RefID = refId;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTTTID, PK);
        }

        private void attachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
                return;
            if (!gridView1.IsDataRow(gridView1.FocusedRowHandle))
                return;

            int refId = (int)gridView1.GetFocusedRowCellValue(colTTTID);

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "TTT";
            frm.RefID = refId;
            frm.RefInfo = string.Format("Tender {0}", refId);
            frm.ShowDialog();
            frm.Dispose();

        }
    }
}