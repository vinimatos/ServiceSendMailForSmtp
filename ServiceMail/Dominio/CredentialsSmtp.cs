using System;

namespace ServiceMail.Dominio
{
    public class CredentialsSmtp
    {
        public CredentialsSmtp(string credential, string password, string urlSmtp)
        {
            Credential= credential;
            UrlSmtp = urlSmtp;
            Password = password;
        }
        public bool EnableSsl { get; set; }

        public string UrlSmtp { get; set; }

        public string Credential { get; set; }

        public string Password { get; set; }

        internal void Send(Func<string, string, string, string, bool> SendMailForSmtp)
        {
            throw new NotImplementedException();
        }
    }
}
