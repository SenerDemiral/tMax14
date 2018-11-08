using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace tMax14
{
    public partial class xgtForm : DevExpress.XtraEditors.XtraForm
    {
        public xgtForm()
        {
            InitializeComponent();
        }

        private void xGTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xgtBindingSource.EndEdit();
            this.xgtTableAdapter.Update(this.mainDataSet.XGT);

        }

        private void xgtForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.XGT' table. You can move, or remove it, as needed.
            this.xgtTableAdapter.Fill(this.mainDataSet.XGT);
            xgtGridView.ActiveFilterString = "[ID] <> '+'";
        }

        private void xgtGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            //info.GroupText = view.GetRowCellValue(e.RowHandle, colVAL).ToString();
            MainDataSet.XGTRow xgtRow = this.mainDataSet.XGT.FindByGRPID(info.EditValue.ToString(), "+");
            info.GroupText = xgtRow.VAL;
        }

        public void AddRow(DevExpress.XtraGrid.Views.Grid.GridView View)
        {

            int currentRow;
            currentRow = View.FocusedRowHandle;

            if (currentRow < 0)
            {
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow);
            }

            if (View.GroupedColumns.Count == 0)
                return;

            string grp = View.GetRowCellValue(currentRow, colGRP).ToString();
            MainDataSet.XGTRow xgtRow = this.mainDataSet.XGT.FindByGRPID(grp, "+");

            if (xgtRow.SYS == "M")   // Grup Modify ise eklenebilir
            {
                View.AddNewRow();

                View.SetRowCellValue(View.FocusedRowHandle, colGRP, grp);
                View.SetRowCellValue(View.FocusedRowHandle, colID, "");
                View.SetRowCellValue(View.FocusedRowHandle, colSYS, "M");   // User Modify

                //View.UpdateCurrentRow();
                View.MakeRowVisible(View.FocusedRowHandle, true);
                View.ShowEditor();
            }
        }

        private void kayitEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow(xgtGridView);
        }

        private void xgtGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            e.Cancel = true;

            //if (!Program.LF.checkPermision("gtForm", "UPD", true))  // No permition
            //    return;

            if (view.GetFocusedRowCellValue(colSYS).ToString() == "M")  // degisebilir
                e.Cancel = false;
            else if (view.GetFocusedRowCellValue(colSYS).ToString() == "V")  // Sadece VAL degisebilir
            {
                if (view.FocusedColumn == colVAL)
                    e.Cancel = false;
            }

            if (!e.Cancel)
            {
                string grp = view.GetFocusedRowCellValue(colGRP).ToString();
                MainDataSet.XGTRow xgtRow = this.mainDataSet.XGT.FindByGRPID(grp, "+");
                if (view.FocusedColumn == colID)
                    txtRepositoryItemTextEdit.MaxLength = xgtRow.IDL;
                if (view.FocusedColumn == colVAL)
                    txtRepositoryItemTextEdit.MaxLength = mainDataSet.XGT.Columns["VAL"].MaxLength;
            }

        }

    }
}