namespace FindLongestUniqueSubstring.Test;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData("abc", 3)]                      
    [InlineData("bbbbb", 1)]                    
    [InlineData("pwwkew", 2)]                   
    [InlineData("abcdefg", 7)]                  
    [InlineData("abccba", 3)]                   
    [InlineData("dvdf", 2)]                     
    [InlineData("", 0)]                         
    [InlineData("a", 1)]                        
    [InlineData("au", 2)]                       
    [InlineData("abba", 2)]                     
    [InlineData("abcabcbb", 3)]                 
    [InlineData("tmmzuxt", 2)]                  
    [InlineData("anviaj", 4)]                   
    [InlineData(null , 0)]                   
    public void ShouldReturExpectedResult(string input, int expected)
    {
        // Act
        var response = Program.FindLongestUniqueSubstring(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
    
    [Theory]
    // Arrange
    [InlineData("abc", 3)]                      
    [InlineData("bbbbb", 1)]                    
    [InlineData("pwwkew", 2)]                   
    [InlineData("abcdefg", 7)]                  
    [InlineData("abccba", 3)]                   
    [InlineData("dvdf", 2)]                     
    [InlineData("", 0)]                         
    [InlineData("a", 1)]                        
    [InlineData("au", 2)]                       
    [InlineData("abba", 2)]                     
    [InlineData("abcabcbb", 3)]                 
    [InlineData("tmmzuxt", 2)]                  
    [InlineData("anviaj", 4)]                   
    [InlineData(null , 0)]                   
    public void ShouldReturExpectedResult2(string input, int expected)
    {
        // Act
        var response = Program.FindLongestUniqueSubstring2(input);
        
        // Assert
        Assert.Equal(expected, response);
    }
    
}