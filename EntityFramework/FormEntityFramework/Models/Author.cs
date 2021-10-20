using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormEntityFramework.Models {
    //エンティティクラス
    public class Author {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public String Gender { get; set; }
        public virtual ICollection<Book> Books{ get; set; }
    }
}