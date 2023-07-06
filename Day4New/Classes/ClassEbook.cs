using Day4ChildInterfaces;
namespace Day4Classes;

public class ElectronicThesis : IEbook
{
    public int pageCount;
    public string publicationYear; 
    public string? author;
    public string? title;
    public string fileExtension;
    private static int _idCounter = 1;
    public static int EBookID {
        get{return _idCounter;}
    }

    public ElectronicThesis(int pageCount, string publicationYear, string? author, string title, string fileExtension)
    {
        _idCounter ++;
        this.pageCount = pageCount;
        this.publicationYear = publicationYear;
        this.author = author;
        this.fileExtension = fileExtension;
        this.title = title;
    }
    public int FileSize()
    {
        int fileSize;
        fileSize = 8 * (pageCount / 100);
        
        return fileSize;
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
        if (title is not null)
        {
            return title;
        }
        return "null";
    }

    public string IsPrintable()
    {
        if (fileExtension == ".pdf" || fileExtension == ".epub")
        {
            return "yes";
        }
        else
        {
            return "no";
        }
    }
}