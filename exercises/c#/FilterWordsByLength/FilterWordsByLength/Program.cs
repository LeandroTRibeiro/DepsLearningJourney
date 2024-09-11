namespace FilterWordsByLength;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new() { "banana", "uva", "laranja", "manga", "pera" };
        
        List<string> filteredWords = FilterWordsByLength(words, 4);

        foreach (string word in filteredWords)
        {
            Console.WriteLine(word);
        }

        static List<string> FilterWordsByLength(List<string> words, int length)
        {
            return words.Where(w => w.Length > length).ToList();
        }
    }
}