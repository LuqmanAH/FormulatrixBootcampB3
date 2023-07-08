using Day4ParentInterfaces;
namespace Day4ChildInterfaces;

public interface IEbook : ILibraryItem
{
    public string IsPrintable();
    public int FileSize();
}