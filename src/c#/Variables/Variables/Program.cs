using System;

namespace Variables
{
    class Program
    {
        // Variável global (de instância) - acessível em toda a classe, mas precisa de uma instância
        string globalInstanceVariable = "Global Instance Variable";
        
        // Variável global (estática) - acessível em toda a classe, sem precisar de uma instância
        static string globalStaticVariable = "Global Static Variable";
        
        static void Main(string[] args)
        {

            // Instanciando a classe para acessar a variavel
            Program program = new Program();

            // Variavel Local
            string localVariable = "Local Variable";
            
            // Acessando a variável global de instância
            Console.WriteLine($"Valor da variável global de instância: {program.globalInstanceVariable}");
            
            // Acessando a variável global estática
            Console.WriteLine($"Valor da variável global estática: {globalStaticVariable}");
            
            // Acessando a variável local
            Console.WriteLine($"Valor da variáve local: {localVariable}");
            
            // Declaracao de uma constante
            const string constantVariable = "Constant Variable";
            Console.WriteLine($"Valor da constante: {constantVariable}");
            
        }
    }
}

