using Xunit;

public class CalculatorTest
{
    [Fact]
    public void TestAddMethod()
    {
        var instancedCalculator = new Calculator();

        int result = instancedCalculator.Add(1, 3);

        Assert.Equal(4, result);


        // Calculator instancedCalculator = new();

        // int a = 1;
        // int b = 1;
        // int expected = 2;

        // int actual = instancedCalculator.Add(a, b);

        // Assert.Equal(expected, actual);
    }
}