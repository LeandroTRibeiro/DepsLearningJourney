namespace IsPalindrome2;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine(IsPalindrome(num1));
        
        static bool IsPalindrome(int num) =>
            num >= 0 && int.Parse(
                new string(
                    num.ToString().Reverse().ToArray())
            ) == num;
    }
}