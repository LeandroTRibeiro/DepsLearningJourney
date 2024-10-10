using ReverseWordsInString;

namespace ReverseWordsInStringTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData("Hello World!", "World! Hello")]
    [InlineData("OpenAI is amazing", "amazing is OpenAI")]
    [InlineData("  Leading and trailing spaces  ", "spaces trailing and Leading")] 
    [InlineData("  Multiple    spaces   between  words ", "words between spaces Multiple")] 
    [InlineData("OneWord", "OneWord")] 
    [InlineData("", "")] 
    [InlineData(" ", "")] 
    [InlineData("A B C D", "D C B A")] 
    [InlineData("Repeat repeat repeat", "repeat repeat Repeat")] 
    [InlineData("  ", "")] 
    [InlineData(null, "")] 
    public void ShouldReturnExpectedResult(string input, string expected)
    {
        // Act
        var response = Program.ReverseWords(input);
        
        // Assert
        Assert.Equal(response, expected);
    }
    
    [Theory]
    // Arrange
    [InlineData("Hello World!", "World! Hello")]
    [InlineData("OpenAI is amazing", "amazing is OpenAI")]
    [InlineData("  Leading and trailing spaces  ", "spaces trailing and Leading")] 
    [InlineData("  Multiple    spaces   between  words ", "words between spaces Multiple")] 
    [InlineData("OneWord", "OneWord")] 
    [InlineData("", "")] 
    [InlineData(" ", "")] 
    [InlineData("A B C D", "D C B A")] 
    [InlineData("Repeat repeat repeat", "repeat repeat Repeat")] 
    [InlineData("  ", "")] 
    [InlineData(null, "")] 
    public void ShouldReturnExpectedResult2(string input, string expected)
    {
        // Act
        var response = Program.ReverseWords2(input);
        
        // Assert
        Assert.Equal(response, expected);
    }
}