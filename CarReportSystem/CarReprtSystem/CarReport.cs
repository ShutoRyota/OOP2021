using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReprtSystem {
    public class CarReport {
        public DateTime Date { get; set; }
        public string Auther { get; set; }
        public MakerGroup Maker { get; set; }
        public string CarName { get; set; }
        public string Report { get; set; }
        public Image Picture { get; set; }
        //メーカー
        public enum MakerGroup {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外国車,
            その他
        }

        
        //更新用
        public void Update(DateTime date, string auther, MakerGroup maker,string carName, 
                                                                         string report, Image picture) {
            this.Date = date;
            this.Auther = auther;
            this.Maker = maker;
            this.CarName = carName;
            this.Report = report;
            this.Picture = picture;

        }


    }

    



}
