using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上修正クラス
    class SalesCounter {

        private List<Sale> _sale;

        public SalesCounter(List<Sale> sales) {
            _sale = sales;
        }

    }
}
