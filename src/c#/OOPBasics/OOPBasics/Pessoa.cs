namespace OOPBasics
{
    public class Pessoa
    {
        // Propriedades que armazenam o primeiro nome, sobrenome e idade da pessoa
        public string FirstName;
        public string LastName;
        public int Age;

        // Construtor padrão, permite criar uma instância da classe Pessoa sem inicializar as propriedades
        public Pessoa()
        {
        }

        // Construtor parametrizado, permite criar uma instância da classe Pessoa e inicializar as propriedades
        public Pessoa(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Método que simula a ação de caminhar, exibindo uma mensagem no console
        public void Walking()
        {
            Console.WriteLine($"{FirstName} {LastName} está caminhando!");
        }
    }
}