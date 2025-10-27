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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingIndicator = new System.Windows.Forms.ProgressBar();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.loadingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.loadingIndicator.Location = new System.Drawing.Point(0, 0);
            this.loadingIndicator.MarqueeAnimationSpeed = 30;
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.Size = new System.Drawing.Size(200, 30);
            this.loadingIndicator.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingIndicator.TabIndex = 0;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.loadingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.loadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
