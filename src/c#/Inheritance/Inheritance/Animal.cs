namespace Inheritance;

public class Animal
{
    // Propriedades básicas comuns a todos os animais
    public string Name { get; set; }
    public string Color { get; set; }

    // Construtor padrão
    public Animal() { }

    // Construtor que inicializa as propriedades comuns
    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
    }
    
    // Método que pode ser usado pela própria classe e por outras classes derivadas
    public void MakeNoise()
    {
        Console.WriteLine($"Animal {Name} esta fazendo barulho!");
    }
}