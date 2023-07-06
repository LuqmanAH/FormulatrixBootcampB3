using Day4Interfaces;
namespace Day4Classes;

public class Book : ILibraryItem
{
    public bool isFiction;
    public bool isCollection;
    public string? title;
    public int bookId;

    public Book(bool isFiction, bool isCollection, string? title, int bookId)
    {
        this.isFiction = isFiction;
        this.isCollection = isCollection;
        this.title = title;
        this.bookId = bookId;
    }

    public int? GetId()
    {
        return this.bookId;
    }
    public void IsAvailable()
    {
        Console.WriteLine("Please ask our librarian");
    }
}
