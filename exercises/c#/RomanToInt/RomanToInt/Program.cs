namespace RomanToInt;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(RomanToInt("III"));
        Console.WriteLine(RomanToInt("IV"));
        Console.WriteLine(RomanToInt("IX"));
        Console.WriteLine(RomanToInt("LVIII"));
        Console.WriteLine(RomanToInt("MCMXCIV"));
        
    }

    public static int RomanToInt(string roman)
    {
        if(string.IsNullOrEmpty(roman)) return 0;
        
        roman = roman.ToUpper().Replace(" ", "");
        
        string[] invalidRepetitions = { "IIII", "VV", "XXXX", "LL", "CCCC", "DD", "MMMM" };

        foreach (string invalidRepetition in invalidRepetitions)
        {
            if (roman.Contains(invalidRepetition))
            {
                return -1;
            }
        }
        
        Dictionary<char, int> romanMap = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        

        
        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (romanMap.ContainsKey(roman[i]))
            {
                if (i < roman.Length - 1 && romanMap[roman[i]] < romanMap[roman[i + 1]])
                {
                    result -= romanMap[roman[i]];
                }
                else
                {
                    result += romanMap[roman[i]];
                }
            }
            else
            {
                return -1;
            }
        }
        
        return result;
    }
}