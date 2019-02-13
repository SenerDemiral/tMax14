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
using System.Reflection;
using DevExpress.XtraGrid.EditForm.Helpers;

namespace tMax14.Teklif
{
    public partial class TeklifAlisFiyatXF : DevExpress.XtraEditors.XtraForm
    {
        bool editable, fytVisible;
        string layoutName = "Teklif.TeklifAlisFiyatXF.taf";
        
        public TeklifAlisFiyatXF()
        {
            
            if (!Program.MF.EntryCheck("Teklif.TeklifAlisFiyatXF", false))
            {
                Shown += (s, e) => Close();
                return;
            }
            
            InitializeComponent();

            tafGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
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

            colPRVT.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colPRVTUSRS.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

            colEditable.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colVisible.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(tafGridControl);
            tafGridView.OptionsView.ShowFooter = false;

            tacGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colFRTIDc.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colAHTIDc.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colROTc.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTc.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colORGc.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colDSTc.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colBRMc.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colDVZc.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colLOCIDc.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
            colTOPc.ColumnEdit = Program.MF.TOPrepositoryItemLookUpEdit;
            colEDITABLEc.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            Program.MF.GridControlSettings(tacGridControl);

            tagGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colAHTIDg.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTIDg.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colROTg.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTg.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colDVZg.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            colBRMg.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colEDITABLEg.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTOBg.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            Program.MF.GridControlSettings(tagGridControl);

            tamGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTOBm.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROTm.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOTm.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colAHTIDm.ColumnEdit = Program.MF.AHTrepositoryItemLookUpEdit;
            colFRTIDm.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colEDITABLEm.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colBRMm.ColumnEdit = Program.MF.AFDbrmRepositoryItemLookUpEdit;
            colDVZm.ColumnEdit = Program.MF.DVTrepositoryItemLookUpEdit;
            Program.MF.GridControlSettings(tamGridControl);

            Program.MF.XGLrestore(layoutName, 0, tafGridView);
        }

        public void Save()
        {
            Validate();
            tafBindingSource.EndEdit();
            tafTableAdapter.Update(teklifDataSet.TAF);

            tacBindingSource.EndEdit();
            tacTableAdapter.Update(teklifDataSet.TAC);

            tagBindingSource.EndEdit();
            tagTableAdapter.Update(teklifDataSet.TAG);

            tamBindingSource.EndEdit();
            tamTableAdapter.Update(teklifDataSet.TAM);
        }
        
        private void tafGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int TAFid = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTAFID, TAFid);
            view.SetFocusedRowCellValue(colSTU, "A");   //Aktif
            view.SetFocusedRowCellValue(colTYP, "G");   //Genel
            view.SetFocusedRowCellValue(colROT, "E");   //Export
            view.SetFocusedRowCellValue(colOWN, "F");   //Own
            view.SetFocusedRowCellValue(colTOB, "O");   //Ops

        }

        private void TeklifAlisFiyatXF_Load(object sender, EventArgs e)
        {
            Qry.qsvTafXUC frm2 = new Qry.qsvTafXUC();
            frm2.TAF = teklifDataSet.TAF;
            frm2.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm2);

            this.tacTableAdapter.Fill(teklifDataSet.TAC, Program.USR);
            this.tagTableAdapter.Fill(teklifDataSet.TAG, Program.USR);
            this.tamTableAdapter.Fill(teklifDataSet.TAM, "", Program.USR);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                PrintingSystem ps = new PrintingSystem();
                PrintableComponentLink link = new PrintableComponentLink(ps);
                link.Component = tafGridControl;
                link.PaperKind = System.Drawing.Printing.PaperKind.A4;
                link.Landscape = true;
                link.Margins.Left = 50;
                link.Margins.Right = 50;
                link.Margins.Top = 50;
                link.Margins.Bottom = 50;
                link.CreateDocument();
                link.ShowPreview();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            exportToolStripMenuItem.Enabled = Program.MF.EntryCheck("Teklif.TeklifAlisFiyatXF.Export", true);
            
            //if (fytVisible && editable)
            //    e.Cancel = false;
            //else
            //    e.Cancel = true;

            //e.Cancel = !edit;
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = tafGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tafGridView.IsDataRow(tafGridView.FocusedRowHandle))
                return;

            if (tafGridView.GetFocusedRowCellValue(colVisible).ToString() == "T")
            {
                Doc.DocXF frm = new Doc.DocXF();
                frm.RefTbl = "OPC";
                frm.RefID = (int)tafGridView.GetFocusedRowCellValue(colTAFID);
                frm.RefInfo = tafGridView.GetFocusedRowCellDisplayText(colTAFID);
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        private void duplicateRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tafGridView.IsDataRow(tafGridView.FocusedRowHandle))
                return;

            TeklifDataSet.TAFRow newRow = teklifDataSet.TAF.NewTAFRow();
            int sri = tafGridView.GetDataSourceRowIndex(tafGridView.FocusedRowHandle);

            newRow.ItemArray = this.teklifDataSet.TAF.Rows[sri].ItemArray;
            newRow.TAFID = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif

            if (newRow.ROT != "E" || newRow.MOT != "A")
            {
                newRow["FYT"] = DBNull.Value;
                newRow["FYT1"] = DBNull.Value;
                newRow["FYT2"] = DBNull.Value;
                newRow["FYT3"] = DBNull.Value;
                newRow["FYT4"] = DBNull.Value;
                newRow["FYT5"] = DBNull.Value;
                newRow["FYT6"] = DBNull.Value;
                newRow["FYT7"] = DBNull.Value;
                newRow["FYT8"] = DBNull.Value;
            }

            newRow["STU"] = "A";
            newRow["GCRTRH"] = DBNull.Value;
            newRow["ONYUSR"] = DBNull.Value;
            newRow["ONYYTK"] = DBNull.Value;
            newRow["ONYTRH"] = DBNull.Value;


            teklifDataSet.TAF.AddTAFRow(newRow);
            tafGridView.FocusedRowHandle = tafGridView.LocateByValue(0, colTAFID, newRow.TAFID);


            //object[] ia = this.teklifDataSet.TAF.Rows[sri].ItemArray;
            //for (int i = 0; i < ia.Length; i++)
            //{
            //}
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!tafGridView.IsDataRow(tafGridView.FocusedRowHandle))
                return;

            int PK = (int)tafGridView.GetFocusedRowCellValue(colTAFID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "TAF";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tacGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            tacGridView.SetFocusedRowCellValue(colTACIDc, PK);

        }

        private void tagGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            int PK = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            tagGridView.SetFocusedRowCellValue(colTAGIDg, PK);
            tagGridView.SetFocusedRowCellValue(colTOBg, "O");   // Ops
        }

        private void tafGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.ListSourceRowIndex >= -10000)
            {
                if (view.GetListSourceRowCellValue(e.ListSourceRowIndex, colVisible).ToString() == "F")
                    if (e.Column.FieldName.StartsWith("FYT"))
                        e.DisplayText = "¤";
            }
        }

        private void tafGridView_GotFocus(object sender, EventArgs e)
        {
            //this.tacTableAdapter.Update(this.teklifDataSet.TAC);
        }

        private void tafGridControl_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private void tacGridControl_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private void tagGridControl_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tafGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !tafGridView.IsDataRow(tafGridView.FocusedRowHandle))
                return;

            int PK = (int)tafGridView.GetFocusedRowCellValue(colTAFID);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = tafGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "TAF";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            tafTableAdapter.ClearBeforeFill = false;
            tafTableAdapter.Fill(teklifDataSet.TAF, string.Format("TAFid = {0}", PK), Program.USR);
        }

        private void onaylaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void onaylaGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tagGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !tagGridView.IsDataRow(tagGridView.FocusedRowHandle))
                return;

            int PK = (int)tagGridView.GetFocusedRowCellValue(colTAGIDg);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = tafGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "TAG";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void onaylaCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tacGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !tacGridView.IsDataRow(tacGridView.FocusedRowHandle))
                return;

            int PK = (int)tacGridView.GetFocusedRowCellValue(colTACIDc);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = tafGridView.GetFocusedRowCellDisplayText(colONYYTK);
            frm.Tbl = "TAC";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void tamGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;
            int TAMid = (int)teklifQueriesTableAdapter.GET_PK("TND");  //Tender/Teklif
            view.SetFocusedRowCellValue(colTAMIDm, TAMid);
            view.SetFocusedRowCellValue(colEDITABLEm, "T");
        }

        private void tamGridControl_Leave(object sender, EventArgs e)
        {
            Save();
        }

        private void tafGridControl_Click(object sender, EventArgs e)
        {

        }

        private void onaylaMtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tamGridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.InvalidRowHandle || !tamGridView.IsDataRow(tamGridView.FocusedRowHandle))
                return;

            int PK = (int)tafGridView.GetFocusedRowCellValue(colTAMIDm);
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = tamGridView.GetFocusedRowCellDisplayText(colONYYTKm);
            frm.Tbl = "TAM";
            frm.TblPK = PK;
            frm.ShowDialog();
            frm.Dispose();

            this.tamTableAdapter.ClearBeforeFill = false;
            this.tamTableAdapter.Fill(this.teklifDataSet.TAM, string.Format("TAMid = {0}", PK), Program.USR);
        }

    }
}