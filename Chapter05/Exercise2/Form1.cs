using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            outStrNum.Text = int.TryParse(inStrNum.Text, out int result) ? result.ToString("#,0") :
                                                                          "数値文字列ではありません";
            
        }
    }
}
