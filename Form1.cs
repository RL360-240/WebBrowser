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
using System.Security.Policy;
namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
        List<Sites> siteHistory = new List<Sites>();
        public WebBrowser()
        {
            InitializeComponent();
            loadHistory();
            searchHistoryListBx.Hide();
            deleteFromHistory.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string url = linkComboBox.Text;
            if (webWindow != null && webWindow.CoreWebView2 != null)
            {
                if (!(url.StartsWith("https://") || url.StartsWith("http://")))
                {
                    if (url.Contains(".")) url = "https://" + url;
                    else url = "https://duckduckgo.com/?ia=web&origin=funnel_home_searchresults&t=h_&q=" + url + "&chip-select=search";
                }
                webWindow.CoreWebView2.Navigate(url);

                if (!siteHistory.Exists(u => u.Url.Equals(url)))
                {
                    Sites site = new Sites(url, 1, DateTime.Now);
                    siteHistory.Add(site);
                }
                else 
                {
                    Sites preExistingSiteLog = siteHistory.Find(u => u.Url.Equals(url));
                    preExistingSiteLog.CallAmount += 1;
                    preExistingSiteLog.LastVisit = DateTime.Now;
                }
            }
            saveToHistory();
            updateHistoryData();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.Show();
            searchButton.Show();
            linkComboBox.Show();

            searchHistoryListBx.Hide();
            deleteFromHistory.Hide();
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

        private void saveToHistory() {
            FileStream stream = new FileStream("C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\History.txt", FileMode.Create
                , FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);



            foreach(Sites s in siteHistory)
            {
                string siteSaveformat = String.Format("{0};{1};{2}",
                    s.Url,
                    Convert.ToString(s.CallAmount),
                    Convert.ToString(s.LastVisit));

                writer.WriteLine(siteSaveformat);
            }
            writer.Close();
        }

        private void updateHistoryData() 
        {
            siteHistory.Sort((s1, s2) => s2.LastVisit.CompareTo(s1.LastVisit));

            linkComboBox.DataSource = null;
            linkComboBox.ValueMember = null;
            searchHistoryListBx.DataSource = null;
            searchHistoryListBx.ValueMember = null;

            linkComboBox.DataSource = siteHistory;
            linkComboBox.ValueMember = "Url";

            searchHistoryListBx.DataSource = siteHistory;
            searchHistoryListBx.ValueMember = "Url";

            linkComboBox.SelectedIndex = -1;

            saveToHistory();
        }

        private void loadHistory() 
        {
            FileStream stream = new FileStream("C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\History.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                string[] line = reader.ReadLine().Split(';');
                Sites site = new Sites(
                    line[0],
                    Convert.ToInt32(line[1]),
                    Convert.ToDateTime(line[2])
                    );

                siteHistory.Add(site);
            }
            reader.Close();
            updateHistoryData();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webWindow.Hide();
            searchButton.Hide();
            linkComboBox.Hide();

            searchHistoryListBx.DataSource = null;
            searchHistoryListBx.ValueMember = null;

            searchHistoryListBx.DataSource = siteHistory;
            searchHistoryListBx.ValueMember = "Url";

            searchHistoryListBx.Show();
            deleteFromHistory.Show();
        }

        private void deleteFromHistory_Click(object sender, EventArgs e)
        {
            foreach (Sites site in searchHistoryListBx.CheckedItems) 
            {
                siteHistory.RemoveAll(s => s.Url.Equals(site.Url));
            }
            updateHistoryData();
        }
    }
}
