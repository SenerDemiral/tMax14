using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.Ops
{
    public partial class ProjeSablonEditXF : DevExpress.XtraEditors.XtraForm
    {
        public string richText;
        
        public ProjeSablonEditXF()
        {
            InitializeComponent();
        }

        private void ProjeSablonEditXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opsDataSet.PRS' table. You can move, or remove it, as needed.
            //this.pRSTableAdapter.Fill(this.opsDataSet.PRS);

   //         if (!prsRow.IsSABLONNull())
   //             richEditControl1.RtfText = prsRow.SABLON;
            richEditControl1.RtfText = richText;
            //this.richEditControl1.DataBindings.Add(new System.Windows.Forms.Binding("RtfText", prsRow, "SABLON", true));


        }

        private void ProjeSablonEditXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            richText = richEditControl1.RtfText;
        }
    }
}