using Day4Interfaces;
namespace Day4Classes;

public class BookShelf
{
    public ILibraryItem libraryItem;
    public int shelfId;
    public bool accessibility;
    public BookShelf (ILibraryItem libraryItem, int shelfId, bool accessibility)
    {
        this.libraryItem = libraryItem;
        this.shelfId = shelfId;
        this.accessibility = accessibility;
    }
}
