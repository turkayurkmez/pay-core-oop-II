// See https://aka.ms/new-console-template for more information
using Iterator;


IteratorBase<News> newsGallery = new();

newsGallery.Add(new News { Id = 1, Title = "Dolar uçtu" });
newsGallery.Add(new News { Id = 2, Title = "Türkay araba aldı" });
newsGallery.Add(new News { Id = 3, Title = "Her şey mükemmel" });




Console.WriteLine(newsGallery.Current);
if (newsGallery.MoveNext())
{
    Console.WriteLine(newsGallery.Current);

}
else
{
    newsGallery.First();
    Console.WriteLine(newsGallery.Current);
    newsGallery.MoveNext();
    Console.WriteLine(newsGallery.Current);
    newsGallery.Last();
    Console.WriteLine(newsGallery.Current);


}

public class News
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public override string ToString()
    {
        return Title;
    }
}


