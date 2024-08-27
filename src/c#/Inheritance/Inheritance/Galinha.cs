namespace Inheritance;

public class Galinha : Ave
{
    // Construtor padrão
    public Galinha() { }

    // Construtor que inicializa propriedades de Galinha e da classe base Ave
    public Galinha(string name, string color, bool canFly) : base(name, color, canFly) { }
    
    // Método que pode ser usado pela própria classe
    public void Scratch()
    {
        Console.WriteLine($"Galinha {Name} está siscando...");
    }
}