using App.Core.Interfaces;
using System.Net.Mail;
using System.Threading.Tasks;

namespace App.Infrastructure.Services
{
    /// <summary>
    ///  MailMessage mailMessage = new MailMessage();
    ///  mailMessage.From = new MailAddress("sender@mail.com");
    ///  mailMessage.To.Add("receiver@mail.com");
    ///  mailMessage.Subject = subject;
    ///  mailMessage.Body = message;
    ///  mailMessage.Attachments.Add(null);
    /// </summary>
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(MailMessage mail)
        {
            if (mail.From == null) mail.From = new MailAddress("sender@mail.com");

            SmtpClient client = new SmtpClient("SMTPServer, port")
            {
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("userName", "password")
            };
            client.Send(mail);
            return Task.CompletedTask;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            return SendEmailAsync(mailMessage);
        }
    }
}
