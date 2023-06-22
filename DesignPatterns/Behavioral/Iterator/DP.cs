using System.Collections;

namespace Iterator
{
    public class IteratorBase<T> : IEnumerator<T>
    {

        private List<T> collection = new List<T>();

        private int position = 0;

        public void Add(T item)
        {
            collection.Add(item);
            position = collection.Count - 1;
        }

        public T Current => collection[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            position = 0;
        }

        public bool MoveNext()
        {

            position++;
            return position < collection.Count - 1;


        }



        public void Reset()
        {
            position = 0;
        }

        public T First()
        {
            position = 0;
            return collection[position];
        }
        public T Last()
        {
            position = collection.Count - 1;
            return collection[position];
        }


        public T Before()
        {
            if (position > 0)
            {
                position--;
            }

            return collection[position];

        }
    }
}
