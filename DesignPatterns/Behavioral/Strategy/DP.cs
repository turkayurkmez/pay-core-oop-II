namespace Strategy
{
    public class ProductCollection
    {
        public void Sort(ISortStrategy sortStrategy)
        {
            sortStrategy.Sort();
        }
    }

    public interface ISortStrategy
    {
        void Sort();
    }

    public class BubbleSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Bubble....");
        }
    }

    public class HeapSort : ISortStrategy
    {
        public void Sort()
        {
            Console.WriteLine("Heap....");
        }
    }



}
