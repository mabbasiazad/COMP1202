class Program
{
    public static void Main(string[] args)
    {
        string s = "COMP1202ObjectOrientedProgramming";
        // index    0123456789...
        Console.WriteLine(s); 
        Console.WriteLine("the third element of the string is: " + s[2]);

        int index = s.IndexOf("P");
        Console.WriteLine("The first index of P is: " + index);

        index = s.IndexOf("P", 4);
        Console.WriteLine("The first index of P after index 4 is: " + index);

        index = s.IndexOf("Object");
        Console.WriteLine("The first index of Object is: " + index);

        //the first element is included, second element is excluded
        string sub = s[2..10]; 
        Console.WriteLine("The substring from index 2 to 9 is: " + sub);



    }
}
