namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            
            // Método Replace substitui "World" por "C#"
            Console.WriteLine(str.Replace("World", "C#"));
            
            // Método Substring retorna uma parte da string começando no índice 6 com comprimento 6
            Console.WriteLine(str.Substring(6, 6));
            
            // Métodos Trim removem espaços em branco no início, no final ou em ambos
            str = "    Hello World!    ";
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.TrimEnd());
            Console.WriteLine(str.Trim());

            // Método Split divide uma string em um array de strings com base no delimitador ", "
            str = "Toyota, Fiat, Iveco, Audi, Renault, Hyundai";
            string[] cars = str.Split(", ");
            Console.WriteLine($"[\"{string.Join("\", \"", cars)}\"]");
            
            Console.WriteLine("\n");
            
            // Método Join concatena um array de strings em uma única string, separada por ", "
            Console.WriteLine(string.Join(", ", cars));
            
            // Métodos ToUpper e ToLower convertem a string para maiúsculas ou minúsculas
            str = "Hello World!";
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            
            // Método Contains verifica se a string contém a substring "Hello"
            Console.WriteLine(str.Contains("Hello"));
            
            // Método IndexOf retorna o índice de início da substring "World!"
            Console.WriteLine(str.IndexOf("World!"));

            // Método Remove remove uma parte da string começando no índice 6 com comprimento 6
            Console.WriteLine(str.Remove(6, 6));
            
            // Método Insert insere ", C#" na posição 5 da string
            Console.WriteLine(str.Insert(5, ", C#"));
        }
    }
}
