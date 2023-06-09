namespace SingleResponsibility
{
    public class ProductService
    {
        public void AddProduct(string name, decimal price)
        {
            DBOperation dBOperation = new DBOperation();
            dBOperation.Execute();
        }
    }
}
