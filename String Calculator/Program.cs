namespace String_Calculator;

public class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add("10000,15,1000,1001"));
    }
}