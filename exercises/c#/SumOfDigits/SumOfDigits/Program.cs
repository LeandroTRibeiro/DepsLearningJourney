namespace SumOfDigits;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine($"Soma dos dígitos de 1234: {SumOfDigits(1234)}");
        Console.WriteLine($"Soma dos dígitos de -567: {SumOfDigits(-567)}");
        
        static int SumOfDigits(int num) => NumberToArray(Math.Abs(num)).Aggregate(0, (acc, item) => acc + item);
        
        static int[] NumberToArray(int num) => Math.Abs(num).ToString().Select(c => int.Parse(c.ToString())).ToArray();
    }
}