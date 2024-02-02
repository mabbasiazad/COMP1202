namespace MethodIntro
{
    internal class Program
    {
        static double tempConversion(double input)
        {
            double output;
            output = (input * 9 / 5) + 32;
            return output;
        }
        
        static void Main(string[] args)
        {
            double tempC = 32;
            double tempF;

            tempF = tempConversion(tempC);  //calling a function //pass an input 

            Console.WriteLine($"the {tempC} Celsius is equal to {tempF:F2} Fahrenheir");

            tempC = 45;
            tempF = tempConversion(tempC);
            Console.WriteLine($"the {tempC} Celsius is equal to {tempF:F2} Fahrenheir");

        }
    }
}
