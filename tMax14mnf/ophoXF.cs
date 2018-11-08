using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14mnf
{
    public partial class ophoXF : DevExpress.XtraEditors.XtraForm
    {
        string layoutName = "MNF.ophoXF";
        
        public ophoXF()
        {
            InitializeComponent();

            ophoGridControl.ExternalRepository = Program.MF.persistentRepository;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colTOS.ColumnEdit = Program.MF.TOSrepositoryItemLookUpEdit;
            colPAG.ColumnEdit = Program.MF.PAGrepositoryItemCheckedComboBoxEdit;
            colPOR.ColumnEdit = Program.MF.PORrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemImageComboBox;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemImageComboBox;
        }

        private void ophoXF_Load(object sender, EventArgs e)
        {
            Program.MF.XGLrestore(layoutName, 0, ophoGridView);
            
            string qry = string.Format("MnfID = {0}", Program.mnf);
            this.ophoTableAdapter.FillByQry(this.dataSet.OPHO, qry, Program.USR);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ophoBindingSource.EndEdit();

            foreach (DataSet.OPHORow row in this.dataSet.OPHO.Rows)
                if (row.RowState != DataRowState.Unchanged)
                {
                    row.KIM = "M";  // Mnf
                    if (!row.IsQCFDNull())
                        row["QCPD"] = DBNull.Value;
                }

            this.ophoTableAdapter.Update(this.dataSet.OPHO);
        }

        private void ophoGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)queriesTableAdapter.GET_PK("OPS");
            view.SetFocusedRowCellValue(colOPHOID, PK);
            view.SetFocusedRowCellValue(colMNFID, Program.mnf);
            view.SetFocusedRowCellValue(colSTU, "P");   // Pending
        }
        
        private void ophoGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.Column == colTOP)
            {
                string top = e.Value.ToString();

                if (top.StartsWith("GOH"))
                {
                    string gohLvl = top.Substring(3, 1);
                    view.SetFocusedRowCellValue(colGOHLVL, Convert.ToInt32(gohLvl));
                    view.SetFocusedRowCellValue(colDIMS, DBNull.Value);
                }
                else
                    view.SetFocusedRowCellValue(colGOHLVL, DBNull.Value);
            }

            if ((e.Column == colPCS || e.Column == colPPP) && !Convert.IsDBNull(view.GetFocusedRowCellValue(colGOHLVL)))
            {
                string top = view.GetFocusedRowCellValue(colTOP).ToString();
                if (top.StartsWith("GOH"))
                {
                    view.SetFocusedRowCellValue(colNOP, DBNull.Value);
                    return;
                }
                int pcs = view.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToInt32(view.GetFocusedRowCellValue(colPCS));
                int ppp = view.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToInt32(view.GetFocusedRowCellValue(colPPP));
                if (ppp != 0)
                {
                    int nop = pcs / ppp;
                    view.SetFocusedRowCellValue(colNOP, nop);
                }
                else
                    view.SetFocusedRowCellValue(colNOP, DBNull.Value);
            }

            if (e.Column == colDIMS || e.Column == colTOP)
            {
                if (Convert.IsDBNull(view.GetFocusedRowCellValue(colGOHLVL)))
                {
                    string dims = view.GetFocusedRowCellDisplayText(colDIMS);
                    if (string.IsNullOrWhiteSpace(dims))
                    {
                        view.SetFocusedRowCellValue(colCVM3, DBNull.Value);
                        return;
                    }

                    int L, W, H, N, tN = 0;
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
                            N = Convert.ToInt32(lhv[3].Trim(new char[] { '#', 'N' }));
                            tN += N;
                            tV += L * W * H;
                        }
                    }
                    view.SetFocusedRowCellValue(colNOP, tN);

                    //decimal nop = Convert.ToDecimal(view.GetFocusedRowCellValue(colNOP));
                    //tV = tV * nop / 1000000m;
                    tV = tV * tN / 1000000m;
                    view.SetFocusedRowCellValue(colCVM3, tV);
                }
                else
                {
                    decimal lvl = view.GetFocusedRowCellValue(colGOHLVL) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colGOHLVL));
                    decimal pcs = view.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPCS));
                    decimal ppp = view.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPPP));
                    if (ppp != 0)
                    {
                        decimal tV = pcs / ppp * 6 / (lvl * 2);
                        view.SetFocusedRowCellValue(colCVM3, tV);
                    }
                    else
                        view.SetFocusedRowCellValue(colCVM3, DBNull.Value);

                }
            }
        }

        private void ophoGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            //if (!view.IsDataRow(view.FocusedRowHandle))   // YeniKayit Focus kaldigi surece DataRow degil
            //    return;

            //if (orderDataSet.OPHO.Rows[sri].RowState == DataRowState.Added)   // Yeni Eklenmis ama Apply edilmemis
            //    return;

            if (view.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                int sri = view.GetDataSourceRowIndex(view.FocusedRowHandle);
                if (dataSet.OPHO.Rows[sri].HasVersion(DataRowVersion.Original))
                {
                    string orgStu = dataSet.OPHO.Rows[sri]["STU", DataRowVersion.Original].ToString();
                    if (orgStu == "C" || orgStu == "S")
                        e.Cancel = true;
                }
            }
            if (view.FocusedColumn == colDIMS && !string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colGOHLVL)))
                e.Cancel = true;
            if (view.FocusedColumn == colPPP && string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colGOHLVL)))
                e.Cancel = true;
        }

        private void STUrepositoryItemImageComboBox_Validating(object sender, CancelEventArgs e)
        {
            var icb = sender as ImageComboBoxEdit;
            if (icb.EditValue.ToString() == "S")
                icb.EditValue = icb.OldEditValue;
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow oR = ophoGridView.GetDataRow(ophoGridView.FocusedRowHandle);
            DataRow nR = dataSet.OPHO.NewRow();

            nR.ItemArray = oR.ItemArray;
            
            oR["OPHOID"] = queriesTableAdapter.GET_PK("OPS");
            nR["OPHID"] = DBNull.Value;
            nR["OPMID"] = DBNull.Value;
            nR["LOIDX"] = DBNull.Value;

            nR["STU"] = "P";
            nR["GSAAD"] = DBNull.Value;
            nR["ARD"] = DBNull.Value;
            nR["AAD"] = DBNull.Value;
            nR["MNFUPD"] = DBNull.Value;
            nR["USRUPD"] = DBNull.Value;
            nR["KIM"] = DBNull.Value;
            dataSet.OPHO.Rows.Add(nR);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xglFX frm = new xglFX();
            frm.id = layoutName;
            frm.origin = ophoGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

    }
}