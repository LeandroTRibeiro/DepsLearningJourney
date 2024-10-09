using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace RemoveDuplicates;

public static class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<BenchmarkTest>();
        int[] nums = { 1, 1, 2 };
        
        int[] response = RemoveDuplicatesList(nums);

        foreach (var num in response)
        {
            Console.WriteLine(num);
        }
    }

    public static int[] RemoveDuplicatesHashSet(int[] nums)
    {
        return nums == null ? new int[] { } : new HashSet<int>(nums).ToArray();
    }

    public static int[] RemoveDuplicatesList(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return new int[] { };
        }
        
        List<int> list = new();

        foreach (var num in nums)
        {
            if (!list.Contains(num))
            {
                list.Add(num);
            }
        }
        
        return list.ToArray();
    }
    
    public class BenchmarkTest
    {
        private readonly int[] _nums = { 1, 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 9, 10, 10 };
        
        [Benchmark]
        public void TestHashSetMethod()
        {
            Program.RemoveDuplicatesHashSet(_nums);
        }

        [Benchmark]
        public void TestListMethod()
        {
            Program.RemoveDuplicatesList(_nums);
        }
    }
}