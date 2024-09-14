namespace MangoSeller;

public class Graph
{
    private Dictionary<Person, List<Person>> connections;

    public Graph()
    {
        connections = new Dictionary<Person, List<Person>>();
    }

    public void AddPerson(Person person)
    {
        if (!connections.ContainsKey(person))
        {
            connections[person] = new List<Person>();
        }
    }

    public void AddConnection(Person person, Person connection)
    {
        if (connections.ContainsKey(person) && connections.ContainsKey(connection))
        {
            connections[person].Add(connection);
        }
    }

    public bool BFS(Person start, Func<Person, bool> predicate)
    {
        if (!connections.ContainsKey(start))
        {
            return false;
        }

        var visited = new HashSet<Person>();
        var queue = new Queue<Person>();
        
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            Person current = queue.Dequeue();

            if (predicate(current))
            {
                return true;
            }
            
            foreach (var neighbor in connections[current])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
        
        return false;
    }

    public void ShowConnections()
    {
        foreach (var person in connections.Keys)
        {
            Console.WriteLine($"{person.Name} esta conectado a :");
            foreach (var neighbor in connections[person])
            {
                   Console.WriteLine($"{neighbor.Name} - vendedor de mangas: {neighbor.MangoSeller}");
            }
        }
    }
}