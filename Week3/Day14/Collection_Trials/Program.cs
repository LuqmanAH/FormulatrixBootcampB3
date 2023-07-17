namespace CollectionTrials;

public partial class Program
{
	public static void Main(string[] args)
	{
		//* Objects instance creation
		//! this is a mess
		int[] sampleArray = {3, 4, 5, 6};
		List<int> sampleList = new List<int>();
		HashSet<Player> hashOfPlayers= new HashSet<Player>();
		LinkedList<int> sampleLinkedList = new();
		int[] intArray = {1, 2, 3, 4, 5, 6};
        List<int> intList = intArray.ToList();
	
		Player player1 = new Player();
		Player player2 = new Player();
		Player player3 = new Player();
		Player player4 = new Player();

		//* Sample print
		Console.WriteLine("Isi dari Array: ");
		for (int i = 0; i < sampleArray.Length; i++)
		{
			Console.WriteLine(sampleArray[i]);
			sampleList.Add(i);
		}

		//* Compare which object to print
		Console.WriteLine("List kalau langsung di print console: ");
		Console.WriteLine($"{sampleList}");

		Console.WriteLine("\nList kalau langsung di print via foreach: ");
		foreach (var x in sampleList)
		{
			Console.WriteLine(x); // ada 0 karena Add Item via for loop
		}


		//* Forced duplicate insertion to the set
		hashOfPlayers.Add(player1);
		hashOfPlayers.Add(player1);
		hashOfPlayers.Add(player2);
		hashOfPlayers.Add(player4);

		//* Compare which object to print
		Console.WriteLine("\nHashSet kalau langsung print: ");
		Console.WriteLine($"{hashOfPlayers}");

		Console.WriteLine("\nHashSet kalau print.name via foreach: ");
		foreach (var player in hashOfPlayers)
		{
			Console.WriteLine(player.PlayerName);
		}
		hashOfPlayers.Add(player3);

		//* Demonstrate on how hashset would only allow FIFO config
		Console.WriteLine("\nHashSet kalau print.name after new insertion: "); //player3 last
		foreach (var player in hashOfPlayers)
		{
			Console.WriteLine(player.PlayerName);
		}

		//* Demonstrate on how LinkedList would only allow user to choose FIFO or LIFO
		Console.WriteLine("\nLinked List insertion FIFO config: "); //10 last
		for (int i = 1; i <= 10; i++)
		{
			sampleLinkedList.AddLast(i);
		}
		foreach (var integer in sampleLinkedList)
		{
			Console.WriteLine(integer);
		}

		sampleLinkedList.Clear();
		Console.WriteLine("\nLinked List insertion LIFO config: "); //1 last
		for (int i = 1; i <= 10; i++)
		{
			sampleLinkedList.AddFirst(i);
		}
		foreach (var integer in sampleLinkedList)
		{
			Console.WriteLine(integer);
		}

		//* Demonstrate on how LinkedList allow object insertion between existing objects
		//? Notice how cumbersome the process. we have to introduce a new object `LinkedListNode` before the actual insertion is allowed
		sampleLinkedList.Clear();
		sampleLinkedList.AddLast(10);
		sampleLinkedList.AddFirst(9);
		LinkedListNode<int> tenNode = sampleLinkedList.AddLast(12); 
		
		Console.WriteLine("\nLinked List middle insertion. Before: ");
		foreach (var integer in sampleLinkedList)
		{
			Console.WriteLine(integer);
		}

		//* Demonstrate on how array can be converted to list
		sampleLinkedList.AddAfter(tenNode, 11);
		Console.WriteLine("\nLinked List middle insertion. After: "); //inserted between 10 and 12
		foreach (var integer in sampleLinkedList)
		{
			Console.WriteLine(integer);
		}
        Console.WriteLine("\ncompare after conversion. Array version: ");
        foreach (var item in intArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\ncompare after conversion. List version: ");
        foreach (var item in intList)
        {
            Console.WriteLine(item);
        }
	}
}