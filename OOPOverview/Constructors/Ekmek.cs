namespace Constructors
{
    public class Ekmek
    {
        public int Adet { get; set; }
        public string Tur { get; set; }

        public Ekmek() : this("Beyaz", 1)
        {

        }

        public Ekmek(int adet) : this("Beyaz", adet)
        {

        }

        public Ekmek(string tur) : this(tur, 1)
        {

        }

        public Ekmek(string tur, int adet)
        {
            Tur = tur;
            Adet = adet;
        }

    }
}
