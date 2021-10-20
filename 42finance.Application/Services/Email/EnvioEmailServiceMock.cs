using _42finance.Domain.Entities.Email;
using _42finance.Domain.Interfaces.Services;
using System;
using System.Net.Mail;

namespace _42finance.Application.Services.Mock
{
    public class EnvioEmailServiceMock : IEnvioEmailService
    {
        public void Enviar(EnvioEmail envioEmail)
        {
            SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

            //smtpClient.Credentials = new system.net.networkcredential("info@mywebsitedomainname.com", "myIDPassword");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();

            //Setting From , To and CC
           // mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
            mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
            mail.CC.Add(new MailAddress("myemailid@gmail.com"));

            smtpClient.Send(mail);
        }
    }
}
