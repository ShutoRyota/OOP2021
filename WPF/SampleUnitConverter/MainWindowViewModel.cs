using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel {
        private double metricValue;
        private double imperialValue;

        //▲ボタンで呼ばれるコマンド【ヤードからメートル】
        public ICommand ImperialUnitToMetric { get; private set; }
        //▼ボタンで呼ばれるコマンド【メートルからヤード】
        public ICommand MetricToImperialUnit { get; private set; }

        //上のComboBoxで選択されている値
        public MetricUnit CurrentMetricUnit { get; set; }
        //下のComboBoxで選択されている値
        public ImprialUnit CurrentImperialUnit { get; set; }

        public double MetricValue {
            get { return metricValue; }
            set { this.metricValue = value;
                this.OnPropertyChanged();　//Viewへ通知
            }
        }

        public double ImperialValue {
            get { return imperialValue; }
            set { this.imperialValue = value;
                this.OnPropertyChanged();　//Viewへ通知
            }
        }


        public MainWindowViewModel() {
            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImprialUnit.Units.First();

            this.MetricToImperialUnit = new DelegateCommand(
                () => this.ImperialValue = this.CurrentImperialUnit.FromMetriclUnit(
                                                this.CurrentMetricUnit, this.MetricValue));
            this.ImperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                                                this.CurrentImperialUnit, this.ImperialValue));
        }
    }
}
