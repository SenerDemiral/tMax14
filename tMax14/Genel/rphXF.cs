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

namespace tMax14.Genel
{
    public partial class rphXF : DevExpress.XtraEditors.XtraForm
    {
        public string iQry = "";

        public rphXF()
        {
            InitializeComponent();

            Program.MF.GridControlSettings(rphGridControl);
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colRPTKOD.ColumnEdit = Program.MF.RptKodRepositoryItemCheckedComboBoxEdit;
            colREFTO.ColumnEdit = Program.MF.RphRefTOrepositoryItemImageComboBox;
            colUUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void rphXF_Load(object sender, EventArgs e)
        {
            Qry.qsvRphXUC frm = new Qry.qsvRphXUC();
            frm.RPH = genelDataSet.RPH;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            try
            {
                this.rphTableAdapter.Fill(this.genelDataSet.RPH, iQry, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Save()  // MainForm
        {
            try
            {
                this.Validate();
                this.rphBindingSource.EndEdit();

                this.rphTableAdapter.Update(genelDataSet.RPH);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.genelDataSet.RPH.RejectChanges();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = rphGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            string mdlH = string.Format("REPORT HISTORY");
            phf.Header.Content.AddRange(new string[] { "", mdlH, "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void rphXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
        }

    }
}