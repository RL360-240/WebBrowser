using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string url = linkComboBox.Text;
            if (webWindow != null && webWindow.CoreWebView2 != null)
            {
                if (url.StartsWith("https://") || url.StartsWith("http://")) webWindow.CoreWebView2.Navigate(url);
                else
                {
                    if (url.Contains(".")) webWindow.CoreWebView2.Navigate("https://" + url);
                    else webWindow.CoreWebView2.Navigate("https://www.google.com/search?q=" + url);
                }
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(webWindow != null && webWindow.CoreWebView2 != null) webWindow.CoreWebView2.Navigate("https://www.google.com");
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.GoForward();
        }

        private void WebBrowser_Resize(object sender, EventArgs e)
        {
            webWindow.Size = this.ClientSize - new System.Drawing.Size(webControls.Location);
            searchButton.Left = this.ClientSize.Width - searchButton.Width;
            linkComboBox.Width = searchButton.Left - linkComboBox.Left;
        }
    }
}
