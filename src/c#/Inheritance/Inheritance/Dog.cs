namespace Inheritance;

public class Dog : Animal
{
    public string Breed { get; private set; }

    public Dog() { }

    public Dog(string name, string color, string breed) : base(name, color)
    {
        this.Breed = breed;
    }
}