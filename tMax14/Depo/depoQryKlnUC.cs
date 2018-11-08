using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Depo
{
    public partial class depoQryKlnUC : DevExpress.XtraEditors.XtraUserControl
    {
        public depoQryKlnUC()
        {
            InitializeComponent();

            depoQryKlnGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colGIRFRTID.ColumnEdit = Program.MF.ftRepositoryItemSearchLookUpEdit;   // Gecici FT
            colGTPID.ColumnEdit = Program.MF.gtpRepositoryItemSearchLookUpEdit;

            trh1dateEdit.DateTime = DateTime.Today;
            trh2dateEdit.DateTime = DateTime.Today.AddDays(1);
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e)
        {   /* DENEME
            if (e.Field == fieldGIRFRTID && e.Value != null)
            {
                var ftRow = Program.MF.mainDataSet.FT.Rows.Find(e.Value);
                e.DisplayText = ftRow["AD"].ToString();
            }*/
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.depoQryKlnTrhTableAdapter.Fill(this.depoDataSet.DEPOQRY_KLN_TRH, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tRH1ToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tRH2ToolStripTextBox.Text, typeof(System.DateTime))))));
                this.depoQryKlnTrhTableAdapter.Fill(this.depoDataSet.DEPOQRY_KLN_TRH, trh1dateEdit.DateTime, trh2dateEdit.DateTime);
                depoQryKlnGridView.ExpandAllGroups();
                depoQryKlnGridView.BestFitColumns();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depoQryKlnPrintableComponentLink.CreateDocument();
            depoQryKlnPrintableComponentLink.ShowPreviewDialog();
        }
    }
}
