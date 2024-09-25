using Application.Services;
using Domain.Entities;

namespace Presentation;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person("João", 25),
            new Person("Ana", 30),
            new Person("João", 20),
            new Person("Maria", 22)
        };
        
        PersonService service = new PersonService();
        
        List<Person> sortedListByName = service.SortPeopleByName(people);
        
        Console.WriteLine("Lista ordenada por nome:");
        foreach (var person in sortedListByName)
        {
            Console.WriteLine(person);
        }
        
        Console.WriteLine("Lista ordenada por idade:");
        List<Person> sortedListByAge = service.SortPeopleByAge(people);
        foreach (var person in sortedListByAge) 
        {
            Console.WriteLine(person);
        }
    }
}