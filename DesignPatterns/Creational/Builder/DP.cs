namespace Builder
{

    /*
	 *     *Rapor başlığı -> Başlık Builder *      
     *     * İçeriği      -> İçerik Builder
     *     * İmza         -> İmza builder  

	 */
    public interface IReportBuilder
    {
        void BuildHeader();
        void BuildContent();
        void BuildSign();
    }

    public class Report
    {
        List<string> parts = new List<string>();
        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void ShowReport()
        {
            parts.ForEach(p => Console.WriteLine(p));
        }
    }

    public class ReportBuilder : IReportBuilder
    {
        public Report Report { get; private set; } = new Report();
        public void BuildContent()
        {
            Report.AddPart("Rapor İçeriği oluşturuldu");
        }

        public void BuildHeader()
        {
            Report.AddPart("Başlık oluşturuldu");
        }

        public void BuildSign()
        {
            Report.AddPart("Rapora imza eklendi!");
        }
    }

    public class Director
    {
        public IReportBuilder Builder { private get; set; }
        public void BuildReport()
        {
            Builder.BuildHeader();
            Builder.BuildContent();
            Builder.BuildSign();
        }


    }

}
