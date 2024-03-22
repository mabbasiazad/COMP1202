using System.Runtime.InteropServices;

class Program
{
    //creat an array of integer of size 100 and fill the array with random numbers between 0, 100
    
    public static double average(int[] arr) {
        double sum = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            sum = sum + arr[index];
            //sum += arr[index];
        }
        return (double) sum/arr.Length;
    }

    public static void changeArray(int[] arr) {
        arr[0] = 1000;
    }

    public static void print(int[] array){
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

    }
    public static void Main(string[] args)
    {
       Random rand = new Random(); 
       int a = rand.Next(0, 100);
       Console.WriteLine("the rand num is: " + a); 
    
        // type : int[]
       int[] randomNumArr = new int[100];

        for (int i = 0; i<randomNumArr.Length; i++){   
            randomNumArr[i] = rand.Next(0,100);
        }

        foreach (int element in randomNumArr)
        {
            Console.Write(element + " ");
        } 

        Console.WriteLine();

        
        double ave = average(randomNumArr);     
        Console.WriteLine("the average of 100 random number is: " + ave);

        int[] sampleArray = {1, 12, 5, 6};
        Console.WriteLine("the sample array before method call: ");
        print(sampleArray);

        changeArray(sampleArray);
        Console.WriteLine("the sample array after method call: ");
        print(sampleArray);

    }
}
