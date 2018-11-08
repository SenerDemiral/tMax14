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
    public partial class OphPgXF : DevExpress.XtraEditors.XtraForm
    {
        public OphPgXF()
        {
            InitializeComponent();

            ophPgGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            colROS.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMETA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMATA.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colDRBD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colRTR.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colROH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colMRTD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colPOD.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
        }

        private void OphPgXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pvtDataSet.OPH_PG' table. You can move, or remove it, as needed.
            this.oPH_PGTableAdapter.Fill(this.pvtDataSet.OPH_PG);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("Ops.opHouse.Export", isSilent: true))
                return;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = ophPgGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "P&G OVERVIEW REPORT", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "Transorient", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

        }
    }
}