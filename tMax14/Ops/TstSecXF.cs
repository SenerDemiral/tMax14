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
    public partial class TstSecXF : DevExpress.XtraEditors.XtraForm
    {
        public int TstID = 0;
        public string TOB = "", ROT = "", MOT = "";
        public int FrtID = 0;

        public TstSecXF()
        {
            InitializeComponent();

            tstLupGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colSTU.ColumnEdit = Program.MF.TklfStuRepositoryItemImageComboBox;
            colTYP.ColumnEdit = Program.MF.TklfTypRepositoryItemImageComboBox;
        }

        private void TstSecXF_Load(object sender, EventArgs e)
        {
            string iQry = string.Format("TOB = '{0}' and ROT = '{1}' and MOT = '{2}'", TOB, ROT, MOT);
            if (FrtID != 0)
                iQry += string.Format(" and FRTID = {0}", FrtID);
            this.tstLupTableAdapter.Fill(this.opsDataSet.TST_LUP, iQry);
            //gridView1.ActiveFilterString = string.Format("[TOB] = {0} and [ROT] = '{1}' and [MOT] = '{2}'", TOB, ROT, MOT);
            gridView1.BestFitColumns();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void secToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void Sec()
        {
            var view = gridView1;
            if (!view.IsDataRow(view.FocusedRowHandle))
                return;

            TstID = (int)view.GetFocusedRowCellValue(colTSTID);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}