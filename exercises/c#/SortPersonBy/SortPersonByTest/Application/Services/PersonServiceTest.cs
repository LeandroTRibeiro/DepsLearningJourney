using Application.Services;
using Domain.Entities;
using Xunit;

namespace SortPersonByTest.Application.Services;

public class PersonServiceTest
{
    [Fact]
    public void SortPeopleByName_ShouldReturn_PeopleOrderedByName()
    {
        // Arrage
        var service = new PersonService();
        var people = new List<Person>
        {
            new Person("João", 25),
            new Person("Ana", 30),
            new Person("Maria", 22)
        };
        
        // Act
        var sortedPeople = service.SortPeopleByName(people);

        //Assert
        
        Assert.Equal("Ana", sortedPeople[0].Name);
        Assert.Equal("João", sortedPeople[1].Name);
        Assert.Equal("Maria", sortedPeople[2].Name);
    }

    [Fact]
    public void SortPeopleByAge_ShouldReturn_PeopleOrderedByAge()
    {
        // Arrange
        var service = new PersonService();
        var people = new List<Person>
        {
            new Person("João", 25),
            new Person("Ana", 30),
            new Person("Maria", 22)
        };
        
        // Act
        var sortedPeople = service.SortPeopleByAge(people);
        
        // Assert
        Assert.Equal(22 , sortedPeople[0].Age);
        Assert.Equal(25, sortedPeople[1].Age);
        Assert.Equal(30, sortedPeople[2].Age);
    }

    [Fact]
    public void SortPeopleByName_ShouldReturn_EmptyList_WhenIsInvalidList()
    {
        // Arrange
        var service = new PersonService();
        
        // Act
        var sortedPeople = service.SortPeopleByName(null);
        
        //Assert
        Assert.Empty(sortedPeople);
    }
    
    [Fact]
    public void SortPeopleByName_ShouldReturn_EmptyList_WhenIsEmptyList()
    {
        // Arrange
        var service = new PersonService();
        var people = new List<Person>();
        
        // Act
        var sortedPeople = service.SortPeopleByName(people);
        
        //Assert
        Assert.Empty(sortedPeople);
    }
    
    [Fact]
    public void SortPeopleByAge_ShouldReturn_EmptyList_WhenIsInvalidList()
    {
        // Arrange
        var service = new PersonService();
        
        // Act
        var sortedPeople = service.SortPeopleByAge(null);
        
        //Assert
        Assert.Empty(sortedPeople);
    }
    
    [Fact]
    public void SortPeopleByAge_ShouldReturn_EmptyList_WhenIsEmptyList()
    {
        // Arrange
        var service = new PersonService();
        var people = new List<Person>();
        
        // Act
        var sortedPeople = service.SortPeopleByAge(people);
        
        //Assert
        Assert.Empty(sortedPeople);
    }
}