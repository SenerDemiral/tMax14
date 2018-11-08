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
    public partial class qsvJrnXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Jurnal.JurnalDataSet.JRNDataTable JRN;
        public string RefTbl = "";
        public int RefID;
        int focusedRecord = 0;

        public qsvJrnXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            rowSTU.Properties.RowEdit = Program.MF.JrnStuRepositoryItemCheckedComboBoxEdit;
            rowTAGS.Properties.RowEdit = Program.MF.TAGselJRNrepositoryItemCheckedComboBoxEdit;
            rowMBRS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;

            rowInsUsr.Properties.RowEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            rowUpdUsr.Properties.RowEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
        }

        private void qsvJrnXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvJRN", 0, qryDataSet.qsJRN);
            if (qryDataSet.qsJRN.Rows.Count == 0)
                qsvGridControl.AddNewRecord();
        }

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                qsvGridControl.DeleteRecord(qsvGridControl.FocusedRecord);
                Program.MF.QSsave("qsvJRN", 0, qryDataSet.qsJRN);

                if (qryDataSet.qsJRN.Rows.Count == 0)
                    qsvGridControl.AddNewRecord();

                e.Handled = true;
            }
        }

        private void qsvGridControl_InitNewRecord(object sender, DevExpress.XtraVerticalGrid.Events.RecordIndexEventArgs e)
        {
            qsvGridControl.SetCellValue(rowPRVT, qsvGridControl.FocusedRecord, false);
            qsvGridControl.SetCellValue(rowBKMD, qsvGridControl.FocusedRecord, false);
        }

        private void qsvGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prepareQry();
                Search();
                e.Handled = true;
            }
        }

        private void Search()
        {
            int nor = 0;
            Program.MF.startSW();
            focusedRecord = qsvGridControl.FocusedRecord;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = jrnTableAdapter.Fill(JRN, Program.USR, qryMemoEdit.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Jurnal", nor);

                Program.MF.QSsave("qsvJRN", 0, qryDataSet.qsJRN);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel;
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            qsvGridControl.CloseEditor();
            Search();
        }

        private void qsvGridControl_VisibleChanged(object sender, EventArgs e)
        {
            qsvGridControl.FocusedRecord = focusedRecord;
        }

        private void qsvGridControl_HiddenEditor(object sender, EventArgs e)
        {
            prepareQry();
        }

        private void prepareQry()
        {
            var view = qsvGridControl;
            view.CloseEditor();
            //if (view.FocusedRecord <= 0)
             //   return;

            StringBuilder sb = new StringBuilder();
            /*
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowJRNID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("JrnID = {0}", view.GetCellValue(rowJRNID, view.FocusedRecord)));
            }
            */
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowJRNID, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowJRNID, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("JrnID in (");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("{0}", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }
            
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowREFTBL, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("RefTbl = '{0}' and RefID = {1}", view.GetCellValue(rowREFTBL, view.FocusedRecord), view.GetCellValue(rowREFID, view.FocusedRecord)));
            }
            else if (RefTbl != "")
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("RefTbl = '{0}' and RefID = {1}", RefTbl, RefID));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTXT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("(upper(Subject) containing upper('{0}') or  upper(Journal) containing upper('{0}'))", view.GetCellValue(rowTXT, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSTU, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowSTU, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("STU in (");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTKPTRH, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TkpTrh <= '{0:dd.MM.yyyy}'", view.GetCellValue(rowTKPTRH, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowUPDTS1, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Upd_TS >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowUPDTS1, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowUPDTS2, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Upd_TS < '{0:dd.MM.yyyy}'", view.GetCellValue(rowUPDTS2, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTAGS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTAGS, view.FocusedRecord).ToString();
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
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowMBRS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowMBRS, view.FocusedRecord).ToString();
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowBKMS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowBKMS, view.FocusedRecord).ToString();
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

            if (view.GetCellValue(rowPRVT, view.FocusedRecord) != null && (bool)view.GetCellValue(rowPRVT, view.FocusedRecord) == true)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("PRVT = '{0}'", "T"));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowInsUsr, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowInsUsr, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("INS_Usr in (");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowUpdUsr, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowUpdUsr, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("UPD_Usr in (");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }


            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());
        }

        private void qsvGridControl_CellValueChanging(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            var view = qsvGridControl;

            if (e.Row.Name == "rowBKMD")
            {
                StringBuilder bkms = new StringBuilder();
                bkms.Append(view.GetCellValue(rowBKMS, view.FocusedRecord));

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
                    bkms = bkms.Replace(", " + Program.USRtag, "");
                    bkms = bkms.Replace(Program.USRtag, "");
                }
                view.SetCellValue(rowBKMS, view.FocusedRecord, bkms.ToString());
            }
        }

    }
}
