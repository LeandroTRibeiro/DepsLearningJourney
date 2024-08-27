namespace Inheritance;

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

}