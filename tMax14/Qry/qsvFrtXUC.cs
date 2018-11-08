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
    public partial class qsvFrtXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Firma.FirmaDataSet.FRT_REC_SELDataTable FRT;
        int focusedRecord = 0;
        public string searchQry;

        public qsvFrtXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowTAGS.Properties.RowEdit = Program.MF.TAGselFRTrepositoryItemCheckedComboBoxEdit;
            rowTUR.Properties.RowEdit = Program.MF.frtTurRepositoryItemCheckedComboBoxEdit;
            rowCntry.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
            rowFLY.Properties.RowEdit = Program.MF.frtFlyRepositoryItemCheckedComboBoxEdit;
            rowGRP.Properties.RowEdit = Program.MF.frtGrpRepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowQRY.Properties.RowEdit = Program.MF.MEMOrepositoryItemMemoEdit;
            rowSREPID.Properties.RowEdit = Program.MF.ustListRepositoryItemCheckedComboBoxEdit;
            rowDRM.Properties.RowEdit = Program.MF.frtDrmRepositoryItemLookUpEdit;
            rowSrvUlk.Properties.RowEdit = Program.MF.CNTRYrepositoryItemCheckedComboBoxEdit;
        }

        private void qsvFrtXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvFRT", 0, qryDataSet.qsFRT);
            if (qryDataSet.qsFRT.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsFRT.NewqsFRTRow();
                newRow.BKMD = false;
                qryDataSet.qsFRT.Rows.Add(newRow);
            }
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
            searchQry = qryMemoEdit.Text;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = frtTableAdapter.Fill(FRT, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Firma", nor);

                Program.MF.QSsave("qsvFRT", 0, qryDataSet.qsFRT);

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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFRTID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("FRTID in ({0})", view.GetCellValue(rowFRTID, view.FocusedRecord)));
            }

            //if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFRTID, view.FocusedRecord)))
            //    sb.AppendLine(string.Format("FRTid = {0}", view.GetCellDisplayText(rowFRTID, view.FocusedRecord)));

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowADN, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(ADN) containing upper('{0}')", view.GetCellDisplayText(rowADN, view.FocusedRecord).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAD, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(AD) containing upper('{0}')", view.GetCellDisplayText(rowAD, view.FocusedRecord).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOfcNo, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OfcNo starting '{0}'", view.GetCellDisplayText(rowOfcNo, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowVdeGun, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");

                string s = view.GetCellDisplayText(rowVdeGun, view.FocusedRecord).ToLower();
                if (s == "null" || s == "not null")
                    sb.AppendLine(string.Format("VdeGun is {0}", s));
                else
                    sb.AppendLine(string.Format("VdeGun = '{0}'", view.GetCellDisplayText(rowVdeGun, view.FocusedRecord)));
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTUR, view.FocusedRecord)))
            {
                string TUR = view.GetCellValue(rowTUR, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(TUR))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("TUR in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFLY, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowFLY, view.FocusedRecord).ToString();
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
                        sb.Append(string.Format("FLY containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowGRP, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowGRP, view.FocusedRecord).ToString();
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
                        sb.Append(string.Format("GRP containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDRM, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowDRM, view.FocusedRecord).ToString();
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
                        sb.Append(string.Format("DRM containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowCntry, view.FocusedRecord)))
            {
                string Cntry = view.GetCellValue(rowCntry, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(Cntry))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("(");
                    string[] sa = Cntry.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("LOCID starting '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSrvUlk, view.FocusedRecord)))
            {
                string VAL = view.GetCellValue(rowSrvUlk, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(VAL))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = VAL.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("SRVULK containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }


            /*
            if ((bool)view.GetFocusedRowCellValue(colBKMD) == true)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("BKMS containing '{0}'", Program.USRtag));
            }
            */

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowSREPID, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowSREPID, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("EXISTS (select * from FRS where FRTid = FRT.FRTid and SRepID in (");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(",");
                        sb.Append(string.Format("{0}", sa[i].Trim()));
                    }
                    sb.AppendLine("))");
                }
            }
            
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAQRY, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(view.GetCellDisplayText(rowAQRY, view.FocusedRecord));
            }

            view.SetCellValue(rowQRY, view.FocusedRecord, sb.ToString());

        }

        private void dataNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                qsvGridControl.DeleteRecord(qsvGridControl.FocusedRecord);
                Program.MF.QSsave("qsvFRT", 0, qryDataSet.qsFRT);

                if (qryDataSet.qsFRT.Rows.Count == 0)
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
