using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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

        public static Settings SetInfo() {
            

            using (var reader = XmlReader.Create("senderInfo.xml")) {
                Settings settings = GetInstance();
                var serializer = new DataContractSerializer(typeof(Settings));
                settings = serializer.ReadObject(reader) as Settings;
                return settings;
            }
        }

        public void SaveInfo() {
            var settings = Settings.GetInstance();

            var set = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("senderInfo.xml", set)) {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }

        }

        public void UpdateInfo() {
            
        }
    }
    

}

