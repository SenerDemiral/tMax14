using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Qry
{
    public partial class qsJrnXF : DevExpress.XtraEditors.XtraUserControl
    {
        public Jurnal.JurnalDataSet.JRNDataTable JRN;

        public string Tbl;
        public int TblPK;

        public qsJrnXF()
        {
            InitializeComponent();
        }

        private void qsJrnXF_Load(object sender, EventArgs e)
        {
            var newRow = qryDataSet.qsJRN.NewqsJRNRow();
            newRow.PRVT = false;
            newRow.BKMD = false;
            newRow.MBRS = Program.USRtag;
            newRow.UPDTS1 = DateTime.Today.AddDays(-30);
            if (!string.IsNullOrWhiteSpace(Tbl))
            {
                newRow.REFTBL = Tbl;
                newRow.REFID = TblPK;
                colREFTBL.OptionsColumn.AllowEdit = false;
                colREFID.OptionsColumn.AllowEdit = false;
            }
            qryDataSet.qsJRN.Rows.Add(newRow);

            //qsLayoutView.AddNewRow();

            qsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGS.ColumnEdit = Program.MF.TAGselJRNrepositoryItemCheckedComboBoxEdit;
            colMBRS.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            colBKMS.ColumnEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
        }

        private void searchSimpleButton_Click(object sender, EventArgs e)
        {
            qsLayoutView.FocusedColumn = colQRY;

            int nor = 0;
            Program.MF.startSW();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = jrnTableAdapter.Fill(JRN, Program.USR, qsLayoutView.GetFocusedRowCellDisplayText(colQRY));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Jurnal", nor);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = (this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel);
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

        private void qsLayoutView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchSimpleButton.PerformClick();
                e.Handled = true;
            }
        }

        private void prepareQry()
        {
            DevExpress.XtraGrid.Views.Layout.LayoutView view = this.qsLayoutView;  //sender as DevExpress.XtraGrid.Views.Layout.LayoutView;

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colJRNID)))
                sb.AppendLine(string.Format("JRNid = {0}", view.GetFocusedRowCellDisplayText(colJRNID)));

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colREFTBL)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("RefTbl = '{0}' and RefID = {1}", view.GetFocusedRowCellDisplayText(colREFTBL), view.GetFocusedRowCellValue(colREFID)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTXT)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("(upper(Subject) containing upper('{0}') or  upper(Journal) containing upper('{0}'))", view.GetFocusedRowCellDisplayText(colTXT)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colSTU)))
            {
                string STU = view.GetFocusedRowCellValue(colSTU).ToString();
                if (!string.IsNullOrEmpty(STU))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("STU in (");
                    string[] sa = STU.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTKPTRH)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TkpTrh <= '{0:dd.MM.yyyy}'", view.GetFocusedRowCellValue(colTKPTRH)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colUPDTS1)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("UPD_TS >= '{0:dd.MM.yyyy}'", view.GetFocusedRowCellValue(colUPDTS1)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colUPDTS2)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("UPD_TS < '{0:dd.MM.yyyy}'", view.GetFocusedRowCellValue(colUPDTS2)));
            }

            /*
            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTAGS)))
            {
                string TAGS = view.GetFocusedRowCellValue(colTAGS).ToString();
                if (!string.IsNullOrEmpty(TAGS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = TAGS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" and ");
                        sb.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }*/

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTAGS)))
            {
                string str = view.GetFocusedRowCellValue(colTAGS).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colMBRS)))
            {
                string str = view.GetFocusedRowCellValue(colMBRS).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("MBRS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colBKMS)))
            {
                string str = view.GetFocusedRowCellValue(colBKMS).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("BKMS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if ((bool)view.GetFocusedRowCellValue(colPRVT) == true)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("PRVT = '{0}'", "T"));
            }

            view.SetFocusedRowCellValue(colQRY, sb.ToString());
        }

        private void qsLayoutView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            qsLayoutView.SetRowCellValue(e.RowHandle, colBKMD, false);
            qsLayoutView.SetRowCellValue(e.RowHandle, colPRVT, false);
        }

        private void qsLayoutView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                e.Value = DBNull.Value;
        }

        private void qsLayoutView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (qsLayoutView.RowCount > 0)
                prepareQry();
        }

        private void qsLayoutView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = qsLayoutView;

            if (e.Column == colBKMD)
            {
                StringBuilder bkms = new StringBuilder();
                bkms.Append(view.GetFocusedRowCellValue(colBKMS));

                if ((bool)e.Value == true)
                {
                    if (!bkms.ToString().Contains(Program.USRtag))
                    {
                        if (bkms.Length > 0)
                            bkms.Append(", ");
                        bkms.Append(Program.USRtag);
                    }
                }
                else
                {
                    bkms.Replace(", " + Program.USRtag, "");
                    bkms.Replace(Program.USRtag, "");
                }
                view.SetFocusedRowCellValue(colBKMS, bkms.ToString());
            }
        }

    }
}
