using System.Windows.Forms;

namespace CKPLLauncher
{
    partial class CKPLLauncher
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
            this.gamesList = new System.Windows.Forms.ListBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.gameName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.launchGame = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.downloadProgress = new CustomProgressBar();
            this.launchWarning = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesList.FormattingEnabled = true;
            this.gamesList.Location = new System.Drawing.Point(0, 84);
            this.gamesList.MaximumSize = new System.Drawing.Size(242, 4000);
            this.gamesList.MinimumSize = new System.Drawing.Size(242, 550);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(242, 550);
            this.gamesList.TabIndex = 0;
            this.gamesList.DrawMode = DrawMode.OwnerDrawFixed;
            this.gamesList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.gamesList_DrawItem);
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(0, 65);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(242, 20);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gameName.Location = new System.Drawing.Point(541, 65);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(152, 25);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "CKPL Launcher";
            this.gameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developers.Location = new System.Drawing.Point(625, 97);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(114, 16);
            this.Developers.TabIndex = 5;
            this.Developers.Text = "CKPL productions";
            this.Developers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(605, 115);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(25, 16);
            this.Version.TabIndex = 6;
            this.Version.Text = "0.0";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // launchGame
            // 
            this.launchGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.launchGame.FlatAppearance.BorderSize = 0;
            this.launchGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchGame.ForeColor = System.Drawing.Color.White;
            this.launchGame.Location = new System.Drawing.Point(788, 75);
            this.launchGame.Name = "launchGame";
            this.launchGame.Size = new System.Drawing.Size(217, 48);
            this.launchGame.TabIndex = 8;
            this.launchGame.Text = "Launch";
            this.launchGame.UseVisualStyleBackColor = false;
            this.launchGame.Click += new System.EventHandler(this.launchGame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceCodeToolStripMenuItem,
            this.projectFilesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(1061, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(117, 54);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.sourceCodeToolStripMenuItem.Text = "Source code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // projectFilesToolStripMenuItem
            // 
            this.projectFilesToolStripMenuItem.Name = "projectFilesToolStripMenuItem";
            this.projectFilesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.projectFilesToolStripMenuItem.Text = "Project Files";
            this.projectFilesToolStripMenuItem.Click += new System.EventHandler(this.projectFilesToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(543, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.AutoEllipsis = true;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.desc.Location = new System.Drawing.Point(543, 164);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(484, 332);
            this.desc.TabIndex = 11;
            this.desc.Text = "0.0";
            // 
            // downloadProgress
            // 
            this.downloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgress.Location = new System.Drawing.Point(248, 526);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(924, 30);
            this.downloadProgress.Step = 1;
            this.downloadProgress.TabIndex = 12;
            // 
            // launchWarning
            // 
            this.launchWarning.AutoSize = true;
            this.launchWarning.Location = new System.Drawing.Point(785, 127);
            this.launchWarning.Name = "launchWarning";
            this.launchWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.launchWarning.Size = new System.Drawing.Size(86, 13);
            this.launchWarning.TabIndex = 14;
            this.launchWarning.Text = "Launch Warning";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Settings.BackgroundImage = global::CKPLLauncher.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(1004, 75);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(48, 48);
            this.Settings.TabIndex = 15;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // gameImage
            // 
            this.gameImage.Location = new System.Drawing.Point(249, 65);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(288, 432);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImage.TabIndex = 7;
            this.gameImage.TabStop = false;
            // 
            // downloadLabel
            // 
            this.downloadLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.downloadLabel.Location = new System.Drawing.Point(249, 500);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(923, 20);
            this.downloadLabel.TabIndex = 13;
            this.downloadLabel.Text = "Downloads";
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CKPLLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.launchWarning);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.downloadProgress);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.launchGame);
            this.Controls.Add(this.gameImage);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.gamesList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "CKPLLauncher";
            this.Text = "CKPL Launcher";
            this.Load += new System.EventHandler(this.CKPLLauncher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox gamesList;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.Button launchGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectFilesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Label launchWarning;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label downloadLabel;
    }
}

