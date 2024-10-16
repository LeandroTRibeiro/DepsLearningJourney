using RomanToInt;

namespace RomanToIntTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData("I", 1)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    [InlineData("", 0)]
    [InlineData(" ", 0)]
    [InlineData(null, 0)]
    [InlineData("iv", 4)]
    [InlineData("xx", 20)]
    [InlineData(" X  L  ", 40)]
    [InlineData("IIII", -1)]  
    [InlineData("ABCM", -1)]  
    [InlineData("MMMDCCCLXXXVIII", 3888)] 
    [InlineData("CCCC", -1)] 
    [InlineData("VV", -1)] 
    [InlineData("XXXX", -1)] 
    [InlineData("LL", -1)] 
    [InlineData("DD", -1)] 
    [InlineData("MMMM", -1)] 
    public void ShouldReturnExpectedResult(string roman, int expected)
    {
        // Act
        var result = Program.RomanToInt(roman);
        
        // Assert
        Assert.Equal(expected, result);
    }
}