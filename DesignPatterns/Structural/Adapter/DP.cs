namespace Adapter
{

    public class Currency
    {
        public string Name { get; set; }
        public decimal Selling { get; set; }
        public decimal Buying { get; set; }

    }
    public interface ICurrencyProvider
    {
        public List<Currency> GetCurrencies();
    }

    public interface IParser
    {
        List<Currency> GetCurrencies();
    }
    public class XmlParser : IParser
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new(){ Name="Dolar", Buying=23.80M, Selling=22.00M},
                new(){ Name="Euro", Buying=23.80M, Selling=22.00M},
                new(){ Name="Yen", Buying=23.80M, Selling=22.00M},

            };
        }
    }
    public class JsonParser : IParser
    {
        public List<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new(){ Name="Papua ", Buying=23.80M, Selling=22.00M},
                new(){ Name="CAD", Buying=23.80M, Selling=22.00M},
                new(){ Name="Dinar", Buying=23.80M, Selling=22.00M},
            };
        }
    }

    public class CurrencyAdapter : ICurrencyProvider
    {
        private readonly IParser parser;

        public CurrencyAdapter(IParser parser)
        {
            this.parser = parser;
        }

        public List<Currency> GetCurrencies()
        {
            return parser.GetCurrencies();
        }
    }


}
