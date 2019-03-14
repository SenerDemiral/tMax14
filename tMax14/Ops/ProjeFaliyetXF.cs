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
    public partial class ProjeFaliyetXF : DevExpress.XtraEditors.XtraForm
    {
        public int PrtID = 0;
        public bool Editable = false;
        string layoutName = "OPS.ProjeFaliyetXF";

        public ProjeFaliyetXF()
        {
            InitializeComponent();

            prfGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            Program.MF.XGLrestore(layoutName, 0, prfGridView);
        }

        private void ProjeFaliyetXF_Load(object sender, EventArgs e)
        {
            this.prfTableAdapter.FillByPRT(this.opsDataSet.PRF, PrtID);

            prfGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colSORUMLU.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            colDRM.ColumnEdit = Program.MF.prtDrmRepositoryItemLookUpEdit;
            //colKONU.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;
            //colDETAY.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;

            Program.MF.GridControlSettings(prfGridControl);

            prfGridView.OptionsBehavior.Editable = Editable;

        }

        public void Save()
        {
            this.Validate();
            this.prfBindingSource.EndEdit();
            this.prfTableAdapter.Update(this.opsDataSet.PRF);
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colPRTID, PrtID);
            view.SetRowCellValue(e.RowHandle, colPRFID, Program.MF.mainQueriesTableAdapter.GET_PK("PRJ"));
        }

        private void ProjeFaliyetXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = prfGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

    }
}