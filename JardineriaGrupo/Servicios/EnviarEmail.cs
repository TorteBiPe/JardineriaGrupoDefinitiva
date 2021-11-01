using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace JardineriaGrupo.Servicios
{
    public class EnviarEmail : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            using (var mensaje = new MailMessage())
            {
                mensaje.To.Add(new MailAddress(email, email));
                mensaje.From = new MailAddress("daw.antonio.prueba@gmail.com", "Net-GMail");
                mensaje.Subject = subject;
                mensaje.Body = htmlMessage;
                mensaje.IsBodyHtml = true;
                using (var cliente = new SmtpClient("smtp.gmail.com", 587))
                {
                    cliente.Port = 587;
                    cliente.UseDefaultCredentials = false;
                    cliente.Credentials = new NetworkCredential("daw.antonio.prueba@gmail.com", "Pantalla1@");
                    cliente.EnableSsl = true;
                    cliente.Send(mensaje);
                }
            }
            return Task.CompletedTask;
        }
    }

}
