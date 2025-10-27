using System.Drawing;
using System.Windows.Forms;

namespace GTU_Tables_Windows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox queryTextBox;
        private System.Windows.Forms.CheckBox saveCheckbox;
        private System.Windows.Forms.Button fetchButton;
        private System.Windows.Forms.Label loadingLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.saveCheckbox = new System.Windows.Forms.CheckBox();
            this.fetchButton = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.Telegram = new System.Windows.Forms.LinkLabel();
            this.Facebook = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Instagram = new System.Windows.Forms.LinkLabel();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(167, 130);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "GTU Table Fetcher";
            // 
            // queryTextBox
            // 
            this.queryTextBox.ForeColor = System.Drawing.Color.Black;
            this.queryTextBox.Location = new System.Drawing.Point(146, 189);
            this.queryTextBox.Name = "queryTextBox";
            this.queryTextBox.Size = new System.Drawing.Size(300, 20);
            this.queryTextBox.TabIndex = 1;
            this.queryTextBox.TextChanged += new System.EventHandler(this.queryTextBox_TextChanged);
            // 
            // saveCheckbox
            // 
            this.saveCheckbox.ForeColor = System.Drawing.Color.White;
            this.saveCheckbox.Location = new System.Drawing.Point(146, 215);
            this.saveCheckbox.Name = "saveCheckbox";
            this.saveCheckbox.Size = new System.Drawing.Size(104, 24);
            this.saveCheckbox.TabIndex = 2;
            this.saveCheckbox.Text = "Save Group ID";
            // 
            // fetchButton
            // 
            this.fetchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.fetchButton.FlatAppearance.BorderSize = 0;
            this.fetchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchButton.ForeColor = System.Drawing.Color.White;
            this.fetchButton.Location = new System.Drawing.Point(250, 245);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(75, 23);
            this.fetchButton.TabIndex = 3;
            this.fetchButton.Text = "Fetch";
            this.fetchButton.UseVisualStyleBackColor = false;
            this.fetchButton.Click += new System.EventHandler(this.fetchButton_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.ForeColor = System.Drawing.Color.Cyan;
            this.loadingLabel.Location = new System.Drawing.Point(263, 295);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(100, 23);
            this.loadingLabel.TabIndex = 4;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.Visible = false;
            // 
            // Telegram
            // 
            this.Telegram.AutoSize = true;
            this.Telegram.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Telegram.Location = new System.Drawing.Point(84, 376);
            this.Telegram.Name = "Telegram";
            this.Telegram.Size = new System.Drawing.Size(51, 13);
            this.Telegram.TabIndex = 5;
            this.Telegram.TabStop = true;
            this.Telegram.Text = "Telegram";
            this.Telegram.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // Facebook
            // 
            this.Facebook.AutoSize = true;
            this.Facebook.LinkColor = System.Drawing.Color.RoyalBlue;
            this.Facebook.Location = new System.Drawing.Point(141, 376);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(55, 13);
            this.Facebook.TabIndex = 6;
            this.Facebook.TabStop = true;
            this.Facebook.Text = "Facebook";
            this.Facebook.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "App Creator:";
            // 
            // Instagram
            // 
            this.Instagram.AutoSize = true;
            this.Instagram.LinkColor = System.Drawing.Color.Magenta;
            this.Instagram.Location = new System.Drawing.Point(202, 376);
            this.Instagram.Name = "Instagram";
            this.Instagram.Size = new System.Drawing.Size(53, 13);
            this.Instagram.TabIndex = 8;
            this.Instagram.TabStop = true;
            this.Instagram.Text = "Instagram";
            this.Instagram.VisitedLinkColor = System.Drawing.Color.Magenta;
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.LinkColor = System.Drawing.Color.LightGray;
            this.Github.Location = new System.Drawing.Point(261, 376);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(38, 13);
            this.Github.TabIndex = 9;
            this.Github.TabStop = true;
            this.Github.Text = "Github";
            this.Github.VisitedLinkColor = System.Drawing.Color.LightGray;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(564, 401);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Instagram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Facebook);
            this.Controls.Add(this.Telegram);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.saveCheckbox);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.loadingLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GTU Table Fetcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private LinkLabel Telegram;
        private LinkLabel Facebook;
        private Label label1;
        private LinkLabel Instagram;
        private LinkLabel Github;
    }
}
