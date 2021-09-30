using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            try {
                Settings settings = Settings.GetInstance();

                //メール送信のためのインスタンス
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(settings.MailAddr);
                mailMessage.To.Add(tbTo.Text);
                mailMessage.CC.Add(tbcc.Text);
                mailMessage.Bcc.Add(tbbcc.Text);
                mailMessage.Subject = tbTitle.Text;
                mailMessage.Body = tbMessage.Text;

                //SMTPでメール送信
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                smtpClient.Send(mailMessage);
                MessageBox.Show("送信完了");
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            new ConfigForm().ShowDialog();
        }
    }
}
