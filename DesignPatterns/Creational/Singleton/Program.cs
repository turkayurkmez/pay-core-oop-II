// See https://aka.ms/new-console-template for more information
using Singleton;

/*
 * Problem: Bir nesneden SADECE 1 tane olmasını istiyorsunuz.... Bunu nasıl sağlarsınız...
 */

Console.WriteLine("Hello, World!");
MailSender mailSender = MailSender.CreateInstance();
mailSender.SmtpServer = "Google";
MailSender sender2 = MailSender.CreateInstance();
Console.WriteLine(sender2.SmtpServer);
Console.WriteLine(mailSender.SmtpServer);
sender2.SmtpServer = "localhost";
Console.WriteLine(sender2.SmtpServer);
Console.WriteLine(mailSender.SmtpServer);