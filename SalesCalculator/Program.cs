using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(@"Sales.csv");
            Dictionary<string, int> amountPerSrore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string,int> obj in amountPerSrore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }   
    }
}
