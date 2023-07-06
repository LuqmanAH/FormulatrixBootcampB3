using Day4Classes;
using Day4Interfaces;

namespace Program;

class program
{
    static void Main()
    {
        Book book1 = new(true, false, "Memancing di Saturnus", 34);
        Book book2 = new(false, true, "Metode Memancing Saat Perang", 15);
        Dictionary dictionary1 = new("Indonesian", "English", 27);
        Dictionary dictionary2 = new("Arabic", "Malaysian", 28);

        BookShelf bookShelf1 = new(book1, 23, true);
        BookShelf bookShelf2 = new(book2, 26, false);
        BookShelf bookShelf3 = new(dictionary1, 33, true);

        Console.WriteLine(book1.GetId());
        Console.WriteLine(book2.GetId());
        Console.WriteLine(dictionary1.GetId());
        Console.WriteLine(dictionary2.GetId());
        Console.WriteLine(bookShelf1.accessibility);
    }
}