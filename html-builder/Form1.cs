using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace html_builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckFolders();
            txtFamilyIntro.LicenceKey = ConfigurationManager.AppSettings["LicenceKey"];
            txtFamilyIntro.DocumentHTML = "";
            txtFamilyIntro.UseRelativeURLs = true;
            txtFamilyIntro.BaseURL = "";
            txtFamilyIntro.UseParagraphAsDefault = true;
            //txtFamilyIntro.HideDOMToolbar = true;
            //txtFamilyIntro.HideMainToolbar = true;
            txtFamilyIntro.HiddenButtons = "tsbPrint,tsbIndent,tsbOutdent,InsertImageToolStripButton,FontToolStripComboBox";
            //https://zoople.tech/viewpage.aspx?ID=HTML.NET%20API&Parent=HTML.NET
            //tsbShowCode tsbPrint tsbCut tsbCopy tsbPaste tsbUndo tsbRedo tsbBold tsbItalic tsbUnderline tsbStrikeout 
            //tsbSuperscript tsbSubscript tsbRemoveFormatting tsbAlignLeft tsbAlignCentre tsbAlignRight tsbAlignJustify 
            //tsbOrderedList tsbUnorderedList tsbOutdent tsbIndent tsbInsertLink tsbRemoveLink InsertImageToolStripButton 
            //TableOptionsToolStripMenuItem tsbForeColor tsbBackColor FontToolStripComboBox FontSizeComboBox FormatSelectionCombo 
            //tsbElementProperties
        }

        private void CheckFolders()
        {
            string path = Application.StartupPath + @"\" + ConfigurationManager.AppSettings["OutputFolderName"];
            if(Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            path = Application.StartupPath + @"\" + ConfigurationManager.AppSettings["ImageStorageLocation"];
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }
        private void btnCreatePage_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + @"\" + ConfigurationManager.AppSettings["TemplateFileName"];
                string familyName = txtFamilyName.Text;
                string familyNameLowerCase = txtFamilyName.Text.ToLower();

                string title = familyNameLowerCase + " genealogy";
                string output_file_name = familyNameLowerCase + " Family genealogy " + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html";

                var file_content = File.ReadAllText(path).ToString();

                file_content = file_content.Replace("{CURRENT_YEAR}", DateTime.Now.Year.ToString());
                file_content = file_content.Replace("{FAMILY_NAME_LOWER}", familyNameLowerCase);
                file_content = file_content.Replace("{FAMILY_NAME}", txtFamilyName.Text);
                file_content = file_content.Replace("{PAGE_WIDTH}", txtPageWidth.Text);

                string introText = txtFamilyIntro.DocumentHTML;
                                
                file_content = file_content.Replace("{FAMILY_INTRO}", introText);
                file_content = file_content.Replace("{TOP_PLACEHOLDER}", GetTopBanner());
                file_content = file_content.Replace("{MIDDLE_PLACEHOLDER}", GetMiddleBanner());
                file_content = file_content.Replace("{BOTTOM_PLACEHOLDER}", GetBottomBanner());
                file_content = file_content.Replace("{LEFT_PLACEHOLDER}", GetLeftBanner());
                file_content = file_content.Replace("{RIGHT_PLACEHOLDER}", GetRightBanner());

                if(rbCodeL.Checked || rbCodeR.Checked || rbImageL.Checked || rbImageR.Checked)
                {
                    file_content = file_content.Replace("MIDDLE_BANNER_CLASS", "banner-div");
                }
                var final = file_content;

                var output_path = Application.StartupPath + @"\" + ConfigurationManager.AppSettings["OutputFolderName"] + @"\";
                var output_file_path = output_path + output_file_name;

                File.WriteAllText(output_file_path, file_content);

                DialogResult dr = MessageBox.Show("Page created successfully. Open output folder?", "Output", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(dr == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", output_path);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtPageWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private string GetTopBanner()
        {
            if(txtBannerT.Text.Length == 0)
                return "";
            string markup = "";
            if (rbCodeT.Checked)
            {
                markup = txtBannerT.Text;
            }
            else if(rbImageT.Checked)
            {
                markup=  "<img src=\"" + txtBannerT.Text + "\" alt=\"top ad\" />";
            }
            return markup;
        }

        private string GetMiddleBanner()
        {
            if (txtBannerM.Text.Length == 0)
                return "";
            string markup = "";
            if (rbCodeM.Checked)
            {
                markup = txtBannerM.Text;
            }
            else if (rbImageM.Checked)
            {
                markup = "<img src=\"" + txtBannerM.Text + "\" alt=\"middle ad\" />";
            }
            return markup;
        }

        private string GetBottomBanner()
        {
            if (txtBannerB.Text.Length == 0)
                return "";
            string markup = "";
            if (rbCodeB.Checked)
            {
                markup = txtBannerB.Text;
            }
            else if (rbImageB.Checked)
            {
                markup = "<img src=\"" + txtBannerB.Text + "\" alt=\"bottom ad\" />";
            }
            return markup;
        }

        private string GetLeftBanner()
        {
            if (txtBannerL.Text.Length == 0)
                return "";
            string markup = "";
            if (rbCodeL.Checked)
            {
                markup = txtBannerL.Text;
            }
            else if (rbImageL.Checked)
            {
                markup = "<img src=\"" + txtBannerL.Text + "\" alt=\"left ad\" />";
            }
            return markup;
        }

        private string GetRightBanner()
        {
            if (txtBannerR.Text.Length == 0)
                return "";
            string markup = "";
            if (rbCodeR.Checked)
            {
                markup = txtBannerR.Text;
            }
            else if (rbImageR.Checked)
            {
                markup = "<img src=\"" + txtBannerR.Text + "\" alt=\"right ad\" />";
            }
            return markup;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //var formWidth = this.Width - 100;
            //txtFamilyIntro.Width = formWidth;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
