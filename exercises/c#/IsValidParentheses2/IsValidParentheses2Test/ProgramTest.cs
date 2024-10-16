using IsValidParentheses2;

namespace IsValidParentheses2Test;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData("()", true)]
    [InlineData("(]", false)]  
    [InlineData("([)]", false)]  
    [InlineData("{[}]", false)]  
    [InlineData("(((((", false)]  
    [InlineData("))))", false)]   
    [InlineData("", false)]
    [InlineData(null, false)]
    [InlineData("([{([{}])}])", true)]
    [InlineData("{}", true)]
    [InlineData("[]", true)]
    [InlineData("A{B}C", true)]
    [InlineData("(abcdef)", true)]
    [InlineData("a(b{c[d]e}f)G", true)]
    [InlineData(" ( { [ ] } ) ", true)]
    public void ShouldReturnExpectedResult(string input, bool expected)
    {
        // Act
        var result = Program.IsValidParentheses(input);
        
        // Assert
        Assert.Equal(expected, result);
    }
}