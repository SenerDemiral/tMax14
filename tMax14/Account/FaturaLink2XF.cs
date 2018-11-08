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
using tMax14ReportClassLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Collections;

namespace tMax14.Account
{
    public partial class FaturaLink2XF : DevExpress.XtraEditors.XtraForm
    {
        public int ID = 0;
        public string IDskl = "ALL";    // Acik ve Faturalasmamis TUMU
        int AFXid;
        string layoutName = "Account.FaturaLink2XF";
        
        public FaturaLink2XF()
        {
            if (!Program.MF.EntryCheck("Account.FaturaLink2XF", false))
            {
                Shown += (s, e) => Close();
                return;
            }

            InitializeComponent();

            afblBindingSource.Filter = "AFBID <> 0";    // Faturalar
            afdlBindingSource.Filter = "AFBID = 0";     // Charges

            afbGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDb.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNFRTIDb.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNDVZb.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBDVZb.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTURb.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colTUR2b.ColumnEdit = Program.MF.afbTUR2repositoryItemImageComboBox;
            colTUR3b.ColumnEdit = Program.MF.afbTUR3repositoryItemImageComboBox;
            colDRMb.ColumnEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            colEDITABLEb.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colFRTIDd.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;
            colDDVZd.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTURd.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colAHTIDd.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colEDITABLEd.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colEFTRb.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            chargeGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDc.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;
            colOPACCIDc.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;

            colDKNFRTIDc.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;
            colDDVZc.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTURc.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colAHTIDc.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colEDITABLEc.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            compBAb.ColumnEdit = Program.MF.BArepositoryItemImageComboBox;
            compBAc.ColumnEdit = Program.MF.BArepositoryItemImageComboBox;
            //this.accountDataSet.AFDL.RowChanging += AFDL_RowChanging;

            //chargeGridView.ActiveFilterString = "[AFDID] > 0";

            Program.MF.XGLrestore(layoutName, 0, afbGridView);
        }

        void AFDL_RowChanging(object sender, DataRowChangeEventArgs e)
        {
            if (!loading)
            {
                var aa = e.Action;
                var bb = e.Row.RowState;
                var cc = e.Row["AFBID"];
                //e.Row.HasVersion(DataRowVersion.
                int afbID = (int)e.Row["AFBID", DataRowVersion.Original];
                AccountDataSet.AFBLRow afbRow =  this.accountDataSet.AFBL.FindByAFBID(afbID);
                if (afbRow.RowState == DataRowState.Unchanged)
                    afbRow.SetModified();
            }
        }

        private void aFBLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afblBindingSource.EndEdit();
            this.afblTableAdapter.Update(this.accountDataSet.AFBL);
        }

        bool loading = false;
        private void Read()
        {
            int nor = 0;
            Program.MF.startSW();

            loading = true;
            AFXid = (int)accountQueriesTableAdapter.AFX_CREATE(ID, IDskl);
            nor = this.afblTableAdapter.Fill(this.accountDataSet.AFBL, AFXid, Program.USR);
            nor += this.afdlTableAdapter.Fill(this.accountDataSet.AFDL, AFXid, Program.USR);
            accountQueriesTableAdapter.AFX_CLEAR(AFXid);
            loading = false;

            Program.MF.stopSW("Fatura Link2", nor);
        }

        private void FaturaLink2XF_Load(object sender, EventArgs e)
        {
            Read();
        }

        private void afbGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //var view = sender as GridView;
            if (!e.HitInfo.InColumn && !e.HitInfo.InGroupPanel)
                afbContextMenuStrip.Show(this, e.Point);
        }

        private void afdlGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //var view = sender as GridView;
            if (!e.HitInfo.InColumn && !e.HitInfo.InGroupPanel)
                afdContextMenuStrip.Show(this, e.Point);
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = afbGridView.GetFocusedRowCellDisplayText(colAFBIDb);

            GridView view = chargeGridView;

            //view.BeginDataUpdate();
            //view.BeginSelection();

            int[] selRows = view.GetSelectedRows();
            List<Int32> afdIDs = new List<int>();
            foreach (int idx in selRows)
            {
                DataRow row = view.GetDataRow(idx);
                afdIDs.Add((int)row["AFDID"]);

                row["AFBID"] = 1450;
            }
            view.ClearSelection();

            int rh;
            foreach (int afdID in afdIDs)
            {
                rh = view.LocateByValue("AFDID", afdID);
                if (rh != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    view.SelectRow(rh);
            }
            //view.EndDataUpdate();
            //view.EndSelection();
            //view.ClearSelection();
        }

        private void seciliFaturayaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = chargeGridView;

            if (afbGridView.GetFocusedRowCellValue("ONYYTK") != DBNull.Value)
            {
                XtraMessageBox.Show("Eklemek için OnyYtk yi kaldırın", "Faturaya Ekle");
                return;
            }

            object afbID = afbGridView.GetFocusedRowCellValue("AFBID");    // Fatura
            object afbFRTID = afbGridView.GetFocusedRowCellValue("FRTID");
            object afbTUR = afbGridView.GetFocusedRowCellValue("TUR");
            object afbDKNFRTID = afbGridView.GetFocusedRowCellValue("DKNFRTID");

            List<Int32> afdIDs = new List<int>();
            int[] selRH = view.GetSelectedRows();
            foreach (int idx in selRH)
            {
                if (view.IsDataRow(idx))
                {
                    DataRow row = view.GetDataRow(idx);
                    int afdID = (int)row["AFDID"];
                    object frtID = row["FRTID"];
                    object tur = row["TUR"];
                    object dknFrtID = row["DKNFRTID"];
                    if (afdID > 0 && frtID.Equals(afbFRTID) && tur.Equals(afbTUR) && dknFrtID.Equals(afbDKNFRTID)) // Iptal olmayan, Firma ve Tur eklenecegi Faturaya uymali
                    {
                        //view.UnselectRow(idx);
                        //row["AFBID"] = afbID;
                        afdIDs.Add(afdID);
                    }
                }
            }
            int rh;
            //view.BeginDataUpdate();
            foreach (int afdID in afdIDs)
            {
                rh = view.LocateByValue("AFDID", afdID);
                view.SetRowCellValue(rh, "AFBID", afbID);

                //view.FocusedRowHandle = rh;
                //view.UpdateCurrentRow();
            }
            view.UpdateCurrentRow();
            //view.EndDataUpdate();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afblBindingSource.EndEdit();
            Kaydet();
        }

        private void Kaydet()
        {
            AccountDataSet.AFBLDataTable afbTable = (AccountDataSet.AFBLDataTable)this.accountDataSet.AFBL.GetChanges();
            AccountDataSet.AFDLDataTable afdTable = (AccountDataSet.AFDLDataTable)this.accountDataSet.AFDL.GetChanges();
            try
            {
                if (afbTable != null)
                {
                    foreach (AccountDataSet.AFBLRow row in afbTable.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                            row["INSUSR"] = Program.USR;
                        else if (row.RowState == DataRowState.Modified)
                            row["UPDUSR"] = Program.USR;
                    }
                    afblTableAdapter.Update(afbTable);
                }
                if (afdTable != null)
                {
                    foreach (DataRow row in afdTable.Rows)
                    {
                        if (row.RowState == DataRowState.Added)
                            row["INSUSR"] = Program.USR;
                        else if (row.RowState == DataRowState.Modified)
                            row["UPDUSR"] = Program.USR;
                    }
                    afdlTableAdapter.Update((AccountDataSet.AFDLDataTable)afdTable);
                }

                // Refresh
                var afbID = afbGridView.GetFocusedRowCellValue("AFBID");
                Read();
                int rh = afbGridView.LocateByValue("AFBID", afbID);
                if (rh != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    afbGridView.FocusedRowHandle = rh;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.accountDataSet.AFB.RejectChanges();
            }
        }

        private void FaturaLink2XF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.afblBindingSource.EndEdit();

            if (this.accountDataSet.HasChanges())
            {
                DialogResult dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "Fatura Link", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Kaydet();
                    //Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
                }
                else if (dr == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.accountDataSet.AFBL.RejectChanges();
                    this.accountDataSet.AFDL.RejectChanges();
                    e.Cancel = true;
                }
            }
        }

        private void yeniFaturaYaratVeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)chargeGridView.GetFocusedRowCellValue("AFDID") < 0)
                return;
            
            AccountDataSet.AFBLRow afblRow = accountDataSet.AFBL.NewAFBLRow();

            afblRow.EDITABLE = "T";
            afblRow.AFBID = (int)accountQueriesTableAdapter.GET_PK("ACC");
            afblRow.FRTID = (int)chargeGridView.GetFocusedRowCellValue("FRTID");
            afblRow.TUR = (string)chargeGridView.GetFocusedRowCellValue("TUR");
            afblRow.TUR3 = "O"; // Ops  Tur2: Firmasindan alinacak, aslinda onemi yok, icindeki kdv belirliyor hesabi
            afblRow.DRM = "A";  //Acik
            afblRow.FTRTRH = DateTime.Today;
            afblRow.BDVZ = (string)chargeGridView.GetFocusedRowCellValue("DDVZ");
            afblRow.BKUR = 0; // (float)chargeGridView.GetFocusedRowCellValue("DKUR");

            if (chargeGridView.GetFocusedRowCellValue("DKNFRTID") != DBNull.Value)
            {
                afblRow["DKNFRTID"] = chargeGridView.GetFocusedRowCellValue("DKNFRTID");
                afblRow["DKNDVZ"] = "TRL";
            }
            accountDataSet.AFBL.AddAFBLRow(afblRow);

            chargeGridView.SetFocusedRowCellValue("AFBID", afblRow.AFBID);
            chargeGridView.UpdateCurrentRow();
        }

        private void faturaKapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            var view = afbGridView;

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

            if (this.accountDataSet.HasChanges())
            {
                XtraMessageBox.Show("Değişklik var önce kaydedin", "Fatura kapat");
                return;
            }

            int afbID = (int)view.GetFocusedRowCellValue(colAFBIDb);
            
            FaturaKapaXF frm = new FaturaKapaXF(afbID, tur);

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XtraMessageBox.Show("Fatura kapatıldı", "Fatura Kapat");
                //Refresh
                afblTableAdapter.ClearBeforeFill = false;
                afdlTableAdapter.ClearBeforeFill = false;
                afblTableAdapter.FillByAFBID(accountDataSet.AFBL, afbID, Program.USR);
                afdlTableAdapter.FillByAFBID(accountDataSet.AFDL, afbID, Program.USR);
                afblTableAdapter.ClearBeforeFill = true;
                afdlTableAdapter.ClearBeforeFill = true;
                /*
                //Kapandi, Remove AFDL, AFBL kayitlari
                DataRow[] dRows = this.accountDataSet.AFDL.Select(string.Format("AFBID = {0}", afbID));
                foreach (var dRow in dRows)
                    this.accountDataSet.AFDL.RemoveAFDLRow((AccountDataSet.AFDLRow)dRow);

                DataRow[] bRows = this.accountDataSet.AFBL.Select(string.Format("AFBID = {0}", afbID));
                this.accountDataSet.AFBL.RemoveAFBLRow((AccountDataSet.AFBLRow)bRows[0]);
                */
            }
        }

        private void deneme2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;
            int afbID = (int)view.GetFocusedRowCellValue(colAFBIDb);
        }
        
        private void faturaOnaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            //if (afblGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !afblGridView.IsDataRow(afblGridView.FocusedRowHandle))
            //    return;

            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = afbGridView.GetFocusedRowCellDisplayText("ONYYTK");
            frm.Tbl = "AFB";
            frm.TblPK = (int)afbGridView.GetFocusedRowCellValue("AFBID");
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ticariFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kayit edilmis olmali
            var view = afbGridView;

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
            var view = afbGridView;

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
            var view = afbGridView;

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

        private void afbGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.GetFocusedRowCellValue("EDITABLE").ToString() != "T")
                e.Cancel = true;

            if ((view.FocusedColumn.FieldName == "DKNFRTID" || view.FocusedColumn.FieldName == "DKNDVZ") && view.GetFocusedRowCellValue("TUR").ToString().Substring(1, 1) != "D")
                e.Cancel = true;

        }

        private void chargeGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn.FieldName == "DKNFRTID" && view.GetFocusedRowCellValue("TUR").ToString().Substring(1, 1) != "D")
                e.Cancel = true;

            if (view.IsDataRow(view.FocusedRowHandle))  // NewItem da degil
            {
                if ((int)view.GetFocusedRowCellValue("AFDID") < 0)
                {
                    e.Cancel = true;
                    return;
                }
                if (view.GetFocusedRowCellValue("EDITABLE").ToString() != "T")
                {
                    e.Cancel = true;
                    return;
                }

                //if (view.GetFocusedRowCellValue("INSTYP") != DBNull.Value && view.GetFocusedRowCellValue("INSTYP").ToString() != "T")  // Otomatik uretilmis ise bos alanlar doldurulabilir, Client girmis ise null
                if (view.GetFocusedRowCellValue("INSTYP") != DBNull.Value)  // Otomatik uretilmis ise bos alanlar doldurulabilir, Client girmis ise null
                    {
                    // Bu alanlar Otomatikde de degisemez
                    if (view.FocusedColumn.FieldName == "FRTID" ||
                        view.FocusedColumn.FieldName == "AHTID" ||
                        view.FocusedColumn.FieldName == "TUR")
                    {
                        e.Cancel = true;
                        return;
                    }

                    var row = view.GetDataRow(view.FocusedRowHandle);

                    object oMik = DBNull.Value,
                           oDvz = DBNull.Value,
                           oFyt = DBNull.Value,
                           oKdy = DBNull.Value;

                    if (row.HasVersion(DataRowVersion.Original))
                    {
                        oMik = row["MIK", DataRowVersion.Original];
                        oDvz = row["DDVZ", DataRowVersion.Original];
                        oFyt = row["DFYT", DataRowVersion.Original];
                        oKdy = row["KDY", DataRowVersion.Original];
                    }

                    if (view.FocusedColumn.FieldName == "MIK" && oMik != DBNull.Value)
                        e.Cancel = true;
                    if (view.FocusedColumn.FieldName == "DDVZ" && oDvz != DBNull.Value)
                        e.Cancel = true;
                    if (view.FocusedColumn.FieldName == "DFYT" && oFyt != DBNull.Value)
                        e.Cancel = true;
                    if (view.FocusedColumn.FieldName == "KDY" && oKdy != DBNull.Value)
                        e.Cancel = true;
                }
            }
            //int afbID = (int)e.Row["AFBID", DataRowVersion.Original];
            //AccountDataSet.AFBLRow afbRow = this.accountDataSet.AFBL.FindByAFBID(afbID);
            //if (afbRow.RowState == DataRowState.Unchanged)
            //    afbRow.SetModified();

        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!chargeGridView.IsDataRow(chargeGridView.FocusedRowHandle))
                return;

            AccountDataSet.AFDLRow sRow = (AccountDataSet.AFDLRow)chargeGridView.GetDataRow(chargeGridView.FocusedRowHandle);
            AccountDataSet.AFDLRow dRow = accountDataSet.AFDL.NewAFDLRow();

            dRow.ItemArray = sRow.ItemArray;
            dRow.AFDID = (int)accountQueriesTableAdapter.GET_PK("ACC"); ;
            dRow["INSTYP"] = DBNull.Value;
            dRow["EDITABLE"] = "T";

            //chargeGridView.BeginDataUpdate();
            accountDataSet.AFDL.AddAFDLRow(dRow);
            //chargeGridView.EndDataUpdate();
        }

        private void afbContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            bool hasChanges = this.accountDataSet.HasChanges();

            kaydetToolStripMenuItem.Enabled = hasChanges;
            faturaKapaToolStripMenuItem.Enabled = !hasChanges;
            faturaOnaylaToolStripMenuItem.Enabled = !hasChanges;
            printToolStripMenuItem.Enabled = !hasChanges;
        }

        private void afdlGridView_GotFocus(object sender, EventArgs e)
        {
            var view = sender as GridView;
            afbGridView.FocusedRowHandle = view.SourceRowHandle;
        }

        private void afdContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            GridView view = (GridView)afbGridControl.FocusedView;
            buFaturadanCikartToolStripMenuItem.Enabled = afbGridView.GetRowCellValue(view.SourceRowHandle, "EDITABLE").ToString() == "T" &&
                                                         view.GetFocusedRowCellValue("EDITABLE").ToString() == "T";
        }

        private void buFaturadanCikartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = (GridView)afbGridControl.FocusedView;

            if (afbGridView.GetFocusedRowCellValue("ONYYTK") != DBNull.Value)
            {
                XtraMessageBox.Show("Çıkartmak için OnyYtk yi kaldırın", "Faturadan Çıkart");
                return;
            }

            // if Parent Editable
            if (afbGridView.GetRowCellValue(view.SourceRowHandle, "EDITABLE").ToString() == "T")
            {
                view.SetFocusedRowCellValue("AFBID", 0);
                view.UpdateCurrentRow();
            }
        }

        private void chargeContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = !chargeGridView.IsDataRow(chargeGridView.FocusedRowHandle);
        }

        private void afbGridView_DoubleClick(object sender, EventArgs e)
        {
            afbGridView.ActiveFilterString = string.Format("[FRTID] = {0}", afbGridView.GetFocusedRowCellValue("FRTID"));
            chargeGridView.ActiveFilterString = string.Format("[FRTID] = {0}", afbGridView.GetFocusedRowCellValue("FRTID"));
        }

        private void chargeGridView_DoubleClick(object sender, EventArgs e)
        {
            afbGridView.ActiveFilterString = string.Format("[FRTID] = {0}", chargeGridView.GetFocusedRowCellValue("FRTID"));
            chargeGridView.ActiveFilterString = string.Format("[FRTID] = {0}", chargeGridView.GetFocusedRowCellValue("FRTID"));
        }

        private void chargeGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Add)
            {
                int rh = e.ControllerRow;
                if (chargeGridView.IsDataRow(rh))
                    if ((int)chargeGridView.GetRowCellValue(rh, "AFDID") < 0)
                        chargeGridView.UnselectRow(rh);
            }
        }

        private void chargeIptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = chargeGridView;

            if (view.GetFocusedRowCellValue("EDITABLE").ToString() != "T")
                return;
            
            if (view.IsDataRow(view.FocusedRowHandle) && (int)view.GetFocusedRowCellValue("AFDID") > 0)
            {
                string iptInfo = chargeIptalInfoToolStripTextBox.Text;
                if (iptInfo.StartsWith("?") || iptInfo.Length < 10)
                {
                    XtraMessageBox.Show("Iptal sebebi girin", "Charge Iptal");
                    return;
                }

                int afdID = (int)view.GetFocusedRowCellValue("AFDID");
                if (afdID > 0)
                {
                    string msj = accountQueriesTableAdapter.AFD_IPT(afdID, iptInfo, Program.USR).ToString();
                    if (msj == "")
                    {
                        view.SetFocusedRowCellValue("AFDID", -afdID); // Negatif means Iptal
                        view.SetFocusedRowCellValue("INFO", iptInfo);
                        view.GetDataRow(view.FocusedRowHandle).AcceptChanges(); // Tekrar yazdirmaya gerek yok
                    }
                    else
                        XtraMessageBox.Show(msj, "Charge Iptal");
                }
            }
        }

        private void afbGridView_CustomSummaryExists(object sender, DevExpress.Data.CustomSummaryExistEventArgs e)
        {
            if (e.Item is GridGroupSummaryItem)
            {
                var fn = (e.Item as GridGroupSummaryItem).FieldName;
                //var ccc = (e.Item as GridGroupSummaryItem).DisplayFormat;
                //var ddd = afbGridView.GetGroupRowValue(e.GroupRowHandle, colBDVZb);
                //if (fn == "BTUTBRT")
               // {
               //     (e.Item as GridGroupSummaryItem).DisplayFormat = "{0:n} " + ddd;
               // }
                if (colBDVZb.GroupIndex == -1 && fn == "BTUTBRT")
                    e.Exists = false;
                else if (e.GroupLevel < colBDVZb.GroupIndex && fn == "BTUTBRT")
                    e.Exists = false;
            }
        }

        private void afbGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            DevExpress.Data.GroupRowInfo dvzGrp = (info.RowKey as DevExpress.Data.GroupRowInfo);

            for (int i = info.Level; i > 0; i--)    // Tersten Dvz'in gectigi Grubu bul
            {
                if (colBDVZb.GroupIndex == i)
                    break;
                dvzGrp = dvzGrp.ParentGroup;
            }
            info.GroupText = info.GroupText.Replace("dvz", dvzGrp.GroupValue.ToString());
        }

        private ArrayList ExtractSummaryItems(GridView view)
        {
            ArrayList groupSummaryItems = new ArrayList();
            foreach (GridSummaryItem si in view.GroupSummary)
                if (si is GridGroupSummaryItem && si.SummaryType != DevExpress.Data.SummaryItemType.None)
                    groupSummaryItems.Add(si);
            return groupSummaryItems;
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = afbGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = afbGridControl;
            
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "AÇIK FATURALAR", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = chargeGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "FATURALANMAMIŞ CHARGE", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", "" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void layoutsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Account.FaturaLink2XFcharge";
            frm.origin = chargeGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tAGUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afbGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int afbID = (int)view.GetFocusedRowCellValue("AFBID");
            Genel.TblTagMdfyXF frm = new Genel.TblTagMdfyXF();
            frm.RefTbl = "AFB";
            frm.RefID = afbID;
            frm.TAGs = view.GetFocusedRowCellValue("TAGS");
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                view.SetFocusedRowCellValue("TAGS", frm.TAGs);
                this.afblTableAdapter.ClearBeforeFill = false;
                this.afblTableAdapter.FillByAFBID(this.accountDataSet.AFBL, afbID, Program.USR);
                afblTableAdapter.ClearBeforeFill = true;
            }

        }

        private void opsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = chargeGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellDisplayText(colOPHMc) == "M")
            {
                Ops.opMasterXUC frm = new Ops.opMasterXUC();
                frm.qsString = string.Format("OPMid = {0}", view.GetFocusedRowCellValue(colOPIDc));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colOPIDc);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }
            else if (view.GetFocusedRowCellDisplayText(colOPHMc) == "H")
            {
                Ops.opHouseXUC frm = new Ops.opHouseXUC();
                frm.qsString = string.Format("OPHid = {0}", view.GetFocusedRowCellValue(colOPIDc));
                frm.Show();

                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                panel.FloatLocation = new Point(100, 100);
                panel.FloatSize = new Size(600, 300);
                panel.Name = "Ops";
                panel.Text = "Ops:" + view.GetFocusedRowCellDisplayText(colOPIDc);

                frm.Dock = DockStyle.Fill;
                panel.Controls.Add(frm);
            }

        }

        private void kPISetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = chargeGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (!Program.MF.EntryCheck("Genel.KpiSetXF", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colAFDIDc);

            Genel.KpiSetXF frm = new Genel.KpiSetXF();
            frm.Tbl = "AFD";
            frm.TblPK = PK;
            frm.KPI = view.GetFocusedRowCellValue(colKPIc).ToString();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void fiyatDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = chargeGridView;
            int PK = (int)view.GetFocusedRowCellValue(colAFDIDc);
            AfdFytUpdXF frm = new AfdFytUpdXF();
            frm.AfdID = PK;
            frm.oDvz = view.GetFocusedRowCellValue(colDDVZc).ToString();
            frm.oFyt = (decimal)view.GetFocusedRowCellValue(colDFYTc);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                afdlTableAdapter.ClearBeforeFill = false;
                afdlTableAdapter.FillByAfdID(accountDataSet.AFDL, PK, Program.USR);
                afdlTableAdapter.ClearBeforeFill = true;
            }
            frm.Dispose();
        }



        /*
        private void afbGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            var vv = info.Column;
            var xx = info.EditValue;
            var yy = info.GroupText;
            var zz = info.GroupValueText;
            var cc = info.Level;
            var dd = info.RowHandle;
            var ee = info.RowKey;

            //(ee as DevExpress.Data.GroupRowInfo).ParentGroup.
            //object ab;
            
            DevExpress.Data.GroupRowInfo pg = (ee as DevExpress.Data.GroupRowInfo);
            for (int i = info.Level; i > 0; i--)
            {
                if (colBDVZb.GroupIndex == i)
                    break;
                pg = pg.ParentGroup;
                //ab = view.GetGroupRowValue(dd);
            }
            var d2 = view.GetParentRowHandle(info.RowHandle);
            var c1 = view.GetGroupSummaryText(pg.Handle);
            //var c2 = view.GetGroupRowDisplayText(pg.Handle).Replace("dvz", pg.GroupValue.ToString());
            info.GroupText = info.GroupText.Replace("dvz", pg.GroupValue.ToString());
            //var d1 = (pg as GridGroupRowInfo).Column.FieldName;

            var aa = (GridGroupSummaryItem)afbGridView.GroupSummary[0];
            
            //afbGridView.GetGroupSummaryValue(1, afbG
            
            GridView view = sender as GridView;
            GridGroupRowInfo info = e.Info as GridGroupRowInfo;
            if (info.Column.FieldName == "BDVZ")
            {
                //int quantity = Convert.ToInt32(view.GetGroupRowValue(e.RowHandle, info.Column));
                //string colorName = getColorName(quantity);
                var aaa = info.Column.Caption + info.GroupValueText;
                var bbb = view.GetGroupSummaryText(e.RowHandle);
                //System.Collections.Hashtable ccc = view.GetGroupSummaryValues(e.RowHandle);

                System.Collections.Hashtable ht = view.GetGroupSummaryValues(e.RowHandle);
                Text = "";
                // Iterate through group summaries.
                info.GroupText = info.GroupValueText;
                foreach (DictionaryEntry entry in ht)
                {
                    GridGroupSummaryItem sumItem = entry.Key as GridGroupSummaryItem;
                    object val = entry.Value;
                    var ggg = sumItem.FieldName;
                    ///if (sumItem.FieldName == "BTUTBRT")
                    //    sumItem.DisplayFormat = "{0:n} " + aaa;
                    // Get the summry item's Tag property and summary value. 
                    //Text += sumItem.FieldName + ": " + val.ToString() + "\t";
                    if (sumItem.FieldName == "BTUTBRT")
                        info.GroupText += string.Format("{0:n2} {1} ", val, info.GroupValueText);
                    else
                        info.GroupText += sumItem.FieldName + " : " + val.ToString() + "  ";

                }

                //info.GroupText = info.Column.Caption + info.GroupValueText;
                //info.GroupText += "  " + view.GetGroupSummaryText(e.RowHandle);
            }
        }

        */
    }
}