using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            var newfile = "nandoku";
            var xdoc = XDocument.Load("11_2.xml");

            var diffikanjis = xdoc.Root.Elements();

            foreach(var moji in diffikanjis) {
                var newdoc = new XElement("difficultkanji",
                             new XElement("word", new XElement("kanji", moji.Element("kanji")),
                             new XElement("yomi", moji.Element("yomi"))));
                
                newdoc.Add(newfile);
                newdoc.Save(newfile);
                
            }
            
            
            var newxdoc = XDocument.Load(newfile);
            
            
            foreach(var kan in newxdoc.Root.Elements()) {
                var kanji = kan.Element("kanji");
                Console.WriteLine(kanji);
            }
            

           
        }
    }
}
