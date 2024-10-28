namespace IsPalindrome1;

public class Program
{
    static void Main(string[] args)
    {
        string input = "A man, a plan, a canal: Panama";
        
        string[] inputArray = { 
            "ovo", "banana", "racecar", "hello", 
            "level", "world", "madam", "noon", "rotor", 
            "civic", "deified", "radar", "banana", 
            "programming", "openai", "technology"  
        };
        
        Console.WriteLine(input.IsPalindrome());

        var palindromeDictonary = inputArray.GroupByPalindrome();

        foreach (var key in palindromeDictonary.Keys)
        {
            Console.Write($"{ key }: ");
            foreach (var word in palindromeDictonary[key])
            {
                Console.Write($"{ word }, ");
            }
            Console.WriteLine();
        }
    }

    
}
