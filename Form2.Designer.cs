using System.Drawing;
using System.Windows.Forms;

namespace GTU_Tables_Windows
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private WebBrowser webBrowser;
        private Panel loadingPanel;
        private ProgressBar loadingIndicator;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingIndicator = new System.Windows.Forms.ProgressBar();

            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 450);
            this.webBrowser.TabIndex = 0;

            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = Color.FromArgb(100, 0, 0, 0); // semi-transparent overlay
            this.loadingPanel.Controls.Add(this.loadingIndicator);
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(800, 450);
            this.loadingPanel.TabIndex = 1;
            this.loadingPanel.Visible = false;

            // 
            // loadingIndicator
            // 
            this.loadingIndicator.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingIndicator.MarqueeAnimationSpeed = 30;
            this.loadingIndicator.Size = new System.Drawing.Size(200, 30);
            this.loadingIndicator.Location = new System.Drawing.Point((800 - 200) / 2, (450 - 30) / 2);

            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.loadingPanel);
            this.Name = "Form2";
            this.ResumeLayout(false);
        }
    }
}
