using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Ops
{
    public partial class opHouseEditXF : DevExpress.XtraEditors.XtraForm
    {
        public int PK = 0;
        Dictionary<string, string> OzlDrm = new Dictionary<string, string>();
        public dynamic orgForm;
        private bool editable = false;
        public bool iE = false, aE = false;

        public opHouseEditXF()
        {
            InitializeComponent();

            ophLayoutView.OptionsCustomization.AllowFilter = false;
            ophLayoutView.OptionsCustomization.AllowSort = false;

            oph2LayoutView.OptionsCustomization.AllowFilter = false;
            oph2LayoutView.OptionsCustomization.AllowSort = false;
            /*
                        ophLayoutView.Appearance.FieldCaption.ForeColor = Color.Coral;
                        ophLayoutView.Appearance.FieldCaption.Options.UseForeColor = true;
                        ophLayoutView.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
                        ophLayoutView.OptionsSingleRecordMode.CardAlignment = DevExpress.XtraGrid.Views.Layout.CardsAlignment.Center;
                        ophLayoutView.OptionsSingleRecordMode.StretchCardToViewHeight = true;
                        ophLayoutView.OptionsSingleRecordMode.StretchCardToViewWidth = true;
                        ophLayoutView.OptionsView.ShowCardCaption = true;
                        ophLayoutView.CardCaptionFormat = "Export";
                        ophLayoutView.OptionsView.ShowHeaderPanel = false;
                        ophLayoutView.OptionsView.ShowCardFieldBorders = true;
                        ophLayoutView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                        */
            ophGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit; //Program.MF.locRepositoryItemPopupContainerEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colMNFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDCNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNFYID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNF2ID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAGNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colHSRFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colPRJID.ColumnEdit = Program.MF.PRTrepositoryItemSearchLookUpEdit;

            colRCPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDLVID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colNSTU.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colPSTU.ColumnEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;
            
            colDTM.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colDTP.ColumnEdit = Program.MF.DTPrepositoryItemLookUpEdit;
            colPTM.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colPOR.ColumnEdit = Program.MF.PORrepositoryItemLookUpEdit;
            colTOL.ColumnEdit = Program.MF.TOLrepositoryItemLookUpEdit;
            colTOS.ColumnEdit = Program.MF.TOSrepositoryItemLookUpEdit;
            //colPAG.ColumnEdit = Program.MF.PAGrepositoryItemLookUpEdit;
            colPAG.ColumnEdit = Program.MF.PAGrepositoryItemCheckedComboBoxEdit;
            colTUS.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colOWNR.ColumnEdit = Program.MF.OWNRrepositoryItemImageComboBox;
            colITOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;

            colTRO.ColumnEdit = Program.MF.OpsTrOrepositoryItemCheckedComboBoxEdit; //OpsTrOrepositoryItemLookUpEdit;
            colTRS.ColumnEdit = Program.MF.OpsTrSrepositoryItemCheckedComboBoxEdit; //OpsTrSrepositoryItemLookUpEdit;

            colMALBDLDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            //colLM_TS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colWBD.ColumnEdit = Program.MF.trhRepositoryItemDateEdit;
            colRRT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colEOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colONYTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colDRBD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDPOGIRTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDPOCIKTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colDRBD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDRCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colTAGS.ColumnEdit = Program.MF.TAGselOPSrepositoryItemCheckedComboBoxEdit;
            colARP.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colCUSLOC.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colVGM.ColumnEdit = Program.MF.OphVGMrepositoryItemImageComboBox;

            oppGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTOPp.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;

            afdoGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTURf.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colFRTIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNFRTIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTIDf.ColumnEdit = Program.MF.AHThouseRepositoryItemGridLookUpEdit;  //Program.MF.AHThouseRepositoryItemLookUpEdit;
            colDDVZf.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBRMf.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colOPACCIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            oph2GridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            //colCCC2.ColumnEdit = Program.MF.B_CCCrepositoryItemCheckedComboBoxEdit;
            
            colSMPTYP2.ColumnEdit = Program.MF.BSMPTYPrepositoryItemLookUpEdit;
            colB_BOXTYP.ColumnEdit = Program.MF.BBOXTYPrepositoryItemLookUpEdit;
            colCCC2.ColumnEdit = Program.MF.BCCCrepositoryItemCheckedComboBoxEdit;

            Program.MF.FRTrepositoryItemLookUpEdit.Closed += FRTrepositoryItemLookUpEdit_Closed;
            Program.MF.locRepositoryItemPopupContainerEdit.Closed += locRepositoryItemPopupContainerEdit_Closed;
            Program.MF.PRTrepositoryItemSearchLookUpEdit.Closed += PRTrepositoryItemSearchLookUpEdit_Closed;
            Program.MF.AHTrepositoryItemLookUpEdit.Closed += AHTrepositoryItemLookUpEdit_Closed;
            Program.MF.AHThouseRepositoryItemGridLookUpEdit.Closed += AHThouseRepositoryItemGridLookUpEdit_Closed;
            Program.MF.GridControlSettings(oppGridControl);
            Program.MF.GridControlSettings(opoGridControl);
            Program.MF.GridControlSettings(afdoGridControl);

            //ophLayoutView.OptionsBehavior.Editable = Program.MF.CanUserDo("Ops.opHouseEditXF", "UPD", isSilent: true);
            editable = Program.MF.ModifyCheck("Ops.opHouseEditXF", isSilent: false);

        }

        void AHThouseRepositoryItemGridLookUpEdit_Closed(object sender, ClosedEventArgs e)
        {
            if (e.CloseMode == PopupCloseMode.Normal && afdoGridControl.IsFocused)
            {
                var a = sender as GridLookUpEdit;

                if (a.OldEditValue != a.EditValue)
                {
                    DataRow row = (a.GetSelectedDataRow() as DataRowView).Row;
                    var kdy = row["KDY"];
                    afdoGridView.SetFocusedRowCellValue(colKDYf, kdy);
                }
            }
        }

        void AHTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;

            if (a.OldEditValue != a.EditValue && afdoGridControl.IsFocused)
            {
                object kdy = a.GetColumnValue("KDY");
                afdoGridView.SetFocusedRowCellValue(colKDYf, kdy);
            }
        }
        
        void FRTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (ophGridControl.IsFocused)
            {
                var a = sender as LookUpEdit;
                if (a.EditValue != DBNull.Value)
                {
                    string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("FRT", a.EditValue.ToString()).ToString();
                    ophLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                    OzlDrm[ophLayoutView.FocusedColumn.FieldName] = ozlDrm;
                }
            }
        }

        public void Save()  // Main kullaniyor
        {
        }

        void locRepositoryItemPopupContainerEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (ophGridControl.IsFocused)
            {
                var a = sender as PopupContainerEdit;

                string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("LOC", a.EditValue.ToString()).ToString();
                ophLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                OzlDrm[ophLayoutView.FocusedColumn.FieldName] = ozlDrm;
            }
        }

        void frtRepositoryItemSearchLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            // IPTAL
            if (ophGridControl.IsFocused)
            {
                var a = sender as SearchLookUpEdit;
                if (a.EditValue != DBNull.Value)
                {
                    string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("FRT", a.EditValue.ToString()).ToString();
                    ophLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                    OzlDrm[ophLayoutView.FocusedColumn.FieldName] = ozlDrm;
                }
            }
        }

        void PRTrepositoryItemSearchLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (ophGridControl.IsFocused && e.CloseMode == PopupCloseMode.Normal)
            {
                var a = sender as SearchLookUpEdit;
                string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("PRT", a.EditValue.ToString()).ToString();
                ophLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                OzlDrm[ophLayoutView.FocusedColumn.FieldName] = ozlDrm;
            }
        }


        private void ophLayoutView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            if (e.FocusedColumn == null)
                return;
            
            if (view.IsFocusedView && OzlDrm.ContainsKey(e.FocusedColumn.FieldName) && e.FocusedColumn != colOzlDrm)
            {
                view.SetFocusedRowCellValue(colOzlDrm, OzlDrm[e.FocusedColumn.FieldName]);
            }
        }

        private void ophLayoutView_CustomFieldCaptionStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewFieldCaptionStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;
            if (OzlDrm.ContainsKey(e.Column.FieldName) && e.Column != colOzlDrm && !string.IsNullOrWhiteSpace(OzlDrm[e.Column.FieldName]))
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void opHouesEditXF_Load(object sender, EventArgs e)
        {
            LoadAll();
        }
        
        private void LoadAll()
        {
            opsDataSet.Clear();
            OzlDrm.Clear();

            if (PK == 0) // New
            {
                newRecord();
                return;
            }

            this.ophTableAdapter.FillByPK(this.opsDataSet.OPH, PK);     // House
            this.oppTableAdapter.FillByOP(this.opsDataSet.OPP, PK);     // Packages
            this.opshTableAdapter.FillByOP(this.opsDataSet.OPSH, PK);   // StatuHistory
            this.opoTableAdapter.FillByOP(this.opsDataSet.OPO, PK);     // Orders
            this.oprhSelDisTableAdapter.Fill(this.opsDataSet.OPRH_SEL_DIS, 0, PK);   //GidenEvrak

            if (Program.MF.EntryCheck("Ops.opHouseEditXF.afdoDP", isSilent: true))
                this.afdoTableAdapter.Fill(this.opsDataSet.AFDO_SEL, string.Format("OPid = {0}", PK), Program.USR);   // FaturaDetay
            afdoGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Ops.opHouseEditXF.afdoDP", isSilent: true);

            this.oposTableAdapter.ClearBeforeFill = false;
            foreach (OpsDataSet.OPORow opoRow in this.opsDataSet.OPO.Rows)
            {
                this.oposTableAdapter.FillByOPO(this.opsDataSet.OPOS, opoRow.OPOID);    // Order SKU's
            }

            OpsDataSet.OPHRow ophRow = (OpsDataSet.OPHRow)this.opsDataSet.OPH.Rows[0];

            if (ophRow != null && !ophRow.IsOPMIDNull())
            {
                this.opmpTableAdapter.Fill(this.opsDataSet.OPM_PACKAGES, ophRow.OPMID);     // Master Packages
                this.opcLupMTableAdapter.Fill(this.opsDataSet.OPC_LUP_M, ophRow.OPMID);
            }

            ////this.oph2TableAdapter.FillByPK(this.opsDataSet.OPH2, PK);     // OPH+
            //OpsDataSet.OPH2Row oph2Row = opsDataSet.OPH2.NewOPH2Row();
            //oph2Row.OPHID = PK;
            //opsDataSet.OPH2.AddOPH2Row(oph2Row);

            foreach (DataColumn dataCol in this.opsDataSet.OPH.Columns)
                OzlDrm.Add(dataCol.ColumnName, "");

            OzelDrmAddDict("LOC", ophRow, this.opsDataSet.OPH.ORGColumn);
            OzelDrmAddDict("LOC", ophRow, this.opsDataSet.OPH.DSTColumn);

            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.SHPIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.MNFIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.CNEIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.CRRIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.DCNIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.NFYIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.NF2IDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.ACCIDColumn);
            OzelDrmAddDict("FRT", ophRow, this.opsDataSet.OPH.HSRFIDColumn);

            OzelDrmAddDict("PRT", ophRow, this.opsDataSet.OPH.PRJIDColumn);

            //string islYtkCur, accYtkCur;
            //Program.MF.IslAccCurYtk("H", PK, out islYtkCur, out accYtkCur);
            //bool ytkOK = Program.MF.YetkiCheck(islYtkCur, true);
            //bool accYtkOK = Program.MF.YetkiCheck(accYtkCur, true);

            ophLayoutView.OptionsBehavior.Editable = editable && iE; // ytkOK;
            oph2LayoutView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Ops.opHouseEditXF.bioDP", isSilent: true) && iE;
            oppGridView.OptionsBehavior.Editable = editable && iE;
            opoGridView.OptionsBehavior.Editable = editable && iE;
            oposGridView.OptionsBehavior.Editable = editable && iE;
            afdoGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Ops.opHouseEditXF.afdoDP", isSilent: true) && aE; // accYtkOK;

            godInfMemoEdit.Enabled = editable && iE;
            hndInfMemoEdit.Enabled = editable && iE;
            othInfMemoEdit.Enabled = editable && iE;
            accInfMemoEdit.Enabled = editable && iE;
        }

        private void OzelDrmAddDict(string tbl, OpsDataSet.OPHRow ophRow, DataColumn dataCol)
        {
            string ozlDrm;

            if (!ophRow.IsNull(dataCol))
            {
                ozlDrm = opsQueriesTableAdapter.OZEL_DURUM(tbl, ophRow[dataCol].ToString()).ToString();
                OzlDrm[dataCol.ColumnName] = ozlDrm;
            }
        }

        private DialogResult SaveAll()
        {
            DialogResult dr = System.Windows.Forms.DialogResult.Yes;

            if (!this.Validate())
                return System.Windows.Forms.DialogResult.Cancel;

            this.ophBindingSource.EndEdit();
            if (this.opsDataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "OpsHouse Edit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (OpsDataSet.AFDO_SELRow row in this.opsDataSet.AFDO_SEL.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                            row.UPDUSR = Program.USR;
                        else if (row.RowState == DataRowState.Added)
                        {
                            row.AFBID = 0;  //Insert/Duplice Faturaya tasima
                            row.INSUSR = Program.USR;
                        }
                    }
                    try
                    {
                        this.ophTableAdapter.Update(this.opsDataSet.OPH);   // Ilk Master kaydi yazdir, UpdateAll bilmiyor
                        this.tableAdapterManager.UpdateAll(this.opsDataSet);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Kayıt");
                    }
                    orgForm.refreshRow(PK);
                }
            }
            return dr;
        }

        private void opHouseEditXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = System.Windows.Forms.DialogResult.Yes;
            
            //if (!this.Validate())
            //{
            //    dr = XtraMessageBox.Show("Hata var! Kaydetmeden çıkmak istiyormusunuz?", "OpsHouse Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dr == DialogResult.Yes)
            //        e.Cancel = false;
            //    return;
            //}

            dr = SaveAll();
            if (dr != System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false;
                Program.MF.FRTrepositoryItemLookUpEdit.Closed -= FRTrepositoryItemLookUpEdit_Closed;
                Program.MF.locRepositoryItemPopupContainerEdit.Closed -= locRepositoryItemPopupContainerEdit_Closed;
                Program.MF.PRTrepositoryItemSearchLookUpEdit.Closed -= PRTrepositoryItemSearchLookUpEdit_Closed;
                Program.MF.AHTrepositoryItemLookUpEdit.Closed -= AHTrepositoryItemLookUpEdit_Closed;
            }
        }

        private void yeniHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = SaveAll();
            if (dr != System.Windows.Forms.DialogResult.Cancel)
            {
                newRecord();
            }
        }

        private void newRecord()
        {
            if (editable)
            {
                ophLayoutView.BeginDataUpdate();
                opsDataSet.Clear();
                ophLayoutView.EndDataUpdate();
                ophLayoutView.AddNewRow();                
                
                /*
                ophLayoutView.BeginDataUpdate();
                opsDataSet.Clear();

                OpsDataSet.OPHRow ophRow = opsDataSet.OPH.NewOPHRow();

                PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
                ophRow.OPHID = PK;
                ophRow.NSTU = "B";  // Booking
                ophRow.TOB = "O";   // Ops
                ophRow.OWNR = "1";  // Merkez
                ophRow.FPT = "C";
                opsDataSet.OPH.AddOPHRow(ophRow);
                ophLayoutView.EndDataUpdate();
                 */
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAll() == System.Windows.Forms.DialogResult.Yes)
                LoadAll();
        }

        private void ophLayoutView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        
        private void ophLayoutView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            view.SetRowCellValue(e.RowHandle, colOPHID, PK);
            view.SetRowCellValue(e.RowHandle, colFPT, "C");    // ModeofFreightPayment Collect*/
            view.SetRowCellValue(e.RowHandle, colNSTU, "B");    // Booking
            view.SetRowCellValue(e.RowHandle, colTOB, "O");    // Ops
            view.SetRowCellValue(e.RowHandle, colOWNR, "1");    // Merkez

        }

        private void opoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPOIDo, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));
            view.SetRowCellValue(e.RowHandle, colOPIDo, PK);
        }

        private void oposGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPOSIDos, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));
        }

        private void oppGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPPIDp, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));
            view.SetRowCellValue(e.RowHandle, colOPIDp, PK);
            view.SetRowCellValue(e.RowHandle, colHMp, "H");
            view.SetRowCellValue(e.RowHandle, colSTACKABLE, "T");
            view.SetRowCellValue(e.RowHandle, colTURNABLE, "T");
        }

        private void afdoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colAFDIDf, Program.MF.mainQueriesTableAdapter.GET_PK("ACC"));
            view.SetRowCellValue(e.RowHandle, colAFBIDf, null);
            view.SetRowCellValue(e.RowHandle, colOPIDf, PK);
            view.SetRowCellValue(e.RowHandle, colOPHMf, "H");
            view.SetRowCellValue(e.RowHandle, colTURf, "BS");   // Satis
            view.SetRowCellValue(e.RowHandle, colKDYf, 0);
            view.SetRowCellValue(e.RowHandle, colMIKf, 1);
            view.SetRowCellValue(e.RowHandle, colDDVZf, "TRL");
        }

        private void ophLayoutView_HiddenEditor(object sender, EventArgs e)
        {
        }

        private void ophLayoutView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            e.Valid = true;
        }

        private void tabbedControlGroup1_DoubleClick(object sender, EventArgs e)
        {
            //layoutViewField_colCBRID.OptionsToolTip.ToolTip = "22222222222";

            //.ophLayoutView.TemplateCard.BeginUpdate();
            //colCBRID.LayoutViewField.OptionsToolTip.ToolTip = "555555";
            //colMNFID.LayoutViewField.OptionsToolTip.ToolTip = "666666666666666";
            //ophLayoutView.TemplateCard.EndUpdate();
        }

        private void ophLayoutView_MouseEnter(object sender, EventArgs e)
        {

        }

        private void ophLayoutView_MouseMove(object sender, MouseEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            DevExpress.XtraGrid.Views.Layout.ViewInfo.LayoutViewHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (hitInfo.InCard &&  hitInfo.InFieldCaption) //hitInfo.Column == colCBRID)
            {
                //toolTipController1.HideHint();

                //toolTipController1.ShowHint(hitInfo.Column.FieldName, "dfa", DevExpress.Utils.ToolTipLocation.BottomCenter); //textBox1, DevExpress.Utils.ToolTipLocation.RightCenter);
                //this.Text = hitInfo.HitTest.ToString();
                //view.SetFocusedRowCellValue(colOzlDrm, (hitInfo.Column as DevExpress.XtraGrid.Columns.LayoutViewColumn).LayoutViewField.OptionsToolTip.ToolTip);
            }
               
        }

        private void toolTipController1_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {/*
            if (e.Info == null && e.SelectedControl == ophGridControl)
            {
                DevExpress.XtraGrid.Views.Layout.LayoutView view = ophGridControl.FocusedView as DevExpress.XtraGrid.Views.Layout.LayoutView;
                DevExpress.XtraGrid.Views.Layout.ViewInfo.LayoutViewHitInfo info = view.CalcHitInfo(e.ControlMousePosition);
                if (info.InField)
                {
                    string text = view.GetRowCellDisplayText(info.RowHandle, info.Column);
                    string cellKey = info.Column.FieldName;//info.RowHandle.ToString() + " - " + info.Column.ToString();
                    e.Info = new DevExpress.Utils.ToolTipControlInfo(cellKey, text);
                    
                }
            }*/
        }

        private void ophLayoutView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            int v2w = view.GetFocusedRowCellValue(colV2W) == DBNull.Value ? -1 : Convert.ToInt32(view.GetFocusedRowCellValue(colV2W));

            if (view.FocusedColumn == colCHW && v2w != 0)
                e.Cancel = true;
        }

        private void oph2DockPanel_Expanded(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            //if (this.opsDataSet.OPH2.Count == 0)
            //    oph2LayoutView.AddNewRow();
        }

        private void bioDockPanel_Enter(object sender, EventArgs e)
        {
            /*
            if (opsDataSet.OPH2.Count == 0)
            {
                OpsDataSet.OPH2Row oph2Row = opsDataSet.OPH2.NewOPH2Row();
                oph2Row.OPHID = PK;
                opsDataSet.OPH2.AddOPH2Row(oph2Row);
            }
            */
        }

        private void oppGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colDIMSp)
            {
                string val = e.Value.ToString().Replace(" ", "");
                int L, W, H, N, tN = 0;
                decimal tV = 0;
                string[] lines = val.Split(new char[] { '+', ' ' });
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] dims = line.Split(new char[] { '*', 'x' });
                        L = Convert.ToInt32(dims[0]);
                        W = Convert.ToInt32(dims[1]);
                        H = Convert.ToInt32(dims[2]);
                        N = Convert.ToInt32(dims[3].Trim(new char[] { '#', 'N' }));
                        tN += N;
                        tV += L * W * H * N;
                    }
                }

                oppGridView.SetFocusedRowCellValue(colNOPp, tN);
                //tV /= 1000000m;
                tV = Math.Round(tV / 1000000m, 2, MidpointRounding.AwayFromZero);
                oppGridView.SetFocusedRowCellValue(colCVM3p, tV );
                oppGridView.SetFocusedRowCellValue(colVM3p, tV);
            }
        }

        private void oppGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.FocusedColumn.FieldName == "NOP")
            {
                if (!string.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(colDIMSp)))
                    e.Cancel = true;
            }

        }


        private void DIMSrepositoryItemPopupContainerEdit_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            //e.Value = DIMSmemoEdit.EditValue;
        }

        private void DIMSrepositoryItemPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            //DIMSmemoEdit.EditValue = (sender as PopupContainerEdit).EditValue;
        }

        private void hideContainerBottom_Click(object sender, EventArgs e)
        {

        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editable)
                return;

            SaveAll();
            int dHid = (int)opsQueriesTableAdapter.OPH_DUP(PK);
            if (dHid != 0)
            {
                iE = true;
                aE = true;
                PK = dHid;
                LoadAll();
            }
        }

        private void GridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (e.Column.FieldName == "Editable" && e.IsGetData)
            {
                e.Value = true;
                //e.Value = ophLayoutView.GetFocusedRowCellDisplayText(colEDITABLEISL) == "T" ? true : false; 
            }
        }

        private void ophLayoutView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;
            
            view.ClearColumnErrors();

            object ROT = view.GetRowCellValue(e.RowHandle, colROT);
            object MOT = view.GetRowCellValue(e.RowHandle, colMOT);
            object ACCID = view.GetRowCellValue(e.RowHandle, colACCID);
            object EOH = view.GetRowCellValue(e.RowHandle, colEOH);

            if (ROT == DBNull.Value)
            {
                view.SetColumnError(colROT, "Boş");
                e.Valid = false;
            }

            if (MOT == DBNull.Value)
            {
                view.SetColumnError(colMOT, "Boş");
                e.Valid = false;
            }

            if (e.Valid && ROT.ToString() == "E" && ACCID == DBNull.Value)
            {
                view.SetColumnError(colACCID, "Boş");
                e.Valid = false;
            }

            if (e.Valid && ROT.ToString() == "E" && view.GetRowCellValue(e.RowHandle, colEOH) == DBNull.Value)
            {
                view.SetColumnError(colEOH, "Boş");
                e.Valid = false;
            }

            if (e.Valid && ROT.ToString() == "I" && ACCID != DBNull.Value && EOH == DBNull.Value)
            {
                view.SetColumnError(colEOH, "Boş");
                e.Valid = false;
            }
        }

        private void afdoGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.FocusedRowHandle >= 0)
            {
                if (view.GetFocusedRowCellValue(colAFBIDf) != DBNull.Value || (int)view.GetFocusedRowCellValue("AFDID") < 0)
                    e.Cancel = true;    // FaturaBasligi varsa IPTAL(AFDid<0) ise degistirtme
                else
                    if (view.GetFocusedDataRow().RowState != DataRowState.Added)    // Yeni eklenen disinda FRTid ve AHTid degistirilmesin
                    {
                        if (view.FocusedColumn.FieldName == "FRTID" || view.FocusedColumn.FieldName == "AHTID" || view.FocusedColumn.FieldName == "TUR")
                            e.Cancel = true;
                    }
            }
        }

        private void afdoIptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = afdoGridView;

            if (view.IsDataRow(view.FocusedRowHandle) && (int)view.GetFocusedRowCellValue("AFDID") > 0)
            {
                string iptInfo = afdoIptalInfoToolStripTextBox.Text;
                if (iptInfo.StartsWith("?") || iptInfo.Length < 10)
                {
                    XtraMessageBox.Show("Iptal sebebi girin", "Charge Iptal");
                    return;
                }

                int afdID = (int)view.GetFocusedRowCellValue("AFDID");
                if (afdID > 0)
                {
                    string msj = opsQueriesTableAdapter.AFD_IPT(afdID, iptInfo, Program.USR).ToString();
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
            /*
            if (afdoGridView.IsDataRow(afdoGridView.FocusedRowHandle))
            {
                string iptInfo = afdoIptalInfoToolStripTextBox.Text;
                if (iptInfo.StartsWith("?") || iptInfo.Length < 10)
                {
                    XtraMessageBox.Show("Iptal sebebi girin", "Charge Iptal");
                    return;
                }

                int afdID = (int)afdoGridView.GetFocusedRowCellValue("AFDID");
                if (afdID > 0)
                {
                    string msj = opsQueriesTableAdapter.AFD_IPT(afdID, iptInfo, Program.USR).ToString();
                    if (msj == "")
                    {
                        var afdoRow = opsDataSet.AFDO_SEL.FindByAFDID(afdID);
                        this.opsDataSet.AFDO_SEL.Rows.Remove(afdoRow);
                        this.afdoTableAdapter.ClearBeforeFill = false;
                        this.afdoTableAdapter.Fill(this.opsDataSet.AFDO_SEL, string.Format("AFDID = -{0}", afdID));   // Account (Nagetif AFDid Iptal demek)
                        this.afdoTableAdapter.ClearBeforeFill = true;
                    }
                    else
                        XtraMessageBox.Show(msj, "Charge Iptal");
                }
            }*/
        }

        private void afdoGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (afdoGridView.GetRowCellValue(e.RowHandle, "TUR") == DBNull.Value)
            {
                e.ErrorText = "Tür girilmemiş.!\n";
                e.Valid = false;
            }
            else if (afdoGridView.GetRowCellValue(e.RowHandle, "TUR").ToString().Substring(1, 1) == "D" && afdoGridView.GetRowCellValue(e.RowHandle, "DKNFRTID") == DBNull.Value)
            {
                e.ErrorText = "Dekont Firma girilmemiş.!\n";
                e.Valid = false;
            }
            else if (afdoGridView.GetRowCellValue(e.RowHandle, "FRTID") == DBNull.Value)
            {
                e.ErrorText = "Firma girilmemiş.!\n";
                e.Valid = false;
            }
            else if (afdoGridView.GetRowCellValue(e.RowHandle, "AHTID") == DBNull.Value)
            {
                e.ErrorText = "Charge girilmemiş.!\n";
                e.Valid = false;
            }
        }

        private void rcpAdrRepositoryItemPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            int ShpID = ophLayoutView.GetFocusedRowCellValue(colSHPID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colSHPID));
            int MnfID = ophLayoutView.GetFocusedRowCellValue(colMNFID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colMNFID));
            int CneID = ophLayoutView.GetFocusedRowCellValue(colCNEID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colCNEID));

            frlGetTableAdapter.Fill(opsDataSet.FRL_GET, ShpID, MnfID, CneID);
        }

        private void rcpAdrRepositoryItemPopupContainerEdit_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
            e.Value = rcpAdrGridView.GetFocusedRowCellValue(colADRESrcp);

        }

        private void rcpAdrGridView_DoubleClick(object sender, EventArgs e)
        {
            rcpAdrPopupContainerControl.OwnerEdit.ClosePopup();
        }

        private void dlvAdrRepositoryItemPopupContainerEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            int ShpID = ophLayoutView.GetFocusedRowCellValue(colSHPID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colSHPID));
            int MnfID = ophLayoutView.GetFocusedRowCellValue(colMNFID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colMNFID));
            int CneID = ophLayoutView.GetFocusedRowCellValue(colCNEID) == DBNull.Value ? 0 : Convert.ToInt32(ophLayoutView.GetFocusedRowCellValue(colCNEID));

            frlGetTableAdapter.Fill(opsDataSet.FRL_GET, ShpID, MnfID, CneID);
        }

        private void dlvAdrRepositoryItemPopupContainerEdit_QueryResultValue(object sender, QueryResultValueEventArgs e)
        {
            e.Value = dlvAdrGridView.GetFocusedRowCellValue(colADRESdlv);
        }

        private void dlvAdrGridView_DoubleClick(object sender, EventArgs e)
        {
            dlvAdrPopupContainerControl.OwnerEdit.ClosePopup();
        }

        private void ophGridControl_Click(object sender, EventArgs e)
        {

        }

        private void teklifSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editable && iE)
            {
                int TstID = 0;

                TstSecXF frm = new TstSecXF();
                frm.TOB = ophLayoutView.GetFocusedRowCellValue(colTOB).ToString();
                frm.ROT = ophLayoutView.GetFocusedRowCellValue(colROT).ToString();
                frm.MOT = ophLayoutView.GetFocusedRowCellValue(colMOT).ToString();
                if (ophLayoutView.GetFocusedRowCellValue(colACCID) != DBNull.Value)
                    frm.FrtID = (int)ophLayoutView.GetFocusedRowCellValue(colACCID);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TstID = frm.TstID;
                    ophLayoutView.SetFocusedRowCellValue(colTSTID, TstID);
                }
                frm.Dispose();
            }
        }

    }
}