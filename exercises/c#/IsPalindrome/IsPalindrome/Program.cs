using System.Text.RegularExpressions;

/*
Desafio: Verificação de Palíndromo
Descrição: Um palíndromo é uma palavra, frase, número ou outra sequência de caracteres que lê da mesma forma de trás para frente (ignorando espaços, pontuação e capitalização). Sua tarefa é criar um programa em C# que verifique se uma string fornecida é um palíndromo.
*/


namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "A man, a plan, a canal, Panama!";
            string str2 = "Hello, World!";
            string str3 = "racecar";

            Console.WriteLine(IsPalindrome(str1));
            Console.WriteLine(IsPalindrome(str2));
            Console.WriteLine(IsPalindrome(str3));
        }

        static bool IsPalindrome(string str)
        {
            string trimStr = Regex.Replace(str, @"[^a-zA-Z]", "").ToLower();
            string reversedStr = new string(trimStr.Reverse().ToArray());

            return trimStr == reversedStr;
        }
    }
}