namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos Primitivos:
            char letter = 'L';                 
            Console.WriteLine($"char: {letter} - Representa um único caractere Unicode.");

            int age = 33;                      
            Console.WriteLine($"int: {age} - Representa um número inteiro.");

            double height = 1.78;              
            Console.WriteLine($"double: {height} - Representa um número de ponto flutuante.");

            bool internship = true;            
            Console.WriteLine($"bool: {internship} - Representa um valor booleano (verdadeiro ou falso).");

            float temperature = 36.6f;         
            Console.WriteLine($"float: {temperature} - Representa um número de ponto flutuante menor.");

            decimal salary = 50000.75m;        
            Console.WriteLine($"decimal: {salary} - Representa um número decimal, usado para cálculos financeiros.");

            long population = 7800000000L;     
            Console.WriteLine($"long: {population} - Representa um número inteiro longo.");

            byte ageInYears = 33;              
            Console.WriteLine($"byte: {ageInYears} - Representa um número inteiro até 255.");

            // Tipos adicionais:
            string name = "Leandro";           
            Console.WriteLine($"string: {name} - Representa uma sequência de caracteres.");

            DateTime currentDate = DateTime.Now; 
            Console.WriteLine($"DateTime: {currentDate} - Representa a data e hora atuais.");

            Guid userId = Guid.NewGuid();      
            Console.WriteLine($"Guid: {userId} - Representa um identificador global único.");


        }
    }
}