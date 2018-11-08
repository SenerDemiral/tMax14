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
    public partial class qsvRphXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Genel.GenelDataSet.RPHDataTable RPH;
        int focusedRecord = 0;
        public string searchQry;

        public qsvRphXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowRptKod.Properties.RowEdit = Program.MF.RptKodRepositoryItemCheckedComboBoxEdit;
            rowFirma.Properties.RowEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            rowRefTO.Properties.RowEdit = Program.MF.RphRefTOrepositoryItemImageComboBox;

        }

        private void qsvRphXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvRPH", 0, qryDataSet.qsRPH);
            if (qryDataSet.qsRPH.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsRPH.NewqsRPHRow();
                //newRow.eFatura = false;
                qryDataSet.qsRPH.Rows.Add(newRow);
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
                nor = rphTableAdapter.Fill(RPH, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("RPH", nor);

                Program.MF.QSsave("qsvRPH", 0, qryDataSet.qsRPH);

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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRptKod, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowRptKod, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("RPTKOD in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFirma, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowFirma, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("FRTid in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRefID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("REFID in ({0})", view.GetCellValue(rowRefID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRefTO, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("REFTO = '{0}'", view.GetCellValue(rowRefTO, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowExdGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("EXD >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowExdGE, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowExdLT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("EXD < '{0:dd.MM.yyyy}'", view.GetCellValue(rowExdLT, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRspDGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("RSPD >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowRspDGE, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowRspDLT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("RSPD < '{0:dd.MM.yyyy}'", view.GetCellValue(rowRspDLT, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowInfo, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("INFO containing '{0}'", view.GetCellValue(rowInfo, view.FocusedRecord)));
            }

            var rspW = view.GetCellValue(rowRspW, view.FocusedRecord);
            if (rspW != null && rspW != DBNull.Value)
            {
                if ((bool)view.GetCellValue(rowRspW, view.FocusedRecord) == true)
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.AppendLine(string.Format("RSPW = '{0}'", "T"));
                }
            }


            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }
    }
}
