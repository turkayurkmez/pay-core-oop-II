namespace FactoryMethod
{
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

    public class PoliticalMap : Map
    {
        protected override void createVisitPoints()
        {
            //Politik haritada (meclis, anıtkabir....) gibi ziyaret noktaları oluşturulacak.
        }
    }
}
