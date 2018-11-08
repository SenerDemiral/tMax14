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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;

namespace tMax14.KaliteKontrol
{
    public partial class kkoXF : DevExpress.XtraEditors.XtraForm
    {
        public string OpHM = "-";
        public int OpID = 0;

        string layoutName = "KaliteKontrol.kkoXF";

        public kkoXF()
        {
            InitializeComponent();

            kkoGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDRM.ColumnEdit = Program.MF.KkoDrmRepositoryItemLookUpEdit;
            colTUR.ColumnEdit = Program.MF.KkoTurRepositoryItemLookUpEdit;
            colOLYKOD.ColumnEdit = Program.MF.KkoOlyKodRepositoryItemLookUpEdit;
            colONC.ColumnEdit = Program.MF.KkoOncRepositoryItemLookUpEdit;
            colBLDSKL.ColumnEdit = Program.MF.KkoBldSklRepositoryItemLookUpEdit;
            colFRFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colFRUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colTOUSR.ColumnEdit = Program.MF.USRrepositoryItemLookUpEdit;
            colORGDPT.ColumnEdit = Program.MF.dptRepositoryItemLookUpEdit;
            colILGUSRS.ColumnEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

            colILGFRTID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
            colBLDTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;
            colKYTTRH.ColumnEdit = Program.MF.TSrepositoryItemDateEdit;

            colTSPPRC.ColumnEdit = Program.MF.KkoTspPrcRepositoryItemLookUpEdit;
            colTAGS.ColumnEdit = Program.MF.TAGselKKOrepositoryItemCheckedComboBoxEdit;

            Program.MF.GridControlSettings(kkoGridControl);

            Program.MF.XGLrestore(layoutName, 0, kkoGridView);
            showPreviewToolStripMenuItem.Checked = kkoGridView.OptionsView.ShowPreview;


            GridView view = kkoGridView;
            for (int i = 0; i < view.Columns.Count; i++)
                view.Columns[i].OptionsEditForm.Caption = view.Columns[i].ToolTip;
        }

        private void kkoXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kkDataSet.KKO' table. You can move, or remove it, as needed.
            if (OpID == 0)
                this.kkoTableAdapter.Fill(this.kkDataSet.KKO, "", Program.USR);
            else
                this.kkoTableAdapter.Fill(this.kkDataSet.KKO, string.Format("OrgOpHM={0} and OrgOpID={1}", OpHM, OpID), Program.USR);

            kkoTableAdapter.ClearBeforeFill = false;

            frcTableAdapter.FillAll(kkDataSet.FRC);
            /*
            frcTableAdapter.ClearBeforeFill = false;
            foreach (kkDataSet.KKORow row in this.kkDataSet.KKO.Rows)
            {
                if (!row.IsFRFRTIDNull())
                    frcTableAdapter.Fill(kkDataSet.FRC, row.FRFRTID);

                if (!row.IsILGFRTIDNull())
                    frcTableAdapter.Fill(kkDataSet.FRC, row.ILGFRTID);

            }*/
            // FRCrepositoryItemGridLookUpEdit1View.ActiveFilterString = string.Format("[FRTID] = {0}", 17);

        }

        public void Save()  // MainForm
        {
            try
            {
                this.Validate();
                this.kkoBindingSource.EndEdit();
                this.kkoTableAdapter.Update(kkDataSet.KKO);

                /*
                kkDataSet.KKODataTable dt = (kkDataSet.KKODataTable)kkDataSet.KKO.GetChanges(DataRowState.Modified | DataRowState.Added | DataRowState.Deleted);
                if (dt != null)
                {
                    foreach (kkDataSet.KKORow row in dt)
                        if (row.RowState == DataRowState.Modified)
                            row.UPDUSR = Program.USR;
                        else if (row.RowState == DataRowState.Added)
                            row.INSUSR = Program.USR;

                    this.kkoTableAdapter.Update(kkDataSet.KKO);
                    
                    foreach (kkDataSet.KKORow row in dt)
                    {
                        if (row.RowState != DataRowState.Deleted)
                            this.kkoTableAdapter.Fill(this.kkDataSet.KKO, string.Format("KKOID = {0}", row.KKOID), ""); //Refresh
                    }
                }*/
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.kkDataSet.KKO.RejectChanges();
            }
        }

        private void muhatapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("KaliteKontrol.kkoXF.kkm", isSilent: false))
                return;

            int kkoID = (int)kkoGridView.GetFocusedRowCellValue(colKKOID);
            string vsbl = kkoGridView.GetFocusedRowCellValue("VSBL").ToString();
            kkmXF frm = new kkmXF();
            frm.kkoID = kkoID;
            frm.vsbl = vsbl;
            frm.Show();
        }

        private void faaliyetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("KaliteKontrol.kkoXF.kkf", isSilent: false))
                return;

            int kkoID = (int)kkoGridView.GetFocusedRowCellValue("KKOID");
            string vsbl = kkoGridView.GetFocusedRowCellValue("VSBL").ToString();
            kkfXF frm = new kkfXF();
            frm.kkoID = kkoID;
            frm.vsbl = vsbl;
            frm.kkoKonu = kkoGridView.GetFocusedRowCellDisplayText("OLYKOD");
            frm.Show();
        }


        private void kkoGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;
            int PK = (int)kkQueriesTableAdapter.GET_PK("KK");

            view.SetFocusedRowCellValue("EDITABLE", "T");
            view.SetFocusedRowCellValue("VSBL", "T");
            view.SetFocusedRowCellValue("PRVT", "F");
            view.SetFocusedRowCellValue("KKOID", PK);
            view.SetFocusedRowCellValue("BLDTRH", DateTime.Today);

            if (OpID != 0)
            {
                view.SetFocusedRowCellValue("ORGOPHM", OpHM);
                view.SetFocusedRowCellValue("ORGOPID", OpID);
            }
        }

        private void FRCrepositoryItemGridLookUpEdit_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;

            object frtID = null;

            if (kkoGridView.FocusedColumn.FieldName == "FRFRCID")
            {
                //frtID = kkoGridView.GetFocusedRowCellValue("FRFRTID");
                editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", kkoGridView.GetFocusedRowCellValue("FRFRTID"));
            }
            else if (kkoGridView.FocusedColumn.FieldName == "ILGFRCID")
            {
                //frtID = kkoGridView.GetFocusedRowCellValue("ILGFRTID");
                editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", kkoGridView.GetFocusedRowCellValue("ILGFRTID"));
            }
            /*
            frtID = frtID == null ? 0 : frtID;

            frcTableAdapter.Fill(kkDataSet.FRC, Convert.ToInt32(frtID));
            
            editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", frtID);*/
        }

        private void FRCrepositoryItemLookUpEdit_Popup(object sender, EventArgs e)
        {
            //LookUpEdit editor = (LookUpEdit)sender;
            //editor.Properties.DataSource
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = layoutName;
            frm.origin = kkoGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = kkoGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 10, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "Kalite Yönetim Olaylar", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "", Program.USR });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void showPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kkoGridView.OptionsView.ShowPreview = !kkoGridView.OptionsView.ShowPreview;
            showPreviewToolStripMenuItem.Checked = kkoGridView.OptionsView.ShowPreview;
        }

        private void eMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kkoGridView.DataRowCount == 0)
                return;

            int refID = (int)kkoGridView.GetFocusedRowCellValue("KKOID");

            kkSendMailXF frm = new kkSendMailXF();
            frm.tbl = "O";
            frm.refID = refID;
            frm.ShowDialog();

        }

        private void olayFaaliyetRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kkOlyFlytXF frm = new kkOlyFlytXF();
            frm.Show();
        }

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = kkoGridView;

            if (view.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle || !view.IsDataRow(view.FocusedRowHandle))
                return;

            int pk = (int)view.GetFocusedRowCellValue("KKOID");
            Genel.onayXF frm = new Genel.onayXF();
            frm.curYTK = view.GetFocusedRowCellDisplayText("ONYYTK");
            frm.Tbl = "KKO";
            frm.TblPK = pk;
            frm.ShowDialog();
            frm.Dispose();
            this.kkoTableAdapter.Fill(this.kkDataSet.KKO, string.Format("KKOID={0}", pk), Program.USR);
        }

        private void kkoGridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            GridView view = (GridView)sender;

            if (e.ListSourceRowIndex < 0)
                return;

            string vsbl = view.GetListSourceRowCellValue(e.ListSourceRowIndex, colVSBL).ToString();

            if (vsbl == "F")
            {
                if (e.Column.FieldName == "DETAY")
                    e.DisplayText = "¤";
            }

        }

        private void kkoGridView_CustomDrawRowPreview(object sender, RowObjectCustomDrawEventArgs e)
        {
            GridView view = (GridView)sender;

            string vsbl = view.GetRowCellValue(e.RowHandle, "VSBL").ToString();
            if (vsbl == "F")
                e.Handled = true;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Save();
        }

        private void kkoGridView_ShowingPopupEditForm(object sender, ShowingPopupEditFormEventArgs e)
        {
            GridView view = sender as GridView;

            bool ro = view.GetFocusedRowCellValue("EDITABLE").ToString() == "F";
            for (int i = 0; i < view.Columns.Count; i++)
            {
                if (view.Columns[i].Visible)
                {
                    if (ro || !view.Columns[i].OptionsColumn.AllowEdit)
                        e.BindableControls[view.Columns[i].FieldName].Enabled = false;
                }
            }
            if (view.GetFocusedRowCellValue("VSBL").ToString() == "F")
                e.BindableControls["DETAY"].Enabled = false;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridView view = kkoGridView;

            view.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
            view.ShowEditForm();
            view.OptionsBehavior.EditingMode = GridEditingMode.Default;

        }

        private void kkoGridView_ShownEditor(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            var aaa = view.FocusedColumn.FieldName;
        }

        private void frFRCrepositoryItemGridLookUpEdit_Enter(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            GridView view = kkoGridView;

            editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", view.GetFocusedRowCellValue("FRFRTID"));
        }

        private void ilgFRCrepositoryItemGridLookUpEdit_Popup(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            GridView view = kkoGridView;

            editor.Properties.View.ActiveFilterString = string.Format("[FRTID] = {0}", view.GetFocusedRowCellValue("ILGFRTID"));
        }

        private void bosUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Program.MF.EntryCheck("KaliteKontrol.BosUpdate", isSilent: true))
                return;

            int kkoID = (int)kkoGridView.GetFocusedRowCellValue(colKKOID);
            Save();

            kkoBosXF frm = new kkoBosXF();
            frm.kkoID = kkoID;
            frm.ShowDialog();

            kkoTableAdapter.Fill(this.kkDataSet.KKO, string.Format("KKOID = {0}", kkoID), Program.USR); //Refresh

        }
    }
}