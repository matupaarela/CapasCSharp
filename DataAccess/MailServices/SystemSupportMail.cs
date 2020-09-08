using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    public class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            SenderMail = "matupaarela@gmail.com";
            Password = "GmailPassword";
            Host = "smtp.gmail.com";
            Port = 587;
            SSL = true;
            InitialSmtpClient();
        }
    }
}
