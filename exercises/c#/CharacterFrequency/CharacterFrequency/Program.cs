namespace CharacterFrequency;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<char, int> frequency = new();

        frequency = CharacterFrequency("Hello World");

        foreach (var character in frequency)
        {
            Console.WriteLine($"{character.Key}: {character.Value}");
        }
        
        static Dictionary<char, int> CharacterFrequency(string input)
        {
            Dictionary<char, int> response = new();

            foreach (char c in input)
            {
                if (c == ' ') continue;
                
                if (response.ContainsKey(c))
                {
                    response[c] += 1;
                }
                else
                {
                    response.Add(c, 1);
                }
            }
            
            return response;
        }
    }
}