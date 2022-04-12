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
using System.Xml.Linq;

namespace ParamSFXFix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessExtra_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtInput.Text != "")
            {
                ExtraDirSearch(txtInput.Text);
            }
            else
            {
                MessageBox.Show("Enter an input and output directory!");
            }
        }

        string ParseOneFile(string XmlPath)
        {
            XAttribute SfxKey = new XAttribute("key", "TITLE");
            XDocument ParamSfx = XDocument.Load(XmlPath);
            XElement ParamSfo = ParamSfx.Element("paramsfo");
            IEnumerable<XElement> ParamTitle =
                from x in ParamSfo.Elements()
                where x.Attribute("key").Value == "TITLE"
                select x;
            return ParamTitle.FirstOrDefault().Value;
        }

        string MoveFromDir(string InDir, string OutDir, string NewFilename, string GameName)
        {
            string FullName = NewFilename;
            string OldName = InDir;
            if (GameName != "")
            {
                if (radPref.Checked)
                {
                    FullName = GameName + " - " + NewFilename;
                }
                else
                {
                    FullName = Path.GetFileNameWithoutExtension(NewFilename) + " - " + GameName + Path.GetExtension(NewFilename);
                }
            }
            //MessageBox.Show("Input Directory: " + InDir + "\nOutput Directory: " + OutDir + "\nUnmodified File Name: " + NewFilename + "\nName Add-on: " + GameName);
            foreach (string f in Directory.GetFiles(InDir, "DATA000" + Path.GetExtension(NewFilename).ToUpperInvariant()))
            {
                
                switch (Path.GetExtension(f).ToUpperInvariant())
                {
                    case ".PKG":
                        FullName = Path.Combine(OutDir, txtPkgPref.Text + Path.GetFileNameWithoutExtension(FullName) + txtPkgSuf.Text + Path.GetExtension(NewFilename));
                        OldName = f;
                        break;
                    case ".P3T":
                        FullName = Path.Combine(OutDir, textOtherPref.Text + Path.GetFileNameWithoutExtension(FullName) + txtOtherSuf.Text + Path.GetExtension(NewFilename));
                        OldName = f;
                        break;
                    case ".MP4":
                        FullName = Path.Combine(OutDir, txtVidPref.Text + Path.GetFileNameWithoutExtension(FullName) + txtVidSuf.Text + Path.GetExtension(NewFilename));
                        OldName = f;
                        break;
                    default:
                        return InDir + ": File with correct extension not found to move to " + OutDir;
                }
            }
            try
            {
                File.Move(OldName, FullName);
            } catch (Exception e) {
                return e.Message;
            }
            return OldName + " successfully moved to " + FullName;
        }

        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir, "*", SearchOption.AllDirectories))
                {
                    foreach (string f in Directory.GetFiles(d, @"PARAM.SFX"))
                    {
                        if (boxNameFix.Checked)
                        {
                            lstErrorList.Items.Add(MoveFromDir(d, txtOutput.Text, ParseOneFile(f), Directory.GetParent(sDir).ToString()));
                        }
                        else
                        {
                            lstErrorList.Items.Add(MoveFromDir(d, txtOutput.Text, ParseOneFile(f), ""));
                        }
                    }
                    //DirSearch(d, sDir, extraDir);
                }
            }
            catch (System.Exception excpt)
            {
                lstErrorList.Items.Add("Directory error: " + excpt.Message);
            }
        }

        void ExtraDirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, @"PARAM.SFX"))
                    {
                            lstErrorList.Items.Add(MoveFromDir(d, txtOutput.Text, ParseOneFile(f), ""));
                    }
                    //DirSearch(d, sDir, extraDir);
                }
            }
            catch (System.Exception excpt)
            {
                lstErrorList.Items.Add("Directory error: " + excpt.Message);
            }
        }

        void SingleDirSearch(string sDir)
        {
            try
            {
                    foreach (string f in Directory.GetFiles(sDir, @"PARAM.SFX"))
                    {
                        lstErrorList.Items.Add(MoveFromDir(sDir, txtOutput.Text, ParseOneFile(f), ""));
                    }
            }
            catch (System.Exception excpt)
            {
                lstErrorList.Items.Add("Directory error: " + excpt.Message);
            }
        }
        private void btnRecursiveMove_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtInput.Text != "")
            {
                DirSearch(txtInput.Text);
            }
            else
            {
                MessageBox.Show("Enter an input and output directory!");
            }
        }

        private void btnInputPick_Click(object sender, EventArgs e)
        {
            if (browseInput.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = browseInput.SelectedPath;
            }
        }

        private void btnOutputPick_Click(object sender, EventArgs e)
        {
            if (browseOutput.ShowDialog() == DialogResult.OK)
            {
                txtOutput.Text = browseOutput.SelectedPath;
            }
        }

        private void btnProcessDir_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtInput.Text != "")
            {
                SingleDirSearch(txtInput.Text);
            }
            else
            {
                MessageBox.Show("Enter an input and output directory!");
            }
        }
    }
}
