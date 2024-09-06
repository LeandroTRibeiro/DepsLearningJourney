namespace IsPerfectNumber;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine($"Numero 6 é perfeito: {IsPerfectNumber(6)}");
        Console.WriteLine($"Numero 10 é perfeito: {IsPerfectNumber(10)}");
        Console.WriteLine($"Numero 8 é perfeito: {IsPerfectNumber(8)}");
        
        static bool IsPerfectNumber(int num)
        {

            List<int> dividers = new();
            
            for (int i = 1; i < num; i++)
            {
                if(num % i == 0) dividers.Add(i);
            }
            
            return dividers.Aggregate(0, (acc, item) => acc + item) == num;
        }
    }
}