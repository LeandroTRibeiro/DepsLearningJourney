namespace Inheritance;

public class Animal
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Animal() { }

    public Animal(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void WalkUp()
    {
        Console.WriteLine("Walking up!");
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"{Name} makes noise!");
    }
}