using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Account
{
    public partial class HspPlnAltXF : DevExpress.XtraEditors.XtraForm
    {
        public HspPlnAltXF()
        {
            InitializeComponent();

            ahpxGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colXHSPNO.ColumnEdit = Program.MF.HspNoXrepositoryItemTextEdit;

        }

        private void aHPXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aHPXBindingSource.EndEdit();
            this.aHPXTableAdapter.Update(this.accountDataSet.AHPX);

        }

        private void HspPlnAltXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.AHPX' table. You can move, or remove it, as needed.
            this.aHPXTableAdapter.Fill(this.accountDataSet.AHPX);

        }
    }
}