namespace method_example
{
    internal class Program
    {
        static double tempConversion(double inputC, double inputK)
        {
            double output = (inputC * 9 / 5) + 32;
            return output;
        }
        static void Main(string[] args)
        {
            double tempC; //declare
            tempC = 32; //assign

            double tempF;
            //tempF = (tempC * 9 / 5) + 32; 
            tempF = tempConversion(tempC, 0); //pass tempC as the input/paramenter/argument

            Console.WriteLine($"the {tempC} in Celsius is equal to {tempF:F2} in Fahrenheit");

            tempC = 45; //
            double tempK = 32;
            //tempF = (tempC * 9 / 5) + 32; //conversion formula
            tempF = tempConversion(tempC, tempK);
            Console.WriteLine($"the {tempC} in Celsius is equal to {tempF:F2} in Fahrenheit");
        }
    }
}
