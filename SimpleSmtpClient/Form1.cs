//nuget install MailKit MimeKit
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                var client = new SmtpClient();
                int sslVer = cmbSSLVersion.SelectedIndex;

                //The SMTP Port used for connecting.Typical SMTP ports are:

                //25
                //587(STARTTLS)
                //465(SSL)
                SecureSocketOptions SocketOptions = SecureSocketOptions.None; // Initialize with a default value
                if (sslVer == 0)
                {
                    SocketOptions = SecureSocketOptions.None;
                }
                else if (sslVer == 1 || sslVer == -1)
                {
                    SocketOptions = SecureSocketOptions.Auto;
                }
                else if (sslVer == 2)
                {
                    SocketOptions = SecureSocketOptions.SslOnConnect;
                }
                else if (sslVer == 3)
                {
                    SocketOptions = SecureSocketOptions.StartTls;
                }
                else if (sslVer == 4)
                {
                    SocketOptions = SecureSocketOptions.StartTlsWhenAvailable;
                }

                client.Connect(guiServerName.Text, Convert.ToInt32(guiPort.Text), SocketOptions);
                client.Authenticate(guiUser.Text, guiPassword.Text);

                MimeMessage message = CreateMailMessage();
                client.Send(message);
                client.Disconnect(true);

                MessageBox.Show("Email sent successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MimeMessage CreateMailMessage()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Your Name", guiEmailFrom.Text));
            message.To.Add(new MailboxAddress("Recipient", guiEmailTo.Text));
            message.Subject = guiEmailSubject.Text;
            message.Body = new TextPart("plain") { Text = guiEmailBody.Text };


            return message;
        }
    }
}
