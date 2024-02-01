namespace week04;
class ValidInput {
    public static void Main(string[] args)
    {
        int cleanNumber; 
        string numInput; 

        Console.WriteLine("enter an integer number between 0 to 100: "); 
        numInput = Console.ReadLine(); 

        bool success = int.TryParse(numInput, out cleanNumber);

        while(success == false || cleanNumber < 0 || cleanNumber > 100) {
            Console.WriteLine("invalid input - re enter your integer number between 0 to 100: "); 
            numInput = Console.ReadLine();
            success =  int.TryParse(numInput, out cleanNumber);
        }

        Console.WriteLine("valid value entered = " + cleanNumber);

        Console.ReadKey(); 


    }
}
 