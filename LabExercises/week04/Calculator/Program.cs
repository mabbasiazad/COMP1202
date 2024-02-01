namespace week04; 

public class Calculator
{
    
    public static void Main(string[] args)
    {
        // Declare variables and then initialize to zero.
    string numInput1 = ""; 
    string numInput2 = "";
    double cleanNum1 = 0; 
    double cleanNum2 = 0; 

    // Display title as the C# console calculator app.
    Console.WriteLine("Console Calculator in C#\r");
    Console.WriteLine("------------------------\n");

    // Ask the user to type the first number.
    Console.WriteLine("Type a number, and then press Enter");

    numInput1 = Console.ReadLine();

    while (double.TryParse(numInput1, out cleanNum1) == false)
    {
        Console.WriteLine("this is not a valid input. Please re-enter your number");
        numInput1 = Console.ReadLine();
    }


    // Ask the user to type the second number.
    Console.WriteLine("Type another number, and then press Enter");
    numInput2 = Console.ReadLine();

    while (double.TryParse(numInput2, out cleanNum2) == false)
    {
        Console.WriteLine("this is not a valid input. Please re-enter your number");
        numInput2 = Console.ReadLine();
    }

    // Ask the user to choose an option.
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Subtract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.Write("Your option? ");

    string op = Console.ReadLine();
    // Use a switch statement to do the math.
    switch (op)
    {
        case "a":
            Console.WriteLine($"Your result: {cleanNum1} + {cleanNum2} = " + (cleanNum1 + cleanNum2));
            break;
        case "s":
            Console.WriteLine($"Your result: {cleanNum1} - {cleanNum2} = " + (cleanNum1 - cleanNum2));
            break;
        case "m":
            Console.WriteLine($"Your result: {cleanNum1} * {cleanNum2} = " + (cleanNum1 * cleanNum2));
            break;
        case "d":
            while (cleanNum2 == 0)
            {
                Console.WriteLine("Enter a non-zero devisor");
                numInput2 = Console.ReadLine();

                while (double.TryParse(numInput2, out cleanNum2) == false)
                {
                    Console.WriteLine("this is not a valid input. Please re-enter your number");
                    numInput2 = Console.ReadLine();
                }
            }
            Console.WriteLine($"Your result: {cleanNum1} / {cleanNum2} = " + (cleanNum1 / cleanNum2));
            break;
    }
    // Wait for the user to respond before closing.
    Console.Write("Press any key to close the Calculator console app...");
    Console.ReadKey();        
    }
}
