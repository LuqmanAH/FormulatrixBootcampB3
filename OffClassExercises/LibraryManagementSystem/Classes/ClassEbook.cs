// using LibraryInterfaces;
namespace LibraryItem;

public class ElectronicThesis
{
    private static int _idCounter = 0;
    public ElectronicThesis()
    {
        ID = _idCounter++;
    }
    public int ID { get; set; }
    public string? Title{get; set;}
    public string? Author{get; set;}

    public int PublicationYear{get; set;}

    public int NumberOfPage{get; set;}

    public int Filesize{get; set;}

    public string? URL{get; set;}
}