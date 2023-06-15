// See https://aka.ms/new-console-template for more information
using Facade;

Console.WriteLine("Hello, World!");
/*
 * Birçok nesneyle gerçekleştirilen karmaşık bir işlemi; istemciden encapsulate etmek (uzaklaştırmak) istiyorsunuz. İstemci basitçe bir fonksiyonu çağıracak; bu işlemleri fonksiyon yönetecek.
 * 
 */

Customer customer = new Customer();
List<OrderItem> orderItems = new List<OrderItem>
{
    new(){ Name="Şapka", Quantity=2},
    new(){ Name="Tişört", Quantity=1}

};
OrderService orderService = new OrderService();
orderService.CreateOrder(customer, orderItems);

