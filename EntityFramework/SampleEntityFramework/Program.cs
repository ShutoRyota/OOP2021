using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEntityFramework.Models;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //Exercise13_1();
            Console.WriteLine("# 1.2");
            Exercise13_2();
            Console.WriteLine();

            Console.WriteLine("# 1.3");
            Exercise13_3();
            Console.WriteLine();

            Console.WriteLine("# 1.4");
            Exercise13_4();
            Console.WriteLine();

            Console.WriteLine("# 1.5");
            Exercise13_5();

            Console.ReadLine();

        }

        

        private static void Exercise13_1() {
            using (var db = new BooksDbContext()) {
                var kikuti = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(kikuti);

                var kawabata = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(kawabata);
                db.SaveChanges();


                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var kokoro = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(kokoro);

                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var izu = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(izu);

                var author3= db.Authors.Single(a => a.Name == "菊池寛");
                var sinju = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(sinju);

                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var tyumon = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(tyumon);

                db.SaveChanges();
            }

            
        }

        private static void Exercise13_2() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.ToList();

                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
                }
            }
        }

        private static void Exercise13_3() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.Where(x => x.Title.Length == db.Books.Max(b => b.Title.Length));

                foreach (var book in books) {
                    Console.WriteLine($"{book.Title}");
                }

            }
        }

        private static void Exercise13_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(b => b.PublishedYear).Take(3);
                foreach (var book in books) {
                    Console.WriteLine($"{book.Title} {book.Author.Name}");
                }

            }
        }

        private static void Exercise13_5() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderByDescending(x => x.Author.Birthday).ToList();
                foreach (var book in books) {
                    Console.WriteLine($"{book.Author.Name} {book.Title} {book.PublishedYear}");
                }
            }
        }



        #region
        private static void DeleteBook() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if(book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
                
            }
        }

        private static void UpdateBook() {
            using(var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);

                db.SaveChanges(); //データべースの更新
            }
        }

        //list 13-7
        static IEnumerable<Book> GetBooks() {
            using(var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        //List 13-8
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title} {book.PublishedYear}");               
            }
            Console.ReadLine(); //一時停止
        }

        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);

                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                db.SaveChanges();

            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    //Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);

                db.SaveChanges();
            }
        }
        #endregion
    }

}
