using System.Drawing;
using System.Windows.Forms;

namespace CKPLLauncher
{
    class CustomProgressBar : ProgressBar
    {
        public Brush brush = Brushes.CornflowerBlue;

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }

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
        /// 
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
            this.launchWarning = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.maximiseButton = new System.Windows.Forms.Button();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gamesList
            // 
            this.gamesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesList.BackColor = System.Drawing.SystemColors.Control;
            this.gamesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamesList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gamesList.FormattingEnabled = true;
            this.gamesList.Location = new System.Drawing.Point(0, 51);
            this.gamesList.MaximumSize = new System.Drawing.Size(242, 4000);
            this.gamesList.MinimumSize = new System.Drawing.Size(242, 550);
            this.gamesList.Name = "gamesList";
            this.gamesList.Size = new System.Drawing.Size(242, 546);
            this.gamesList.TabIndex = 0;
            this.gamesList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.gamesList_DrawItem);
            this.gamesList.SelectedIndexChanged += new System.EventHandler(this.gamesList_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(0, 32);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(242, 20);
            this.SearchBar.TabIndex = 1;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.gameName.Location = new System.Drawing.Point(566, 32);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(152, 25);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "CKPL Launcher";
            this.gameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Developers
            // 
            this.Developers.AutoSize = true;
            this.Developers.BackColor = System.Drawing.Color.Transparent;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developers.Location = new System.Drawing.Point(650, 64);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(114, 16);
            this.Developers.TabIndex = 5;
            this.Developers.Text = "CKPL productions";
            this.Developers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.BackColor = System.Drawing.SystemColors.Control;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.Location = new System.Drawing.Point(630, 82);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(25, 16);
            this.Version.TabIndex = 6;
            this.Version.Text = "0.0";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // launchGame
            // 
            this.launchGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.launchGame.FlatAppearance.BorderSize = 0;
            this.launchGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchGame.ForeColor = System.Drawing.Color.White;
            this.launchGame.Location = new System.Drawing.Point(819, 42);
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
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceCodeToolStripMenuItem,
            this.projectFilesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(1090, 32);
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
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 115);
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
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.desc.Location = new System.Drawing.Point(568, 131);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(511, 369);
            this.desc.TabIndex = 11;
            this.desc.Text = "0.0";
            // 
            // launchWarning
            // 
            this.launchWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.launchWarning.AutoSize = true;
            this.launchWarning.BackColor = System.Drawing.Color.Transparent;
            this.launchWarning.Location = new System.Drawing.Point(816, 94);
            this.launchWarning.Name = "launchWarning";
            this.launchWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.launchWarning.Size = new System.Drawing.Size(86, 13);
            this.launchWarning.TabIndex = 14;
            this.launchWarning.Text = "Launch Warning";
            // 
            // downloadLabel
            // 
            this.downloadLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.downloadLabel.BackColor = System.Drawing.Color.Transparent;
            this.downloadLabel.Location = new System.Drawing.Point(257, 529);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(939, 20);
            this.downloadLabel.TabIndex = 13;
            this.downloadLabel.Text = "Downloads";
            this.downloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(1190, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 24);
            this.closeButton.TabIndex = 16;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maximiseButton
            // 
            this.maximiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximiseButton.BackColor = System.Drawing.SystemColors.Control;
            this.maximiseButton.Location = new System.Drawing.Point(1163, 2);
            this.maximiseButton.Name = "maximiseButton";
            this.maximiseButton.Size = new System.Drawing.Size(24, 24);
            this.maximiseButton.TabIndex = 17;
            this.maximiseButton.UseVisualStyleBackColor = false;
            this.maximiseButton.Click += new System.EventHandler(this.maximiseButton_Click);
            // 
            // minimiseButton
            // 
            this.minimiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimiseButton.BackColor = System.Drawing.SystemColors.Control;
            this.minimiseButton.Location = new System.Drawing.Point(1136, 2);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(24, 24);
            this.minimiseButton.TabIndex = 18;
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Settings.BackgroundImage = global::CKPLLauncher.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(1035, 42);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(48, 48);
            this.Settings.TabIndex = 15;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // gameImage
            // 
            this.gameImage.BackColor = System.Drawing.Color.Transparent;
            this.gameImage.Location = new System.Drawing.Point(249, 32);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(312, 468);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameImage.TabIndex = 7;
            this.gameImage.TabStop = false;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadProgress.Location = new System.Drawing.Point(248, 555);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(956, 30);
            this.downloadProgress.Step = 1;
            this.downloadProgress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(0, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1130, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "CKPL Launcher";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CKPLLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minimiseButton);
            this.Controls.Add(this.maximiseButton);
            this.Controls.Add(this.closeButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(1216, 600);
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
        private System.Windows.Forms.Label launchWarning;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label downloadLabel;
        private Button closeButton;
        private Button maximiseButton;
        private Button minimiseButton;
        private ProgressBar downloadProgress;
        private Label label4;
    }
}

