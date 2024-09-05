namespace FizzBuzzPrime;

class Program
{
    static void Main(string[] args)
    {
        
        FizzBuzzPrime(1, 100);

        void FizzBuzzPrime(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                string response = "";
                if(IsPrime(i)) response += "Prime\t";
                if (i % 3 == 0 && i % 5 == 0)
                {
                    response += "FizzBuzz";
                } else
                {
                    if (i % 3 == 0)
                    {
                        response += "Fizz";
                    } else if (i % 5 == 0)
                    {
                        response += "Buzz";
                    }
                    else
                    {
                        response += $"{i}";
                    }
                };
                Console.WriteLine(response);
            }
        }
        
        bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number is 2 or 3) return true; // merge pattern
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }
            return true;
        }
    }
}