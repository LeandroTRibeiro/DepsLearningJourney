namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando a classe Pessoa usando o construtor padrão (sem parâmetros)
            Pessoa p1 = new Pessoa();

            // Atribuindo valores às propriedades da instância p1 após a criação
            p1.FirstName = "Leandro";
            p1.LastName = "Ribeiro";
            p1.Age = 33;
            
            // Instanciando a classe Pessoa usando o construtor parametrizado (com atributos iniciais)
            Pessoa p2 = new Pessoa("Bruna", "Martins", 38);
            
            // Usando o método Walking da classe Pessoa para ambas as instâncias
            p1.Walking();
            p2.Walking();
        }
    }
}