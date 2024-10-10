namespace FindLongestUniqueSubstring;

public class Program
{
    static void Main(string[] args)
    {
        string input = "bbbbb";
        
        Console.WriteLine(FindLongestUniqueSubstring(input));
        Console.WriteLine(FindLongestUniqueSubstring2(input));
    }

    public static int FindLongestUniqueSubstring(string input)
    {
        string response = "";

        if (input == null || input.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (!response.Contains(input[i]))
            {
                response += input[i];
            }
            else
            {
                break;
            }
 
        }
        
        return response.Length;
    }

    public static int FindLongestUniqueSubstring2(string input)
    {
        if (input == null || input.Length == 0)
        {
            return 0;
        }
        
        var seenChars = new HashSet<char>();
        
        return input.TakeWhile(ch => seenChars.Add(ch)).Aggregate("", (current, ch) => current + ch).Length;
    }
}

