using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class obsdXF : DevExpress.XtraEditors.XtraForm
    {
        public string Editable = "F";
        public int obsID = 0;
        public string PrtNo = "";
        public string SiteNo = "";
        public int DstLabID = 0;


        public obsdXF()
        {
            InitializeComponent();

            obsdGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colDSTLABID.ColumnEdit = Program.MF.FRTrepositoryItemLookUpEdit;
        }

        private void oBSDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void Save()
        {
            this.Validate();
            this.oBSDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.opsDataSet);
        }

        private void obsdXF_Load(object sender, EventArgs e)
        {
            this.oBSDTableAdapter.Fill(this.opsDataSet.OBSD, PrtNo, SiteNo, DstLabID);
        }

        private void obsdGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            
            int PK = (int)Program.MF.mainQueriesTableAdapter.GET_PK("OPS");
            view.SetFocusedRowCellValue(colOBSDID, PK);
            view.SetFocusedRowCellValue(colPRTNO, PrtNo);
            view.SetFocusedRowCellValue(colSITENO, SiteNo);
            view.SetFocusedRowCellValue(colDSTLABID, DstLabID);
        }

        private void createHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (obsdGridView.GetFocusedRowCellValue(colSTKNO) == DBNull.Value)
                return;

            Save();

            DialogResult dr = System.Windows.Forms.DialogResult.Yes; 
            
            if (obsdGridView.GetFocusedRowCellValue(colOPHID) != DBNull.Value)
            {
                dr = XtraMessageBox.Show("Bu stok kullanılmış! Yine de bu Stok kullanılarak yeni bir House yaratılsın mı?", "Create House", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != System.Windows.Forms.DialogResult.Yes)
                    return;
            }

            int obsdID = (int)obsdGridView.GetFocusedRowCellValue(colOBSDID);
            object ophID = opsQueriesTableAdapter.OBSD2OPH(obsID, obsdID);
            obsdGridView.SetFocusedRowCellValue(colOPHID, ophID);
        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (obsdGridView.GetFocusedRowCellValue(colOPHID) == DBNull.Value)
                return;

            Ops.opHouseXUC frm = new Ops.opHouseXUC();
            frm.qsString = string.Format("OPHID = {0}", obsdGridView.GetFocusedRowCellValue("OPHID"));
            //frm.Show();

            var panel = dockManager.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Float);
            
            panel.FloatLocation = new Point(100, 100);
            panel.FloatSize = new Size(600, 300);
            panel.Name = "House";
            panel.Text = "Houses of BioStok" + obsdGridView.GetFocusedRowCellDisplayText("OPHID");

            frm.Dock = DockStyle.Fill;
            panel.Controls.Add(frm);

        }

        private void obsdGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (obsdGridView.FocusedColumn == colSTKNO && obsdGridView.GetFocusedRowCellValue(colOPHID) != DBNull.Value)
                e.Cancel = true;
        }

        private void stokGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obsdEkleXF frm = new obsdEkleXF();
            frm.obsID = obsID;
            frm.ShowDialog();
            this.oBSDTableAdapter.Fill(this.opsDataSet.OBSD, PrtNo, SiteNo, DstLabID);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (obsdGridView.GetFocusedRowCellValue(colOPHID) != DBNull.Value)
            if (Editable == "T")
            {
                obsdGridView.DeleteRow(obsdGridView.FocusedRowHandle);
                Save();
            }
        }
    }
}