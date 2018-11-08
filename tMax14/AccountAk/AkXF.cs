using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace tMax14.AccountAk
{
    public partial class AkXF : DevExpress.XtraEditors.XtraForm
    {
        public AkXF()
        {
            InitializeComponent();
        }

        private void aKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            this.Validate();
            this.aKBindingSource.EndEdit();
            this.aKTableAdapter.Update(this.accountAkDataSet.AK);
        }

        private void AkXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountAkDataSet.AK' table. You can move, or remove it, as needed.
            this.aKTableAdapter.Fill(this.accountAkDataSet.AK);

        }

        private void akGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            int akID = (int)accountAkQueriesTableAdapter.GET_PK("AK");
            view.SetFocusedRowCellValue("AKID", akID);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int akID = (int)akGridView.GetFocusedRowCellValue("AKID");
            accountAkQueriesTableAdapter.AK_CREATE(akID);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int akID = (int)akGridView.GetFocusedRowCellValue("AKID");
            AkhXF frm = new AkhXF();
            frm.akID = akID;
            frm.akAD = akGridView.GetFocusedRowCellDisplayText("AD");
            frm.Show();
        }

        private void dagitimYuzdeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkdyXF frm = new AkdyXF();
            frm.Show();
        }

        private void opsSayilariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int akID = (int)akGridView.GetFocusedRowCellValue("AKID");
            AkoXF frm = new AkoXF();
            frm.akID = akID;
            frm.akAD = akGridView.GetFocusedRowCellDisplayText("AD");
            frm.Show();
        }

        private void merkezMasraflariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int akID = (int)akGridView.GetFocusedRowCellValue("AKID");
            AktXF frm = new AktXF();
            frm.akID = akID;
            frm.akAD = akGridView.GetFocusedRowCellDisplayText("AD");
            frm.Show();
        }

        private void dagitimCarpanlariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();

            int akID = (int)akGridView.GetFocusedRowCellValue("AKID");
            AkdXF frm = new AkdXF();
            frm.akID = akID;
            frm.akAD = akGridView.GetFocusedRowCellDisplayText("AD");
            frm.Show();
        }
    }
}