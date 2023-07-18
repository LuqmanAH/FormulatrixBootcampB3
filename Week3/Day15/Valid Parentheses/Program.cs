namespace VPSolution;

/*
    * Implement The solution for Valid Parentheses Problem in LeetCode
    * Assumption: string s only consist of combination of parentheses, this makes string that contains other than parentheses invalid
    *
*/

public class Program 
{
    public static void Main()
    {
        bool test1 = IsValid("()");
        bool test2 = IsValid("()[]{}");
        bool test3 = IsValid("(]");
        bool test4 = IsValid("(");
        bool test5 = IsValid("ad({})"); // invalid by introducing characters other than parentheses

        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.WriteLine(test3);
        Console.WriteLine(test4);
        Console.WriteLine(test5);
    }
    public static bool IsValid(string s)
    {
        Dictionary<char, char> Map = new()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        Stack<char> stack = new();
        foreach (var c in s)
        {
            if (!Map.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }
            else if (stack.Count == 0 || stack.Pop() != Map[c])
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
