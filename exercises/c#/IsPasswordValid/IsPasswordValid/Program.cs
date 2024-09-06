namespace IsPasswordValid;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(IsPasswordValid("Aa1!abcd"));
        Console.WriteLine(IsPasswordValid("abc123"));   
        Console.WriteLine(IsPasswordValid("Password1!"));
        
        static bool IsPasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            
            if (password.Length < 8) return false;
            
            if(!password.Any(char.IsUpper)) return false;
            if(!password.Any(char.IsLower)) return false;
            
            if(!password.Any(char.IsDigit)) return false;
            
            if(!password.Any(ch => !char.IsLetterOrDigit(ch))) return false;

            return true;
        }
    }
}

