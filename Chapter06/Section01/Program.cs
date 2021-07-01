using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();
            /*Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0"));
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages));
            Console.WriteLine("最高額" + books.Max(x => x.Price));
            Console.WriteLine("最低額" + books.Min(x => x.Price));
            Console.WriteLine("冊数" + books.Count());
            Console.WriteLine("500円以上の本の数 " + books.Count(x => x.Price >= 500));
            Console.WriteLine( "「物語」が含まれる本は"+books.Count(x=>x.Title.Contains("物語"))+"冊");

            books.Where(x => x.Title.Contains("物語")).Select(x => x.Title).Take(2).
                                                                   ToList().ForEach(Console.WriteLine);

            Console.WriteLine();

            var topS = books.OrderByDescending(x => x.Price).Take(3);
            Console.WriteLine("高額3");
            foreach(var book in topS) {
                Console.WriteLine(book.Title + " " + book.Price);
            }*/

            var titles = books.Select(x => x.Title);
            foreach(var item in titles) {
                Console.WriteLine(item);
            }



        }
    }
}