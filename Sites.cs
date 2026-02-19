using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    internal class Sites
    {
        string url;
        int callAmount;
        DateTime lastVisit;

        public Sites(string url, int callAmount, DateTime lastVisit) {
            this.url = url;
            this.callAmount = callAmount;
            this.lastVisit = lastVisit;
        }

        public string Url { get => url; set => url = value; }
        public int CallAmount { get => callAmount; set => callAmount = value; }
        public DateTime LastVisit { get => lastVisit; set => lastVisit = value; }
    }
}
