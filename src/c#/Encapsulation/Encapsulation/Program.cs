using Encapsulation;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe Pessoa com o construtor que aceita parâmetros
            Pessoa p = new Pessoa("Leandro", "Ribeiro", 33);
            
            // Modificando o sobrenome usando o setter público da propriedade LastName
            p.LastName = "Thiago";
            
            // Exibindo o primeiro nome e a idade usando o método GetAge() para acessar o campo privado Age
            Console.WriteLine($"{p.FirstName} tem {p.GetAge()} anos.");
            
            // Chamando o método Walking da classe Pessoa
            p.Walking();
        }
    }
}