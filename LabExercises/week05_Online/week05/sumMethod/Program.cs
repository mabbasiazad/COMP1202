namespace sumMethod
{
    internal class Program
    {
        static double average(int a, int b, int c)
        {
            double result;
            result = (double) (a + b + c) / 3;
            return result;  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int number_1 = 12;
            int number_2 = 13;
            int number_3 = 21;

            double result;
            result = average(number_1, number_2, number_3);

            Console.WriteLine($"the average of {number_1}, {number_2}, and {number_3} is : {result:F2}");


        }
    }
}
