using System.Numerics;

namespace Factorial;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(5));
    }

    static BigInteger Factorial(int n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}