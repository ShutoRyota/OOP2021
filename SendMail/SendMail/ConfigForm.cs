using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {

        private Settings settings = Settings.GetInstance();
        
        public ConfigForm() {
            InitializeComponent();            
        }

        private void btdefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAdde();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAdde();
        }

        private void btApply_Click(object sender, EventArgs e) {
            SetInfo();            
        }

        private void btOK_Click(object sender, EventArgs e) {
            SetInfo();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SetInfo() {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            settings.SaveInfo();
            
        }
    }
}
