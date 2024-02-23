using System.ComponentModel.DataAnnotations;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        String s = "Comp1202ObjectOrientedProgramming";
        //index    "0123456789...."
        Console.WriteLine(s[0..5]); //prints out the substring from index 0 to 5
        

        int idx = 5;
        //print out the description of the letter to be printed by indexing
        Console.WriteLine("The letter at index " + idx + " is " + s[idx]);

        int sLength = s.Length; //returns the length of the string 
        Console.WriteLine("The length of the string is " + sLength);

        idx = s.IndexOf("o"); //returns the index of the first occurrence of the letter "O"
        Console.WriteLine("The index of the first occurrence of the letter 'O' is " + idx);

        idx = s.LastIndexOf("Object"); //returns the index of the last occurrence of the letter "O"   
        Console.WriteLine("The index of the last occurrence of the word 'Object' is " + idx);

        // start index included and end index excluded
        string sub = s.Substring(4, 8); //returns the substring starting from index 4 and ending at index 8
        Console.WriteLine("The substring starting from index 4 and ending at index 8 is " + sub);

        idx = s.IndexOf("x");
        if (idx == -1)
        {
            Console.WriteLine("The letter 'x' is not found in the string");
        }
        else
        {
            Console.WriteLine("The letter 'x' is found at index " + idx);
        }

        idx = s.IndexOf("O", 9); //returns the index of the first occurrence of the letter "O" after index 9
        Console.WriteLine("The index of the first occurrence of the letter 'O' after index 9 is " + idx);


    }
}

