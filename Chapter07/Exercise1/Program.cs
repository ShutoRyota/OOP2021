using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";

            #region ドライバ
            Exercise7_1_1(text);
            Console.WriteLine("-----");

            Exercise7_1_2(text);
            Console.WriteLine("-----");
            #endregion
        
        }

        private static void Exercise7_1_1(string text) {
            var dict = new Dictionary<char, int>();
            var textUp = text.ToUpper();
            foreach(var ch in textUp.ToCharArray()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch]++;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach(var result in dict.OrderBy(x => x.Key)) {
                Console.WriteLine($"{result.Key} : {result.Value}");
            }
        }

        private static void Exercise7_1_2(string text) {
            var dict = new SortedDictionary<char,int>();
            var textUp = text.ToUpper();
            foreach (var ch in textUp.ToCharArray()) {
                if ('A' <= ch && ch <= 'Z') {
                    if (dict.ContainsKey(ch)) {
                        dict[ch] += 1;
                    } else {
                        dict[ch] = 1;
                    }
                }
            }

            foreach (var result in dict) {
                Console.WriteLine($"{result.Key} : {result.Value}");
            }
        }
    }
}
