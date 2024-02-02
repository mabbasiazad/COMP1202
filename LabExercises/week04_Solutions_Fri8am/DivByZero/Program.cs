namespace Divide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables a, b
            Console.WriteLine("enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            int b = int.Parse(Console.ReadLine());
            //calculate result = a / b
            
            //print the result

            //check if b == 0 then prompts the user 
            //they have entered invalid input for b
            //ask them to a enter an non-zero number for b
            while (b == 0 || b > 100)
            {
                Console.WriteLine("you have entered an invalid number for b");
                Console.WriteLine("enter a non-zer number for b which is less than 100"); 
                b = int.Parse(Console.ReadLine());
            }

            double result = (double)a / b;

            Console.WriteLine($"the result of {a} /{b} = {result:F2}");
        }
    }
}

