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
    public partial class KurGirisXF : DevExpress.XtraEditors.XtraForm
    {
        public KurGirisXF()
        {
            InitializeComponent();

            dvkGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(dvkGridControl);
        }

        private void trhDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            Save();
            this.dVKTableAdapter.Fill(this.accountDataSet.DVK, trhDateEdit.DateTime);
            
        }

        public void Save()
        {
            this.Validate();
            this.dVKBindingSource.EndEdit();
            this.dVKTableAdapter.Update(this.accountDataSet.DVK);
        }

        private void dvkGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            dvkGridView.SetFocusedRowCellValue(colTRH, trhDateEdit.DateTime);
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvkGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !dvkGridView.IsDataRow(dvkGridView.FocusedRowHandle))
                return;

            Save();
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = dvkGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.DvkDvz = dvkGridView.GetFocusedRowCellDisplayText(colDVZ);
            frm.DvkTrh = (DateTime)dvkGridView.GetFocusedRowCellValue(colTRH);
            frm.ShowDialog();
            frm.Dispose();
            this.dVKTableAdapter.Fill(this.accountDataSet.DVK, trhDateEdit.DateTime);
        }

    }
}