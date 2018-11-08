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

namespace tMax14.WAN
{
    public partial class wmoXF : DevExpress.XtraEditors.XtraForm
    {
        string kim = "M";
        public wmoXF()
        {
            InitializeComponent();

            wmoGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colMNFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
        }


        private void wMOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void wmoXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wanDataSet.WMO' table. You can move, or remove it, as needed.
            this.wmoTableAdapter.Fill(this.wanDataSet1.WMO);
        }

        private void wmoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("WMO");  //Tender/Teklif
            view.SetFocusedRowCellValue(colWMOID, PK);
            view.SetFocusedRowCellValue(colSTU, "P");   // Pending
        }

        object[] rowCopy;
        
        private void satirKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sri = wmoGridView.GetDataSourceRowIndex(wmoGridView.FocusedRowHandle);
            rowCopy = this.wanDataSet1.WMO.Rows[sri].ItemArray;
        }

        private void satirYapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rowCopy == null)
                return;
            
            wanDataSet.WMORow newRow = wanDataSet1.WMO.NewWMORow();
            newRow.ItemArray = rowCopy;
            newRow.WMOID = (int)Program.MF.mainQueriesTableAdapter.GET_PK("WMO");

            wanDataSet1.WMO.AddWMORow(newRow);
        }

        private void kimRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            kim = kimRadioGroup.EditValue.ToString();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wmoBindingSource.EndEdit();

            foreach (wanDataSet.WMORow row in this.wanDataSet1.WMO.Rows)
                if (row.RowState != DataRowState.Unchanged)
                    row.KIM = kim;

            this.wmoTableAdapter.Update(this.wanDataSet1.WMO);
        }

        private void wmoGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colTOP)
            {
                string top = e.Value.ToString();
                
                if (top.StartsWith("GOH"))
                {
                    string gohLvl = top.Substring(3, 1);
                    wmoGridView.SetFocusedRowCellValue(colGOHLVL, Convert.ToInt32(gohLvl));
                    wmoGridView.SetFocusedRowCellValue(colDIMS, DBNull.Value);
                }
                else
                    wmoGridView.SetFocusedRowCellValue(colGOHLVL, DBNull.Value);
            }

            if (e.Column == colPCS || e.Column == colPPP)
            {
                string top = wmoGridView.GetFocusedRowCellValue(colTOP).ToString();
                if (top.StartsWith("GOH"))
                {
                    wmoGridView.SetFocusedRowCellValue(colNOP, DBNull.Value);
                    return;
                }
                int pcs = wmoGridView.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToInt32(wmoGridView.GetFocusedRowCellValue(colPCS));
                int ppp = wmoGridView.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToInt32(wmoGridView.GetFocusedRowCellValue(colPPP));
                if (ppp != 0)
                {
                    int nop = pcs / ppp;
                    wmoGridView.SetFocusedRowCellValue(colNOP, nop);
                }
                else
                    wmoGridView.SetFocusedRowCellValue(colNOP, DBNull.Value);
            }

            if (e.Column == colDIMS || e.Column == colNOP || e.Column == colTOP)
            {
                if (Convert.IsDBNull(wmoGridView.GetFocusedRowCellValue(colGOHLVL)))
                {
                    if (Convert.IsDBNull(wmoGridView.GetFocusedRowCellValue(colNOP)))
                    {
                        wmoGridView.SetFocusedRowCellValue(colCVM3, DBNull.Value);
                        return;
                    }

                    string dims = wmoGridView.GetFocusedRowCellDisplayText(colDIMS);
                    if (string.IsNullOrWhiteSpace(dims))
                    {
                        wmoGridView.SetFocusedRowCellValue(colCVM3, DBNull.Value);
                        return;
                    }

                    decimal nop = Convert.ToDecimal(wmoGridView.GetFocusedRowCellValue(colNOP));

                    int L, W, H;
                    decimal tV = 0;
                    string[] lines = dims.Split(new char[] { '+', ' ' });
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] lhv = line.Split(new char[] { '*', 'x' });
                            L = Convert.ToInt32(lhv[0]);
                            W = Convert.ToInt32(lhv[1]);
                            H = Convert.ToInt32(lhv[2]);
                            tV += L * W * H;
                        }
                    }

                    tV = tV * nop / 1000000m;
                    wmoGridView.SetFocusedRowCellValue(colCVM3, tV);
                }
                else
                {
                    decimal lvl = wmoGridView.GetFocusedRowCellValue(colGOHLVL) == DBNull.Value ? 0 : Convert.ToDecimal(wmoGridView.GetFocusedRowCellValue(colGOHLVL));
                    decimal pcs = wmoGridView.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToDecimal(wmoGridView.GetFocusedRowCellValue(colPCS));
                    decimal ppp = wmoGridView.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToDecimal(wmoGridView.GetFocusedRowCellValue(colPPP));
                    if (ppp != 0)
                    {
                        decimal tV = pcs / ppp * 6 / (lvl * 2);
                        wmoGridView.SetFocusedRowCellValue(colCVM3, tV);
                    }
                    else
                        wmoGridView.SetFocusedRowCellValue(colCVM3, DBNull.Value);

                }
            }
        }

        private void satirIptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!wmoGridView.IsDataRow(wmoGridView.FocusedRowHandle))   // YeniKayit Focus kaldigi surece DataRow degil, ESC ile cancel edilebilir
            {
                wmoGridView.CancelUpdateCurrentRow();
                return;
            }
            // wmoGridView.UpdateCurrentRow(); gerek yok!

            int sri = wmoGridView.GetDataSourceRowIndex(wmoGridView.FocusedRowHandle);
            if (wanDataSet1.WMO.Rows[sri].RowState == DataRowState.Added)   // YeniEklenmis ise SIL (DB de yok)
            {
                wmoGridView.DeleteRow(wmoGridView.FocusedRowHandle);
                return;
            }
            
            string orgStu = wanDataSet1.WMO.Rows[sri]["STU", DataRowVersion.Original].ToString();
            if (orgStu == "P" || orgStu == "S")
                wanDataSet1.WMO.Rows[sri]["STU"] = "C";

        }

        private void wmoGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (!wmoGridView.IsDataRow(wmoGridView.FocusedRowHandle))   // YeniKayit Focus kaldigi surece DataRow degil
                return;

            int sri = wmoGridView.GetDataSourceRowIndex(wmoGridView.FocusedRowHandle);
            if (wanDataSet1.WMO.Rows[sri].RowState == DataRowState.Added)   // Yeni Eklenmis ama Apply edilmemis
                return;

            string orgStu = wanDataSet1.WMO.Rows[sri]["STU", DataRowVersion.Original].ToString();
            if (orgStu == "C" || orgStu == "S")
                e.Cancel = true;

            if (wmoGridView.FocusedColumn == colDIMS && !string.IsNullOrEmpty(wmoGridView.GetFocusedRowCellDisplayText(colGOHLVL)))
                e.Cancel = true;
        }

        private void satirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmoGridView.AddNewRow();
        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            shippedToolStripMenuItem.Enabled = kim == "U";
            approveMnfUpdToolStripMenuItem.Enabled = kim == "U";
        }

        private void shippedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmoGridView.SetFocusedRowCellValue(colSTU, "S");
        }

        private void wmoGridView_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column == colSTU)
                e.RepositoryItem = STUrepositoryItemRadioGroup;
        }

        private void approveMnfUpdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmoGridView.SetFocusedRowCellValue(colUSRUPD, wmoGridView.GetFocusedRowCellValue(colMNFUPD));
        }
    }

}