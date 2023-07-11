using Day4ParentInterfaces;
namespace Day4ChildInterfaces;

public interface IBook : ILibraryItem
{
    public string CoverType();
}