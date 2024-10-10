using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using FindLongestUniqueSubstring;

namespace FindLongestUniqueSubstringBenchmark;

public class ProgramBenchmark
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BencjmarkTest>();
    }

    public class BencjmarkTest
    {
        [Params("abc", "bbbbb", "pwwkew", "abcdefg", "abccba")] 
        public string phrase;

        [Benchmark]
        public int BenchmarkFindLongestUniqueSubstring()
        {
            return Program.FindLongestUniqueSubstring(phrase);
        }

        [Benchmark]
        public int BenchmarkFindLongestUniqueSubstring2()
        {
            return Program.FindLongestUniqueSubstring2(phrase);
        }
    }
}