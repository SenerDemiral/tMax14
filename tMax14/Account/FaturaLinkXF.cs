using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

using DevExpress.XtraReports;
using tMax14ReportClassLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace tMax14.Account
{
    public partial class FaturaLinkXF : DevExpress.XtraEditors.XtraForm
    {
        public int ID = 0;
        public string IDtyp = "";   // House/Master/Firma
        public string IDskl = "ALL";    // Acik ve Faturalasmamis TUMU
        int AFXid;

        public FaturaLinkXF()
        {
            InitializeComponent();

            afblGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDb.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colBDVZb.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTURb.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colTUR2b.ColumnEdit = Program.MF.afbTUR2repositoryItemImageComboBox;
            colTUR3b.ColumnEdit = Program.MF.afbTUR3repositoryItemImageComboBox;
            colDRMb.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            afdlGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;
            colDDVZd.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTURd.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colAHTIDd.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colEDITABLEd.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.DVTrepositoryItemLookUpEdit.Closed += DVTrepositoryItemLookUpEdit_Closed;
        }

        private void FaturaLinkXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.afblBindingSource.EndEdit();

            if (this.accountDataSet.HasChanges())
            {
                DialogResult dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "Fatura Link", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    afblTableAdapter.Update(this.accountDataSet.AFBL);
                    afdlTableAdapter.Update(this.accountDataSet.AFDL);

                    Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
                }
                else if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.accountDataSet.AFBL.RejectChanges();
                    this.accountDataSet.AFDL.RejectChanges();
                    e.Cancel = true;
                }
            }

        }

        void DVTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;

            if (a.OldEditValue != a.EditValue)
            {
                object trh, kur;

                if (afdlGridControl.IsFocused)
                {
                    if ((int)afdlGridView.GetFocusedRowCellValue(colAFBIDd) == 0)
                        trh = DateTime.Today;
                    else
                    {
                        AccountDataSet.AFDLRow dRow = afdlGridView.GetDataRow(afdlGridView.FocusedRowHandle) as AccountDataSet.AFDLRow;
                        AccountDataSet.AFBLRow pRow = dRow.GetParentRow("AFBL_AFDL") as AccountDataSet.AFBLRow;
                        //AccountDataSet.AFBLRow pRow = afdlGridView.GetDataRow(afblGridView.FocusedRowHandle).GetParentRow("AFBL_AFDL") as AccountDataSet.AFBLRow;
                        trh = pRow.IsFTRTRHNull() ? DateTime.Today : pRow.FTRTRH;
                    }
                    kur = accountQueriesTableAdapter.AFB_KUR(a.EditValue.ToString(), (DateTime)trh);
                    afdlGridView.SetFocusedRowCellValue(colDKURd, kur);
                }
                if (afblGridControl.IsFocused)
                {
                    if ((int)afblGridView.GetFocusedRowCellValue(colAFBIDd) == 0)
                        trh = DateTime.Today;
                    else
                        trh = afblGridView.GetFocusedRowCellValue(colFTRTRHb) == DBNull.Value ? DateTime.Today : afblGridView.GetFocusedRowCellValue(colFTRTRHb);

                    kur = accountQueriesTableAdapter.AFB_KUR(a.EditValue.ToString(), (DateTime)trh);
                    afblGridView.SetFocusedRowCellValue(colBKURb, kur);

                    AccountDataSet.AFDLRow[] cRows = afblGridView.GetDataRow(afblGridView.FocusedRowHandle).GetChildRows("AFBL_AFDL") as AccountDataSet.AFDLRow[];
                    for (int i = 0; i < cRows.Length; i++)
                        cRows[i].BKUR = (Single)kur;

                }
            }
        }


        private void FaturaLinkXF_Load(object sender, EventArgs e)
        {
            return; // Kullanilmiyor 07.02.18 de kapadim
            // Iki turlu : Form(AnaMenuden) veya Dialog(Ops'dan)
            Text = string.Format("Fatura Link  {0} {1}", ID, IDskl);
            Read();

        }

        private void Read()
        {
            AFXid = (int)accountQueriesTableAdapter.AFX_CREATE(ID, IDskl);
            this.afblTableAdapter.Fill(this.accountDataSet.AFBL, AFXid, Program.USR);
            this.afdlTableAdapter.Fill(this.accountDataSet.AFDL, AFXid, Program.USR);
            accountQueriesTableAdapter.AFX_CLEAR(AFXid);

            afblGridView.BestFitColumns();
            afdlGridView.BestFitColumns();
        }

        #region Drag&Drop

        GridHitInfo downHitInfo = null;
        
        private void afdlGridView_MouseDown(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            
            if (Control.ModifierKeys != Keys.None)
                return;

            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.RowHandle != GridControl.NewItemRowHandle)
            {
                var row = view.GetDataRow(hitInfo.RowHandle);
                string Drm = row.GetParentRow("AFBL_AFDL")["DRM"].ToString();

                string Eb = row.GetParentRow("AFBL_AFDL")["EDITABLE"].ToString();
                string Ed = row["EDITABLE"].ToString();
                int afdID = (int)row["AFDID"];  // Eksi ise Iptal edilmis
                //if (Eb == "T" && Ed == "T" && afdID > 0)
                //    downHitInfo = hitInfo;
                if (afdID > 0)  // Link de editable a bakma!
                    downHitInfo = hitInfo;

                //if (Drm == "A") // Aciksa
                //    downHitInfo = hitInfo;
            }
        }

        private void afdlGridView_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null)
            {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y)))
                {
                    view.UpdateCurrentRow();
                    string AFDid = view.GetRowCellDisplayText(downHitInfo.RowHandle, colAFDIDd);
                    DataRow row = view.GetDataRow(downHitInfo.RowHandle);

                    view.GridControl.DoDragDrop(row, DragDropEffects.All);

                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                    downHitInfo = null;
                }
            }
        }

        private void afblGridControl_DragOver(object sender, DragEventArgs e)
        {
            GridControl grid = (GridControl)sender;
            Point pt = new Point(e.X, e.Y);
            pt = grid.PointToClient(pt);
            GridView view = grid.GetViewAt(pt) as GridView;
            GridHitInfo trgHitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            
            if (view == afblGridView && trgHitInfo.InRow && e.Data.GetDataPresent(typeof(AccountDataSet.AFDLRow)))
            {
                e.Effect = DragDropEffects.Move;
                var srcRow = e.Data.GetData(typeof(AccountDataSet.AFDLRow)) as AccountDataSet.AFDLRow;

                int trgFRTid = view.GetRowCellValue(trgHitInfo.RowHandle, colFRTIDb) == DBNull.Value ? 0 : (int)view.GetRowCellValue(trgHitInfo.RowHandle, colFRTIDb);
                string trgTur = view.GetRowCellValue(trgHitInfo.RowHandle, colTURb).ToString();
                string trgDrm = view.GetRowCellValue(trgHitInfo.RowHandle, colDRMb).ToString();
                string trgE = view.GetRowCellValue(trgHitInfo.RowHandle, colEDITABLE).ToString();
                int srcFRTid = srcRow.IsFRTIDNull() ? 0 : srcRow.FRTID;
                
                ddStu.Text = string.Empty;
                if (trgFRTid == 0 || (trgDrm == "A" && trgFRTid == srcFRTid && trgTur == srcRow["TUR"].ToString() && trgE == "T"))
                    e.Effect = DragDropEffects.Move;
                else
                {
                    //Text = trgFRTid + "  " + srcRow["FRTID"].ToString();
                    e.Effect = DragDropEffects.None;
                    if (trgDrm != "A")
                        ddStu.Text = "Fatura açık değil";
                    else if (trgFRTid != srcFRTid)
                        ddStu.Text = "Müşteri farklı";
                    else if (trgTur != srcRow["TUR"].ToString())
                        ddStu.Text = "Tür farklı";
                    else
                        ddStu.Text = "Yetkisiz";
                }
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void afblGridControl_DragDrop(object sender, DragEventArgs e)
        {
            GridControl grid = (GridControl)sender;
            Point pt = new Point(e.X, e.Y);
            pt = grid.PointToClient(pt);
            GridView view = grid.GetViewAt(pt) as GridView;

            AccountDataSet.AFDLRow srcRow = e.Data.GetData(typeof(AccountDataSet.AFDLRow)) as AccountDataSet.AFDLRow;
            GridHitInfo trgHitInfo = view.CalcHitInfo(grid.PointToClient(new Point(e.X, e.Y)));
            int AFBid = (int)view.GetRowCellValue(trgHitInfo.RowHandle, colAFBIDb);


            object trh, kur;
            srcRow.AFBID = AFBid;
            if ((int)AFBid == 0)
            {
                srcRow.BKUR = -1;
                trh = DateTime.Today;
            }
            else
            {
                AccountDataSet.AFBLRow pRow = srcRow.GetParentRow("AFBL_AFDL") as AccountDataSet.AFBLRow;
                srcRow.BKUR = pRow.BKUR;   //srcRow.GetParentRow("AFBL_AFDL")["KUR"];

                trh = pRow.IsFTRTRHNull() ? DateTime.Today : pRow.FTRTRH;
            }
            kur = accountQueriesTableAdapter.AFB_KUR(srcRow.DDVZ, (DateTime)trh);
            view.SetRowCellValue(trgHitInfo.RowHandle, colDKURd, kur);

            view.RefreshData();
        }

        #endregion Drag&Drop

        private void afdlGridView_HiddenEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            view.UpdateSummary();            
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afblBindingSource.EndEdit();

            try
            {
                foreach (AccountDataSet.AFBLRow row in this.accountDataSet.AFBL.Rows)
                    if (row.RowState == DataRowState.Modified)
                        row.UPDUSR = Program.USR;
                    else if (row.RowState == DataRowState.Added)
                        row.INSUSR = Program.USR;

                foreach (AccountDataSet.AFDLRow row in this.accountDataSet.AFDL.Rows)
                    if (row.RowState == DataRowState.Modified)
                        row.UPDUSR = Program.USR;
                    else if (row.RowState == DataRowState.Added)
                        row.INSUSR = Program.USR;

                afblTableAdapter.Update(this.accountDataSet.AFBL);
                afdlTableAdapter.Update(this.accountDataSet.AFDL);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.accountDataSet.AFB.RejectChanges();
            }

            Read();
        }

        private void topTutRepositoryItemTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.TextEdit te = sender as DevExpress.XtraEditors.TextEdit;
            string aaa = te.Text;
            double topTut = 0;
            if (!string.IsNullOrWhiteSpace(te.Text))
                topTut = Convert.ToDouble(te.Text);
            double kdy = afdlGridView.GetFocusedRowCellValue(colKDYd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colKDYd));
            double mik = afdlGridView.GetFocusedRowCellValue(colMIKd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colMIKd));
            //double orgFyt = afdlGridView.GetFocusedRowCellValue(colORGFYTd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colORGFYTd));
            double orgKur = afdlGridView.GetFocusedRowCellValue(colDKURd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colDKURd));
            double ftrKur = afdlGridView.GetFocusedRowCellValue(colBKURd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colBKURd));
            double orgFyt = topTut / (orgKur / ftrKur * mik * (1.00 + kdy / 100.00));
            afdlGridView.SetFocusedRowCellValue(colDFYTd, orgFyt);
            //afdlGridView.PostEditor();
        }

        private void afblGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle < 0)
                return;
            if (e.RowHandle == view.FocusedRowHandle && (int)view.GetRowCellValue(e.RowHandle, colAFBIDb) == 0)
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.White;
                e.HighPriority = true;
            }
            
        }

        private void afblGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if ((int)view.GetFocusedRowCellValue(colAFBIDb) == 0)
                e.Cancel = true;
            else if (view.GetFocusedRowCellValue(colEDITABLE).ToString() != "T")
                e.Cancel = true;
        }

        private void afdlGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if ((int)view.GetFocusedRowCellValue(colAFDIDd) < 0)
                e.Cancel = true;
            if ((int)view.GetFocusedRowCellValue(colAFBIDd) != 0)
            {
                if (view.FocusedColumn == colFRTIDd ||
                    view.FocusedColumn == colTURd)
                    e.Cancel = true;
            }
            if (afblGridView.GetFocusedRowCellValue(colEDITABLE).ToString() != "T" ||
                view.GetFocusedRowCellValue(colEDITABLEd).ToString() != "T")
                e.Cancel = true;
        }

        private void yeniFaturaBasligiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountDataSet.AFBLRow afblRow = accountDataSet.AFBL.NewAFBLRow();

            afblRow.AFBID = (int)accountQueriesTableAdapter.GET_PK("ACC");
            afblRow.FRTID = (int)afdlGridView.GetFocusedRowCellValue(colFRTIDd);
            afblRow.TUR = (string)afdlGridView.GetFocusedRowCellValue(colTURd);
            afblRow.TUR3 = "O"; // Ops  Tur2: Firmasindan alinacak, aslinda onemi yok, icindeki kdv belirliyor hesabi
            afblRow.DRM = "A";  //Acik
            afblRow.FTRTRH = DateTime.Today;
            afblRow.BDVZ = (string)afdlGridView.GetFocusedRowCellValue(colDDVZd);
            afblRow.BKUR = (float)afdlGridView.GetFocusedRowCellValue(colDKURd);
            

            accountDataSet.AFBL.AddAFBLRow(afblRow);

            afdlGridView.SetFocusedRowCellValue(colAFBIDd, afblRow.AFBID);
            afdlGridView.UpdateCurrentRow();
        }

        private void afblGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colOPIDb)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colOPHMb));
        }
        
        private void afdlGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colOPIDd)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colOPHMd));
        }

        private void buFaturadanCikartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (afblGridView.GetFocusedRowCellValue(colEDITABLE).ToString() != "T")
                return;

            GridView view = afdlGridView;
            view.SetFocusedRowCellValue(colAFBIDd, 0);
            view.UpdateCurrentRow();

        }

        private void duplicateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!afdlGridView.IsDataRow(afdlGridView.FocusedRowHandle))
                return;

            if (afblGridView.GetFocusedRowCellValue(colEDITABLE).ToString() != "T")
                return;
            
            /*
            // Baslik Aciksa (0 herzaman acik)
            if (afblGridView.GetFocusedRowCellValue(colDRMb).ToString() != "A")    
                return;

            // Basligin Yetkisine bak
            //if (!isIslYetkili())
            //    return;

            // Ops'un AccYetkisine bak
            if (!isAccYetkili())
                return;
            */
            AccountDataSet.AFDLRow sRow = (AccountDataSet.AFDLRow)afdlGridView.GetDataRow(afdlGridView.FocusedRowHandle);
            AccountDataSet.AFDLRow dRow = accountDataSet.AFDL.NewAFDLRow();

            /*
            dRow.AFBID = sRow.AFBID;
            dRow.AFDID = (int)accountQueriesTableAdapter.GET_PK("ACC"); ;
            dRow.TUR = sRow.TUR;
            dRow.FRTID = sRow.FRTID;
            dRow.OPHM = sRow.OPHM;
            dRow.OPID = sRow.OPID;
            dRow.MIK = 1m;
            dRow.DDVZ = sRow.DDVZ;
            dRow.DKUR = sRow.DKUR;
            */
            //for (int i = 0; i < dRow.ItemArray.Length; i++)
            //    dRow.ItemArray[i] = sRow.ItemArray[i];
            dRow.ItemArray = sRow.ItemArray;
            dRow.AFDID = (int)accountQueriesTableAdapter.GET_PK("ACC"); ;

            afdlGridView.BeginDataUpdate();
            accountDataSet.AFDL.AddAFDLRow(dRow);
            afdlGridView.EndDataUpdate();

        }

        private void contextMenuStripDetay_Opening(object sender, CancelEventArgs e)
        {
            bool tf = false;
            if (!afdlGridView.IsEmpty && afblGridView.GetFocusedRowCellValue(colDRMb).ToString() == "A")      // Aciksa True
                tf = true;

            yeniFaturaBasligiToolStripMenuItem.Enabled = tf;
            buFaturadanCikartToolStripMenuItem.Enabled = tf;
            duplicateRecordToolStripMenuItem.Enabled = tf;
        }

        private void contextMenuStripBaslik_Opening(object sender, CancelEventArgs e)
        {
            if ((int)afblGridView.GetFocusedRowCellValue(colAFBIDb) == 0)
                printToolStripMenuItem.Enabled = false;
            else
                printToolStripMenuItem.Enabled = true;
        }

        private void ticariFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afblGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int AFBid = (int)view.GetFocusedRowCellValue(colAFBIDb);
            FaturaXR rpr = new FaturaXR(AFBid, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }

        }

        private void faturaYurtdisiDraftKDVDahilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afblGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int AFBid = (int)view.GetFocusedRowCellValue(colAFBIDb);
            Fatura2XR rpr = new Fatura2XR(AFBid, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }
        }

        private void faturaResmiMarkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afblGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int AFBid = (int)view.GetFocusedRowCellValue(colAFBIDb);
            Fatura3XR rpr = new Fatura3XR(AFBid, antetToolStripComboBox.Text, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.PrintingSystem.SetCommandVisibility(PrintingSystemCommand.Watermark, CommandVisibility.None);
                printTool.ShowPreviewDialog();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            var view = afblGridView;
            
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellValue(colDRMb).ToString() != "A")
                return;

            string tur = view.GetFocusedRowCellValue(colTURb).ToString();
            if (tur == "BS" || tur == "BA")
                if (!Program.MF.EntryCheck("Account.FaturaKapaXF.Satis.Ops", false))
                    return;
            if (tur == "AS" || tur == "AA")
                if (!Program.MF.EntryCheck("Account.FaturaKapaXF.Alis.Ops", false))
                    return;

            int AFBid = (int)view.GetFocusedRowCellValue(colAFBIDb);
            kaydetToolStripMenuItem.PerformClick();
            FaturaKapaXF frm = new FaturaKapaXF(AFBid, tur);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Read();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afblGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;
            
            //if (afblGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !afblGridView.IsDataRow(afblGridView.FocusedRowHandle))
            //    return;

            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = afblGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "AFB";
            frm.TblPK = (int)afblGridView.GetFocusedRowCellValue(colAFBIDb);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void opsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goOps(afblGridView);
        }

        private void opsDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goOps(afdlGridView);
        }

        private void goOps(GridView view)
        {
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellDisplayText("OPHM") == "M")
            {
                Ops.opMasterXUC frm = new Ops.opMasterXUC();
                frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue("OPID"));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText("OPID");

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }

            else if (view.GetFocusedRowCellDisplayText("OPHM") == "H")
            {
                Ops.opHouseXUC frm = new Ops.opHouseXUC();
                frm.qsString = string.Format("OPHid = {0}", view.GetFocusedRowCellValue("OPID"));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText("OPID");

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afblGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Firma.frtXUC frm = new Firma.frtXUC();
            frm.qsString = string.Format("FRTid = {0}", view.GetFocusedRowCellValue(colFRTIDb));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Firma";
            panel.Text = "Firma:" + view.GetFocusedRowCellDisplayText(colFRTIDb);

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }



    }
}