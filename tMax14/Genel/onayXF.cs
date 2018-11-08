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
    public partial class onayXF : DevExpress.XtraEditors.XtraForm
    {
        public string Tbl;
        public int TblPK = 0;
        public string DvkDvz = string.Empty;
        public DateTime DvkTrh;
        public string curYTK;
        MainDataSet.UUYRow[] uuyRows;
        
        public onayXF()
        {
            InitializeComponent();
        }

        private void onayXF_Load(object sender, EventArgs e)
        {
            //this.uSTTableAdapter.Fill(this.mainDataSet.UST);
            userLookUpEdit.Properties.DataSource = Program.MF.mainDataSet.UST;

            string OK = mainQueriesTableAdapter.ONAYLA_CHECK(Program.USR, curYTK).ToString();
            if (OK == "F")
            {
                MessageBox.Show("Bu kaydı onaylamaya yetkili değilsiniz");
                this.Close();
                return;
            }
            
            curYTKtextEdit.Text = curYTK;
            userLookUpEdit.EditValue = Program.USR;
            if (Program.USR == "ADMIN")
                userLookUpEdit.Enabled = true;

            Init3();
        }

        private void Init()
        {
            //Kullanilmiyor
            /*
            usrYtkRadioGroup.Properties.Items.Clear();
            onaylaSimpleButton.Enabled = false;
            usrYtkRadioGroup.SelectedIndex = -1;

            uuyRows = (MainDataSet.UUYRow[])Program.MF.mainDataSet.UUY.Select(string.Format("USR = '{0}'", userLookUpEdit.EditValue), "YTK", DataViewRowState.OriginalRows);
            if (uuyRows.Length != 0)
            {
                int idx = 0;
                foreach (var uuyRow in uuyRows)
                {
                    string ytkInfo = string.Format("{0}, {1}", uuyRow.YTK, uuyRow.YTKAD);

                    if (string.IsNullOrEmpty(curYTK) || uuyRow.FCN.Contains(string.Format(",{0},", curYTK)))
                    {
                        string[] pNodes = uuyRow.FPN.Split(new char[] {','});
                        foreach (string s in pNodes)
                        {
                            if (!string.IsNullOrEmpty(s))
                            {
                                idx++;
                                usrYtkRadioGroup.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(s, s + "+" + Program.MF.mainDataSet.UYT.FindByYTK(s).AD, true));
                                onaylaSimpleButton.Enabled = true;
                                //if (usrYtkRadioGroup.SelectedIndex == -1)
                                //    usrYtkRadioGroup.SelectedIndex = idx;
                            }
                        }
                        string[] cNodes = uuyRow.FCN.Split(new char[] { ',' });
                        foreach (string s in cNodes)
                        {
                            if (!string.IsNullOrEmpty(s))
                            {
                                idx++;
                                usrYtkRadioGroup.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(s, s + "-" + Program.MF.mainDataSet.UYT.FindByYTK(s).AD, true));
                                onaylaSimpleButton.Enabled = true;
                                if (usrYtkRadioGroup.SelectedIndex == -1)
                                    if (uuyRow.YTK == s)
                                        usrYtkRadioGroup.SelectedIndex = idx;
                            }
                        }
                    }
                    else
                        usrYtkRadioGroup.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(uuyRow.YTK, ytkInfo, false));
                }
            }*/
        }

        private void userLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            Init3();
        }

        private void onaylaSimpleButton_Click(object sender, EventArgs e)
        {
            if (TblPK == 0 && string.IsNullOrEmpty(DvkDvz))
                return;

            string newYTK = imageComboBoxEdit1.EditValue.ToString();
            if (!string.IsNullOrEmpty(newYTK))
            {
                try
                {
                    if (TblPK != 0)
                        mainQueriesTableAdapter.ONAYLA(Tbl, TblPK, newYTK, Program.USR);
                    else
                        mainQueriesTableAdapter.ONAYLA_DVK(DvkDvz, DvkTrh, newYTK, Program.USR);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Onay");
                }
            }
            this.Close();
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Init3()
        {
            onaylaSimpleButton.Enabled = false;
            imageComboBoxEdit1.Properties.Items.Clear();
            imageComboBoxEdit1.SelectedItem = -1;
            uuyRows = (MainDataSet.UUYRow[])Program.MF.mainDataSet.UUY.Select(string.Format("USR = '{0}'", userLookUpEdit.EditValue), "YTK", DataViewRowState.OriginalRows);
            if (uuyRows.Length != 0)
            {
                int idx = 0;
                foreach (var uuyRow in uuyRows)
                {
                    string ytkInfo = string.Format("{0}, {1}", uuyRow.YTK, uuyRow.YTKAD);

                    if (string.IsNullOrEmpty(curYTK) || uuyRow.FCN.Contains(string.Format(",{0},", curYTK)))
                    {
                        string[] pNodes = uuyRow.FPN.Split(new char[] { ',' });
                        foreach (string s in pNodes)
                        {
                            if (!string.IsNullOrEmpty(s))
                            {
                                idx++;
                                imageComboBoxEdit1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("+ "+Program.MF.mainDataSet.UYT.FindByYTK(s).AD, s));
                                onaylaSimpleButton.Enabled = true;
                            }
                        }
                        string[] cNodes = uuyRow.FCN.Split(new char[] { ',' });
                        foreach (string s in cNodes)
                        {
                            if (!string.IsNullOrEmpty(s))
                            {
                                if (uuyRow.YTK == s)
                                {
                                    imageComboBoxEdit1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("* " + Program.MF.mainDataSet.UYT.FindByYTK(s).AD, s));
                                    imageComboBoxEdit1.SelectedIndex = idx;
                                }
                                else
                                    imageComboBoxEdit1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("- " + Program.MF.mainDataSet.UYT.FindByYTK(s).AD, s));
                                onaylaSimpleButton.Enabled = true;
                                idx++;

                            }
                        }
                    }
                }
                if (imageComboBoxEdit1.Properties.Items.Count > 0)
                    imageComboBoxEdit1.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem("- <null>", "-"));
            }
        }
    }
}