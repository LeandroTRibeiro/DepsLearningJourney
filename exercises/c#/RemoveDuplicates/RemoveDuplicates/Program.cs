namespace RemoveDuplicates;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> list = new List<int>() { 1, 2, 3, 2, 4, 1, 5 };

        IEnumerable<int> response = RemoveDuplicates(list);

        foreach (int number in response)
        {
            Console.WriteLine(number);
        }

        static IEnumerable<int> RemoveDuplicates(IEnumerable<int> list) => new HashSet<int>(list);
    }
}