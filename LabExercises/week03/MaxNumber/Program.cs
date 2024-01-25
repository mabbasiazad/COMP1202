using System;
namespace MaxNumberProgram;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter the 1st number");
        string fristInValue = Console.ReadLine();

        Console.WriteLine("enter the 2nd number");
        string secondInValue = Console.ReadLine();

        double numberA = double.Parse(fristInValue); 
        double numberB = double.Parse(secondInValue);

        double maxNumber = numberA;
        if (numberB > numberA) maxNumber = numberB;            

        Console.WriteLine($"the max number if {maxNumber}");
        
    }
}