using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        string Title;
        string ArtistName;
        int Length;

        public Song(string title, string artistName, int length) {
            Title1 = title;
            ArtistName1 = artistName;
            Length1 = length;
        }

        public string Title1 { get => Title; set => Title = value; }
        public string ArtistName1 { get => ArtistName; set => ArtistName = value; }
        public int Length1 { get => Length; set => Length = value; }
    }
}
