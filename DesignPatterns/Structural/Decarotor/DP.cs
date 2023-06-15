namespace Decarotor
{
    public abstract class Message
    {
        public abstract void Send();
    }

    public class MailMessage : Message
    {
        public override void Send()
        {
            Console.WriteLine("Mail Gönderildi");
        }
    }

    public class WSMessage : Message
    {
        public override void Send()
        {
            Console.WriteLine("WS ile Gönderildi");
        }
    }

    public abstract class MessageDecorator : Message
    {
        protected Message message;

        protected MessageDecorator(Message message)
        {
            this.message = message;
        }

        public override void Send()
        {
            message.Send();
        }
    }

    public class SignMessageDecorator : MessageDecorator
    {
        public SignMessageDecorator(Message message, string sign) : base(message)
        {
            Sign = sign;
        }

        public string Sign { get; set; }
        public override void Send()
        {
            Console.WriteLine($"{Sign} olarak imzalandı");
            base.Send();
        }

    }

    public class CryptoMessageMessageDecorator : MessageDecorator
    {
        public string Algorithm { get; set; }
        public CryptoMessageMessageDecorator(Message message, string algorithm) : base(message)
        {
            Algorithm = algorithm;
        }

        public override void Send()
        {
            Console.WriteLine($"{Algorithm} ile şifrelendi");
            base.Send();
        }

    }



}
