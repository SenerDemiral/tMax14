using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class ProjeSablonXUC : DevExpress.XtraEditors.XtraForm
    {
        public OpsDataSet.PRSRow prsRow;

        public ProjeSablonXUC()
        {
            InitializeComponent();
        }

        private void pRSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);

        }

        private void editSablonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjeSablonEditXF frm = new ProjeSablonEditXF();
            frm.richText = prsGridView.GetFocusedRowCellValue(colSABLON).ToString();
            frm.ShowDialog();
            prsGridView.SetFocusedRowCellValue(colSABLON, frm.richText);
            frm.Dispose();
        }

        private void ProjeSablonXUC_Load(object sender, EventArgs e)
        {
            this.prsTableAdapter.Fill(opsDataSet.PRS);
        }

        private void buSablonuKullanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prsRow = (OpsDataSet.PRSRow)prsGridView.GetFocusedDataRow();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;         
        }

        private void prsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colPRSID, Program.MF.mainQueriesTableAdapter.GET_PK("PRJ"));
        }
    }
}
