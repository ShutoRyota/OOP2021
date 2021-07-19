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

namespace Exercise2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btOutput_Click(object sender, EventArgs e) {
            if (ofdOpen.ShowDialog() == DialogResult.OK) {
                var lines = File.ReadAllLines(ofdOpen.FileName);
                lines.Select((s, ix) => string.Format($"{ix + 1} {s}"));

                if(sfdSave.ShowDialog() == DialogResult.OK) {
                    File.WriteAllLines(sfdSave.FileName, lines);
                }
            }
        }
    }
}
