namespace SumEvenNumbersWithWhere;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        Console.WriteLine(SumEvenNumbersWithWhere(numbers));

        static int SumEvenNumbersWithWhere(List<int> numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}