using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdOpen2.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadLines(ofdOpen2.FileName);

                if (ofdOpen1.ShowDialog() == DialogResult.OK) {
                    using (var writer = new StreamWriter(ofdOpen1.FileName, append: true)) {
                        foreach (var line in lines) {
                            writer.WriteLine(line);

                        }
                    }

                }
            }

        }


    }
    
}
