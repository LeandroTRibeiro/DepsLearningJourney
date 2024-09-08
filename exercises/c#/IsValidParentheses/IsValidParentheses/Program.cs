namespace IsValidParentheses;

class Program 
{
    static void Main(string[] args)
    {


        Console.WriteLine(IsValidParentheses("()"));
        Console.WriteLine(IsValidParentheses("()[]{}"));
        Console.WriteLine(IsValidParentheses("(]"));
        Console.WriteLine(IsValidParentheses("([)]"));
        Console.WriteLine(IsValidParentheses("{[]}"));
        
        static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if(stack.Count == 0 || 
                        (c == ')' && stack.Peek() != '(') ||
                        (c == '}' && stack.Peek() != '{') || 
                        (c == ']' && stack.Peek() != '['))
                    {
                        return false;
                    }

                    stack.Pop();

                }
            }
            return stack.Count == 0;
        }
    } 
}
