namespace IsValidParentheses2;

public class Program
{
    static void Main(string[] args)
    {
        string input = "(({{[()]}}))";
        
        Console.WriteLine(IsValidParentheses(input));
    }

    public static bool IsValidParentheses(string input)
    {
        if (string.IsNullOrEmpty(input)) return false;
        
        Stack<char> stack = new Stack<char>();
        
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(' || input[i] == '{' || input[i] == '[')
            {
                stack.Push(input[i]);
            } else if (input[i] == ')' || input[i] == '}' || input[i] == ']')
            {
                if (stack.Count == 0) return false;
                
                var top = stack.Pop();

                if ((input[i] == ')' && top != '(') ||
                    (input[i] == '}' && top != '{') ||
                    (input[i] == ']' && top != '['))
                {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}