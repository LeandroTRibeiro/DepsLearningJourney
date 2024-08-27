namespace Abstraction;
// Classe derivada Cat que herda de Animal
public class Cat : Animal
{
    // Implementação do método abstrato MakeSound específico para Cat
    public override void MakeSound()
    {
        Console.WriteLine("Meow Meow Meow!");
    }

    // Implementação do método abstrato Move específico para Cat
    public override void Move()
    {
        Console.WriteLine("Move to left!");
    }
}