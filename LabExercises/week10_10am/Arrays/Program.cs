class Program
{
    public static void Main(string[] args)
    {
        //exercise 1: create this array and display it in the console
        //[12, 8, 7, 6, 27, 81, 92, 100]

        //1.declare
        int a; 
        //2. initialize / assign
        a = 12; 
        
        //approach 1
        //1.declare
        int[] myArray;        
        //2. creat + assign
        myArray = new int[8]{12, 8, 7, 6, 27, 81, 92, 100};      

        //approach 2
        int[] myArray_2 = new int[8] {12, 8, 7, 6, 27, 81, 92, 100};

        //approach 3 (preferred approach)
        int[] myArray_3 = {12, 8, 7, 6, 27, 81, 92, 100};
        
        string[] fruits = new string[3];
        fruits = new string[] {"apple", "orange", "banana"};

        //approach 4
        int[] myArray_4 = new int[8];
        myArray_4[0] = 12;
        myArray_4[1] = 8; 
        myArray_4[2] = 7;
        myArray_4[3] = 6; 
        myArray_4[4] = 27;
        myArray_4[5] = 81;
        myArray_4[6] = 92;
        myArray_4[7] = 100;  

        Console.WriteLine("element 0: " + myArray[0]);
        Console.WriteLine("element 1: " + myArray[1]);

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");             

        }

        Console.WriteLine();

        foreach (var item in myArray)
        {
            Console.Write(item + " ");
        }

    }
}
