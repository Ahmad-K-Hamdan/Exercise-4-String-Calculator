
namespace String_Calculator;

public class Calculator
{
    private const int BigNumbers = 1000;
    
    public int Add(string numbers)
    {
        if (numbers.Trim().Length == 0)
        {
            return 0;
        }

        var ints = ParseStringToListOfIntegers(numbers);
        CatchNegativeNumbers(ints);
        ints = IgnoreBigNumbers(ints);

        return ints.Sum();
    }

    private List<int> ParseStringToListOfIntegers(string numbers)
    {
        string newString = "";
        foreach (var c in numbers)
        {
            if (char.IsDigit(c) || c == '-')
            {
                newString += c;
            }
            else
            {
                newString += " ";
            }
        }

        var nums = newString.Trim().Split(' ');
        return nums.Select(num => int.Parse(num)).ToList();
    }

    private void CatchNegativeNumbers(List<int> ints)
    {
        var NegativeNumbers = ints.Where(num => num < 0);

        if (NegativeNumbers.Any())
        {
            throw new ArgumentException($"negatives not allowed: {string.Join(", ", NegativeNumbers)}");
        }
    }

    private List<int> IgnoreBigNumbers(List<int> ints)
    {
        return ints.Where(num => num <= BigNumbers).ToList();
    }
}
