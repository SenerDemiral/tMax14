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
    public partial class qsLocXF : DevExpress.XtraEditors.XtraUserControl
    {
        public Genel.GenelDataSet.LOCDataTable LOC;

        public qsLocXF()
        {
            InitializeComponent();

            this.qsLayoutView.FieldCaptionFormat = "{0}";

            this.qsLayoutView.Appearance.FieldCaption.Options.UseTextOptions = true;
            this.qsLayoutView.Appearance.FieldCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
        }

        private void qsLocXF_Load(object sender, EventArgs e)
        {
            var newRow = qryDataSet.qsLOC.NewqsLOCRow();
            newRow.Drm = false;
            qryDataSet.qsLOC.Rows.Add(newRow);
        }

        private void searchSimpleButton_Click(object sender, EventArgs e)
        {
            qsLayoutView.FocusedColumn = colQRY;    // Change Column to prepareQry

            int nor = 0;
            Program.MF.startSW();
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                nor = locTableAdapter.FillByQRY(LOC, qsLayoutView.GetFocusedRowCellDisplayText(colQRY));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Program.MF.stopSW("Loacation", nor);

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

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colLOCid)))
                sb.AppendLine(string.Format("LOCid like upper('{0}%')", view.GetFocusedRowCellDisplayText(colLOCid)));

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colAd)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(AD) containing upper('{0}' collate WIN1254)", view.GetFocusedRowCellDisplayText(colAd).Replace("'", "''")));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colCntry)))
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("upper(CNTRY) starting upper('{0}' collate WIN1254)", view.GetFocusedRowCellDisplayText(colCntry).Replace("'", "''")));
            }

            if ((bool)view.GetFocusedRowCellValue(colDrm) == true)
            {
                if (sb.Length > 0)
                    sb.AppendLine(" and ");
                sb.AppendLine(string.Format("DRM = 'A'"));
            }

            if (!string.IsNullOrWhiteSpace(view.GetFocusedRowCellDisplayText(colFunc)))
            {
                string FUNCS = view.GetFocusedRowCellValue(colFunc).ToString();
                if (!string.IsNullOrEmpty(FUNCS))
                {
                    if (sb.Length > 0)
                        sb.AppendLine(" and ");
                    sb.Append("( ");
                    string[] sa = FUNCS.Split(new char[] { ',' });
                    for (int i = 0; i < sa.Length; i++)
                    {
                        if (i > 0)
                            sb.Append(" or ");
                        sb.Append(string.Format("FUNC containing '{0}'", sa[i].Trim()));
                    }
                    sb.AppendLine(" )");
                }
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
