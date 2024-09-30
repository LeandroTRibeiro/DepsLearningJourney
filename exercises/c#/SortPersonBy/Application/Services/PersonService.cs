using Domain.Entities;

namespace Application.Services;

public class PersonService
{
    public List<Person> SortPeopleByName(List<Person> people)
    {
        if (people == null || !people.Any())
        {
            return new List<Person>();
        }
        
        return people.OrderBy(p => p.Name).ToList();
    }

    public List<Person> SortPeopleByAge(List<Person> people)
    {
        if (people == null || !people.Any())
        {
            return new List<Person>();
        }
        
        return people.OrderBy(p => p.Age).ToList();
    }
    
}