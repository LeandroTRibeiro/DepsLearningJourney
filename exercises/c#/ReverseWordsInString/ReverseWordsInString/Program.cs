namespace ReverseWordsInString;

public class Program
{
    static void Main(string[] args)
    {
        string input = "Hello world today";
        
        Console.WriteLine(ReverseWords(input));
        Console.WriteLine(ReverseWords2(input));
    }

    public static string ReverseWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }
        
        return String.Join(" ", input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries ).Reverse());
    }

    public static string ReverseWords2(string input)
    {
        
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }
        
        List<string> words = new List<string>();
        string reversed = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                reversed += input[i];
            }

            if (input[i] == ' ' || input.Length - 1 == i)
            {
                if (reversed != "")
                {
                    words.Add(reversed);
                    reversed = "";
                }
            }
        }

        reversed = "";
        
        for (int i = words.Count - 1; i >= 0; i--)
        {
            reversed += words[i];

            if (i > 0)
            {
                reversed += ' ';
            }
        }
        
        return reversed;
    }
}