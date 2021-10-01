using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        SmtpClient smtpClient = new SmtpClient();
        Settings settings = Settings.GetInstance();

        public Form1() {
            InitializeComponent();
            if(File.Exists(@"C:\Users\infosys\source\repos\ShutoRyota\OOP2021\SendMail\SendMail\bin\Debug\senderInfo.xml"))
                settings = Settings.SetInfo();
        }

        private void btSend_Click(object sender, EventArgs e) {
            try {
                
                btCancel.Enabled = true;

                //メール送信のためのインスタンス
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(settings.MailAddr);
                mailMessage.To.Add(tbTo.Text);

                if(tbcc.Text != string.Empty)
                    mailMessage.CC.Add(tbcc.Text);

                if(tbbcc.Text != string.Empty)
                    mailMessage.Bcc.Add(tbbcc.Text);

                mailMessage.Subject = tbTitle.Text;
                mailMessage.Body = tbMessage.Text;

                //SMTPでメール送信
                smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                smtpClient.SendMailAsync(mailMessage);
                

            }catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                MessageBox.Show("送信取消");
            }if(e.Error != null) {
                MessageBox.Show("エラーが発生しました\r\n" + e.Error.Message);
            }else {
                MessageBox.Show("送信完了");
                btCancel.Enabled = false;
            }
        }


        private void btConfig_Click(object sender, EventArgs e) {
            new ConfigForm().ShowDialog();
        }


        private void btCancel_Click(object sender, EventArgs e) {          
            smtpClient.SendAsyncCancel();
            btCancel.Enabled = false;
        }
    }
}
