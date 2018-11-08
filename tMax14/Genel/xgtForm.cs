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

namespace tMax14.Genel
{
    public partial class xgtForm : DevExpress.XtraEditors.XtraForm
    {
        public xgtForm()
        {
            InitializeComponent();
        }

        private void xGTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            this.Validate();
            this.xgtBindingSource.EndEdit();
            this.xgtTableAdapter.Update(this.genelDataSet.XGT);

        }

        private void xgtForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genelDataSet.XGT' table. You can move, or remove it, as needed.
            this.xgtTableAdapter.Fill(this.genelDataSet.XGT);
            xgtGridView.ActiveFilterString = "[ID] <> '+'";
        }

        private void xgtForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save();
        }

        private void xgtGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            //info.GroupText = view.GetRowCellValue(e.RowHandle, colVAL).ToString();
            GenelDataSet.XGTRow xgtRow = this.genelDataSet.XGT.FindByGRPID(info.EditValue.ToString(), "+");
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
            GenelDataSet.XGTRow xgtRow = this.genelDataSet.XGT.FindByGRPID(grp, "+");

            if (xgtRow.SYS == "M" || xgtRow.SYS == "V")   // Grup Modify ise eklenebilir
            {
                View.AddNewRow();

                View.SetRowCellValue(View.FocusedRowHandle, colGRP, grp);
                View.SetRowCellValue(View.FocusedRowHandle, colID, "");
                View.SetRowCellValue(View.FocusedRowHandle, colSYS, "V");   // User Modify

                View.UpdateCurrentRow();
                View.MakeRowVisible(View.FocusedRowHandle, true);
                View.ShowEditor();
            }
        }

        private void kayitEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddRow(xgtGridView);
            //return;
            GridView view = xgtGridView;

            int currentRow;
            currentRow = view.FocusedRowHandle;

            if (currentRow < 0)
            {
                currentRow = view.GetDataRowHandleByGroupRowHandle(currentRow);
            }
            if (view.GroupedColumns.Count == 0)
                return;

            string grp = view.GetRowCellValue(currentRow, colGRP).ToString();
            GenelDataSet.XGTRow xgtRow = this.genelDataSet.XGT.FindByGRPID(grp, "+");

            if (xgtRow.SYS == "M" || xgtRow.SYS == "V")   // Grup Modify ise eklenebilir
            {
                xgtNewForm frm = new xgtNewForm(xgtRow.IDL);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        GenelDataSet.XGTRow nRow = this.genelDataSet.XGT.NewXGTRow();
                        nRow.GRP = grp;
                        nRow.ID = frm.ID;
                        nRow.VAL = frm.VAL;
                        nRow.SYS = "V";
                        this.genelDataSet.XGT.AddXGTRow(nRow);
                        Save();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void xgtGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;


            //if (!Program.LF.checkPermision("gtForm", "UPD", true))  // No permition
            //    return;

            if (view.GetDataRow(view.FocusedRowHandle).RowState != DataRowState.Added)
            {
                if (view.FocusedColumn.FieldName == "TXT")
                    return;

                e.Cancel = true;
                
                if (view.GetFocusedRowCellValue(colSYS).ToString() == "M")  // degisebilir
                    e.Cancel = false;
                else if (view.GetFocusedRowCellValue(colSYS).ToString() == "V")  // Sadece VAL degisebilir
                {
                    if (view.FocusedColumn == colVAL)
                        e.Cancel = false;
                }
            }
            if (!e.Cancel)
            {
                string grp = view.GetFocusedRowCellValue(colGRP).ToString();
                GenelDataSet.XGTRow xgtRow = this.genelDataSet.XGT.FindByGRPID(grp, "+");
                if (view.FocusedColumn == colID)
                    txtRepositoryItemTextEdit.MaxLength = xgtRow.IDL;
                if (view.FocusedColumn == colVAL)
                    txtRepositoryItemTextEdit.MaxLength = genelDataSet.XGT.Columns["VAL"].MaxLength;
            }
        }

    }
}