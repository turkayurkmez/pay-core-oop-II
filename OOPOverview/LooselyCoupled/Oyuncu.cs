namespace LooselyCoupled
{
    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }

    public interface IKiyafet
    {

    }
    public abstract class UstGiyim : IKiyafet
    {

    }

    public class Kazak : UstGiyim
    {

    }
    public class KirmiziKazak : Kazak
    {

    }
}
