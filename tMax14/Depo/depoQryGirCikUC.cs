using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace tMax14.Depo
{
    public partial class depoQryGirCikUC : DevExpress.XtraEditors.XtraUserControl
    {
        public depoQryGirCikUC()
        {
            InitializeComponent();

            girTAGtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            girTAGtextEdit.Properties.Mask.EditMask = Program.MF.TagDepoRepositoryItemTextEdit.Mask.EditMask;
            cikTAGtextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            cikTAGtextEdit.Properties.Mask.EditMask = Program.MF.TagDepoRepositoryItemTextEdit.Mask.EditMask;

            drmImageComboBoxEdit.EditValue = "A";
            girFrtIdLookUpEdit.Properties.DataSource = Program.MF.ftRepositoryItemSearchLookUpEdit.DataSource;  // Gecici FT
            gtpCheckedComboBoxEdit.Properties.DataSource = Program.MF.gtpRepositoryItemSearchLookUpEdit.DataSource;

            depoQryGCGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colGIRFRTID.ColumnEdit = Program.MF.ftRepositoryItemSearchLookUpEdit;
            colGIRGTPID.ColumnEdit = Program.MF.gtpRepositoryItemSearchLookUpEdit;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.dEPOQRY_GCTableAdapter.Fill(this.depoDataSet.DEPOQRY_GC, sDRMToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(sGIRTRH1ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(sGIRTRH2ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(sGIRFRTIDToolStripTextBox.Text, typeof(int))))), sGIRTAGToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(sCIKTRH1ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(sCIKTRH2ToolStripTextBox.Text, typeof(System.DateTime))))), sCIKTAGToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            string gtpIds = "";
            bool allChecked = true;
            foreach (CheckedListBoxItem bi in gtpCheckedComboBoxEdit.Properties.Items)
                if (bi.CheckState != CheckState.Checked)
                {
                    allChecked = false;
                    break;
                }
            if (!allChecked)
                gtpIds = (string)gtpCheckedComboBoxEdit.Properties.GetCheckedItems() ;

            this.dEPOQRY_GCTableAdapter.Fill(this.depoDataSet.DEPOQRY_GC, 
                drmImageComboBoxEdit.EditValue.ToString(), 
                (DateTime?)girTrh1dateEdit.EditValue,
                (DateTime?)girTrh2dateEdit.EditValue,
                (DateTime?)bitTrh1dateEdit.EditValue,
                (DateTime?)bitTrh2dateEdit.EditValue,
                (int?)girFrtIdLookUpEdit.EditValue,// ?? 0,
                gtpIds,
                (string)girTAGtextEdit.EditValue,
                (DateTime?)cikTrh1dateEdit.EditValue,
                (DateTime?)cikTrh2dateEdit.EditValue,
                (string)cikTAGtextEdit.EditValue);
                //cikTAGtextEdit.Text ?? "");

            /*
            depoQryGCgridView.UpdateSummary();
            depoQryGCgridView.UpdateTotalSummary();

            depoQryGCgridView.DataController.UpdateGroupSummary();

            GridViewInfo viewInfo = depoQryGCgridView.GetViewInfo() as GridViewInfo;
            viewInfo.SetDataDirty();
            depoQryGCgridView.InvalidateRect(depoQryGCgridView.ViewRect);
            */
        }

        decimal topSgrDgr;
        int topGirMik;
        int id;
        Dictionary<int, int> dicGirMik = new Dictionary<int, int>();
        Dictionary<int, decimal> dicSgrDgr = new Dictionary<int, decimal>();

        private void depoQryGCgridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            // Get the summary ID. 
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            string summaryFN = (e.Item as GridSummaryItem).FieldName;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                if (summaryFN == "GIRMIK")
                {
                    dicGirMik.Clear();
                    topGirMik = 0;
                }
                else if (summaryFN == "GIRSGRDGR")
                {
                    dicSgrDgr.Clear();
                    topSgrDgr = 0;
                }
            }
            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                id = (int)depoQryGCgridView.GetRowCellValue(e.RowHandle, colGIRID);

                if (summaryFN == "GIRMIK" && !dicGirMik.ContainsKey(id))
                        dicGirMik.Add(id, Convert.IsDBNull(e.FieldValue) ? 0 : Convert.ToInt32(e.FieldValue));
                else if (summaryFN == "GIRSGRDGR" && !dicSgrDgr.ContainsKey(id))
                        dicSgrDgr.Add(id, Convert.IsDBNull(e.FieldValue) ? 0.0m : Convert.ToDecimal(e.FieldValue));
            }
            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryFN)
                {
                    case "GIRMIK": 
                        foreach (var g in dicGirMik)
                            topGirMik += g.Value;
                        e.TotalValue = topGirMik;
                        break;
                    case "GIRSGRDGR": // sgrDgr
                        foreach (var s in dicSgrDgr)
                            topSgrDgr += s.Value;
                        e.TotalValue = topSgrDgr;
                        break;
                }
            }      

        }
    }
}
