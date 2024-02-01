namespace week04;
public class Divid
{
    public static void Main(string[] args)
    {
        string inputA;
        string inputB;
        Console.WriteLine("please enter the first number");
        inputA = Console.ReadLine();

        Console.WriteLine("please enter the second input"); 
        inputB = Console.ReadLine(); 

        double a;
        double b; 

        a = double.Parse(inputA); 
        b = double.Parse(inputB);

        while (b == 0) {   //the input 0 for b is not valid because a / 0 is not defined in math
            Console.WriteLine("the second number cannot be zero");
            Console.WriteLine("Re-ente a non-zero number");
            inputB = Console.ReadLine();
            b = double.Parse(inputB);
        }

        double result; 
        result = a / b;

        Console.WriteLine($"the result of {a} / {b} is: {result}");
    }
}
