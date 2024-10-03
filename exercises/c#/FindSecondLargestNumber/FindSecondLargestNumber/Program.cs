using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace FindSecondLargestNumber;

public class Program
{
    static void Main(string[] args)
    {
        var sumamary = BenchmarkRunner.Run<BenchmarkTest>();
        
        int[] numbers = { 4, 1, 7, 9, 2, 8 };
        
        Console.WriteLine(FindLargestNumber(numbers));
        Console.WriteLine(FindLargestNumber2(numbers));
    }

    public static int FindLargestNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }
        
        if (numbers.Length < 2)
        {
            return numbers[0];
        }
        
        for(int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                int temp;

                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        return numbers[numbers.Length - 2];
    }

    public static int FindLargestNumber2(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }
        
        if (numbers.Length < 2)
        {
            return numbers[0];
        }
        
        Array.Sort(numbers);
        
        return numbers[numbers.Length - 2];
    }
}

public class BenchmarkTest
{
    private readonly int[] _numbers = { 4, 1, 7, 9, 2, 8 };

    [Benchmark]
    public int BenchmarkFindLargestNumber()
    {
        return Program.FindLargestNumber(_numbers);
    }

    [Benchmark]
    public int BenchmarkFindLargestNumber2()
    {
        return Program.FindLargestNumber2(_numbers);
    }
}