namespace Polymorphism;

public class Canguru : Mamifero
{
    // Construtor padrão
    public Canguru() { }
    
    // Construtor que inicializa propriedades de Canguru e da classe base Mamifero
    public Canguru(string name, string color, int numberOfLegs) : base(name, color, numberOfLegs) { }

    // Método que pode ser usado pela própria classe
    public void Jump()
    {
        Console.WriteLine($"Canguru {Name} está pulando ... ");
    }

    // Método sobreescrito da classe Mamifero
    public override void FeedYoung()
    {
        Console.WriteLine($"Canguru {Name} não tem filhotes!");
    }
    
    // Método sobreescrito da classe Animal
    public override void MakeNoise()
    {
        Console.WriteLine($"Canguru {Name} de cor {Color} faz esse som ao pular: Thump, Thump, Thump...");
    }
}