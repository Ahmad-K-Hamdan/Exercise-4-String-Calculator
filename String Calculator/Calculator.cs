namespace String_Calculator;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers.Trim().Length == 0)
        {
            return 0;
        }

        var ints = ParseStringToListOfIntegers(numbers);
        
        return ints.Sum();
    }

    public List<int> ParseStringToListOfIntegers(string numbers)
    {
        var nums = numbers.Split(',');
        return nums.Select(num => int.Parse(num)).ToList();
    }
}
