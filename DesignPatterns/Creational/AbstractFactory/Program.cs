// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");
/*
 * Problem:
 * 
 * Geliştireceğiniz uygulama; çizimi yapılan bir arayüzü, seçilen platforma göre oluşturacak.
 *    - Bir kullanıcı giriş ekranı çizdiniz ve IOS için oluşturmasını istediniz. 
 *    - Login ekranındali textbox, buton ve label gibi kontrolleri IOS'da oluşturması gerekiyor.
 *    
 *    
 *  Senaryo:
 *  
 *  Bir harita uygulamasında; turisti, coğrafi ya da uydu haritası isteyebilir.... 
 *  
 */

MapCreator<GeoCultureMap> mapCreator = new MapCreator<GeoCultureMap>();
mapCreator.ShowVisitPoints();

MapCreator<GeoEntertaintmentMap> entMap = new MapCreator<GeoEntertaintmentMap>();
entMap.ShowVisitPoints();

