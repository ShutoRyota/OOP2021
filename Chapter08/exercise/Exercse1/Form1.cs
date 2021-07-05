using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercse1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            tbDateDisp.Text = string.Format("{0:yyyy/M/d HH:mm}",today)+"\r\n" +
                                            today.ToString("yyyy年MM月dd日 HH時mm分ss秒")+"\r\n"+
                                            today.ToString("ggyy年 M月d日(dddd)",culture);
            //tbDateDisp.Text = today.ToString("d");
        }

        private void Form1_Load(object sender, EventArgs e) {

            tssTimeLabel.Text = DateTime.Now.ToString("T");
            var timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString("T");
        }
    }
}
