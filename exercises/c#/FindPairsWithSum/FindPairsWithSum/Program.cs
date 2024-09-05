namespace FindPairsWithSum;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new() {1, 2, 3, 4, 5, 6};
        int target = 7;
        
        List<List<int>> result = FindPairsWithSum(numeros, target);

        foreach (List<int> element in result)
        {
            Console.WriteLine($"Pares de numero que a soma dao {target}: {element[0]}, {element[1]}");
        }

        List<List<int>> FindPairsWithSum(List<int> array, int target)
        {
            List<List<int>> result = new();
            List<int> alreadyRead = new();

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    if ((array[i] + array[j] == target) 
                        && !alreadyRead.Contains(array[i]) 
                        && !alreadyRead.Contains(array[j]))
                    {
                        alreadyRead.Add(array[i]);
                        alreadyRead.Add(array[j]);
                        result.Add(new List<int> { array[i], array[j] });
                    }
                }
            }
            
            return result;
        }
        
    }
}