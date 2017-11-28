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

namespace CKPLLauncher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;

        private Form form;

        private void uninstall_Click(object sender, EventArgs e)
        {
            form = new Form();
            // 
            // Uninstall
            // 
            form.ClientSize = new System.Drawing.Size(300, 100);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.MaximumSize = new System.Drawing.Size(300, 100);
            form.MinimumSize = new System.Drawing.Size(300, 100);
            form.Text = "Uninstall";
            form.ResumeLayout(false);
            confirm = new System.Windows.Forms.Button();
            cancel = new System.Windows.Forms.Button();

            // 
            // confirm
            // 
            confirm.Location = new System.Drawing.Point(25, 20);
            confirm.Size = new System.Drawing.Size(100, 25);
            confirm.Text = "Confirm";
            confirm.Click += new System.EventHandler(this.confirm_Click);

            // 
            // cancel
            // 
            cancel.Location = new System.Drawing.Point(160, 20);
            cancel.Size = new System.Drawing.Size(100, 25);
            cancel.Text = "Cancel";
            cancel.Click += new System.EventHandler(this.cancel_Click);

            form.Controls.Add(cancel);
            form.Controls.Add(confirm);
            form.Show();
        }

        public void cancel_Click(object sender, EventArgs e)
        {
            form.Close();
            form.Dispose();
        }

        public void confirm_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\appData\\" + this.Text.Replace(" Properties", "") + ".xml"))
            {
                File.Delete(Application.StartupPath + "\\appData\\" + this.Text.Replace(" Properties", "") + ".xml");
            }

            if (Directory.Exists(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", "")))
            {
                Directory.Delete(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", ""), true);
            }

            form.Close();
            form.Dispose();
            this.Close();
            this.Dispose();
        }

        private void browseGameFiles_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.Text.Replace(" Properties", ""));
            if(this.Text.Replace(" Properties", "") == "CKPL Launcher")
            {
                System.Diagnostics.Process.Start(Application.StartupPath);
            }
            else
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", "") + "\\");
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir;

            if (this.Text.Replace(" Properties", "") == "CKPL Launcher")
            {
                this.uninstall.Enabled = false;
                dir = new DirectoryInfo(Application.StartupPath);
            } 
            else
            {
                dir = new DirectoryInfo(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", "") + "\\");
            }
            
            this.diskUsage.Text = FileSize.FormatBytes(FileSize.DirSize(dir));
        }
    }
}
