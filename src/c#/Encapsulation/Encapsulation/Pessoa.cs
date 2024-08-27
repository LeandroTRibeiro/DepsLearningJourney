namespace Encapsulation
{
    public class Pessoa
    {
        // Propriedade pública para leitura do nome, mas com setter privado
        public string FirstName { get; private set; } 
        
        // Propriedade com getter privado e setter público
        public string LastName { private get; set; }
        
        // Campo privado, acessado apenas dentro da classe
        private int Age;
        
        public Pessoa() { }

        // Construtor que inicializa as propriedades da classe
        public Pessoa(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Método público para acessar o campo privado Age
        public int GetAge()
        {
            return this.Age;
        }

        // Método que exibe uma mensagem usando os dados da classe
        public void Walking()
        {
            Console.WriteLine($"{FirstName} {LastName} está caminhando!");
        }
    }
}