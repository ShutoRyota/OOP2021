using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    static class InchConverter {

        private const double ratio = 0.0254;

        public static double MeterToInch(double meter) {
            return meter /ratio;
        }
        
        public static double InchToMeter(double inch) {
            return inch * ratio;
        }
    }
}
