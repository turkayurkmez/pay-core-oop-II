namespace DependencyInversion
{
    public class Report
    {

        private ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }
        public void SendReport()
        {

            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class WSSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp'dan....");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram'dan....");
        }
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

}
