using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.SmallTalk
{
    public partial class strUC : DevExpress.XtraEditors.XtraUserControl
    {
        public strUC()
        {
            InitializeComponent();

            strGridControl.DataSource = this.smallTalkDataSet.STR;
            Program.MF.GridControlSettings(strGridControl);
        }

        private void Save()
        {
            this.Validate();
            this.strBindingSource.EndEdit();
            this.strTableAdapter.Update(this.smallTalkDataSet.STR);
        }

        private void strGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            strGridView.SetRowCellValue(e.RowHandle, colSTRID, smallTalkQueriesTableAdapter.GET_PK("STR"));
        }

        private void STRUserControl_Load(object sender, EventArgs e)
        {
            this.strTableAdapter.Fill(this.smallTalkDataSet.STR);

            strGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colUSRS.ColumnEdit = Program.MF.ustListRepositoryItemCheckedComboBoxEdit;
        }

        private void strGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            Save();
        }

        private void strGridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && e.Control)
            {
                var view = (DevExpress.XtraGrid.Views.Grid.GridView)(sender as DevExpress.XtraGrid.GridControl).FocusedView;
                view.AddNewRow();
            }
        }
    }
}
