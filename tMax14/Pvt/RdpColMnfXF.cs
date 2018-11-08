using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace tMax14.Pvt
{
    public partial class RdpColMnfXF : DevExpress.XtraEditors.XtraForm
    {
        public int opmID;

        public RdpColMnfXF()
        {
            InitializeComponent();

            oPM_PDP_COLMNFGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colB_KUTUGONDER.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
        }

        private void RdpColMnfXF_Load(object sender, EventArgs e)
        {

            this.oPM_PDP_COLMNFTableAdapter.Fill(this.pvtDataSet.OPM_PDP_COLMNF, opmID);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = oPM_PDP_COLMNFGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "RDP Collection Manifest", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }
    }
}