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
    public partial class newTagXF : DevExpress.XtraEditors.XtraForm
    {
        public string newTbl = string.Empty;
        public string newTag = string.Empty;

        public newTagXF()
        {
            InitializeComponent();
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TAGtextEdit.Text))
            {
                newTag = "<"+TAGtextEdit.Text+">";
                if (Program.MF.mainDataSet.XTG.FindByTBLTAG(newTbl, newTag) == null)
                {
                    Program.MF.mainDataSet.XTG.AddXTGRow(newTbl, newTag, ADtextEdit.Text, Program.USR, DateTime.Now, "");
                    Program.MF.xtgTableAdapter.Update(Program.MF.mainDataSet.XTG);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void newTagXF_Load(object sender, EventArgs e)
        {
            TBLtextEdit.Text = newTbl;
        }
    }
}