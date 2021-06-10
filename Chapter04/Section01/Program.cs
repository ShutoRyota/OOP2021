using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var session = new Dictionary<string, object>();
            session["myProduct"] = new Product();

            var prduct = session["myProduct"] as Product;

            if (prduct == null) {
                Console.WriteLine("失敗");
            } else {
                Console.WriteLine("成功");
            }

        }

        private static Product GetProduct() {
            Sale sale = new Sale();
            return sale?.Product;
        }
    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
