using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using tMax14.Doc;

namespace tMax14.Qry
{
    public partial class qsDocXF : DevExpress.XtraEditors.XtraUserControl
    {
        public Doc.DocDataSet.DOCDataTable DOC;
        
        public qsDocXF()
        {
            InitializeComponent();

            this.qsLayoutView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.qsLayoutView.OptionsCustomization.AllowFilter = false;
            this.qsLayoutView.OptionsCustomization.AllowSort = false;
            this.qsLayoutView.OptionsFilter.AllowFilterEditor = false;
            this.qsLayoutView.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AlignGlobal;
            this.qsLayoutView.OptionsItemText.TextToControlDistance = 10;
            this.qsLayoutView.OptionsSingleRecordMode.StretchCardToViewHeight = true;
            this.qsLayoutView.OptionsSingleRecordMode.StretchCardToViewWidth = true;
            this.qsLayoutView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.qsLayoutView.OptionsView.ShowCardExpandButton = false;
            this.qsLayoutView.OptionsView.ShowHeaderPanel = false;

            this.colQRY.AppearanceCell.Options.UseTextOptions = true;
            this.colQRY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colQRY.AppearanceHeader.Options.UseTextOptions = true;
            this.colQRY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            this.layoutViewField_colQRY.TextLocation = DevExpress.Utils.Locations.Top;

            qsGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colTAGS.ColumnEdit = Program.MF.TAGselDOCrepositoryItemCheckedComboBoxEdit;
            colDET.ColumnEdit = Program.MF.DOCdetRepositoryItemLookUpEdit;
        }

        private void qsDocXF_Load(object sender, EventArgs e)
        {
            var newRow = qryDataSet.qsDOC.NewqsDOCRow();
            newRow.BKMD = false;
            qryDataSet.qsDOC.Rows.Add(newRow);
        }
        
        private void searchSimpleButton_Click(object sender, EventArgs e)
        {
            qsLayoutView.FocusedColumn = colQRY;

            int nor = 0;
            Program.MF.startSW();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = docTableAdapter.Fill(DOC, qsLayoutView.GetFocusedRowCellDisplayText(colQRY));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Attachment", nor);

                if (this.Parent.Parent is DevExpress.XtraBars.Docking.DockPanel)
                    (this.Parent.Parent as DevExpress.XtraBars.Docking.DockPanel).HideImmediately();
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

        private void qsLayoutView_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                e.Value = DBNull.Value;
        }

        private void prepareQry()
        {
            DevExpress.XtraGrid.Views.Layout.LayoutView view = qsLayoutView;

            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colAd)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(Ad) containing upper('{0}')", view.GetFocusedRowCellDisplayText(colAd).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTyp)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(Typ) containing upper('{0}')", view.GetFocusedRowCellDisplayText(colTyp).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTrhGE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("EXD >= '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colTrhGE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colTrhLT)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("EXD < '{0:dd.MM.yyyy HH:mm}'", view.GetFocusedRowCellValue(colTrhLT)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colSizeGE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("BlbLen >= {0}", view.GetFocusedRowCellValue(colSizeGE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colSizeLE)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("BlbLen <= {0}", view.GetFocusedRowCellValue(colSizeLE)));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colDET)))
            {
                string str = view.GetFocusedRowCellValue(colDET).ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("DET in (");
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
                            sb.Append(" or ");
                        sb.Append(string.Format("TAGS containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
            }

            if ((bool)view.GetFocusedRowCellValue(colBKMD) == true)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("BKMS containing '{0}'", Program.USRtag));
            }

            view.SetFocusedRowCellValue(colQRY, sb.ToString());

        }

        private void qsLayoutView_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            if (qsLayoutView.RowCount > 0)
                prepareQry();
        }

    }
}
