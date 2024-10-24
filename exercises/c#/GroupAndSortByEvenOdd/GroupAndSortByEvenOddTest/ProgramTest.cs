using GroupAndSortByEvenOdd;
using Xunit;

namespace GroupAndSortByEvenOddTest;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData( 
        new int[] { 10, 15, 3, 7, 2, 8, 23, 14 }, 
        new int[] { 2, 8, 10, 14 },               
        new int[] { 3, 7, 15, 23 }                
    )]
    [InlineData(
        new int[] { },                             
        new int[] { },                             
        new int[] { }                              
    )]
    [InlineData(
        new int[] { 2, 4, 6, 8 },                         
        new int[] { 2, 4, 6, 8 },                   
        new int[] { }                              
    )]
    [InlineData(
        new int[] { 1, 3, 5, 7 },                           
        new int[] { },                             
        new int[] { 1, 3, 5, 7 }          
        )]
    public static void ShouldReturnExpectedResult(
        int[] input, 
        int[] expectedEven,
        int[] expectedOdd
        )
    {
        // Act
        var dictionary = Program.GroupSortByEvenOdd(input.ToList());
        
        // Assert
        Assert.True(dictionary.ContainsKey("odd"));
        Assert.Equal(expectedOdd.ToList(), dictionary["odd"]);
        
        Assert.True(dictionary.ContainsKey("even"));
        Assert.Equal(expectedEven.ToList(), dictionary["even"]);
    }
    
}