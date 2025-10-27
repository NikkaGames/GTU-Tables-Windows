using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTU_Tables_Windows
{
    public partial class Form2 : Form
    {
        public string HtmlData { get; set; } = "";
        private bool isLoading = true;

        public Form2(string htmlData, string tableId)
        {
            HtmlData = htmlData;
            InitializeComponent();

            this.Text = $"Schedule table for {tableId}";
            this.BackColor = Color.FromArgb(18, 18, 18);
            this.WindowState = FormWindowState.Maximized;

            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            webBrowser.Navigating += WebBrowser_Navigating;
            webBrowser.ScrollBarsEnabled = true;
            webBrowser.DocumentText = HtmlData;
            ShowLoading(true);

            AnimateZoom();
        }

        private async void AnimateZoom()
        {
            float scale = 0.8f;
            while (scale < 1f)
            {
                webBrowser.Width = (int)(this.ClientSize.Width * scale);
                webBrowser.Height = (int)(this.ClientSize.Height * scale);
                webBrowser.Left = (this.ClientSize.Width - webBrowser.Width) / 2;
                webBrowser.Top = (this.ClientSize.Height - webBrowser.Height) / 2;
                scale += 0.02f;
                await Task.Delay(15);
            }
            webBrowser.Dock = DockStyle.Fill;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoading = false;
            ShowLoading(false);

            var doc = webBrowser.Document;
            if (doc?.Body != null)
            {
                doc.Body.Style = "margin:0; padding:0; width:100%; zoom:0.8;";
                var elements = doc.GetElementsByTagName("div");
                foreach (HtmlElement el in elements)
                {
                    var classAttr = el.GetAttribute("className");
                    if (classAttr == "center-div")
                    {
                        el.OuterHtml = "";
                    }
                }
            }

            try
            {
                int contentHeight = webBrowser.Document.Body.ScrollRectangle.Height;
                int contentWidth = webBrowser.Document.Body.ScrollRectangle.Width;

                int maxWidth = Screen.PrimaryScreen.WorkingArea.Width - 40;
                int maxHeight = Screen.PrimaryScreen.WorkingArea.Height - 40;

                webBrowser.Width = Math.Min(contentWidth + 20, maxWidth);
                webBrowser.Height = Math.Min(contentHeight + 20, maxHeight);

                this.ClientSize = new Size(webBrowser.Width, webBrowser.Height);

                webBrowser.Left = (this.ClientSize.Width - webBrowser.Width) / 2;
                webBrowser.Top = (this.ClientSize.Height - webBrowser.Height) / 2;

                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch { }
        }

        private void WebBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            var url = e.Url.ToString();
            if (url.StartsWith("tg:") || url.StartsWith("fb:"))
            {
                System.Diagnostics.Process.Start(url);
                e.Cancel = true;
            }
            else if (url.StartsWith("intent:") || url.StartsWith("sfbfi:"))
            {
                e.Cancel = true;
            }
        }

        private void ShowLoading(bool show)
        {
            loadingPanel.Visible = show;
            loadingPanel.BringToFront();
            loadingIndicator.Style = ProgressBarStyle.Marquee;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
                e.Cancel = true;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }
    }
}
