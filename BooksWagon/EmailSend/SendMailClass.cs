using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BooksWagon.EmailSend
{
    public class SendMailClass
    {
        public static void SendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            mail.From = new MailAddress("moreypushkar24@outlook.com");
            mail.To.Add("moreypushkar24@outlook.com");
            mail.Subject = "Test Mail....";
            mail.Body = "Mail With Attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("C:/Users/HP/source/repos/BooksWagon/BooksWagon/ExtentReport/index.html");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("moreypushkar24@outlook.com", "pushkaru24");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
