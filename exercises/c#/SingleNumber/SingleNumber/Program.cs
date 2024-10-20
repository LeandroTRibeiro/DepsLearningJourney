namespace SingleNumber;

public class Program
{
    static void Main(string[] args)
    {
        List<int> input = new() { 4, 1, 2, 1, 2 };
        
        var response = SingleNumber(input);

        foreach (var number in response)
        {
            Console.WriteLine(number);
        }
    }

    public static List<int> SingleNumber(List<int> input)
    {
        if (input == null || input.Count == 0)
        {
            return new List<int>();
        }
        
        return input
            .GroupBy(number => number)
            .Where(group => group.Count() == 1)
            .Select(group => group.Key)
            .ToList();
    }
    
    public static List<int> SingleNumber2(List<int> input)
    {
        List<int> result = new List<int>();
        
        if (input == null || input.Count == 0)
        {
            return result;
        }
        
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (var number in input)
        {
            if (!dictionary.ContainsKey(number))
            {
                dictionary.Add(number, 1);
            }
            else
            {
                dictionary[number]++;
            }
            
        }

        foreach (var number in dictionary) 
        {
            if (number.Value == 1)
            {
                result.Add(number.Key);
            }
        }

        return result;
    }
}

