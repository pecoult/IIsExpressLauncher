using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IisExpressLauncher
{
    public partial class Main : Form
    {
        private const string defaultPortNo = "8080";
        private const string localHostName = "localhost";
        private List<string> installationPaths = new List<string> { 
            @"C:\Program Files (x86)\IIS Expressa\",
            @"C:\Program Files\IIS Expressa\"
        };
        private const string iisExpressExeName = "iisexpress.exe";
        private const string settingPreviousWebsitePath = "PreviousWebsitePath";
        private const string settingPreviousPortNo = "PreviousPortNo";
        private const string settingCustomPathToIisExpress = "CustomPathToIisExpress";

        public Main()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            this.Visible = true; 

            tbxWebSiteDir.Text = Properties.Settings.Default[settingPreviousWebsitePath].ToString();
            tbxPortNo.Text = Properties.Settings.Default[settingPreviousPortNo].ToString();

            if (string.IsNullOrWhiteSpace(tbxPortNo.Text))
            {
                tbxPortNo.Text = defaultPortNo;
            }

            ShowPanel(pnlMain);

            ShowFeedback("");
        }

        private void ShowPanel(Panel pnlToShow)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }

            pnlToShow.Visible = true;
            pnlToShow.Location = new Point(0, 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (GetInputValidationErrors().Count() > 0)
            {
                ShowFeedback(string.Join(Environment.NewLine, GetInputValidationErrors()));
            }
            else
            {
                // get iis installation path
                var pathToIis = (Properties.Settings.Default[settingCustomPathToIisExpress] ?? "").ToString();

                if (string.IsNullOrWhiteSpace(pathToIis))
                {
                    foreach (var installationPath in installationPaths)
                    {
                        if (Directory.Exists(installationPath))
                        {
                            pathToIis = installationPath;
                            break;
                        }
                    }
                }

                pathToIis = Path.Combine(pathToIis, iisExpressExeName);

                if (!File.Exists(pathToIis))
                {
                    ShowPanel(pnlSetIisExpressPath);
                    ShowFeedback("Unable to find an installation of IIS Express. Please locate iisexpress.exe");
                }
                else
                {
                    ShowFeedback("");
                    var parameters = string.Format("\"/path:{0}\" /port:{1}", tbxWebSiteDir.Text, tbxPortNo.Text);
                    Process process = Process.Start(pathToIis, parameters);

                    if (cbxOpenInBrowser.Checked)
                    {
                        Process.Start(string.Format("http://{0}:{1}", localHostName, tbxPortNo.Text));
                    }

                    process.WaitForExit();

                    // save input for next time
                    Properties.Settings.Default[settingPreviousWebsitePath] = tbxWebSiteDir.Text;
                    Properties.Settings.Default[settingPreviousPortNo] = tbxPortNo.Text;
                    Properties.Settings.Default.Save();

                    this.Close();
                }
            }

        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            tbxWebSiteDir.Text = ChooseFolderPath();
        }

        private void btnChoosePathToIisExpress_Click(object sender, EventArgs e)
        {
            tbxPathToIisExpress.Text = ChooseFolderPath();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(tbxPathToIisExpress.Text, iisExpressExeName)))
            {
                ShowFeedback(string.Format("{0} was not found at the path sprcified.", iisExpressExeName));
            }
            else
            {
                Properties.Settings.Default[settingCustomPathToIisExpress] = tbxPathToIisExpress.Text;
                Properties.Settings.Default.Save();

                ShowPanel(pnlMain);
            }
        }

        private IEnumerable<string> GetInputValidationErrors()
        {
            var retVal = new List<string>();

            if (!Directory.Exists(tbxWebSiteDir.Text))
            {
                retVal.Add("Website Path could not be found");
            }

            var portNo = 0;
            if (int.TryParse(tbxPortNo.Text, out portNo))
            {
                // must be positive
                if (portNo < 0)
                {
                    retVal.Add("Port Number must be greater than 0");
                }

                // must not be reserved
                if (portNo <= 1024)
                {
                    retVal.Add("Port Number must be greater that 1024 (0 - 1024 are reserved)");
                }

                // must be less than 65536
                if (portNo > 65536)
                {
                    retVal.Add("Port Number must be less than 65536");
                }
            }
            else
            {
                retVal.Add("Port Number must be a numeric value");
            }

            return retVal;
        }

        private string ChooseFolderPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            return fbd.SelectedPath;
        }

        private int GetFeedbackLabelHeight() 
        {
            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(lblFeedback.Text, lblFeedback.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }

        private void ShowFeedback(string feedback)
        {
            lblFeedback.Text = feedback;

            foreach (Control c in this.Controls)
            {
                if (c is Panel && c.Visible)
                {
                    var height = GetFeedbackLabelHeight();
                    c.Location = new Point(0, height == 0 ? 0 : height + 20);
                    SetFormHeight();
                    break;
                }
            }
        }

        private void SetFormHeight()
        {
            foreach (Control c in this.Controls)
            {
                if (c.Visible)
                {
                    this.Height = c.Height + c.Location.Y + 50;
                    break;
                }
            }
        }
    }
}
