using Day4Interfaces;
namespace Day4Classes;
public class Dictionary : ILibraryItem
{
    public string? fromLanguage;
    public string? toLanguage;
    public int dictionaryId;

    public Dictionary(string fromLanguage, string toLanguage, int dictionaryId)
    {
        this.fromLanguage = fromLanguage;
        this.toLanguage = toLanguage;
        this.dictionaryId = dictionaryId;
    }

    public int? GetId()
    {
        return this.dictionaryId;
    }

    public void IsAvailable()
    {
        Console.WriteLine("Please ask our librarian");
    }
}
