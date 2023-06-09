namespace AbstractAndInterface
{
    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        //public Document(string title)
        //{
        //    Title = title;
        //}
        public string Title { get; set; }
        public string Owner { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine("Kopyalandı...");
        }
        public abstract void Open();

        public abstract void Save();


    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF açılıyor...");
        }



        public override void Save()
        {
            Console.WriteLine("PDF kaydediliyor...");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel açılıyor...");

        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alınıyor");
        }

        public override void Save()
        {

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word açılıyor...");
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alınıyor");
        }

        public override void Save()
        {

        }
    }

    public class DocumentPrinterComponent
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
