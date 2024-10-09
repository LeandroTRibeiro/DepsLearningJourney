using FindSecondLargestNumber;

namespace FindSecondLargestNumberTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] {}, 0)]
    [InlineData(new int[] { 4, 1, 7, 9, 2, 8 }, 8)]
    [InlineData(new int[] { 4, 1, 7, 9, 2 }, 7)]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 2, 2, 2 }, 2)]
    [InlineData(null, 0)]
    public void ShouldAssertTheExpectedResult_FindLargestNumber(int[] input, int expected)
    {
        // Act
        var response = Program.FindLargestNumber(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
    
    [Theory]
    // Arrange
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] {}, 0)]
    [InlineData(new int[] { 4, 1, 7, 9, 2, 8 }, 8)]
    [InlineData(new int[] { 4, 1, 7, 9, 2 }, 7)]
    [InlineData(new int[] { 1, 2, 3 }, 2)]
    [InlineData(new int[] { 2, 2, 2 }, 2)]
    [InlineData(null, 0)]
    public void ShouldAssertTheExpectedResult_FindLargestNumber2(int[] input, int expected)
    {
        // Act
        var response = Program.FindLargestNumber2(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
}