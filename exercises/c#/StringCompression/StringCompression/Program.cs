using System;
using System.Text;

/*
Descrição: Escreva um programa em C# que comprima uma string usando a contagem de caracteres repetidos consecutivamente. Por exemplo, a string "aaabcccccaaa" deve ser convertida para "a3b1c5a3". Se a string comprimida não for menor que a string original, o programa deve retornar a string original.
*/

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaabcccccaaa";
            string str2 = "abcd";
            string str3 = "aabbccdd";
            string str4 = "aaaaaaaabbccdd";

            Console.WriteLine(CompressString(str1));
            Console.WriteLine(CompressString(str2));
            Console.WriteLine(CompressString(str3)); 
            Console.WriteLine(CompressString(str4)); 
        }

        static string CompressString(string input)
        {
            StringBuilder compressed = new StringBuilder();
            int countConsecutive = 0;

            for (int i = 0; i < input.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= input.Length || input[i] != input[i + 1])
                {
                    compressed.Append(input[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            return compressed.Length < input.Length ? compressed.ToString() : input;
        }
    }
}