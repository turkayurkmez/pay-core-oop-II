// See https://aka.ms/new-console-template for more information
using Encapsulation;

Product product = new Product();

product.SetPrice(5);
product.Name = "Şapka";
product.Category = "Giyim";
product.ChangeStock(5);
if (product.IsAvailable)
{
    Console.WriteLine("Stokta var");
}

Console.WriteLine("Hello, World!");