// See https://aka.ms/new-console-template for more information
using ObjectAndClass;

Employee e1 = new Employee();
Employee e2 = new Employee();

e1.Name = "Türkay";
Employee e3 = e1;
e3.Name = "Fikret";

Console.WriteLine(e1.Name);


Console.WriteLine("Hello, World!");

