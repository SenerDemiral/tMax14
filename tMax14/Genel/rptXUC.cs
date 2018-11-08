using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraRichEdit;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace tMax14.Genel
{
    public partial class rptXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public rptXUC()
        {
            InitializeComponent();

            //ustNotRichEditControl.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A4;
            //ustNotRichEditControl.Document.Sections[0].Margins.Left = 0;
            //ustNotRichEditControl.Document.Sections[0].Margins.Right = 0;

        }

        private void rptXUC_Load(object sender, EventArgs e)
        {
            rptTableAdapter.Fill(genelDataSet.RPT);
            /*
            DockPanel fdp = dockManager.AddPanel(DockingStyle.Bottom);
            fdp.Text = "Footer";
            fdp.FloatSize = new System.Drawing.Size(800, 400);
            var frec = new RichEditControl();
            frec.ActiveViewType = RichEditViewType.Simple;
            frec.Dock = DockStyle.Fill;
            frec.DataBindings.Add("RtfText", rptBindingSource, "FOOTER");
            fdp.ControlContainer.Controls.Add(frec);

            DockPanel adp = dockManager.AddPanel(DockingStyle.Bottom);
            adp.Text = "Alt Not";
            var arec = new RichEditControl();
            arec.ActiveViewType = RichEditViewType.Simple;
            arec.Dock = DockStyle.Fill;
            arec.DataBindings.Add("RtfText", rptBindingSource, "ALTNOT");
            adp.ControlContainer.Controls.Add(arec);
            adp.DockAsTab(fdp, 0);

            DockPanel udp = dockManager.AddPanel(DockingStyle.Bottom);
            udp.Text = "Üst Not";
            var urec = new RichEditControl();
            urec.ActiveViewType = RichEditViewType.Simple;
            urec.Dock = DockStyle.Fill;
            urec.DataBindings.Add("RtfText", rptBindingSource, "USTNOT");
            udp.ControlContainer.Controls.Add(urec);
            // Panel dp2 will be displayed within the first tab.
            udp.DockAsTab(fdp, 0);

            DockPanel bdp = dockManager.AddPanel(DockingStyle.Bottom);
            udp.Text = "eMail Body";
            var brec = new RichEditControl();
            brec.ActiveViewType = RichEditViewType.Simple;
            brec.Dock = DockStyle.Fill;
            brec.DataBindings.Add("HtmlText", rptBindingSource, "EMAILBODY");
            udp.ControlContainer.Controls.Add(brec);
            // Panel dp2 will be displayed within the first tab.
            bdp.DockAsTab(fdp, 0);
*/
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.rptBindingSource.EndEdit();

            ClearEmptyTRF();
            this.rptTableAdapter.Update(this.genelDataSet.RPT);
        }

        private void RichEditControl_DocumentLoaded(object sender, EventArgs e)
        {
            var rec = sender as DevExpress.XtraRichEdit.RichEditControl;
            rec.Document.DefaultCharacterProperties.FontName = "Tahoma";
            rec.Document.DefaultCharacterProperties.FontSize = 10;
        }

        private void rptGridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
                rptGridView.Focus();
        }

        private void ClearEmptyTRF()
        {
            RichEditControl rec = new RichEditControl();
            for (int i = 0; i < this.genelDataSet.RPT.Rows.Count; i++)
            {
                if (this.genelDataSet.RPT.Rows[i]["USTNOT"] != DBNull.Value)
                {
                    rec.RtfText = this.genelDataSet.RPT.Rows[i]["USTNOT"].ToString();
                    if (string.IsNullOrWhiteSpace(rec.Text))
                        this.genelDataSet.RPT.Rows[i]["USTNOT"] = DBNull.Value;
                }

                if (this.genelDataSet.RPT.Rows[i]["ALTNOT"] != DBNull.Value)
                {
                    rec.RtfText = this.genelDataSet.RPT.Rows[i]["ALTNOT"].ToString();
                    if (string.IsNullOrWhiteSpace(rec.Text))
                        this.genelDataSet.RPT.Rows[i]["ALTNOT"] = DBNull.Value;
                }

                if (this.genelDataSet.RPT.Rows[i]["FOOTER"] != DBNull.Value)
                {
                    rec.RtfText = this.genelDataSet.RPT.Rows[i]["FOOTER"].ToString();
                    if (string.IsNullOrWhiteSpace(rec.Text))
                        this.genelDataSet.RPT.Rows[i]["FOOTER"] = DBNull.Value;
                }
               
                if (this.genelDataSet.RPT.Rows[i]["EMAILBODY"] != DBNull.Value)
                {
                    rec.HtmlText = this.genelDataSet.RPT.Rows[i]["EMAILBODY"].ToString();
                    if (string.IsNullOrWhiteSpace(rec.Text))
                        this.genelDataSet.RPT.Rows[i]["EMAILBODY"] = DBNull.Value;
                }
            }
        }

        private void dinamikDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptdXF frm = new rptdXF();
            frm.RPTid = (int)rptGridView.GetFocusedRowCellValue(colRPTID);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void rptGridControl_Click(object sender, EventArgs e)
        {

        }

        private void eMaılSubjectDockPanel_Click(object sender, EventArgs e)
        {

        }

        private void eMailBodyDockPanel_Click(object sender, EventArgs e)
        {

        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = rptGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Doc.DocXF frm = new Doc.DocXF();

            frm.RefTbl = "RPT";
            frm.RefID = (int)view.GetFocusedRowCellValue(colRPTID);
            frm.RefInfo = "Rapor Tanım: " + view.GetFocusedRowCellDisplayText(colRPTID);
            //frm.AltTbl = "FRT";
            //frm.AltID = (int)view.GetFocusedRowCellValue(colFRTID); ;

            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
