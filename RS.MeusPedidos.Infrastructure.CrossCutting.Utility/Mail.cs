using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Infrastructure.CrossCutting.Utility
{
    public class Mail
    {
        public static void Send(string subject, string body, params string[] to)
        {
            MailMessage mail = new MailMessage();

            foreach (string x in to)
                mail.To.Add(x);

            mail.From = new MailAddress("ruan.meuspedidos@outlook.com", "Meus Pedidos");            
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;

            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ruan.meuspedidos@outlook.com", "meuspedidos1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
