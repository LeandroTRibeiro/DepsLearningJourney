namespace Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(Fibonacci(6));
        
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        
        return Fibonacci(n -1 ) + Fibonacci(n - 2);
    }
}