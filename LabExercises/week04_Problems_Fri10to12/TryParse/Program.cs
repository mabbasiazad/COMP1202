namespace week04.TryParse;

class Program {
    public static void Main(string[] args)
    {
        string inputString; 
        Console.WriteLine("enter an integer number");
        inputString = Console.ReadLine();
        int integerValue; 
        
        integerValue = int.Parse("123");
        

        //integerValue = int.Parse(inputString);

        Console.WriteLine("Type onversion was successful");
        Console.WriteLine($"Number you entred: {integerValue}");

        //run your code and see the result when you enter an invalid number
        //now use int.TryParse() method instead of int.Parse() 

    }
}
