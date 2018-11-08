using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.SmallTalk
{
    public partial class stSelOutUC : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime SonOkuTrh = new DateTime(2000, 1, 1, 0, 0, 0);
        string qStu = "O";  //Open
        string usrBKM;

        public stSelOutUC()
        {
            InitializeComponent();

            usrBKM = "<" + Program.USTid.ToString() + ">";
            
            stSelOutGridControl.ExternalRepository = Program.MF.mainPersistentRepository;
            colOUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colMUSRID.ColumnEdit = Program.MF.ustRepositoryItemLookUpEdit;
            colSTRID.ColumnEdit = Program.MF.strRepositoryItemLookUpEdit;
            colCAT.ColumnEdit = Program.MF.stCatRepositoryItemLookUpEdit;

            TAGbuttonEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            TAGbuttonEdit.Properties.Mask.EditMask = Program.MF.TAGrepositoryItemTextEdit.Mask.EditMask;
        }

        private void stSelOutUserControl_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void fill()
        {
            this.stSelOutTableAdapter.Fill(this.smallTalkDataSet.ST_SEL_OUT, Program.USTid, qStu, SonOkuTrh);
            stSelOutGridView.ExpandAllGroups();
        }

        private void stSelGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            // Gidenler Okundu yapilamaz
            //if (stSelGridView.GetFocusedRowCellValue("YON").ToString() == "O")
            //    e.Cancel = true;
        }

        #region ContextMenu

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            konuyaMesajEkleToolStripMenuItem.Enabled = true;
            konuyuKapaToolStripMenuItem.Enabled = true;
            konuyuIptalToolStripMenuItem.Enabled = true;

            if (!stSelOutGridView.IsDataRow(stSelOutGridView.FocusedRowHandle) || stSelOutGridView.GetFocusedRowCellValue(colSTU).ToString() != "O")
            {
                konuyaMesajEkleToolStripMenuItem.Enabled = false;
                konuyuKapaToolStripMenuItem.Enabled = false;
                konuyuIptalToolStripMenuItem.Enabled = false;
            }
        }

        private void yeniKonuAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("New");
            frm.STid = 0;
            frm.ShowDialog();
            fill();
        }

        private void konuyaMesajEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Append");
            frm.STid = (int)stSelOutGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void konuyuKapaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Close");
            frm.STid = (int)stSelOutGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void konuyuIptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stNewForm frm = new stNewForm("Cancel");
            frm.STid = (int)stSelOutGridView.GetFocusedRowCellValue(colSTID);
            frm.ShowDialog();
            fill();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stuOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "O";
            stuCancelledToolStripMenuItem.Checked = false;
            stuClosedToolStripMenuItem.Checked = false;
            fill();
        }

        private void stuCancelledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "X";
            stuOpenToolStripMenuItem.Checked = false;
            stuClosedToolStripMenuItem.Checked = false;
            fill();
        }

        private void stuClosedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qStu = "C";
            stuCancelledToolStripMenuItem.Checked = false;
            stuOpenToolStripMenuItem.Checked = false;
            fill();
        }

        #endregion ContextMenu

        private void TAGrepositoryItemTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string value;
                if ((barManager.ActiveEditor as DevExpress.XtraEditors.TextEdit).EditValue == null)
                    value = "";
                else
                    value = (barManager.ActiveEditor as DevExpress.XtraEditors.TextEdit).EditValue.ToString();

                //////////
                //string sss = addDelTAGbarEditItem.EditValue.ToString();
                e.Handled = true;
            }
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKM = stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (!BKM.Contains(usrBKM))
            {
                int PK = Convert.ToInt32(stSelOutGridView.GetFocusedRowCellValue(colSTID));
                BKM += usrBKM;
                stSelOutGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelOutGridView.UpdateCurrentRow();
                smallTalkQueriesTableAdapter.ST_UPD(PK, stSelOutGridView.GetFocusedRowCellValue(colTAG).ToString(), stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString());
            }
        }

        private void deleteBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string BKM = stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (BKM.Contains(usrBKM))
            {
                BKM = BKM.Replace(usrBKM, "");
                stSelOutGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelOutGridView.UpdateCurrentRow();
            }
        }

        private void TAGbuttonEdit_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string TAG = stSelOutGridView.GetFocusedRowCellValue(colTAG).ToString();
            int PK = Convert.ToInt32(stSelOutGridView.GetFocusedRowCellValue(colSTID));
            
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                TAG += "<"+TAGbuttonEdit.Text+">";
                stSelOutGridView.SetFocusedRowCellValue(colTAG, TAG);

            }
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Minus)
            {
                MessageBox.Show("Del " + TAGbuttonEdit.Text);
                string[] sa = TAGbuttonEdit.Text.Split('>');
                for (int i = 0; i < sa.Length; i++)
                {
                    TAG = TAG.Replace(sa[i]+">", "");
                }
                stSelOutGridView.SetFocusedRowCellValue(colTAG, TAG);
            }
            stSelOutGridView.UpdateCurrentRow();
            smallTalkQueriesTableAdapter.ST_UPD(PK, stSelOutGridView.GetFocusedRowCellValue(colTAG).ToString(), stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString());
        }

        private void addBKMsimpleButton_Click(object sender, EventArgs e)
        {
            string BKM = stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (!BKM.Contains(usrBKM))
            {
                int PK = Convert.ToInt32(stSelOutGridView.GetFocusedRowCellValue(colSTID));
                BKM += usrBKM;
                stSelOutGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelOutGridView.UpdateCurrentRow();
                smallTalkQueriesTableAdapter.ST_UPD(PK, stSelOutGridView.GetFocusedRowCellValue(colTAG).ToString(), stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString());
            }
        }

        private void delBKMsimpleButton_Click(object sender, EventArgs e)
        {
            string BKM = stSelOutGridView.GetFocusedRowCellValue(colBKM).ToString();

            if (BKM.Contains(usrBKM))
            {
                BKM = BKM.Replace(usrBKM, "");
                stSelOutGridView.SetFocusedRowCellValue(colBKM, BKM);
                stSelOutGridView.UpdateCurrentRow();
            }
        }
    }
}
