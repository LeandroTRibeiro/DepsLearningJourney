namespace Polymorphism;

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
    
    // Método virtual que pode ser usado pela própria classe e por outras classes derivadas
    public virtual void FeedYoung()
    {
        Console.WriteLine($"Mamifero {Name} está amamentando seus filhotes.");
    }
}