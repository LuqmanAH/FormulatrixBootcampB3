namespace LibraryItem;

public abstract class Book
{
    private static int _idCounter = 1;
    public Book()
    {
        ID = _idCounter++;
    }
    public static int ID{get; set;}
    public string? Title {get; set;}

    public string? Author{get; set;}

    public int PublicationYear{get; set;}

    public int NumberOfPage{get; set;}
}

// TODO: might need to separate each children as methods grow larger
public class Novel : Book
{
    public int NumberOfChapter {get; set;}
}

public class Magazine : Book
{
    public string? Publisher {get; set;}
}