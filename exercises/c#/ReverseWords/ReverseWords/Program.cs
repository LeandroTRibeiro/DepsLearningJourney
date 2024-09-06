namespace ReverseWords;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Frase: O rato roeu a roupa do rei de Roma\n" +
                          $"Reversa: {ReverseWords("O rato roeu a roupa do rei de Roma")}");
        
        static string ReverseWords(string word) =>  string.Join(" ", word.Split(" ").Reverse());
    }
}