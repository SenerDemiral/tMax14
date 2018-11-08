using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using tMax14ReportClassLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;
using DevExpress.XtraPrinting;
using System.IO;

namespace tMax14.Ops
{
    public partial class opMasterXUC : DevExpress.XtraEditors.XtraUserControl
    {
        Ops.opHouseXUC opHouseFrm;
        public int? OPMID = 0;
        public string qsString = string.Empty;

        string qryStr = string.Empty;

        string qryPrmStr = string.Empty;
        FirebirdSql.Data.FirebirdClient.FbCommand activeFbCommand = new FirebirdSql.Data.FirebirdClient.FbCommand();
        string layoutName = "Ops.opMasterXUC.opm";

        private Qry.qsOpmXF qsFrm = new Qry.qsOpmXF();

        public opMasterXUC()
        {
            InitializeComponent();
            
            opmGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colLCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colONYTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colETD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colETA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colCOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colLCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colACOT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colTPAD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colTPDD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colOBTT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;


            colOWNR.ColumnEdit = Program.MF.OWNRrepositoryItemImageComboBox;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit; // locRepositoryItemPopupContainerEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit; // locRepositoryItemPopupContainerEdit; //SearchLookUpEdit;// RepositoryItemPopupContainerEdit;

            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //ftRepositoryItemSearchLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colNSTU.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colPSTU.ColumnEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;
            colASTU.ColumnEdit = Program.MF.OpsStuAmetaRepositoryItemImageComboBox;

            colTRO.ColumnEdit = Program.MF.OpsTrOrepositoryItemCheckedComboBoxEdit; //OpsTrOrepositoryItemLookUpEdit;
            colTRS.ColumnEdit = Program.MF.OpsTrSrepositoryItemCheckedComboBoxEdit; //OpsTrSrepositoryItemLookUpEdit;

            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colEDITABLEACC.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            
            //opmGridControl.DataSource = this.opsDataSet.OPM_SEL;
            Program.MF.GridControlSettings(opmGridControl);
            
            opmGridView.OptionsView.ShowGroupPanel = true;


            opmGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);

            var view = opmGridView;
            view.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            view.OptionsFilter.UseNewCustomFilterDialog = true;
            for (int i = 0; i < this.opsDataSet.OPM_SEL.Columns.Count; i++)
                if (this.opsDataSet.OPM_SEL.Columns[i].DataType.Name == "DateTime")
                {
                    view.Columns[this.opsDataSet.OPM_SEL.Columns[i].ColumnName].OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Date;
                    view.Columns[this.opsDataSet.OPM_SEL.Columns[i].ColumnName].OptionsFilter.ShowEmptyDateFilter = true;
                }
        
            Program.MF.XGLrestore(layoutName, 0, opmGridView);
        }

        private void opmGridView_Layout(object sender, EventArgs e)
        {
            //Program.MF.XGLsave(layoutName, 0, opmGridView);
        }

        private void opmGridControl_Enter(object sender, EventArgs e)
        {
            if (!opmGridView.IsEmpty)
            {
                NewId(OPMID);
            }
        }

        private void opmGridControl_Leave(object sender, EventArgs e)
        {
            //Program.MF.Text += "GridLeave ";
           // MessageBox.Show("opmGridLeave");
        }

        private void opMasterXUC_Load(object sender, EventArgs e)
        {
            qsFrm.OPM = opsDataSet.OPM_SEL;
            qsFrm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(qsFrm);

            if (OPMID != 0)
            {
                this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = '{0}'", OPMID), Program.USR);
            }

            if (!string.IsNullOrEmpty(qsString))
            {
                int nor = 0;
                Program.MF.startSW();
                try
                {
                    nor = this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, qsString, Program.USR);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    Program.MF.stopSW("OpsMaster", nor);
                }
            }
            else if (OPMID != null && OPMID != 0)
                queryToolStripMenuItem.Enabled = false;
        }

        private void opMasterXUC_Leave(object sender, EventArgs e)
        {
            // Acik Panelleri kapatmaya/Save etmeye gerek yok, zaten degisiklik yapildiysa panelin icindeki Control a girilmis demektir
            /*
            //MessageBox.Show("opMasterLeave");
            for (int i = dockManager.Panels.Count - 1; i >= 0; i--)
            {
                dynamic ctrl = dockManager.Panels[i].ControlContainer.Controls[0];  // Panel'in icindeki Form/UserControl
                ctrl.Save();
                int kkkk = dockManager.Panels[i].ControlContainer.Controls.Count;
                int jjjj = dockManager.Panels[i].Controls.Count;
                string ssss = dockManager.Panels[i].Controls[0].Name;
                dockManager.Panels[i].Close();
            }
            //dockManager.RemovePanel(dockManager.ActivePanel);
            //dockManager.Clear();*/
        }

        public void NewId(object id)
        {
            if (opmGridView.IsEditing)  // Edit edecek birsey yok Edititble=False
                opmGridView.UpdateCurrentRow();

            if (id == DBNull.Value)
                this.opsDataSet.OPM_SEL.Clear();
            else if ((int)id == 0)  // Query
            {
                reQuery();
            }
            else
            {
                this.opmSelTableAdapter.ClearBeforeFill = true;
                OPMID = (int)id;
                this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = '{0}'", OPMID), Program.USR);
            }
        }

        public void refreshRow(int PK)
        {
            this.opmSelTableAdapter.ClearBeforeFill = false;
            this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = '{0}'", PK), Program.USR);
        }

        public void Save()  // KULLANILMIYOR Editible=False editForm da yapilir
        {
            this.Validate();
            this.opmSelBindingSource.EndEdit();
            DataTable changedRows = this.opsDataSet.OPM.GetChanges(DataRowState.Added | DataRowState.Modified);
            this.opmSelTableAdapter.Update(this.opsDataSet.OPM_SEL);
           
            if (changedRows != null)
            {
                //this.opsDataSet.OPM.AcceptChanges();
                foreach (DataRow row in changedRows.Rows)
                {
                    refreshRow((int)row["OPMID"]);
                }
            }
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmGridView.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "OPM";
            frm.RefID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.RefInfo = opmGridView.GetFocusedRowCellDisplayText(colOPMID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmGridView.DataRowCount == 0)
                return;

            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "ophPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                int id = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                panel.Name = "ophPanel";

                opHouseFrm = new opHouseXUC();
                opHouseFrm.OPMID = id;
                panel.Text = string.Format("M {0}", opmGridView.GetFocusedRowCellDisplayText(colOPMID));
                opHouseFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(opHouseFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor
            }
        }

        private void opmGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (opHouseFrm != null)
            {
                if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle ||
                    e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                    !opmGridView.IsDataRow(e.FocusedRowHandle))
                    opHouseFrm.NewId(0);
                else
                {
                    dockManager.Panels["ophPanel"].Text = string.Format("M {0}", opmGridView.GetFocusedRowCellValue(colOPMID));
                    opHouseFrm.NewId((int)opmGridView.GetFocusedRowCellValue(colOPMID));
                }
            }
        }

        private void opmGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            opmGridView.SetRowCellValue(e.RowHandle, colOPMID, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));   // House&Master ayni Generator kullanir
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query();
        }
     
        private void Query()
        {
            Program.QPF.TBL = "OPM";
            if (Program.QPF.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            qryStr = Program.QPF.prepareQryStr();    //prepareCommandString(qryPrmStr);
            if (!string.IsNullOrEmpty(qryStr))
            {
                int nor = 0;
                Program.MF.startSW();
                try
                {
                    this.opmSelTableAdapter.ClearBeforeFill = true;
                    nor = this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, qryStr, Program.USR);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    Program.MF.stopSW("OpsMaster", nor);
                }
            }

        }

        private void reQuery()  // Calismiyor, Query degisti
        {
            /*
            if (!string.IsNullOrEmpty(activeFbCommand.CommandText))
            {
                //DataTable dt = (DataTable)this.opsDataSet.OPM;
                Program.QPF.reQry((DataTable)this.opsDataSet.OPM, activeFbCommand);
            }*/
        }

        private void loadingPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opMasterLoadingXF frm = new opMasterLoadingXF();
            frm.opmRow = (Ops.OpsDataSet.OPM_SELRow)opmGridView.GetDataRow(opmGridView.FocusedRowHandle);
            frm.ShowDialog();

            int PK = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            //refreshRow(PK);
            NewId(OPMID);
            if (opHouseFrm != null)
                opHouseFrm.NewId(PK);
        }

        private void containerLoadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opContainerLoadingXF frm = new opContainerLoadingXF();
            frm.OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.ShowDialog();
        }

        
        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (opmGridView.RowCount == 0)
            {
                for (int i = 0; i < contextMenuStrip.Items.Count; i++)
                    contextMenuStrip.Items[i].Enabled = false;
                queryToolStripMenuItem.Enabled = true;
                yeniKayitToolStripMenuItem.Enabled = true;
            }
            else
            {
                for (int i = 0; i < contextMenuStrip.Items.Count; i++)
                    contextMenuStrip.Items[i].Enabled = true;

                if (OPMID != null && OPMID != 0)
                    queryToolStripMenuItem.Enabled = false;

                printsItems();
            }
        }

        private void dockManager_ClosedPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e)
        {
            //string aaa = e.Panel.Name;
            //e.Panel.Dispose();
            
        }

        private void dockManager_ClosingPanel(object sender, DevExpress.XtraBars.Docking.DockPanelCancelEventArgs e)
        {
            //MessageBox.Show("ClosingPanel");
            //string ssss = e.Panel.ActiveControl.Name;
        }

        private void originToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.mapXF frm = new Genel.mapXF();
            frm.MapCenter(opmGridView.GetFocusedRowCellDisplayText(colORG));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void destinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.mapXF frm = new Genel.mapXF();
            frm.MapCenter(opmGridView.GetFocusedRowCellDisplayText(colDST));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "OPM";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = opmGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                opmGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                opmGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                opmGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                opmGridView.UpdateCurrentRow();
            }
        }

        private void opmGridControl_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opmGridView.IsDataRow(opmGridView.FocusedRowHandle))
                return;
            
            if (Program.MF.EntryCheck("Ops.opMasterEditXF", isSilent: true))
            {
                int PK = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
                opMasterEditXF frm = new opMasterEditXF();
                frm.PK = PK;
                frm.iE = opmGridView.GetFocusedRowCellValue(colEDITABLE).ToString() == "T" ? true : false;
                frm.aE = opmGridView.GetFocusedRowCellValue(colEDITABLEACC).ToString() == "T" ? true : false;
                frm.orgForm = this;
                frm.Show();
                /*
                frm.ShowDialog();
                PK = frm.PK;
                frm.Dispose();

                this.opmSelTableAdapter.ClearBeforeFill = false;
                this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = {0}", PK));*/
            }
        }

        private void yeniKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Ops.opMasterEditXF", isSilent: true) && Program.MF.ModifyCheck("Ops.opMasterEditXF", isSilent: true))
            {
                int PK = 0; // Yeni kayit istegi
                opMasterEditXF frm = new opMasterEditXF();
                frm.PK = PK;
                frm.orgForm = this;
                frm.Show();
            }
        }

        private void printsItems()
        {
            string ROT = opmGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = opmGridView.GetFocusedRowCellValue(colMOT).ToString();

            YTtoolStripMenuItem.Enabled = rptItem("YT", ROT, MOT);
            MAWBtoolStripMenuItem.Enabled = rptItem("MAWB", ROT, MOT);
            CMtoolStripMenuItem.Enabled = rptItem("CM", ROT, MOT);
            ENStoolStripMenuItem.Enabled = rptItem("ENSF", ROT, MOT);
            PLtoolStripMenuItem.Enabled = rptItem("PL", ROT, MOT);
            STFMtoolStripMenuItem.Enabled = rptItem("STFM", ROT, MOT);
            SAMtoolStripMenuItem.Enabled = rptItem("SAM", ROT, MOT);
            /*
            YTtoolStripMenuItem.Enabled   = ROT == "E" && (MOT == "T" || MOT == "S");
            MAWBtoolStripMenuItem.Enabled = ROT == "E" && MOT == "A";
            CMtoolStripMenuItem.Enabled   = ROT == "E" && MOT == "A";
            RTFtoolStripMenuItem.Enabled  = ROT == "E" && MOT == "A";
            ENStoolStripMenuItem.Enabled  = ROT == "E" && MOT == "T";
            PLtoolStripMenuItem.Enabled   = ROT == "E" && MOT == "S";
            STFMtoolStripMenuItem.Enabled = ROT == "E" && MOT == "S";
            SAMtoolStripMenuItem.Enabled = ROT == "E";
            */
        }

        rptInfo rpti = new rptInfo();

        private bool rptItem(string kod, string ROT, string MOT)
        {
            MainDataSet.RPTRow rpt = Program.MF.mainDataSet.RPT.FindByKOD(kod);
            if (rpt == null)
                return false;
            return rpt.HM == "M" && (ROT == rpt.EXP || ROT == rpt.IMP) && (MOT == rpt.AIR || MOT == rpt.SEA || MOT == rpt.TRUCK || MOT == rpt.RAIL);
        }

        private void MAWBprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            MawbXR rpr = new MawbXR(OPMid, false);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("MAWB", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void MAWBprintAntetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            MawbXR rpr = new MawbXR(OPMid, true);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("MAWB", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void MAWBeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            MawbXR rpr = new MawbXR(OPMid, true);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail HAWB", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("MAWB", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail MAWB", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void CMprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            CargoManifestXR rpr = new CargoManifestXR(OPMid);
            
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("CM", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void CMeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            CargoManifestXR rpr = new CargoManifestXR(OPMid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Cargo Manifest", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("CM", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail CargoManifest", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);

        }

        private void YTeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            YuklemeTalimatiXR rpr = new YuklemeTalimatiXR(OPMid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Yükleme Talimatı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("YT", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail YüklemeTalimatı", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void YTprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            YuklemeTalimatiXR rpr = new YuklemeTalimatiXR(OPMid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("YT", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void ENSeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            
            ENSformXR rpr = new ENSformXR(OPMid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail ENS Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("ENSF", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail ENS Formu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void ENSprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            
            ENSformXR rpr = new ENSformXR(OPMid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("ENSF", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void RTFeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            
            RezervasyonTeyitFormXR rpr = new RezervasyonTeyitFormXR(OPMid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Rezervasyon Teyit Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("RTF", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail RezervasyonTeyitFormu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void RTFprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
    
            RezervasyonTeyitFormXR rpr = new RezervasyonTeyitFormXR(OPMid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("RTF", "OPM", OPMid, Program.USR, "F", "eMail");
                Program.MF.reportDone(rpti);
            }
        }

        private void PLprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            ParsiyelListesiXR rpr = new ParsiyelListesiXR(OPMid);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("PL", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void STFMprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            SerbestTeslimFormMasterXR rpr = new SerbestTeslimFormMasterXR(OPMid);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("STF", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void SAMprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            ShippingAdviceMasterXR rpr = new ShippingAdviceMasterXR(OPMid);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("SAM", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void SAMeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            ShippingAdviceMasterXR rpr = new ShippingAdviceMasterXR(OPMid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Shipping Advice Master", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("SAM", "OPM", OPMid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail ShippingAdviceMaster", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void demurrageClaimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            DmrgClaimXR rpr = new DmrgClaimXR(OPMid, Program.USR);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("DMRGC", "OPM", OPMid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }


        private void faturaLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OP";    // OpThis

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.IDtyp = "M";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLinkMHsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OPA";   // OpAll:M+Hs

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.IDtyp = "M";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLink2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.FaturaLink2XF", isSilent: true))
                return;

            int ID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OP";    // OpThis

            Account.FaturaLink2XF frm = new Account.FaturaLink2XF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLink2MHsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.FaturaLink2XF", isSilent: true))
                return;

            int ID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OPA";   // OpAll:M+Hs

            Account.FaturaLink2XF frm = new Account.FaturaLink2XF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void profitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.opMasterProfitXF", isSilent: true))
                return;

            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            opMasterProfitXF frm = new opMasterProfitXF();
            frm.OPMid = OPMid;
            frm.ShowDialog();
        }

        private void opmGridView_ShowFilterPopupDate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupDateEventArgs e)
        {
            if (e.Column.ColumnType.Name != "DateTime")
                return;
            DateTime yarin = DateTime.Today.AddDays(1);
            CriteriaOperator yarindanOnce = new BinaryOperator(e.Column.FieldName, yarin, BinaryOperatorType.Less);
            CriteriaOperator crit2 = new GroupOperator(GroupOperatorType.And, yarindanOnce);
            e.List.Add(new DevExpress.XtraEditors.FilterDateElement("Bugün ve Öncesi", string.Format("< {0:dd.MM.yy}", yarin), crit2));
        }

        private void onayIslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !opmGridView.IsDataRow(opmGridView.FocusedRowHandle))
                return;

            int PK = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = opmGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "OPM";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.opmSelTableAdapter.ClearBeforeFill = false;
            this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = {0}", PK), Program.USR);
        }

        private void onayAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !opmGridView.IsDataRow(opmGridView.FocusedRowHandle))
                return;

            int PK = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = opmGridView.GetFocusedRowCellDisplayText(colONYAYTK);
            frm.Tbl = "OPMA";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.opmSelTableAdapter.ClearBeforeFill = false;
            this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = {0}", PK), Program.USR);
        }

        private void markenAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string ROT = opmGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = opmGridView.GetFocusedRowCellValue(colMOT).ToString();
            
            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = OPMid;
            frm.HM = "M";
            frm.ROT = ROT;
            frm.MOT = MOT;

            frm.rptID = -1; // "taMrkn";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void agentAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPMid = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string ROT = opmGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = opmGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = OPMid;
            frm.HM = "M";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = -2; //  "taSAM";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void reportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.rphXF frm = new Genel.rphXF();

            frm.iQry = string.Format("RefTO = 'OPM' and RefID = {0}", opmGridView.GetFocusedRowCellValue(colOPMID));

            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.Export", isSilent: true))
                return;
            
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = opmGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Master", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void bioCreateChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opmGridView.IsDataRow(opmGridView.FocusedRowHandle))
                return;

            if (Program.MF.ModifyCheck("Ops.opHouseEditXF.bioDP", isSilent: false))
                opsQueriesTableAdapter.AFD_INS_MARKEN((int)opmGridView.GetFocusedRowCellValue(colOPMID), Program.USR);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Ops.opMasterXUC.opm";
            frm.origin = opmGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bosUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opmBosXF", isSilent: true))
                return;

            opmBosXF frm = new opmBosXF();
            frm.opmID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.ShowDialog();
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (opmGridView.IsDataRow(opmGridView.FocusedRowHandle))
            {
                Clipboard.SetText(opmGridView.GetFocusedRowCellDisplayText(opmGridView.FocusedColumn));
            }
        }

        private void houseProfitDenemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pvt.ophProfitXF frm = new Pvt.ophProfitXF();
            frm.mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.ophoXF frm = new Order.ophoXF();
            frm.usgTyp = "MasterOrders";
            frm.hID = 0;
            frm.iQry = string.Format("OPMID = {0}", opmGridView.GetFocusedRowCellValue(colOPMID));
            frm.Text = string.Format("Master #{0} Orders", opmGridView.GetFocusedRowCellValue(colOPMID));
            frm.Show();
        }

        private void bioThingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            // Updates OpsInfos
            opsQueriesTableAdapter.BIO_UPD_INFOS(mID);

            // Attach BioDmyInv
            BioDmyInvXR rpr = new BioDmyInvXR(mID);
            MemoryStream ms = new MemoryStream();
            rpr.ExportToPdf(ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            int len = (int)ms.Length;
            byte[] img = new byte[len];
            ms.Read(img, 0, len);
            ms.Close();
            opsQueriesTableAdapter.DOC_INS2("OPM", mID, "Marken Dummy Invoice", ".pdf", "MRKIN", Program.USR, len, img);

        }

        private void chargeCreateDenemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ophChargeCreateXF frm = new ophChargeCreateXF();
            frm.mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            frm.Show();
        }

        private void chargeCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            try
            {
                opsQueriesTableAdapter.OPH_CHARGE_INS(mID, Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void denemeTeklifFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            dnmTklfFtrXF frm = new dnmTklfFtrXF(mID);
            frm.Show();
        }

        private void teklifFaturaSadeceEAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Fatura oluşturulacaktır.  Eminmisiniz?", "Teklif -> Fatura", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;

            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            try
            {
                opsQueriesTableAdapter.TKLF_INS_FTR(mID, Program.USR);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Insert Fatura");
            }
        }

        private void traxonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            if (opmGridView.GetFocusedRowCellValue(colROT).ToString() == "E" &&
                opmGridView.GetFocusedRowCellValue(colMOT).ToString() == "A")
            {
                Traxon.Trx2XF frm = new Traxon.Trx2XF();
                frm.mID = mID;
                frm.Show();
            }
        }

        private void t1EMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string ROT = opmGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = opmGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "M";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = 600;  // --T1
            frm.ShowDialog();
            frm.Dispose();

        }

        private void alisFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMaster.TeklifFtrAlsXF", isSilent: true))
                return;

            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);
            string Editable = opmGridView.GetFocusedRowCellValue(colEDITABLEACC).ToString();

            Teklif.TeklifFtrAlsXF frm = new Teklif.TeklifFtrAlsXF();
            frm.mID = mID;
            frm.Editable = Editable;
            frm.Show();
        }

        private void kaliteKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OpID = (int)opmGridView.GetFocusedRowCellValue("OPMID");
            KaliteKontrol.kkoXF frm = new KaliteKontrol.kkoXF();
            frm.OpHM = "M";
            frm.OpID = OpID;
            frm.Show();
        }

        private void quickSearcedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Pvt.opmPvtXF", isSilent: false))
                return;

            Pvt.opmPvtXF frm = new Pvt.opmPvtXF();
            frm.iQry = qsFrm.qsQry;  //qryStr;
            frm.Show();
        }

        private void queriedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Pvt.opmPvtXF", isSilent: false))
                return;

            Pvt.opmPvtXF frm = new Pvt.opmPvtXF();
            frm.iQry = qryStr;
            frm.Show();
        }

        private void pvtNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Raporlar Pivot Network
            if (!Program.MF.EntryCheck("Pvt.PvtNetworkXF", isSilent: false))
                return;

            Pvt.PvtNetworkXF frm = new Pvt.PvtNetworkXF();
            frm.Show();
        }

        private void pDPCollectionManifestTunasetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            Pvt.RprPdpExcelXF frm = new Pvt.RprPdpExcelXF();
            frm.mID = mID;
            frm.Show();

        }

        private void rDPCollectionManifestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // IPTAL
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            Pvt.RdpColMnfXF frm = new Pvt.RdpColMnfXF();
            frm.opmID = mID;
            frm.Show();
        }

        private void collectionManifestGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // IPTAL
            int mID = (int)opmGridView.GetFocusedRowCellValue(colOPMID);

            Pvt.rprCMgridFX frm = new Pvt.rprCMgridFX();
            frm.opmID = mID;
            frm.Show();
        }

        private void kPISetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = opmGridView;
            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (!Program.MF.EntryCheck("Genel.KpiSetXF", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colOPMID);
            Genel.KpiSetXF frm = new Genel.KpiSetXF();
            frm.Tbl = "OPM";
            frm.TblPK = PK;
            frm.KPI = view.GetFocusedRowCellValue(colKPI).ToString();
            frm.ShowDialog();
            frm.Dispose();

            this.opmSelTableAdapter.ClearBeforeFill = false;
            this.opmSelTableAdapter.Fill(this.opsDataSet.OPM_SEL, string.Format("OPMid = {0}", PK), Program.USR);

        }


    }
}
