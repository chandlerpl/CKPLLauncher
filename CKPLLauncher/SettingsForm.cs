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
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button close;

        private Form form;

        private void uninstall_Click(object sender, EventArgs e)
        {
            form = new Form();
            // 
            // Uninstall
            // 
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.ClientSize = new System.Drawing.Size(300, 75);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.MaximumSize = new System.Drawing.Size(300, 75);
            form.MinimumSize = new System.Drawing.Size(300, 75);
            form.Text = "Uninstall";
            form.ResumeLayout(false);
            confirm = new System.Windows.Forms.Button();
            cancel = new System.Windows.Forms.Button();
            name = new System.Windows.Forms.Label();
            close = new System.Windows.Forms.Button();

            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(274, 3);
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 16;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.uninstallCancel_Click);

            // 
            // close
            // 
            this.name.Location = new System.Drawing.Point(3, 3);
            this.name.Text = "Are you sure you want to unistall " + this.Text.Replace(" Properties", "") + "?";
            this.name.TextAlign = ContentAlignment.MiddleLeft;
            this.name.Dock = DockStyle.Top;

            // 
            // confirm
            // 
            confirm.Location = new System.Drawing.Point(25, 20);
            confirm.Size = new System.Drawing.Size(100, 25);
            confirm.Text = "Confirm";
            confirm.Click += new System.EventHandler(this.uninstallConfirm_Click);
            

            // 
            // cancel
            // 
            cancel.Location = new System.Drawing.Point(160, 20);
            cancel.Size = new System.Drawing.Size(100, 25);
            cancel.Text = "Cancel";
            cancel.Click += new System.EventHandler(this.uninstallCancel_Click);

            form.Controls.Add(cancel);
            form.Controls.Add(confirm);
            form.Controls.Add(close);
            form.Controls.Add(name);
            form.Show();
        }

        public void uninstallCancel_Click(object sender, EventArgs e)
        {
            form.Close();
            form.Dispose();
        }

        public void uninstallConfirm_Click(object sender, EventArgs e)
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
            if (this.Text.Replace(" Properties", "") == "CKPL Launcher")
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
            this.propertiesName.Text = this.Text;
            if (this.Text.Replace(" Properties", "") == "CKPL Launcher")
            {
                this.uninstall.Enabled = false;
                this.diskUsage.Text = FileSize.FormatBytes(FileSize.DirSize(new DirectoryInfo(Application.StartupPath)));
            }
            else
            {
                if (Directory.Exists(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", "")))
                {
                    this.diskUsage.Text = FileSize.FormatBytes(FileSize.DirSize(new DirectoryInfo(Application.StartupPath + "\\apps\\" + this.Text.Replace(" Properties", ""))));
                }
                else
                {
                    this.diskUsage.Text = "None";
                    //this.uninstall.Enabled = false;
                    this.browseGameFiles.Enabled = false;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void minimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
