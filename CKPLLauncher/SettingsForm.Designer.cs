namespace CKPLLauncher
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertiesControl = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.browseGameFiles = new System.Windows.Forms.Button();
            this.diskUsage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uninstall = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertiesControl.SuspendLayout();
            this.general.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertiesControl
            // 
            this.propertiesControl.Controls.Add(this.general);
            this.propertiesControl.Controls.Add(this.tabPage2);
            this.propertiesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesControl.Location = new System.Drawing.Point(0, 0);
            this.propertiesControl.Multiline = true;
            this.propertiesControl.Name = "propertiesControl";
            this.propertiesControl.SelectedIndex = 0;
            this.propertiesControl.Size = new System.Drawing.Size(523, 627);
            this.propertiesControl.TabIndex = 0;
            // 
            // general
            // 
            this.general.BackColor = System.Drawing.Color.Transparent;
            this.general.Controls.Add(this.browseGameFiles);
            this.general.Controls.Add(this.diskUsage);
            this.general.Controls.Add(this.label1);
            this.general.Controls.Add(this.uninstall);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(515, 601);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            // 
            // browseGameFiles
            // 
            this.browseGameFiles.Location = new System.Drawing.Point(47, 107);
            this.browseGameFiles.Name = "browseGameFiles";
            this.browseGameFiles.Size = new System.Drawing.Size(198, 23);
            this.browseGameFiles.TabIndex = 3;
            this.browseGameFiles.Text = "Browse game files";
            this.browseGameFiles.UseVisualStyleBackColor = true;
            this.browseGameFiles.Click += new System.EventHandler(this.browseGameFiles_Click);
            // 
            // diskUsage
            // 
            this.diskUsage.AutoSize = true;
            this.diskUsage.Location = new System.Drawing.Point(147, 9);
            this.diskUsage.Name = "diskUsage";
            this.diskUsage.Size = new System.Drawing.Size(44, 13);
            this.diskUsage.TabIndex = 2;
            this.diskUsage.Text = "0.00MB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disk Space Used:";
            // 
            // uninstall
            // 
            this.uninstall.Location = new System.Drawing.Point(47, 69);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(198, 23);
            this.uninstall.TabIndex = 0;
            this.uninstall.Text = "Uninstall";
            this.uninstall.UseVisualStyleBackColor = true;
            this.uninstall.Click += new System.EventHandler(this.uninstall_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(523, 627);
            this.Controls.Add(this.propertiesControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 666);
            this.MinimumSize = new System.Drawing.Size(539, 666);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.propertiesControl.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl propertiesControl;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseGameFiles;
        private System.Windows.Forms.Label diskUsage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uninstall;
    }
}