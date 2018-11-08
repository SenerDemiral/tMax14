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

namespace tMax14.Account
{
    public partial class FaturaDetayXF : DevExpress.XtraEditors.XtraForm
    {
        private int AFBid;
        private AccountDataSet.AFBRow afbRow;

        public FaturaDetayXF(int AFBid, bool isEditable)
        {
            InitializeComponent();

            this.AFBid = AFBid;

            afbvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowFRTID.Properties.RowEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            rowHSPNO.Properties.RowEdit = Program.MF.AHPrepositoryItemLookUpEdit;
            rowDRM.Properties.RowEdit = Program.MF.AFBdrmRepositoryItemImageComboBox;
            rowEFTR.Properties.RowEdit = Program.MF.TFrepositoryItemCheckEdit;
            rowTUR.Properties.RowEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            rowTUR2.Properties.RowEdit = Program.MF.afbTUR2repositoryItemImageComboBox;
            rowTUR3.Properties.RowEdit = Program.MF.afbTUR3repositoryItemImageComboBox;
            

            Program.MF.DVTrepositoryItemLookUpEdit.Closed += DVTrepositoryItemLookUpEdit_Closed;
            Program.MF.AHTrepositoryItemLookUpEdit.Closed += AHTrepositoryItemLookUpEdit_Closed;
        }

        void DVTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            Form frm = Form.ActiveForm;

            if (a.OldEditValue != a.EditValue && afdGridControl.IsFocused && frm == this)
            {
                if (a.EditValue.ToString() == afbRow.BDVZ)
                    afdGridView.SetFocusedRowCellValue(colDKUR, afbRow.BKUR);
                else
                {
                    object trh, kur;

                    trh = afbRow.IsFTRTRHNull() ? DateTime.Today : afbRow.FTRTRH;
                    kur = accountQueriesTableAdapter.AFB_KUR(a.EditValue.ToString(), (DateTime)trh);
                    afdGridView.SetFocusedRowCellValue(colDKUR, kur);
                }
            }
        }

        void AHTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            Form frm = Form.ActiveForm;

            if (a.OldEditValue != a.EditValue && afdGridControl.IsFocused && frm == this)
            {
                object kdy = a.GetColumnValue("KDY");
                if (kdy == DBNull.Value)
                    kdy = 0;
                afdGridView.SetFocusedRowCellValue(colKDY, kdy);
            }
        }

        private void FaturaDetayXF_Load(object sender, EventArgs e)
        {
            Read();

            //this.afdGridControl.DataSource = this.accountDataSet.AFD_REC_SEL; Ozellikle yok, gereksiz toplam almasin
            Program.MF.GridControlSettings(this.afdGridControl);

            afdGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.afbTURrepositoryItemCheckedComboBoxEdit;
            colKDY.ColumnEdit = Program.MF.KDYrepositoryItemImageComboBox;
            colBRM.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            //colHSPNO.ColumnEdit = Program.MF.AHPrepositoryItemLookUpEdit;
            colHSPNO.ColumnEdit = Program.MF.AHPhspNoAdRepositoryItemLookUpEdit;  //Display

            colCompFyt.Caption += " " + afbRow.BDVZ;
            colCompTutNet.Caption += " " + afbRow.BDVZ;
            colCompTutBrt.Caption += " " + afbRow.BDVZ;



        }

        public void Save()
        {
            this.Validate();
            this.afdBindingSource.EndEdit();
            try
            {
                foreach (AccountDataSet.AFBRow row in this.accountDataSet.AFB.Rows)
                    if (row.RowState == DataRowState.Modified)
                        row.UPDUSR = Program.USR;
                    else if (row.RowState == DataRowState.Added)
                        row.INSUSR = Program.USR;
                foreach (AccountDataSet.AFDRow row in this.accountDataSet.AFD.Rows)
                    if (row.RowState == DataRowState.Modified)
                        row.UPDUSR = Program.USR;
                    else if (row.RowState == DataRowState.Added)
                        row.INSUSR = Program.USR;

                this.afbTableAdapter.Update(this.accountDataSet.AFB);
                this.afdTableAdapter.Update(this.accountDataSet.AFD);
                this.afddTableAdapter.Update(this.accountDataSet.AFDD);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaturaDetayXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            Program.MF.DVTrepositoryItemLookUpEdit.Closed -= DVTrepositoryItemLookUpEdit_Closed;
            Program.MF.AHTrepositoryItemLookUpEdit.Closed -= AHTrepositoryItemLookUpEdit_Closed;
        }

        private void Read()
        {
            afbTableAdapter.Fill(accountDataSet.AFB, string.Format("AFBid = {0}", AFBid), Program.USR);
            afbRow = accountDataSet.AFB[0];

            this.dvzSelTableAdapter.FillByTrh(this.accountDataSet.DVZ_SEL, afbRow.FTRTRH, null);
            this.afdTableAdapter.Fill(this.accountDataSet.AFD, string.Format("AFBid = {0}", afbRow.AFBID), Program.USR);
            this.afddTableAdapter.Fill(this.accountDataSet.AFDD, afbRow.AFBID, 0);

            if (afbRow.EDITABLE == "F")
                afdGridView.OptionsBehavior.Editable = false;
            else
                afdGridView.OptionsBehavior.Editable = Program.MF.YetkiCheck(afbRow.IsONYYTKNull() == true ? "" : afbRow.ONYYTK);

            //if (afbRow.DRM != "A" || !afdGridView.OptionsBehavior.Editable || !string.IsNullOrEmpty(afbRow.ONYYTK))
            if (afbRow.DRM != "A" || !afdGridView.OptionsBehavior.Editable)
            {
                Text += " [ReadOnly]";
                afbvGridControl.OptionsBehavior.Editable = false;
                afdGridView.OptionsBehavior.Editable = false;
                afdDtyGridView.OptionsBehavior.Editable = false;
            }
            if (afbRow.TUR3 == "O") // Ops Glr/Gdr dagilimi otomatik, degistirmeye izin verme
                afdDtyGridView.OptionsBehavior.Editable = false;

            if (afbRow.TUR3 == "G") // Genel ise HspNo, Ops ise Hizmet den girsin
                colAHTID.Visible = false;
            else
                colHSPNO.OptionsColumn.AllowEdit = false;

        }

        private void afdGridView_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e)
        {
            //e.Appearance.ForeColor = Color.Blue;    //Sadece ForeColor calisiyor, BackColor olmuyor
            //e.Info.DisplayText = string.Format("{0} {1:n2}", afbRow.BDVZ, e.Info.Value);
        }

        private void afdGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int AFDid = (int)accountQueriesTableAdapter.GET_PK("ACC");

            view.SetRowCellValue(e.RowHandle, colAFDID, AFDid);
            view.SetRowCellValue(e.RowHandle, colAFBID, afbRow.AFBID);
            view.SetRowCellValue(e.RowHandle, colFRTID, afbRow.FRTID);
            //view.SetRowCellValue(e.RowHandle, colDKNFRTID, afbRow.DKNFRTID);
            view.SetRowCellValue(e.RowHandle, colDDVZ, "TRL");
            view.SetRowCellValue(e.RowHandle, colDKUR, 1);
            view.SetRowCellValue(e.RowHandle, colBKUR, afbRow.BKUR);
            view.SetRowCellValue(e.RowHandle, colTUR, afbRow.TUR);
            //view.SetRowCellValue(e.RowHandle, colCPZKUR, (double)1 / afbRow.KUR);
            view.SetRowCellValue(e.RowHandle, colKDY, 0);
            view.SetRowCellValue(e.RowHandle, colDFYT, 0);
            view.SetRowCellValue(e.RowHandle, colMIK, 1);

            this.afddTableAdapter.ClearBeforeFill = false;
            this.afddTableAdapter.Fill(this.accountDataSet.AFDD, afbRow.AFBID, AFDid);

        }

        private void topTutRepositoryItemTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            // Kullanilmiyor!!!
            /*
            DevExpress.XtraEditors.TextEdit te = sender as DevExpress.XtraEditors.TextEdit;
            string aaa = te.Text;
            double topTut = 0;
            if (!string.IsNullOrWhiteSpace(te.Text))
                topTut = Convert.ToDouble(te.Text);
            double kdy = afdGridView.GetFocusedRowCellValue(colKDY) == DBNull.Value ? 0 : Convert.ToDouble(afdGridView.GetFocusedRowCellValue(colKDY));
            double mik = afdGridView.GetFocusedRowCellValue(colMIK) == DBNull.Value ? 0 : Convert.ToDouble(afdGridView.GetFocusedRowCellValue(colMIK));
            //double orgFyt = afdlGridView.GetFocusedRowCellValue(colORGFYTd) == DBNull.Value ? 0 : Convert.ToDouble(afdlGridView.GetFocusedRowCellValue(colORGFYTd));
            double orgKur = afdGridView.GetFocusedRowCellValue(colDKUR) == DBNull.Value ? 0 : Convert.ToDouble(afdGridView.GetFocusedRowCellValue(colDKUR));
            double ftrKur = afdGridView.GetFocusedRowCellValue(colBKUR) == DBNull.Value ? 0 : Convert.ToDouble(afdGridView.GetFocusedRowCellValue(colBKUR));
            double orgFyt = topTut / (orgKur / ftrKur * mik * (1.00 + kdy / 100.00));
            afdGridView.SetFocusedRowCellValue(colDFYT, orgFyt);
            //afdlGridView.PostEditor();
             */
        }

        private void afddGridControl_Leave(object sender, EventArgs e)
        {
            /*
            //decimal fyt = Convert.ToDecimal(colFYT.SummaryItem.SummaryValue);
            afddGridView.UpdateCurrentRow();

            decimal tutNet = Convert.ToDecimal(colFYTm.SummaryItem.SummaryValue);    // AFDD.Fyt aslinda Tutar!!!!
            decimal mik = afdGridView.GetFocusedRowCellValue(colMIK) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetFocusedRowCellValue(colMIK));
            decimal dKur = afdGridView.GetFocusedRowCellValue(colDKUR) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetFocusedRowCellValue(colDKUR));
            decimal bKur = afdGridView.GetFocusedRowCellValue(colBKUR) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetFocusedRowCellValue(colBKUR));
            decimal dFyt = tutNet / (mik * dKur / bKur);
            afdGridView.SetFocusedRowCellValue(colDFYT, dFyt);
            
            afdGridView.SetFocusedRowModified();*/
        }

        private void afddGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            { 
                string tur = view.GetRowCellValue(e.RowHandle, colTURm).ToString();
                if ( tur == "-")
                {
                    e.Appearance.ForeColor = Color.White;
                    e.Appearance.BackColor = Color.Coral;
                }
                else if (tur == "K")    //KarMerkezi
                {
                    e.Appearance.ForeColor = Color.Red;
                    //e.Appearance.BackColor = Color.Coral;
                }
                else if (tur == "M")    //MasrafMerkezi
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

        private void afdGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.Column == colOPID)
                e.DisplayText = string.Format("{0:N0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colOPHM));
        }

        private void afddGridControl_Enter(object sender, EventArgs e)
        {/*
            if (afdGridView.IsEditing)
            {
                afdGridView.CloseEditor();
                afdGridView.UpdateCurrentRow();
            }*/
        }

        private void afbvGridControl_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (afdGridView.OptionsBehavior.Editable)
                afdGridControl.Enabled = false;
            
            if (afbvGridControl.FocusedRow == rowTUR3 && afbvGridControl.GetCellValue(rowOPID, 0) != DBNull.Value)
                e.Cancel = true;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
        }

        private void afdGridView_CustomRowCellEditForEditing(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column == colHSPNO)
                e.RepositoryItem = Program.MF.AHPrepositoryItemLookUpEdit;
        }

        private void repositoryItemCalcEdit_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void afddGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void afdGridView_HiddenEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            //if (view.FocusedColumn == col    
            
        }

        private void afdGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!afdGridView.IsFocusedView)
                return;

            //if (!afdGridView.IsFocusedView)
            //    return;

            if (e.Column != colCompTutNet &&
                e.Column != colDFYT &&
                e.Column != colDKUR &&
                e.Column != colMIK)
                return;

            //decimal tutNet = afdGridView.GetRowCellValue(e.RowHandle, colCompTutNet) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetRowCellValue(e.RowHandle, colCompTutNet));
            decimal dFyt = afdGridView.GetRowCellValue(e.RowHandle, colDFYT) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetRowCellValue(e.RowHandle, colDFYT));
            decimal Mik = afdGridView.GetRowCellValue(e.RowHandle, colMIK) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetRowCellValue(e.RowHandle, colMIK));
            decimal dTut = dFyt * Mik;

            int foundIndex = -1;
            int cnt = 0;
            if (dTut != (decimal)colFYTm.SummaryItem.SummaryValue)
            {
                AccountDataSet.AFDDRow[] dRows = afdGridView.GetDataRow(e.RowHandle).GetChildRows("AFD_AFDD") as AccountDataSet.AFDDRow[];
                for (int i = 0; i < dRows.Length; i++)
                    if (!dRows[i].IsFYTNull())
                    {
                        cnt++;
                        foundIndex = i;
                    }

                if (cnt == 1)   // 1 tane bulundu Fiyati buna koy
                    dRows[foundIndex].FYT = dTut; //dFyt;
                else
                {
                    for (int i = 0; i < dRows.Length; i++)
                        dRows[i]["FYT"] = DBNull.Value;
                    dRows[0].FYT = dTut; // dFyt;
                }
            }
        }

        private void repositoryItemCalcEdit_Leave(object sender, EventArgs e)
        {

        }

        private void afddGridView_HiddenEditor(object sender, EventArgs e)
        {
            var view = afdGridView;
            var viewDty = afdDtyGridView;
            object aaa = viewDty.GetRowCellValue(0, colFYTm);

            viewDty.SetRowCellValue(0, colFYTm, null);
            viewDty.UpdateCurrentRow();
            
            decimal dTut = Convert.ToDecimal(colFYTm.SummaryItem.SummaryValue);    // AFDD.Fyt aslinda Tutar!!!!
            decimal mik = view.GetFocusedRowCellValue(colMIK) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colMIK));
            //decimal dKur = view.GetFocusedRowCellValue(colDKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colDKUR));
            //decimal bKur = view.GetFocusedRowCellValue(colBKUR) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colBKUR));
            //decimal dFyt = Math.Round(tutNet / (mik * dKur / bKur), 4);
            decimal dFyt = Math.Round(dTut / mik, 4);
            view.SetFocusedRowCellValue(colDFYT, dFyt);

            //afdGridView.SetFocusedRowCellValue(colDFYTd, colFYT.SummaryItem.SummaryValue);
            view.SetFocusedRowModified();

        }

        private void afddGridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;

            if (view.OptionsBehavior.Editable && view.IsDataRow(view.FocusedRowHandle))
            {
                DataRow[] dRows = afdGridView.GetDataRow(afdGridView.FocusedRowHandle).GetChildRows("AFD_AFDD");
                for (int i = 0; i < dRows.Length; i++)
                    dRows[i]["FYT"] = DBNull.Value;

                decimal dFyt = afdGridView.GetFocusedRowCellValue(colDFYT) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetFocusedRowCellValue(colDFYT));
                decimal Mik = afdGridView.GetFocusedRowCellValue(colMIK) == DBNull.Value ? 0 : Convert.ToDecimal(afdGridView.GetFocusedRowCellValue(colMIK));
                decimal dTut = dFyt * Mik;
                
                view.SetFocusedRowCellValue(colFYTm, dTut);
                //view.SetFocusedRowCellValue(colFYT, afdGridView.GetFocusedRowCellValue(colDFYTd));
            }
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void kDVAyiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afdGridView;
            view.CloseEditor();
            decimal kdy = view.GetFocusedRowCellValue(colKDY) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colKDY));
            decimal dFyt = view.GetFocusedRowCellValue(colDFYT) == DBNull.Value ? 0 : Convert.ToDecimal(view.GetFocusedRowCellValue(colDFYT));
            if (kdy != 0)
            {
                view.SetFocusedRowCellValue(colDFYT, dFyt / (kdy / 100 + 1));
                //view.UpdateCurrentRow();  Ozellikle yok Esc ile vazgecebilmesi icin
            }

        }

    }
}