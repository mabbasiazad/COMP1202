namespace week04;

public class Sum
{
    public static void Main(string[] args)
    {
        //write a code to calculate the sum of numbers between 0 to N
        const int LIMIT = 6;
        int sum = 0;
        int currentNumber = 0;
        Console.Write("sum = ");
        while (currentNumber <= LIMIT)
        {
            if (currentNumber == LIMIT) Console.Write(currentNumber + " = ");
            else Console.Write(currentNumber + " + ");
            sum += currentNumber;
            currentNumber++;
        }

        Console.Write(sum);

        //Console.WriteLine($"the sum of numbers between 0 to {LIMIT} is {sum}");
        //added to github from visual studio code
        Console.WriteLine();
        Console.WriteLine("the program is over");
        Console.ReadLine();
    }
}

