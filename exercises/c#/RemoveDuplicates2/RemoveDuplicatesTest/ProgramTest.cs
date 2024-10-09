using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = RemoveDuplicates.Program;

namespace RemoveDuplicatesTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 2, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 5, 5, 7, 7 }, new int[] { 1, 2, 3, 4, 5, 7 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(null, new int[] { })]
    public void ShouldReturnExpectedResultHashSet(int[] input, int[] expected)
    {
        // Act
        var response = Program.RemoveDuplicatesHashSet(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
    
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 2, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4, 5, 5, 7, 7 }, new int[] { 1, 2, 3, 4, 5, 7 })]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(null, new int[] { })]
    public void ShouldReturnExpectedResultList(int[] input, int[] expected)
    {
        // Act
        var response = Program.RemoveDuplicatesList(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
}