namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 20, 15, 1, 40, 150, 87, 36, 12, 0, 15 };
            List<int> sortedNumbers = QuickSort(numbers);

            foreach (int number in sortedNumbers)
            {
                Console.Write($"{number} ");
            }
            
        }

        static List<int> QuickSort(List<int> list)
        {
            if (list.Count < 2)
            {
                return list;
            }
            else
            {
                int pivot = list[0];
                
                List<int> minors = list.Skip(1).Where(x => x <= pivot).ToList();
                List<int> bigger = list.Skip(1).Where(x => x > pivot).ToList();

                List<int> result = QuickSort(minors)
                    .Concat(new List<int> { pivot })
                    .Concat(QuickSort(bigger))
                    .ToList();
                
                return result;
            }
            
        }
    }
}