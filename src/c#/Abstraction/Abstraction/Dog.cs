namespace Abstraction;
// Classe derivada Dog que herda de Animal
public class Dog : Animal
{
    // Implementação do método abstrato MakeSound específico para Dog
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof Woof!");
    }
    
    // Implementação do método abstrato Move específico para Dog
    public override void Move()
    {
        Console.WriteLine("Move to right!");
    }
}