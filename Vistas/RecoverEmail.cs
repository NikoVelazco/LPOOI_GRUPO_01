
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Vistas
{
    public static class RecoverEmail
    {
        public static void Send(string sendTo, string sendFrom, string subject, string body)
        {
            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("lpoo1.2024@outlook.com", "1234");
            client.EnableSsl = true;

            MailMessage msg = new MailMessage();
            msg.Subject = subject;
            msg.Body = body;
            msg.From = new MailAddress(sendFrom);
            msg.To.Add(new MailAddress(sendTo));

            try
            {
                client.Send(msg);
                MessageBox.Show("Se ha enviado un correo de recuperación a: " + sendTo);
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show("Error de SMTP: " + smtpEx.StatusCode + " - " + smtpEx.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
            finally
            {
                client.Dispose(); // Liberar recursos
                msg.Dispose(); // Liberar recursos
            }
        }
    }
}



