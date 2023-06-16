public class Book
{
    public string Name;
    public string Author;
    public int Pages;
    public string Genre;

    public Book() { }
    public Book(string name,string author, int page, string genre)
    {
        Name = name;
        Author = author;    
        Pages = page;
        Genre = genre;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name : {Name}\n" +
            $"Author : {Author}\n" +
            $"Pages : {Pages}\n" +
            $"Genre : {Genre}\n");
    }
}