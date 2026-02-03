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
using System.IO;
namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
            loadHistory();
            searchHistoryTxt.Hide();
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
                    else webWindow.CoreWebView2.Navigate("https://duckduckgo.com/?ia=web&origin=funnel_home_searchresults&t=h_&q=" + url + "&chip-select=search");
                }
                if (!linkComboBox.Items.Contains(url))
                {
                    linkComboBox.Items.Add(url);
                    saveToHistory(url);
                }
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.Show();
            searchButton.Show();
            linkComboBox.Show();

            searchHistoryTxt.Hide();
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
            webWindow.Size = this.ClientSize - new System.Drawing.Size(webControls.Location.X + 20, webControls.Location.Y + 50);
            searchButton.Left = this.ClientSize.Width - searchButton.Width - 10;
            linkComboBox.Width = searchButton.Left - linkComboBox.Left;
        }

        private void saveToHistory(string savedString) {
            FileStream stream = new FileStream("C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\History.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(savedString);
            writer.Close();
        }

        private void loadHistory() 
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = "C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
                FileStream stream = new FileStream("C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\History.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    linkComboBox.Items.Add(reader.ReadLine());
                }
                reader.Close();
            //}
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.Hide();
            searchButton.Hide();
            linkComboBox.Hide();

            searchHistoryTxt.Show();

            FileStream stream = new FileStream("C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\History.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                searchHistoryTxt.Text += reader.ReadLine() + "\n";
            }
            reader.Close();
        }
    }
}
