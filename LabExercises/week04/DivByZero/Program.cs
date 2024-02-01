namespace week04; 
public class DivByZero
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please enter the value for a");
        string inputA = Console.ReadLine();
        Console.WriteLine("please enter the value for b");
        string inputB = Console.ReadLine();

        double a = double.Parse(inputA); 
        double b = double.Parse(inputB);
        double result = 0;

        while (b == 0)
        {
            Console.WriteLine("please enter non-zero value for b"); 
            inputB = Console.ReadLine();
            b = double.Parse(inputB);
        }

        result = a / b;
        Console.WriteLine($"{a} divided by {b} ({inputA} / {inputB}) is equal to {result}");

    }
}
