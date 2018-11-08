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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;

namespace tMax14.Order
{
    public partial class ophoXF : DevExpress.XtraEditors.XtraForm
    {
        public string iQry = "OPHOID > 0";
        public string hLinkQry = "";
        public int hID = 0; //104586;
        string kim = "U";
        public string usgTyp = "Genel";   // UsageType : Genel, HouseOrders, Link2House, MasterOrders
        string layoutName = "Order.ophoXF.";

        public ophoXF()
        {
            InitializeComponent();

            ophoGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colMNFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colTOS.ColumnEdit = Program.MF.TOSrepositoryItemLookUpEdit;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colPAG.ColumnEdit = Program.MF.PAGrepositoryItemCheckedComboBoxEdit;
            colPOR.ColumnEdit = Program.MF.PORrepositoryItemLookUpEdit;

        }

        private void ophoXF_Load(object sender, EventArgs e)
        {
            layoutName += usgTyp;
            Program.MF.XGLrestore(layoutName, 0, ophoGridView);
            
            Qry.qsOphoXUC frm = new Qry.qsOphoXUC();
            frm.OPHO = this.orderDataSet.OPHO;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            if (usgTyp == "Link2House")
                ophoGridControl.ContextMenuStrip = contextMenuStrip2;
            
            if (!string.IsNullOrEmpty(iQry))
            {
                Text += "  -> " + iQry;
                this.ophoTableAdapter.FillByQry(this.orderDataSet.OPHO, iQry, Program.USR);
            }

            //ophoGridView.OptionsSelection.MultiSelect = hID != 0;
        }

        private void ophoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            view.SetFocusedRowCellValue(colOPHOID, PK);
            view.SetFocusedRowCellValue(colSTU, "P");   // Pending
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ophoBindingSource.EndEdit();

            foreach (OrderDataSet.OPHORow row in this.orderDataSet.OPHO.Rows)
                if (row.RowState != DataRowState.Unchanged)
                {
                    row.KIM = kim;
                    if (!row.IsQCFDNull())
                        row["QCPD"] = DBNull.Value;
                }

            this.ophoTableAdapter.Update(this.orderDataSet.OPHO);
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
                    tV = Math.Round(tV * tN / 1000000m, 2);
                    view.SetFocusedRowCellValue(colCVM3, tV);
                }
                else
                {
                    decimal lvl = view.GetFocusedRowCellValue(colGOHLVL) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colGOHLVL));
                    decimal pcs = view.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPCS));
                    decimal ppp = view.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPPP));
                    if (ppp != 0)
                    {
                        decimal tV = Math.Round(pcs / ppp * 6 / (lvl * 2), 2);
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
                if (orderDataSet.OPHO.Rows[sri].HasVersion(DataRowVersion.Original))
                {
                    string orgStu = orderDataSet.OPHO.Rows[sri]["STU", DataRowVersion.Original].ToString();
                    if (kim == "M" && orgStu != "P")
                        e.Cancel = true;
                }
            }
            if (view.FocusedColumn == colDIMS && !string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colGOHLVL)))
                e.Cancel = true;
            if (view.FocusedColumn == colPPP && string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colGOHLVL)))
                e.Cancel = true;
        }

        private void goldSealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["GSAAD"] = DateTime.Today;
            }
            view.EndDataUpdate();
        }

        private void approvalRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["ARD"] = DateTime.Today;
            }
            view.EndDataUpdate();
        }

        private void approvalAdmittedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["AAD"] = DateTime.Today;
            }
            view.EndDataUpdate();
        }

        private void qCPassedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                if (row["QCFD"] == DBNull.Value && row["QCPD"] == DBNull.Value)
                    row["QCPD"] = DateTime.Today;
            }
            view.EndDataUpdate();
        }

        private void linkSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hID == 0)
                return;

            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["OPHID"] = hID;
            }
            view.EndDataUpdate();

            this.Validate();
            this.ophoBindingSource.EndEdit();

            foreach (OrderDataSet.OPHORow row in this.orderDataSet.OPHO.Rows)
                if (row.RowState != DataRowState.Unchanged)
                    row.KIM = kim;

            this.ophoTableAdapter.Update(this.orderDataSet.OPHO);

            this.DialogResult = DialogResult.OK;
        }

        private void dropHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hID == 0)
                return;

            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["OPHID"] = DBNull.Value;
            }
            view.EndDataUpdate();
        }

        private void manufacturerUpdateApprovedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            view.BeginDataUpdate();

            int[] selRows = view.GetSelectedRows();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                row["USRUPD"] = row["MNFUPD"];
            }
            view.EndDataUpdate();

            //ophoGridView.SetFocusedRowCellValue(colUSRUPD, ophoGridView.GetFocusedRowCellValue(colMNFUPD));
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow oR = ophoGridView.GetDataRow(ophoGridView.FocusedRowHandle);
            DataRow nR = orderDataSet.OPHO.NewRow();
            nR.ItemArray = oR.ItemArray;
            oR["OPHOID"] = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
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
            orderDataSet.OPHO.Rows.Add(nR);
            
            /*
            int sri = ophoGridView.GetDataSourceRowIndex(ophoGridView.FocusedRowHandle);
            object[] rowCopy = this.orderDataSet.OPHO.Rows[sri].ItemArray;

            orderDataSet.OPHO.Rows.Add(rowCopy);

            OrderDataSet.OPHORow newRow = orderDataSet.OPHO.NewOPHORow();
            newRow.ItemArray = rowCopy;
            newRow.OPHOID = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");

            orderDataSet.OPHO.AddOPHORow(newRow);*/
        }

        private void ophoGridView_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column == colSTU)
                e.RepositoryItem = STUrepositoryItemRadioGroup;
        }

        private void kimRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            kim = kimRadioGroup.EditValue.ToString();
            STUrepositoryItemRadioGroup.Items[1].Enabled = kim == "U";
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            dropHouseToolStripMenuItem.Enabled = hID != 0;
            selectOrdersToLinkToolStripMenuItem.Enabled = hID != 0;
            createHousePackagesToolStripMenuItem.Enabled = hID != 0;
        }

        private void ophoGridView_EditFormShowing(object sender, EditFormShowingEventArgs e)
        {
            colLOIDX.OptionsColumn.ReadOnly = true;
            STUrepositoryItemRadioGroup.Items[1].Enabled = kim == "U";
        }

        private void selectOrdersToLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hID == 0)
                return;

            Order.ophoXF frm = new Order.ophoXF();
            frm.usgTyp = "Link2House";
            frm.hID = hID;
            frm.iQry = hLinkQry;
            frm.Text = string.Format("Append Orders to House #{0}", hID);
            frm.ShowDialog();

            if (!string.IsNullOrEmpty(iQry))
                this.ophoTableAdapter.FillByQry(this.orderDataSet.OPHO, iQry, Program.USR);
        }

        private void ophoGridView_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {

        }

        private void housePackageCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void createHousePackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hID == 0)
                return;

            orderQueriesTableAdapter.OPHO_2OPP(hID);
            XtraMessageBox.Show("House Packages Created", "Create House Packages");
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = ophoGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = ophoGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Orders", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", "" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ophoGridView.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "OPHO";
            frm.RefID = (int)ophoGridView.GetFocusedRowCellValue(colOPHOID);
            frm.RefInfo = ophoGridView.GetFocusedRowCellDisplayText(colOPHOID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void calculateVM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = ophoGridView;

            //view.BeginDataUpdate();
            calculateVM3();
            //view.EndDataUpdate();
        }

        private void calculateVM3()
        {
            GridView view = ophoGridView;

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

                tV = Math.Round(tV * tN / 1000000m, 2);
                view.SetFocusedRowCellValue(colCVM3, tV);
            }
            else
            {
                decimal lvl = view.GetFocusedRowCellValue(colGOHLVL) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colGOHLVL));
                decimal pcs = view.GetFocusedRowCellValue(colPCS) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPCS));
                decimal ppp = view.GetFocusedRowCellValue(colPPP) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colPPP));
                if (ppp != 0)
                {
                    decimal tV = Math.Round(pcs / ppp * 6 / (lvl * 2), 2);
                    view.SetFocusedRowCellValue(colCVM3, tV);
                }
                else
                    view.SetFocusedRowCellValue(colCVM3, DBNull.Value);
            }
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculateVM3();
        }

        private void cntNosRepositoryItemCheckedComboBoxEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            cntNosRepositoryItemCheckedComboBoxEdit.Items.Clear();
            if (ophoGridView.GetFocusedRowCellValue(colMCNTNOS) != DBNull.Value)
            {
                string[] sa = ophoGridView.GetFocusedRowCellDisplayText(colMCNTNOS).Split(new char[] { ',' });
                foreach (string s in sa)
                    cntNosRepositoryItemCheckedComboBoxEdit.Items.Add(s);
            }
        }

    }
}