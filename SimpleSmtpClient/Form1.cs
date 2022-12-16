using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SimpleSmtpClient
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void guiUseCredentials_CheckedChanged(object sender, EventArgs e)
        {
            guiUser.ReadOnly = true;
            guiPassword.ReadOnly = true;
            if (guiUseCredentials.Checked)
            {
                guiUser.ReadOnly = false;
                guiPassword.ReadOnly = false;
            }
        }

        private void guiSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient();
                client.Host = guiServerName.Text;
                client.Port = Convert.ToInt32(guiPort.Text);
                if (guiUseCredentials.Checked)
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(guiUser.Text, guiPassword.Text);
                }
                if (guiUseSsl.Checked)
                {
                    client.EnableSsl = true;

                    int sslVer = cmbSSLVersion.SelectedIndex;
                    if (sslVer == 0 || sslVer == -1)
                    {
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
                    }
                    else if (sslVer == 1)
                    {
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                    }
                    else if (sslVer == 2)
                    {
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                    }
                    else if (sslVer == 3)
                    {
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                    }
                    else if (sslVer == 4)
                    {
                        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    }
                    //tls 1.3 not supported by .net framework 4.8 as of now.
                }
                MailMessage message = CreateMailMessage();
                client.Send(message);
                MessageBox.Show("Email Sent.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MailMessage CreateMailMessage()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(guiEmailFrom.Text);
            mailMessage.To.Add(guiEmailTo.Text);
            mailMessage.Body = guiEmailBody.Text;
            mailMessage.Subject = guiEmailSubject.Text;
            if (!string.IsNullOrEmpty(guiReplyTo.Text))
            {
                mailMessage.ReplyToList.Add(guiReplyTo.Text);
            }
            if (!string.IsNullOrEmpty(guiHeader.Text))
            {
                mailMessage.Headers.Add(guiHeader.Text, guiHeaderValue.Text);
            }
            return mailMessage;
        }
    }
}
