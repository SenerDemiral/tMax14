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

namespace tMax14.KaliteKontrol
{
    public partial class kkmXF : DevExpress.XtraEditors.XtraForm
    {
        public int kkoID = 0;
        public string vsbl = "F";
        string layoutName = "KaliteKontrol.kkmXF";

        public kkmXF()
        {
            InitializeComponent();

            kkmGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTOB.ColumnEdit = Program.MF.TOBrepositoryItemLookUpEdit;
            colROT.ColumnEdit = Program.MF.ROTrepositoryItemLookUpEdit;
            colMOT.ColumnEdit = Program.MF.MOTrepositoryItemLookUpEdit;
            colMHTUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colTYTUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colEDITABLE.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            colKNU.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colKYTTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            Program.MF.GridControlSettings(kkmGridControl);

            kkmGridView.OptionsBehavior.ReadOnly = !Program.MF.ModifyCheck("KaliteKontrol.kkoXF.kkm", isSilent: true);
        }

        public void Save()  // MainForm
        {
            try
            {
                this.Validate();
                this.kkmBindingSource.EndEdit();
                this.kkmTableAdapter.Update(kkDataSet.KKM);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.kkDataSet.KKM.RejectChanges();
            }
        }

        private void kkmXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Olay: {0} Muhatapları", kkoID);

            if (vsbl == "F")
            {
                colN1.Visible = false;
                colN1.OptionsColumn.ShowInCustomizationForm = false;
                colN2.Visible = false;
                colN2.OptionsColumn.ShowInCustomizationForm = false;
                colN3.Visible = false;
                colN3.OptionsColumn.ShowInCustomizationForm = false;
                colN4.Visible = false;
                colN4.OptionsColumn.ShowInCustomizationForm = false;
                colN5.Visible = false;
                colN5.OptionsColumn.ShowInCustomizationForm = false;
            }

            this.kkmTableAdapter.Fill(this.kkDataSet.KKM, kkoID, "O", Program.USR);
            kkmTableAdapter.ClearBeforeFill = false;

            frcTableAdapter.ClearBeforeFill = false;
            foreach (kkDataSet.KKMRow row in this.kkDataSet.KKM.Rows)
            {
                if (!row.IsFRTIDNull())
                    frcTableAdapter.Fill(kkDataSet.FRC, row.FRTID);
            }
        }

        private void kkmGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            int PK = (int)kkQueriesTableAdapter.GET_PK("KK");

            view.SetFocusedRowCellValue("KKMID", PK);
            view.SetFocusedRowCellValue("KKOID", kkoID);
            view.SetFocusedRowCellValue("KNU", "F");
        }

        private void FRCrepositoryItemGridLookUpEdit_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;

            object frtID = null;

            if (kkmGridView.FocusedColumn.FieldName == "FRCID")
            {
                frtID = kkmGridView.GetFocusedRowCellValue("FRTID");
                //filter = string.Format("[FRTID] = {0}", kkoGridView.GetFocusedRowCellValue("FRFRTID"));
            }

            frtID = frtID == DBNull.Value ? 0 : frtID;

            frcTableAdapter.Fill(kkDataSet.FRC, Convert.ToInt32(frtID));

            editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", frtID);
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = kkmGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void kkmGridView_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            string n1 = kkmGridView.GetRowCellDisplayText(e.RowHandle, "N1");
            string n2 = kkmGridView.GetRowCellDisplayText(e.RowHandle, "N2");
            string n3 = kkmGridView.GetRowCellDisplayText(e.RowHandle, "N3");
            string n4 = kkmGridView.GetRowCellDisplayText(e.RowHandle, "N4");
            string n5 = kkmGridView.GetRowCellDisplayText(e.RowHandle, "N5");

            n1 = string.IsNullOrWhiteSpace(n1) ? "" : "N1: " + n1 + "\r\n";
            n2 = string.IsNullOrWhiteSpace(n2) ? "" : "N2: " + n2 + "\r\n";
            n3 = string.IsNullOrWhiteSpace(n3) ? "" : "N3: " + n3 + "\r\n";
            n4 = string.IsNullOrWhiteSpace(n4) ? "" : "N4: " + n4 + "\r\n";
            n5 = string.IsNullOrWhiteSpace(n5) ? "" : "N5: " + n5 + "\r\n";

            e.PreviewText = n1 + n2 + n3 + n4 + n5;
        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kkmGridView.OptionsView.ShowPreview = !kkmGridView.OptionsView.ShowPreview;
            showPreviewToolStripMenuItem.Checked = kkmGridView.OptionsView.ShowPreview;
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kkmGridView.DataRowCount == 0)
                return;

            int refID = (int)kkmGridView.GetFocusedRowCellValue("KKMID");

            kkSendMailXF frm = new kkSendMailXF();
            frm.tbl = "M";
            frm.refID = refID;
            frm.ShowDialog();

        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = kkmGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int pk = (int)view.GetFocusedRowCellValue("KKMID");
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText("ONYYTK");
            frm.Tbl = "KKM";
            frm.TblPK = pk;
            frm.ShowDialog();
            frm.Dispose();
            this.kkmTableAdapter.Fill(this.kkDataSet.KKM, pk, "M", Program.USR); //Refresh Clear=false
        }
    }
}