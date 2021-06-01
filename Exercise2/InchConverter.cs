using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    static class InchConverter {

        public static void PrintResult(int start,int stop) {
            for(int i = start; i <= stop; i++) {
                Console.WriteLine("{0}m = {1:0.0000}in",i,MeterToInch(i));
            }
        }

        public static double MeterToInch(double meter) {
            double inch = meter * 0.0245;

            return inch;
        }
    }
}
