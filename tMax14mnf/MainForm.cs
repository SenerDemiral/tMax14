using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tMax14mnf
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.XGTPOR' table. You can move, or remove it, as needed.
            this.xGTPORTableAdapter.Fill(this.dataSet.XGTPOR);
            // TODO: This line of code loads data into the 'dataSet1.XGTPAG' table. You can move, or remove it, as needed.
            this.xGTPAGTableAdapter.Fill(this.dataSet1.XGTPAG);
            // TODO: This line of code loads data into the 'dataSet.XGTTOS' table. You can move, or remove it, as needed.
            this.xGTTOSTableAdapter.Fill(this.dataSet.XGTTOS);
            Text = Program.mnfAd;
            
            this.frtTableAdapter.Fill(this.dataSet.FRT);
            
        }

        private void ophoSimpleButton_Click(object sender, EventArgs e)
        {
            ophoXF frm = new ophoXF();
            //frm.MdiParent = this;
            //frm.Dock = DockStyle.Fill;
            //frm.Show();
            tabbedView.AddDocument(frm);
           // tabbedView.ActiveDocument.Caption = frmText;

        }

        public void XGLrestore(string layoutName, int idx, object sender)
        {
            dynamic view = sender;
            string text = (string)queriesTableAdapter.XGL_GET(Program.USR, layoutName, idx);
            if (!string.IsNullOrEmpty(text))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(text);
                MemoryStream stream = new MemoryStream(byteArray);
                view.RestoreLayoutFromStream(stream);
                stream.Close();
            }
        }

    }
}
