using System;

namespace Variables
{
    class Program
    {
        // Variável de instância - acessível em toda a classe, mas precisa de uma instância
        string globalInstanceVariable = "Global Instance Variable";
        
        // Variável estática - acessível em toda a classe, sem precisar de uma instância
        static string globalStaticVariable = "Global Static Variable";
        
        // Variável privada (de instância) - acessível em toda a classe, mas precisa de uma instância
        private string privateVariable = "Private Variable";
        
        static void Main(string[] args)
        {
            // Instanciando a classe para acessar as variáveis de instância
            Program program = new Program();
            
            // Acessando a variável de instância
            Console.WriteLine($"Valor da variável de instância: {program.globalInstanceVariable}");
            
            // Acessando a variável estática
            Console.WriteLine($"Valor da variável estática: {globalStaticVariable}");
            
            // Acessando a variável privada de instância
            Console.WriteLine($"Valor da variável privada de instância: {program.privateVariable}");
            
            // Variável Local
            string localVariable = "Local Variable";
            
            // Acessando a variável local
            Console.WriteLine($"Valor da variável local: {localVariable}");
            
            // Declaração de uma constante
            const string constantVariable = "Constant Variable";
            Console.WriteLine($"Valor da constante: {constantVariable}");
            
            // Declaração de uma variável com inferência de tipo
            var inferredVariable = "Inferred Variable";
            Console.WriteLine($"Valor da variável com inferência de tipo: {inferredVariable}");
        }
    }
}