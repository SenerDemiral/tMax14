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
    public partial class TblTagMdfyXF : DevExpress.XtraEditors.XtraForm
    {
        public string RefTbl = "";
        public int RefID = 0;
        public object TAGs;

        public TblTagMdfyXF()
        {
            InitializeComponent();


        }

        private void TblTagMdfyXF_Load(object sender, EventArgs e)
        {
            this.xTGTableAdapter.FillByTBL(this.mainDataSet.XTG, RefTbl);

            TAGScheckedComboBoxEdit.EditValue = TAGs;
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            mainQueriesTableAdapter.TBL_TAG_MDFY(RefTbl, RefID, TAGScheckedComboBoxEdit.EditValue.ToString());
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void TAGScheckedComboBoxEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = RefTbl;
                frm.ShowDialog();
                string newTag = frm.newTag;
                frm.Dispose();

                if (!edit.EditValue.ToString().Contains(newTag))
                {
                    if (!string.IsNullOrEmpty(edit.Text))
                        edit.EditValue += ", ";
                    edit.EditValue += newTag;
                }
            }
        }

    }
}