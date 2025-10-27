using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTU_Tables_Windows
{
    public partial class Form1 : Form
    {
        private Preferences prefs;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.AcceptButton = this.fetchButton;
            prefs = new Preferences("TablePrefs.json");

            this.Telegram.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://t.me/s/NikkaGamesOfficial",
                    UseShellExecute = true
                });
            };
            this.Facebook.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://facebook.com/sunflower.thrust",
                    UseShellExecute = true
                });
            };
            this.Instagram.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/pmicdxe",
                    UseShellExecute = true
                });
            };
            this.Github.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/NikkaGames",
                    UseShellExecute = true
                });
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveCheckbox.Checked = prefs.GetBool("checkbox", true);
            if (prefs.GetBool("checkbox", true))
            {
                queryTextBox.Text = prefs.GetString("table_id", "");
            }

            fetchButton.Enabled = !string.IsNullOrEmpty(queryTextBox.Text);
        }

        private async void fetchButton_Click(object sender, EventArgs e)
        {
            loadingLabel.Visible = true;
            fetchButton.Enabled = false;

            string query = queryTextBox.Text;
            bool save = saveCheckbox.Checked;
            prefs.PutBool("checkbox", save);

            if (!Utils.IsInternetAvailable())
            {
                MessageBox.Show("No Internet Connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadingLabel.Visible = false;
                fetchButton.Enabled = true;
                return;
            }

            try
            {
                string data = await Task.Run(() => Utils.SendAndReceiveAsync(query));
                if (data == "NOT_FOUND")
                {
                    MessageBox.Show($"Table {query} not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //MessageBox.Show($"Table {query} found!", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (save)
                        prefs.PutString("table_id", query);
                    new Form2(data, query).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadingLabel.Visible = false;
            fetchButton.Enabled = true;
        }

        private void queryTextBox_TextChanged(object sender, EventArgs e)
        {
            fetchButton.Enabled = !string.IsNullOrEmpty(queryTextBox.Text);
        }
    }
}
