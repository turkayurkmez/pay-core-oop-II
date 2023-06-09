// See https://aka.ms/new-console-template for more information

using AbstractAndInterface;

ExcelDocument excel = new ExcelDocument();
PdfDocument pdf = new PdfDocument();
WordDocument word = new WordDocument();

DocumentPrinterComponent component = new DocumentPrinterComponent();
component.Print(excel);
component.Print(word);

Console.WriteLine("Hello, World!");
