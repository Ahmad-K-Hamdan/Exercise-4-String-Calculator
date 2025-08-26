using String_Calculator;
using Xunit;

namespace String_Calculator_Tests;

public class CalculatorTests
{
    Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ZeroNumbers_ReturnZero()
    {
        // Assert
        var answer = _calculator.Add("");

        // Act
        Assert.Equal(0, answer);
    }

    [Fact]
    public void Add_OneNumber_ReturnSameNumber()
    {
        // Assert
        var answer = _calculator.Add("1");

        // Act
        Assert.Equal(1, answer);
    }

    [Fact]
    public void Add_OneNumberAndZero_ReturnSameNumber()
    {
        // Assert
        var answer = _calculator.Add("1,0");

        // Act
        Assert.Equal(1, answer);
    }

    [Fact]
    public void Add_TwoNumbers_ReturnTheirAddition()
    {
        // Assert
        var answer = _calculator.Add("1,1");

        // Act
        Assert.Equal(2, answer);
    }

    [Fact]
    public void Add_MoreThanTwoNumbers_ReturnTheirAddition()
    {
        // Assert
        var answer = _calculator.Add("1,2,3,4,5");

        // Act
        Assert.Equal(15, answer);
    }

    [Fact]
    public void Add_HandleNewLines_ReturnTheirAddition()
    {
        // Assert
        var answer = _calculator.Add("1\n2,3,4\n5");

        // Act
        Assert.Equal(15, answer);
    }

    [Fact]
    public void Add_HandleAllTypesOfDelimters_ReturnTheirAddition()
    {
        // Assert
        var answer = _calculator.Add("//;\n1;2\n3\n4;5");

        // Act
        Assert.Equal(15, answer);
    }
}