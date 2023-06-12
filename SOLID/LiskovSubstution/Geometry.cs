namespace LiskovSubstution
{
    public static class GeometryFactory
    {
        public static IAreaCalcutable CreateRectangle(double unitLength1, double? unitLength2 = null)
        {
            /*Bir biçimde kare döndürmeniz gerekti!!!!*/

            return unitLength2.HasValue ? new Rectangle { Width = unitLength1, Height = unitLength2.Value } :
                                          new Square { EdgeLength = unitLength1 };
        }
    }


    public interface IAreaCalcutable
    {
        double GetArea();
    }
    public class Rectangle : IAreaCalcutable
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public double GetArea() => Width * Height;

    }

    public class Square : IAreaCalcutable //: Rectangle
    {
        public double EdgeLength { get; set; }
        public double GetArea() => EdgeLength * EdgeLength;

    }
}
