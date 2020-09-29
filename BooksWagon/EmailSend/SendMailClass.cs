using System;
using System.Net;
using System.Net.Mail;

namespace BooksWagon.EmailSend
{
    public class SendMailClass
    {
        public static void SendMail()
        {
            MailMessage mail = new MailMessage();
            string fromEmail = "moreypushkar24@outlook.com";
            string password = "realhero2430";
            string ToEmail = "moreypushkar24@outlook.com";
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(ToEmail);           
            mail.Subject = "Test Mail....";
            mail.Body = "Mail With Attachment";
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;
            mail.Attachments.Add(new Attachment(@"C:/Users/HP/source/repos/BooksWagon/BooksWagon/ExtentReport/index.html"));
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromEmail, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
