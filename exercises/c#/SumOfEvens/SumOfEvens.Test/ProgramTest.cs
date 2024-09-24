namespace SumOfEvens.Test;

public class ProgramTest
{
    [Theory] 
    // Arrenge
    [InlineData(6, new int[] { 2, 4 })]  
    [InlineData(30, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [InlineData(-14, new int[] { -10, 3, 5, -4, 7 })]
    [InlineData(0, new int[] { 1, 3, 5, 7, 9 })]
    [InlineData(0, new int[] { })]
    public void ShouldReturnSumOfEvens(int expected, int[] numbers)
    {
        // Act
        int sum = Program.SumOfEvens(numbers);
        
        // Asset
        Assert.Equal(expected, sum);
    }
}