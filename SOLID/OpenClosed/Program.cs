// See https://aka.ms/new-console-template for more information
using OpenClosed;

//Console.WriteLine("Hello, World!");
//Bir nesne; gelişime AÇIK değişime KAPALI olmalıdır.
//Yeni bir özellik eklemek istediğinizde varolan objeleri değiştirmek zorunda kalıyorsanız prensibi ihlal ediyorsunuz demektir.
Customer customer = new Customer() { TypeOfCard = new Premium(), Name = "Türkay" };
OrderManager orderManager = new OrderManager { Customer = customer };
var total = orderManager.GetDiscountedPrice(1000);
Console.WriteLine(total);