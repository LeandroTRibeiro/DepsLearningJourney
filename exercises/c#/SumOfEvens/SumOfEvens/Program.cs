namespace SumOfEvens;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] numbers2 = { -10, 3, 5, -4, 7 };
        int[] numbers3 = { 1, 3, 5, 7, 9 };
        
        Console.WriteLine(SumOfEvens(numbers1));
        Console.WriteLine(SumOfEvens(numbers2));
        Console.WriteLine(SumOfEvens(numbers3));

    }

    public static int SumOfEvens(int[] numbers)
    {
        return numbers.Aggregate(0, (acc, item) => item % 2 == 0 ? acc + item : acc);
    }
}