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

            string str = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var words = str.Split(';');

            foreach(var s in words) {
                
            }

        }
    }
}
