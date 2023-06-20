namespace Command
{
    public interface ICommand
    {
        void Execute();
    }

    public class SendMessageCommand : ICommand
    {
        private string to;

        public SendMessageCommand(string to)
        {
            this.to = to;
        }

        public void Execute()
        {
            Console.WriteLine($"{to} alıcısına mesaj atıldı");
        }
    }

    public class DbCommand : ICommand
    {

        private DbReceiver dbReceiver;
        private string name;
        private int id;

        public DbCommand(DbReceiver dbReceiver, string name, int id)
        {
            this.dbReceiver = dbReceiver;
            this.name = name;
            this.id = id;
        }

        public void Execute()
        {
            /*
             *  Çok aşamalı bir komut olsun......
             */
            dbReceiver.CreateNewItem(name);
            dbReceiver.UpdateAnotherOne(id);
        }
    }


    public class DbReceiver
    {
        public void CreateNewItem(string name)
        {
            Console.WriteLine($"{name} db'ye eklendi");
        }

        public void UpdateAnotherOne(int id)
        {
            Console.WriteLine($"{id} db'de güncellendi.");
        }
    }

    public class Invoker
    {
        private List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command) => commands.Add(command);
        public void Clear() => commands.Clear();
        public void ExecuteAll() => commands.ForEach(command => command.Execute());




    }
}
