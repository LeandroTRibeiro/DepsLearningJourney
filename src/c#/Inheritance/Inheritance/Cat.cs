namespace Inheritance;

public class Cat : Animal
{
    public Cat() { }

    public Cat(string name, string color) : base(name, color) { }

    public override void MakeNoise()
    {
        Console.WriteLine($"{this.Name} says Meow!");
    }
    
}