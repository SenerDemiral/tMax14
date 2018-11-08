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
    public partial class qsvTstXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Teklif.TeklifDataSet.TSTDataTable TST;
        public Teklif.TeklifDataSet.TSFDataTable TSF;

        public delegate void Save();
        public Save saveHandler;

        int focusedRecord = 0;
        
        public qsvTstXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            rowFirma.Properties.RowEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;

            rowFrtTur.Properties.RowEdit = Program.MF.frtTurRepositoryItemCheckedComboBoxEdit;
            rowFrtUlk.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowmOrgUlkS.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowmDstUlkS.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowROT.Properties.RowEdit = Program.MF.ROTrepositoryItemCheckedComboBoxEdit;
            rowMOT.Properties.RowEdit = Program.MF.MOTrepositoryItemCheckedComboBoxEdit;
            rowSTU.Properties.RowEdit = Program.MF.TklfStuRepositoryItemCheckedComboBoxEdit;
            rowTYP.Properties.RowEdit = Program.MF.TklfTypRepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowOnyUsr.Properties.RowEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;
            rowSlsUsr.Properties.RowEdit = Program.MF.USRrepositoryItemCheckedComboBoxEdit;

            rowAHTIDS.Properties.RowEdit = Program.MF.AHTopsRepositoryItemCheckedComboBoxEdit;

        }

        private void qsvTstXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvTST", 0, qryDataSet.qsTST);
            if (qryDataSet.qsTST.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsTST.NewqsTSTRow();
                //newRow.eFatura = false;
                qryDataSet.qsTST.Rows.Add(newRow);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
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

                saveHandler();

                nor = tstTableAdapter.Fill(TST, qryMemoEdit.Text, Program.USR);
                this.tsfTableAdapter.ClearBeforeFill = false;
                TSF.Clear();
                foreach (Teklif.TeklifDataSet.TSTRow row in TST.Rows)
                {
                    this.tsfTableAdapter.Fill(TSF, row.TSTID, 0);

                  //                      this.tsfTableAdapter.Fill(TSF, row.TSTID);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Talepler", nor);

                Program.MF.QSsave("qsvTST", 0, qryDataSet.qsTST);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                {
                    var dp = this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel;
                    if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.AutoHide)
                        dp.HideImmediately();
                }
            }
        }

        private void qsvGridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
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
            {
                Program.MF.QSsave("qsvTST", 0, qryDataSet.qsTST);
                //MessageBox.Show( view.FocusedRecord.ToString());
                //return;
            }
            view.CloseEditor();

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTSTID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TSTID in ({0})", view.GetCellValue(rowTSTID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFirma, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowFirma, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("FRTID in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFrtTur, view.FocusedRecord)))
            {
                string TUR = view.GetCellValue(rowFrtTur, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(TUR))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("FRTTUR in (");
                    string[] sa = TUR.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFrtUlk, view.FocusedRecord)))
            {
                string TUR = view.GetCellValue(rowFrtUlk, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(TUR))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("FRTULK in (");
                    string[] sa = TUR.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("'{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOnyUsr, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowOnyUsr, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("ONYUSR in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSlsUsr, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowSlsUsr, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("SLSUSR in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTYP, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTYP, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("TYP in (");
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

            //exists (select * from TSF where TSTID = TST.TSTID and AHTID in (153, 10))

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAHTIDS, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowAHTIDS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append(string.Format("exists (select * from TSF where TSTID = TST.TSTID and AHTID in ({0}))", str));

                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowmOrgUlkS, view.FocusedRecord)))
            {
                string mOrgUlkS = view.GetCellValue(rowmOrgUlkS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(mOrgUlkS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = mOrgUlkS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("mOrgUlkS containing '[{0}]'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowmDstUlkS, view.FocusedRecord)))
            {
                string mDstUlkS = view.GetCellValue(rowmDstUlkS, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(mDstUlkS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = mDstUlkS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("mDstUlkS containing '[{0}]'", sa[i].Trim()));
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTklfTrhGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TklTrh >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowTklfTrhGE, view.FocusedRecord)));
            }
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTklfTrhLT, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("TklTrh < '{0:dd.MM.yyyy}'", view.GetCellValue(rowTklfTrhLT, view.FocusedRecord)));
            }



            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                qsvGridControl.DeleteRecord(qsvGridControl.FocusedRecord);
                Program.MF.QSsave("qsvTST", 0, qryDataSet.qsTST);

                if (qryDataSet.qsTST.Rows.Count == 0)
                    qsvGridControl.AddNewRecord();

                e.Handled = true;
            }
        }

    }
}
