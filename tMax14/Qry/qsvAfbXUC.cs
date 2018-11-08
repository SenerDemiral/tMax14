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
    public partial class qsvAfbXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Account.AccountDataSet.AFBDataTable AFB;
        int focusedRecord = 0;

        public qsvAfbXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            rowAFBID.Properties.RowEdit = Program.MF.intSrepositoryItemTextEdit;
            rowFirma.Properties.RowEdit = Program.MF.FRTrepositoryItemCheckedComboBoxEdit;
            rowFirmaGrp.Properties.RowEdit = Program.MF.frtGrpRepositoryItemCheckedComboBoxEdit;
            rowBKMS.Properties.RowEdit = Program.MF.MBRselRepositoryItemCheckedComboBoxEdit;
            rowTAGS.Properties.RowEdit = Program.MF.TAGselAFBrepositoryItemCheckedComboBoxEdit;
            rowDvz.Properties.RowEdit = Program.MF.DVTrepositoryItemCheckedComboBoxEdit;
            rowTur.Properties.RowEdit = Program.MF.afbTURrepositoryItemCheckedComboBoxEdit;
            rowTur2.Properties.RowEdit = Program.MF.afbTUR2repositoryItemImageComboBox;
            rowTur3.Properties.RowEdit = Program.MF.afbTUR3repositoryItemImageComboBox;
            rowDrm.Properties.RowEdit = Program.MF.afbDRMrepositoryItemCheckedComboBoxEdit;
            rowOnyYtk.Properties.RowEdit = Program.MF.YTKrepositoryItemCheckedComboBoxEdit;
            roweFatura.Properties.RowEdit = Program.MF.BOOLrepositoryItemCheckEdit;
            roweMld.Properties.RowEdit = Program.MF.AFBeMldRepositoryItemCheckedComboBoxEdit;
        }

        private void qsvAfbXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvAFB", 0, qryDataSet.qsAFB);
            if (qryDataSet.qsAFB.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsAFB.NewqsAFBRow();
                //newRow.eFatura = false;
                qryDataSet.qsAFB.Rows.Add(newRow);
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
                nor = afbTableAdapter.Fill(AFB, qryMemoEdit.Text, Program.USR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Fatura", nor);

                Program.MF.QSsave("qsvAFB", 0, qryDataSet.qsAFB);

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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowAFBID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AFBID in ({0})", view.GetCellValue(rowAFBID, view.FocusedRecord)));
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFirmaGrp, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowFirmaGrp, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("FRTID in (select FRTID from FRT where ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("GRP containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(")");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOnyYtk, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowOnyYtk, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("OnyYtk in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFtrTrh1, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("FtrTrh >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowFtrTrh1, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFtrTrh2, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("FtrTrh < '{0:dd.MM.yyyy}'", view.GetCellValue(rowFtrTrh2, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOdmVde1, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OdmVde >= '{0:dd.MM.yyyy}'", view.GetCellValue(rowOdmVde1, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOdmVde2, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("OdmVde < '{0:dd.MM.yyyy}'", view.GetCellValue(rowOdmVde2, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFtrNo, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("FtrNo containing '{0}'", view.GetCellValue(rowFtrNo, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTur, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowTur, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("Tur in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTur2, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Tur2 = '{0}'", view.GetCellValue(rowTur2, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTur3, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("Tur3 = '{0}'", view.GetCellValue(rowTur3, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDrm, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowDrm, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("Drm in (");
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

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowDvz, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowDvz, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("bDvz in (");
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
            var eFtr = view.GetCellValue(roweFatura, view.FocusedRecord);
            if (eFtr != null && eFtr != DBNull.Value)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                if ((bool)view.GetCellValue(roweFatura, view.FocusedRecord) == true)
                    sb.AppendLine(string.Format("eFtr = '{0}'", "T"));
                else
                    sb.AppendLine(string.Format("eFtr = '{0}'", "F"));
            }

            var arsiv = view.GetCellValue(rowArsiv, view.FocusedRecord);
            if (arsiv != null && arsiv != DBNull.Value)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                if ((bool)view.GetCellValue(rowArsiv, view.FocusedRecord) == true)
                    sb.AppendLine(string.Format("Arsiv = '{0}'", "T"));
                else
                    sb.AppendLine(string.Format("(Arsiv = '{0}' or Arsiv is null)", "F"));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTutGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("bTutBrt >= {0}", view.GetCellValue(rowTutGE, view.FocusedRecord)));
            }
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowTutLE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("bTutBrt <= {0}", view.GetCellValue(rowTutLE, view.FocusedRecord)));
            }
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowKlnGE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("bKln >= {0}", view.GetCellValue(rowKlnGE, view.FocusedRecord)));
            }
            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowKlnLE, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("bKln <= {0}", view.GetCellValue(rowKlnLE, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(roweMld, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("coalesce(eMld,'F') in ({0})", view.GetCellValue(roweMld, view.FocusedRecord)));
            }
            

            //////////////////////////////////////////////////////////////

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOPID, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AFD.OPid = {0}", view.GetCellValue(rowOPID, view.FocusedRecord)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowOPHM, view.FocusedRecord)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("AFD.OPHM = '{0}'", view.GetCellValue(rowOPHM, view.FocusedRecord)));
            }

            view.SetCellValue(rowbQRY, view.FocusedRecord, sb.ToString());

        }

        private void qsvGridControl_InitNewRecord(object sender, DevExpress.XtraVerticalGrid.Events.RecordIndexEventArgs e)
        {
            var view = qsvGridControl;
            view.SetCellValue(roweFatura, view.FocusedRecord, null);
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
                    bkms.Replace(Program.USRtag, "");
                }
                view.SetCellValue(rowBKMS, view.FocusedRecord, bkms.ToString());
            }
        }


    }
}
