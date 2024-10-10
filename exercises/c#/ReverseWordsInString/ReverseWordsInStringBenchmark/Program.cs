using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ReverseWordsInStringBenchmark;

public class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkTest>();
    }
    
    public class BenchmarkTest
    {
        private readonly string phrase = "  Multiple    spaces   between  words ";

        [Benchmark]
        public string BenchmarkReverseWordsInString()
        {
            return ReverseWordsInString.Program.ReverseWords(phrase);
        }

        [Benchmark]
        public string BenchmarkReverseWordsInString2()
        {
            return ReverseWordsInString.Program.ReverseWords2(phrase);
        }
    }
}