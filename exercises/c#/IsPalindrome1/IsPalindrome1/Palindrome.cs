using System.Text.RegularExpressions;

namespace IsPalindrome1;

public static class Palindrome
{
    public static bool IsPalindrome(this string input)
    {
        string cleanedInput = Regex.Replace(input, @"[^a-zA-Z0-9]", "").ToLower();
        
        return string.Join("", cleanedInput.Reverse()).Equals(cleanedInput);
    }

    public static Dictionary<string, List<string>> GroupByPalindrome(
        this string[] input)
    {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

        return input
            .GroupBy((word) => word.IsPalindrome() ? "is-palindrome" : "is-not-palindrome")
            .ToDictionary(group => group.Key, group => group.ToList());
    }
}