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
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Docking;

namespace tMax14.Account
{
    public partial class FisDetayXF : DevExpress.XtraEditors.XtraForm
    {
        private AccountDataSet.AVBRow avbRow;
        string kalanHspNo = "";
        List<string> klnHspNoS = new List<string>();
        //int AVBid, AFBid, ACSid;
        string refTO;
        int refID;
        bool Editable;
        bool initRow = false;   // avdGridView_CellValueChanged tekrar tekrar girmesin diye

        public FisDetayXF(string refTO, int refID, bool editable = false)
        {
            InitializeComponent();

            this.refTO = refTO;
            this.refID = refID;
            this.Editable = editable;

            avbvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowDRM.Properties.RowEdit = Program.MF.AVBdrmRepositoryItemImageComboBox;
            rowTUR.Properties.RowEdit = Program.MF.AVBTrepositoryItemLookUpEdit;

            Program.MF.GridControlSettings(avdGridControl);

            avdGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colHSPNO.ColumnEdit = Program.MF.AHPhspNoAdRepositoryItemLookUpEdit;  //Display
            colSKL.ColumnEdit = Program.MF.AVDsklRepositoryItemImageComboBox;

            avdKlnGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colHSPNOk.ColumnEdit = Program.MF.AHPrepositoryItemLookUpEdit;  //Program.MF.AHPrepositoryItemSearchLookUpEdit;
            colEFUTAGSk.ColumnEdit = Program.MF.TAGselEFUrepositoryItemCheckedComboBoxEdit;

            //hspNoSearchLookUpEdit.Properties.DataSource = Program.MF.AHPrepositoryItemSearchLookUpEdit.DataSource;
            //hspNoSearchLookUpEdit.Properties.ValueMember = "HSPNO";
            //hspNoSearchLookUpEdit.Properties.DisplayMember = "HspNoAd";

            checkedComboBoxEdit1.Properties.DataSource = Program.MF.AHPdtyRepositoryItemLookUpEdit.DataSource;
            checkedComboBoxEdit1.Properties.ValueMember = "HSPNO";
            checkedComboBoxEdit1.Properties.DisplayMember = "HspAdNo";

            Program.MF.DVTrepositoryItemLookUpEdit.Closed += DVTrepositoryItemLookUpEdit_Closed;
        }

        void DVTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            Form frm = Form.ActiveForm;

            if (a.OldEditValue != a.EditValue && avdGridControl.IsFocused && frm == this)
            {
                this.kuR_AVBTableAdapter.Fill(this.accountDataSet.KUR_AVB, a.EditValue.ToString(), avbRow.TRH);
                //avdGridView.SetFocusedRowCellValue(colDKUR, accountDataSet.KUR_AVB[0].BKUR);
                avdGridView.SetFocusedRowCellValue(colAKUR, accountDataSet.KUR_AVB[0].AKUR);

                // aTut sadece dDvz degistiginde hesaplanir, sonra Yuvarlama ile degisebilir!
                decimal dTut = Convert.ToDecimal(avdGridView.GetFocusedRowCellValue(colDTUT));
                decimal aKur = Convert.ToDecimal(avdGridView.GetFocusedRowCellValue(colAKUR));
                decimal aTut = Math.Round(dTut * aKur, 2);
                avdGridView.SetFocusedRowCellValue(colATUT, aTut);
            }
        }

        private void FisDetayXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
        }

        public void Save()
        {
            this.Validate();
            this.avdBindingSource.EndEdit();
            try
            {
                //this.avdTableAdapter.Save(this.accountDataSet.AVD);    // !!Save Kullanma 5.9.1 de hata geliyor
                this.avdTableAdapter.Update(this.accountDataSet.AVD);
                this.avdDtyTableAdapter.Update(this.accountDataSet.AVDD);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                this.accountDataSet.AVDD.RejectChanges();
                this.accountDataSet.AVD.RejectChanges();
            }
        }

        private void FisDetayXF_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void LoadAll()
        {
            int nor = 0;
            if (refTO == "V")   // AVBden geliyor AVBID=refID
                nor = avbTableAdapter.Fill(accountDataSet.AVB, string.Format("AVB.AVBid = {0}", refID), Program.USR);
            else
                nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("RefID = {0} and RefTO = '{1}'", refID, refTO), Program.USR);

            /*
            if (AFBid != 0) // Faturadan Geliyor
                nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("RefID = {0} and RefTO = 'F'", AFBid), Program.USR);
            else if (ACSid != 0) // Cekden Geliyor
                nor = this.avbTableAdapter.Fill(this.accountDataSet.AVB, string.Format("RefID = {0} and RefTO = 'C'", ACSid), Program.USR);
            else
                nor = avbTableAdapter.Fill(accountDataSet.AVB, string.Format("AVB.AVBid = {0}", AVBid), Program.USR);
            */
            
            if (nor == 0)
            {
                XtraMessageBox.Show("Kayıt bulunamadı", "Fiş Detayları");
                this.Close();
                return;
            }
            avbRow = accountDataSet.AVB[0];

            if (Editable)
            {
                if (avbRow.DRM != "A")  // Kapaliysa
                    Editable = false;
                else
                    Editable = Program.MF.YetkiCheck(avbRow.IsONYYTKNull() == true ? "" : avbRow.ONYYTK);   // OnyYtk sine gore

            }
            avdGridView.OptionsBehavior.Editable = Editable;
            avdDtyGridView.OptionsBehavior.Editable = Editable;
            kalaniSifirlaToolStripMenuItem.Enabled = Editable;
            
            kullanToolStripMenuItem.Enabled = Editable;

            if (!Editable)
                Text += "  [ReadOnly]";

            /**
            avdGridView.OptionsBehavior.Editable = Program.MF.YetkiCheck(avbRow.IsONYYTKNull() == true ? "" : avbRow.ONYYTK);

            if (avbRow.DRM != "A")
            {
                avdGridView.OptionsBehavior.Editable = false;
                avdDtyGridView.OptionsBehavior.Editable = false;
            }

            if (avdGridView.OptionsBehavior.Editable == false)
            {
                Text += "  [ReadOnly]";
                kalaniSifirlaToolStripMenuItem.Enabled = false;
                kullanToolStripMenuItem.Enabled = false;
                //avddGridView.Appearance.HeaderPanel.BackColor = Color.Coral;
                //XtraMessageBox.Show("Bu Fiş içinde Değişiklik yapamazsınız", "Fiş Detayları", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/

            this.avdTableAdapter.Fill(this.accountDataSet.AVD, avbRow.AVBID);
            this.avdDtyTableAdapter.Fill(this.accountDataSet.AVDD, avbRow.AVBID, 0);
            this.hTableAdapter.Fill(this.accountDataSet.AVD_KALANLAR_HELPER, DateTime.Today);

            //colCalcATUT.Caption = string.Format("ResmiTutar{0}", "TRL");
            //colCalcATUT.ToolTip = string.Format("ResmiTutar{0}", "TRL");

            colDDVZ.ToolTip = "İşlem Dövizi";
            colAKUR.ToolTip = "Resmi Kur";

            dovizKalanlari();

            kurUpdSimpleButton.Enabled = Program.MF.EntryCheck("Account.FisDetayXF.KurUpd", true);
        }

        private void avdGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle && !view.IsGroupRow(e.RowHandle))
            {
                if (view.GetRowCellValue(e.RowHandle, colBA).ToString() == "A")
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

        private void avdkGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle && !view.IsGroupRow(e.RowHandle))
            {
                if (view.GetRowCellValue(e.RowHandle, colBAk).ToString() == "A")
                {
                    e.Appearance.ForeColor = Color.Red;
                    e.Appearance.BackColor = Color.LemonChiffon;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Blue;
                    e.Appearance.BackColor = Color.LemonChiffon;
                }

                e.HighPriority = true;
            }
        }

        private void kalanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kalanHspNo = avdGridView.GetFocusedRowCellValue(colHSPNO).ToString();
            klnHspNoS.Clear();
            klnHspNoS.Add(avdGridView.GetFocusedRowCellValue(colHSPNO).ToString());
            hesapKalanlari();

        }

        private void hesapKalanlari()
        {
            klnTopDockPanel.Visibility = DockVisibility.Visible;
            klnTopDockPanel.MakeFloat();

            this.accountDataSet.AVDK.Clear();
            this.avdKlnTableAdapter.ClearBeforeFill = false;
            foreach (string klnHspNo in klnHspNoS)
                this.avdKlnTableAdapter.Fill(this.accountDataSet.AVDK, klnHspNo);
            //this.avdkTableAdapter.Fill(this.accountDataSet.AVDK, kalanHspNo);
        }

        private void kullanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!avdGridView.OptionsBehavior.Editable)
            //    return;

            //if (!Editable)
            //    return;

            avdGridView.BeginUpdate();
            foreach (int rowHnd in avdKlnGridView.GetSelectedRows())
            {
                if (avdKlnGridView.IsDataRow(rowHnd))
                {
                    avdGridView.AddNewRow();

                    initRow = true;
                    avdGridView.SetFocusedRowCellValue(colSKL, "K");    // HesapKapama kaydi
                    avdGridView.SetFocusedRowCellValue(colHSPNO, avdKlnGridView.GetRowCellValue(rowHnd, colHSPNOk));
                    avdGridView.SetFocusedRowCellValue(colREFTO, avdKlnGridView.GetRowCellValue(rowHnd, colREFTOk));
                    avdGridView.SetFocusedRowCellValue(colREFID, avdKlnGridView.GetRowCellValue(rowHnd, colREFIDk));
                    avdGridView.SetFocusedRowCellValue(colBA, avdKlnGridView.GetRowCellValue(rowHnd, colKBAk));
                    avdGridView.SetFocusedRowCellValue(colDTUT, avdKlnGridView.GetRowCellValue(rowHnd, colDKLNk));
                    avdGridView.SetFocusedRowCellValue(colDDVZ, avdKlnGridView.GetRowCellValue(rowHnd, colDDVZk));

                    this.kuR_AVBTableAdapter.Fill(this.accountDataSet.KUR_AVB, avdKlnGridView.GetRowCellValue(rowHnd, colDDVZk).ToString(), avbRow.TRH);
                    //avdGridView.SetFocusedRowCellValue(colDKUR, accountDataSet.KUR_AVB[0].BKUR);
                    avdGridView.SetFocusedRowCellValue(colAKUR, accountDataSet.KUR_AVB[0].AKUR);

                    decimal dTut = avdGridView.GetFocusedRowCellValue(colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(avdGridView.GetFocusedRowCellValue(colDTUT));
                    decimal aKur = avdGridView.GetFocusedRowCellValue(colAKUR) == DBNull.Value ? 0 : Convert.ToDecimal(avdGridView.GetFocusedRowCellValue(colAKUR));
                    decimal aTut = Math.Round(dTut * aKur, 2);
                    avdGridView.SetFocusedRowCellValue(colATUT, aTut);
                    avdGridView.SetFocusedRowCellValue(colDTUT_INS, avdKlnGridView.GetRowCellValue(rowHnd, colDKLNk));  //avdGridView.GetFocusedRowCellValue(colDTUT));
                    initRow = false;
                    
                    //decimal d = 0;
                    //Decimal.TryParse(avdGridView.GetFocusedRowCellValue(colDTUT).ToString(), out d);
                }
            }
            avdGridView.UpdateCurrentRow();
            avdGridView.EndUpdate();
            hesapKalanlari();

            /*
            object hspNo = avdkGridView.GetFocusedRowCellValue(colHSPNOk);
            object refTo = avdkGridView.GetFocusedRowCellValue(colREFTOk);
            object refId = avdkGridView.GetFocusedRowCellValue(colREFIDk);
            object refDvz = avdkGridView.GetFocusedRowCellValue(colREFDVZk);
            object BA = avdkGridView.GetFocusedRowCellValue(colBAk);
            object tut = avdkGridView.GetFocusedRowCellValue(colTUTk);

            avdGridView.BeginUpdate();
            avdGridView.AddNewRow();
            avdGridView.SetFocusedRowCellValue(colHSPNO, hspNo);
            avdGridView.SetFocusedRowCellValue(colREFTO, refTo);
            avdGridView.SetFocusedRowCellValue(colREFID, refId);
            avdGridView.SetFocusedRowCellValue(colBA, BA);
            avdGridView.SetFocusedRowCellValue(colDTUT, tut);
            avdGridView.SetFocusedRowCellValue(colDDVZ, refDvz);

            this.kuR_AVBTableAdapter.Fill(this.accountDataSet.KUR_AVB, refDvz.ToString(), avbRow.TRH);
            avdGridView.SetFocusedRowCellValue(colDKUR, accountDataSet.KUR_AVB[0].BKUR);
            avdGridView.EndUpdate();

            avdGridView.UpdateCurrentRow();

            hesapKalanlari(hspNo.ToString());
             */
        }

        
        private void kalaniSifirlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;
            if (!view.OptionsBehavior.Editable)
                return;

            string dDvz = view.GetFocusedRowCellValue(colDDVZ).ToString();

            //this.kuR_AVBTableAdapter.Fill(this.accountDataSet.KUR_AVB, dDvz, avbRow.TRH);
            //avdGridView.SetFocusedRowCellValue(colAKUR, accountDataSet.KUR_AVB[0].AKUR);
            //view.UpdateCurrentRow();
            
            string BA = "B";
            decimal aTut = 0;

            decimal aBrcTop = Convert.ToDecimal(colCalcABRC.SummaryItem.SummaryValue);
            decimal aAlcTop = Convert.ToDecimal(colCalcAALC.SummaryItem.SummaryValue);

            decimal aBrc = Convert.ToDecimal(view.GetFocusedRowCellValue(colCalcABRC));
            decimal aAlc = Convert.ToDecimal(view.GetFocusedRowCellValue(colCalcAALC));

            aBrcTop -= aBrc;
            aAlcTop -= aAlc;


            if (aBrcTop > aAlcTop)
            {
                BA = "A";
                aTut = aBrcTop - aAlcTop;    
            }
            else 
            {
                BA = "B";
                aTut = aAlcTop - aBrcTop;
            }

            decimal aKur = Convert.ToDecimal(avdGridView.GetFocusedRowCellValue(colAKUR));
            
            decimal dTut = Math.Round(aTut / aKur, 2);

            if (dTut != 0)
                aKur = aTut / dTut;

            initRow = true;
            view.SetFocusedRowCellValue(colBA, BA);
            view.SetFocusedRowCellValue(colDTUT, dTut);
            view.SetFocusedRowCellValue(colAKUR, aKur);
            view.SetFocusedRowCellValue(colATUT, aTut);
            initRow = false;

            view.UpdateCurrentRow();
        }


        private void DTUTrepositoryItemCalcEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            // Buraya hic gelmiyor!!!
            // Referans varsa Tutar artirilamaz
            var a = sender as CalcEdit;
            if (avdGridView.GetFocusedRowCellValue(colREFID) != DBNull.Value)
                if ((decimal)a.OldEditValue < (decimal)a.EditValue)
                {
                    a.EditValue = a.OldEditValue;
                }
        }

        private void DTUTrepositoryItemCalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            GridView view = avdGridView;
            DevExpress.XtraEditors.CalcEdit edit = sender as DevExpress.XtraEditors.CalcEdit;

            decimal dTut = edit.Value;
            decimal aKur = view.GetFocusedRowCellValue(colAKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colAKUR));
            decimal aTut = Math.Round(dTut * aKur, 2);

            initRow = true;
            view.SetFocusedRowCellValue(colATUT, aTut);
            initRow = false;

            avdDtyGridView.UpdateCurrentRow();
            //avddGridView.UpdateSummary();
        }

        private void avdGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.FocusedColumn != colDTUT)
            {
                //if (view.GetFocusedRowCellValue(colREFID) != DBNull.Value && view.GetFocusedRowCellValue(colSKL).ToString() == "K" )
                if (view.GetFocusedRowCellValue(colSKL).ToString() == "K")
                    e.Cancel = true;
            }
            if (!e.Cancel)
                view.SetFocusedRowCellValue(colUPDUSR, Program.USR);
        }

        private void avdGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            initRow = true;
            GridView view = sender as GridView;
            int AVDid = (int)accountQueriesTableAdapter.GET_PK("ACC");
            view.SetFocusedRowCellValue(colAVDID, AVDid);
            view.SetFocusedRowCellValue(colAVBID, avbRow.AVBID);
            //view.SetFocusedRowCellValue(colAKUR, avbRow.AKUR);
            view.SetFocusedRowCellValue(colDDVZ, "TRL");
            view.SetFocusedRowCellValue(colDTUT, 0);
            view.SetFocusedRowCellValue(colAKUR, 1.0);
            view.SetFocusedRowCellValue(colATUT, 0);
            view.SetFocusedRowCellValue(colBA, "B");
            view.SetFocusedRowCellValue(colSKL, "A");   // Ana/Asil kayit
            view.SetFocusedRowCellValue(colINSUSR, Program.USR);
            initRow = false;

            this.avdDtyTableAdapter.Fill(this.accountDataSet.AVDD, avbRow.AVBID, AVDid);
            avdDtyGridView.RefreshData();
        }

        private void avdGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (initRow)
                return;

            GridView view = sender as GridView;
            
            if (e.Column == colDTUT)
            {

                //decimal dTut = view.GetRowCellValue(e.RowHandle, colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colDTUT));
                //decimal aKur = view.GetRowCellValue(e.RowHandle, colAKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colAKUR));
                //decimal aTut = Math.Round(dTut * aKur, 2);
                //view.SetFocusedRowCellValue(colATUT, aTut);

                string hspNo = view.GetRowCellValue(e.RowHandle, colHSPNO).ToString();
                if (!hspNo.StartsWith("6") && !hspNo.StartsWith("7"))
                    return;

                decimal dTut = view.GetRowCellValue(e.RowHandle, colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colDTUT));
                decimal aKur = view.GetRowCellValue(e.RowHandle, colAKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colAKUR));
                decimal aTut = Math.Round(dTut * aKur, 2);

                int foundIndex = -1;
                int cnt = 0;
                if (dTut != (decimal)colTUT.SummaryItem.SummaryValue)
                {
                    AccountDataSet.AVDDRow[] dRows = view.GetDataRow(e.RowHandle).GetChildRows("AVD_AVDD") as AccountDataSet.AVDDRow[];
                    for (int i = 0; i < dRows.Length; i++)
                        if (!dRows[i].IsTUTNull() && dRows[i].TUT > 0)
                        {
                            cnt++;
                            foundIndex = i;
                        }

                    if (cnt == 1)   // 1 tane bulundu Fiyati buna koy
                        dRows[foundIndex].TUT = dTut;
                    else
                    {
                        for (int i = 0; i < dRows.Length; i++)
                            dRows[i]["TUT"] = DBNull.Value;
                        dRows[0].TUT = dTut;
                    }
                }

                aTut = Math.Round(dTut * aKur, 2);
                view.SetFocusedRowCellValue(colATUT, aTut);
            }

            if (e.Column == colAKUR)
            {
                decimal dTut = view.GetRowCellValue(e.RowHandle, colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colDTUT));
                decimal aKur = view.GetRowCellValue(e.RowHandle, colAKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetRowCellValue(e.RowHandle, colAKUR));
                decimal aTut = Math.Round(dTut * aKur, 2);
                view.SetFocusedRowCellValue(colATUT, aTut);
                //view.UpdateSummary();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void avddGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string tur = view.GetRowCellValue(e.RowHandle, colTUR).ToString();
                if (tur == "-")
                {
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.BackColor = Color.Coral;
                }
                else if (tur == "K")
                {
                    e.Appearance.ForeColor = Color.Red;
                    //e.Appearance.BackColor = Color.Coral;
                }
                else if (tur == "M")
                {
                    e.Appearance.ForeColor = Color.Green;
                    //e.Appearance.BackColor = Color.Coral;
                }
                else
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                e.HighPriority = true;
            }
        }

        private void avdkGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            int rh = view.GetRowHandle(e.ListSourceRowIndex);

            if (e.Column == colREFIDk)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetRowCellValue(rh, colREFTOk));

            if (e.Column.FieldName == "dRunTotal")
            {
                int firstRowHandle = view.GroupCount == 0 ? 0 : view.GetChildRowHandle(view.GetParentRowHandle(rh), 0);
                decimal qta = 0;
                for (int i = firstRowHandle; i <= rh; i++)
                {
                    if (view.GetRowCellValue(i, colBAk).ToString() == "B")
                        qta += Convert.ToDecimal(view.GetRowCellValue(i, colDKLNk));
                    else
                        qta -= Convert.ToDecimal(view.GetRowCellValue(i, colDKLNk));
                }
                if (qta < 0)
                    e.DisplayText = (Math.Abs(qta)).ToString("N") + " A";
                else if (qta > 0)
                    e.DisplayText = qta.ToString("N") + " B";
                else
                    e.DisplayText = "";
            }
        }

        private void avdkGridView_EndGrouping(object sender, EventArgs e)
        {
            if (colDDVZk.GroupIndex >= 0)
                colCompDrunTotal.VisibleIndex = colDTUTk.VisibleIndex + 1;
        }

        private void avdGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colREFID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colREFTO));
        }

        private void checkedComboBoxEdit1_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Cancel)
                return;

            //Text = checkedComboBoxEdit1.EditValue.ToString();
            string[] hspNoS = checkedComboBoxEdit1.EditValue.ToString().Split(new char[] { ',' });
            klnHspNoS.Clear();
            foreach (string hspNo in hspNoS)
                klnHspNoS.Add(hspNo.Trim());
            
            hesapKalanlari();

        }

        private void refreshSimpleButton_Click(object sender, EventArgs e)
        {
            //Text = checkedComboBoxEdit1.EditValue.ToString();
            string[] hspNoS = checkedComboBoxEdit1.EditValue.ToString().Split(new char[] { ',' });
            klnHspNoS.Clear();
            foreach (string hspNo in hspNoS)
                klnHspNoS.Add(hspNo.Trim());

            hesapKalanlari();
        }
        
        private void dovizKalanlari()
        {
            Dictionary<string, decimal> dvzKln = new Dictionary<string, decimal>();
            decimal tut;

            foreach (AccountDataSet.AVDRow avdRow in this.accountDataSet.AVD.Rows)
            {
                if (avdRow.RowState != DataRowState.Deleted)
                {
                    tut = avdRow.DTUT;
                    if (avdRow.BA == "A")
                        tut *= -1m;
                    if (dvzKln.ContainsKey(avdRow.DDVZ))
                        dvzKln[avdRow.DDVZ] += tut;
                    else
                        dvzKln.Add(avdRow.DDVZ, tut);
                }
            }
            dvzKlnGridControl.DataSource = dvzKln;
        }

        private void dvzKlnGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colDvzKlnTut)
            {
                decimal tut = Convert.ToDecimal(view.GetListSourceRowCellValue(e.ListSourceRowIndex, colDvzKlnTut));
                if (tut > 0)
                    e.DisplayText = string.Format("{0:N2} B", tut);
                if (tut < 0)
                    e.DisplayText = string.Format("{0:N2} A", tut * -1m);
            }
        }

        private void avdGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dovizKalanlari();
        }

        private void avdGridView_RowCountChanged(object sender, EventArgs e)
        {
            
            dovizKalanlari();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (avdGridView.OptionsBehavior.Editable)
            {
                avdGridView.BeginUpdate();
                avdGridView.DeleteSelectedRows();
                avdGridView.EndUpdate();
                Save(); //Gerek Yok
            }
        }

        private void avdGridView_CustomDrawFooterCell(object sender, FooterCellCustomDrawEventArgs e)
        {
            if (e.Info.SummaryItem.Tag == null)
                return;

            if (e.Info.SummaryItem.Tag.ToString() == "aBrcKln")
            {
                decimal aBrcTop = Convert.ToDecimal(colCalcABRC.SummaryItem.SummaryValue);
                decimal aAlcTop = Convert.ToDecimal(colCalcAALC.SummaryItem.SummaryValue);
                if (aBrcTop < aAlcTop)
                    e.Info.DisplayText = string.Format("{0:N2}", (aAlcTop - aBrcTop));
                else
                    e.Info.DisplayText = "";
            }
            else if (e.Info.SummaryItem.Tag.ToString() == "aAlcKln")
            {
                decimal aBrcTop = Convert.ToDecimal(colCalcABRC.SummaryItem.SummaryValue);
                decimal aAlcTop = Convert.ToDecimal(colCalcAALC.SummaryItem.SummaryValue);
                if (aBrcTop > aAlcTop)
                    e.Info.DisplayText = string.Format("{0:N2}", (aBrcTop - aAlcTop));
                else
                    e.Info.DisplayText = "";
            }
        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPreviewToolStripMenuItem.Checked = !showPreviewToolStripMenuItem.Checked;
            avdGridView.OptionsView.ShowPreview = showPreviewToolStripMenuItem.Checked;
            colREFINFO.Visible = !showPreviewToolStripMenuItem.Checked;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = avdGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string reportHeader = string.Format("Muhasebe Fişi {0}, {1}, {2}", avbRow.AVBID, avbvGridControl.GetCellDisplayText(rowTUR, 0), avbvGridControl.GetCellDisplayText(rowTRH, 0));

            phf.Header.Content.AddRange(new string[] { "", reportHeader, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void hesapHareketleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var view = avdKlnGridView;
            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            frm.FRTid = 0;
            frm.info = string.Format("{0} • {1}", view.GetFocusedRowCellValue("HSPNO"), view.GetFocusedRowCellDisplayText("HSPNO"));
            frm.Show();

            //string HspNoS = string.Format("{0}", avdKlnGridView.GetFocusedRowCellValue(colHSPNOk));
            //showHesapHareketleri(HspNoS);
        }

        private void hesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;
            AccountRpr.AvdHstXF frm = new AccountRpr.AvdHstXF();
            frm.HspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            frm.FRTid = 0;
            frm.info = string.Format("{0} • {1}", view.GetFocusedRowCellValue("HSPNO"), view.GetFocusedRowCellDisplayText("HSPNO"));
            frm.Show();

            //string HspNoS = string.Format("{0}", avdGridView.GetFocusedRowCellValue(colHSPNO));
            //showHesapHareketleri(HspNoS);
        }

        private void showHesapHareketleri(string HspNoS)
        {
            bool panelYok = true;
            for (int i = 0; i < hesapHareketDockManager.Panels.Count; i++)
            {
                if (hesapHareketDockManager.Panels[i].Name == HspNoS)
                {
                    hesapHareketDockManager.Panels[i].Show();
                    panelYok = false;
                    break;
                }
            }

            if (panelYok)
            {
                DockPanel panel = null;
                if (hesapHareketDockManager.Panels.Count == 0)
                {
                    panel = hesapHareketDockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                    panel.FloatSize = new Size(1100, 400);
                }
                else
                {
                    bool cntYok = true;
                    for (int i = 0; i < hesapHareketDockManager.Panels.Count; i++)
                    {
                        if (hesapHareketDockManager.Panels[i].Name == "panelContainer1")
                        {
                            panel = hesapHareketDockManager.Panels[i].AddPanel();
                            cntYok = false;
                            break;
                        }
                    }
                    if (cntYok)
                    {
                        panel = hesapHareketDockManager.Panels[0].AddPanel();
                        panel.ParentPanel.Tabbed = true;        // panelContainer(DockPanel) otomatik ekleniyor
                    }
                }
                panel.Name = HspNoS;
                panel.Text = HspNoS;
                FisDetayHistoryXF frm = new FisDetayHistoryXF();
                frm.Dock = DockStyle.Fill;
                frm.iQry = string.Format("HspNo = '{0}'", HspNoS);
                panel.Controls.Add(frm);
                panel.Show();
            }
        }

        private void hesapHareketDockManager_ClosingPanel(object sender, DockPanelCancelEventArgs e)
        {
            e.Panel.Dispose();

        }

        private void tLYuvarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;

            if (!view.OptionsBehavior.Editable)
                return;
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            view.UpdateCurrentRow();

            decimal aBrcTop = Convert.ToDecimal(colCalcABRC.SummaryItem.SummaryValue);
            decimal aAlcTop = Convert.ToDecimal(colCalcAALC.SummaryItem.SummaryValue);

            if (aBrcTop == aAlcTop)
                return;
            
            // New Record
            view.AddNewRow();
            view.SetFocusedRowCellValue(colDDVZ, "TRL");
            view.SetFocusedRowCellValue(colAKUR, 1);
            view.SetFocusedRowCellValue(colHSPNO, "679.01.0002");  // Bu hesap silinmis "679.01.0052.01" yenisi 679.01.0002: Yuvarlama Farklari
            if (aBrcTop > aAlcTop)
            {
                view.SetFocusedRowCellValue(colBA, "A");
                view.SetFocusedRowCellValue(colDTUT, aBrcTop - aAlcTop);
            }
            else
            {
                view.SetFocusedRowCellValue(colBA, "B");
                view.SetFocusedRowCellValue(colDTUT, aAlcTop - aBrcTop);
            }
            
            view.UpdateCurrentRow();
        }

        private void kurYuvarlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;

            if (!view.OptionsBehavior.Editable)
                return;
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            if (view.GetFocusedRowCellDisplayText(colDDVZ) == "TRL")     // TL'nin yuvarlamasi olmaz
                return;
            
            view.UpdateCurrentRow();

            int avdID = (int)view.GetFocusedRowCellValue(colAVDID);
            string OK = accountQueriesTableAdapter.AVD_RTL_ESITLE(avdID).ToString();
            if (OK == "T")  // Update oldu Refresh
            {
                bool cbf = this.avdTableAdapter.ClearBeforeFill;
                this.avdTableAdapter.ClearBeforeFill = false;
                var aaa = this.avdTableAdapter.Fill(this.accountDataSet.AVD, avdID);  // avbID/avdID den bulabilir
                this.avdTableAdapter.ClearBeforeFill = cbf;
            }

            /* Yukaridakinin aynisi Client da yapilirsa
            var view = avdGridView;

            if (view.GetFocusedRowCellDisplayText(colDDVZ) == "TRL")     // TL'nin yuvarlamasi olmaz
                return;

            decimal aBrcTop = Convert.ToDecimal(colCalcABRC.SummaryItem.SummaryValue);
            decimal aAlcTop = Convert.ToDecimal(colCalcAALC.SummaryItem.SummaryValue);

            if (aBrcTop == aAlcTop)
                return;

            string BA = view.GetFocusedRowCellDisplayText(colBA);
            decimal dTut = view.GetFocusedRowCellValue(colDTUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colDTUT));
            decimal aTut = view.GetFocusedRowCellValue(colATUT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colATUT));
            decimal aKur = 0;

            if (BA == "B")
                aBrcTop -= aTut;
            else
                aAlcTop -= aTut;

            aTut = Math.Abs(aBrcTop - aAlcTop);
            aKur = aTut / dTut;

            view.SetFocusedRowCellValue(colAKUR, aKur);
            */

        }

        private void hesapBakiyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            string hspNo = view.GetFocusedRowCellValue(colHSPNO).ToString();
            AccHspNoBkyXF frm = new AccHspNoBkyXF(hspNo, 0);
            frm.ShowDialog();
            frm.Dispose();

            //Program.MF.HspNoBky();
            //flyoutPanel1.ShowBeakForm();
        }

        private void avdGridView_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column == colHSPNO)
                e.RepositoryItem = Program.MF.AHPrepositoryItemLookUpEdit;
        }

        private void avddGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            string hspNo = avdGridView.GetFocusedRowCellValue(colHSPNO).ToString();
            if (!hspNo.StartsWith("6") && !hspNo.StartsWith("7"))
                e.Cancel = true;
        }

        private void avddGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            avdDtyGridView.UpdateCurrentRow();
            avdGridView.SetFocusedRowCellValue(colDTUT, colTUT.SummaryItem.SummaryValue);
            avdGridView.SetFocusedRowModified();
        }

        private void avddGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;

            if (view.OptionsBehavior.Editable && view.IsDataRow(view.FocusedRowHandle))
            {
                DataRow[] dRows = avdGridView.GetDataRow(avdGridView.FocusedRowHandle).GetChildRows("AVD_AVDD");
                for (int i = 0; i < dRows.Length; i++)
                    dRows[i]["TUT"] = DBNull.Value;

                view.SetFocusedRowCellValue(colTUT, avdGridView.GetFocusedRowCellValue(colDTUT));
            }
        }

        private void avdKlnGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            compSelectedKalanTop();

        }

        private void compSelectedKalanTop()
        {
            var view = avdKlnGridView;
            int[] srh = view.GetSelectedRows();

            string dvz, ba;
            decimal dTut, tut, kur;

            hGridView.BeginUpdate();

            AccountDataSet.AVD_KALANLAR_HELPERRow hr;
            for (int k = 0; k < this.accountDataSet.AVD_KALANLAR_HELPER.Rows.Count; k++)
            {
                hr = (AccountDataSet.AVD_KALANLAR_HELPERRow)this.accountDataSet.AVD_KALANLAR_HELPER.Rows[k];
                hr.TUT = 0;
                hr.TUT2 = 0;
                hr.MIK = 0;
            }

            for (int i = 0; i < view.SelectedRowsCount; i++)
            {
                if (srh[i] >= 0) // GroupRow < 0
                {
                    ba = view.GetRowCellDisplayText(srh[i], colBAk);
                    dvz = view.GetRowCellDisplayText(srh[i], colDDVZk);
                    kur = Convert.ToDecimal(this.accountDataSet.AVD_KALANLAR_HELPER.FindByDVZ(dvz).KUR);
                    dTut = Convert.ToDecimal(view.GetRowCellValue(srh[i], colDKLNk));
                    if (ba == "A")
                        dTut = dTut * -1;
                    tut = dTut * kur;

                    for (int k = 0; k < this.accountDataSet.AVD_KALANLAR_HELPER.Rows.Count; k++)
                    {
                        hr = (AccountDataSet.AVD_KALANLAR_HELPERRow)this.accountDataSet.AVD_KALANLAR_HELPER.Rows[k];
                        hr.TUT += tut / Convert.ToDecimal(hr.KUR);
                        if (hr.DVZ == dvz)
                        {
                            hr.TUT2 += dTut;
                            hr.MIK += 1;
                        }
                    }
                }
            }
            hGridView.BestFitColumns();
            hGridView.EndUpdate();
        }

        private void kurUpdSimpleButton_Click(object sender, EventArgs e)
        {
            accountQueriesTableAdapter.AVB_UPD_AKUR(avbRow.AVBID, kurUpdDvzTextEdit.Text, Convert.ToSingle(kurUpdKurTextEdit.EditValue));
            LoadAll();
        }

        private void kurFarkFisiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;
            if (!view.OptionsBehavior.Editable)
                return;
            
            try
            {
                accountQueriesTableAdapter.ACC_KURFARK_INS(avbRow.AVBID);
                LoadAll();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "KurFark fişi oluştur");
            }
        }

        private void fisKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kapama Fisiyse, Aciksa, Editable degilse
            // KapamaFisi onaylanmis, HspNo ve Tutar secilip kapatilacak. (Tutar == FisBakiyesi olmak zorunda)
        }

        private void detayHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = avdGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            int avdID = (int)view.GetFocusedRowCellValue(colAVDID);
            FisDetayHareketXF frm = new FisDetayHareketXF();
            frm.avdID = avdID;
            frm.ShowDialog();
            //frm.Dispose();

        }

    }
}