using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SimpleSmtpClient
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void guiUseSsl_CheckedChanged(object sender, EventArgs e)
        {
            cmbSSLVersion.Enabled = guiUseSsl.Checked;
        }

        private void guiSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSmtpConfiguration();
                ValidateMailMessage();

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
                    ConfigSslOrTls();
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
        
        private void ValidateSmtpConfiguration()
        {
            if (string.IsNullOrEmpty(guiServerName.Text))
            {
                throw new Exception("Invalid SMTP server.");
            }

            if (guiUseCredentials.Checked &&
                (string.IsNullOrEmpty(guiUser.Text) || string.IsNullOrEmpty(guiPassword.Text)))
            {
                throw new Exception("Invalid User or Password.");
            }
        }

        private void ValidateMailMessage()
        {
            if (!IsValidMailAddress(guiEmailFrom.Text))
            {
                throw new Exception("Invalid From address.");
            }

            if (!IsValidMailAddressList(guiEmailTo.Text))
            {
                throw new Exception("Invalid To address.");
            }

            if (!string.IsNullOrEmpty(guiEmailBcc.Text) &&
                !IsValidMailAddressList(guiEmailBcc.Text))
            {
                throw new Exception("Invalid Bcc address.");
            }
        }

        private void ConfigSslOrTls()
        {
            int sslVer = cmbSSLVersion.SelectedIndex;

            switch (sslVer)
            {
                case 0:
                case -1:
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.SystemDefault;
                    break;
                case 1:
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                    break;
                case 2:
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                    break;
                case 3:
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
                    break;
                case 4:
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    break;
            }
            //tls 1.3 not supported by .net framework 4.8 as of now.
        }

        private MailMessage CreateMailMessage()
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(guiEmailFrom.Text);
            mailMessage.To.Add(guiEmailTo.Text);
            if (!string.IsNullOrEmpty(guiEmailBcc.Text))
            {
                mailMessage.Bcc.Add(guiEmailBcc.Text);
            }
            mailMessage.Body = guiEmailBody.Text;
            mailMessage.IsBodyHtml = guiIsBodyHtml.Checked;
            mailMessage.Subject = guiEmailSubject.Text;
            return mailMessage;
        }

        private static bool IsValidMailAddressList(string str)
        {
            return str.Split(',').All(IsValidMailAddress);
        }

        private static bool IsValidMailAddress(string str)
        {
            try
            {
                _ = new MailAddress(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
