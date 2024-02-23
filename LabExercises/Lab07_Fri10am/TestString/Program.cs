class Program
{
    public static void Main(string[] args)
    {
        string s = "COMP1202 Object-Oriented Programming";
        //index     0123456789...
        System.Console.WriteLine("Original String: " + s);

        // 1- access by indexing
        char letter = s[3]; 
        System.Console.WriteLine("Character at index 3: " + letter);

        // 2- substring
        string sub_string = s[1..7];
        System.Console.WriteLine("Substring from index 1 (included) to 7 (exluded): " + sub_string);

        // 3- indexOf()
        int index = s.IndexOf("M");
        System.Console.WriteLine("Index of the first occurrence of 'M': " + index);

        index = s.IndexOf("Object"); //????
        System.Console.WriteLine("Index of the first occurrence of 'Object': " + index);

        // 4- length of the strign
        Console.WriteLine("Length of the string: " + s.Length);



    }
}
