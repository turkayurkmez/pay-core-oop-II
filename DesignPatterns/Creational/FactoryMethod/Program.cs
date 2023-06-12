// See https://aka.ms/new-console-template for more information
using FactoryMethod;

Console.WriteLine("Hello, World!");
/*
 * Bir harita uygulaması geliştirmeye karar verdiniz.
 *   Turist, gezmek istediği alanda, görmek istediği kategoriyi belirtir (Kültür, Dini, Eğlence gibi). 
 *   Harita turistin yaptğı seçime göre api'den yerleri çeker ve haritada gösterir...
 *   
 *   Harita eglence = new Harita(new Eglence());
 *   harita.ZiyaretNoktalari => Burası dolu olacak.
 *   
 *   Eğer senaryo kargo olsaydı.... 
 *   
 *           Kargo 
 *           
 *   KaraYoluKargo karayoluLojistik = new KaraYoluKargo
 *   karayoluLojistik.Arac => Kamyon
 *   
 *   DenizYoluKargo denizyoluLojistik = new DenizYoluKargo
 *   denizyoluLojistik.Arac => Gemi
 *   
 */
EntertainmentMap entertainmentMap = new EntertainmentMap();
foreach (var visit in entertainmentMap.VisitPoints)
{
    Console.WriteLine(visit.Name);
}

