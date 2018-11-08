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
    public partial class qsvTafXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Teklif.TeklifDataSet.TAFDataTable TAF;
        int focusedRecord = 0;

        public qsvTafXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            rowCarrier.Properties.RowEdit = Program.MF.FRTcrrRepositoryItemCheckedComboBoxEdit;
            rowCharge.Properties.RowEdit = Program.MF.AHTopsRepositoryItemCheckedComboBoxEdit;

            rowOrgCntry.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowDstCntry.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowROT.Properties.RowEdit = Program.MF.ROTrepositoryItemCheckedComboBoxEdit;
            rowMOT.Properties.RowEdit = Program.MF.MOTrepositoryItemCheckedComboBoxEdit;
            rowOwn.Properties.RowEdit = Program.MF.TFNrepositoryItemCheckEdit;
            rowTOP.Properties.RowEdit = Program.MF.TOPrepositoryItemCheckedComboBoxEdit;

            rowTAGS.Properties.RowEdit = Program.MF.TAGselTNDrepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowQRY.Properties.RowEdit = Program.MF.MEMOrepositoryItemMemoEdit;
        }

        private void qsvFrtXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvTAF", 0, qryDataSet.qsTAF);
            if (qryDataSet.qsTAF.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsTAF.NewqsTAFRow();
                newRow.Own = "F";
                qryDataSet.qsTAF.Rows.Add(newRow);
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
                nor = tafTableAdapter.Fill(TAF, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("TeklifAlışFiyat", nor);

                Program.MF.QSsave("qsvTAF", 0, qryDataSet.qsTAF);

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

        private void qsvGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prepareQry();
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
            view.CloseEditor();

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTAFID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TAFID in ({0})", view.GetCellValue(rowTAFID, view.FocusedRecord)));
            }

            
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowCarrier, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowCarrier, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("CRRid in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowCharge, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowCharge, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("AHTid in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowROT, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowROT, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("ROT in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowMOT, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowMOT, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("MOT in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTOP, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTOP, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("TOP in (");
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
                string TAGS = view.GetCellValue(rowTAGS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(TAGS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = TAGS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowBKMS, view.FocusedRecord)))
            {
                string BKMS = view.GetCellValue(rowBKMS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(BKMS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = BKMS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("BKMS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOrgCntry, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowOrgCntry, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("(");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("Org starting '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDstCntry, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowDstCntry, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("(");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("Dst starting '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (view.GetCellValue(rowOwn, view.FocusedRecord) != DBNull.Value)
            {
                //string TF = (bool)view.GetCellValue(rowOwn, view.FocusedRecord) ? "T" : "F";
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Own = '{0}'", view.GetCellValue(rowOwn, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAQRY, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(view.GetCellDisplayText(rowAQRY, view.FocusedRecord));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowGcrTrh, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                DateTime dt = (DateTime)view.GetCellValue(rowGcrTrh, view.FocusedRecord);
                sb.AppendLine(string.Format("GcrTrh >= '{0}'", dt.ToString("dd.MM.yyyy")));
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                qsvGridControl.DeleteRecord(qsvGridControl.FocusedRecord);
                Program.MF.QSsave("qsvTAF", 0, qryDataSet.qsTAF);

                if (qryDataSet.qsTAF.Rows.Count == 0)
                    qsvGridControl.AddNewRecord();

                e.Handled = true;
            }
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
