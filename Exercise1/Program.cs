using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Song[] songs = new Song[3] {new Song("aa","aaa",100), 
                                        new Song("bb", "bbb", 60), new Song("cc", "ccc", 121)};

            PrintSongs(songs);
        }

        public static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine("タイトル:{0} アーティスト:{1} 時間 {2:m\\:ss}:{3:00}"
                                    , song.Title1, song.ArtistName1, song.Length1, song.Length1 % 60);
            }
        }
    }
}