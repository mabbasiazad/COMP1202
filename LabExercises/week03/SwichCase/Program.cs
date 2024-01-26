using System.ComponentModel;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number between 1 to 10");
            string inValue = Console.ReadLine();

            int number;
            string romanStyle;
            romanStyle = " ";
            
            int.TryParse(inValue, out number);

            switch (number)
            {
                case 1:
                    romanStyle ="I";
                    break;
                case 2:
                    romanStyle ="II";
                    break;
                case 3:
                    romanStyle ="III";
                    break;
                case 4:
                    romanStyle ="IV";
                    break;
                case 5:
                    romanStyle ="V";
                    break;
                case 6:
                    romanStyle ="VI";
                    break;

                case 7:
                    romanStyle ="VII";
                    break;
                case 8:
                    romanStyle ="VIII";
                    break;
                case 9:
                    romanStyle ="IX";
                    break;

                case 10:
                    romanStyle ="X";
                    break;
                default:
                  Console.WriteLine("Error: Value must be between 1 to 10");
                  break;
            }
            Console.WriteLine($"the roman style is: {romanStyle}");
        }
    }
}

