namespace Inheritance;

public class Mamifero : Animal
{
    // Propriedade específica para mamíferos
    public int NumberOfLegs { get; set; }

    // Construtor padrão
    public Mamifero() { }
    
    // Construtor que inicializa propriedades de Mamífero e do Animal base
    public Mamifero(string name, string color, int numberOfLegs) : base(name, color)
    {
        NumberOfLegs = numberOfLegs;
    }
    
    // Método que pode ser usado pela própria classe e por outras classes derivadas
    public void FeedYoung()
    {
        Console.WriteLine($"Mamifero {Name} está amamentando seus filhotes.");
    }
}