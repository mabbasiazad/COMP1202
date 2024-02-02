namespace week04;

public class Sum
{
    public static void Main(string[] args)
    {
        //define N
        const int N = 3;

        //define sum = 0
        int sum = 0;

        Console.Write("sum = "); 
        //for loop sum = 0 + 1 ; sum = 0 + 1 + 2
        for (int i = 0; i <= N; i++)
        {
            if (i == N)
            {
                Console.Write(i + " = ");
            }
            else
            {
                Console.Write(i + " + ");
            }
            //sum = sum + i;
            sum += i;
        }

        Console.Write(sum);
    }
    
}