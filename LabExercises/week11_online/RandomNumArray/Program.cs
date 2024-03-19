class Program
{
    //creat an array of integer of size 100 and fill the array with random numbers between 0, 100
    public static void Main(string[] args)
    {
       Random rand = new Random(); 
       int a = rand.Next(0, 100);
       Console.WriteLine("the rand num is: " + a); 

       int[] randomNumArr = new int[100];

    for (int i = 0; i<randomNumArr.Length; i++){   
        randomNumArr[i] = rand.Next(0,100);
    }

    foreach (int element in randomNumArr)
    {
        Console.Write(element + " ");
    }

       

    }
}
