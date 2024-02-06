namespace example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string response;
            while(true)
            {
                Console.WriteLine(counter);
                Console.WriteLine("do you want to continue? (yes / no)");
                response = Console.ReadLine();
                if (response == "no")
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine("the end of the program");
        }
    }
}
