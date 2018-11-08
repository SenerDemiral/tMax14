using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Genel
{
    public partial class kkesXF : DevExpress.XtraEditors.XtraForm
    {
        public kkesXF()
        {
            InitializeComponent();

            kkesGridControl.ExternalRepository = Program.MF.mainPersistentRepository;

        }

        private void kKESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kkesBindingSource.EndEdit();
            this.kkesTableAdapter.Update(this.mainDataSet.KKES);

        }

        private void kkesXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.KKES' table. You can move, or remove it, as needed.
            this.kkesTableAdapter.Fill(this.mainDataSet.KKES);

        }

        private void kkesGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            object pk = mainQueriesTableAdapter.GET_PK("KK");
            kkesGridView.SetRowCellValue(e.RowHandle, colKKESID, pk);

        }
    }
}