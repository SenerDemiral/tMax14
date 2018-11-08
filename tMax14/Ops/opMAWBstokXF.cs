using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class opMAWBstokXF : DevExpress.XtraEditors.XtraForm
    {
        public opMAWBstokXF()
        {
            InitializeComponent();

            opmiGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
        }

        private void oPMIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.opmiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);

        }

        private void opMAWBstokXF_Load(object sender, EventArgs e)
        {
            this.opmiTableAdapter.Fill(this.opsDataSet.OPMI);
        }

        private void opmiGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle && 
                view.GetDataRow(view.FocusedRowHandle).RowState != DataRowState.Added)
                e.Cancel = true;

        }
    }
}