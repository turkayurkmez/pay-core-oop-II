// See https://aka.ms/new-console-template for more information

using Inheritance;

Console.WriteLine("Hello, World!");
Pizza pizza = new Pizza() { Boyut = PizzaBoyutu.Buyuk, Sure = 2 };
Hamburger hamburger = new Hamburger() { Sure = 1, TursuOlsunMu = true };
Kurufasulye kurufasulye = new Kurufasulye();
Bezelye bezelye = new Bezelye();

Asci asci = new Asci();
asci.Pisir(pizza);
asci.Pisir(hamburger);
asci.Pisir(kurufasulye);
asci.Pisir(bezelye);