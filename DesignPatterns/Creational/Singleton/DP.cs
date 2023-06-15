namespace Singleton
{
    public interface ISender
    {
        void Send();
    }

    public class MailSender : ISender
    {
        private MailSender()
        {

        }
        public string SmtpServer { get; set; }
        private static MailSender _sender;
        public static MailSender CreateInstance()
        {
            if (_sender == null)
            {
                _sender = new MailSender();
            }
            return _sender;
        }
        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
