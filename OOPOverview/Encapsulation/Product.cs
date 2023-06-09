namespace Encapsulation
{
    public class Product
    {
        /* Her product'un ............... vardır */
        private double price;
        public void SetPrice(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("fiyat negatif olamaz");
            }
            this.price = value;
        }

        public double GetPrice()
        {
            return price;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category { get; set; }

        public int Stock { get; set; }
        public void ChangeStock(double newStock)
        {
            IsAvailable = newStock > 0;
        }



        public bool IsAvailable { get; private set; }

        public string Vendor { get; init; }

    }
}
