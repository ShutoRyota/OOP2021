using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            inputStringText.Text= "Jackdaws love my big sphinx of quartz";
            inputText2.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void button531_Click(object sender, EventArgs e) {
            textBox531.Text = inputStringText.Text.Count(c => c == ' ').ToString();
            
        }

        private void button532_Click(object sender, EventArgs e) {

            try {
                textBox532_3.Text = inputStringText.Text.Replace(textBox532_1.Text, textBox532_2.Text);
            } catch (ArgumentException) {
                textBox532_3.Text = "何も入力されていません";
            }

        }

        private void button533_Click(object sender, EventArgs e) {
            textBox533.Text = inputStringText.Text.Split(' ').Length.ToString();
        }

        private void button534_Click(object sender, EventArgs e) {
            var words = inputStringText.Text.Split(' ').Where(s => s.Length <= 4);

            foreach(var s in words) {
                textBox534.Text += $"{s} ";
            }
        }

        private void button535_Click(object sender, EventArgs e) {
            var words = inputStringText.Text.Split(' ');
            var sb = new StringBuilder(words[0]);
            foreach(string s in words.Skip(1)) {
                sb.Append(' ');
                sb.Append(s);
            }

            textBox535.Text = sb.ToString();

        }

        private void button54_Click(object sender, EventArgs e) {
            var prof = inputText2.Text.Split(';').Select(s => s.Split('=')).ToArray();

            textBox54_1.Text = $"{ToJap(prof[0][0])}   ： {prof[0][1]}\r\n" +
                               $"{ToJap(prof[1][0])}： {prof[1][1]}\r\n" +
                               $"{ToJap(prof[2][0])}： {prof[2][1]}";


        }

        private string ToJap(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";

                default:
                    throw new ArgumentException("引数が正しくない");
            }
        }
    }
}