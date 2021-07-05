using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
        Timer tm = new Timer();
        public Form1() {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e) {           
            sw.Start();
            
            tm.Interval = 1;
            tm.Start();
            tm.Tick += Tm_Tick;
            
        }

        private void stop_Click(object sender, EventArgs e) {
            sw.Stop();
            tm.Stop();
        }

        private void Form1_Load(object sender, EventArgs e) {
            timeDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void Tm_Tick(object sender, EventArgs e) {
            timeDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void reset_Click(object sender, EventArgs e) {
            sw.Restart();
            rapDisp.Text = string.Empty;
            timeDisp.Text = sw.Elapsed.ToString(@"hh\.mm\.ss\.ff");
        }

        private void rap_Click(object sender, EventArgs e) {
            rapDisp.Text += sw.Elapsed.ToString(@"hh\:mm\:ss\:ff")+"\r\n";
        }
    }
}
