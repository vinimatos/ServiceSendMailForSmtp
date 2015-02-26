using System;
using System.Net.Mail;
using ServiceMail.Dominio;

namespace ServiceMail
{
    public class SendMail
    {
        public bool SendMailForSmtp(string recipientMail, string subject, string bodyMail, string urlSmtp)
        {
            try
            {

                var componentMail = new ComponentMail();

                componentMail.RecipientMail = recipientMail;
                componentMail.Subject = subject;
                componentMail.BodyMail = bodyMail;

                componentMail.Priority = MailPriority.High;

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AuthenticCredential(string credential, string password, string urlSmtp)
        {
            try
            {
                var ath = new CredentialsSmtp(credential, password, urlSmtp);
                ath.EnableSsl = false;

                ath.Send(SendMailForSmtp);
               
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
