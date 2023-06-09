namespace OpenClosed
{
    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium

    //}

    public abstract class CardType
    {
        public abstract double GetDiscountedPrice(double price);

    }
    public class Standard : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .95;
        }
    }

    public class Silver : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .90;
        }
    }

    public class Gold : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .85;
        }
    }

    public class Premium : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .8;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardType TypeOfCard { get; set; }
    }

    public class OrderManager
    {
        public Customer Customer { get; set; }

        public double GetDiscountedPrice(double price)
        {
            //switch (Customer.TypeOfCard)
            //{
            //    case CardType.Standard:
            //        return price * .95;
            //    case CardType.Silver:
            //        return price * .90;

            //    case CardType.Gold:
            //        return price * .85;
            //    case CardType.Premium:
            //        return price * .80;

            //    default:
            //        return price;
            //}
            return Customer.TypeOfCard.GetDiscountedPrice(price);

        }
    }
}
