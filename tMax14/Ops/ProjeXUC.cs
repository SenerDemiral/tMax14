using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace tMax14.Ops
{
    public partial class ProjeXUC : DevExpress.XtraEditors.XtraUserControl
    {
        string layoutName = "OPS.ProjeXUC";

        public ProjeXUC()
        {
            InitializeComponent();

            Program.MF.XGLrestore(layoutName, 0, prtGridView);
        }

        public void Save()
        {
            this.Validate();
            this.prtBindingSource.EndEdit();
            prtTableAdapter.Update(opsDataSet.PRT);
        }

        private void ProjeXUC_Load(object sender, EventArgs e)
        {
            prtTableAdapter.Fill(opsDataSet.PRT);

            prtGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDRM.ColumnEdit = Program.MF.prtDrmRepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.prtTurRepositoryItemLookUpEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselPRTrepositoryItemCheckedComboBoxEdit;
            colYONETICI.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            colSORUMLU.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            //colAMAC.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;
            //colACIKLAMA.ColumnEdit = Program.MF.MemoExtRepositoryItemMemoExEdit;

            Program.MF.GridControlSettings(prtGridControl);

            GridFormatRule gridFormatRule = new GridFormatRule();
            FormatConditionRuleExpression formatConditionRuleExpression = new FormatConditionRuleExpression();
            gridFormatRule.Column = colBKMS;
            gridFormatRule.ApplyToRow = true;
            formatConditionRuleExpression.PredefinedName = "Bold Text"; // "Red Fill, Red Text";
            formatConditionRuleExpression.Expression = string.Format("Contains([BKMS], '{0}')", Program.USRtag);
            gridFormatRule.Rule = formatConditionRuleExpression;
            prtGridView.FormatRules.Add(gridFormatRule);


            prtTableAdapter.ClearBeforeFill = false;
        }

        private void prtGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, colPRTID, Program.MF.mainQueriesTableAdapter.GET_PK("PRJ"));
        }

        private void sablonlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ProjeSablonXUC frm = new ProjeSablonXUC();
            if (frm.ShowDialog() == DialogResult.OK)
                prtGridView.SetFocusedRowCellValue(colTXT, frm.prsRow.SABLON);
            */
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ProjeSablonEditXF frm = new ProjeSablonEditXF();
            frm.Text = "Proje Info";
            frm.richText = prtGridView.GetFocusedRowCellValue(colTXT).ToString();
            frm.ShowDialog();
            prtGridView.SetFocusedRowCellValue(colTXT, frm.richText);
            frm.Dispose();
            */
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)prtGridView.GetFocusedRowCellValue(colPRTID);
            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "PRT";
            frm.RefID = PK;
            frm.ShowDialog();
            frm.Dispose();

        }

        private void faaliyetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PK = (int)prtGridView.GetFocusedRowCellValue(colPRTID);
            ProjeFaliyetXF frm = new ProjeFaliyetXF();
            frm.PrtID = PK;
            frm.ShowDialog();
            frm.Dispose();

        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKMS = prtGridView.GetFocusedRowCellValue(colBKMS).ToString();
            // Toggle 
            if (BKMS.Contains(Program.USRtag))   // Varsa cikar
            {
                BKMS = BKMS.Replace(Program.USRtag, "");
                //afbGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                //afbGridView.UpdateCurrentRow();
            }
            else                        // Yoksa ekle
            {
                BKMS += Program.USRtag;
                //afbGridView.SetFocusedRowCellValue(colBKMS, BKMS);
                //afbGridView.UpdateCurrentRow();
            }

            //Save BKMS
            int PK = (int)prtGridView.GetFocusedRowCellValue(colPRTID);
            Program.MF.mainQueriesTableAdapter.BKMS_UPD("PRT", PK, BKMS);
            this.prtTableAdapter.FillByPRT(opsDataSet.PRT, PK);

        }

        private void attachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = prtGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Doc.DocXF frm = new Doc.DocXF();

            frm.RefTbl = "PRT";
            frm.RefID = (int)view.GetFocusedRowCellValue(colPRTID);
            frm.RefInfo = "Proje: " + view.GetFocusedRowCellDisplayText(colPRTID);
            //frm.AltTbl = "FRT";
            //frm.AltID = (int)view.GetFocusedRowCellValue(colFRTID); ;

            frm.ShowDialog();
            frm.Dispose();

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Save();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = prtGridView;
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
