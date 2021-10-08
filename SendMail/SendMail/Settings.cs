using System;
using System.Collections.Generic;
using System.IO;
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
        public static bool EmptyFlg { get; private set; } = true;

        private static Settings instance = null;

        private Settings() {
            
        }


        public static Settings GetInstance() {
            if(instance == null) {
                try {
                    SetInfo();
                }catch(Exception ex) {
                    instance = new Settings();
                    EmptyFlg = false;
                }
                    
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

        public bool SetConfig(string port,string host,string mailaddr,string pass,bool ssl) {
            Host = host;
            Port = int.Parse(port);
            MailAddr = mailaddr;
            Pass = pass;
            Ssl = ssl;

            instance.SaveInfo();

            EmptyFlg = true;
            return true;
        }

        //逆シリアル化
        public static void SetInfo() {
            try {
                using (var reader = XmlReader.Create("senderInfo.xml")) {
                    var serializer = new DataContractSerializer(typeof(Settings));
                    instance = serializer.ReadObject(reader) as Settings;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
                
        }
        //シリアル化
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

        //情報を持っているかの確認
        public bool CheckData() {
            if (string.IsNullOrEmpty(Port.ToString()))
                return false;

            if (string.IsNullOrEmpty(Host))
                return false;

            if (string.IsNullOrEmpty(MailAddr))
                return false;

            if (string.IsNullOrEmpty(Pass))
                return false;

            return true;
        }
    }
}

