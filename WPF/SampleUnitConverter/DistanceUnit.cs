using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class DistanceUnit {
        public string Name { get; set; }
        public double Coefficient { get; set; }
        public override string ToString() {
            return this.Name;
        }


    }

    public class MetricUnit : DistanceUnit {

        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name="mm",Coefficient=1},
            new MetricUnit{Name="cm",Coefficient=10},
            new MetricUnit{Name="m",Coefficient=10*100},
            new MetricUnit{Name="km",Coefficient=10*100*1000},
        };
        public static ICollection<MetricUnit> Units { get { return units; } }

        /// <summary>
        /// ヤードからメートル
        /// </summary>
        /// <param name="unit">単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromImperialUnit(ImprialUnit unit,double value) {
            return (value * unit.Coefficient) * 25.4 / this.Coefficient;
        }
    }


    public class ImprialUnit : DistanceUnit {
        private static List<ImprialUnit> units = new List<ImprialUnit> {
            new ImprialUnit{Name="in",Coefficient=1},
            new ImprialUnit{Name="ft",Coefficient=12},
            new ImprialUnit{Name="yd",Coefficient=12*3},
            new ImprialUnit{Name="ml",Coefficient=12*3*1760},
        };
        public static ICollection<ImprialUnit> Units { get { return units; } }

        /// <summary>
        /// メートルからヤード
        /// </summary>
        /// <param name="unit">単位</param>
        /// <param name="value">係数</param>
        /// <returns></returns>
        public double FromMetriclUnit(MetricUnit unit, double value) {
            return (value * unit.Coefficient) / 25.4 / this.Coefficient;
        }
    }

}
