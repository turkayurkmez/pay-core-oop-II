// See https://aka.ms/new-console-template for more information
using DependencyInversion;

Console.WriteLine("Hello, World!");
/*
 * Dependency: Bağımlı olma durumu
 * Laptop'un çalışması RAM'e bağlı
 * Matkap'ın işe yaraması için; uç takılmalıdır.
 * 
 * 
 * Inversion: Tersine çevirme....
 * 
 * Elektrik sistemi
 * Odanızdaki aydınlatma
 *    Duy -> Ampul
 * 
 * Yüksek seviye sınıf --> Soyut katman --> Düşük seviye sınıf
 *   Matkap            --> Ucun takıldığı yer --> Uç  
 */
MailSender mailSender = new MailSender();
WSSender wSSender = new WSSender();
TelegramSender telegramSender = new TelegramSender();


Report report = new Report(mailSender);
report.SendReport();
Report report2 = new Report(wSSender);
report2.SendReport();
Report report3 = new Report(telegramSender);
report3.SendReport();