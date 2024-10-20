using SingleNumber;

namespace SingleNumberTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, new int[] { })]                 
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]       
    [InlineData(new int[] { 7, 8, 9, 7, 9, 8 }, new int[] { })]                 
    [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { })]                        
    [InlineData(new int[] { 10, 20, 10, 30, 20 }, new int[] { 30 })]             
    [InlineData(new int[] { }, new int[] { })]                                   
    [InlineData(new int[] { 100 }, new int[] { 100 })]                           
    [InlineData(new int[] { -1, -2, -3, -1, -2 }, new int[] { -3 })]             
    [InlineData(new int[] { 0, 0, 0 }, new int[] { })]  
    public void ShouldReturnExpectedResult(int[] input, int[] expected)
    {
        // Act
        var result = Program.SingleNumber(input.ToList());
        
        // Assert
        Assert.Equal(expected.ToList(), result);
    }
    
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { 1, 1, 2, 2, 3, 3 }, new int[] { })]                 
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, new int[] { 5, 4, 3, 2, 1 })]       
    [InlineData(new int[] { 7, 8, 9, 7, 9, 8 }, new int[] { })]                 
    [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { })]                        
    [InlineData(new int[] { 10, 20, 10, 30, 20 }, new int[] { 30 })]             
    [InlineData(new int[] { }, new int[] { })]                                   
    [InlineData(new int[] { 100 }, new int[] { 100 })]                           
    [InlineData(new int[] { -1, -2, -3, -1, -2 }, new int[] { -3 })]             
    [InlineData(new int[] { 0, 0, 0 }, new int[] { })]  
    public void ShouldReturnExpectedResult2(int[] input, int[] expected)
    {
        // Act
        var result = Program.SingleNumber2(input.ToList());
        
        // Assert
        Assert.Equal(expected.ToList(), result);
    }
}