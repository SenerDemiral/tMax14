using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars.Docking;

namespace tMax14.Firma
{
    public partial class frtEditForm : DevExpress.XtraEditors.XtraForm
    {
        public int FRTid = 0;

        public frtEditForm()
        {
            InitializeComponent();

            frtGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colLOCID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDRM.ColumnEdit = Program.MF.frtDrmRepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.frtTurRepositoryItemLookUpEdit;
            colFLY.ColumnEdit = Program.MF.frtFlyRepositoryItemCheckedComboBoxEdit;
            //colILS.ColumnEdit = Program.MF.frtIlsRepositoryItemCheckedComboBoxEdit;
            colHDQID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colGRP.ColumnEdit = Program.MF.frtGrpRepositoryItemCheckedComboBoxEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselFRTrepositoryItemCheckedComboBoxEdit;
            colLNAID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCBRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBANKS.ColumnEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;

            colPAYTFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colINVTOID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSRCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colSRCTYP.ColumnEdit = Program.MF.frtSrcTypRepositoryItemLookUpEdit;

            colBLSTU.ColumnEdit = Program.MF.frtBLstuRepositoryItemLookUpEdit;
            colSRVULK.ColumnEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;

            frcGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colRPTIDSc.ColumnEdit = Program.MF.RPTrepositoryItemCheckedComboBoxEdit;
            colUYRKc.ColumnEdit = Program.MF.CNTRYrepositoryItemLookUpEdit;
            colROTc.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTc.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            frsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colSREPIDs.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colSUSRIDs.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colORGs.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDSTs.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colACCIDs.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colRAKIPs.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colROTs.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTs.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colTKLFs.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colDTMs.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colTOPSs.ColumnEdit = Program.MF.TOPrepositoryItemCheckedComboBoxEdit;

            frocGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAHTIDoc.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colBRMoc.ColumnEdit = Program.MF.BRMrepositoryItemImageComboBox;

            fraGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAGNIDa.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colMOTa.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            frlGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            frrGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colIPTr.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colBKMD.UnboundExpression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
           
        }

        private void frtEditForm_Load(object sender, EventArgs e)
        {
            bool isEditable = Program.MF.ModifyCheck("Firma.frtEditForm", true);
            frtLayoutView.OptionsBehavior.Editable = isEditable;
            fraGridView.OptionsBehavior.Editable = isEditable;
            froGridView.OptionsBehavior.Editable = isEditable;
            frlGridView.OptionsBehavior.Editable = isEditable;

            frcGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Firma.frcDP", true);
            frrGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Firma.frrDP", true);
            frsGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Firma.frsDP", true);
            frocGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Firma.frocDP", true);

            if (!Program.MF.EntryCheck("Firma.frcDP", true))
                frcDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Firma.frrDP", true))
                frrDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Firma.frsDP", true))
                frsDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Firma.frocDP", true))
                frocDockPanel.Visibility = DockVisibility.Hidden;

            if (FRTid != 0)
            {
                this.frtEditTableAdapter.FillByPK(this.firmaDataSet.FRTedit, FRTid);
                this.frcTableAdapter.FillByFRT(this.firmaDataSet.FRC, FRTid);
                this.frsTableAdapter.FillByFRT(this.firmaDataSet.FRS, FRTid);
                this.frocTableAdapter.FillByFRT(this.firmaDataSet.FROC, FRTid);
                this.fraTableAdapter.FillByFRT(this.firmaDataSet.FRA, FRTid);
                this.frrTableAdapter.FillByFRT(this.firmaDataSet.FRR, FRTid);
                this.froTableAdapter.FillByFRT(this.firmaDataSet.FRO, FRTid);
                this.frlTableAdapter.FillByFRT(this.firmaDataSet.FRL, FRTid);
            }
            else
                frtLayoutView.AddNewRow();

            bool mhsb = Program.MF.ModifyCheck("Firma.frtEditForm.mhsb", true);
            colPI11CTRF.OptionsColumn.AllowEdit = mhsb;
            colHSPNO12.OptionsColumn.AllowEdit = mhsb;
            colHSPNO32.OptionsColumn.AllowEdit = mhsb;
            colEFATURA.OptionsColumn.AllowEdit = mhsb;
            colVDEGUN.OptionsColumn.AllowEdit = mhsb;
            colODMSKL.OptionsColumn.AllowEdit = mhsb;
            colLMTTUT.OptionsColumn.AllowEdit = mhsb;
            
            //Program.MF.GridControlSettings(frcGridControl);
            //Program.MF.GridControlSettings(frsGridControl);

            /*
            XT.xtXUC uc = new XT.xtXUC();
            uc.RefTbl = "FRT";
            string XTBLB = string.Empty;
            if (!this.firmaDataSet.FRTedit[0].IsXTBLBNull())
                XTBLB = this.firmaDataSet.FRTedit[0].XTBLB;
            LayoutControlItem item = new LayoutControlItem();
            item.Control = uc;
            item.TextVisible = false;
            XTlayoutControlGroup.AddItem(item);
            uc.NewId(PK, XTBLB);
            */
        }

        private void frtEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = SaveAll();
            if (dr == System.Windows.Forms.DialogResult.Cancel)
                e.Cancel = true;
        }

        private DialogResult SaveAll()
        {
            this.Validate();
            this.frtEditBindingSource.EndEdit();

            DialogResult dr = System.Windows.Forms.DialogResult.Yes;
            if (this.firmaDataSet.HasChanges())
            {
                dr = XtraMessageBox.Show("Değişiklik var! Kayıt yapılsın?", "Firma Edit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    if (isValid())
                    {
                        this.frtEditTableAdapter.Update(this.firmaDataSet.FRTedit);
                        this.frcBindingSource.EndEdit();
                        this.frcTableAdapter.Update(this.firmaDataSet.FRC);
                        this.frsBindingSource.EndEdit();
                        this.frsTableAdapter.Update(this.firmaDataSet.FRS);
                        this.frocBindingSource.EndEdit();
                        this.frocTableAdapter.Update(this.firmaDataSet.FROC);
                        this.fraBindingSource.EndEdit();
                        this.fraTableAdapter.Update(this.firmaDataSet.FRA);

                        this.frrBindingSource.EndEdit();
                        this.frrTableAdapter.Update(this.firmaDataSet.FRR);
                        this.froBindingSource.EndEdit();
                        this.froTableAdapter.Update(this.firmaDataSet.FRO);
                        this.frlBindingSource.EndEdit();
                        this.frlTableAdapter.Update(this.firmaDataSet.FRL);
                    }
                    else
                        dr = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            return dr;
        }

        private bool isValid()
        {
            return true;
            
            bool res = true;
            StringBuilder errMsj = new StringBuilder();
            
            if (frtLayoutView.GetFocusedRowCellValue(colTUR) == DBNull.Value)
                errMsj.AppendLine("Tür");
            if (frtLayoutView.GetFocusedRowCellValue(colADN) == DBNull.Value)
                errMsj.AppendLine("NickName");
            if (frtLayoutView.GetFocusedRowCellValue(colAD) == DBNull.Value)
                errMsj.AppendLine("Ad");
            if (frtLayoutView.GetFocusedRowCellValue(colLOCID) == DBNull.Value)
                errMsj.AppendLine("Location");
            if (frtLayoutView.GetFocusedRowCellValue(colGRP) == DBNull.Value)
                errMsj.AppendLine("Group");
            if (frtLayoutView.GetFocusedRowCellValue(colSRCTYP) == DBNull.Value)
                errMsj.AppendLine("Source Type");
            
            
            if (errMsj.Length == 0)
            {
                if (string.IsNullOrWhiteSpace(frtLayoutView.GetFocusedRowCellValue(colADN).ToString()))
                    errMsj.AppendLine("NickName");
                if (string.IsNullOrWhiteSpace(frtLayoutView.GetFocusedRowCellValue(colAD).ToString()))
                    errMsj.AppendLine("Ad");
                
                string tur = frtLayoutView.GetFocusedRowCellValue(colTUR).ToString();
                if ( tur == "CA")
                {
                    if (frtLayoutView.GetFocusedRowCellValue(colIATA) == DBNull.Value)
                        errMsj.AppendLine("IATA");
                    if (frtLayoutView.GetFocusedRowCellValue(colCASS) == DBNull.Value)
                        errMsj.AppendLine("CASS");
                    if (frtLayoutView.GetFocusedRowCellValue(colL2) == DBNull.Value)
                        errMsj.AppendLine("L2");
                    if (frtLayoutView.GetFocusedRowCellValue(colL3) == DBNull.Value)
                        errMsj.AppendLine("L3");
                    if (frtLayoutView.GetFocusedRowCellValue(colN3) == DBNull.Value)
                        errMsj.AppendLine("N3");
                    if (frtLayoutView.GetFocusedRowCellValue(colAIRLINEPIMA) == DBNull.Value)
                        errMsj.AppendLine("AirlinePIMA");
                    if (frtLayoutView.GetFocusedRowCellValue(colAMBAR) == DBNull.Value)
                        errMsj.AppendLine("Ambar");
                    if (frtLayoutView.GetFocusedRowCellValue(colBAYRAK) == DBNull.Value)
                        errMsj.AppendLine("Bayrak");
                }
                else if (tur == "CS")
                {
                    if (frtLayoutView.GetFocusedRowCellValue(colLNAID) == DBNull.Value)
                        errMsj.AppendLine("Line's Agent");
                }
            }

            if (errMsj.Length > 0)
            {
                XtraMessageBox.Show(errMsj.ToString(), "Zorunlu Alanlar");
                res = false;
            }
            return res;
        }
        
        private void frtLayoutView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colBKMD)
            {
                string BKMS = frtLayoutView.GetRowCellDisplayText(e.RowHandle, colBKMS);
                if ((bool)e.Value)
                {
                    if (!BKMS.Contains(Program.USRtag))
                    {
                        BKMS += Program.USRtag;
                        frtLayoutView.SetRowCellValue(e.RowHandle, colBKMS, BKMS);
                    }
                }
                else
                {
                    if (BKMS.Contains(Program.USRtag))
                    {
                        BKMS = BKMS.Replace(Program.USRtag, "");
                        frtLayoutView.SetRowCellValue(e.RowHandle, colBKMS, BKMS);
                    }
                }
            }
        }

        private void yeniKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = SaveAll();
            if (dr != System.Windows.Forms.DialogResult.Cancel)
            {
                firmaDataSet.Clear();
                frtLayoutView.AddNewRow();
            }
        }

        private void frtLayoutView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            FRTid = (int)firmaQueriesTableAdapter.GET_PK("FRT");
            frtLayoutView.SetFocusedRowCellValue(colFRTID, FRTid);
            frtLayoutView.SetFocusedRowCellValue(colGRP, "NTR");
            frtLayoutView.SetFocusedRowCellValue(colSRCTYP, "OPS");
            frtLayoutView.SetFocusedRowCellValue(colVDEGUN, 0);
            frtLayoutView.SetFocusedRowCellValue(colODMSKL, "N");   //Nakit

        }

        private void yeniContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frcGridView.AddNewRow();
        }

        private void silContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frcGridView.DeleteRow(frcGridView.FocusedRowHandle);
        }

        private void yeniServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frsGridView.AddNewRow();
        }

        private void silServisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frsGridView.DeleteRow(frsGridView.FocusedRowHandle);
        }

        private void yeniOCtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frocGridView.AddNewRow();
        }

        private void silOCtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frocGridView.DeleteRow(frocGridView.FocusedRowHandle);
        }

        private void yeniAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fraGridView.AddNewRow();
        }

        private void silAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fraGridView.DeleteRow(fraGridView.FocusedRowHandle);
        }

        private void frrYeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrGridView.AddNewRow();
        }

        private void frrSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frrGridView.DeleteRow(frrGridView.FocusedRowHandle);
        }

        private void froYeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            froGridView.AddNewRow();
        }

        private void froSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            froGridView.DeleteRow(froGridView.FocusedRowHandle);
        }

        private void yeniFRLtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frlGridView.AddNewRow();
        }

        private void silFRLtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frlGridView.DeleteRow(frlGridView.FocusedRowHandle);
        }

        private void frcGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            frcGridView.SetRowCellValue(e.RowHandle, colFRCIDc, Program.MF.mainQueriesTableAdapter.GET_PK("FR"));
            frcGridView.SetRowCellValue(e.RowHandle, colFRTIDc, FRTid);
            string CNTRY = frtLayoutView.GetFocusedRowCellDisplayText(colLOCID);
            if (!string.IsNullOrWhiteSpace(CNTRY))
                frcGridView.SetRowCellValue(e.RowHandle, colUYRKc, CNTRY.Substring(0,2));
        }

        private void frsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            frsGridView.SetRowCellValue(e.RowHandle, colFRSIDs, Program.MF.mainQueriesTableAdapter.GET_PK("FR"));
            frsGridView.SetRowCellValue(e.RowHandle, colFRTIDs, FRTid);
        }

        private void frocGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //frocGridView.SetRowCellValue(e.RowHandle, colFROCIDoc, Program.MF.mainQueriesTableAdapter.GET_PK("FR")); //Kalkti PK = FRTid+AHTid
            frocGridView.SetRowCellValue(e.RowHandle, colFRTIDoc, FRTid);

        }

        private void fraGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            fraGridView.SetRowCellValue(e.RowHandle, colFRAIDa, Program.MF.mainQueriesTableAdapter.GET_PK("FR"));
            fraGridView.SetRowCellValue(e.RowHandle, colFRTIDa, FRTid);
        }

        private void tabbedControlGroup1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(item2.Width.ToString());
        }

        private void frrGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            frrGridView.SetRowCellValue(e.RowHandle, colFRRIDr, Program.MF.mainQueriesTableAdapter.GET_PK("FR"));
            frrGridView.SetRowCellValue(e.RowHandle, colFRTIDr, FRTid);
        }

        private void froGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            froGridView.SetRowCellValue(e.RowHandle, colFROIDo, Program.MF.mainQueriesTableAdapter.GET_PK("FR"));
            froGridView.SetRowCellValue(e.RowHandle, colFRTIDo, FRTid);
        }

        private void frlGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            frlGridView.SetRowCellValue(e.RowHandle, colFRTIDl, FRTid);
        }

        private void teklifTalepOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveAll() == System.Windows.Forms.DialogResult.Yes)
            {
                frs2tstXF frm = new frs2tstXF();
                frm.frsRow = (FirmaDataSet.FRSRow)frsGridView.GetFocusedDataRow();

                frm.FrsID = (int)frsGridView.GetFocusedRowCellValue("FRSID");
                frm.ShowDialog();

                //var frsRow = (FirmaDataSet.FRSRow)frsGridView.GetFocusedDataRow();
            }
        }

    }
}