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
    public partial class efuMdfyXF : DevExpress.XtraEditors.XtraForm
    {
        public object RefTO;
        public object RefID;
        public object TAGs;
        public object Info;
        public object TkpTrh;

        //public efuMdfyXF(object RefTO, object RefID, object TAGs, object TkpTrh)
        public efuMdfyXF()
        {
            InitializeComponent();
        }

        private void efuMdfyXF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet.XTG' table. You can move, or remove it, as needed.
            this.xTGTableAdapter.FillByEFU(this.mainDataSet.XTG);

            RefTOtextEdit.Text = RefTO.ToString();
            RefIDtextEdit.Text = RefID.ToString();
            TAGScheckedComboBoxEdit.EditValue = TAGs;
            //MsjTextEdit.Text = "";
            //if (TkpTrh != DBNull.Value)   Kullanma bir onceki kalsin
            //    TkpTrhDateEdit.EditValue = TkpTrh;
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            Info = mainQueriesTableAdapter.EFU_MDFY(RefTOtextEdit.Text, Convert.ToInt32(RefIDtextEdit.Text), TAGScheckedComboBoxEdit.Text, MsjTextEdit.Text, TkpTrhDateEdit.DateTime, Program.USR).ToString();
            
            TAGs = TAGScheckedComboBoxEdit.EditValue.ToString();
            TkpTrh = TkpTrhDateEdit.EditValue;
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void TAGScheckedComboBoxEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                CheckedComboBoxEdit edit = (sender as CheckedComboBoxEdit);

                // New TAG form
                Genel.newTagXF frm = new Genel.newTagXF();
                frm.newTbl = "EFU";
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