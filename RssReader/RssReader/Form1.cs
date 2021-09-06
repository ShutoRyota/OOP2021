using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                var url = new Uri(tbUrl.Text);
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(url);

                XDocument xdoc =  XDocument.Load(stream);
                var titles = xdoc.Root.Descendants("title");
                
                foreach(var title in titles) {
                    lbTitles.Items.Add(title.Value);
                }
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
