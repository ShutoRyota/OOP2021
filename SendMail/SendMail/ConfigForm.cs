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
                tbHost.Text = settings.Host;
                tbPort.Text = settings.Port.ToString();
                tbUserName.Text = settings.MailAddr;
                tbPass.Text = settings.Pass;
                cbSsl.Checked = settings.Ssl;
                tbSender.Text = settings.MailAddr;
            
            
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
            SettingsSet();            
        }

        private void btOK_Click(object sender, EventArgs e) {
            if (SettingsSet()) {
                this.Close();
            }

            
         
        }

        private void btCancel_Click(object sender, EventArgs e) {
            if (settings.CheckData()) {
               this.Close();
            }else {
                MessageBox.Show("設定されていない項目があります");
            }
             
        }

        private bool SettingsSet() {
            
            if(string.IsNullOrEmpty(tbHost.Text)) {
                MessageBox.Show("送信サーバを入力してください");
                return false;
            }

            if (string.IsNullOrEmpty(tbPort.Text)) {
                MessageBox.Show("ポート番号を入力してください");
                return false;
            }

            if (string.IsNullOrEmpty(tbUserName.Text)) {
                MessageBox.Show("メールアドレスを入力してください");
                return false;
            }

            if (string.IsNullOrEmpty(tbPass.Text)) {
                MessageBox.Show("パスワードを入力してください");
                return false;
            }

            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            settings.SaveInfo();
            return true;
        }
    }
}
