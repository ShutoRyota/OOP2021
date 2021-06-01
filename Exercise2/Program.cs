using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-toi") {
                PrintMeterToInchList(1, 10);
            } else {
                PrintInchToMeterList(1, 10);
            }
        }


        public static void PrintMeterToInchList(int start, int stop) {
            for (int i = start; i <= stop; i++) {
                Console.WriteLine("{0}m = {1:0.0000}in", i, InchConverter.MeterToInch(i));
            }
        }
        
        public static void PrintInchToMeterList(int start, int stop) {
            for (int i = start; i <= stop; i++) {
                Console.WriteLine("{0}in = {1:0.0000}m", i, InchConverter.InchToMeter(i));
            }
        }
    }
}
