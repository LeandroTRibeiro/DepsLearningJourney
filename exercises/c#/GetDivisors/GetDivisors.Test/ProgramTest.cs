namespace GetDivisors.Test;

public class ProgramTest
{
    [Theory]
    // Arrange
    [InlineData(new int[] { 1, 2, 4, 7, 14, 28 }, 28)]
    [InlineData(new int[] { 1 }, 1)]  
    [InlineData(new int[] { 1, 2 }, 2)]  
    [InlineData(new int[] { 1, 3 }, 3)]  
    [InlineData(new int[] { 1, 2, 4, 8 }, 8)]  
    [InlineData(new int[] { 1, 5 }, 5)]  
    [InlineData(new int[] { 1, 2, 4, 8, 16, 32, 64 }, 64)]  
    [InlineData(new int[] { 1, 7, 49 }, 49)]  
    [InlineData(new int[] { 1, 3, 9, 27 }, 27)]  
    [InlineData(new int[] { 1, 2, 3, 6, 11, 22, 33, 66 }, 66)]  
    [InlineData(new int[] { 1, 97 }, 97)]  
    public void ShouldReturnTheDivirsors(int[] expected, int number)
    {
        // Act
        IEnumerable<int> response = Program.GetDivisors(number);
       
        // Assert
        Assert.Equal(expected, response);
    }

    [Theory]
    // Arrange
    [InlineData(null)]
    [InlineData(0)]
    [InlineData(-10)]
    public void ShouldThrowExceptionWhenNumberIsInvalid(int number)
    {
        // Act
        var exeption = Assert.Throws<ArgumentException>(() => Program.GetDivisors(number));
        
        // Assert
        Assert.Equal("Deve ser um numero maior que zero.", exeption.Message);
    }
}