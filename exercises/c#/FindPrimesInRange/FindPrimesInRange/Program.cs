namespace FindPrimesInRange;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> primes = FindPrimesInRange(0, 100);

        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
        
        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> response = new();

            for (int i = start; i <= end; i++)
            {
                if(IsPrime(i)) response.Add(i);
            }
            
            return response;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number is 2 or 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }

            return true;
        }
    }
}