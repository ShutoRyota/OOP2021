using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        Dictionary<string, string> websitedic = new Dictionary<string, string>();

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                var url = new Uri(tbUrl.Text);
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(url);

                XDocument xdoc =  XDocument.Load(stream);
                var titles = xdoc.Root.Descendants("title").ToArray() ;
                var links = xdoc.Root.Descendants("link").ToArray();

                for(int i= 0; i < titles.Length; i++) {
                    websitedic.Add(titles[i].Value, links[i].Value);
                }

                lbTitles.Items.Clear();
                foreach(var title in websitedic) { 
                    
                    lbTitles.Items.Add(title.Key);
                }

            }
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            if (websitedic.TryGetValue(lbTitles.SelectedItem.ToString(), out string urlstring)){
                var url = new Uri(urlstring);
                wbBrowser.Url = url;
            }
            
            
            
        }
    }
}
