using System.Net.Mail;

namespace ServiceMail.Dominio
{
    public class ComponentMail
    {
        public string RecipientMail { get; set; }

        public string Subject { get; set; }

        public string BodyMail { get; set; }

        public MailPriority Priority { get; set; }

        
    }
}
