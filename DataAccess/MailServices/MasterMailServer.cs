using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DataAccess.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient Smtp;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool SSL { get; set; }

        protected void InitialSmtpClient()
        {
            Smtp = new SmtpClient();
            Smtp.Credentials = new NetworkCredential(SenderMail, Password);
            Smtp.Host = Host;
            Smtp.Port = Port;
            Smtp.EnableSsl = SSL;
        }

        public void SendMail(string Subject, string Body, List<string> RecipientMail)
        {
            var MailMgs = new MailMessage();
            try
            {
                MailMgs.From = new MailAddress(SenderMail);
                foreach(string Mail in RecipientMail)
                {
                    MailMgs.To.Add(Mail);
                }
                MailMgs.Subject = Subject;
                MailMgs.Body = Body;
                MailMgs.Priority = MailPriority.Normal;
                Smtp.Send(MailMgs);
            }
            catch (Exception) { }
            finally {
                MailMgs.Dispose();
                Smtp.Dispose();
            }
        }
    }
}
