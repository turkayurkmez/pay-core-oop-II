// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 *    Uygulamanızdaki bir bileşen ile, verinin aktarılacağı kaynak aynı interface'e sahip değilse (uyumlu değilse), uyumluluğu nasıl sağlarsınız?
 *    
 * Senaryo:
 *    Bir API'den JSON diğerinden XML çekiyorsunuz.... 
 *    Bunları Currency (kur) olarak göstereceksiniz....
 */

XmlParser xmlParser = new XmlParser();
JsonParser jsonParser = new JsonParser();

CurrencyAdapter xmlcurrencyAdapter = new CurrencyAdapter(xmlParser);
xmlcurrencyAdapter.GetCurrencies().ForEach(c => Console.WriteLine(c.Name));

CurrencyAdapter jsonCurrAdapter = new CurrencyAdapter(jsonParser);
jsonCurrAdapter.GetCurrencies().ForEach(j => Console.WriteLine(j.Name));