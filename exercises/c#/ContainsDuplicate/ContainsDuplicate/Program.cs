namespace ContainsDuplicate;

class Program
{
    static void Main(string[] agrs)
    {
        
        Console.WriteLine(ContainsDuplicate(new int[]{1, 2, 3, 4, 5, 6}));
        Console.WriteLine(ContainsDuplicate(new int[]{1, 2, 3, 4, 1, 6}));
        Console.WriteLine(ContainsDuplicate(new int[] {}));
        Console.WriteLine(ContainsDuplicate(new int[] {1}));
        Console.WriteLine(ContainsDuplicate(new int[]{1, 2, 3, 4, 3, 6}));
        
        
        static bool ContainsDuplicate(int[] arr)
        {
            if (arr.Length < 2) return false;

            HashSet<int> hashSet = new HashSet<int>();

            foreach (int item in arr)
            {
                if (hashSet.Contains(item)) return true;
                
                hashSet.Add(item);
            }

            return false;
        }
    }
}