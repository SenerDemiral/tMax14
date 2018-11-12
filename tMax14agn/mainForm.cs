using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;

namespace tMax14agn
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
    {
        public mainForm()
        {
            InitializeComponent();

            this.Text = string.Format("tMax14 Agents : #{0} {1}", Program.agn, Program.agnAd);

            this.Text = string.Format("tMax14 Agents v{0} : #{1} {2}", Assembly.GetExecutingAssembly().GetName().Version.ToString(), Program.agn, Program.agnAd);
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = "tMax14 Agents v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                this.Text = string.Format("tMax14 Agents v{0} : #{1} {2}", System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion, Program.agn, Program.agnAd);
            }

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
        }

        private void opmSimpleButton_Click(object sender, EventArgs e)
        {
            opmXF frm = new opmXF();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.oPSTPTableAdapter.Fill(this.dataSet.OPSTP);
            this.oPSTNTableAdapter.Fill(this.dataSet.OPSTN);
        }

        private void ophSimpleButton_Click(object sender, EventArgs e)
        {
            ophXF frm = new ophXF();
            frm.MdiParent = this;
            frm.Show();
        }

        private void afbSimpleButton_Click(object sender, EventArgs e)
        {
            if (Program.agnLocID.StartsWith("TR"))
            {
                afbIcXF frm = new afbIcXF();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                afbDisXF frm = new afbDisXF();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}