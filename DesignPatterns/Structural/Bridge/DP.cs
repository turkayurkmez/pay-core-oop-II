namespace Bridge
{
    public class Report
    {
        public ReportFormat ReportFormat { get; set; }
    }

    public class Sales : Report { }
    public class Performance : Report
    {

    }


    public class ReportFormat
    {

    }

    public class Pdf : ReportFormat
    {

    }

    public class Excel : ReportFormat
    {

    }
}
