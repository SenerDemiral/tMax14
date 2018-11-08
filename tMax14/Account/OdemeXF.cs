using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class OdemeXF : DevExpress.XtraEditors.XtraForm
    {
        public OdemeXF()
        {
            InitializeComponent();
        }

        public void Save()
        {
            this.Validate();
            this.aobBindingSource.EndEdit();
            this.aobTableAdapter.Update(this.accountDataSet.AOB);

        }

        private void OdemeXF_Load(object sender, EventArgs e)
        {
            Program.MF.GridControlSettings(aobGridControl);
            aobGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            this.aobTableAdapter.Fill(this.accountDataSet.AOB, "FRTID = -1");

        }

        private void detaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeDetayXF frm = new OdemeDetayXF();
            frm.aobRow = (AccountDataSet.AOBRow)aobGridView.GetFocusedDataRow();

            frm.ShowDialog();
        }

        private void aobGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int AOBid = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colAOBID, AOBid);
        }


    }
}