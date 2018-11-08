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
    public partial class qsvAvbXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Account.AccountDataSet.AVBDataTable AVB;
        int focusedRecord = 0;
        
        public qsvAvbXUC()
        {
            InitializeComponent();

            rowDrm.Properties.RowEdit = Program.MF.AVBdrmRepositoryItemCheckedComboBoxEdit;
            rowTur.Properties.RowEdit = Program.MF.AVBTrepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowTAGS.Properties.RowEdit = Program.MF.TAGselAVBrepositoryItemCheckedComboBoxEdit;

        }

        private void qsvAvbXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvAVB", 0, qryDataSet.qsAVB);
            if (qryDataSet.qsAVB.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsAVB.NewqsAVBRow();
                //newRow.eFatura = false;
                qryDataSet.qsAVB.Rows.Add(newRow);
            }
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(qryMemoEdit.Text))
                return;

            int nor = 0;
            Program.MF.startSW();
            focusedRecord = qsvGridControl.FocusedRecord;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = avbTableAdapter.Fill(AVB, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Fiş", nor);

                Program.MF.QSsave("qsvAVB", 0, qryDataSet.qsAVB);

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
            Search();
        }

        private void qsvGridControl_EditorKeyUp(object sender, KeyEventArgs e)
        {
            var aa = e.KeyCode;
            var bb = sender;
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.Handled = true;
            }
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

            if (view.FocusedRecord < 0)
                return;

            view.CloseEditor();

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAVBID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AVB.AVBID in ({0})", view.GetCellValue(rowAVBID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDrm, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowDrm, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("AVB.DRM in (");
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
            
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTur, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTur, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("AVB.TUR in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAciklama, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AVB.ACIKLAMA containing '{0}'", view.GetCellValue(rowAciklama, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTrh1, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AVB.TRH >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowTrh1, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTrh2, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AVB.TRH < '{0:dd.MM.yyyy}'", view.GetCellValue(rowTrh2, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowHspNoS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowHspNoS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("AVD.HSPNO in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTAGS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTAGS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" or ");
                    sb.Append("( ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("AVB.TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
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
                    sb.AppendLine(")");
                }
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());
        }

        private void qsvGridControl_InitNewRecord(object sender, DevExpress.XtraVerticalGrid.Events.RecordIndexEventArgs e)
        {
            var view = qsvGridControl;
            view.SetCellValue(rowDrm, view.FocusedRecord, "A");
            //view.SetCellValue(rowTrh1, view.FocusedRecord, DateTime.Today.AddDays(-30));
        }

        private void qsvGridControl_CellValueChanged(object sender, DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs e)
        {
            var view = qsvGridControl;
            if (e.Row == rowBKMD)
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
                    bkms.Replace(", " + Program.USRtag, "");
                    bkms.Replace(Program.USRtag + ", ", "");
                    bkms.Replace(Program.USRtag, "");
                }
                view.SetCellValue(rowBKMS, view.FocusedRecord, bkms.ToString());
            }
        }


    }
}
