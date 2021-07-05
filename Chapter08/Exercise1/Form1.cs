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
            var date = dTP1.Value;
            var today = DateTime.Now;
            
            tbOutput.Text = GetAge(date,today).ToString();

            tbLeap.Text = DateTime.IsLeapYear(date.Year) ? "閏年" : "閏年でない";

        }

        public int GetAge(DateTime birthday,DateTime target) {
            var age = target.Year - birthday.Year;


            if (target < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
