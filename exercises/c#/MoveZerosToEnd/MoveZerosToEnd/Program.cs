using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;

namespace MoveZerosToEnd
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MoveZerosBenchmarks>();
        }
        
        public static IEnumerable<int> MoveZerosToEndLinq(IEnumerable<int> numbers)
        {
            IEnumerable<int> zeros = numbers.Where(item => item == 0);
            return numbers.Where(item => item != 0).Concat(zeros);
        }

        public static void MoveZerosToEndInPlace(List<int> numbers)
        {
            int startIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != 0)
                {
                    numbers[startIndex] = numbers[i];
                    startIndex++;
                }
            }

            for (int i = startIndex; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }
        }
    }

    public class MoveZerosBenchmarks
    {
        private readonly List<int> numbers = new() { 0, 1, 0, 3, 12 };

        [Benchmark]
        public void BenchmarkUsingLinq()
        {
            Program.MoveZerosToEndLinq(numbers);
        }

        [Benchmark]
        public void BenchmarkUsingInPlace()
        {
            Program.MoveZerosToEndInPlace(new List<int>(numbers));
        }
    }
}