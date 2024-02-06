namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(100);
            //Console.WriteLine("your random number is: ");
            //Console.WriteLine(randomNumber);
            //Guess a number - if the guess == randomNumber "Gongrats"
            //if guess is not true let the user enter a new number

            int guessCount = 0;

            while (true)
            {
                //1- I should ask the user to enter an input
                Console.WriteLine("Guess a number between 0 and 100");
                int guess = Convert.ToInt32(Console.ReadLine());

                guessCount++; 

                if (guess == randomNumber)
                {
                    Console.WriteLine($"Congradulations. You won!!");
                    Console.WriteLine($"It took you {guessCount} guesses");
                    break;
                }

                else if (guess < randomNumber) {
                    Console.WriteLine("please enter larger number");
                }

                else
                {
                    Console.WriteLine("please enter smaller number");
                }

                //2- I check the input == randomNumber (if)

                //3- else input !=randomNumber 

            }
        }
    }
}
