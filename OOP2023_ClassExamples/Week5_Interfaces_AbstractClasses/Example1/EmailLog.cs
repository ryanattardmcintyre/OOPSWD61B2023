using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example1
{
    public class EmailLog : ILog
    {
        private SmtpClient smtpClient;
        private string recipient;
        public EmailLog(string recipientEmail)
        {
            recipient = recipientEmail;
            smtpClient = new SmtpClient("smtp.gmail.com")
            { Port = 587, Credentials = new NetworkCredential("username", "password"), EnableSsl = true, };

        }
        public void Log(string message)
        {
            smtpClient.Send("admin@abc.com", recipient, "Email Log From....", message);
        }

        public void Log(string message, Exception exception)
        {
            smtpClient.Send("admin@abc.com", recipient, "Email Log From....", message
                + "| Exception: " + exception.Message);
        }
    }
}
