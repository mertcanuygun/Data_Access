namespace Dapper_MusicDb.UserInterface
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.songPageCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songPageUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songPageDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songPageCreateToolStripMenuItem,
            this.songPageUpdateToolStripMenuItem,
            this.songPageDeleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // songPageCreateToolStripMenuItem
            // 
            this.songPageCreateToolStripMenuItem.Name = "songPageCreateToolStripMenuItem";
            this.songPageCreateToolStripMenuItem.Size = new System.Drawing.Size(209, 38);
            this.songPageCreateToolStripMenuItem.Text = "SongPageCreate";
            this.songPageCreateToolStripMenuItem.Click += new System.EventHandler(this.songPageCreateToolStripMenuItem_Click);
            // 
            // songPageUpdateToolStripMenuItem
            // 
            this.songPageUpdateToolStripMenuItem.Name = "songPageUpdateToolStripMenuItem";
            this.songPageUpdateToolStripMenuItem.Size = new System.Drawing.Size(217, 38);
            this.songPageUpdateToolStripMenuItem.Text = "SongPageUpdate";
            this.songPageUpdateToolStripMenuItem.Click += new System.EventHandler(this.songPageUpdateToolStripMenuItem_Click);
            // 
            // songPageDeleteToolStripMenuItem
            // 
            this.songPageDeleteToolStripMenuItem.Name = "songPageDeleteToolStripMenuItem";
            this.songPageDeleteToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.songPageDeleteToolStripMenuItem.Text = "SongPageDelete";
            this.songPageDeleteToolStripMenuItem.Click += new System.EventHandler(this.songPageDeleteToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 581);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem songPageCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songPageUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songPageDeleteToolStripMenuItem;
    }
}