namespace FindSubsetsThatSumToTarget;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 2, 3, 5, -1, 6 };

        var response = numbers.FindSubsets(5);
        
        foreach (var subset in response)
        {
            foreach (var number in subset)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}