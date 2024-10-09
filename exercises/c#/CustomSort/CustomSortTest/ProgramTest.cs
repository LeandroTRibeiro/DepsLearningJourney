using System.Collections;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = CustomSort.Program;

namespace CustomSortTest;

public class CustomSortTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { new List<string> { "apple", "banana", "cherry", "date" }, new List<string> { "date", "apple", "cherry", "banana" } };
        yield return new object[] { new List<string> { "orange", "kiwi", "grape", "lemon" }, new List<string> { "grape", "lemon", "orange", "kiwi" } };
        yield return new object[] { new List<string> { "x", "yyy", "zz", "a" }, new List<string> { "a", "x", "zz", "yyy" } };
        yield return new object[] { new List<string>(), new List<string>() };
        yield return new object[] { new List<string> { "single" }, new List<string> { "single" } }; 
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class ProgramTest
{
    
    
    [Theory]
    // Arrange
    [ClassData(typeof(CustomSortTestData))]
    public void ShouldReturnAnExpectedResult(List<string> input, List<string> expected)
    {
        // Act
        var result = Program.CustomSort(input);
        
        // Assert
        Assert.Equal(expected, result);
    }
}