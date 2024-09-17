namespace ReverseString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseString("hello world!"));
        
        string ReverseString(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}