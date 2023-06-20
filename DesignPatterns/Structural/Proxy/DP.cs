namespace Proxy
{
    public interface IMath
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
    }

    public class RealMath : IMath
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }

    public class MathProxy : IMath
    {
        private RealMath realMath;

        public MathProxy(RealMath realMath)
        {
            this.realMath = realMath;
        }

        public int Add(int x, int y)
        {
            if (CheckValues(x, y))
            {
                LogData();
                return realMath.Add(x, y);
            }

            return 0;

        }

        public int Subtract(int x, int y)
        {
            return realMath.Subtract(x, y);
        }

        public bool CheckValues(int x, int y)
        {
            Console.WriteLine("Değerlerin uygunluğu kontrol ediliyor");
            return x > 0 && y > 0;
        }

        public void LogData()
        {
            Console.WriteLine($"{DateTime.Now} anında proxy çalıştı....");
        }
    }
}
