using String_Calculator;

namespace String_Calculator_Tests;

public class CalculatorTests
{
    Calculator _calculator = new Calculator();

    [Theory]
    [InlineData("", 0)]
    [InlineData("1", 1)]
    [InlineData("1,0", 1)]
    [InlineData("1,1", 2)]
    [InlineData("1,2,3,4,5", 15)]
    [InlineData("1\n2,3,4\n5", 15)]
    [InlineData("//;\n1;2\n3\n4;5", 15)]
    [InlineData("1001,2", 2)]
    public void Add_WhenValidInputs_ShouldReturnExpectedResult(string inputValue, int expectedResult)
    {
        // Act
        var answer = _calculator.Add(inputValue);

        // Assert                                    
        Assert.Equal(expectedResult, answer);
    }

    [Fact]
    public void Add_NegativeNumbers_ThrowAnArgumentException()
    {
        // Arrange and Act
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("1,2,-3,4,-5"));

        // Assert
        Assert.Equal("negatives not allowed: -3, -5", ex.Message);
    }
}