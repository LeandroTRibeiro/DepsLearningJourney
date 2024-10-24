using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BenchmarkGroupByEvenOdd;

public class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkTest>();
    }

    public class BenchmarkTest
    {
        private readonly List<int> _input = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [Benchmark]
        public Dictionary<string, List<int>> BenchmarkGroupByEvenOdd()
        {
            return GroupAndSortByEvenOdd.Program.GroupSortByEvenOdd(_input);
        }
        
        [Benchmark]
        public Dictionary<string, List<int>> BenchmarkGroupByEvenOdd2()
        {
            return GroupAndSortByEvenOdd.Program.GroupSortByEvenOdd(_input);
        }
        
        [Benchmark]
        public Dictionary<string, List<int>> BenchmarkGroupByEvenOdd3()
        {
            return GroupAndSortByEvenOdd.Program.GroupSortByEvenOdd(_input);
        }
    }
}