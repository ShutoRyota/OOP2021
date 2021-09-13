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
        Dictionary<string, XElement> websitedic = new Dictionary<string, XElement>();
        

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                try {
                    var url = new Uri(tbUrl.Text);
                    wc.Headers.Add("Content-type", "charset=UTF-8");

                    var stream = wc.OpenRead(url);

                    XDocument xdoc = XDocument.Load(stream);
                    var items = xdoc.Root.Descendants("item").ToArray();

                    websitedic = items.ToDictionary(x => x.Element("title").Value);

                    lbTitles.Items.Clear();
                    foreach (var title in websitedic.Keys) {

                        lbTitles.Items.Add(title);
                    }
                    lbTitles.Enabled = true;
                }catch(Exception ex) {}
                

            }
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            try {
                var item = websitedic[lbTitles.SelectedItem?.ToString()];
                tbUpdateDate.Text = item.Element("pubDate").Value;
                lbdisc.Text = item.Element("description").Value;
            }catch(ArgumentNullException ane){ }
             
        }

        private void btWebDisp_Click(object sender, EventArgs e) {
            try {
                var item = websitedic[lbTitles.SelectedItem?.ToString()];
                Browser browser = new Browser();
                browser.Text = item.Element("title").Value;
                var url = new Uri(item.Element("link").Value);
                browser.wbBrowser.Url = url;
                browser.Show();
            }catch(ArgumentNullException ane) { }
        }
    }
}
