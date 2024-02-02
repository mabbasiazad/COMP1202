namespace ForLoopIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine(Math.Pow(i, 2) + " ");
            }
        }
    }
}
