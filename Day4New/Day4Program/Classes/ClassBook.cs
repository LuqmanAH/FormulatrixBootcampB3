using Day4ChildInterfaces;
namespace Day4Classes;

public class NonFictionBook : IBook
{
    public int pageCount;
    public string publicationYear; 
    public string? author;
    public string title;
    private static int _idCounter = 1;
    public static int BookID {
        get{return _idCounter;}
    }

    public NonFictionBook(int pageCount, string publicationYear, string? author, string title)
    {
        _idCounter ++;
        this.pageCount = pageCount;
        this.publicationYear = publicationYear;
        this.author = author;
        this.title = title;
        
    }
    public string CoverType()
    {
        if (pageCount >= 350)
        {
            return "Hardcover";
        }
        else if (pageCount > 0 && pageCount < 350)
        {
            return "PaperBack";
        } 
        else
        {
            return "";
        }
    }

    public string? GetAuthor()
    {
        return author;
    }

    public string GetPublicationYear()
    {
        return publicationYear;
    }

    public string GetTitle()
    {
        return title;
    }
    
}