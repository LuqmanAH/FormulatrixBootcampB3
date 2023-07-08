using Day4ParentInterfaces;
using Day4Classes;

namespace Program;

public class MainProgram
{
    public static void Main(string[] args)
    {
        BookShelf bookShelf1 = new BookShelf();

        bookShelf1.AddItem(new NonFictionBook( 54, "2020", "Albert Camus", "The absurd life"));
        bookShelf1.AddItem(new ElectronicThesis(180,"2018", "Muhammad Sulaiman Rosyid", "Aplikasi Fast Fourier Transform pada Analisis Spektrum Sinyal Cinta", ".pdf"));

        /* 
        ! List items refer to parent interface rather than its child, this makes methods derived from child interface unaccessible
       TODO: resolve error by altering program.cs or the interface source code 
       TODO: Define IPrinted and IDigital interfaces 
       * IPrint will define methods for printed library entities
       * IDigital will define methods for digital library entities
       * Ideas: generic book shall be an abstract class declaring basic attributes and method of a book
       * Ideas: light novels, magazines, and research paper shall be the children class derived from generic book each with its own overridden methods
       * Ideas: favorite shall be a composite class referencing multiple different library entities 
        */
        
        List<ILibraryItem> items = bookShelf1.GetItems();

        // Console.WriteLine(items.Count);
        Console.WriteLine(items[0].GetTitle());
        Console.WriteLine(items[0].GetAuthor());
        Console.WriteLine(items[0].GetPublicationYear());
        
        //* Line below will result in build failure when uncommented
        // Console.WriteLine(items[0].CoverType());
        Console.WriteLine("");
        Console.WriteLine(items[1].GetTitle());
        Console.WriteLine(items[1].GetAuthor());
        Console.WriteLine(items[1].GetPublicationYear());
    }
}