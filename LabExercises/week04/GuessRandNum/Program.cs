namespace week04;
public class GuessRand
{
    public static void Main(string[] args)
    {
        int randNum = new Random().Next(1, 10); 
        int userInput;
        const int numOfGuess = 10;
        int counter = 0;

        while (counter <= numOfGuess)
        {
            Console.WriteLine("Guess a number between 1 to 100");
            userInput = Convert.ToInt32(Console.ReadLine());
            counter ++;
            if (userInput == randNum) {
                Console.WriteLine($"Congradulation you won after {counter} try");
                break;
            }

            else {
                Console.WriteLine("Please try again");
            }
        }

        Console.WriteLine($"the true number was {randNum}");
    }


}