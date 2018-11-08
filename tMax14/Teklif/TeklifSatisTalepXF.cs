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
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraRichEdit;
using System.IO;
using System.Net.Mail;
using tMax14ReportClassLibrary;

namespace tMax14.Teklif
{
    public partial class TeklifSatisTalepXF : DevExpress.XtraEditors.XtraForm
    {
        bool editable, fytVisible;
        string layoutNameTalep = "Teklif.TeklifSatisTalepXF";
        string layoutNameTeklif = "Teklif.TeklifSatisTalepTeklifXF";
        string hdrTmp;

        public TeklifSatisTalepXF() 
        {
            if (!Program.MF.EntryCheck("Teklif.TeklifSatisTalepXF", false))
            {
                Shown += (s, e) => Close();
                return;
            }

            InitializeComponent();


            tstGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDt.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colCRRIDt.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCIDt.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colBRMf.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colSDVZf.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            
            colROTt.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTt.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            
            colORGSt.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colDSTSt.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colPOLSt.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;
            colPOUSt.ColumnEdit = Program.MF.locRepositoryItemCheckedComboBoxEdit;

            colPTMt.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colDTMt.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colTOPt.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colSDVZt.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colPRVTt.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colPRVTUSRSt.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

            colKMGFt.ColumnEdit = Program.MF.KMGrepositoryItemLookUpEdit;
            colKMGCt.ColumnEdit = Program.MF.KMGrepositoryItemLookUpEdit;
            colKMGGt.ColumnEdit = Program.MF.KMGrepositoryItemLookUpEdit;

            colSTUt.ColumnEdit = Program.MF.TklfStuRepositoryItemImageComboBox;
            colTYPt.ColumnEdit = Program.MF.TklfTypRepositoryItemImageComboBox;
            colINFOt.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;

            colTOBt.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colSLSUSRt.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            //colSLSUSRt.ColumnEdit = Program.MF.ustListRepositoryItemCheckedComboBoxEdit;
            //colBKMSt.ColumnEdit = Program.MF.BKMt;

            colEditable.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colVisible.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colALLIN.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colCUSLOCID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colADR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTOPS.ColumnEdit = Program.MF.TOPrepositoryItemCheckedComboBoxEdit;
            colCRRIDS.ColumnEdit = Program.MF.FRTcrrRepositoryItemCheckedComboBoxEdit;
            colRFSTYP.ColumnEdit = Program.MF.TstRfsTypRositoryItemLookUpEdit;

            colASKt.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(tstGridControl);

            tsfGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAHTIDf.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colORGf.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDSTf.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colCRRIDf.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colBRMf.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colADVZf.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colSDVZf.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colTOPf.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colKMGf.ColumnEdit = Program.MF.KMGrepositoryItemLookUpEdit;

            //colHMf.ColumnEdit = Program.MF.hmRepositoryItemImageComboBox; Internal
            colPAGf.ColumnEdit = Program.MF.PAGrepositoryItemLookUpEdit;
            colPRNTf.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colINFOf.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;

            Program.MF.GridControlSettings(tsfGridControl);

            tafTableAdapter.ClearBeforeFill = false;
            colCRRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colACCID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAGNID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colOPRID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTID.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colBRM.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colTOP.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colORG.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDST.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colPOL.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colPOU.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;

            colPTM.ColumnEdit = Program.MF.PTMrepositoryItemLookUpEdit;
            colDTM.ColumnEdit = Program.MF.DTMrepositoryItemLookUpEdit;
            colDGR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTENDER.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTMDDLVRY.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colINSR.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colMALBDLDVZ.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;

            colTAGS.ColumnEdit = Program.MF.TAGselTNDrepositoryItemCheckedComboBoxEdit;

            Program.MF.XGLrestore(layoutNameTalep, 0, tstGridView);
            //Program.MF.XGLrestore(layoutNameTeklif, 0, tsfGridView);
            tsfGridView.OptionsView.ShowFooter = false;

            this.tsfTableAdapter.ClearBeforeFill = false;

            Program.MF.FRTrepositoryItemLookUpEdit.Closed += FRTrepositoryItemLookUpEdit_Closed;

            hdrTmp = tsfGridView.OptionsPrint.RtfReportHeader;

        }

        void FRTrepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (tstGridControl.IsFocused)
            {
                var a = sender as LookUpEdit;
                if (a.EditValue != DBNull.Value)
                {
                    string ozlDrm = teklifQueriesTableAdapter.OZEL_DURUM("FRT", a.EditValue.ToString()).ToString();
                    tstGridView.SetFocusedRowCellValue(colFRTOZLDRMt, ozlDrm);
                    frtOzlDrmMemoEdit.EditValue = ozlDrm;
                }
            }
        }
        
        public void Save()
        {
            this.Validate();
            this.tstBindingSource.EndEdit();
            try
            {
                foreach (TeklifDataSet.TSTRow row in this.teklifDataSet.TST.Rows)
                    if (row.RowState == DataRowState.Modified)
                        row.UPDUSR = Program.USR;

                this.tstTableAdapter.Update(this.teklifDataSet.TST);

                TeklifDataSet.TSFDataTable dt = (TeklifDataSet.TSFDataTable)this.teklifDataSet.TSF.GetChanges(DataRowState.Modified);
                this.tsfTableAdapter.Update(this.teklifDataSet.TSF);
                if (dt != null)
                {
                    this.tsfTableAdapter.Fill(this.teklifDataSet.TSF, (int)dt.Rows[0]["TSTID"], (int)dt.Rows[0]["TSFID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeklifSatisTalepXF_Load(object sender, EventArgs e)
        {
            Qry.qsvTstXUC frm = new Qry.qsvTstXUC();
            frm.saveHandler = Save;

            frm.TST = teklifDataSet.TST;
            frm.TSF = teklifDataSet.TSF;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            //this.tstTableAdapter.Fill(this.teklifDataSet.TST, "TSTID > 0", Program.USR);

        }

        private void tstGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTSTIDt, PK);
            view.SetFocusedRowCellValue(colTYPt, "T");
            view.SetFocusedRowCellValue(colSTUt, "P");   // Pending
            view.SetFocusedRowCellValue(colTYPt, "G");   //Genel
            view.SetFocusedRowCellValue(colROTt, "E");   //Export
            view.SetFocusedRowCellValue(colTOBt, "O");   //Ops
            view.SetFocusedRowCellValue(colPRVTt, "F");   //False
            view.SetFocusedRowCellValue(colEditable, "T");
            view.SetFocusedRowCellValue(colVisible, "T");
            view.SetFocusedRowCellValue(colRVSNOt, "-"); //Revize
            view.SetFocusedRowCellValue(colINSUSRt, Program.USR); //InsUsr
        }

        private void tsfGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTSFIDf, PK);
            view.SetFocusedRowCellValue(colKIMEf, "HACC");   //hAcc
            view.SetFocusedRowCellValue(colPRNTf, "T");
        }

        private void TeklifSatisTalepXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Text += " Close";
            Save();
        }

        private void tstGridControl_Leave(object sender, EventArgs e)
        {
            //Text += " Leave";
            Save();
        }

        private void olusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Mevcut teklif silinip yenisi oluşturulacaktır. Eminmisiniz?", "Teklif oluştur", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                return;
            
            //TeklifAlisFiyatXF alis = new TeklifAlisFiyatXF();
            //alis.ShowDialog();
            int PK = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);
            try
            {
                teklifQueriesTableAdapter.TKLF_INS_TSF(PK);
                DataRow[] tsfRow = teklifDataSet.TSF.Select("TSTID = "+PK);
                for (int i = 0; i < tsfRow.Length; i++)
                    teklifDataSet.TSF.Rows.Remove(tsfRow[i]);   //RemoveTSFRow(tsfRow[i]);

                this.tsfTableAdapter.ClearBeforeFill = false;
                //this.tsfTableAdapter.Fill(this.teklifDataSet.TSF, PK);
                this.tsfTableAdapter.Fill(teklifDataSet.TSF, PK, 0);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tstGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.ListSourceRowIndex >= -10000)
            {
                if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colVisible).ToString() == "F")
                {
                    if (e.Column.FieldName == "CRRID")
                    {
                        e.DisplayText = "¤";
                    }
                }
            }
        }

        private void tsfGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.Column == colAREFIDf)
                e.DisplayText = string.Format("{0} {1}", e.Value, view.GetListSourceRowCellValue(e.ListSourceRowIndex, colAREFTOf));

            if (!fytVisible)
            {
                if (e.Column.FieldName.StartsWith("AFYT") || e.Column.FieldName.StartsWith("SFYT") || e.Column.FieldName == "CRRID")
                    e.DisplayText = "¤";
            }
        }

        private void tafGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (!fytVisible)
            {
                if (e.Column.FieldName.StartsWith("FYT") || e.Column.FieldName == "CRRID")
                    e.DisplayText = "¤";
            }
        }

        private void tsfGridView_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            string tafID = tsfGridView.GetRowCellValue(e.RowHandle, colAREFIDf).ToString();
            string qry = "TAFID = " + tafID;
            //MessageBox.Show(qry);
            int nor = this.teklifDataSet.TAF.Select("TAFID = " + tafID).Length;
            if (nor == 0)
                this.tafTableAdapter.Fill(this.teklifDataSet.TAF, qry, Program.USR);
        }

        private void tstGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0) //!= DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                /*
                this.Validate();
                this.tsfBindingSource.EndEdit();
                this.tsfTableAdapter.Update(this.teklifDataSet.TSF);
                
                int tstID = (int)tstGridView.GetRowCellValue(e.FocusedRowHandle, colTSTIDt);
                tsfTableAdapter.Fill(this.teklifDataSet.TSF, tstID);
                */
                editable = tstGridView.GetRowCellValue(e.FocusedRowHandle, colEditable).ToString() == "T" ? true : false;
                fytVisible = tstGridView.GetRowCellValue(e.FocusedRowHandle, colVisible).ToString() == "T" ? true : false;

                tsfGridView.OptionsBehavior.ReadOnly = !editable;
                tsfGridView.OptionsBehavior.Editable = editable;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (fytVisible && editable)
                e.Cancel = false;
            else
                e.Cancel = true;

            e.Cancel = !editable;
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            if (tstGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !tstGridView.IsDataRow(tstGridView.FocusedRowHandle))
                return;

            int PK = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = tstGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "TST";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.tstTableAdapter.ClearBeforeFill = false;
            this.tstTableAdapter.Fill(this.teklifDataSet.TST, string.Format("TSTid = {0}", PK), Program.USR);
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tstGridView.DataRowCount == 0)
                return;
            if (!tstGridView.IsDataRow(tstGridView.FocusedRowHandle))
                return;

            int refId = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "TST";
            frm.RefID = refId;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tstGridView.DataRowCount == 0)
                return;
            if (!tstGridView.IsDataRow(tstGridView.FocusedRowHandle))
                return;

            int refId = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "TST";
            frm.RefID = refId;
            frm.RefInfo = string.Format("Teklif/Talep {0}", refId);
            frm.ShowDialog();
            frm.Dispose();

        }

        private void layoutsTalepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutNameTalep;
            frm.origin = tstGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void layoutsTeklifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutNameTeklif;
            frm.origin = tsfGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        /*
         // Create printing components.
PrintingSystem printingSystem1 = new PrintingSystem();
PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
// ...

private void Form1_Load(object sender, EventArgs e) {
    // Add the link to the printing system's collection of links.
    printingSystem1.Links.AddRange(new object[] { printableComponentLink1 });
 
    // Assign a control to be printed by this link.
    printableComponentLink1.Component = gridControl1;

    // Assign the printing system to the document viewer.
    documentViewer1.PrintingSystem = printingSystem1;
}

         */

        private void exportToolStripMenuItem_ClickOld(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tsfGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);
            object frm = tstGridView.GetFocusedRowCellDisplayText(colFRTIDt);
            object rot = tstGridView.GetFocusedRowCellValue(colROTt);
            object mot = tstGridView.GetFocusedRowCellValue(colMOTt);
            object hOrg = tstGridView.GetFocusedRowCellValue(colORGSt);
            object hDst = tstGridView.GetFocusedRowCellValue(colDSTSt);
            object mOrg = tstGridView.GetFocusedRowCellValue(colPOLSt);
            object mDst = tstGridView.GetFocusedRowCellValue(colPOUSt);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Talep/Teklif {0} {1}/{2} ({3})-{4} >> {5}-({6})", frm, rot, mot, hOrg, mOrg, mDst, hDst);
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }


        private void exportTurkceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSatis("T");
        }

        private void exportEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSatis("E");
        }

        private void exportTurkceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exportSatis("T");
        }

        private void exportIngilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSatis("E");
        }

        private void eMailTurkceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSatis("T", true);
        }

        private void eMailIngilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportSatis("E", true);
        }

        private void exportSatis(string dil, bool eMail = false)
        {
            int tstID = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);
            rprTklfTableAdapter.Fill(teklifDataSet.RPR_TKLF, tstID, dil);
            TeklifDataSet.RPR_TKLFRow rprTklfRow = (TeklifDataSet.RPR_TKLFRow)teklifDataSet.RPR_TKLF.Rows[0];
            string tklfTE = "Teklif";

            if (dil == "T")
            {
                colORGf.Caption = "Çıkış";
                colDSTf.Caption = "Varış";
                colBRMf.Caption = "Birim";
                colTRNTIMEf.Caption = "Transit Süre";

                colSKDY.Caption = "KDV%";
                colSDVZf.Caption = "Para Birim";

                colSFYTf.Caption = "Fiyat";
                colSFYT1f.Caption = "Min";
                colSFYT2f.Caption = "-45";
                colSFYT3f.Caption = "+45";
                colSFYT4f.Caption = "+100";
                colSFYT5f.Caption = "+250";
                colSFYT6f.Caption = "+300";
                colSFYT7f.Caption = "+500";
                colSFYT8f.Caption = "+1000";

                colSFYTE.Caption = "Fiyat";
                colSFYT1E.Caption = "Min";
                colSFYT2E.Caption = "-45";
                colSFYT3E.Caption = "+45";
                colSFYT4E.Caption = "+100";
                colSFYT5E.Caption = "+250";
                colSFYT6E.Caption = "+300";
                colSFYT7E.Caption = "+500";
                colSFYT8E.Caption = "+1000";
            }
            else
            {
                tklfTE = "Tender";
                colORGf.Caption = "Origin";
                colDSTf.Caption = "Destination";
                colBRMf.Caption = "Unit";
                colTRNTIMEf.Caption = "Transit Time";

                colSKDY.Caption = "%VAT";
                colSDVZf.Caption = "Currency";
                
                colSFYTf.Caption = "Rate";
                colSFYT1f.Caption = "Min";
                colSFYT2f.Caption = "-45";
                colSFYT3f.Caption = "+45";
                colSFYT4f.Caption = "+100";
                colSFYT5f.Caption = "+250";
                colSFYT6f.Caption = "+300";
                colSFYT7f.Caption = "+500";
                colSFYT8f.Caption = "+1000";

                colSFYTE.Caption = "Rate";
                colSFYT1E.Caption = "Min";
                colSFYT2E.Caption = "-45";
                colSFYT3E.Caption = "+45";
                colSFYT4E.Caption = "+100";
                colSFYT5E.Caption = "+250";
                colSFYT6E.Caption = "+300";
                colSFYT7E.Caption = "+500";
                colSFYT8E.Caption = "+1000";
            }

            if (colG9.GroupIndex == 0)
            {
                tsfGridView.CollapseAllGroups();
                //tsfGridView.OptionsView.ShowFooter = true;
                tsfGridView.OptionsPrint.ExpandAllGroups = false;
                tsfGridView.OptionsPrint.PrintFooter = true;
                tsfGridView.OptionsPrint.AutoWidth = false;

            }
            else
            {
                tsfGridView.ExpandAllGroups();
                //tsfGridView.OptionsView.ShowFooter = false;
                tsfGridView.OptionsPrint.ExpandAllGroups = true;
                tsfGridView.OptionsPrint.PrintFooter = false;
                tsfGridView.OptionsPrint.AutoWidth = false;

                //tsfGridView.OptionsPrint.AutoWidth = true;
                //tsfGridView.BestFitColumns();
            }

            RichEditDocumentServer richServer = new RichEditDocumentServer();
            richServer.RtfText = rprTklfRow.ALTNOT;
            //richServer.Document.AppendText(" SENER");
            if (!rprTklfRow.IsDTYNOTNull())
            {
                if (string.IsNullOrEmpty(richServer.Text))
                    richServer.RtfText = rprTklfRow.DTYNOT;
                else
                    richServer.Document.AppendRtfText(rprTklfRow.DTYNOT);
            }
            
            tsfGridView.OptionsPrint.RtfReportFooter = richServer.RtfText;
            tsfGridView.OptionsPrint.RtfPageFooter = rprTklfRow.FOOTER;


            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tsfGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 10;
            link.Margins.Right = 10;
            link.Margins.Top = 10;
            link.Margins.Bottom = 10;

//            tsfGridView.OptionsPrint.RtfPageHeader =
            tsfGridView.OptionsPrint.RtfReportHeader =
                 rprTklfRow.USTNOT
                .Replace("@TSTID@", rprTklfRow.TSTID.ToString())
                .Replace("@FIRMA@", rprTklfRow.FIRMA)
                .Replace("@TLPTRH@", rprTklfRow.TLPTRHS)
                .Replace("@TKLTRH@", rprTklfRow.TKLTRHS)
                .Replace("@GCRTRH@", rprTklfRow.GCRTRHS)
                .Replace("@ROT@", rprTklfRow.ROT)
                .Replace("@MOT@", rprTklfRow.MOT)
                .Replace("@PTM@", rprTklfRow.PTM)
                .Replace("@DTM@", rprTklfRow.DTM)

                .Replace("@HORGS@", rprTklfRow.HORGS)
                .Replace("@HDSTS@", rprTklfRow.HDSTS)
                .Replace("@MORGS@", rprTklfRow.MORGS)
                .Replace("@MDSTS@", rprTklfRow.MDSTS)

                .Replace("@MALCINSI@", rprTklfRow["MALCINSI"].ToString())
                .Replace("@INFO@", rprTklfRow.INFO);

            link.CreateDocument();

            if (eMail)
            {
                if (string.IsNullOrWhiteSpace(rprTklfRow.EMAILS))
                {
                    XtraMessageBox.Show("eMail adresi bulunamadı", "eMail Teklif", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                Cursor = Cursors.WaitCursor;
                try
                {
                    MainDataSet.SMTPRow SMTP = Program.MF.SMTP();
                    MailMessage mail = new MailMessage();

                    // Create a new memory stream and export the report into it as PDF.
                    MemoryStream ms = new MemoryStream();
                    link.ExportToPdf(ms);

                    // Create a new attachment and put the PDF report into it.
                    ms.Seek(0, System.IO.SeekOrigin.Begin);
                    Attachment att = new Attachment(ms, string.Format("{0}-{1}.pdf", tklfTE, tstID), "application/pdf");
                    mail.Attachments.Add(att);

                    mail.To.Add(rprTklfRow.EMAILS);

                    mail.Subject = rprTklfRow.EMAILSUBJECT;
                    mail.Body = rprTklfRow.EMAILBODY;
                    mail.IsBodyHtml = true;

                    mail.From = new MailAddress(SMTP.MAIL_FROM_ADDRESS, SMTP.MAIL_FROM_DISPLAY_NAME);
                    SmtpClient smtp = new SmtpClient(SMTP.CLIENT_HOST);
                    smtp.Credentials = new System.Net.NetworkCredential(SMTP.CREDENTIALS_USER_NAME, SMTP.CREDENTIALS_USER_PASSWORD);
                    smtp.EnableSsl = SMTP.ENABLE_SSL == "T" ? true : false;
                    smtp.Port = SMTP.PORT;

                    smtp.Send(mail);

                    int len = (int)ms.Length;
                    byte[] img = new byte[len];
                    ms.Read(img, 0, len);
                    //teklifQueriesTableAdapter.DOC_INS2("TST", tstID, "Teklif", ".pdf", "TKLF", Program.USR, len, img);
                    teklifQueriesTableAdapter.DOC_INS2("TST", tstID, string.Format("Teklif {0}", tstGridView.GetFocusedRowCellValue(colRVSNOt)), ".pdf", "TKLF", Program.USR, len, img);

                    // Close the memory stream.
                    ms.Close();
                    ms.Flush();

                    rptInfo rpti = new rptInfo();
                    rpti.put("TKLF", "TST", tstID, Program.USR, "F", "eMail Teklif");
                    Program.MF.reportDone(rpti, false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error sending eMail.\n" + ex.ToString());
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                link.ShowPreviewDialog();
                
                if (XtraMessageBox.Show("İşlem tamamlandı mı?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    link.ExportToPdf(ms);
                    ms.Seek(0, System.IO.SeekOrigin.Begin);
                    int len = (int)ms.Length;
                    byte[] img = new byte[len];
                    ms.Read(img, 0, len);
                    ms.Close();

                    teklifQueriesTableAdapter.DOC_INS2("TST", tstID, string.Format("Teklif {0}", tstGridView.GetFocusedRowCellValue(colRVSNOt)), ".pdf", "TKLF", Program.USR, len, img);
                    rptInfo rpti = new rptInfo();
                    rpti.put("TKLF", "TST", tstID, Program.USR, "F", "eMail Teklif");
                    Program.MF.reportDone(rpti, false);
                }
                
            }
        }

        private void xxxxx(object sender, EventArgs e)
        {
            int tstID = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);
            rprTklfTableAdapter.Fill(teklifDataSet.RPR_TKLF, tstID, "T");
            TeklifDataSet.RPR_TKLFRow rprTklfRow = (TeklifDataSet.RPR_TKLFRow)teklifDataSet.RPR_TKLF.Rows[0];

            hdrTmp = rprTklfRow.USTNOT;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tsfGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);
            object frm = tstGridView.GetFocusedRowCellDisplayText(colFRTIDt);
            object rot = tstGridView.GetFocusedRowCellValue(colROTt);
            object mot = tstGridView.GetFocusedRowCellValue(colMOTt);
            object hOrg = tstGridView.GetFocusedRowCellValue(colORGSt);
            object hDst = tstGridView.GetFocusedRowCellValue(colDSTSt);
            object mOrg = tstGridView.GetFocusedRowCellValue(colPOLSt);
            object mDst = tstGridView.GetFocusedRowCellValue(colPOUSt);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("Talep/Teklif {0} ", tstGridView.GetFocusedRowCellValue(colTSTIDt));
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            int frtID = (int)tstGridView.GetFocusedRowCellValue(colFRTIDt);
            string firma = Program.MF.FrtAd(frtID);

            string lblFRT = "Firma";
            string lblTKLTRH = "Teklif Tarihi";
            string lblGCRTRH = "Geçerlilik Tarihi";
            string lblHORGS = "Çı kı ş  Yeri";
            string lblHDSTS = "Varı ş  Yeri";
            string lblMORGS = "Çı kı ş  Limanı";
            string lblMDSTS = "Varı ş  Limanı";
            string lblMALCINSI = "Mal Cinsi";


            tsfGridView.OptionsPrint.RtfReportHeader =
                 hdrTmp
                .Replace("@lblFRT@", lblFRT)
                .Replace("@FRT@", firma)

                .Replace("@lblTKLTRH@", lblTKLTRH)
                .Replace("@TKLTRH@", tstGridView.GetFocusedRowCellDisplayText(colTKLTRHt))

                .Replace("@lblGCRTRH@", lblGCRTRH)
                .Replace("@GCRTRH@", tstGridView.GetFocusedRowCellDisplayText(colGCRTRHt))

                .Replace("@ROT@", tstGridView.GetFocusedRowCellDisplayText(colROTt))
                .Replace("@MOT@", tstGridView.GetFocusedRowCellDisplayText(colMOTt))

                .Replace("@lblHORGS@", lblHORGS)
                .Replace("@HORGS@", tstGridView.GetFocusedRowCellDisplayText(colORGSt))

                .Replace("@lblHDSTS@", lblHDSTS)
                .Replace("@HDSTS@", tstGridView.GetFocusedRowCellDisplayText(colDSTSt))

                .Replace("@lblMORGS@", lblMORGS)
                .Replace("@MORGS@", tstGridView.GetFocusedRowCellDisplayText(colPOLSt))

                .Replace("@lblMDSTS@", lblMDSTS)
                .Replace("@MDSTS@", tstGridView.GetFocusedRowCellDisplayText(colPOUSt))

                .Replace("@DTM@", tstGridView.GetFocusedRowCellDisplayText(colDTMt))
                .Replace("@PTM@", tstGridView.GetFocusedRowCellDisplayText(colPTMt))

                .Replace("@lblMALCINSI@", lblMALCINSI)
                .Replace("@MALCINSI@", tstGridView.GetFocusedRowCellDisplayText(colMALCINSIt))

                .Replace("@INFO@", tstGridView.GetFocusedRowCellDisplayText(colINFOt));

            string s = tstGridView.GetFocusedRowCellDisplayText(colGCRTRHt);

            //            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            //            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();


        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompositeLink composLink = new CompositeLink(new PrintingSystem());
            PrintableComponentLink pcLink1 = new PrintableComponentLink();
            PrintableComponentLink pcLink2 = new PrintableComponentLink();

            //richEditControl1.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A5;
            //pcLink2.Component = gridControl1;
            pcLink1.Component = tsfGridControl;

            //tsfGridView.OptionsPrint.RtfReportHeader = richEditControl1.Document.RtfText;

            composLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
            composLink.Landscape = true;
            composLink.Margins.Left = 50;
            composLink.Margins.Right = 50;
            composLink.Margins.Top = 50;
            composLink.Margins.Bottom = 50;

            //composLink.Links.Add(pcLink2);
//            composLink.Links[0].CustomPaperSize = new System.Drawing.Size(500, 200);
            composLink.Links.Add(pcLink1);

            composLink.ShowPreviewDialog();
        }

        private void tsfGridView_EndGrouping(object sender, EventArgs e)
        {
            Text = colG9.GroupIndex.ToString();

            if (colG9.GroupIndex == 0)
            {
                tsfGridView.CollapseAllGroups();
                tsfGridView.OptionsView.ShowFooter = true;
                tsfGridView.OptionsPrint.ExpandAllGroups = false;
            }
        }

        private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sTstID = (int)tstGridView.GetFocusedRowCellValue(colTSTIDt);
            int dTstID = (int)teklifQueriesTableAdapter.TST_DUP(sTstID, Program.USR);

            bool tcbf = tstTableAdapter.ClearBeforeFill;
            bool fcbf = tsfTableAdapter.ClearBeforeFill;
            tstTableAdapter.ClearBeforeFill = false;
            tsfTableAdapter.ClearBeforeFill = false;

            tstTableAdapter.Fill(teklifDataSet.TST, string.Format("TSTID = {0}", dTstID), Program.USR);
            this.tsfTableAdapter.Fill(this.teklifDataSet.TSF, dTstID, 0);

            tstTableAdapter.ClearBeforeFill = tcbf;
            tsfTableAdapter.ClearBeforeFill = fcbf;
        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = tstGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                tstGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                tstGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                tstGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                tstGridView.UpdateCurrentRow();
            }
        }

        private void setPrintAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void printCheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tstID = (int)tstGridView.GetFocusedRowCellValue("TSTID");
            foreach (TeklifDataSet.TSFRow row in this.teklifDataSet.TSF.Rows)
                if (row.TSTID == tstID)
                    row.PRNT = "T";
        }

        private void printUncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tstID = (int)tstGridView.GetFocusedRowCellValue("TSTID");
            foreach (TeklifDataSet.TSFRow row in this.teklifDataSet.TSF.Rows)
                if (row.TSTID == tstID)
                    row.PRNT = "F";
        }

        private void housesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouseXUC", false))
                return;

            Ops.opHouseXUC frm = new Ops.opHouseXUC();
            frm.qsString = string.Format("TSTID = {0}", tstGridView.GetFocusedRowCellValue("TSTID"));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "House";
            panel.Text = "Houses of TSTID" + tstGridView.GetFocusedRowCellDisplayText("TSTID");

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void mastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opMasterXUC", false))
                return;

            Ops.opMasterXUC frm = new Ops.opMasterXUC();
            frm.qsString = string.Format("TSTID = {0}", tstGridView.GetFocusedRowCellValue("TSTID"));
            frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "Master";
            panel.Text = "Masters of TSTID" + tstGridView.GetFocusedRowCellDisplayText("TSTID");

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);
        }

        private void reportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.rphXF frm = new Genel.rphXF();

            frm.iQry = string.Format("RefTO = 'TST' and RefID = {0}", tstGridView.GetFocusedRowCellValue("TSTID"));

            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Teklif.TeklifSatisTalepXF.Export", isSilent: true))
                return;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = tstGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Talepler", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsfGridView.OptionsView.ShowPreview = !tsfGridView.OptionsView.ShowPreview;
            showPreviewToolStripMenuItem.Checked = tsfGridView.OptionsView.ShowPreview;
        }

        private void setPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TeklifDataSet.TSFRow row in this.teklifDataSet.TSF.Rows)
                row.PRNT = "T";

            this.tsfTableAdapter.Update(this.teklifDataSet.TSF);
        }

        private void unSetPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TeklifDataSet.TSFRow row in this.teklifDataSet.TSF.Rows)
                row.PRNT = "F";

            this.tsfTableAdapter.Update(this.teklifDataSet.TSF);
        }

        rptInfo rpti = new rptInfo();
        
        private void eCSRateRequestEMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = tstGridView;
            int tstID = (int)view.GetFocusedRowCellValue("TSTID");

            EcsRateRequestXR rpr = new EcsRateRequestXR(tstID, Program.USR);
            if (string.IsNullOrWhiteSpace(rpr.eMails))
            {
                XtraMessageBox.Show("eMail adresi bulunamadı", "ECS Rate Request", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (XtraMessageBox.Show(string.Format("Mail gonderilecekler: {0}", rpr.eMails), "ECS Rate Request",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                rpti.put("ECSRR", "TST", tstID, Program.USR, "F", "eMail");

                MailClass.MailReportAsBodyTask(rpti, "eMail ECS Rate Request", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
                //sendEMail(rpti, "eMail Marken HAWB Request Form", rpr, rpr.eMails, rpr.eMailSubject, rpr.eMailBody);
            }
        }

    }
}