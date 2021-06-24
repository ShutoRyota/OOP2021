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
            inputStringText.Text = "Jackdaws love my big sphinx of quartz";
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
            var sb = new StringBuilder();
            foreach(string s in words) {
                sb.Append(s);
                sb.Append(" ");
            }

            textBox535.Text = sb.ToString().Trim();

        }

        private void button54_Click(object sender, EventArgs e) {
            var plof = inputText2.Text.Split(';').Select(s => s.Substring(s.IndexOf('=') + 1)).ToArray();

            textBox54_1.Text = $"作家　：{plof[0]}\r\n代表作：{plof[1]}\r\n誕生年：{plof[2]}";

        }
    }
}
