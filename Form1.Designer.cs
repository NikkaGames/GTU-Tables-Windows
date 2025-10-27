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
            this.titleLabel = new System.Windows.Forms.Label();
            this.queryTextBox = new System.Windows.Forms.TextBox();
            this.saveCheckbox = new System.Windows.Forms.CheckBox();
            this.fetchButton = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
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
            this.queryTextBox.KeyDown += QueryTextBox_KeyDown;
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
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(564, 401);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.queryTextBox);
            this.Controls.Add(this.saveCheckbox);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.loadingLabel);
            this.Name = "Form1";
            this.Text = "GTU Table Fetcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
