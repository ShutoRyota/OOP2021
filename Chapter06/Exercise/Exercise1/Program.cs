using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbaers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };
            #region driver
            Exercise6_1_1(numbaers);
            Console.WriteLine("-----");

            Exercise6_1_2(numbaers);
            Console.WriteLine("-----");

            Exercise6_1_3(numbaers);
            Console.WriteLine("-----");

            Exercise6_1_4(numbaers);
            Console.WriteLine("-----");

            Exercise6_1_5(numbaers);
            Console.WriteLine("-----");
            #endregion
        }

        private static void Exercise6_1_1(int[] numbaers) {
            Console.WriteLine(numbaers.Max());
        }

        private static void Exercise6_1_2(int[] numbaers) {
            var num = numbaers.Reverse().Take(2);
            foreach(var n in num) {
                Console.WriteLine(n);
            }
            
        }

        private static void Exercise6_1_3(int[] numbaers) {
            var numString = numbaers.Select(n => n.ToString());

            foreach(var s in numString) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise6_1_4(int[] numbaers) {
            var minNum = numbaers.OrderBy(n => n).Take(3);
            foreach(var n in minNum) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise6_1_5(int[] numbaers) {
            Console.WriteLine(numbaers.Distinct().Count(n => n > 10));
        }       
    }
}
