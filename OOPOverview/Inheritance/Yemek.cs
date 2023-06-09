namespace Inheritance
{
    public class Yemek
    {
        public int Sure { get; set; }
        public List<string> Malzemeler { get; set; }
        public double Fiyat { get; set; }
        public void Pisir()
        {
            Console.WriteLine($"{GetType().Name}, {Sure} dakikada bitti");
        }

        public virtual void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, Yanında pilav ile sunuldu");
        }

    }

    public class Hamburger : Yemek
    {
        public bool TursuOlsunMu { get; set; }
        public string EkstraSos { get; set; }
        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, Yanında patates kızartması ile sunuldu");
        }

    }

    public class Pizza : Yemek
    {
        public PizzaBoyutu Boyut { get; set; }
        public string Ekstra { get; set; }

        public override void SunumYap()
        {
            Console.WriteLine($"{GetType().Name}, Yanında kola  ile sunuldu");
        }

    }

    public class Kurufasulye : Yemek
    {
        public bool EtVarMi { get; set; }
    }
    public class Bezelye : Yemek
    {
        public bool HavucVarmi { get; set; }
    }



    public enum PizzaBoyutu
    {
        Kucuk, Orta, Buyuk
    }
}
