namespace FindPairsWithSum2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 4, 3, 5, 7, 8, 1, 9 };
        int target = 10;
        
        var result = FindPairsWithSum(numbers, target);
        
        foreach (var pair in result)
        {
            Console.WriteLine($"({pair.Item1}, {pair.Item2})");
        }
    }

    static IEnumerable<(int, int)> FindPairsWithSum(IEnumerable<int> numbers, int targetSum)
    {
        var verifiedNumbers = new HashSet<int>();
        foreach (var number in numbers)
        {
            int complement = targetSum - number;
            if (verifiedNumbers.Contains(complement))
            {
                yield return (number, complement);
            }
            verifiedNumbers.Add(number);
        }
    }
}