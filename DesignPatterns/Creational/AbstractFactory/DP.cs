namespace AbstractFactory
{

    //Coğrafi ya da Uydu haritası seçenekleri....
    public interface IVisitPoint
    {
        public string Name { get; set; }
    }

    public class Pub : IVisitPoint
    {
        public string Name { get; set; }
    }

    public class ConcertHall : IVisitPoint
    {
        public string Name { get; set; }

    }

    public class Museum : IVisitPoint
    {
        public string Name { get; set; }

    }
    public class Exhibition : IVisitPoint
    {
        public string Name { get; set; }

    }


    public abstract class Map
    {
        public IEnumerable<IVisitPoint> VisitPoints { get; set; }
        public Map()
        {
            //VisitPoints Map'a göre değişecek!
            createVisitPoints();
        }

        //Bu metot sayesinde; haritada gösterilecek yerler üretiliyor:
        //FatoryMethod:
        protected abstract void createVisitPoints();

    }

    public class EntertainmentMap : Map
    {
        protected override void createVisitPoints()
        {
            VisitPoints = new List<IVisitPoint>()
            {
           new Pub{ Name="Teras Pub"},
           new ConcertHall{ Name="Küçükçiftlik"},
           new Pub{ Name="Mavi bar" }
              };




        }
    }

    public class CultureMap : Map
    {
        protected override void createVisitPoints()
        {
            VisitPoints = new List<IVisitPoint>()
            {
                  new Museum{ Name="Topkapı Saray"},
                  new Exhibition{ Name="Akbank sanat"},
                  new Museum{ Name ="Yerebatan sarnıcı"}
            };
        }
    }


    public interface IMap
    {
        IEnumerable<IVisitPoint> GetVisitPoints();
        public string MapStyle { get; set; }
        public Map MapFormat { get; set; }
    }


    public class GeoEntertaintmentMap : IMap
    {
        public string MapStyle { get; set; } = "Coğrafi";
        public Map MapFormat { get; set; } = new EntertainmentMap();

        public IEnumerable<IVisitPoint> GetVisitPoints()
        {
            return MapFormat.VisitPoints;
        }
    }

    public class GeoCultureMap : IMap
    {
        public string MapStyle { get; set; } = "Coğrafi";
        public Map MapFormat { get; set; } = new CultureMap();

        public IEnumerable<IVisitPoint> GetVisitPoints()
        {
            return MapFormat.VisitPoints;
        }
    }

    public class SatelliteCultureMap : IMap
    {
        public string MapStyle { get; set; } = "Uydu";
        public Map MapFormat { get; set; } = new CultureMap();

        public IEnumerable<IVisitPoint> GetVisitPoints()
        {
            return MapFormat.VisitPoints;
        }
    }

    public class SatelliteEntertaintmentMap : IMap
    {
        public string MapStyle { get; set; } = "Uydu";
        public Map MapFormat { get; set; } = new EntertainmentMap();

        public IEnumerable<IVisitPoint> GetVisitPoints()
        {
            return MapFormat.VisitPoints;
        }
    }

    //Abstract Factory sınıfı:
    public class MapCreator<T> where T : IMap, new()
    {
        private T map;
        public MapCreator()
        {
            map = new T();
        }

        public void ShowVisitPoints()
        {
            Console.WriteLine($"Oluşturulan harita: {map.MapFormat.GetType().Name} - Stil:{map.MapStyle} ");
            map.GetVisitPoints().ToList().ForEach(vp => Console.WriteLine(vp.Name));
        }
    }
}
