namespace SparseArray;
/*
    *Implement the program solution for HackerRank problem: Sparse Array
    *Input param:
        ? string[] strings = array of strings to be queried
        ? string[] queries = array of strings representing queries
    *Returned value:
        ? int[] result = array of integer denoting the amount of found query within strings
    !Note: some details are omitted for simplicity (e.g array length int)
*/
public class Program
{
    public static void Main()
    {
        string[] toBeQueried = {"aba", "baba", "aba", "xzxb"};
        string[] queries = {"aba", "xzxb", "ab"};
        
        var x = MatchingStrings(toBeQueried, queries);
        foreach (var item in x)
        {
            Console.WriteLine(item);
        }

    }
    public static int[] MatchingStrings(string[] strings, string[] queries)
    {
        List<int> queriesCount = new();
        foreach (var query in queries)
        {
            List<string> successfulQuery = new();
            foreach (var str in strings)
            {
                if (str.Equals(query))
                {
                    successfulQuery.Add(str);
                }
            }
            queriesCount.Add(successfulQuery.Count);
        }
        return queriesCount.ToArray();
    }
}