namespace Facade
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class Product
    {
        public int Stock { get; set; }
    }

    public class Order
    {
        public decimal TotalPrice { get; set; }
    }

    public class OrderService
    {
        public int CreateOrder(Customer customer, List<OrderItem> orderItems)
        {
            Console.WriteLine($"{customer.Name} isimli müşteri:");
            orderItems.ForEach(oi => Console.WriteLine($"{oi.Name} ürününden {oi.Quantity} adet aldı"));
            orderItems.ForEach(oi => Console.WriteLine($"{oi.Name} ürününün stoğundan {oi.Quantity} adet düşüldü"));


            return 1;
        }
    }

    public class OrderItemService
    {

    }

    public class ProductService
    {

    }


}
