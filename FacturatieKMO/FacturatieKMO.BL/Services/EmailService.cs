using System.Net.Mail;

namespace FacturatieKMO.BL
{
    public class EmailService
    {
        public static void SendMail(string email, string id, string subject, string body)
        {
            // Plug in your email service here to send an email.
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("apschoolnet@gmail.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("apschoolnet@gmail.com", "apNet123");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
