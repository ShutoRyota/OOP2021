using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            #region 5.1
            Console.Write("文字列１：");
            var line1 = Console.ReadLine();
            Console.Write("文字列２：");
            var line2 = Console.ReadLine();

            if (string.Compare(line1, line2,ignoreCase:true)==0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
            #endregion

            #region 5.2
            Console.Write("数値：");
            int.TryParse(Console.ReadLine(),out int result);
            string str = $"{result:N0}";
            Console.WriteLine(str);
            #endregion

            //5.3.1
            var str2 = "Jackdaws love my big sphinx of quartz";
            var ch = str2.ToCharArray();
            int count=0;
            foreach(var c in ch) {
                if (char.IsWhiteSpace(c)) {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
