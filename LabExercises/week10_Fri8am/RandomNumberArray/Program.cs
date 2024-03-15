class Program
{
    public static void Main(string[] args)
    {
        //create an array of random numbers (between 0, 100) of size = 10
        Random rand = new Random();
        int a = rand.Next(0, 100); 
        Console.WriteLine(a);

        //array of size 10
        int[] array;   //declare
        array = new int[10];  //create

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 100);
            Console.Write(array[i] + " ");           
        }




    }
}