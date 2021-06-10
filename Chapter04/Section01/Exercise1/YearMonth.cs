using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    public class YearMonth {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        public bool Is21Century {
            get {
                return 2001<=Year && Year<=2100;
            }   
        }

        public YearMonth AddOneMonth() {
            var next = new YearMonth(
                (this.Month != 12) ? this.Year : this.Year+1,
                (++this.Month) % 12);

            return next;
        }
        public override string ToString() {
            return Year+"年"+Month+"月";
        }

        

    }
}
