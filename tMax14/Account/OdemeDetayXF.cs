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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraGrid;

namespace tMax14.Account
{
    public partial class OdemeDetayXF : DevExpress.XtraEditors.XtraForm
    {
        //AccountDataSet.AOD_SEL_KALANLARDataTable movedDT;
        public AccountDataSet.AOBRow aobRow;

        public OdemeDetayXF()
        {
            InitializeComponent();
        }

        private void aOD_REC_SELBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aodBindingSource.EndEdit();
            this.aodTableAdapter.Update(this.accountDataSet.AOD);
        }

        private void OdemeDetayXF_Load(object sender, EventArgs e)
        {
            colBDVZ.Caption = aobRow.DVZ;
            colBKUR.Caption = aobRow.DVZ + " Kur";
            colBBRC.Caption = aobRow.DVZ + " Borç";
            colBALC.Caption = aobRow.DVZ + " Alacak";

            this.aodTableAdapter.Fill(this.accountDataSet.AOD, aobRow.AOBID);

            aodGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTID.ColumnEdit = Program.MF.frtRepositoryItemSearchLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            iFRTIDToolStripTextBox.Text = aobRow.FRTID.ToString();
            fillToolStripButton.PerformClick();

            kurDateEdit.DateTime = aobRow.TRH;
            dvzSelSimpleButton.PerformClick();

            //movedDT = (AccountDataSet.AOD_SEL_KALANLARDataTable)this.accountDataSet.AOD_SEL_KALANLAR.Clone();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.aodSelKalanlarTableAdapter.Fill(this.accountDataSet.AOD_SEL_KALANLAR, new System.Nullable<int>(((int)(System.Convert.ChangeType(iFRTIDToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aodGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            decimal tut = 0,
                    kur = 0,
                    bTut = 0,
                    bKur = 0;

            var focusedColumn = aodGridView.FocusedColumn;

            if (aodGridView.GetRowCellValue(e.RowHandle, colBKUR) != DBNull.Value)
                bKur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBKUR));

            if (aodGridView.GetRowCellValue(e.RowHandle, colREFID) == DBNull.Value)   // Referansi yoksa
            {
                if (e.Column == colFRTID)
                {
                    int FRTid = (int)aodGridView.GetRowCellValue(e.RowHandle, colFRTID);
                    
                    string fDVZ = "TRL";
                    var frtRow = Program.MF.mainDataSet.FRT.FindByFRTID(FRTid);
                    if (!frtRow.IsDVZNull())
                        fDVZ = Program.MF.mainDataSet.FRT.FindByFRTID(FRTid).DVZ;
                    aodGridView.SetRowCellValue(e.RowHandle, colDVZ, fDVZ);
                    aodGridView.SetRowCellValue(e.RowHandle, colKUR, this.accountDataSet.DVZ_SEL.FindByDVZ(fDVZ).KUR1);
                }

                if (focusedColumn == colBRC && e.Column == colBRC)
                    aodGridView.SetRowCellValue(e.RowHandle, colALC, DBNull.Value);
                if (focusedColumn == colALC && e.Column == colALC)
                    aodGridView.SetRowCellValue(e.RowHandle, colBRC, DBNull.Value);

                // Detay Tutarlari
                if ((focusedColumn == colBRC && e.Column == colBRC) || (focusedColumn == colKUR && e.Column == colKUR))
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBRC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBRC));
                        kur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colKUR));
                        bTut = Math.Round(tut * kur / bKur, 2, MidpointRounding.AwayFromZero);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, bTut);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
                if ((focusedColumn == colALC && e.Column == colALC) || (focusedColumn == colKUR && e.Column == colKUR))
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colALC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colALC));
                        kur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colKUR));
                        bTut = Math.Round(tut * kur / bKur, 2, MidpointRounding.AwayFromZero);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, bTut);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
                // Baslik Tutarlari
                if (focusedColumn == colBBRC && e.Column == colBBRC)
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBBRC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBRC));
                        bTut = Convert.ToDecimal(e.Value);
                        bKur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBKUR));
                        kur = bTut * bKur / tut;
                        aodGridView.SetRowCellValue(e.RowHandle, colKUR, kur);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
                if (focusedColumn == colBALC && e.Column == colBALC)
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBALC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colALC));
                        bTut = Convert.ToDecimal(e.Value);
                        bKur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBKUR));
                        kur = bTut * bKur / tut;
                        aodGridView.SetRowCellValue(e.RowHandle, colKUR, kur);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
            }

            if (aodGridView.GetFocusedRowCellValue(colREFID) != DBNull.Value)   // Referansi varsa
            {
                decimal odmMinTut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colODMMINTUT));
                decimal odmMaxTut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colODMMAXTUT));

                // Detay Tutarlari
                if ((focusedColumn == colBRC && e.Column == colBRC) || (focusedColumn == colKUR && e.Column == colKUR))
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBRC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBRC));
                        kur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colKUR));
                        bTut = Math.Round(tut * kur / bKur, 2, MidpointRounding.AwayFromZero);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, bTut);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
                if ((focusedColumn == colALC && e.Column == colALC) || (focusedColumn == colKUR && e.Column == colKUR))
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colALC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colALC));
                        kur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colKUR));
                        bTut = Math.Round(tut * kur / bKur, 2, MidpointRounding.AwayFromZero);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, bTut);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }

                // Baslik Tutarlari
                if (focusedColumn == colBBRC && e.Column == colBBRC)
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBBRC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBRC));
                        bTut = Convert.ToDecimal(e.Value);
                        bKur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBKUR));
                        kur = bTut * bKur / tut;
                        aodGridView.SetRowCellValue(e.RowHandle, colKUR, kur);
                        aodGridView.SetRowCellValue(e.RowHandle, colBALC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
                if (focusedColumn == colBALC && e.Column == colBALC)
                {
                    if (aodGridView.GetRowCellValue(e.RowHandle, colBALC) != DBNull.Value)
                    {
                        tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colALC));
                        bTut = Convert.ToDecimal(e.Value);
                        bKur = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBKUR));
                        kur = bTut * bKur / tut;
                        aodGridView.SetRowCellValue(e.RowHandle, colKUR, kur);
                        aodGridView.SetRowCellValue(e.RowHandle, colBBRC, DBNull.Value);
                        aodGridView.UpdateSummary();
                    }
                }
            }
        }


        private void aodGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            
            if (aodGridView.GetFocusedRowCellValue(colREFID) != DBNull.Value)   // Referansi varsa
            {
                if (aodGridView.FocusedColumn == colFRTID)
                {
                        e.Cancel = true;
                }
                if (aodGridView.FocusedColumn == colDVZ)
                {
                        e.Cancel = true;
                }
                if (aodGridView.FocusedColumn == colBRC)
                {
                    if (aodGridView.GetFocusedRowCellDisplayText(colODMBAkln) == "B")
                        aodGridView.SetFocusedRowCellValue(colALC, DBNull.Value);
                    else
                        e.Cancel = true;
                }
                if (aodGridView.FocusedColumn == colALC)
                {
                    if (aodGridView.GetFocusedRowCellDisplayText(colODMBAkln) == "A")
                        aodGridView.SetFocusedRowCellValue(colBRC, DBNull.Value);
                    else
                        e.Cancel = true;
                }
                if (aodGridView.FocusedColumn == colBBRC)
                {
                    if (aodGridView.GetFocusedRowCellDisplayText(colODMBAkln) == "B")
                        aodGridView.SetFocusedRowCellValue(colBALC, DBNull.Value);
                    else
                        e.Cancel = true;
                }
                if (aodGridView.FocusedColumn == colBALC)
                {
                    if (aodGridView.GetFocusedRowCellDisplayText(colODMBAkln) == "A")
                        aodGridView.SetFocusedRowCellValue(colBBRC, DBNull.Value);
                    else
                        e.Cancel = true;
                }
            }
        }

        private void aodGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            /*
            decimal tut = 0;
            decimal odmMinTut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colODMMINTUTd));
            decimal odmMaxTut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colODMMAXTUTd));

            if (aodGridView.GetRowCellValue(e.RowHandle, colBRC) != DBNull.Value)
            {
                tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colBRC));
                if (tut < odmMinTut || tut > odmMaxTut)
                {
                    e.Valid = false;
                    e.ErrorText = string.Format("Borç tutarında Hata : {0} >= {1} <= {2}\n", odmMinTut, tut, odmMaxTut);
                }
            }
            if (aodGridView.GetRowCellValue(e.RowHandle, colALC) != DBNull.Value)
            {
                tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colALC));
                if (tut < odmMinTut || tut > odmMaxTut)
                {
                    e.Valid = false;
                    e.ErrorText = string.Format("Alacak tutarında Hata : {0} >= {1} <= {2}\n", odmMinTut, tut, odmMaxTut);
                }
            }

            if (aodGridView.GetRowCellValue(e.RowHandle, colD2BKUR) == DBNull.Value)
            {
                e.Valid = false;
                e.ErrorText = "Çapraz Kur girilmemiş\n";
            }
            if (aodGridView.GetRowCellValue(e.RowHandle, colD2BKUR) != DBNull.Value)
            {
                tut = Convert.ToDecimal(aodGridView.GetRowCellValue(e.RowHandle, colD2BKUR));
                if (tut <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Çapraz kur >= 0 olmalı\n";
                }
            }*/
        }

        private void aodGridView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView view = sender as GridView;
            if (aodGridView.GetFocusedRowCellValue(colREFID) != DBNull.Value)   // Referansi varsa
            {
                if (view.FocusedColumn == colKUR)
                {
                    if (e.Value == DBNull.Value)
                    {
                        e.Valid = false;
                        e.ErrorText = "Kur girilmemiş\n";
                    }
                    else
                    {
                        decimal val = Convert.ToDecimal(e.Value);
                        if (val <= 0)
                        {
                            e.Valid = false;
                            e.ErrorText = "Kur >= 0 olmalı\n";
                        }
                    }
                }
                else if (view.FocusedColumn == colBRC)
                {
                    string odmBA = view.GetFocusedRowCellDisplayText(colODMBAkln);
                    if (e.Value == DBNull.Value && odmBA == "B")
                    {
                        e.Valid = false;
                        e.ErrorText = "Borç tutarı girilmemiş\n";
                    }
                    if (e.Value != DBNull.Value)
                    {
                        decimal odmMinTut = Convert.ToDecimal(view.GetFocusedRowCellValue(colODMMINTUT));
                        decimal odmMaxTut = Convert.ToDecimal(view.GetFocusedRowCellValue(colODMMAXTUT));
                        decimal val = Convert.ToDecimal(e.Value);
                        if (val < odmMinTut || val > odmMaxTut)
                        {
                            e.Valid = false;
                            e.ErrorText = string.Format("Borç tutarında Hata : {0} >= {1} <= {2}\n", odmMinTut, val, odmMaxTut);
                        }
                    }
                }
                else if (view.FocusedColumn == colALC)
                {
                    string odmBA = view.GetFocusedRowCellDisplayText(colODMBAkln);
                    if (e.Value == DBNull.Value && odmBA == "A")
                    {
                        e.Valid = false;
                        e.ErrorText = "Alacak tutarı girilmemiş\n";
                    }
                    if (e.Value != DBNull.Value)
                    {
                        decimal odmMinTut = Convert.ToDecimal(view.GetFocusedRowCellValue(colODMMINTUT));
                        decimal odmMaxTut = Convert.ToDecimal(view.GetFocusedRowCellValue(colODMMAXTUT));
                        decimal val = Convert.ToDecimal(e.Value);
                        if (val < odmMinTut || val > odmMaxTut)
                        {
                            e.Valid = false;
                            e.ErrorText = string.Format("Alacak tutarında Hata : {0} >= {1} <= {2}\n", odmMinTut, val, odmMaxTut);
                        }
                    }
                }
            }
        }

        private void aodGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {/*
            GridView view = sender as GridView;
            int AODid = (int)accountQueriesTableAdapter.GET_PK("ACC");

            //view.BeginDataUpdate();
            view.SetFocusedRowCellValue(colAODID, AODid);
            view.SetFocusedRowCellValue(colAOBID, aobRow.AOBID);
            view.SetFocusedRowCellValue(colDVZ, "TRL");
            view.SetFocusedRowCellValue(colDVZkur, 1);
            view.SetFocusedRowCellValue(colBRC, 0);
            //view.EndDataUpdate();*/
        }

        private void yeniKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newRow = accountDataSet.AOD.NewAODRow();

            newRow.AOBID = aobRow.AOBID;
            newRow.AODID = (int)accountQueriesTableAdapter.GET_PK("ACC");

            newRow.DVZ = "TRL";
            newRow.KUR = 1;

            newRow.BDVZ = aobRow.DVZ;
            newRow.BKUR = aobRow.KUR;

            accountDataSet.AOD.AddAODRow(newRow);
        }

        private void klnGridView_DoubleClick(object sender, EventArgs e)
        {
            Kalan2AOD();
        }
        
        private void Kalan2AOD()
        {

            var srcRow = (AccountDataSet.AOD_SEL_KALANLARRow)klnGridView.GetFocusedDataRow();
            if (srcRow.REFDRM == "A")
            {
                XtraMessageBox.Show("Fatura henüz tamamlanmamış, Ödemede kullanamazsınız!", "Referans belge ekle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var newRow = accountDataSet.AOD.NewAODRow();

            newRow.AOBID = aobRow.AOBID;
            newRow.AODID = (int)accountQueriesTableAdapter.GET_PK("ACC");

            newRow.REFTBL = srcRow.REFTBL;
            if (!srcRow.IsREFIDNull())
                newRow.REFID = srcRow.REFID;
            newRow.REFTUR = srcRow.REFTUR;
            newRow.REFBA = srcRow.REFBA;

            newRow.REFTUT = srcRow.REFTUT;
            newRow.REFKLNTUT = srcRow.REFKLNTUT;


            newRow.FRTID = srcRow.FRTID;
            newRow.DVZ = srcRow.REFDVZ;
            newRow.KUR = this.accountDataSet.DVZ_SEL.FindByDVZ(newRow.DVZ).KUR1;
            newRow.BDVZ = aobRow.DVZ;
            newRow.BKUR = aobRow.KUR;

            newRow.ODMBA = srcRow.ODMBA;
            newRow.ODMMINTUT = srcRow.ODMMINTUT;
            newRow.ODMMAXTUT = srcRow.ODMMAXTUT;
            if (srcRow.ODMBA == "B")
            {
                newRow.BRC = newRow.ODMMAXTUT;
                newRow.BBRC = Math.Round(newRow.BRC * Convert.ToDecimal(newRow.KUR) / Convert.ToDecimal(newRow.BKUR), 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                newRow.ALC = newRow.ODMMAXTUT;
                newRow.BALC = Math.Round(newRow.ALC * Convert.ToDecimal(newRow.KUR) / Convert.ToDecimal(newRow.BKUR), 2, MidpointRounding.AwayFromZero);
            }

            accountDataSet.AOD.AddAODRow(newRow);
            klnGridView.DeleteRow(klnGridView.FocusedRowHandle);

            //object[] values = srcRow.ItemArray;
            //movedDT.Rows.Add(values);
        }

        private void SaveInTransaction()
        {
            // Calismasi icin accountDataSet.cs ye bak!!!!!!!!!!!!!!!!!!!! Hierarcial Update False oldugunda calismasi icin

            bool workConnOpened = false;
            global::System.Data.IDbConnection workConnection = this.aodTableAdapter.Connection;
            if (((workConnection.State & global::System.Data.ConnectionState.Broken) == global::System.Data.ConnectionState.Broken))
            {
                workConnection.Close();
            }
            if ((workConnection.State == global::System.Data.ConnectionState.Closed))
            {
                workConnection.Open();
                workConnOpened = true;
            }
            //workConnection.Open();
            global::System.Data.IDbTransaction workTransaction = workConnection.BeginTransaction();
            try
            {
                this.aodTableAdapter.Transaction = ((global::FirebirdSql.Data.FirebirdClient.FbTransaction)(workTransaction));
                this.aodTableAdapter.Update(this.accountDataSet.AOD);
                workTransaction.Commit();
            }
            catch (Exception ex)
            {
                workTransaction.Rollback();
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Kaydederken hata oluştu. Hiçbir değisiklik kaydedilmedi!");
            }
            finally
            {
                if (workConnOpened)
                    workConnection.Close();
            }
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            /*
            if (e.Info == null && e.SelectedControl == aodGridControl)
            {
                GridView view = aodGridControl.FocusedView as GridView;
                GridHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                if (info.InRowCell)
                {
                    string text = view.GetRowCellDisplayText(info.RowHandle, info.Column);
                    string cellKey = info.RowHandle.ToString() + " - " + info.Column.ToString();
                    e.Info = new DevExpress.Utils.ToolTipControlInfo(cellKey, text+"  sener");
                }
            }*/


            if (e.SelectedControl != aodGridControl) return;

            ToolTipControlInfo info = null;
            //Get the view at the current mouse position
            GridView view = aodGridControl.GetViewAt(e.ControlMousePosition) as GridView;
            if (view == null) return;
            //Get the view's element information that resides at the current position
            GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
            //Display a hint for row indicator cells
            if (hi.HitTest == GridHitTest.RowIndicator)
            {
                //An object that uniquely identifies a row indicator cell
                object o = hi.HitTest.ToString() + hi.RowHandle.ToString();
                string text = "Row " + hi.RowHandle.ToString();
                //text = string.Format("<color=255,0,0>Tür:\t{0}</color>\nID: \t{1}\nNo:\t{2}\nTrh:\t{3}\nVde:\t{4}\nTut:\t{5:n2}\nKln:\t{6:n2}", 
                text = string.Format("<size=10>"+
                                     "<color=255,0,0>Referans Belge</color><br>" +
                                     "Tür: <b>{0}</b></color><br>" +
                                     "ID:  <b>{1}</b><br>"+
                                     "No:  <b>{2}</b><br>" +
                                     "Trh: <b>{3}</b><br>" +
                                     "Vde: <b>{4}</b><br>" +
                                     "Dvz: <b>{5}</b><br>" +
                                     "Tut: <b>{6,20:n2}</b><br>" +
                                     "Kln: <b>{7,20:n2}</b>" +
                                     "</size>", 
                    view.GetRowCellDisplayText(hi.RowHandle, colREFTURkln),
                    view.GetRowCellDisplayText(hi.RowHandle, colREFID),
                    view.GetRowCellDisplayText(hi.RowHandle, colREFNO),
                    view.GetRowCellDisplayText(hi.RowHandle, colREFTRH),
                    view.GetRowCellDisplayText(hi.RowHandle, colREFODMVDE),
                    view.GetRowCellDisplayText(hi.RowHandle, colREFDVZ),
                    view.GetRowCellValue(hi.RowHandle, colREFTUT),
                    view.GetRowCellValue(hi.RowHandle, colREFKLNTUT)
                    );
                info = new ToolTipControlInfo(o, text);
            }
            //Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
            if (info != null)
                e.Info = info;
        }

        private void aodGridView_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            decimal bt = Convert.ToDecimal(colBBRC.SummaryItem.SummaryValue);
            decimal at = Convert.ToDecimal(colBALC.SummaryItem.SummaryValue);

            if (e.Info.SummaryItem.Tag.ToString() == "bBrcKln")
            {
                if (at > bt)
                    e.Info.DisplayText = string.Format("{0:N2}", (at - bt));
                else
                    e.Info.DisplayText = "";
            }
            else if (e.Info.SummaryItem.Tag.ToString() == "bAlcKln")
            {
                if (bt > at)
                    e.Info.DisplayText = string.Format("{0:N2}", (bt - at));
                else
                    e.Info.DisplayText = "";
            }

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountDataSet.AOD.HasErrors)   // Varsa Onceki hatalari temizle
            {
                DataRow[] errRows = accountDataSet.AOD.GetErrors();
                for (int i = 0; i < errRows.Length; i++)
                    errRows[i].ClearErrors();
            }

            // Borc != Alacak ise Yazdirma
            decimal bt = Convert.ToDecimal(colBBRC.SummaryItem.SummaryValue);
            decimal at = Convert.ToDecimal(colBALC.SummaryItem.SummaryValue);

            if (bt != at)
            {
                XtraMessageBox.Show("Toplamler eşit değil!", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveInTransaction();
        }

        private void aodGridView_RowStyle(object sender, RowStyleEventArgs e)
        {

            if (e.RowHandle == aodGridView.FocusedRowHandle && !aodGridView.IsGroupRow(e.RowHandle))
            {
                if (string.IsNullOrEmpty(aodGridView.GetRowCellDisplayText(e.RowHandle, colBRC)))
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.BackColor = Color.LightCyan;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Blue;
                    e.Appearance.BackColor = Color.LightCyan;
                }

                e.HighPriority = true;
            }
        }

        private void kayitSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aodGridView.DeleteRow(aodGridView.FocusedRowHandle);
        }

        private void dvzSelSimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dvzSelTableAdapter.FillByTrh(this.accountDataSet.DVZ_SEL, kurDateEdit.DateTime);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private double CaprazKur(string frDvz, string toDvz)
        {
            double fr = this.accountDataSet.DVZ_SEL.FindByDVZ(frDvz).KUR1;
            double to = this.accountDataSet.DVZ_SEL.FindByDVZ(toDvz).KUR1;
            return fr / to;
        }

        private void KalanlaKapat()
        {
            aodGridView.UpdateSummary();
            decimal bBrc = 0, bAlc = 0;
            if (aodGridView.GetFocusedRowCellValue(colBBRC) != DBNull.Value)
                bBrc = Convert.ToDecimal(aodGridView.GetFocusedRowCellValue(colBBRC));
            if (aodGridView.GetFocusedRowCellValue(colBALC) != DBNull.Value)
                bAlc = Convert.ToDecimal(aodGridView.GetFocusedRowCellValue(colBALC));

            decimal bTop = Convert.ToDecimal(colBBRC.SummaryItem.SummaryValue);
            bTop -= bBrc;
            decimal aTop = Convert.ToDecimal(colBALC.SummaryItem.SummaryValue);
            aTop -= bAlc;

            if (bTop != aTop)
            {
                decimal bKur = Convert.ToDecimal(aobRow.KUR);

                string dDVZ = aodGridView.GetFocusedRowCellDisplayText(colDVZ);
                string bDVZ = aodGridView.GetFocusedRowCellDisplayText(colBDVZ);
                decimal kur = Convert.ToDecimal(this.accountDataSet.DVZ_SEL.FindByDVZ(dDVZ).KUR1);
                decimal frk = Math.Abs(bTop - aTop);
                decimal tut = Math.Round(frk * bKur / kur, 2, MidpointRounding.AwayFromZero);
                aodGridView.SetFocusedRowCellValue(colKUR, kur);

                if (bTop > aTop)
                {
                    aodGridView.SetFocusedRowCellValue(colALC, tut);
                    aodGridView.SetFocusedRowCellValue(colBALC, frk);
                }
                else
                {
                    aodGridView.SetFocusedRowCellValue(colBRC, tut);
                    aodGridView.SetFocusedRowCellValue(colBBRC, frk);
                }
                aodGridView.UpdateCurrentRow();
            }
        }

        private void kalanlaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KalanlaKapat();
        }

        private void dvzGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (dvzGridView.GetFocusedRowCellDisplayText(colDVZkur) == "TRL")
                e.Cancel = true;
        }

    }
}