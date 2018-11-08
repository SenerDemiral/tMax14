using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.Ops
{
    public partial class opMasterEditXF : DevExpress.XtraEditors.XtraForm
    {
        public int PK = 0;
        Dictionary<string, string> OzlDrm = new Dictionary<string, string>();
        public dynamic orgForm;
        bool editable = false;
        public bool iE = false, aE = false;

        public opMasterEditXF()
        {
            InitializeComponent();

            opmLayoutView.OptionsCustomization.AllowFilter = false;
            opmLayoutView.OptionsCustomization.AllowSort = false;

            opmGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;   //locRepositoryItemPopupContainerEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colVGLOC.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCRAID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNFYID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNF2ID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colNSTU.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colPSTU.ColumnEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;
            colASTU.ColumnEdit = Program.MF.OpsStuAmetaRepositoryItemImageComboBox;

            colTOS.ColumnEdit = Program.MF.TOSrepositoryItemLookUpEdit;
            colTOL.ColumnEdit = Program.MF.TOLrepositoryItemLookUpEdit;
            colPOL.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit;
            colPOT.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit;
            colPOU.ColumnEdit = Program.MF.locRepositoryItemPopupContainerEdit;
            colTOC.ColumnEdit = Program.MF.TOCrepositoryItemLookUpEdit;
            colOWNR.ColumnEdit = Program.MF.OWNRrepositoryItemImageComboBox;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;

            colDTM.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colPTM.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colDTP.ColumnEdit = Program.MF.DTPrepositoryItemLookUpEdit;

            colTRO.ColumnEdit = Program.MF.OpsTrOrepositoryItemCheckedComboBoxEdit; //OpsTrOrepositoryItemLookUpEdit;
            colTRS.ColumnEdit = Program.MF.OpsTrSrepositoryItemCheckedComboBoxEdit; //OpsTrSrepositoryItemLookUpEdit;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colWBD.ColumnEdit = Program.MF.trhRepositoryItemDateEdit;
            colONYTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRRT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colEOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colETD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colETA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colCOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPAT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colACD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colLCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colACOT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colTPAD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colTPDD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colULSD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colULCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colULCD2.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colOBTT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colTAGS.ColumnEdit = Program.MF.TAGselOPSrepositoryItemCheckedComboBoxEdit;

            opm2GridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDVZair.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTO1air.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;  // RepositoryItemPopupContainerEdit;
            colTO2air.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colTO3air.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colSPHair.ColumnEdit = Program.MF.opsSPHrepositoryItemCheckedComboBoxEdit;

            opmaGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAHTIDa.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colDVZa.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            oppGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTOPp.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            //colCOWNIDp.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            //colCDPOIDp.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            afdoGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDKNFRTIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTIDf.ColumnEdit = Program.MF.AHTmasterRepositoryItemGridLookUpEdit;
            colDDVZf.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBRMf.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colTURf.ColumnEdit = Program.MF.afbTurRepositoryItemLookUpEdit;
            colOPACCIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            Program.MF.FRTrepositoryItemLookUpEdit.Closed += FRTrepositoryItemLookUpEdit_Closed;
            Program.MF.locRepositoryItemPopupContainerEdit.Closed += locRepositoryItemPopupContainerEdit_Closed;

            OPMAopsRepositoryItemLookUpEdit.Closed += OPMAopsRepositoryItemLookUpEdit_Closed;
            Program.MF.AHTmasterRepositoryItemGridLookUpEdit.Closed += AHTmasterRepositoryItemGridLookUpEdit_Closed;

            Program.MF.GridControlSettings(oppGridControl);
            Program.MF.GridControlSettings(opmaGridControl);
            Program.MF.GridControlSettings(opmcGridControl);
            Program.MF.GridControlSettings(afdoGridControl);

            //opmLayoutView.OptionsBehavior.Editable = Program.MF.CanUserDo("Ops.opMasterEditXF", "UPD", isSilent: true);
            editable = Program.MF.ModifyCheck("Ops.opMasterEditXF", isSilent: true);
        }

        void AHTmasterRepositoryItemGridLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
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

        public void Save()  // Main'den
        {
            // Degisiklik yapmasina izin yok! Bu module ayarliyor
        }

        private DialogResult SaveAll()
        {
            // Gerek yok girdiyse kaydetsin
            //if (opsDataSet.OPM2.Count > 0 && opsDataSet.OPM2.Rows[0].RowState == DataRowState.Unchanged)
            //    opsDataSet.OPM2.Clear();

            DialogResult dr = System.Windows.Forms.DialogResult.Yes;

            if (!this.Validate())
                return System.Windows.Forms.DialogResult.Cancel;

            this.opmBindingSource.EndEdit();
            if (this.opsDataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "OpsMaster Edit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (OpsDataSet.AFDO_SELRow row in this.opsDataSet.AFDO_SEL.Rows)
                    {
                        if (row.RowState == DataRowState.Modified)
                            row.UPDUSR = Program.USR;
                        else if (row.RowState == DataRowState.Added)
                        {
                            //row.AFBID = 0;  //Insert/Duplice Faturaya tasima, bu da calisiyor
                            row["AFBID"] = DBNull.Value;
                            row.INSUSR = Program.USR;
                        }
                    }
                    
                    if (opmLayoutView.GetFocusedRowCellValue(colMOT).ToString() == "T" && opmLayoutView.GetFocusedRowCellValue(colTRACK) == DBNull.Value)
                    {
                        opmLayoutView.SetFocusedRowCellValue(colTRACK, "TR-IT-AT-DE-FR-UK");
                        opmLayoutView.UpdateCurrentRow();
                    }
                    
                    try
                    {
                        this.opmTableAdapter.Update(this.opsDataSet.OPM);   // Ilk Master kaydi yazdir, UpdateAll bilmiyor
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

        private void opMasterEditXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = System.Windows.Forms.DialogResult.Yes;
            
            //if (!this.Validate())
            //{
            //    dr = XtraMessageBox.Show("Hata var! Kaydetmeden çıkmak istiyormusunuz?", "OpsMaster Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                OPMAopsRepositoryItemLookUpEdit.Closed -= OPMAopsRepositoryItemLookUpEdit_Closed;
            }
        }

        void OPMAopsRepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var a = sender as LookUpEdit;
            if (opmaGridControl.IsFocused)
            {
                opmaGridView.SetFocusedRowCellValue(colHMa, a.GetColumnValue("HM"));
                opmaGridView.SetFocusedRowCellValue(colDVZa, a.GetColumnValue("DVZ"));
            }
        }

        void locRepositoryItemPopupContainerEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (opmGridControl.IsFocused && e.CloseMode != PopupCloseMode.Cancel)
            {
                var a = sender as PopupContainerEdit;
                if (a.EditValue != null)
                {
                    string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("LOC", a.EditValue.ToString()).ToString();
                    opmLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                    OzlDrm[opmLayoutView.FocusedColumn.FieldName] = ozlDrm;
                }
            }
        }

        void FRTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (opmGridControl.IsFocused && e.CloseMode != PopupCloseMode.Cancel)
            {
                var a = sender as LookUpEdit;

                if (a.EditValue != null)
                {
                    string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("FRT", a.EditValue.ToString()).ToString();
                    opmLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                    OzlDrm[opmLayoutView.FocusedColumn.FieldName] = ozlDrm;
                }
            }
        }

        void frtRepositoryItemSearchLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            // IPTAL
            if (opmGridControl.IsFocused && e.CloseMode != PopupCloseMode.Cancel)
            {
                var a = sender as SearchLookUpEdit;

                if (a.EditValue != null)
                {
                    string ozlDrm = opsQueriesTableAdapter.OZEL_DURUM("FRT", a.EditValue.ToString()).ToString();
                    opmLayoutView.SetFocusedRowCellValue(colOzlDrm, ozlDrm);
                    OzlDrm[opmLayoutView.FocusedColumn.FieldName] = ozlDrm;
                }
            }
        }

        private void opmLayoutView_CustomFieldCaptionStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewFieldCaptionStyleEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;
            if (OzlDrm.ContainsKey(e.Column.FieldName) && e.Column != colOzlDrm && !string.IsNullOrWhiteSpace(OzlDrm[e.Column.FieldName]))
            {
                e.Appearance.BackColor = Color.Red;
                e.Appearance.ForeColor = Color.White;
            }
        }
        
        private void opmLayoutView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;
            if (view.IsFocusedView && e.FocusedColumn != null && OzlDrm.ContainsKey(e.FocusedColumn.FieldName) && e.FocusedColumn != colOzlDrm)
            {
                view.SetFocusedRowCellValue(colOzlDrm, OzlDrm[e.FocusedColumn.FieldName]);
            }
        }

        private void opMasterEditXF_Load(object sender, EventArgs e)
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

            this.opmaOpsTableAdapter.FillByOPM(this.opsDataSet.OPMA_OPS, PK);   // Ops Lookup
            this.opmaTableAdapter.FillByOPM(this.opsDataSet.OPMA, PK);  // AMETA
            this.opmaPCTableAdapter.Fill(this.opsDataSet.AMETA_PROFIT_CALC, PK);  // AMETA Profit Calc

            this.opshTableAdapter.FillByOP(this.opsDataSet.OPSH, PK);   // StatuHistory
            this.oppTableAdapter.FillByOP(this.opsDataSet.OPP, PK);     // Packages/Containers
            this.opmcTableAdapter.FillByOPM(this.opsDataSet.OPMC, PK);  // OtherCharges
            this.oprhSelDisTableAdapter.Fill(this.opsDataSet.OPRH_SEL_DIS, PK, 0);   //GidenEvrak
            this.opcLupTableAdapter.Fill(this.opsDataSet.OPC_LUP);
            this.opcLupMTableAdapter.Fill(this.opsDataSet.OPC_LUP_M, PK);

            if (Program.MF.EntryCheck("Ops.opMasterEditXF.afdoDP", isSilent: true))
                this.afdoTableAdapter.Fill(this.opsDataSet.AFDO_SEL, string.Format("OPid = {0}", PK), Program.USR);   // Account
            afdoGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Ops.opMasterEditXF.afdoDP", isSilent: true);
            
            this.opmTableAdapter.FillByPK(this.opsDataSet.OPM, PK);     // Master
            OpsDataSet.OPMRow opmRow = (OpsDataSet.OPMRow)this.opsDataSet.OPM.Rows[0];

            this.opm2TableAdapter.FillByPK(this.opsDataSet.OPM2, PK);     // OPM+
            
            foreach (DataColumn dataCol in this.opsDataSet.OPH.Columns)
                OzlDrm.Add(dataCol.ColumnName, "");

            OzelDrmAddDict("LOC", opmRow, this.opsDataSet.OPM.ORGColumn);
            OzelDrmAddDict("LOC", opmRow, this.opsDataSet.OPM.DSTColumn);
            OzelDrmAddDict("LOC", opmRow, this.opsDataSet.OPM.POLColumn);
            OzelDrmAddDict("LOC", opmRow, this.opsDataSet.OPM.POTColumn);
            OzelDrmAddDict("LOC", opmRow, this.opsDataSet.OPM.POUColumn);

            OzelDrmAddDict("FRT", opmRow, this.opsDataSet.OPM.SHPIDColumn);
            OzelDrmAddDict("FRT", opmRow, this.opsDataSet.OPM.CNEIDColumn);
            OzelDrmAddDict("FRT", opmRow, this.opsDataSet.OPM.CRRIDColumn);
            OzelDrmAddDict("FRT", opmRow, this.opsDataSet.OPM.CRAIDColumn);
            OzelDrmAddDict("FRT", opmRow, this.opsDataSet.OPM.NFYIDColumn);

            //string islYtkCur, accYtkCur;
            //Program.MF.IslAccCurYtk("M", PK, out islYtkCur, out accYtkCur);
            //bool ytkOK = Program.MF.YetkiCheck(islYtkCur, true);
            //bool accYtkOK = Program.MF.YetkiCheck(accYtkCur, true);

            opmLayoutView.OptionsBehavior.Editable = editable && iE;  //ytkOK;
            opm2LayoutView.OptionsBehavior.Editable = editable && iE;
            oppGridView.OptionsBehavior.Editable = editable && iE;
            opmaGridView.OptionsBehavior.Editable = editable && iE;
            opmcGridView.OptionsBehavior.Editable = editable && iE;
            afdoGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Ops.opMasterEditXF.afdoDP", isSilent: true) && aE; // accYtkOK;

            godInfMemoEdit.Enabled = editable && iE;
            hndInfMemoEdit.Enabled = editable && iE;
            accInfMemoEdit.Enabled = editable && iE;

        }

        private void OzelDrmAddDict(string tbl, OpsDataSet.OPMRow opmRow, DataColumn dataCol)
        {
            string ozlDrm;
            DevExpress.XtraGrid.Columns.LayoutViewColumn viewCol = opmLayoutView.Columns[dataCol.ColumnName];
            if (!opmRow.IsNull(dataCol))
            {
                ozlDrm = opsQueriesTableAdapter.OZEL_DURUM(tbl, opmRow[dataCol].ToString()).ToString();
                OzlDrm[dataCol.ColumnName] = ozlDrm;
            }
        }

        private void yeniMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editable)
                return;

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
                opmLayoutView.BeginDataUpdate();
                opsDataSet.Clear();

                OpsDataSet.OPMRow opmRow = opsDataSet.OPM.NewOPMRow();

                PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
                opmRow.OPMID = PK;
                opmRow.SHPID = -1;  // TO
                opmRow.CNEID = -1;  // TO
                opmRow.NSTU = "B";  // Booking
                opmRow.TOB = "O";   // Ops
                opmRow.OWNR = "1";  // Merkez

                opsDataSet.OPM.AddOPMRow(opmRow);
                opmLayoutView.EndDataUpdate();
            }
        }

        private void opmLayoutView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            //PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            //view.SetRowCellValue(e.RowHandle, colOPMID, PK);
        }

        private void oppGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPPIDp, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));
            view.SetRowCellValue(e.RowHandle, colOPIDp, PK);
            view.SetRowCellValue(e.RowHandle, colHMp, "M");
            //view.SetRowCellValue(e.RowHandle, colCRHBTOp, "F");
        }

        private void opmaGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPMAIDa, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));
            view.SetRowCellValue(e.RowHandle, colOPMIDa, PK);
            view.SetRowCellValue(e.RowHandle, colXXINPa, "F");
        }


        private void opmcGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colOPMIDc, PK);
            view.SetRowCellValue(e.RowHandle, colACc, "C");
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAll() == System.Windows.Forms.DialogResult.Yes)
                LoadAll();
        }

        
        private void airDockPanel_Enter(object sender, EventArgs e)
        {
            if (opsDataSet.OPM2.Count == 0)
            {
                OpsDataSet.OPM2Row opm2Row = opsDataSet.OPM2.NewOPM2Row();
                opm2Row.OPMID = PK;
                opsDataSet.OPM2.AddOPM2Row(opm2Row);
                airDockPanel.Refresh();
            }

        }

        private void MAWBidAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmLayoutView.GetFocusedRowCellValue(colCRRID) != DBNull.Value)
            {
                int crrID = (int)opmLayoutView.GetFocusedRowCellValue(colCRRID);
                string refNo = opsQueriesTableAdapter.OPMI_GET(crrID).ToString();
                opmLayoutView.SetFocusedRowCellValue(colREFNO, refNo);
            }
        }

        private void MAWBidIadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmLayoutView.GetFocusedRowCellValue(colCRRID) != DBNull.Value)
            {
                int crrID = (int)opmLayoutView.GetFocusedRowCellValue(colCRRID);
                string refNo = opmLayoutView.GetFocusedRowCellValue(colREFNO).ToString();
                string OK = opsQueriesTableAdapter.OPMI_IADE(refNo, crrID).ToString();
                if (OK == "F")
                    XtraMessageBox.Show("MAWB No iade edilemedi");
                else
                    opmLayoutView.SetFocusedRowCellValue(colREFNO, null);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            MAWBnoToolStripMenuItem.Enabled = 
                opmLayoutView.GetFocusedRowCellValue(colCRRID) != DBNull.Value &&
                opmLayoutView.GetFocusedRowCellValue(colROT) != DBNull.Value &&
                opmLayoutView.GetFocusedRowCellValue(colROT).ToString() == "E" &&
                opmLayoutView.GetFocusedRowCellValue(colMOT) != DBNull.Value &&
                opmLayoutView.GetFocusedRowCellValue(colMOT).ToString() == "A";

        }

        private void opmGridControl_Click(object sender, EventArgs e)
        {

        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editable)
                return;

            SaveAll();
            int dMid = (int)opsQueriesTableAdapter.OPM_DUP(PK);
            if (dMid != 0)
            {
                iE = true;
                aE = true;
                PK = dMid;
                LoadAll();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opmaGridControl.ShowPrintPreview();
            //return;
            
            PrintingSystem ps = new PrintingSystem();
            // Create a link that will print a control. 
            PrintableComponentLink link = new PrintableComponentLink(ps);
            // Specify the control to be printed. 
            link.Component = opmaGridControl;
            // Set the paper format. 
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;
            // Subscribe to the CreateReportHeaderArea event used to generate the report header. 
            //link.CreateMarginalHeaderArea += link_CreateMarginalHeaderArea;
            //link.CreateMarginalFooterArea += link_CreateMarginalFooterArea;
            // Generate the report. 
            link.CreateDocument();
            // Show the report. 
            link.ShowPreview();
        }

        void link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            string reportHeader = string.Format("AMETA");
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = new Font("Tahoma", 12, FontStyle.Bold);
            RectangleF rec = new RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50);
            e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None);
        }

        private void oppGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.FocusedColumn == colCNTNOp && view.GetFocusedRowCellValue(colOPCIDp) != DBNull.Value)
                e.Cancel = true;
        }

        private void oppGridView_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            // Editor for Editing Only, colOPCIDp.ColumnEdit is null
            if (e.Column == colOPCIDp)
                e.RepositoryItem = OPCLUPrepositoryItemLookUpEdit;
        }

        private void OPCLUPrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            var edit = sender as LookUpEdit;
            if (e.CloseMode == PopupCloseMode.Normal && edit.OldEditValue != edit.EditValue && oppGridControl.IsFocused)
            {
                var opcRow = opsDataSet.OPC_LUP.FindByOPCID((int)edit.EditValue);
                if (opcRow != null)
                {
                    oppGridView.SetFocusedRowCellValue(colCNTNOp, opcRow.CNTNO);
                }
            }
        }

        private void createAMETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opsQueriesTableAdapter.AMETA_CREATE(PK);
            this.opmaTableAdapter.FillByOPM(this.opsDataSet.OPMA, PK);  // AMETA
            this.opmaPCTableAdapter.Fill(this.opsDataSet.AMETA_PROFIT_CALC, PK);  // AMETA Profit Calc
        }

        private void create45AMETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opsQueriesTableAdapter.AMETA45_CREATE(PK);
            this.opmaTableAdapter.FillByOPM(this.opsDataSet.OPMA, PK);  // AMETA
            this.opmaPCTableAdapter.Fill(this.opsDataSet.AMETA_PROFIT_CALC, PK);  // AMETA Profit Calc
        }

        private void afdoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            //if (Program.MF.YetkiCheck(opmLayoutView.GetFocusedRowCellDisplayText(colONYAYTK), false))
            {
                view.SetRowCellValue(e.RowHandle, colAFDIDf, Program.MF.mainQueriesTableAdapter.GET_PK("ACC"));
                //view.SetRowCellValue(e.RowHandle, colAFBIDf, 0);
                view.SetRowCellValue(e.RowHandle, colOPIDf, PK);
                view.SetRowCellValue(e.RowHandle, colOPHMf, "M");
                view.SetRowCellValue(e.RowHandle, colTURf, "AA");   //Alis
                view.SetRowCellValue(e.RowHandle, colKDYf, 0);
                view.SetRowCellValue(e.RowHandle, colMIKf, 1);
                view.SetRowCellValue(e.RowHandle, colDDVZf, "TRL");
            }
            //else
            //    BeginInvoke(new MethodInvoker(view.CancelUpdateCurrentRow));  //CancelNewRow

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

        private void OCIrepositoryItemMemoExEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            Text += e.Value.ToString() + " ";

            // sa = new string[100];
            /*
            string[] sa = e.Value.ToString().Split(new char[] { '/' }); //,  StringSplitOptions.RemoveEmptyEntries);
            int sal = sa.Length / 4;
            for (int i = 0; i < sal; i++)
            {
                sa[i*4+  
            }
            */
            string[] stringSeparators = new string[] {"\r\n"};
            string[] res = e.Value.ToString().Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            string resVal = String.Empty;
            bool hasErr = false;

            for (int i = 0; i < res.Length; i++)
            {
                string err = "";
                string[] pa = res[i].Split(new char[] { '/' });

                if (pa.Length != 5)
                    err = "Hatalı Format";
                else if (pa[1].Length > 0 && pa[1].Length < 2)
                    err = "ContryCode boş veya 2 karakter olmalı";
                else if (pa[2].Length > 0 && pa[2].Length < 3)
                    err = "InformationIdetifier boş veya 3 karakter olmalı";
                else if (pa[3].Length > 2)
                    err = "CustomInformationIdetifier en fazla 2 karakter olmalı";
                else if (pa[4].Length > 35)
                    err = string.Format("SuplemetaryCustomInformation en fazla 35 karakter olmalı, girilen {0}", pa[4].Length);

                if (err.Length > 0)
                {
                    hasErr = true;
                    XtraMessageBox.Show(string.Format("Satır: {0} -> {1} \n\nSatır Formatı: /ContryCode/InformationIdetifier/CustomInformationIdetifier/SuplemetaryCustomInformation", i + 1, err), "Other Custom Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resVal += res[i] + "\r\n";
                }
            }

            if (!hasErr)
            {
                e.Value = resVal;
                e.Handled = true;
            }

        }

        private void SSRrepositoryItemMemoExEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            string[] res = e.Value.ToString().Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            string resVal = String.Empty;
            bool hasErr = false;

            if (res.Length > 3)
                XtraMessageBox.Show("3 Satırdan fazla olamaz.", "Special Service Request", MessageBoxButtons.OK, MessageBoxIcon.Error);

            for (int i = 0; i < res.Length; i++)
            {
                string err = "";
                string[] pa = res[i].Split(new char[] { '/' });

                if (pa[1].Length > 35)
                    err = string.Format("SpecialServiceRequest en fazla 35 karakter olmalı, girilen {0}", pa[1].Length);

                if (err.Length > 0)
                {
                    hasErr = true;
                    XtraMessageBox.Show(string.Format("Satır: {0} -> {1} \n\nSatır Formatı: /SpecialServiceRequest", i + 1, err), "Special Service Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resVal += res[i] + "\r\n";
                }
            }

            if (!hasErr)
            {
                e.Value = resVal;
                e.Handled = true;
            }

        }

        private void tekifSecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editable && iE)
            {
                int TstID = 0;

                TstSecXF frm = new TstSecXF();
                frm.ROT = opmLayoutView.GetFocusedRowCellValue(colROT).ToString();
                frm.MOT = opmLayoutView.GetFocusedRowCellValue(colMOT).ToString();

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TstID = frm.TstID;
                    opmLayoutView.SetFocusedRowCellValue(colTSTID, TstID);
                }
                frm.Dispose();
            }
        }

    }
}
