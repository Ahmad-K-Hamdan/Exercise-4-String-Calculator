namespace String_Calculator;

public class Calculator
{
    public int Add(String numbers)
    {
        if (numbers.Trim().Length == 0)
        {
            return 0;
        }

        var IndexOfFirstComma = numbers.IndexOf(',');
        if (IndexOfFirstComma == -1)
        {
            return int.Parse(numbers);
        }

        var FirstNumber = int.Parse(numbers.Substring(0, IndexOfFirstComma));

        var StringAfterComma = numbers.Substring(IndexOfFirstComma);
        if (StringAfterComma.Length < 1)
        {
            return FirstNumber;
        }

        var SecondNumber = int.Parse(numbers.Substring(numbers.IndexOf(',') + 1));

        return FirstNumber + SecondNumber;
    }
}
