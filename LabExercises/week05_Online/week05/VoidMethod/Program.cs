using System.ComponentModel.DataAnnotations;

namespace VoidMethod
{
    internal class Program
    {
        static void greeting()
        {
            Console.WriteLine("Hi How're you?");
        }
        static void display(string message)
        {
            Console.WriteLine(message); 
        }
        static void Main(string[] args)
        {
            string msg = "Hi this is a function display";
            display(msg);
            greeting();
        }
    }
}
