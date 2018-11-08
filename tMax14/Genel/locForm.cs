using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Genel
{
    public partial class locForm : DevExpress.XtraEditors.XtraForm
    {
        bool hasChanges = false;

        public locForm()
        {
            InitializeComponent();

            locGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colCITYID.ColumnEdit = Program.MF.locRepositoryItemLookUpEdit;
        }

        private void Save()
        {
            this.Validate();
            this.locBindingSource.EndEdit();

            if (genelDataSet.HasChanges())
            {
                hasChanges = true;
                int nor = this.locTableAdapter.Update(this.genelDataSet.LOC);
            }

        }

        private void locForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'genelDataSet.LOC' table. You can move, or remove it, as needed.
            //this.locTableAdapter.Fill(this.genelDataSet.LOC);

            Qry.qsLocXF frm = new Qry.qsLocXF();
            frm.LOC = genelDataSet.LOC;
            frm.Dock = DockStyle.Fill;
            qsDockPanel.Controls.Add(frm);

            locGridView.OptionsBehavior.Editable = Program.MF.ModifyCheck("Genel.locForm", true);
        }

        private void mapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genel.mapXF frm = new Genel.mapXF();
            frm.MapCenter(locGridView.GetFocusedRowCellDisplayText(colLOCID));
            frm.ShowDialog();
            frm.Dispose();
        }

        private void aktifYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locGridView.SetFocusedRowCellValue(colDRM, "A");
            Save();
        }

        private void locForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            if (hasChanges)
                Program.MF.locLUtreeTableAdapter.Fill(Program.MF.mainDataSet.LOC_LU_TREE);
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}