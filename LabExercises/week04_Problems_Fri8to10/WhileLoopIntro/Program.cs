namespace week04;

public class Sum
{
    public static void Main(string[] args)
    {
        //write a code to calculate the sum of numbers between 0 to N
            int N;
    N = 3;

    int currentNumber;
    currentNumber = 0;

    int sum;
    sum = 0;

    while (currentNumber <= N)
    {
        sum = sum + currentNumber;
        currentNumber = currentNumber + 1; 
    }

    Console.WriteLine("sum is equal to:" + sum);
    Console.ReadKey();
    }
}
