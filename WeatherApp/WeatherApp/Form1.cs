using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WeatherApp {
    public partial class Form1 : Form {
        Dictionary<string, int> areas;
        public Form1() {
            InitializeComponent();
            areas = new Dictionary<string, int>() {
            {"東京都",13 },
            {"神奈川県",14 },
            {"埼玉県",11 },
            {"千葉県",12},
            {"茨城県" ,8},
            {"栃木県",9 },
            {"群馬県",10},
            {"山梨県",19}
        };
        }

        private void btView_Click(object sender, EventArgs e) {
            

            if (areas.TryGetValue(cbArea.Text,out int code)) {
                var result = GetWeatherReportFromYahoo(code);
                tbresult.Text = string.Empty;
                foreach (var s in result) {
                    tbresult.Text += s + "\r\n";
                }
            }
        }

        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }

       
    }
}
