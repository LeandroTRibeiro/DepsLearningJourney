namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de Galinha e define suas propriedades
            Galinha chicken = new Galinha();

            // Propriedades herdados da classe Animal 
            chicken.Name = "Valentina";
            chicken.Color = "branca";
            
            // Propriedade herdada da classe Ave
            chicken.CanFly = false;
            
            // Executa o método herdado pela classe Animal
            chicken.MakeNoise();
            
            // Executa o método herdado pela classe Ave
            chicken.Fly();
            
            // Executa o método da própria classe
            chicken.Scratch();
            
            // --- 
            
            // Cria uma instância de Canguru usando o construtor com parâmetros herdados da classe Animal e Mamifero
            Canguru kangaroo  = new Canguru("Jack", "Marrom", 2);
            
            // Executa o método herdado da classe Animal
            kangaroo.MakeNoise();

            // Executa o método herdado da classe Mamifero
            kangaroo.FeedYoung();
            
            // Executa o método da própria classe
            kangaroo.Jump();
        }
    }
}