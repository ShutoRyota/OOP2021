using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "Sample.xml";

            Exercise1_1(file);
            Console.WriteLine("-------");

            Exercise1_2(file);
            Console.WriteLine("-------");

            Exercise1_3(file);
            Console.WriteLine("-------");

        }

        private static void Exercise1_1(string file) {
            var doc = XDocument.Load(file);
            var sports = doc.Root.Elements().
                         Select(x => new {
                             Name = (string)x.Element("name"),
                             Teammenbers = (int)x.Element("teammembers")
                         });
            foreach(var sport in sports) {
                Console.WriteLine($"{sport.Name} {sport.Teammenbers}");
            }
        }

        private static void Exercise1_2(string file) {
            var doc = XDocument.Load(file);
            var sports = doc.Root.Elements().
                         Select(x => new {
                             Name = (string)x.Element("name").Attribute("kanji"),
                             firstplayed = (int)x.Element("firstplayed")
                         }).OrderBy(year=>year.firstplayed);
            foreach (var sport in sports) {
                Console.WriteLine(sport.Name);
            }
        }

        private static void Exercise1_3(string file) {
            var doc = XDocument.Load(file);
            var sport = doc.Root.Elements().
                          Select(x => new {
                              Name = (string)x.Element("name"),
                              Teammenbers = (int)x.Element("teammembers")
                          }).OrderByDescending(x => x.Teammenbers).First();
            


            Console.WriteLine(sport.Name) ;

        }
    }
}
