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
        //ボタンの数を決める
        private const int row = 3;
        private const int column = 9;
        private List<Button> buttons = new List<Button>();

        private DispatcherTimer tm1 = new DispatcherTimer();
        private DispatcherTimer tm2 = new DispatcherTimer();
        private Stopwatch sw = new Stopwatch();

        public MainWindow() {
            InitializeComponent();
            setButton(row,column);
        }

        private void setButton(int row,int column) {
            
            for(int i = 0; i < row; i++) {
                maingrid.RowDefinitions.Add(new RowDefinition());
            }
            for(int i = 0; i < column; i++) {
                maingrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for(int i = 0; i < row; i++) {
                for(int j = 0; j < column; j++) {
                    Button button = new Button();
                    button.Content = (column * i) + (j + 1); 
                    button.SetValue(Grid.RowProperty, i);
                    button.SetValue(Grid.ColumnProperty, j);
                    button.Click += button_Click;
                    maingrid.Children.Add(button);
                    buttons.Add(button);
                    
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e) {
            int btnum = int.Parse((string)((Button)sender).Content);

            if(rand == btnum) {
                hint.Text = "正解";
                ((Button)sender).Background = Brushes.Red;
                tm1.Stop();
                tm2.Stop();
                sw.Stop();
            }else if(rand > btnum) {
                hint.Text = "もっと大きい数字";
                ((Button)sender).Background = Brushes.Yellow;
            }
            else {
                hint.Text = "もっと小さい数字";
                ((Button)sender).Background = Brushes.Yellow;
            }
        }

        private void start_Click(object sender, RoutedEventArgs e) {
            rand = new Random().Next(1, row*column);
            StartTimer();
            time.Text = GetSWTime();

            foreach(var b in buttons) {
                b.Background = start.Background;
            }
        }

        private void StartTimer() {
            sw.Restart();

            tm1.Interval = new TimeSpan(0, 0, 10);
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
            return (tm1.Interval - sw.Elapsed).ToString(@"ss\:ff");
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tm1.Stop();
            tm2.Stop();
            sw.Stop();
            time.Text = new TimeSpan().ToString(@"ss\:ff");
            MessageBox.Show("時間切れ");
        }


    }
}
