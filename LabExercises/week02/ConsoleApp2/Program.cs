namespace week02.ConsoleApp2;
internal class Program
    {
        static double milesToFeet(double miles)
        {
            return miles * 5280;
        }

        static void Main()
        {
            // Declare and initialize miles to 4.5
            double miles = 4.5;

            // Convert miles to feet and kilometers
            double feet = milesToFeet(miles);
            double kilometers = miles * 1.60934;

            // Display the values with the specified formatting
            Console.WriteLine("Miles: {0,10:F2}", miles); //,10 is width specifier +10 is right aligned -10 is left aligned
            Console.WriteLine("Feet: {0:N0}", feet); // The N0 format specifier display them with comma separators and no decimal positions
            Console.WriteLine("Kilometers: {0,10:F2}", kilometers);

            // Change the initialization value for miles
            miles = 7.8;

            // Recalculate feet and kilometers
            feet = milesToFeet(miles);
            kilometers = miles * 1.60934;

            // Display the updated values with the same formatting
            Console.WriteLine($"\nUpdated Miles: {miles,6:F2}");
            Console.WriteLine("Updated Feet: {0:N0}", feet);
            Console.WriteLine("Updated Kilometers: {0,6:F2}", kilometers);
        }
    }
