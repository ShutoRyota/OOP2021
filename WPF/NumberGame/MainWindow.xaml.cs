using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        int rand = 0;
        DispatcherTimer tm1 = new DispatcherTimer();
        DispatcherTimer tm2 = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();

        public MainWindow() {
            InitializeComponent();
            setButton(5,5);
            StartTimer();
            time.Text = GetSWTime();
        }

        public void StartTimer() {
            sw.Start();
            tm1.Interval = new TimeSpan(0,0,5);
            tm1.Start();
            tm1.Tick += Tm_Tick;

            tm2.Interval = new TimeSpan(0, 0, 0, 0, 1);
            tm2.Start();
            tm2.Tick += Tm2_Tick;
        }

        private void Tm2_Tick(object sender, EventArgs e) {
            time.Text = GetSWTime();
        }

        private string GetSWTime() {
            return sw.Elapsed.ToString(@"ss\:ff");
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tm1.Stop();
            tm2.Stop();
            sw.Stop();
            MessageBox.Show("時間切れ");
            
            
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
                tm1.Stop();
                tm2.Stop();
                sw.Stop();
            }else if(rand > btnum) {
                hint.Text = "もっと大きい数字";
            }else {
                hint.Text = "もっと小さい数字";
            }
        }

    }
}
