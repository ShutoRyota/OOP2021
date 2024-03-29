﻿using System;
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
        }

        private void Form1_Shown(object sender, EventArgs e) {
            if (Settings.EmptyFlg == false) {
                new ConfigForm().ShowDialog();
            }
        }

        private void btSend_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbTo.Text)) {
                MessageBox.Show("送信先を入力してください");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbMessage.Text)) {
                MessageBox.Show("本文を入力してください");
                return;
            }

            btSend.Enabled = false;
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
            btSend.Enabled = true;
            if (e.Cancelled) {
                MessageBox.Show("送信取消");
            }if(e.Error != null) {
                MessageBox.Show("エラーが発生しました\r\n" + e.Error.Message);
            }else {
                MessageBox.Show("送信完了");
                btCancel.Enabled = false;
                新規作成ToolStripMenuItem_Click(sender, e);
            }
        }


        private void btConfig_Click(object sender, EventArgs e) {
                new ConfigForm().ShowDialog();
        }


        private void btCancel_Click(object sender, EventArgs e) {          
            smtpClient.SendAsyncCancel();
            btCancel.Enabled = false;
        }

        private void 新規作成ToolStripMenuItem_Click(object sender, EventArgs e) {
            tbTo.Text = string.Empty;
            tbcc.Text = string.Empty;
            tbbcc.Text = string.Empty;
            tbTitle.Text = string.Empty;
            tbMessage.Text = string.Empty;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
