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

        // Join the list of strings (nums) to create a string
        // Split the new string based on \n
        var newString = String.Join(' ', nums);
        nums = newString.Split('\n');

        // Join the list of strings (nums) to create a string
        // Split the new string based on ' ' space to get the final list
        newString = String.Join(' ', nums);
        nums = newString.Split(' ');

        return nums.Select(num => int.Parse(num)).ToList();
    }
}
