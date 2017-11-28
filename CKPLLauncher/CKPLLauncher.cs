using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;

namespace CKPLLauncher
{
    public partial class CKPLLauncher : Form
    {
        SQLConnection sql;

        public CKPLLauncher()
        {
            InitializeComponent();
        }

        private void gamesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameName.Text = gamesList.SelectedItem.ToString();
            Version.Text = FileSize.xmlData(gameName.Text, "/app/Version", false);
            Developers.Text = FileSize.xmlData(gameName.Text, "/app/Developer", true);
            desc.Text = FileSize.xmlData(gameName.Text, "/app/Description", true);
            string path = Application.StartupPath + "\\apps\\" + gameName.Text;
            if (File.Exists(path + "\\image.jpg"))
            {
                gameImage.Image = Image.FromFile(path);
            }
            else
            {
                gameImage.Image = Properties.Resources.NotAvailable;
            }

            if (gameName.Text == "CKPL Launcher")
            {
                launchWarning.Text = "This app cannot be launched from itself.";
                launchGame.Enabled = false;
            }
            else
            {
                launchWarning.Text = "";
                launchGame.Enabled = true;

                if (FileSize.xmlData(gameName.Text, "/app/Version", true) != FileSize.xmlData(gameName.Text, "/app/Version", false))
                {
                    launchGame.Text = "Update";
                }
                else if (File.Exists(path + "\\" + FileSize.xmlData(gameName.Text, "/app/Executable", false)))
                {
                    launchGame.Text = "Launch";
                }
                else
                {
                    launchGame.Text = "Download";
                }
            }

            string check = FileSize.xmlData(gameName.Text, "/app/SourceCode", true);

            if (check != null && check != "")
            {
                sourceCodeToolStripMenuItem.Enabled = true;
            }
            else
            {
                sourceCodeToolStripMenuItem.Enabled = false;
            }

            check = FileSize.xmlData(gameName.Text, "/app/ProjectFiles", true);

            if (check != null && check != "")
            {
                projectFilesToolStripMenuItem.Enabled = true;
            }
            else
            {
                projectFilesToolStripMenuItem.Enabled = false;
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void CKPLLauncher_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\apps";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!Directory.Exists(Application.StartupPath + "\\downloads"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\downloads");
            }

            if(!Directory.Exists(Application.StartupPath + "\\appData"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\appData");
            }

            if (!Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            sql = new SQLConnection();
            sql.sqlOpen();

            List<String> list = sql.sqlSelect("Name", "gamesList", "");

            foreach (string item in list)
            {
                gamesList.Items.Add(item);
                sql.sqlDownload(Application.StartupPath + "\\temp\\", item, "gamesList");
            }
            gamesList.SelectedIndex = 0;
        }

        private void CKPLLauncher_Closed(object sender, EventArgs e)
        {
            sql.sqlClose();
            Directory.Delete(Application.StartupPath + "\\temp", true);
        }
        
        private void launchGame_Click(object sender, EventArgs e)
        {
            if (launchGame.Text == "Launch")
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\apps\\" + gameName.Text + "\\" + FileSize.xmlData(gameName.Text, "/app/Executable", false));
            }
            else if (launchGame.Text == "Download")
            {
                string fileName = gameName.Text + ".zip";
                startDownload("http://ckplproductions.co.uk/apps/" + fileName, "downloads\\" + fileName);
            }
            else if (launchGame.Text == "Update")
            {
                string fileName = gameName.Text + ".zip";
                startDownload("http://ckplproductions.co.uk/apps/" + fileName, "downloads\\" + fileName);
            }
        }

        private void gamesList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color color = Color.CornflowerBlue;
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, color);
            
            e.DrawBackground();
            e.Graphics.DrawString(gamesList.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = FileSize.xmlData(gameName.Text, "/app/SourceCode", true);
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void projectFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = FileSize.xmlData(gameName.Text, "/app/ProjectFiles", true);
            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void startDownload(string link, string destination)
        {
            Thread thread = new Thread(() => 
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(link), destination);
            });
            thread.Start();
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                string downloaded = FileSize.FormatBytes(e.BytesReceived);
                string toDownload = FileSize.FormatBytes(e.TotalBytesToReceive);
                downloadLabel.Text = "Downloaded " + downloaded + " of " + toDownload;
                downloadProgress.Value = int.Parse(e.ProgressPercentage.ToString());
            });
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if(Directory.Exists(Application.StartupPath + "\\apps\\" + gameName.Text))
                {
                    Directory.Delete(Application.StartupPath + "\\apps\\" + gameName.Text, true);
                }

                string zipPath = Application.StartupPath + "\\downloads\\" + gameName.Text + ".zip";
                string extractPath = Application.StartupPath + "\\apps\\" + gameName.Text + "\\";

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                File.Delete(Application.StartupPath + "\\downloads\\" + gameName.Text + ".zip");

                if (File.Exists(Application.StartupPath + "\\appData\\" + gameName.Text + ".xml"))
                {
                    File.Delete(Application.StartupPath + "\\appData\\" + gameName.Text + ".xml");
                }

                File.Copy(Application.StartupPath + "\\temp\\" + gameName.Text + ".xml", Application.StartupPath + "\\appData\\" + gameName.Text + ".xml");
                launchGame.Text = "Launch";
                downloadLabel.Text = "Completed";
                Version.Text = FileSize.xmlData(gameName.Text, "/app/Version", false);
            });
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Text = gameName.Text + " Properties";
            sf.Show();
        }
    }
}
