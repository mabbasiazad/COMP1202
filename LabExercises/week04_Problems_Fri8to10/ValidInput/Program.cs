namespace week04;
class ValidInput {
    public static void Main(string[] args)
    {
        int cleanNumber; 
        string numInput; 

        Console.WriteLine("enter an integer number between 0 to 100: "); 
        numInput = Console.ReadLine(); 

        bool conversion_state;
        conversion_state = int.TryParse(numInput, out cleanNumber);

        if (conversion_state == false) {
            Console.WriteLine("you have entered invalid input");
            Console.WriteLine("please re-enter your input"); 
            numInput = Console.ReadLine();
            int.TryParse(numInput, out cleanNumber);
        }
        //your code here

        Console.WriteLine("valid value entered = " + cleanNumber);


    }
}
 
 
