using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace tMax14.SmallTalk
{
    public partial class stNewForm : DevExpress.XtraEditors.XtraForm
    {
        public int STid;
        string act;

        public stNewForm()
        {
            InitializeComponent();
        }

        public stNewForm(string act)
        {
            InitializeComponent();

            roomLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            catLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            sbjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

            this.act = act;
            if (act == "New")
            {
                // Input: Tur, Room, Subject, Msj
                STid = 0;
                catLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                roomLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                sbjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                msjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (act == "Append")
            {
                // Input: Msj
                msjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (act == "Cancel")
            {
                // Input: Msj(Cancel reason)
                msjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else if (act == "Close")
            {
                // Input: Satisfaction
                //sfnLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            else
                Close();  // Hata


            catLookUpEdit.Properties.DataSource = Program.MF.stCatDW;    // Konu Türü
            catLookUpEdit.Properties.ValueMember = "ID";
            catLookUpEdit.Properties.DisplayMember = "VAL";
            catLookUpEdit.EditValue = "-";

            roomLookUpEdit.Properties.DataSource = Program.MF.strDW;     // Cell/Room
            roomLookUpEdit.Properties.ValueMember = "STRID";
            roomLookUpEdit.Properties.DisplayMember = "NAME";
        }

        private void stNewForm_Load(object sender, EventArgs e)
        {
            roomLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            sbjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            if (STid == 0) // YeniMesaj
            {
                roomLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                sbjLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }

        private void OKsimpleButton_Click(object sender, EventArgs e)
        {
            int STRid = roomLookUpEdit.EditValue == null ? 0 : (int)roomLookUpEdit.EditValue;

            string msj = (string)smallTalkQueriesTableAdapter.ST_APND(act, STid, STRid, Program.USTid, catLookUpEdit.EditValue.ToString(), sbjTextEdit.Text, tagTextEdit.Text, "", msjMemoEdit.Text);
            if (msj != "")
            {
                XtraMessageBox.Show(msj, "Mesaj Ekle");
                return;
            }
            else
            {
                if (STid == 0) // YeniMesaj
                {
                    //SmallTalkDataSet.STKRow row = smallTalkDataSet.STK.FindBySTKID(STKid);
                    //string SMSlist = row["SMSLIST"].ToString();
                    //if (!string.IsNullOrEmpty(SMSlist))
                    //    sendSMS(SMSlist, ozetTextEdit.Text);
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


    }
}