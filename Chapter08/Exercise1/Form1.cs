using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            var date = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            var today = DateTime.Now;

            var diff = today.Date - date.Date;

            tbOutput.Text = diff.TotalSeconds > 0 ? $"今日まで{diff.Days}日経過している" :
                                                                            $"今日からあと{-diff.Days}日";


            

            tbLeap.Text = DateTime.IsLeapYear(date.Year) ? "閏年" : "閏年でない";

        }
    }
}
