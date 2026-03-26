using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    internal class SitesSave
    {
        private static string directory = "C:\\Users\\user\\Desktop\\ProgamIII\\WebBrowser\\Historial.json";

        public static List<Sites> getSites() {
            List <Sites> siteList = new List<Sites>();

            if (File.Exists(directory))
            {
                string jsonString = File.ReadAllText(directory);

                siteList = JsonConvert.DeserializeObject<List<Sites>>(jsonString);
            }

            return siteList;
        }

        public static void setSites(List<Sites> sites) {
            string jsonStirng = JsonConvert.SerializeObject(sites);
            File.WriteAllText(directory , jsonStirng);
        }
    }
}
