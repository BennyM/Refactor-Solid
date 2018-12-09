using System.Collections.Generic;
using System.Net.Mail;

namespace web.Store
{
    public class MailNotification
     : INotification
    {
        public IList<string> ToAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public IList<string> BccAddresses { get; set; }

        public void Send()
        {
            SmtpClient client = new SmtpClient("mysmtpserver");
            client.UseDefaultCredentials = false;
            // client.Credentials = new NetworkCredential("username", "password");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("our-shop@cool-shop.be");
            //  mailMessage.To.Add(order.EmailAddress);
            mailMessage.Body = "Your order has been shipped!";
            mailMessage.Subject = "Order confirmation";
            client.Send(mailMessage);
        }
    }
}