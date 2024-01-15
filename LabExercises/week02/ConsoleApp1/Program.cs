using System;
namespace week02.ConsoleApp1; 
public class Program
{
    public static void Main(string[] args)
    {
        double temperatureC = 32.1;
        double temeratureF;
        temeratureF = (temperatureC * 9 / 5) + 32;
        Console.WriteLine($"the temperature {temperatureC} \u00B0C is equal to {temeratureF: 0.00} degreeF");
        Console.ReadKey(); 
    }
}