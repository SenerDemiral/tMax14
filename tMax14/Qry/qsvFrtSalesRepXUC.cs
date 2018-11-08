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
    public partial class qsvFrtSalesRepXUC : DevExpress.XtraEditors.XtraUserControl
    {
        public Firma.FirmaDataSet.FRT_SALESREPDataTable DT;
        int focusedRecord = 0;
        
        public qsvFrtSalesRepXUC()
        {
            InitializeComponent();

            qsvGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

            rowFirmaFaliyet.Properties.RowEdit = Program.MF.frtFlyRepositoryItemCheckedComboBoxEdit;
            rowJurnalTAG.Properties.RowEdit = Program.MF.TAGselJRNrepositoryItemCheckedComboBoxEdit;

        }

        private void qsvFrtSalesRepXUC_Load(object sender, EventArgs e)
        {
            Program.MF.QSrestore("qsvFrtSalesRep", 0, qryDataSet.qsFrtSalesRep);
            if (qryDataSet.qsFrtSalesRep.Rows.Count == 0)
            {
                var newRow = qryDataSet.qsFrtSalesRep.NewqsFrtSalesRepRow();
                //newRow.Own = "F";
                qryDataSet.qsFrtSalesRep.Rows.Add(newRow);
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
                nor = frtSalesRepTableAdapter.Fill(DT, Program.USR, qryFrtMemoEdit.Text, qryJrnMemoEdit.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Firma SalesRep", nor);

                Program.MF.QSsave("qsvFrtSalesRep", 0, qryDataSet.qsFrtSalesRep);

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

            StringBuilder sbFrt = new StringBuilder();
            StringBuilder sbJrn = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowFirmaFaliyet, view.FocusedRecord)))
            {
                string str = view.GetCellValue(rowFirmaFaliyet, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sbFrt.Length > 0)
                        sbFrt.AppendLine(" and ");
                    sbFrt.Append("( ");
                    string[] sa = str.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sbFrt.Append(" or ");
                        sbFrt.Append(string.Format("FLY containing '{0}'", sa[i].Trim()));
                    }
                    sbFrt.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowJurnalTAG, view.FocusedRecord)))
            {
                string TAGS = view.GetCellValue(rowJurnalTAG, view.FocusedRecord).ToString();
                if (!string.IsNullOrEmpty(TAGS))
                {
                    if (sbJrn.Length > 0)
                        sbJrn.AppendLine(" and ");
                    sbJrn.Append("( ");
                    string[] sa = TAGS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sbJrn.Append(" or ");
                        sbJrn.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sbJrn.AppendLine(" )");
                }
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowJurnalUpdGE, view.FocusedRecord)))
            {
                if (sbJrn.Length > 0)
                    sbJrn.AppendLine(" and ");
                DateTime dt = (DateTime)view.GetCellValue(rowJurnalUpdGE, view.FocusedRecord);
                sbJrn.AppendLine(string.Format("UPD_TS >= '{0}'", dt.ToString("dd.MM.yyyy")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetCellDisplayText(rowJurnalUpdLT, view.FocusedRecord)))
            {
                if (sbJrn.Length > 0)
                    sbJrn.AppendLine(" and ");
                DateTime dt = (DateTime)view.GetCellValue(rowJurnalUpdLT, view.FocusedRecord);
                sbJrn.AppendLine(string.Format("UPD_TS < '{0}'", dt.ToString("dd.MM.yyyy")));
            }

            view.SetCellValue(rowfQry, view.FocusedRecord, sbFrt.ToString());
            view.SetCellValue(rowjQry, view.FocusedRecord, sbJrn.ToString());

        }
    }
}
