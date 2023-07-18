using System.Collections;

namespace TryCollectionsPt2;

public class Program
{
    public static void Main(string[] args)
    {
        //! no typesafety
        Hashtable hashtable = new Hashtable
        {
            { 5, "item1" },
            { 5f, "item2" },
            { 5d, "item3" },
            { 5m, "item4" },
            { 5L, "item5" },
            { "5", "item6" },
            { true, "item7" }
        };


        //! print elements with no clear sorting
        foreach (var element in hashtable)
        {
            Console.WriteLine(element);
            // Console.WriteLine(element.Key); Error as the type of 'element' is object
            // Console.WriteLine(element.Value);
        }

        Console.WriteLine();
        SortedList sortedList = new()
        {
            { 5, "item1" },
            { 6, "item2" },
            { 7, "item3" }
        };

        foreach (DictionaryEntry element in sortedList)
        {
            Console.WriteLine(element.Key);
        }

        //! Compare data structure of Q and Stack
        //* Q's First in is 'indexed' as the first item and stack's First in is stacked by other entry until it becomes the last 'indexed' item
        Console.WriteLine();
        Queue queue= new Queue();
        for (int i = 1; i <= 10; i++)
        {
            queue.Enqueue(i);
        }
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //* De-Q returns the value
        var removeItem = queue.Dequeue();
        Console.WriteLine(removeItem);

        Console.WriteLine();
        Stack stack = new Stack();
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i);
        }
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //* Pop returns the value
        var removeItem2 = stack.Pop();
        Console.WriteLine(removeItem2);

    }
}