using String_Calculator;

namespace String_Calculator_Tests;

public class CalculatorTests
{
    Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ZeroNumbers_ReturnZero()
    {
        // Act
        var answer = _calculator.Add("");

        // Assert
        Assert.Equal(0, answer);
    }

    [Fact]
    public void Add_OneNumber_ReturnSameNumber()
    {
        // Act
        var answer = _calculator.Add("1");

        // Assert
        Assert.Equal(1, answer);
    }

    [Fact]
    public void Add_OneNumberAndZero_ReturnSameNumber()
    {
        // Act
        var answer = _calculator.Add("1,0");

        // Assert
        Assert.Equal(1, answer);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnTheirSum()
    {
        // Act
        var answer = _calculator.Add("1,1");

        // Assert
        Assert.Equal(2, answer);
    }

    [Fact]
    public void Add_MoreThanTwoNumbers_ReturnTheirSum()
    {
        // Act
        var answer = _calculator.Add("1,2,3,4,5");

        // Assert
        Assert.Equal(15, answer);
    }

    [Fact]
    public void Add_WithNewLines_ReturnTheirSum()
    {
        // Act
        var answer = _calculator.Add("1\n2,3,4\n5");

        // Assert
        Assert.Equal(15, answer);
    }

    [Fact]
    public void Add_WithAnyTypeOfDelimiters_ReturnTheirSum()
    {
        // Act
        var answer = _calculator.Add("//;\n1;2\n3\n4;5");

        // Assert
        Assert.Equal(15, answer);
    }

    [Fact]
    public void Add_NegativeNumbers_ThrowAnArgumentException()
    {
        // Arrange and Act
        var ex = Assert.Throws<ArgumentException>(() => _calculator.Add("1,2,-3,4,-5"));

        // Assert
        Assert.Equal("negatives not allowed: -3, -5", ex.Message);
    }

    [Fact]
    public void Add_BigNumbers_AreIgnored()
    {
        // Act
        var answer = _calculator.Add("1001,2");

        // Assert
        Assert.Equal(2, answer);
    }
}