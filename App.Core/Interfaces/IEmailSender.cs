using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(System.Net.Mail.MailMessage mail);

        Task SendEmailAsync(string email, string subject, string message);
    }
}
