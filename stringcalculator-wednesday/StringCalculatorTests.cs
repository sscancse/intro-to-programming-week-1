
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("5", 5)]
    [InlineData("101", 101)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4", 7)]
    [InlineData("6,2", 8)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("7,10,8", 25)]
    [InlineData("1,2,6,4,9", 22)]
    public void UnknownNumberOfDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n52,6\n2", 61)]
    [InlineData("3\n6\n1", 10)]
    [InlineData("41,3,3\n17", 64)]
    public void NewLineDelimiter(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1,4,4\n18;3\n1;1", 32)]
    [InlineData("//-\n3-4-5,2", 14)]
    public void DefineAdditionalDelimiter(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    /*
    [Theory]
    [InlineData("//;\n2;5,-8", )]
    [InlineData("6,7\n-1,-2,10", )]
    public void ThrowExceptionOnNegative(string numbers, Exception expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    */
}
