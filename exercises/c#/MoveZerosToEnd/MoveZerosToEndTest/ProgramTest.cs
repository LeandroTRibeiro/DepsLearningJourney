using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = MoveZerosToEnd.Program;

namespace MoveZerosToEndTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 3, 12, 0, 0 }, new int[] { 0, 1, 0, 3, 12 })]
    [InlineData(new int[] { 1, 3, 12 }, new int[] { 1, 3, 12 })]
    [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 2 }, new int[] { 2 })]
    [InlineData(new int[] { -1, -2, -3, 0, 0, 0 }, new int[] { 0, -1, 0, -2, 0, -3 })]
    public void ShouldReturnTheExpectedResults(int[] expected, int[] input)
    {
        // Act 
        var response = Program.MoveZerosToEndLinq(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 3, 12, 0, 0 }, new int[] { 0, 1, 0, 3, 12 })]
    [InlineData(new int[] { 1, 3, 12 }, new int[] { 1, 3, 12 })]
    [InlineData(new int[] { 0, 0 }, new int[] { 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 2 }, new int[] { 2 })]
    [InlineData(new int[] { -1, -2, -3, 0, 0, 0 }, new int[] { 0, -1, 0, -2, 0, -3 })]
    public void ShouldReturnTheExpectedResultsSecondFunc(int[] expected, int[] input)
    {
        // Act 
        List<int> convertedArray = input.ToList();
        Program.MoveZerosToEndInPlace(convertedArray);
        
        // Assert
        Assert.Equal(expected, convertedArray);
    }
}