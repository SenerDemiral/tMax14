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
    public partial class AccHspNoBkyXF : XtraForm
    {
        string hspNo;
        int frtID;

        public AccHspNoBkyXF(string HspNo, int frtID)
        {
            InitializeComponent();

            this.hspNo = HspNo;
            this.frtID = frtID;
        }

        private void AccHspNoBkyXF_Load(object sender, EventArgs e)
        {
            try
            {
                this.aCC_HSPNO_BKYTableAdapter.Fill(this.accountDataSet.ACC_HSPNO_BKY, hspNo, frtID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}