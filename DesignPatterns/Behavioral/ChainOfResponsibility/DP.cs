namespace ChainOfResponsibility
{
    /*
     * Problem:
     *    Bir nesne üzerinde arka arkaya çalışacak bir sürü adım vardır ve bu adımlar gelecekte de değişebilir. Tüm bu işlemi yürütmek için nasıl bir yaklaşım sergilersiniz?
     *  
     *  Senaryo:
     *    Bir rezervasyon akışı aşağıdaki gibidir: 
     *     1. Validasyon
     *     2. Availability
     *     3. Deposit
     *     4. Approving
     *     5. Notification
     *  
     *  1. Her adımda gerçekleşecek işlemi arayüze ayırın
     */

    public interface IHandler<T>
    {
        //Her halka bu interface'i implemente edecek.
        IHandler<T> Next { set; }

        void Handle(T value);
    }

    public abstract class HandlerBase<T> : IHandler<T>
    {
        public HandlerBase()
        {

        }
        protected HandlerBase(IHandler<T> handler)
        {
            Next = handler;
        }

        public IHandler<T> Next { private get; set; }



        public virtual void Handle(T value)
        {
            if (Next != null)
            {
                Next.Handle(value);
            }
        }
    }

    public class Reservation
    {
        public string Info { get; set; }
    }

    public class ValidateReservation : HandlerBase<Reservation>
    {
        public override void Handle(Reservation value)
        {
            if (value.Info.Length > 0)
            {
                Console.WriteLine("Info değeri var. Zincir devam ediyor....");
                base.Handle(value);
            }
            else
            {
                Console.WriteLine("Validasyon patladı. Devam etmiyor....");
            }

        }
    }

    public class AvailableReservation : HandlerBase<Reservation>
    {
        public override void Handle(Reservation value)
        {
            //otel uygunluğu kontrol ediliyor;
            if (new Random().Next(1, 3) < 2)
            {
                Console.WriteLine("Otel uygun...");
                base.Handle(value);
            }
            else
            {
                Console.WriteLine("uygun değil");
            }

        }
    }

    public class Deposit : HandlerBase<Reservation>
    {
        public override void Handle(Reservation value)
        {
            Console.WriteLine("Depozito alındı... Zincir tamamlandı");
        }
    }


}
