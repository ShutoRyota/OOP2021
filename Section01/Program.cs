using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {              

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            var names = new List<string> {
                    "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            // 3.1.1
            //Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            //Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            //Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            //Exercise1_4(numbers);
            Console.WriteLine("-----");

            // 3.2.1
           // Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            //Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            //Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            //Exercise2_4(names);
            Console.WriteLine("-----");

            //ex
            Exercise3_1(names);
            Console.WriteLine("-----");

            Exercise3_2();
        }

        private static void Exercise3_2() {

            List<string> lines = new List<string>();
            Console.WriteLine("文字列を１０入力");
            for (int i = 0; i < 10; i++) {

                lines.Add(Console.ReadLine());
            }
            Console.WriteLine("処理を選択\n１．小文字のカウント\n２．大文字のカウント\n３．数字のカウント");

            int sum = 0;
            switch (int.Parse(Console.ReadLine())) {
                case 1:
                    for (int i = 0; i < lines.Count; i++) {
                        var count = lines[i].ToCharArray().Count(c => char.IsLower(c));
                        sum += count;
                    } break;
                case 2:
                    for (int i = 0; i < lines.Count; i++) {
                        var count = lines[i].ToCharArray().Count(c => char.IsUpper(c));
                        sum += count;
                    }
                    break;
                case 3:
                    for (int i = 0; i < lines.Count; i++) {
                        var count = lines[i].ToCharArray().Count(c => char.IsNumber(c));
                        sum += count;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine(sum);

        }
        
        private static void Exercise3_1(List<string> names) {
            int sum = 0;
            for (int i = 0; i < names.Count; i++) {
                var count = names[i].ToCharArray().Count(c => char.IsLower(c));
                sum += count;
            }
            Console.WriteLine(sum);
        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exists) {
                Console.WriteLine("ある");
            } else {
                Console.WriteLine("ない");
            }
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n =>Console.WriteLine(n/2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise1_4(List<int> numbers) {
            numbers.Select(n => n * 2).ToList().ForEach(Console.WriteLine);
        }

        private static void Exercise2_1(List<string> names) {
            var input = Console.ReadLine();
            var index = names.FindIndex(s => s == input);
            if (index >= 0) {
                Console.WriteLine(index);
            } else {
                Console.WriteLine("-1");
            }
            
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));

            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var query = names.Where(s => s.Contains('o')).ToArray();
            foreach(var s in query) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var query = names.Where(s => s.StartsWith("B")).Select(s=> s.Length);
            foreach(var n in query) {
                Console.WriteLine(n);
            }

        }

    }
}
