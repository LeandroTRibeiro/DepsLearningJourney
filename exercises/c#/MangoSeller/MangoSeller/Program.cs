namespace MangoSeller;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person(name: "Leandro", mangoSeller: false);
        
        Person person2 = new Person(name: "Bruna", mangoSeller: false);
        Person person3 = new Person(name: "Rosa", mangoSeller: false);
        Person person4 = new Person(name: "Eduardo", mangoSeller: false);
        
        Person person5 = new Person(name: "Gabrielli", mangoSeller: false);
        Person person6 = new Person(name: "Leticia", mangoSeller: false);
        
        Person person7 = new Person(name: "Bia", mangoSeller: true);

        Graph graph = new();
        
        graph.AddPerson(person1);
        graph.AddPerson(person2);
        graph.AddPerson(person3);
        graph.AddPerson(person4);
        graph.AddPerson(person5);
        graph.AddPerson(person6);
        graph.AddPerson(person7);
        
        graph.AddConnection(person1, person2);
        graph.AddConnection(person1, person3);
        graph.AddConnection(person1, person4);
        
        graph.AddConnection(person2, person5);
        graph.AddConnection(person2, person6);
        
        graph.AddConnection(person4, person7);
        
        graph.ShowConnections();
        
        Console.WriteLine($"{person1.Name} esta conectado a algum vendedor de mangas? {graph.BFS(person1, p => p.MangoSeller)}");
    }
}