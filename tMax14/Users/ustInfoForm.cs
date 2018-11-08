using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;

namespace tMax14.Users
{
    public partial class ustInfoForm : DevExpress.XtraEditors.XtraForm
    {
        
        
        public ustInfoForm(ustForm pFrm)
        {
            InitializeComponent();

            //infoRichEditControl.HtmlText = ustRow.INFO;
            infoRichEditControl.DataBindings.Add(new Binding("HtmlText", pFrm.ustBindingSource, "INFO")); //this.carsBindingSource, "RtfContent"));

        }

        private void ustInfoForm_Load(object sender, EventArgs e)
        {
            infoRichEditControl.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A4;
            infoRichEditControl.Document.Sections[0].Margins.Left = 10;
            infoRichEditControl.Document.Sections[0].Margins.Right = 10;
            infoRichEditControl.Document.Sections[0].Margins.Top = 10;
            infoRichEditControl.Document.Sections[0].Margins.Bottom = 10;
            infoRichEditControl.Document.DefaultCharacterProperties.FontSize = 10;
            infoRichEditControl.Document.DefaultCharacterProperties.FontName = "Arial";

            // Add new Style
            CharacterStyle cstyle = infoRichEditControl.Document.CharacterStyles["MyCStyle"];
            if (cstyle == null)
            {
                cstyle = infoRichEditControl.Document.CharacterStyles.CreateNew();
                cstyle.Name = "MyCStyle";
                cstyle.Parent = infoRichEditControl.Document.CharacterStyles["Default Paragraph Font"];
                cstyle.ForeColor = Color.DarkOrange;
                cstyle.Strikeout = StrikeoutType.Double;
                cstyle.FontName = "Verdana";
                infoRichEditControl.Document.CharacterStyles.Add(cstyle);
            }

        }
    }
}