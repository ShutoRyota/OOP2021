using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public int rand = 0;
        Timer tm = new Timer();
        public MainWindow() {
            InitializeComponent();
            setButton(5,5);
            //Timer tm = new Timer();
            //tm.Start();
            

        }

        private void setButton(int row,int column) {
            
            int n = 1;
            for(int i = 0; i < column; i++) {
                for(int j = 0; j < row; j++) {
                    Button button = new Button();
                    button.Content = $"{n}";
                    button.SetValue(Grid.RowProperty, i);
                    button.SetValue(Grid.ColumnProperty, j);
                    button.Click += b1_Click;
                    maingrid.Children.Add(button);
                    n = ++n;
                }
            }


        }

        private void MainWindow_Click(object sender, RoutedEventArgs e) {
            throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            rand = new Random().Next(1, 26);
        }

        private void b1_Click(object sender, RoutedEventArgs e) {
            int btnum = int.Parse((string)((Button)sender).Content);

            if(rand == btnum) {
                hint.Text = "正解";
            }else if(rand > btnum) {
                hint.Text = "もっと大きい数字";
            }else {
                hint.Text = "もっと小さい数字";
            }
        }

    }
}
