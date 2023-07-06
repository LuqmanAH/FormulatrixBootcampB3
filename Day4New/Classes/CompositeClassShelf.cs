using Day4ParentInterfaces;
namespace Day4Classes;

public class BookShelf
{
    private List<ILibraryItem> _items;
    public BookShelf ()
    {
        _items = new List<ILibraryItem>();
    }
    public void AddItem(ILibraryItem item)
    {
        _items.Add (item);
    }

    public List<ILibraryItem> GetItems() 
    {
        return _items;
    }
}
