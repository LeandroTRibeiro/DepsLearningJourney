using AnagramGrouping;

namespace AnagramGroupingTest;

public class Program_Test
{
    [Theory]
    // Arrange
    [MemberData(nameof(GetAnagramsTestingData))]
    public void ShouldReturnExpectedGroups(List<string> input, List<List<string>> expected)
    {
        // Act
        var response = Program.AnagramGrouping(input);
        
        // Assert
        Assert.Equal(expected.Count, response.Count);

        foreach (var group in expected)
        {
            Assert.Contains(response, r => AreListEqual(r, group));
        }
    }

    private bool AreListEqual(List<string> list1, List<string> list2)
    {
        if (list1.Count != list2.Count)
        {
            return false;
        }
        
        list1.Sort();
        list2.Sort();

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
            {
                return false;
            }
        }

        return true;
    }
    
    // Arrange
    public static IEnumerable<object[]> GetAnagramsTestingData()
    {
        yield return new object[]
        {
            new List<string>
            {
                "listen", "silent", "enlist", "eat", "tea", "tan", "nat", "bat"
            },
            new List<List<string>>
            {
                new List<string> { "listen", "silent", "enlist" },
                new List<string> { "eat", "tea" },
                new List<string> { "tan", "nat" },
                new List<string> { "bat" }
            }
        };
        
        yield return new object[]
        {
            new List<string> { "hello", "olleh", "world", "dlrow" },
            new List<List<string>>
            {
                new List<string> { "hello", "olleh" },
                new List<string> { "world", "dlrow" }
            }
        };

        yield return new object[]
        {
            new List<string> { "abc", "cab", "bac", "xyz", "zyx" },
            new List<List<string>>
            {
                new List<string> { "abc", "cab", "bac" },
                new List<string> { "xyz", "zyx" }
            }
        };
        
        yield return new object[]
        {
            new List<string> { "abc"},
            new List<List<string>>
            {
                new List<string> { "abc" },
            }
        };
        
        yield return new object[]
        {
            new List<string> { ""},
            new List<List<string>>
            {
                new List<string> { "" },
            }
        };
    }

    [Fact]
    public void ShouldReturnThrowAArgumentExceptionWhenInputIsEmpty()
    {
        // Arrange
        List<string> input = new List<string>();
        
        // Act 
        var exception = Assert.Throws<ArgumentException>(() => Program.AnagramGrouping(input));
        
        // Assert
        Assert.Equal("Input cannot be empty.", exception.Message);
    }
    
    [Fact]
    public void ShouldReturnThrowAArgumentExceptionWhenInputIsNull()
    {
        // Arrange
        List<string> input = null;
        
        // Act 
        var exception = Assert.Throws<ArgumentException>(() => Program.AnagramGrouping(input));
        
        // Assert
        Assert.Equal("Input cannot be empty.", exception.Message);
    }
    
}