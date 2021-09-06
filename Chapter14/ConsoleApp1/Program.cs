using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        Dictionary<string, int> areas = new Dictionary<string, int>() {
            {"前橋", 4210},
            {"みなかみ",4220 },
            {"宇都宮",4110},
            {"水戸",4010},
        };
        List<int> cityCode = new List<int>();
        
        static void Main(string[] args) {
            new Program();

        }

        public Program() {
            int code = SelectArea();

            if (code != 0) {
                var result = GetWeatherReportFromYahoo(code);
                foreach (var s in result) {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }
        }
        //リスト14.15
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");

            Console.WriteLine(html);
        }
        //リスト14.17
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\rs32005\Pictures\Screenshots\スクリーンショット (10).png");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }
        //リスト14.18
        public void OpenReadSample() {
            var wc = new WebClient();
            using(var stream = wc.OpenRead(@"https://yahoo.co.jp"))
            using(var sr = new StreamReader(stream, Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
        }

        //リスト14.19
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
            var num = 1;
            Console.WriteLine("地域コードを入力");
            foreach(KeyValuePair<string,int> pair in areas) {
                Console.WriteLine($"{num++}:{pair.Key}");
                cityCode.Add(pair.Value);
            }         
            Console.WriteLine("9:その他");

            int areaCode = int.Parse(Console.ReadLine());
            if(areaCode == 9) {
                Console.WriteLine("コードを入力してください");
                return int.Parse(Console.ReadLine());
            }
            return cityCode[areaCode - 1];

        }

    }

}
