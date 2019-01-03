using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using DevExpress.XtraReports;
using tMax14ReportClassLibrary;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars.Docking;
using DevExpress.Data.Filtering;
using DevExpress.XtraPrinting;

namespace tMax14.Ops
{
    public partial class opHouseXUC : DevExpress.XtraEditors.XtraUserControl
    {
        //Docs.docForm docFrm;
        Ops.opMasterXUC opMasterFrm;
        string qryPrmStr = string.Empty;
        FirebirdSql.Data.FirebirdClient.FbCommand activeFbCommand = new FirebirdSql.Data.FirebirdClient.FbCommand();
        DockPanel editPanel;

        public int OPMID = 0;   // 0:dynamicQuery else FillBy OPMid
        public string qsString = string.Empty;
        string layoutName = "Ops.opHouseXUC.oph";

        public opHouseXUC()
        {
            InitializeComponent();
        
            ophGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colORD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDRBD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDPOGIRTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDPOCIKTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDRCD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colEXD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colWBD.ColumnEdit = Program.MF.trhRepositoryItemDateEdit;
            colRRT.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colEOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colATR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            //colROC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colAOC.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colONYTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            
            
            colOWNR.ColumnEdit = Program.MF.OWNRrepositoryItemImageComboBox;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;

            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit; // locRepositoryItemPopupContainerEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit; // locRepositoryItemPopupContainerEdit;

            colSHPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colCNEID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;  //frtRepositoryItemSearchLookUpEdit;  GECICI
            colMNFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNFYID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colNF2ID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAGNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDCNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colHSRFID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;

            colRCPID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colDLVID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colPRJID.ColumnEdit = Program.MF.PRTrepositoryItemSearchLookUpEdit;

            colNSTU.ColumnEdit = Program.MF.OpsStuNrmRepositoryItemLookUpEdit;
            colPSTU.ColumnEdit = Program.MF.OpsStuPrbRepositoryItemLookUpEdit;

            colDTM.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colDTP.ColumnEdit = Program.MF.DTPrepositoryItemLookUpEdit;
            colPTM.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colPOR.ColumnEdit = Program.MF.PORrepositoryItemLookUpEdit;
            colTOL.ColumnEdit = Program.MF.TOLrepositoryItemLookUpEdit;
            colPAG.ColumnEdit = Program.MF.PAGrepositoryItemCheckedComboBoxEdit;
            colTOS.ColumnEdit = Program.MF.TOSrepositoryItemLookUpEdit;
            colITOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;

            colTRO.ColumnEdit = Program.MF.OpsTrOrepositoryItemCheckedComboBoxEdit; //OpsTrOrepositoryItemLookUpEdit;
            colTRS.ColumnEdit = Program.MF.OpsTrSrepositoryItemCheckedComboBoxEdit; //OpsTrSrepositoryItemLookUpEdit;

            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colEDITABLEACC.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colB_DLGONDER.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colB_DLDONDU.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colB_KUTUGONDER.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colB_KUTUDONDU.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colVGM.ColumnEdit = Program.MF.OphVGMrepositoryItemImageComboBox;

            //ophGridControl.DataSource = this.opsDataSet.OPH_SEL;
            Program.MF.GridControlSettings(ophGridControl);

            ophGridView.OptionsView.ShowGroupPanel = true;

            ophGridView.FormatConditions[0].Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);

            var gridView = ophGridView;
            gridView.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            gridView.OptionsFilter.UseNewCustomFilterDialog = true;

            /*
            for (int i = 0; i < this.opsDataSet.OPH_SEL.Columns.Count; i++)
                if (this.opsDataSet.OPH_SEL.Columns[i].DataType.Name == "DateTime")
                {
                    gridView.Columns[this.opsDataSet.OPH_SEL.Columns[i].ColumnName].OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.Date;
                    gridView.Columns[this.opsDataSet.OPH_SEL.Columns[i].ColumnName].OptionsFilter.ShowEmptyDateFilter = true;
                }
            */
            Program.MF.XGLrestore(layoutName, 0, ophGridView);
        }

        private void ophGridView_Layout(object sender, EventArgs e)
        {
            //Program.MF.XGLsave(layoutName, 0, ophGridView);
        }

        private void opHouseXUC_Load(object sender, EventArgs e)
        {
            Qry.qsOphXF frm = new Qry.qsOphXF();
            frm.OPH = opsDataSet.OPH_SEL;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);
            
            if (OPMID != 0)
            {
                NewId(OPMID);
            }
            else if (!string.IsNullOrEmpty(qsString))
            {
                int nor = 0;
                Program.MF.startSW();
                try
                {
                    nor = this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, qsString, Program.USR);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    Program.MF.stopSW("OpsHouse", nor);
                }
            }
        }

        private void ophGridControl_Enter(object sender, EventArgs e)
        {
            NewId(OPMID);
        }

        private void ophGridControl_Leave(object sender, EventArgs e)
        {

        }

        public void NewId(int id)
        {
            if (ophGridView.IsEditing)
                ophGridView.UpdateCurrentRow();

            if (id != 0)
            {
                OPMID = id;
                this.ophSelTableAdapter.ClearBeforeFill = true;
                this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, string.Format("OPMid = '{0}'", OPMID), Program.USR);
            }
            else
                reQuery();
        }
        
        public void Save()
        {
            this.Validate();
            this.ophSelBindingSource.EndEdit();
            this.ophSelTableAdapter.Update(this.opsDataSet.OPH_SEL);
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ophGridView.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "OPH";
            frm.RefID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            frm.RefInfo = ophGridView.GetFocusedRowCellDisplayText(colOPHID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ophGridView.DataRowCount == 0 || ophGridView.GetFocusedRowCellValue(colOPMID) == DBNull.Value)
                return;

          
            bool panelYok = true;
            for (int i = 0; i < dockManager.Panels.Count; i++)
            {
                if (dockManager.Panels[i].Name == "opmPanel")
                {
                    dockManager.Panels[i].Show();
                    panelYok = false;
                }
            }
            if (panelYok)
            {
                int id = (int)ophGridView.GetFocusedRowCellValue(colOPMID);
                var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Bottom);
                panel.Name = "opmPanel";
                panel.Options.ShowCloseButton = true;

                opMasterFrm = new opMasterXUC();
                opMasterFrm.OPMID = id;
                panel.Text = string.Format("H{0} / M{1}", ophGridView.GetFocusedRowCellDisplayText(colOPHID), ophGridView.GetFocusedRowCellDisplayText(colOPMID));
                opMasterFrm.Dock = DockStyle.Fill;
                panel.Controls.Add(opMasterFrm);     // Panel Show edilene kadar FormLoad cagrilmiyor
            }
        }

        private void ophGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (opMasterFrm != null)
            {
                if (e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle ||
                    e.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle ||
                    !ophGridView.IsDataRow(e.FocusedRowHandle))
                    opMasterFrm.NewId(DBNull.Value);
                else
                {
                    if (ophGridView.GetFocusedRowCellValue(colOPMID) == DBNull.Value)
                    {
                        dockManager.Panels["opmPanel"].Text = string.Format("H{0}", ophGridView.GetFocusedRowCellDisplayText(colOPHID));
                        opMasterFrm.NewId(DBNull.Value);
                    }
                    else
                    {
                        object aa = ophGridView.GetFocusedRowCellDisplayText(colOPHID);
                        object bb = ophGridView.GetFocusedRowCellDisplayText(colOPMID);
                        dockManager.Panels["opmPanel"].Text = string.Format("H{0} / M{1}", ophGridView.GetFocusedRowCellDisplayText(colOPHID), ophGridView.GetFocusedRowCellDisplayText(colOPMID));
                        opMasterFrm.NewId(ophGridView.GetFocusedRowCellValue(colOPMID));
                    }
                }
            }

        }

        private void ophGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            ophGridView.SetRowCellValue(e.RowHandle, colOPHID, Program.MF.mainQueriesTableAdapter.GET_PK("OPS"));   // House&Master ayni Generator kullanir
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            Program.QPF.TBL = "OPH";
            if (Program.QPF.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            string qryStr = Program.QPF.prepareQryStr();    //prepareCommandString(qryPrmStr);
            if (!string.IsNullOrEmpty(qryStr))
            {
                int nor = 0;
                Program.MF.startSW();
                try
                {
                    this.ophSelTableAdapter.ClearBeforeFill = true;
                    nor = this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, qryStr, Program.USR);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                finally
                {
                    Program.MF.stopSW("OpsHouse", nor);
                }
            }
        }

        private void reQuery()  // Calismiyor, Query degisti
        {/*
            if (!string.IsNullOrEmpty(activeFbCommand.CommandText))
            {
                //DataTable dt = (DataTable)this.opsDataSet.OPH;
                Program.QPF.reQry((DataTable)this.opsDataSet.OPH, activeFbCommand);
            }*/
        }

        public void refreshRow(int PK)
        {
            this.ophSelTableAdapter.ClearBeforeFill = false;
            this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, string.Format("OPHid = '{0}'", PK), Program.USR);

        }

        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ophGridView.IsDataRow(ophGridView.FocusedRowHandle))
                return;

            if (Program.MF.EntryCheck("Ops.opHouseEditXF", isSilent: true))
            {
                int PK = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
                opHouseEditXF frm = new opHouseEditXF();
                frm.PK = PK;
                frm.iE = ophGridView.GetFocusedRowCellValue(colEDITABLE).ToString() == "T" ? true : false;
                frm.aE = ophGridView.GetFocusedRowCellValue(colEDITABLEACC).ToString() == "T" ? true : false;
                frm.orgForm = this;
                frm.Show();

                /*
                frm.ShowDialog();
                PK = frm.PK;
                frm.Dispose();

                this.ophSelTableAdapter.ClearBeforeFill = false;
                this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, string.Format("OPHid = {0}", PK));
                */

                /*
                var view = ophGridView;

                frm.Dock = DockStyle.Fill;
                var dd = frm.Size.Height;
            
                if (editPanel == null)
                {
                    editPanel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                    editPanel.Text = "DENEME";
                    editPanel.FloatSize = new Size(frm.Size.Width, frm.Size.Height);
                    editPanel.ControlContainer.Controls.Add(frm);
                }
                else
                {
                    editPanel.Show();
                    //DockPanel panel = new DockPanel();
                    //panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                    //panel.ControlContainer.Controls.Add(frm);
                    //panel.DockTo(editPanel, DockingStyle.Fill);

                    var panel2 = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
                    //var panel2 = editPanel.AddPanel();
                    panel2.ControlContainer.Controls.Add(frm);
                    panel2.DockAsTab(editPanel);
                    var aa =  editPanel.ParentPanel.Count;
                
                }
                */
            }
        }

        private void yeniKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Ops.opHouseEditXF", isSilent: true) && Program.MF.ModifyCheck("Ops.opHouseEditXF", isSilent: true))
            {
                int PK = 0; //New
                opHouseEditXF frm = new opHouseEditXF();
                frm.PK = PK;
                frm.orgForm = this;
                frm.Show();
            }
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "OPH";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = ophGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                ophGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                ophGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                ophGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                ophGridView.UpdateCurrentRow();
            }
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ophGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !ophGridView.IsDataRow(ophGridView.FocusedRowHandle))
                return;

            int PK = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = ophGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "OPH";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.ophSelTableAdapter.ClearBeforeFill = false;
            this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, string.Format("OPHid = {0}", PK), Program.USR);
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (ophGridView.RowCount == 0)
            {
                for (int i = 0; i < contextMenuStrip.Items.Count; i++)
                    contextMenuStrip.Items[i].Enabled = false;
                queryToolStripMenuItem.Enabled = true;
            }
            else
            {
                for (int i = 0; i < contextMenuStrip.Items.Count; i++)
                    contextMenuStrip.Items[i].Enabled = true;

                if (OPMID != 0)
                    queryToolStripMenuItem.Enabled = false;

                printsItems();

                editToolStripMenuItem.Enabled = Program.MF.EntryCheck("Ops.opHouseEditXF", true);
                printsToolStripMenuItem.Enabled = Program.MF.EntryCheck("Ops.opHouse.Print", true);
                reportHistoryToolStripMenuItem.Enabled = Program.MF.EntryCheck("Genel.rphXF", true);
                faturaLinkToolStripMenuItem.Enabled = Program.MF.EntryCheck("Account.FaturaLinkXF", true);
                exportToolStripMenuItem.Enabled = Program.MF.EntryCheck("Ops.opHouse.Export", true);
            }

            yeniKayitToolStripMenuItem.Enabled = Program.MF.EntryCheck("Ops.opHouseEditXF", true) && Program.MF.ModifyCheck("Ops.opHouseEditXF", true);
        }

        #region Prints

        private void printsItems()
        {
            if (!ophGridView.IsDataRow(ophGridView.FocusedRowHandle))
                return;
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            HAWBtoolStripMenuItem.Enabled = rptItem("HAWB", ROT, MOT);
            PSAtoolStripMenuItem.Enabled = rptItem("PSA", ROT, MOT);
            SAtoolStripMenuItem.Enabled = rptItem("SA", ROT, MOT);
            if (ROT == "Z")
                PODtoolStripMenuItem.Enabled = rptItem("POD", "I", "A");
            else
                PODtoolStripMenuItem.Enabled = rptItem("POD", ROT, MOT);
            FBLtoolStripMenuItem.Enabled = rptItem("FBL", ROT, MOT);
            FCRtoolStripMenuItem.Enabled = rptItem("FCR", ROT, MOT);
            CItoolStripMenuItem.Enabled = rptItem("CI", ROT, MOT);
            VItoolStripMenuItem.Enabled = rptItem("VI", ROT, MOT);
            STFHtoolStripMenuItem.Enabled = rptItem("STFH", ROT, MOT);
            ABFtoolStripMenuItem.Enabled = rptItem("ABF", ROT, MOT);
            RTFtoolStripMenuItem.Enabled = rptItem("RTF", ROT, MOT);
            /*
            HAWBtoolStripMenuItem.Enabled = ROT == "E" && MOT == "A";
            PSAtoolStripMenuItem.Enabled = ROT == "E" && (MOT == "S" || MOT == "A");
            SAtoolStripMenuItem.Enabled   = ROT == "E";
            PODtoolStripMenuItem.Enabled  = true;
            FBLtoolStripMenuItem.Enabled  = ROT == "E" && (MOT == "S" || MOT == "T");
            FCRtoolStripMenuItem.Enabled  = ROT == "E" && (MOT == "S" || MOT == "T");
            CItoolStripMenuItem.Enabled   = ROT == "I";
            VItoolStripMenuItem.Enabled   = ROT == "I";
            STFHtoolStripMenuItem.Enabled = ROT == "E" && (MOT == "S" || MOT == "T");
            ABFtoolStripMenuItem.Enabled  = ROT == "E" && MOT == "A";
            */
        }

        private bool rptItem(string kod, string ROT, string MOT)
        {
            MainDataSet.RPTRow rpt = Program.MF.mainDataSet.RPT.FindByKOD(kod);
            if (rpt == null)
                return false;
            return rpt.HM == "H" && (ROT == rpt.EXP || ROT == rpt.IMP) && (MOT == rpt.AIR || MOT == rpt.SEA || MOT == rpt.TRUCK || MOT == rpt.RAIL);
        }

        rptInfo rpti = new rptInfo();

        private void PSAeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            PreShippingAdviceXR rpr = new PreShippingAdviceXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail PreShippingAdvice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("PSA", "OPH", OPHid, Program.USR, "F", "eMail"); 
            MailClass.MailReportTask(rpti, "eMail PreShippingAdvice", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void PSAprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            PreShippingAdviceXR rpr = new PreShippingAdviceXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("PSA", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void SAeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            ShippingAdviceHouseXR rpr = new ShippingAdviceHouseXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail ShippingAdvice", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("SAH", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail ShippingAdvice", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void SAprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            ShippingAdviceHouseXR rpr = new ShippingAdviceHouseXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("SAH", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void PODeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            ProofOfDeliveryXR rpr = new ProofOfDeliveryXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail POD", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("POD", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail POD", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void PODprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            ProofOfDeliveryXR rpr = new ProofOfDeliveryXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("POD", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void HAWBprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HawbXR rpr = new HawbXR(OPHid, false);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("HAWB", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void HAWBprintAntetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HawbXR rpr = new HawbXR(OPHid, true);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("HAWB", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void HAWBeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HawbXR rpr = new HawbXR(OPHid, true);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail HAWB", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("HAWB", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail Çıkış İhbarı", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void hBLPrintAntetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HblXR rpr = new HblXR(OPHid, true);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("HBL", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void hBLPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HblXR rpr = new HblXR(OPHid, false);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("HBL", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void hBLEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            HblXR rpr = new HblXR(OPHid, true);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail FBL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("FBL", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail FBL", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }


        private void FBLprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FblXR rpr = new FblXR(OPHid, false);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("FBL", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void FBLprintAntetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FblXR rpr = new FblXR(OPHid, true);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("FBL", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void FBLeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FblXR rpr = new FblXR(OPHid, true);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail FBL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("FBL", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail FBL", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void FCRprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FcrXR rpr = new FcrXR(OPHid, false);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("FCR", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void FCRprintAntetliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FcrXR rpr = new FcrXR(OPHid, true);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("FCR", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void FCReMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            FcrXR rpr = new FcrXR(OPHid, true);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail FCR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("FCR", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail FCR", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void CIeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            CikisIhbariXR rpr = new CikisIhbariXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Çıkış İhbarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("CI", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail Çıkış İhbarı", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void CIprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            CikisIhbariXR rpr = new CikisIhbariXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("CI", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void VIeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            int ihbarNo = Convert.ToInt32(ihbarNoToolStripComboBox.Text);

            VarisIhbarXR rpr = new VarisIhbarXR(OPHid, ihbarNo);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Varış İhbarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("VI", "OPH", OPHid, Program.USR, "F", string.Format("eMail IhbNo:{0}", ihbarNo));
            MailClass.MailReportTask(rpti, "eMail Varış İhbarı", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void VIprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            int ihbarNo = Convert.ToInt32(ihbarNoToolStripComboBox.Text);
            VarisIhbarXR rpr = new VarisIhbarXR(OPHid, ihbarNo);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("VI", "OPH", OPHid, Program.USR, "F", string.Format("IhbNo:{0}", ihbarNo));
                Program.MF.reportDone(rpti);
            }
        }

        private void VI3eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            int ihbarNo = Convert.ToInt32(ihbarNoToolStripComboBox.Text);

            VarisIhbarSonXR rpr = new VarisIhbarSonXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Varış İhbarı SON", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("VI3", "OPH", OPHid, Program.USR, "F", "Son Ihbar");
            MailClass.MailReportTask(rpti, "eMail Varış İhbarı SON", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void VI3printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            int ihbarNo = Convert.ToInt32(ihbarNoToolStripComboBox.Text);
            VarisIhbarSonXR rpr = new VarisIhbarSonXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("VI3", "OPH", OPHid, Program.USR, "F", "Son Ihbar");
                Program.MF.reportDone(rpti);
            }
        }

        private void STFHeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            SerbestTeslimFormHouseXR rpr = new SerbestTeslimFormHouseXR(OPHid);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Serbest Teslim Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("STFH", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail Serbest Teslim Formu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);

        }

        private void STFHprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            SerbestTeslimFormHouseXR rpr = new SerbestTeslimFormHouseXR(OPHid);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("STFH", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void ABFprintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            AcentaBeyanFormuXR rpr = new AcentaBeyanFormuXR(OPHid);
            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("ABF", "OPH", OPHid, Program.USR, "F", null);
                Program.MF.reportDone(rpti);
            }
        }

        private void topluVarisIhbariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = -5; // "taVI";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void topluCikisIhbariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = -4; // "taCI";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void topluShippingAdviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = -3;  // "taSAH";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void markenHAWBRequestMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            MrkHAWBrequestXR rpr = new MrkHAWBrequestXR(OPHid);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Marken HAWB Request Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("MHAWBRF", "OPH", OPHid, Program.USR, "F", "eMail");

            MailClass.MailReportAsBodyTask(rpti, "eMail Marken HAWB Request Form", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        #endregion Prints

        private void faturaLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.FaturaLink2XF", isSilent: true))
                return;

            int ID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string IDskl = "OP";    // OpThis

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.IDtyp = "H";
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLinkMHsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.FaturaLink2XF", isSilent: true))
                return;

            if (ophGridView.GetFocusedRowCellValue(colOPMID) == DBNull.Value)
                return;

            int ID = (int)ophGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OPA";   // OpAll:M+Hs

            Account.FaturaLinkXF frm = new Account.FaturaLinkXF();
            frm.ID = ID;
            frm.IDtyp = "H";
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLink2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.FaturaLink2XF", isSilent: true))
                return;

            int ID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string IDskl = "OP";    // OpThis

            Account.FaturaLink2XF frm = new Account.FaturaLink2XF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void faturaLink2MHsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.FaturaLink2XF", isSilent: true))
                return;

            if (ophGridView.GetFocusedRowCellValue(colOPMID) == DBNull.Value)
                return;

            int ID = (int)ophGridView.GetFocusedRowCellValue(colOPMID);
            string IDskl = "OPA";   // OpAll:M+Hs

            Account.FaturaLink2XF frm = new Account.FaturaLink2XF();
            frm.ID = ID;
            frm.IDskl = IDskl;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void reportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.rphXF frm = new Genel.rphXF();

            frm.iQry = string.Format("RefTO = 'OPH' and RefID = {0}", ophGridView.GetFocusedRowCellValue(colOPHID));

            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!Program.MF.EntryCheck("Ops.opHouse.Export", isSilent: true))
                return;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = ophGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "House", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void ophGridView_ShowFilterPopupDate(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupDateEventArgs e)
        {
            if (e.Column.ColumnType.Name != "DateTime")
                return;
            //if (e.Column.FieldName != "Column2") return;
            //     e.List.Clear();
            /*
            DateTime firstDayOfThisYear = new DateTime(DateTime.Today.Year, 1, 1);
            DateTime firstDayOfLastYear = firstDayOfThisYear.AddYears(-1);

            CriteriaOperator lastYear = new BinaryOperator(e.Column.FieldName, firstDayOfLastYear, BinaryOperatorType.GreaterOrEqual);
            CriteriaOperator thisYear = new BinaryOperator(e.Column.FieldName, firstDayOfThisYear, BinaryOperatorType.Less);
            CriteriaOperator crit = new GroupOperator(GroupOperatorType.And, lastYear, thisYear);
            e.List.Add(new DevExpress.XtraEditors.FilterDateElement("Last Year2", "aaaaaaaaaaaaaaaaa", crit));
            */
            DateTime yarin = DateTime.Today.AddDays(1);
            CriteriaOperator yarindanOnce = new BinaryOperator(e.Column.FieldName, yarin, BinaryOperatorType.Less);
            CriteriaOperator crit2 = new GroupOperator(GroupOperatorType.And, yarindanOnce);
            e.List.Add(new DevExpress.XtraEditors.FilterDateElement("Bugün ve Öncesi", string.Format("< {0:dd.MM.yy}", yarin), crit2));
            //DevExpress.XtraEditors.FilterDateElement(
        }

        private void ophGridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            if (e.RowHeight > 100)
                e.RowHeight = 100;
        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ophGridView.OptionsView.ShowPreview = showPreviewToolStripMenuItem.Checked;
            colINFO.Visible = !showPreviewToolStripMenuItem.Checked;
        }

        private void rowAutoHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ophGridView.OptionsView.RowAutoHeight = rowAutoHeightToolStripMenuItem.Checked;
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Ops.opHouseXUC.oph";
            frm.origin = ophGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void bosUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.ophBosXF", isSilent: true))
                return;

            ophBosXF frm = new ophBosXF();
            frm.ophID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            frm.ShowDialog();
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ophGridView.IsDataRow(ophGridView.FocusedRowHandle))
            {
                Clipboard.SetText(ophGridView.GetFocusedRowCellDisplayText(ophGridView.FocusedColumn));
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ophGridView.IsDataRow(ophGridView.FocusedRowHandle))
                return;

            Order.ophoXF frm = new Order.ophoXF();
            frm.usgTyp = "HouseOrders";
            frm.hID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            frm.iQry = string.Format("OPHID = {0}", frm.hID);
            frm.Text = string.Format("House #{0} Orders", frm.hID);
            frm.hLinkQry = string.Format("OPHID is null and STU <> 'C' and PAG is not null and GSAAD is not null and AAD is not null and QCPD is not null and MOT = '{0}' and SHPID = {1} and CNEID = {2}", ophGridView.GetFocusedRowCellValue(colMOT), ophGridView.GetFocusedRowCellValue(colSHPID), ophGridView.GetFocusedRowCellValue(colCNEID));
            //frm.hLinkQry = string.Format("OPHID = {0} or (OPHID is null and STU <> 'C' and PAG is not null and GSAAD is not null and AAD is not null and QCPD is not null and MOT = '{1}' and SHPID = {2} and CNEID = {3})", ophGridView.GetFocusedRowCellValue(colOPHID), ophGridView.GetFocusedRowCellValue(colMOT), ophGridView.GetFocusedRowCellValue(colSHPID), ophGridView.GetFocusedRowCellValue(colCNEID));
            frm.Show();
        }

        private void ordinoEtiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            OrdinoEtiketXR rpr = new OrdinoEtiketXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void ordinoTeslimFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            OrdinoTeslimFormuXR rpr = new OrdinoTeslimFormuXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
            }
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            RezervasyonTeyitFormXR rpr = new RezervasyonTeyitFormXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Rezervasyon Teyit Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("RTF", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "eMail Rezervasyon Teyit Formu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            RezervasyonTeyitFormXR rpr = new RezervasyonTeyitFormXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("RTF", "OPH", OPHid, Program.USR, "F", "Print");
                Program.MF.reportDone(rpti);
            }
        }

        private void markenAWBAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = 400;  // --MAWA Marken Airwaybill Alert
            frm.ShowDialog();
            frm.Dispose();
        }

        private void icNakliyeBilgisiEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IcNakliyeBilgisiXR rpr = new IcNakliyeBilgisiXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "İç Nakliye Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (XtraMessageBox.Show(string.Format("Mail gonderilecekler: {0}", rpr.eMails), "İç Nakliye Bilgisi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                rpti.put("INB", "OPH", OPHid, Program.USR, "F", "eMail");
                //MailClass.MailReportTask(rpti, "İç Nakliye Bilgisi", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
                MailClass.MailReportAsBodyTask(rpti, "İç Nakliye Bilgisi", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
            }

        }

        private void icNakliyeBilgisiPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IcNakliyeBilgisiXR rpr = new IcNakliyeBilgisiXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("INB", "OPH", OPHid, Program.USR, "F", "Print");
                Program.MF.reportDone(rpti);
            }

        }

        private void icNakliyeTalimatiEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IcNakliyeTalimatiXR rpr = new IcNakliyeTalimatiXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "İç Nakliye Talimatı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("INT", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "İç Nakliye Talimatı", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
        }

        private void icNakliyeTalimatiPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IcNakliyeTalimatiXR rpr = new IcNakliyeTalimatiXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("INT", "OPH", OPHid, Program.USR, "F", "Print");
                Program.MF.reportDone(rpti);
            }

        }

        private void icNakliyeTalimatiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ıcNakliyeBilgisiEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            string ROT = ophGridView.GetFocusedRowCellValue(colROT).ToString();
            string MOT = ophGridView.GetFocusedRowCellValue(colMOT).ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = 510;  // --IcNakliyeBilgisi
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ihracatciGuvenlikFormuEMailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IhracatciGuvenlikFormuXR rpr = new IhracatciGuvenlikFormuXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "İhracatcı Güvenlik Formu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("IGF", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "İhracatcı Güvenlik Formu", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody, "RTF");
        }

        private void ihracatciGuvenlikFormuPrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            IhracatciGuvenlikFormuXR rpr = new IhracatciGuvenlikFormuXR(OPHid);

            using (ReportPrintTool printTool = new ReportPrintTool(rpr))
            {
                printTool.ShowPreviewDialog();
                rpti.put("IGF", "OPH", OPHid, Program.USR, "F", "Print");
                Program.MF.reportDone(rpti);
            }
        }

        private void kaliteKontrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OpID = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            KaliteKontrol.kkoXF frm = new KaliteKontrol.kkoXF();
            frm.OpHM = "H";
            frm.OpID = OpID;
            frm.Show();
        }

        private void aktarmaBilgilendirmeEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            AktarmaBilgilendirmeXR rpr = new AktarmaBilgilendirmeXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Aktarma Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("AKTB", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "Aktarma Bilgilendirme", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody, "");  // NoAttachment
        }

        private void gumrukBilgisiEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            GumrukBilgisiXR rpr = new GumrukBilgisiXR(OPHid);

            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Gümrük Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("GB", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "Gümrük Bilgisi", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody, "");  // NoAttachment
        }

        private void teslimEvragiEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int opID = (int)ophGridView.GetFocusedRowCellValue("OPHID");
            string ROT = ophGridView.GetFocusedRowCellValue("ROT").ToString();
            string MOT = ophGridView.GetFocusedRowCellValue("MOT").ToString();

            TopluAlertXF frm = new TopluAlertXF();
            frm.USR = Program.USR;
            frm.USReMail = Program.USReMail;
            frm.opID = opID;
            frm.HM = "H";
            frm.ROT = ROT;
            frm.MOT = MOT;
            frm.rptID = 605;  // --TSLM TeslimEvragi
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ozetBeyanEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OPHid = (int)ophGridView.GetFocusedRowCellValue(colOPHID);

            rprOztbTableAdapter.Fill(opsDataSet.RPR_OZTB, OPHid);

            string eMails = opsDataSet.RPR_OZTB.Rows[0]["EMAILS"].ToString();
            string eMailSubject = opsDataSet.RPR_OZTB.Rows[0]["EMAILSUBJECT"].ToString();
            string eMailBody = opsDataSet.RPR_OZTB.Rows[0]["EMAILBODY"].ToString();

            if (string.IsNullOrWhiteSpace(eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "Ozet Beyan", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            rpti.put("OZTB", "OPH", OPHid, Program.USR, "F", "eMail");
            MailClass.MailReportTask(rpti, "Ozet Beyan", null, eMails, eMailSubject, eMailBody, "");  // NoAttachment
        }

        private void kPISetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = ophGridView;
            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            if (!Program.MF.EntryCheck("Genel.KpiSetXF", false))
                return;

            int PK = (int)view.GetFocusedRowCellValue(colOPHID);
            Genel.KpiSetXF frm = new Genel.KpiSetXF();
            frm.Tbl = "OPH";
            frm.TblPK = PK;
            frm.KPI = view.GetFocusedRowCellValue(colKPI).ToString();
            frm.ShowDialog();
            frm.Dispose();

            this.ophSelTableAdapter.ClearBeforeFill = false;
            this.ophSelTableAdapter.Fill(this.opsDataSet.OPH_SEL, string.Format("OPHid = {0}", PK), Program.USR);

        }

        private void gorulduOnayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.GRO", isSilent: false))
                return;

            int PK = (int)ophGridView.GetFocusedRowCellValue(colOPHID);
            Program.MF.GorulduOnayEkle("OPH", PK);
            ophGridView.SetFocusedRowCellValue(colGROUSR, Program.USR);
            ophGridView.SetFocusedRowCellValue(colGROTRH, DateTime.Now);
        }
    }
}
