namespace TempConversion
{
    internal class Program
    {
        static double tempCelToFahr(double tempCel)
        {
            double result = (tempCel * 9 / 5) + 32;
            return result;  
        }
        static void Main(string[] args)
        {
            double tempC;
            tempC = 32;

            double tempF;
            tempF = tempCelToFahr(tempC);

            Console.WriteLine($"{tempC} degree Celsius is eqaul to {tempF} degree Fahrenheit");
            Console.ReadKey();
        }
    }
}
