using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{

    internal class Email
    {
        private static readonly string _email = "muradgojayevv@gmail.com";
        private static readonly string _password = "YOUR_EMAIL_PASSWORD";

        public static void SendMail(string recipientEmail, string subject)
        {
            if (Validation.CheckEmail(recipientEmail))
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(_email, _password),
                    EnableSsl = true,
                };

                smtpClient.Send(_email, recipientEmail, subject, "1234");

            }
        }

    }
}
