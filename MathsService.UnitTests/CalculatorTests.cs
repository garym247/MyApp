namespace MyApp.MathsService.UnitTests;

using MyApp.MathsService;

public class CalculatorTests
{
    [Fact]
    public void IsEven_ShouldReturnTrue()
    {
        var calculator = new Calculator();

        Assert.True(calculator.IsEven(2), "2 should be even");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(11)]
    [InlineData(101)]
    public void IsEven_ShouldReturnFalse(int value)
    {
        var calculator = new Calculator();

        Assert.False(calculator.IsEven(value), $"{value} should not be even");
    }

    [Fact]
    public void IsEven_ShouldThrowArgumentException()
    {
        var calculator = new Calculator();

        var ex = Assert.Throws<ArgumentException>(() => calculator.IsEven(-1));

        Assert.Equal("Argument -1 is less than zero.", ex.Message);
    }
}