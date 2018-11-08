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

namespace tMax14.KaliteKontrol
{
    public partial class kkfXF : DevExpress.XtraEditors.XtraForm
    {
        public int kkoID = 0;
        public string kkoKonu = "";
        public string vsbl = "F";
        string layoutName = "KaliteKontrol.kkfXF";
        
        public kkfXF()
        {
            InitializeComponent();

            kkfGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTUR.ColumnEdit = Program.MF.KkfTurRepositoryItemLookUpEdit;
            colYTKUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colMHTUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colAMRUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;

            colTNMUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colDGRUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colKYTTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            Program.MF.GridControlSettings(kkfGridControl);
            Program.MF.XGLrestore(layoutName, 0, kkfGridView);

            kkfGridView.OptionsBehavior.ReadOnly = !Program.MF.ModifyCheck("KaliteKontrol.kkoXF.kkf", isSilent: true);
        }

        public void Save()  // MainForm
        {
            try
            {
                this.Validate();
                this.kkfBindingSource.EndEdit();
                this.kkfTableAdapter.Update(kkDataSet.KKF);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.kkDataSet.KKF.RejectChanges();
            }
        }

        private void kkfXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Olay: {0} Faaliyetleri", kkoID);

            this.kkfTableAdapter.Fill(this.kkDataSet.KKF, kkoID, "O", Program.USR);
            kkfTableAdapter.ClearBeforeFill = false;

            if (vsbl == "F")
            {
                colDETAY.Visible = false;
                colDETAY.OptionsColumn.ShowInCustomizationForm = false;
            }
        }

        private void kkfGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            int PK = (int)kkQueriesTableAdapter.GET_PK("KK");
            
            view.SetFocusedRowCellValue("KKFID", PK);
            view.SetFocusedRowCellValue("KKOID", kkoID);

        }

        private void attachmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vsbl == "F")
                return;

            var view = kkfGridView;

            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            Doc.DocXF frm = new Doc.DocXF();
            int pk = (int)view.GetFocusedRowCellValue("KKFID");
            frm.RefTbl = "AFB";
            frm.RefID = pk;
            frm.RefInfo = "Kalite Kontrol Faaliyet: " + pk.ToString();

            frm.ShowDialog();
            frm.Dispose();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = kkfGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kkfGridView.DataRowCount == 0)
                return;

            int refID = (int)kkfGridView.GetFocusedRowCellValue("KKFID");

            kkSendMailXF frm = new kkSendMailXF();
            frm.tbl = "F";
            frm.refID = refID;
            frm.ShowDialog();

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = kkfGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { string.Format("[{0}] {1}", kkoID, kkoKonu), "", "Kalite Yönetim Faaliyet" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = kkfGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int pk = (int)view.GetFocusedRowCellValue("KKFID");
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText("ONYYTK");
            frm.Tbl = "KKF";
            frm.TblPK = pk;
            frm.ShowDialog();
            frm.Dispose();
            this.kkfTableAdapter.Fill(this.kkDataSet.KKF, pk, "F", Program.USR); //Refresh Clear=false
        }

        private void kkfGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void bosUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("KaliteKontrol.BosUpdate", isSilent: true))
                return;

            kkfBosXF frm = new kkfBosXF();
            frm.kkfID = (int)kkfGridView.GetFocusedRowCellValue(colKKFID);
            frm.ShowDialog();

        }
    }
}