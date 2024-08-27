namespace Polymorphism;

public class Ave : Animal
{
    // Propriedade específica para aves
    public bool CanFly { get; set; }
    
    // Construtor padrão
    public Ave() { }

    // Construtor que inicializa propriedades de Ave e do Animal base
    public Ave(string name, string color, bool canFly) : base(name, color)
    {
        CanFly = canFly;
    }
    
    // Método virtual que pode ser usado e sobreescrito pela própria classe e por outras classes derivadas
    public virtual void Fly()
    {
        Console.WriteLine($"Ave {Name} está voando...");
    }
}