// See https://aka.ms/new-console-template for more information
using InterfaceSegregation;

Console.WriteLine("Hello, World!");
/*
 *  Bir sınıf, bir interface'i implemente ediyorsa; interface'in sağladığı TÜM FONKSİYONLARI geliştirmeye MECBURDUR.
 *  ISP, istemci kullanmadığı fonksiyonları bir interface'de olmasına zorlamamalıdır.
 *  
 */
ProductRepository productRepository = new ProductRepository();
BasketRepository basketRepository = new BasketRepository();

SearchDataComponent searchDataComponent = new SearchDataComponent();
var products = searchDataComponent.Search<Product>(productRepository, "deneme").ToList();
//var basketList = searchDataComponent.Search<Basket>(basketRepository, "deneme").ToList();

products.ForEach(p => Console.WriteLine(p.Name));
//basketList.ForEach(b => Console.WriteLine(b.ToString()));




