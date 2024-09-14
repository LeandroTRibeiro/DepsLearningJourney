namespace MangoSeller;

public class Person
{
    public string Name { get; set; }
    public bool MangoSeller { get; set; }

    public Person(string name, bool mangoSeller)
    {
        Name = name;
        MangoSeller = mangoSeller;
    }
}