// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");
/*
 * Bir nesneyi oluştururken; birden fazla tekrar eden aşama varsa bu aşamaları nesnenin kensisinden nasıl izole edersiniz?
 * 
 * Bir Rapor oluşturacaksınız. Raporun aşamaları şöyle:
 *     *Rapor başlığı -> Başlık Builder *      
 *     * İçeriği      -> İçerik Builder
 *     * İmza         -> İmza builder  
 *     
 *     
 */


Director director = new Director();
ReportBuilder reportBuilder = new ReportBuilder();
director.Builder = reportBuilder;
director.BuildReport();

reportBuilder.Report.ShowReport();

Console.WriteLine();