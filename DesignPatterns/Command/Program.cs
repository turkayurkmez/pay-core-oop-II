// See https://aka.ms/new-console-template for more information
using Command;

Console.WriteLine("Hello, World!");

DbReceiver receiver = new DbReceiver();
Invoker invoker = new Invoker();
invoker.AddCommand(new SendMessageCommand("patron"));
invoker.AddCommand(new DbCommand(receiver, "deneme", 3));

invoker.ExecuteAll();