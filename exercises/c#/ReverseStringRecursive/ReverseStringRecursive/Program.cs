namespace ReverseStringRecursive;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseString("Hello World!"));
        Console.WriteLine(ReverseString("CSharp"));
        Console.WriteLine(ReverseString("C#")); 
        Console.WriteLine(ReverseString(""));     
        Console.WriteLine(ReverseString("a"));  

        static string ReverseString(string input)
        {
            if (input.Length <= 1) return input;
            
            return input[input.Length - 1] + ReverseString(input.Substring(0, input.Length - 1));
        }
    }
}