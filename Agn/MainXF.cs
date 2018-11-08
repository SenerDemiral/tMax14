using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Agn
{
    public partial class MainXF : DevExpress.XtraEditors.XtraForm
    {
        public MainXF()
        {
            InitializeComponent();
        }

        private void OPMnavBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            opmXF frm = new opmXF();
            tabbedView.AddDocument(frm);
        }
    }
}