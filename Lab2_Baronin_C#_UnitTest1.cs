namespace Lab2_Baronin.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("level", true)]
    [InlineData("hello", false)]
    [InlineData("radar", true)]
    [InlineData("test", false)]
    public void IsPalindrome_ShouldReturnExpectedResult(string text, bool expected)
    {
        // Act
        bool result = Utility.IsPalindrome(text);

        // Assert
        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData(12345, 15)]
    [InlineData(507, 12)]
    [InlineData(9, 9)]
    [InlineData(100, 1)]
    [InlineData(120, 3)]
    public void SumOfDigits_ShouldReturnExpectedSum(int number, int expected)
    {
        // Act
        int result = Utility.SumOfDigits(number);

        // Assert
        Assert.Equal(expected, result);
    }
}
