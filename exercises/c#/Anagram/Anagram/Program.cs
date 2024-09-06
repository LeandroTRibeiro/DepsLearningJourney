namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool AreAnagram(string a, string b)
            {
                var wordA = a.ToLower().Replace(" ", "").ToCharArray();
                var wordB = b.ToLower().Replace(" ", "").ToCharArray();
                
                Array.Sort(wordA);
                Array.Sort(wordB);
                
                return string.Equals(new string(wordA), new string(wordB));
            }

            Console.WriteLine(AreAnagram("Listen", "Silent"));
            Console.WriteLine(AreAnagram("A gentleman", "Elegant man"));
            Console.WriteLine(AreAnagram("School master", "The classroom"));
            Console.WriteLine(AreAnagram("Hello", "Olleh"));
            Console.WriteLine(AreAnagram("Hello", "World"));
            
        }
    }
}