using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraPrinting;

namespace tMax14.Users
{
    public partial class ustForm : DevExpress.XtraEditors.XtraForm
    {
        bool editable;

        public ustForm()
        {
            InitializeComponent();


            ustGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDRM.ColumnEdit = Program.MF.ustDrmRepositoryItemLookUpEdit;
            colYMKTUR.ColumnEdit = Program.MF.ustYmkTurRepositoryItemLookUpEdit;
            colTMU.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colSEX.ColumnEdit = Program.MF.sexRepositoryItemLookUpEdit;
            colMNTRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colKANGRP.ColumnEdit = Program.MF.kanGrpRepositoryItemLookUpEdit;
            colUNVT.ColumnEdit = Program.MF.stringRepositoryItemTextEdit;
            colUNVE.ColumnEdit = Program.MF.stringRepositoryItemTextEdit;
            colKRYSVY.ColumnEdit = Program.MF.krySvyRepositoryItemLookUpEdit;
            colISYER.ColumnEdit = Program.MF.isYerRepositoryItemLookUpEdit;
            colCLSGRP.ColumnEdit = Program.MF.clsGrpRepositoryItemLookUpEdit;
            colDPT.ColumnEdit = Program.MF.dptRepositoryItemLookUpEdit;            
            colTCKNO.ColumnEdit = Program.MF.tckNoRepositoryItemTextEdit;
            colOFSKART.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colOTPKART.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTKIBH.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            colTRNOVR.ColumnEdit = Program.MF.UstTrnOvrRepositoryItemLookUpEdit;

            colROTS.ColumnEdit = Program.MF.ROTrepositoryItemCheckedComboBoxEdit;
            colMOTS.ColumnEdit = Program.MF.MOTrepositoryItemCheckedComboBoxEdit;
            colHDNFS.ColumnEdit = Program.MF.frtTurRepositoryItemCheckedComboBoxEdit;

            
            usiGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTURi.ColumnEdit = Program.MF.usiTurRepositoryItemLookUpEdit;

            //uspGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            ///colFRMp.ColumnEdit = Program.MF.uspFrmRepositoryItemLookUpEdit;
            //colENTp.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;
            //colMDFp.ColumnEdit = Program.MF.TFrepositoryItemCheckEdit;

            ustGridView.BestFitColumns();

            // Docks
            // USK telefon
            // USI izin
            // USM Maas
            // USA Arac
            // USP Permitions
        }

        private void uSTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            this.Validate();
            this.ustBindingSource.EndEdit();
            //this.ustTableAdapter.Update(this.usersDataSet.UST);
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        }

        private void ustForm_Load(object sender, EventArgs e)
        {
            ustGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.ustForm", isSilent: true);
            usaGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.usaDP", isSilent: true);
            uskGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.uskDP", isSilent: true);
            usiGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.usiDP", isSilent: true);
            usmGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Users.usmDP", isSilent: true);

            this.ustTableAdapter.Fill(this.usersDataSet.UST);

            if (Program.MF.EntryCheck("Users.usaDP", true))
                this.usaTableAdapter.Fill(this.usersDataSet.USA);
            if (Program.MF.EntryCheck("Users.uskDP", true))
                this.uskTableAdapter.Fill(this.usersDataSet.USK);
            if (Program.MF.EntryCheck("Users.usiDP", true))
                this.usiTableAdapter.Fill(this.usersDataSet.USI);
            if (Program.MF.EntryCheck("Users.usmDP", true))
                this.usmTableAdapter.Fill(this.usersDataSet.USM);
            
            Program.MF.GridControlSettings(ustGridControl);
            Program.MF.GridControlSettings(uskGridControl);
            Program.MF.GridControlSettings(usaGridControl);
            Program.MF.GridControlSettings(usiGridControl);
            Program.MF.GridControlSettings(usmGridControl);
            //Program.MF.GridControlSettings(uspGridControl); NoInsert

            if (!Program.MF.EntryCheck("Users.uskDP", true))
                uskDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Users.usiDP", true))
                usiDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Users.usmDP", true))
                usmDockPanel.Visibility = DockVisibility.Hidden;
            if (!Program.MF.EntryCheck("Users.usaDP", true))
                usaDockPanel.Visibility = DockVisibility.Hidden;

            usiPivotToolStripMenuItem.Enabled = Program.MF.EntryCheck("Users.usiPivot", true);
            usaPivotToolStripMenuItem.Enabled = Program.MF.EntryCheck("Users.usaPivot", true);
            uskPivotToolStripMenuItem.Enabled = Program.MF.EntryCheck("Users.uskPivot", true);
            usmPivotToolStripMenuItem.Enabled = Program.MF.EntryCheck("Users.usmPivot", true);
        }

        private void dockManager_Expanding(object sender, DockPanelCancelEventArgs e)
        {/*
            if (e.Panel == uskDockPanel)
                e.Cancel = !Program.MF.EntryCheck("Users.uskDP", true);
            else if (e.Panel == usiDockPanel)
                e.Cancel = !Program.MF.EntryCheck("Users.usiDP", true);
            else if (e.Panel == usmDockPanel)
                e.Cancel = !Program.MF.EntryCheck("Users.usmDP", true);
            else if (e.Panel == usaDockPanel)
                e.Cancel = !Program.MF.EntryCheck("Users.usaDP", true);
            else if (e.Panel == uspDockPanel)
                e.Cancel = !Program.MF.EntryCheck("Users.uspDP", true);*/
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        #region InitNewRow

        private void ustGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            object pk = usersQueriesTableAdapter.GET_PK("UST");
            ustGridView.SetRowCellValue(e.RowHandle, colUSTID, pk);
        }

        private void uspGridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //uspGridView.SetRowCellValue(e.RowHandle, colENTp, "F");
            //uspGridView.SetRowCellValue(e.RowHandle, colMDFp, "F");
        }

        #endregion InitNewRow

        private void ustForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MFDgridView.CloseEditor();
            //MFDgridView.UpdateCurrentRow();

            this.Validate();
            this.ustBindingSource.EndEdit();

            if (usersDataSet.HasChanges())
            {
                this.Activate();
                //Font defaultFont = AppearanceObject.DefaultFont;
                //AppearanceObject.DefaultFont = new Font("Verdana", 10, FontStyle.Bold);

                DialogResult dr = XtraMessageBox.Show("Değişiklik var! \n\nKaydetmek için Yes, \nKaydetmeden çıkmak için No, \nÇıkmaktan vazgeçmek için Cancel basın\n ", this.Text, MessageBoxButtons.YesNoCancel);
                //AppearanceObject.DefaultFont = defaultFont;
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Save();
                }
                else if (dr == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void usmGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DateTime oValue = (DateTime)usmGridView.GetRowCellValue(e.RowHandle, colTRHm);
            if (oValue.Day != 1)
            {
                DateTime nValue = oValue.AddDays(oValue.Day * -1 + 1);
                usmGridView.SetRowCellValue(e.RowHandle, colTRHm, nValue);
            }
            DateTime iseGrsTrh = (DateTime)ustGridView.GetFocusedRowCellValue(colISGRSTRH);
            iseGrsTrh = iseGrsTrh.AddDays(iseGrsTrh.Day * -1 + 1);
            DateTime maasTrh = (DateTime)usmGridView.GetRowCellValue(e.RowHandle, colTRHm);

            if (maasTrh < iseGrsTrh)
            {
                e.ErrorText = "İşe giriş tarihinden küçük olamaz";
                e.Valid = false;
                usmDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else
                usmDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;

        }

        private void usiPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Users.usiDP", true))
            {
                usiPivot frm = new usiPivot();
                frm.ShowDialog();
            }
        }

        private void usmPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Users.usmDP", true))
            {
                usmPivot frm = new usmPivot();
                frm.ShowDialog();
            }
        }

        private void uskPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Users.uskDP", true))
            {
                uskPivot frm = new uskPivot();
                frm.ShowDialog();
            }
        }

        private void usaPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MF.EntryCheck("Users.usaDP", true))
            {
                usaPivot frm = new usaPivot();
                frm.ShowDialog();
            }
        }

        private void ustGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridColumn col = ustGridView.FocusedColumn;
            if (col == colUSR)
            {
                if (ustGridView.GetFocusedDataRow().RowState != DataRowState.Detached && !string.IsNullOrWhiteSpace(ustGridView.GetFocusedRowCellDisplayText(colUSR)))
                {
                    e.Cancel = true;
                }
                //string ggg = ustGridView.GetFocusedRowCellDisplayText(colUSR);
                //string sss = ustGridView.GetFocusedDataRow().RowState.ToString();
            }

            if (col.ColumnEdit == Program.MF.stringRepositoryItemTextEdit)
            {
                Program.MF.stringRepositoryItemTextEdit.MaxLength = this.usersDataSet.UST.Columns[col.FieldName].MaxLength;
            }
         }

        private void ınfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ri = ustGridView.GetFocusedDataSourceRowIndex();
            //UsersDataSet.USTRow ustRow = (UsersDataSet.USTRow)usersDataSet.UST.Rows[ri];
            //ustInfoForm frm = new ustInfoForm((UsersDataSet.USTRow)usersDataSet.UST.Rows[ri]);
            ustInfoForm frm = new ustInfoForm(this);
            frm.ShowDialog();
        }

        private void documentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ustGridView.DataRowCount == 0)
                return;

            Doc.DocXF frm = new Doc.DocXF();
            frm.RefTbl = "UST";
            frm.RefID = (int)ustGridView.GetFocusedRowCellValue(colUSTID);
            frm.RefInfo = ustGridView.GetFocusedRowCellDisplayText(colAD);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void defaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //usersQueriesTableAdapter.USP_INS_USR((int)ustGridView.GetFocusedRowCellValue(colUSTID));
            //this.uspTableAdapter.Fill(this.usersDataSet.USP);

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.USTid > 2)
                colEMAILPWD.OptionsColumn.Printable = DefaultBoolean.False;

            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);

            link.Component = ustGridControl;
            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 50;
            link.Margins.Bottom = 50;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            phf.Header.Content.AddRange(new string[] { "", "TTEAM PERSONEL LİSTESİ", "" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "LS-6.2-03 / Rev:00 / Rev. Tarih: -", "", "" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();

            /*
            var Font = new Font("Tahoma", 12, FontStyle.Bold);
            DevExpress.XtraPrinting.PageHeaderFooter phf = new PageHeaderFooter();
                        
            DevExpress.XtraPrinting.PageHeaderArea pha = new DevExpress.XtraPrinting.PageHeaderArea();
            pha.Content.Add("TTEAM PERSONEL LİSTESİ");
            pha.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far;

            pha.Font = Font;

            DevExpress.XtraPrinting.PageFooterArea pfa = new DevExpress.XtraPrinting.PageFooterArea();
            pfa.Content.Add("LS-6.2-03 / Rev:00 / Rev. Tarih: -");
            pfa.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Near;

            phf = new DevExpress.XtraPrinting.PageHeaderFooter(pha, pfa);

            link.PageHeaderFooter = phf;
            link.CreateDocument();
            link.ShowPreview();
            */
        }

        private void jurnalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int refId = (int)ustGridView.GetFocusedRowCellValue(colUSTID);

            Jurnal.jrnXF frm = new Jurnal.jrnXF();
            frm.RefTbl = "UST";
            frm.RefID = refId;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.xglFX frm = new Genel.xglFX();
            frm.id = "Users.ustForm";
            frm.origin = ustGridView;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void pivotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}