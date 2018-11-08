using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;
using DevExpress.XtraGrid;

namespace tMax14.Account
{
    public partial class FisKapamaFisiXF : DevExpress.XtraEditors.XtraForm
    {
        public int AvbID = 933537;

        public FisKapamaFisiXF()
        {
            InitializeComponent();

            avbKapamaKapaSelGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNO.ColumnEdit = Program.MF.AHPhspNoAdRepositoryItemLookUpEdit;  //Display
        }

        private void FisKapamaFisiXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.avbKapamaKapaSelTableAdapter.Fill(this.accountDataSet.AVB_KAPAMA_KAPA_SEL, AvbID, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private decimal getGrupTop(int sii)
        {
            GridView view = gridView2;

            int groupRowHandle = -1;
            
            if (view.FocusedRowHandle >= 0)
                groupRowHandle = view.GetParentRowHandle(view.FocusedRowHandle);
            else
                groupRowHandle = view.FocusedRowHandle;
            
            if (!view.IsGroupRow(groupRowHandle)) 
                return 0;

            return Convert.ToDecimal(view.GetGroupSummaryValue(groupRowHandle, (GridGroupSummaryItem)view.GroupSummary[sii]));
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            GridView view = gridView2;
            if (string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText("AVBID")))
                return;

            decimal gdKulTop = getGrupTop(1);

            view.FocusedColumn = colDKUL;
            view.ShowEditor();
            view.ActiveEditor.EditValue = -gdKulTop;
            view.PostEditor();
        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;
            
            if (e.Column == colDKUL)
            {
                decimal dKln = view.GetRowCellValue(e.RowHandle, colDKLN) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colDKLN));
                decimal dKul = e.Value == DBNull.Value ? 0 : Convert.ToDecimal(e.Value);
                decimal aKur = Convert.ToDecimal(view.GetFocusedRowCellValue("AKUR"));
                
                decimal aKul = Math.Round(dKul * aKur, 2);

                view.SetFocusedRowCellValue("AKUL", aKul);
                //view.ValidateEditor();
                view.UpdateCurrentRow();
            }
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            
            if (view.FocusedColumn == colDKUL)
            {
                decimal dKul = e.Value == DBNull.Value ? 0 : Convert.ToDecimal(e.Value);
                decimal dKln = view.GetFocusedRowCellValue(colDKLN) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colDKLN));

                if (dKln < 0)   // eksi
                {
                    if (dKul < dKln || dKul > 0)
                        e.Value = dKln;
                }
                else
                {
                    if (dKul > dKln || dKul < 0)
                        e.Value = dKln;
                }

                decimal gdKulTop = getGrupTop(1);

                if (Math.Abs(Convert.ToDecimal(e.Value)) > Math.Abs(gdKulTop))
                    e.Value = -gdKulTop;
            }
        }


        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(gridView2.GetFocusedRowCellDisplayText("AVBID")))
                e.Cancel = true;
        }

        private void kurYuvarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = gridView2;
            
            if (view.GetFocusedRowCellDisplayText("DDVZ") == "TRL")     // TL'nin yuvarlamasi olmaz
                return;

            decimal gaKulTop = getGrupTop(2);
            if (gaKulTop == 0)
                return;

            decimal dKul = view.GetFocusedRowCellValue(colDKUL) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colDKUL));
            if (dKul == 0)
                return;

            decimal gdKulTop = getGrupTop(1);
            if (gdKulTop != 0)
                return;

            decimal aKul = view.GetFocusedRowCellValue(colAKUL) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colAKUL));

            gaKulTop -= aKul;

            if (dKul < 0)
                gaKulTop = -gaKulTop;

            decimal aKur = Math.Abs(gaKulTop / dKul);
            view.SetFocusedRowCellValue(colAKUR, aKur);
            view.SetFocusedRowCellValue(colAKUL, Math.Round(gaKulTop, 2));
            view.UpdateCurrentRow();
        }

        private void kapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal aKul = Convert.ToDecimal(colAKUL.SummaryItem.SummaryValue);
            if (aKul != 0)
            {
                MessageBox.Show("TL Brc ≠ Alc");
                return;
            }
            this.avbKapamaKapaSelTableAdapter.Update(this.accountDataSet.AVB_KAPAMA_KAPA_SEL);

            accountQueriesTableAdapter.AVB_KAPA(AvbID, Program.USR);

            Close();
        }

    }
}