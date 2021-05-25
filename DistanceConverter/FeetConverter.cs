using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class FeetConverter {

        //メートルからフィート
        public double MeterToFeet(double meter) {
            return meter / 0.3048;
        }

        //フィートからメートルを求める
        public double FeetToMeter(double feet) {
            return feet * 0.3048;
        }

    }

        
}
