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
    public partial class opPackageTypeXF : DevExpress.XtraEditors.XtraForm
    {
        public opPackageTypeXF()
        {
            InitializeComponent();
        }

        private void oTPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.otpBindingSource.EndEdit();
            this.otpTableAdapter.Update(this.mainDataSet.OTP);

        }

        private void opPackageTypeXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.OTP' table. You can move, or remove it, as needed.
            this.otpTableAdapter.Fill(this.mainDataSet.OTP);

        }

        private void otpGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.FocusedColumn == colTOP &&
                view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle &&
                view.GetDataRow(view.FocusedRowHandle).RowState != DataRowState.Added)
                e.Cancel = true;

        }

        public void AddRow(DevExpress.XtraGrid.Views.Grid.GridView View)
        {
            int currentRow;
            currentRow = View.FocusedRowHandle;

            if (currentRow < 0)
            {
                currentRow = View.GetDataRowHandleByGroupRowHandle(currentRow);
            }

            //if (View.GroupedColumns.Count == 0)
            //    return;

            //string grp = View.GetRowCellValue(currentRow, colGRP).ToString();
            //GenelDataSet.XGTRow xgtRow = this.genelDataSet.XGT.FindByGRPID(grp, "+");

            View.AddNewRow();
            View.SetRowCellValue(View.FocusedRowHandle, colTUR, View.GetRowCellValue(currentRow, colTUR));

            //View.UpdateCurrentRow();
            View.MakeRowVisible(View.FocusedRowHandle, true);
            View.FocusedColumn = colTOP;
            View.ShowEditor();
        }

        private void kayitEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow(otpGridView);
        }


    }
}