namespace InterfaceSegregation
{

    public class Product
    {
        public string Name { get; set; }
    }

    public class Basket
    {

    }


    public interface IRepository<T>
    {
        T Get(int id);
        IList<T> GetAll();

        void Delete(int id);
        void Create(T item);

        //IList<T> GetProductsByName(string name);
    }

    public interface ISearchable<T>
    {
        IList<T> GetEntitiesByName(string name);
    }

    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Create(Product item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetEntitiesByName(string name)
        {
            return new List<Product>()
           {
               new()  { Name = name }
           };
        }
    }

    public class BasketRepository : IRepository<Basket>
    {
        public void Create(Basket item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Basket Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Basket> GetAll()
        {
            throw new NotImplementedException();
        }


    }


    public class SearchDataComponent
    {

        public IList<T> Search<T>(ISearchable<T> repository, string name)
        {
            return repository.GetEntitiesByName(name);
        }

    }
}
