namespace AnagramGrouping;

public class Program
{
    static void Main(string[] args)
    {
        var input = new List<string> { "listen", "silent", "enlist", "eat", "tea", "tan", "nat", "bat" };
        
        var response = AnagramGrouping(input);

        foreach (var list in response)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }

    public static List<List<string>> AnagramGrouping(List<string> words)
    {
        if (words == null || words.Count == 0)
        {
            throw new ArgumentException("Input cannot be empty.");
        }
        
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        for (int i = 0; i < words.Count; i++)
        {
            var sortedWords = SortWord(words[i]);

            if (!groups.ContainsKey(sortedWords))
            {
                groups.Add(sortedWords, new List<string>() { words[i] } );
            }
            else
            {
                groups[sortedWords].Add(words[i]);
            }
        }
        
        List<List<string>> result = new List<List<string>>();

        foreach (var group in groups)
        {
            result.Add(group.Value);
        }
        
        return result;
    }

    public static string SortWord(string word)
    {
        char[] caracters = word.ToCharArray();
        
        Array.Sort(caracters);
        
        return new string(caracters);
    }
}