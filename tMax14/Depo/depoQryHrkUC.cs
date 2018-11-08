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
    public partial class depoQryHrkUC : DevExpress.XtraEditors.XtraUserControl
    {
        public depoQryHrkUC()
        {
            InitializeComponent();

            depoQryHrkGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colGIRFRTID.ColumnEdit = Program.MF.ftRepositoryItemSearchLookUpEdit;   // Gecici FT
            colGTPID.ColumnEdit = Program.MF.gtpRepositoryItemSearchLookUpEdit;

            trh1dateEdit.DateTime = DateTime.Today;
            trh2dateEdit.DateTime = DateTime.Today.AddDays(1);

            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Application = "tMax14";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Author = "Şener DEMİRAL";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Subject = "Depo Hareketleri";
            this.printingSystem.ExportOptions.Pdf.DocumentOptions.Title = "Transorient Depo Hareketleri";
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.depoQryHrkTrhTableAdapter.Fill(this.depoDataSet.DEPOQRY_HRK_TRH, trh1dateEdit.DateTime, trh2dateEdit.DateTime);
                //depoQryHrkGridView.ExpandAllGroups();
                depoQryHrkGridView.BestFitColumns();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depoQryHrkPrintableComponentLink.CreateDocument();
            depoQryHrkPrintableComponentLink.ShowPreviewDialog();
        }
    }
}
