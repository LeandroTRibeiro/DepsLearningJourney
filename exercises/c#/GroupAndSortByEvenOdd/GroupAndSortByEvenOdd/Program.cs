namespace GroupAndSortByEvenOdd;

public class Program
{
    static void Main(string[] args)
    {
        List<int> input = new() { 10, 15, 3, 7, 2, 8, 23, 14 };
        
        var response = GroupSortByEvenOdd3(input);

        foreach (var key in response.Keys)
        {
            Console.Write($"{key}: ");
            foreach (var number in response[key])
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

    }

    public static Dictionary<string, List<int>> GroupSortByEvenOdd(List<int> input)
    {
        if (input is null) throw new ArgumentNullException("Input cannot be null");
        
        input.Sort();
        
        Dictionary<string, List<int>> output = new();
        
        output.Add("even", new List<int> {});
        output.Add("odd", new List<int> {});

        foreach (var number in input)
        {
            if (number % 2 == 0)
            {
                output["even"].Add(number);
            }
            else
            {
                output["odd"].Add(number);
            }
            
        }
        
        return output;
    }

    public static Dictionary<string, List<int>> GroupSortByEvenOdd2(
        List<int> input)
    {
        if (input is null) throw new ArgumentNullException("Input cannot be null");
        
        Dictionary<string, List<int>> output = new();
        output.Add("even", input.Where(x => x % 2 == 0).OrderBy(x => x).ToList());
        output.Add("odd", input.Where(x => x % 2 != 0).OrderBy(x => x).ToList());
        
        return output;
    }

    public static Dictionary<string, List<int>> GroupSortByEvenOdd3(List<int> input)
    {
        if (input is null) throw new ArgumentNullException("Input cannot be null");

        return input
            .GroupBy(x => x % 2 == 0 ? "even" : "odd")
            .ToDictionary(x => x.Key, x => x.OrderBy(y => y).ToList());
    }
}