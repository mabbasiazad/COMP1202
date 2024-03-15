class Program
{
    public double average(int[] array) {
        //your code here : sum / count
        int sum = 0;
        foreach (var item in array)
        {
            sum = sum + item;
            // sum += item
        }

        return (double) sum / array.Length;

    }
    public static void Main(string[] args)
    {
        //create an array of size 10 of random numbers between 0, 100
        Random rand = new Random();  //creat an object of rand
        
        int[] randArray = new int[10];

        for (int i = 0; i < randArray.Length; i++)
        {
            randArray[i] = rand.Next(0, 100); 
            Console.Write(randArray[i] + " ");    
        }

        randArray = new int[]{12, 8, 7, 6, 27, 81, 92, 100};
        
        // this is for non-static average
        Program obj = new Program();
        double ave = obj.average(randArray);
        //ave = 41.6
        Console.WriteLine();
        Console.WriteLine("the average of the elements in the array is: " + ave);

    }
}