// See https://aka.ms/new-console-template for more information
using Decarotor;
using System.IO.Compression;
using System.Net.Sockets;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *   Belirli bir nesneye (run-time'da) yeni fonksiyonlar (veya özellikler) eklemek istiyorsunuz. Bunu varolana müdahale etmeden nasıl çözersiniz?
 *   //Karamel Latte
 *   //Esmer şekerli karamel Latte
 *   //Vanilya şuruplu Latte (ama şekersiz)
 *   
 */
//Stream
FileStream fileStream = null;
MemoryStream stream = new MemoryStream();
NetworkStream networkStream = null;

GZipStream gZipStream = new GZipStream(stream, CompressionLevel.SmallestSize);
//CryptoStream cryptoStream = new CryptoStream(gZipStream, null, CryptoStreamMode.Write);


WSMessage whatsAppMessage = new WSMessage();
SignMessageDecorator signMessageDecorator = new SignMessageDecorator(whatsAppMessage, "Türkay Ürkmez");
CryptoMessageMessageDecorator cryptoMessage = new CryptoMessageMessageDecorator(signMessageDecorator, "SHA512");

cryptoMessage.Send();
