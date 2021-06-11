using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            var yms = new YearMonth[] {new YearMonth(2000, 11), new YearMonth(2001, 12),
                                       new YearMonth(2002, 8), new YearMonth(2003, 9),
                                       new YearMonth(2004, 10), };

            // 2.2
            Exercise2_2(yms);
            Console.WriteLine();

            // 2.4
            Exercise2_4(yms);
            Console.WriteLine();

            //2.5
            Exercise2_5(yms);
            
        }

        private static void Exercise2_2(YearMonth[] yms) {
            foreach (var y in yms) {
                Console.WriteLine(y);
            }
        }

        //2.3 
        private static YearMonth Search21(YearMonth[] yms) {
            foreach (var y in yms) {
                if (y.Is21Century) {
                    return y;
                }
            }
            return null;
        }


        private static void Exercise2_4(YearMonth[] yms) {
            var year21c = Search21(yms);
            Console.WriteLine(year21c?.Year.ToString() ?? "２１世紀のデータはありません");
        }

        private static void Exercise2_5(YearMonth[] yms) {
            var query = yms.Select(y => y.AddOneMonth()).ToArray();

            foreach (var y in query) {
                Console.WriteLine(y);
            }
        }
        
    }
}
