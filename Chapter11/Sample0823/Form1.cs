using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(int.TryParse(Value.Text,out int value) && int.TryParse(Jou.Text, out int jou)){
                int result=value;
                for(int i = 1; i < jou; i++)
                {
                    result *= value;
                }
                Result.Text = result.ToString();
            */

            if (int.TryParse(Value.Text, out int value) && int.TryParse(Jou.Text, out int jou)){
                int result = (int)Math.Pow(value, jou);
                Result.Text = result.ToString();
            }

            
        }
    }
}
