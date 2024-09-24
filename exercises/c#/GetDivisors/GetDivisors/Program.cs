namespace GetDivisors;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero que deseja encontrar os divisores: ");
        int n = int.Parse(Console.ReadLine()!);
        
        var divisors = GetDivisors(n);
        
        foreach (var divisor in divisors)
        {
            Console.WriteLine(divisor);
        }
    }

    public static IEnumerable<int> GetDivisors(int number)
    {
        if (number == null || number <= 0)
        {
            throw new ArgumentException("Deve ser um numero maior que zero.");
        }
        
        return Enumerable.Range(1, number).Where(n => number % n == 0);
    }
    
}