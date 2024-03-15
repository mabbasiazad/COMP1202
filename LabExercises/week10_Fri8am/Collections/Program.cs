class Program
{
    public static void Main(string[] args)
    {
        // array = {13, 11, 9, 8, 3, 1}
        int[] myArray_1 = new int[]{13, 11, 9, 8, 3, 1};
       

        //second approach 
        int[] myArray_2 = {13, 11, 9, 8, 3, 1};

        //third approach
        int[] myArray_3 = new int[6];    //declare + create       
        myArray_3 = [1, 2, 3]; //assign

        // Console.WriteLine(myArray_1[0]);
        // Console.WriteLine(myArray_1[1]);
        // Console.WriteLine(myArray_1[2]);


        // print the elements by index
        for (int i = 0; i < myArray_1.Length; i++)
        {
            Console.Write(myArray_1[i] + " ");
        }

        Console.WriteLine();

        // print elements by their value
        foreach (var item in myArray_1)
        {
            Console.Write(item + " "); 
        }


    }
} // closing brace for the Program class
