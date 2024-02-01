namespace week04;
public class ForLoop
{
    public static void Main(string[] args)
    {
        int N = 8;
        for (int i = 0; i < N; i++)
        {
            Console.Write(Math.Pow(i, 2) + " ");
        }

        Console.ReadKey();
    }
}
