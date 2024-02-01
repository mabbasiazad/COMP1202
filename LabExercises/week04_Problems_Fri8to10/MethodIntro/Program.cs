namespace TempConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempC;
            tempC = 32;

            double tempF;
            tempF = (tempC * 9 / 5) + 32;

            Console.WriteLine($"{tempC} degree Celsius is eqaul to {tempF} degree Fahrenheit");
            Console.ReadKey();
        }
    }
}

