namespace CustomSort;

public class Program
{
    static void Main(string[] args)
    {
        List<string> list = new() { "apple", "banana", "cherry", "date" };

        var sortedList = CustomSort(list);

        foreach (var word in sortedList)
        {
            Console.WriteLine(word);
        }
    }

    public static List<string> CustomSort(List<string> list)
    {
        
        List<string> result = new();

        Dictionary<string, Dictionary<char, int>> wordsFrequency = new();

        foreach (string word in list)
        {
            Dictionary<char, int> charFrequency = new();

            foreach (char letter in word)
            {
                if (charFrequency.ContainsKey(letter))
                {
                    charFrequency[letter]++;
                }
                else
                {
                    charFrequency.Add(letter, 1);
                }
            }
            
            wordsFrequency.Add(word, charFrequency);
        }

        return list.OrderBy(word =>
        {
            var repeatCount = wordsFrequency[word].Values
                .Where(frequency => frequency > 1)
                .Sum(frequency => frequency - 1);
            
            return repeatCount;
        }).ThenBy(word => word).ToList();
    }
}