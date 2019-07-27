using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Genel
{
    public partial class xtgXF : DevExpress.XtraEditors.XtraForm
    {
        public xtgXF()
        {
            InitializeComponent();

            xtgBindingSource.DataSource = Program.MF.mainDataSet.XTG;
        }

        private void xtgGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (xtgGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                xtgGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                return;

            int ri = xtgGridView.GetDataSourceRowIndex(xtgGridView.FocusedRowHandle);
            //MainDataSet.XTGRow xtgRow = (MainDataSet.XTGRow)xtgGridView.GetFocusedRow();
            if (xtgGridView.FocusedColumn == colTAG && Program.MF.mainDataSet.XTG[ri].RowState != DataRowState.Added)
                e.Cancel = true;
        }

        private void xtgGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var View = xtgGridView;
            int currentRow;
            currentRow = View.FocusedRowHandle;

            View.AddNewRow();
            /*
            if (currentRow < 0)
            {
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow);
            }

            if (View.GroupedColumns.Count == 0)
                return;

            string tbl = View.GetRowCellValue(currentRow, colTBL).ToString();
            MainDataSet.XTGRow row = Program.MF.mainDataSet.XTG.FindByTBLTAG(tbl, "+");

            View.AddNewRow();

            View.SetRowCellValue(View.FocusedRowHandle, colTBL, tbl);
            View.SetRowCellValue(View.FocusedRowHandle, colTAG, "");

            View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);
            View.ShowEditor();*/
        }

        private void deleteUnSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xtgGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                xtgGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                return;

            int ri = xtgGridView.GetDataSourceRowIndex(xtgGridView.FocusedRowHandle);
            if (Program.MF.mainDataSet.XTG[ri].RowState == DataRowState.Added)
                xtgGridView.DeleteRow(xtgGridView.FocusedRowHandle);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            this.Validate();
            this.xtgBindingSource.EndEdit();
            this.xtgTableAdapter.Update(Program.MF.mainDataSet.XTG);
        }

        private void xtgXUC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xtgGridView.DeleteRow(xtgGridView.FocusedRowHandle);
        }
    }
}
