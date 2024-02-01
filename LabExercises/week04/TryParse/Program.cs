namespace week04.TryParse;

class Program {
    public static void Main(string[] args)
    {
        string inputString; 
        inputString = Console.ReadLine();
        int integerValue; 
        bool success = int.TryParse(inputString, out integerValue);
        if (success == true)
        {
            Console.WriteLine($"Conversion of  '{inputString}' to {integerValue} was a success");
        }
        else
        {
            Console.WriteLine("Invalid input - 0 recorded for 'integerValue'");
        }
    }
}
