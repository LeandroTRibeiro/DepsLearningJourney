namespace FilterOutCommonWords;

class Program
{
    static void Main(string[] args)
    {
        List<string> mainWords = new List<string> { "cachorro", "gato", "pássaro", "peixe", "leão" };
        List<string> commonWords = new List<string> { "gato", "peixe" };

        List<string> response = FilterOutCommonWords(mainWords, commonWords);

        foreach (string word in response)
        {
            Console.WriteLine(word);
        }

        static List<string> FilterOutCommonWords(List<string> mainWords, List<string> commonWords)
        {
            return mainWords.Where((item) => !commonWords.Contains(item)).ToList();
        }
    }
}