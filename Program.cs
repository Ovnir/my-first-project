List<Book> books = new List<Book>
{
    new Book("Война и мир", "Лев Толстой", 1869),
    new Book("Преступление и наказание", "Фёдор Достоевский", 1866),
    new Book("Мастер и Маргарита", "Михаил Булгаков", 1967)
};

foreach (Book b in books)
    b.PrintInfo();

Book oldest = books[0];
foreach (Book b in books)
{
    if (b.Year < oldest.Year)
        oldest = b;
}
Console.WriteLine($"\nСамая старая: \"{oldest.Title}\" ({oldest.Year})");

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"\"{Title}\" - {Author}, {Year} г.");
    }
}
