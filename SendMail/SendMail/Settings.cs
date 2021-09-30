using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail {
    public class Settings {

        public int Port { get; set; }
        public string Host { get; set; }
        public string MailAddr { get; set; }
        public string Pass { get; set; }
        public bool Ssl { get; set; }

        private static Settings instance = null;

        private Settings() { }

        public static Settings GetInstance() {
            if (instance == null) {
                instance = new Settings();
            }
            return instance;
        }

        public string sHost() {
            return "smtp.gmail.com";
        }

        public string sPort() {
            return 587.ToString();
        }

        public string sMailAdde() {
            return "ojsinfosys01@gmail.com";
        }

        public string sPass() {
            return "Infosys2021";
        }

        public bool bSsl() {
            return true;
        }
    }
}

