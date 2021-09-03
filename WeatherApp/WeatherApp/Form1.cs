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
        public Form1() {
            InitializeComponent();
        }

        private void btView_Click(object sender, EventArgs e) {
            int code = SelectArea();

            if (code != 0) {
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

        private int SelectArea() {
            string areaName = cbArea.Text;
            switch (areaName) {
                case "東京都": return 13;
                case "神奈川県": return 14;
                case "埼玉県": return 11;
                case "千葉県": return 12;
                case "茨城県": return 8;
                case "栃木県": return 9;
                case "群馬県": return 10;
                case "山梨県": return 19;

                default: return 0;
            }
        }
    }
}
