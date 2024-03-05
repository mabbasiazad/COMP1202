class Program
{
    public static void Main(string[] args)
    {
        string s = "This is COMP1202 class";
        //index     0123456789 
        //1) Q: I want to get access to the 10th character of this string
        char ch = s[9]; 
        Console.WriteLine("The 10th character is: " + ch);

        //2) Q: I want the characters between 1st to 6th characters
        // first index is inclusive but the second index is exclusive 

        string sub_string = s[0..6];
        Console.WriteLine("The sub string is: " + sub_string);

        // 3) what is the index of 
        int index = s.IndexOf("M");
        Console.WriteLine("The index of M is: " + index);

        index = s.IndexOf("COMP");
        Console.WriteLine("The index of COMP is: " + index);

        index = s.IndexOf("W");
        Console.WriteLine("The index of W is: " + index);

        index = s.IndexOf("O", 11);
        



    }
}
