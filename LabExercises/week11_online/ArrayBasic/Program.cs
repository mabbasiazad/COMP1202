class Program
{
    public static void Main(string[] args)
    {
        int a = 5; 
        //first approach (everyting for array definition in one line)
        int[] numbers = new int[4]{11, 12, 13, 14};
        // access operator for arrays are by index
        //display the second element of the array
        Console.WriteLine("the second element of the array is: " + numbers[1]);

        // 11 12 13 14
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write(numbers[index] + " ");
            //Console.Write("Element at index " + index + " is: " + numbers[index]);
        }

        Console.WriteLine();

        foreach (var item in numbers)
        {
            Console.Write(item + " ");   
        }

        Console.WriteLine();

        // second approach:  creat first and assing later
        //break it down to different step
        //1. creat the array of string of size 3
        string[] fruits = new string[3]; //declare and creat
        
        //assign
        fruits[0] = "apple";
        fruits[1] = "banana"; 
        fruits[2] = "tomato";

        // iteration over the elements of array
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.Write(fruits[i] + " ");
        }

        Console.WriteLine();

        // simplest approach
        double[] numbers_2 = {1.2, 3.2, 6.8, 6.7};
        foreach (var item in numbers_2)
        {
            Console.Write(item + " ");
        }




    }
}
