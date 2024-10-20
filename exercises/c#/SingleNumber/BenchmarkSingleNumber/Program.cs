using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkSingleNumber;

public class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkTest>();
    }

    public class BenchmarkTest
    {
        private readonly List<int> numbers = new() {  4, 1, 2, 1, 2 };

        [Benchmark]
        public List<int> BenchmarkSingleNumber()
        {
            return SingleNumber.Program.SingleNumber(numbers);
        }

        [Benchmark]
        public List<int> BenckmarkSingleNumber2()
        {
            return SingleNumber.Program.SingleNumber2(numbers);
        }
    }
}