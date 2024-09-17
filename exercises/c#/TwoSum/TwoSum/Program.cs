namespace TwoSum;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new() { 3, 2, 4 };
        int target = 6;
        
        TwoSum(numbers, target);

    }
    static void TwoSum(List<int> numbers, int target)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    Console.WriteLine($"A soma de {numbers[i]} + {numbers[j]} = {target}, que sao os indices {i} e {j}");
                    return;
                }
            }
        }
        
        Console.WriteLine($"Nenhuma soma dos numeros do array dao o resultado de {target}");
    }
}