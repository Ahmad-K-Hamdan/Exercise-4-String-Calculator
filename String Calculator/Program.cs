namespace String_Calculator;

public class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add("512\n14\n10\n15,-500,-1,-2"));
    }
}