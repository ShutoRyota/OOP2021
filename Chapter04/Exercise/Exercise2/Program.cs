using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            var yms = new YearMonth[] {new YearMonth(2000,1), new YearMonth(2001, 2),
                                       new YearMonth(2002, 12), new YearMonth(2003, 4),new YearMonth(2004, 5), };

            // 2.2
            foreach(var y in yms) {
                Console.WriteLine(y);
            }

            Console.WriteLine();

            // 2.4
            var year21 = Search21(yms);
            Console.WriteLine(year21?.ToString());

            Console.WriteLine();

            //2.5
            var query = yms.ToList().Select(y => y.AddOneMonth()).ToArray() ;

            foreach (var y in query) {
                Console.WriteLine(y);
            }
        }

        //2.3
        public static YearMonth Search21(YearMonth[] yms) {
            foreach (var y in yms) {
                if (y.Is21Century) {
                    return y;
                }

            }
            return null;
        }
    }
}
